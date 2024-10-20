using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace manginasal
{
    public partial class orders : Form
    {
        public int total = 0;
        int payment = 0;
        int totalchange = 0;
        public orders()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(txttotal.Text);
            int payment = Convert.ToInt32(txtpayment.Text);

            totalchange =  payment - total;

            string changee = Convert.ToString(totalchange);

            change.Text = changee;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
