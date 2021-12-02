using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TodoAppWithJWT.Configuration;
using TodoAppWithJWT.Models.DTOs.Requests;
using TodoAppWithJWT.Models.DTOs.Responses;
using System;
using System.Collections.Generic;

namespace TodoAppWithJWT.Controllers
{
    [Route("api/[controller]")] // api/authmanagement

    [ApiController]

    public class AuthManagementController : ControllerBase

    {

        private readonly UserManager<IdentityUser> _userManager;

        private readonly JwtConfig _jwtConfig;

        public AuthManagementController(

                UserManager<IdentityUser> userManager,

                IOptionsMonitor<JwtConfig> optionsMonitor)

        {

            _userManager = userManager;

            _jwtConfig = optionsMonitor.CurrentValue;

        }

        

        [HttpPost]

        [Route("Register")]

        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)

        {

            //  Check that the incoming request is valid 

            if (ModelState.IsValid)

            {

                //  Check the existence of users using the same e-mail 

                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser != null)

                {

                    return BadRequest(new RegistrationResponse()

                    {

                        Errors = new List<string>()

                    {

                        "Email already in use"

                    },

                        Success = false

                    });

                }

                var newUser = new IdentityUser() { Email = user.Email, UserName = user.Username };

                var isCreated = await _userManager.CreateAsync(newUser, user.Password);

                if (isCreated.Succeeded)

                {

                    var jwtToken = GenerateJwtToken(newUser);

                    return Ok(new RegistrationResponse()

                    {

                        Success = true,

                        Token = jwtToken

                    });

                }

                else

                {

                    return BadRequest(new RegistrationResponse()

                    {

                        Errors = isCreated.Errors.Select(x => x.Description).ToList(),

                        Success = false

                    });

                }

            }

            return BadRequest(new RegistrationResponse()

            {

                Errors = new List<string>()

            {

                "Invalid payload"

            },

                Success = false

            });

        }

        private string GenerateJwtToken(IdentityUser user)

        {

            // Now? , It's time to define  jwt token  了 , It will be responsible for creating our  tokens

            var jwtTokenHandler = new JwtSecurityTokenHandler();

            //  from  appsettings  Get our  secret

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            //  Define our  token descriptor

            //  We need to use  claims （token  Properties in ） Give out about  token  Information about , They belong to specific users ,

            //  therefore , Can contain the user's  Id、 name 、 Mailbox, etc .

            //  The good news is , This information is provided by our server and  Identity framework  Generate , They are effective and credible .

            var tokenDescriptor = new SecurityTokenDescriptor

            {

                Subject = new ClaimsIdentity(new[]

                {

                new Claim("Id", user.Id),

                new Claim(JwtRegisteredClaimNames.Email, user.Email),

                new Claim(JwtRegisteredClaimNames.Sub, user.Email),

                // Jti  Used to refresh  token, We'll talk about it in the next article 

                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            }),

                // token  We need to shorten the expiration time of , And make use of  refresh token  To maintain the user's login status ,

                Expires = DateTime.UtcNow.AddHours(6),

                //  Here we add encryption algorithm information , For encrypting our  token

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);

            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;

        }

        //then , We need to be in AuthManagementController Add Login Method ：

        [HttpPost]

        [Route("Login")]

        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)

        {

            if (ModelState.IsValid)

            {

                //  Check the existence of users using the same e-mail 

                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser == null)

                {

                    //  For safety reasons , We don't want to reveal too much about the request failure 

                    return BadRequest(new RegistrationResponse()

                    {

                        Errors = new List<string>()

                {

                    "Invalid login request"

                },

                        Success = false

                    });

                }

                //  Now we need to check that the user has entered the correct password 

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

                if (!isCorrect)

                {

                    //  For safety reasons , We don't want to reveal too much about the request failure 

                    return BadRequest(new RegistrationResponse()

                    {

                        Errors = new List<string>()

                {

                    "Invalid login request"

                },

                        Success = false

                    });

                }

                var jwtToken = GenerateJwtToken(existingUser);

                return Ok(new RegistrationResponse()

                {

                    Success = true,

                    Token = jwtToken

                });

            }

            return BadRequest(new RegistrationResponse()

            {

                Errors = new List<string>()

        {

            "Invalid payload"

        },

                Success = false

            });

        }


    }


}