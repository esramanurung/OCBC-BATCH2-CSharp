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
    public partial class FormRegister : Form
    {
        Config db = new Config();
        public FormRegister()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReg2_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO user_info(names,username,password) VALUES('" + textBoxReg1.Text + "','" + textBoxReg2.Text + "','" + textBoxReg3.Text + "');");
        }

        private void btnLog2_Click(object sender, EventArgs e)
        {
            FormLogin form1 = new FormLogin();
            form1.Show();
        }
    }
}
