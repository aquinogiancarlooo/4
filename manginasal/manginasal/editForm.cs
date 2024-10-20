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
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            productid.Enabled = true;
            stock.Enabled = true;
            price.Enabled = true;
            category.Enabled = true;

            button1.Visible = false;
            bt1.Visible = false;
            bt2.Visible = false;
            savebtn.Visible = true;

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            bt1.Visible = true;
            bt2.Visible = true;
            savebtn.Visible = false;

            productid.Enabled = false;
            stock.Enabled = false;
            price.Enabled = false;
            category.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
