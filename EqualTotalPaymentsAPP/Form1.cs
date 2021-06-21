using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EqualTotalPaymentsAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void txtLoanAmount_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtInterestRate_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtLoanPeriod_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void txtLoanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtLoanPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtLoanAmount.Text == "" || txtInterestRate.Text == "" || txtLoanPeriod.Text == "")
            {
                string msg = "Enter all fields";
                string title = "Invalid input";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                DialogResult res = MessageBox.Show(msg, title, btn);
                if (res == DialogResult.OK)
                {
                    txtLoanAmount.Clear();
                    txtInterestRate.Clear();
                    txtLoanPeriod.Clear();
                }
            }
            else if (Convert.ToInt32(txtLoanAmount.Text) == 0)
            {
                string msg = "Enter valid loan amount";
                string title = "Invalid input";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                //MessageBox.Show("Enter valid amount");
                DialogResult res = MessageBox.Show(msg, title, btn);
                if (res == DialogResult.OK)
                {
                    txtLoanAmount.Clear();
                    txtInterestRate.Clear();
                    txtLoanPeriod.Clear();
                }
            }

            else if (Convert.ToInt32(txtInterestRate.Text) == 0)
            {
                string msg = "Enter valid interest rate";
                string title = "Invalid input";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                DialogResult res = MessageBox.Show(msg, title, btn);
                if (res == DialogResult.OK)
                {
                    txtLoanAmount.Clear();
                    txtInterestRate.Clear();
                    txtLoanPeriod.Clear();
                }

            }
            else if (Convert.ToInt32(txtLoanPeriod.Text) == 0)
            {
                string msg = "Enter valid loan period";
                string title = "Invalid input";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                DialogResult res = MessageBox.Show(msg, title, btn);
                if (res == DialogResult.OK)
                {
                    txtLoanAmount.Clear();
                    txtInterestRate.Clear();
                    txtLoanPeriod.Clear();
                }
            }
            else
            {
                int amt, period, i;
                amt = Convert.ToInt32(txtLoanAmount.Text);
                double rate = Convert.ToDouble(txtInterestRate.Text) / 1200;
                period = Convert.ToInt32(txtLoanPeriod.Text);

                DataTable dt = new DataTable("loan details for " + period + " months");

                dt.Columns.Add("Payment number", typeof(int));
                dt.Columns.Add("Payment Amount", typeof(double));
                dt.Columns.Add("Principal Amount Paid", typeof(double));
                dt.Columns.Add("Interest Amount Paid", typeof(double));
                dt.Columns.Add("Loan outstanding balance", typeof(double));

                for (i = 1; i <= period; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Payment number"] = i;
                    double payAmount = (amt * rate * ((float)Math.Pow(1 + rate, period))) / (-1 + ((float)Math.Pow(1 + rate, period)));
                    dr["Payment Amount"] = payAmount;
                    double principalpaid = payAmount * (Math.Pow((1 + rate), -(1 + period - i)));
                    dr["Principal Amount Paid"] = principalpaid;
                    double interestpaid = payAmount - principalpaid;
                    dr["Interest Amount Paid"] = interestpaid;
                    double outstandingamount = (interestpaid / rate) - principalpaid;
                    dr["Loan outstanding balance"] = outstandingamount;

                    dt.Rows.Add(i, Math.Round(payAmount, 2), Math.Round(principalpaid, 2), Math.Round(interestpaid, 2), Math.Round(outstandingamount, 2));

                }
                Form2 f2 = new Form2(dt);
                f2.Show();
                Visible = false;
            }
        }
    }
}
