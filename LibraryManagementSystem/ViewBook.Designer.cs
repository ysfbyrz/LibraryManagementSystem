namespace LibraryManagementSystem
{
    partial class ViewBook
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBQuan = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtBPDate = new System.Windows.Forms.TextBox();
            this.txtBPbl = new System.Windows.Forms.TextBox();
            this.txtBAuthor = new System.Windows.Forms.TextBox();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelisbn = new System.Windows.Forms.Label();
            this.labelBPDate = new System.Windows.Forms.Label();
            this.labelBPbl = new System.Windows.Forms.Label();
            this.labelBAuthor = new System.Windows.Forms.Label();
            this.labelBName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(535, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 2);
            this.panel4.TabIndex = 16;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBookName.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtBookName.Location = new System.Drawing.Point(535, 35);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 29);
            this.txtBookName.TabIndex = 15;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(398, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Book Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 315);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Location = new System.Drawing.Point(781, 35);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(173, 33);
            this.btnRefresh1.TabIndex = 18;
            this.btnRefresh1.Text = "Refresh";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtBQuan);
            this.panel1.Controls.Add(this.txtIsbn);
            this.panel1.Controls.Add(this.txtBPDate);
            this.panel1.Controls.Add(this.txtBPbl);
            this.panel1.Controls.Add(this.txtBAuthor);
            this.panel1.Controls.Add(this.txtBName);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.labelisbn);
            this.panel1.Controls.Add(this.labelBPDate);
            this.panel1.Controls.Add(this.labelBPbl);
            this.panel1.Controls.Add(this.labelBAuthor);
            this.panel1.Controls.Add(this.labelBName);
            this.panel1.Location = new System.Drawing.Point(203, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 312);
            this.panel1.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(690, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 33);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(471, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 33);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(260, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 33);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBQuan
            // 
            this.txtBQuan.Location = new System.Drawing.Point(627, 185);
            this.txtBQuan.Name = "txtBQuan";
            this.txtBQuan.Size = new System.Drawing.Size(207, 22);
            this.txtBQuan.TabIndex = 30;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(627, 117);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(207, 22);
            this.txtIsbn.TabIndex = 29;
            // 
            // txtBPDate
            // 
            this.txtBPDate.Location = new System.Drawing.Point(627, 39);
            this.txtBPDate.Name = "txtBPDate";
            this.txtBPDate.Size = new System.Drawing.Size(207, 22);
            this.txtBPDate.TabIndex = 9;
            // 
            // txtBPbl
            // 
            this.txtBPbl.Location = new System.Drawing.Point(161, 176);
            this.txtBPbl.Name = "txtBPbl";
            this.txtBPbl.Size = new System.Drawing.Size(225, 22);
            this.txtBPbl.TabIndex = 8;
            // 
            // txtBAuthor
            // 
            this.txtBAuthor.Location = new System.Drawing.Point(161, 114);
            this.txtBAuthor.Name = "txtBAuthor";
            this.txtBAuthor.Size = new System.Drawing.Size(225, 22);
            this.txtBAuthor.TabIndex = 7;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(161, 42);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(225, 22);
            this.txtBName.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(507, 188);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 16);
            this.label.TabIndex = 5;
            this.label.Text = "Book Quantity";
            // 
            // labelisbn
            // 
            this.labelisbn.AutoSize = true;
            this.labelisbn.Location = new System.Drawing.Point(519, 120);
            this.labelisbn.Name = "labelisbn";
            this.labelisbn.Size = new System.Drawing.Size(38, 16);
            this.labelisbn.TabIndex = 4;
            this.labelisbn.Text = "ISBN";
            // 
            // labelBPDate
            // 
            this.labelBPDate.AutoSize = true;
            this.labelBPDate.Location = new System.Drawing.Point(466, 45);
            this.labelBPDate.Name = "labelBPDate";
            this.labelBPDate.Size = new System.Drawing.Size(131, 16);
            this.labelBPDate.TabIndex = 3;
            this.labelBPDate.Text = "Book Purchase Date";
            // 
            // labelBPbl
            // 
            this.labelBPbl.AutoSize = true;
            this.labelBPbl.Location = new System.Drawing.Point(26, 179);
            this.labelBPbl.Name = "labelBPbl";
            this.labelBPbl.Size = new System.Drawing.Size(108, 16);
            this.labelBPbl.TabIndex = 2;
            this.labelBPbl.Text = "Book Publication";
            // 
            // labelBAuthor
            // 
            this.labelBAuthor.AutoSize = true;
            this.labelBAuthor.Location = new System.Drawing.Point(54, 117);
            this.labelBAuthor.Name = "labelBAuthor";
            this.labelBAuthor.Size = new System.Drawing.Size(80, 16);
            this.labelBAuthor.TabIndex = 1;
            this.labelBAuthor.Text = "Book Author";
            // 
            // labelBName
            // 
            this.labelBName.AutoSize = true;
            this.labelBName.Location = new System.Drawing.Point(55, 45);
            this.labelBName.Name = "labelBName";
            this.labelBName.Size = new System.Drawing.Size(79, 16);
            this.labelBName.TabIndex = 0;
            this.labelBName.Text = "Book Name";
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label4);
            this.Name = "ViewBook";
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBPbl;
        private System.Windows.Forms.TextBox txtBAuthor;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelisbn;
        private System.Windows.Forms.Label labelBPDate;
        private System.Windows.Forms.Label labelBPbl;
        private System.Windows.Forms.Label labelBAuthor;
        private System.Windows.Forms.Label labelBName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBQuan;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtBPDate;
    }
}