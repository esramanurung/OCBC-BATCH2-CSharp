using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;
        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        //Get : api/user
        [HttpGet(Name = "Get Movie")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            // retirm new string[]
            return _context.GetAllMovie();
        }

        //Get : api/user/{id}
        [HttpGet("{id}", Name = "Get Where MovieItem")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        [HttpPost]
        public String InsertDataMovie(MovieItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;

            return _context.InsertDataMovie(data);
        }

        [HttpPut]
        public String UpdateDataMovie(MovieItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;

            return _context.UpdateDataMovie(data);
        }

        [HttpDelete("{id}")]
        public String DeleteDataMovie(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;

            return _context.DeleteDataMovie(id);
        }
    }

}
