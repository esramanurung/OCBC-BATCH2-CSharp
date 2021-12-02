using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin1
{
    public partial class FormLogin : Form
    {
        Config db = new Config();
        public FormLogin()
        {
            db.Connect("userdata");
            InitializeComponent();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            db.ExecutableSelect("SELECT * FROM user_info where username='" + inputUsernameLog.Text + "' and password='" + inputPasswordLog.Text + "'");
            if (db.Count() == 1)
            {
                MessageBox.Show("Sukses! Anda masuk sebagai " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Kombinasi user dan password salah!");
            }
        }

        private void bntExit1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bntRegis1_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
        }
    }
}
