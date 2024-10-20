namespace manginasal
{
    partial class orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtorders = new System.Windows.Forms.TextBox();
            this.txtordernum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = global::manginasal.Properties.Resources.bg;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.change);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtpayment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtstatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.txtorders);
            this.panel1.Controls.Add(this.txtordernum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 926);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 770);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 36;
            this.button2.Text = "change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 843);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 63);
            this.button1.TabIndex = 35;
            this.button1.Text = "PRINT RECIEPT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(260, 772);
            this.change.Multiline = true;
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(267, 40);
            this.change.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(262, 732);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "change";
            // 
            // txtpayment
            // 
            this.txtpayment.Location = new System.Drawing.Point(467, 656);
            this.txtpayment.Multiline = true;
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(267, 40);
            this.txtpayment.TabIndex = 32;
            this.txtpayment.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(469, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "payment";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::manginasal.Properties.Resources.logo2;
            this.panel3.Location = new System.Drawing.Point(26, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 30;
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Location = new System.Drawing.Point(59, 563);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(267, 40);
            this.txtstatus.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(61, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 37);
            this.label9.TabIndex = 28;
            this.label9.Text = "status";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(59, 656);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(267, 40);
            this.txttotal.TabIndex = 27;
            // 
            // txtorders
            // 
            this.txtorders.Location = new System.Drawing.Point(59, 301);
            this.txtorders.Multiline = true;
            this.txtorders.Name = "txtorders";
            this.txtorders.Size = new System.Drawing.Size(675, 219);
            this.txtorders.TabIndex = 26;
            // 
            // txtordernum
            // 
            this.txtordernum.Enabled = false;
            this.txtordernum.Location = new System.Drawing.Point(59, 207);
            this.txtordernum.Multiline = true;
            this.txtordernum.Name = "txtordernum";
            this.txtordernum.Size = new System.Drawing.Size(267, 40);
            this.txtordernum.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(61, 616);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "total amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(170, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(430, 42);
            this.label7.TabIndex = 23;
            this.label7.Text = "ORDER TRANSACTION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(61, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 37);
            this.label8.TabIndex = 22;
            this.label8.Text = "orders";
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 915);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtstatus;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtorders;
        public System.Windows.Forms.TextBox txtordernum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox change;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}