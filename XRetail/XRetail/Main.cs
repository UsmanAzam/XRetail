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
    public partial class Main : Form
    {
        Login lg;
        public Main(string u, Login l)
        {
            InitializeComponent();
            lg = l;
            lbl_user.Text = "Nasir Rashid";
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {            
            lg.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            /*
            var context = new XRetailRepository.XretailDBEntities();
            var query = from c in context.Categories select c;
            MessageBox.Show("" +  query.ToList<Category>());
            */
        }

     

        
    }
}
