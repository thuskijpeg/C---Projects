using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masalesa_Prac4
{
    public partial class Form1 : Form
    {
        // Named constant for daily rate
        private const decimal DAILY_RATE = 350m;

        public Form1()
        {
            InitializeComponent();

            // Set button texts with access keys
            btnCalculate.Text = "&Calculate"; // Alt + C
            btnExit.Text = "E&xit";           // Alt + X

            // Wire up button events
            btnCalculate.Click += btnCalculate_Click;
            btnExit.Click += btnExit_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotalCost.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int days = int.Parse(txtDays.Text);
                decimal totalCost = DAILY_RATE * days;

                lblTotalCost.Text = "Hi, " + txtName.Text + ", your cost will be " + totalCost.ToString("C");
                lblTotalCost.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for days.");
                txtDays.Focus();
                txtDays.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmployeeNo.Clear();
            txtCourtName.Clear();
            txtDays.Clear();

            // Hide the label again after clearing
            lblTotalCost.Text = string.Empty;
            lblTotalCost.Visible = false;

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
