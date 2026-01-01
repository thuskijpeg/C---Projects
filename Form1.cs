using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac1._6_MakingDecisions_45312222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string level = "";

                if (rbFirstYear.Checked) level = "1st year";
                else if (rbSecondYear.Checked) level = "2nd year";
                else if (rbThirdYear.Checked) level = "3rd year";

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(level))
                {
                    MessageBox.Show("Please complete all student information.", "Input Error");
                    return;
                }

                double totalCost = 0;

                if (chkCSharp.Checked) totalCost += 550.67;
                if (chkCpp.Checked) totalCost += 530.30;
                if (chkVB.Checked) totalCost += 480.02;
                if (chkJava.Checked) totalCost += 756.60;
                if (chkDatabase.Checked) totalCost += 736.45;

                string message = $"Hello {firstName} {lastName},\n" +
                                 $"Year of study: {level}\n" +
                                 $"Total cost of selected modules: R{totalCost:F2}";

                MessageBox.Show(message, "Enrollment Summary");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating the cost.\n" + ex.Message, "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                rbFirstYear.Checked = false;
                rbSecondYear.Checked = false;
                rbThirdYear.Checked = false;
                chkCSharp.Checked = false;
                chkCpp.Checked = false;
                chkVB.Checked = false;
                chkJava.Checked = false;
                chkDatabase.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing the form.\n" + ex.Message, "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
    
}
