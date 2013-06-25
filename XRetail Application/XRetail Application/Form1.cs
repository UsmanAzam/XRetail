using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjects;

namespace XRetail_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XRetailEntities db = new XRetailEntities();
            Employee emp = new Employee();
            emp.name = "Usman Azam";
            db.Employees.AddObject(emp);
            db.SaveChanges();
            MessageBox.Show("Data Added Sucessfully.");
        }
    }
}
