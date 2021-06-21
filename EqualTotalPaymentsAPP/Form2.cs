using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EqualTotalPaymentsAPP
{
    public partial class Form2 : Form
    {
        public Form2(DataTable dt)
        {
            InitializeComponent();
            gridResults.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}
