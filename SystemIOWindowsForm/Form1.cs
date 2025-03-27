using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWindowsForm
{
    public partial class Form1 : Form
    {
        dataOptions dataOptionsO;
        List<employee> employeList;

        public Form1()
        {
            InitializeComponent();
            dataOptionsO = new dataOptions();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeListingBtn_Click(object sender, EventArgs e)
        {
            employeList = dataOptionsO.GetEmployes(150);
            EmployeeListBox.DataSource = employeList;
        }

        private void EmployeeListBox_DoubleClick(object sender, EventArgs e)
        {
            employee chosenEmployee = (employee)EmployeeListBox.SelectedItem;
            nametextbox.Text = chosenEmployee.Name;
            surnametextbox.Text = chosenEmployee.Surname;
            emailtextbox.Text = chosenEmployee.Email;
            companytextbox.Text = chosenEmployee.Country;
            countrytextbox.Text = chosenEmployee.Country;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            dataOptionsO.AddEmployee("c:\\Udemy", employeList);
        }
    }
}
