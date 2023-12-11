namespace LibraryManagementSystem
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtbookısbn = new System.Windows.Forms.TextBox();
            this.dtpurchasedate = new System.Windows.Forms.DateTimePicker();
            this.txtpublication = new System.Windows.Forms.TextBox();
            this.txtauthorname = new System.Windows.Forms.TextBox();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.labelbookquantity = new System.Windows.Forms.Label();
            this.labelbookisbn = new System.Windows.Forms.Label();
            this.labelbookdate = new System.Windows.Forms.Label();
            this.labelpublication = new System.Windows.Forms.Label();
            this.labelauthorname = new System.Windows.Forms.Label();
            this.labelbookname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(435, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add Book";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 116);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txtquantity);
            this.panel2.Controls.Add(this.txtbookısbn);
            this.panel2.Controls.Add(this.dtpurchasedate);
            this.panel2.Controls.Add(this.txtpublication);
            this.panel2.Controls.Add(this.txtauthorname);
            this.panel2.Controls.Add(this.txtbookname);
            this.panel2.Controls.Add(this.labelbookquantity);
            this.panel2.Controls.Add(this.labelbookisbn);
            this.panel2.Controls.Add(this.labelbookdate);
            this.panel2.Controls.Add(this.labelpublication);
            this.panel2.Controls.Add(this.labelauthorname);
            this.panel2.Controls.Add(this.labelbookname);
            this.panel2.Location = new System.Drawing.Point(144, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 425);
            this.panel2.TabIndex = 5;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnclear.Location = new System.Drawing.Point(448, 201);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(161, 49);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightYellow;
            this.btnsave.Location = new System.Drawing.Point(448, 110);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(161, 49);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.Wheat;
            this.txtquantity.Location = new System.Drawing.Point(159, 270);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(251, 22);
            this.txtquantity.TabIndex = 11;
            this.txtquantity.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtbookısbn
            // 
            this.txtbookısbn.BackColor = System.Drawing.Color.Wheat;
            this.txtbookısbn.Location = new System.Drawing.Point(159, 214);
            this.txtbookısbn.Margin = new System.Windows.Forms.Padding(4);
            this.txtbookısbn.Name = "txtbookısbn";
            this.txtbookısbn.Size = new System.Drawing.Size(251, 22);
            this.txtbookısbn.TabIndex = 10;
            // 
            // dtpurchasedate
            // 
            this.dtpurchasedate.CalendarForeColor = System.Drawing.Color.Wheat;
            this.dtpurchasedate.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dtpurchasedate.Location = new System.Drawing.Point(159, 159);
            this.dtpurchasedate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpurchasedate.Name = "dtpurchasedate";
            this.dtpurchasedate.Size = new System.Drawing.Size(251, 22);
            this.dtpurchasedate.TabIndex = 9;
            // 
            // txtpublication
            // 
            this.txtpublication.BackColor = System.Drawing.Color.Wheat;
            this.txtpublication.Location = new System.Drawing.Point(153, 111);
            this.txtpublication.Margin = new System.Windows.Forms.Padding(4);
            this.txtpublication.Name = "txtpublication";
            this.txtpublication.Size = new System.Drawing.Size(256, 22);
            this.txtpublication.TabIndex = 8;
            // 
            // txtauthorname
            // 
            this.txtauthorname.BackColor = System.Drawing.Color.Wheat;
            this.txtauthorname.Location = new System.Drawing.Point(155, 66);
            this.txtauthorname.Margin = new System.Windows.Forms.Padding(4);
            this.txtauthorname.Name = "txtauthorname";
            this.txtauthorname.Size = new System.Drawing.Size(255, 22);
            this.txtauthorname.TabIndex = 7;
            // 
            // txtbookname
            // 
            this.txtbookname.BackColor = System.Drawing.Color.Wheat;
            this.txtbookname.Location = new System.Drawing.Point(155, 17);
            this.txtbookname.Margin = new System.Windows.Forms.Padding(4);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(255, 22);
            this.txtbookname.TabIndex = 6;
            // 
            // labelbookquantity
            // 
            this.labelbookquantity.AutoSize = true;
            this.labelbookquantity.BackColor = System.Drawing.Color.Wheat;
            this.labelbookquantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbookquantity.Location = new System.Drawing.Point(16, 268);
            this.labelbookquantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbookquantity.Name = "labelbookquantity";
            this.labelbookquantity.Size = new System.Drawing.Size(129, 24);
            this.labelbookquantity.TabIndex = 5;
            this.labelbookquantity.Text = "Book Quantity";
            // 
            // labelbookisbn
            // 
            this.labelbookisbn.AutoSize = true;
            this.labelbookisbn.BackColor = System.Drawing.Color.Wheat;
            this.labelbookisbn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbookisbn.Location = new System.Drawing.Point(99, 215);
            this.labelbookisbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbookisbn.Name = "labelbookisbn";
            this.labelbookisbn.Size = new System.Drawing.Size(48, 24);
            this.labelbookisbn.TabIndex = 4;
            this.labelbookisbn.Text = "ISBN";
            // 
            // labelbookdate
            // 
            this.labelbookdate.AutoSize = true;
            this.labelbookdate.BackColor = System.Drawing.Color.Wheat;
            this.labelbookdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbookdate.Location = new System.Drawing.Point(13, 159);
            this.labelbookdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbookdate.Name = "labelbookdate";
            this.labelbookdate.Size = new System.Drawing.Size(129, 24);
            this.labelbookdate.TabIndex = 3;
            this.labelbookdate.Text = "Purchase Date";
            // 
            // labelpublication
            // 
            this.labelpublication.AutoSize = true;
            this.labelpublication.BackColor = System.Drawing.Color.Wheat;
            this.labelpublication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelpublication.Location = new System.Drawing.Point(43, 110);
            this.labelpublication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpublication.Name = "labelpublication";
            this.labelpublication.Size = new System.Drawing.Size(103, 24);
            this.labelpublication.TabIndex = 2;
            this.labelpublication.Text = "Publication";
            // 
            // labelauthorname
            // 
            this.labelauthorname.AutoSize = true;
            this.labelauthorname.BackColor = System.Drawing.Color.Wheat;
            this.labelauthorname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelauthorname.Location = new System.Drawing.Point(25, 66);
            this.labelauthorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelauthorname.Name = "labelauthorname";
            this.labelauthorname.Size = new System.Drawing.Size(123, 24);
            this.labelauthorname.TabIndex = 1;
            this.labelauthorname.Text = "Author Name";
            // 
            // labelbookname
            // 
            this.labelbookname.AutoSize = true;
            this.labelbookname.BackColor = System.Drawing.Color.Wheat;
            this.labelbookname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbookname.Location = new System.Drawing.Point(35, 18);
            this.labelbookname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbookname.Name = "labelbookname";
            this.labelbookname.Size = new System.Drawing.Size(106, 24);
            this.labelbookname.TabIndex = 0;
            this.labelbookname.Text = "Book Name";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelbookquantity;
        private System.Windows.Forms.Label labelbookisbn;
        private System.Windows.Forms.Label labelbookdate;
        private System.Windows.Forms.Label labelauthorname;
        private System.Windows.Forms.Label labelbookname;
        private System.Windows.Forms.TextBox txtpublication;
        private System.Windows.Forms.TextBox txtauthorname;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label labelpublication;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtbookısbn;
        private System.Windows.Forms.DateTimePicker dtpurchasedate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
    }
}