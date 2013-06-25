using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XRetail
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Activate();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == "" && password == "")
            {
                new Main(username,this).Show();
                this.Hide();
            }
            else
            {
                //lbl_error.Text = "Oops!!!!!";
            }
        }
    }
}
