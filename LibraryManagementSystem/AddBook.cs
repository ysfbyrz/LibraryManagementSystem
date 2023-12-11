using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtauthorname.Text != "" && txtpublication.Text != "" && txtbookısbn.Text != "" && txtquantity.Text != "")
            {


                string bname = txtbookname.Text;
                string bauthor = txtauthorname.Text;
                string publication = txtpublication.Text;
                string pdate = dtpurchasedate.Text;
                Int64 ısbn = Int64.Parse(txtbookısbn.Text);
                Int64 quan = Int64.Parse(txtquantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\SQLEXPRESS; database=Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bPDate,bIsbn,bQuan) values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "','" + ısbn + "','" + quan + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                txtbookname.Clear();
                txtauthorname.Clear();
                txtbookısbn.Clear();
                txtpublication.Clear();
                txtquantity.Clear();

                MessageBox.Show("Book info saved.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty field NOT Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbookname.Clear();
            txtauthorname.Clear();
            txtbookısbn.Clear();
            txtpublication.Clear();
            txtquantity.Clear();

        }
    }
}
