using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBasedLibrary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeTable emp = new EmployeeTable();
            emp.Employee_Name = NameTextBox.Text;
            emp.Employee_Location = LocationTextBox.Text;
            emp.Employee_Salary = Convert.ToDecimal(SalaryTextBox.Text);
            //MessageBox.Show($"Name:{emp.Employee_Name},Location:{emp.Employee_Location},Salary:{emp.Employee_Salary}");
            using (var empObj = new EmployeeContext())
            {
                empObj.Employee_Records.Add(emp);
                empObj.SaveChanges();
                MessageBox.Show($"Name:{emp.Employee_Name},Location:{emp.Employee_Location},Salary:{emp.Employee_Salary} inserted successfully");
            }


        }        

    

    }
}
