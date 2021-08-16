using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WSGLIBRARY
{
    public partial class DisplayBooks : Form
    {
        public DisplayBooks()
        {
            InitializeComponent();

        }

        public String ConString = "Data Source=N3MA;Initial Catalog=BookCatalog;Integrated Security=True";
        private void DisplayBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);

                try
                {
                    DataTable datatable = new DataTable();
                    String query = "SELECTBOOKS";
                    SqlDataAdapter cmd = new SqlDataAdapter(query, con);
                    cmd.Fill(datatable);
                    DataGridView.DataSource = datatable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String input = SearchInputText.Text;
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                DataTable datatable = new DataTable();
                String query = "SEARCHBOOKS '" + input + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(query, con);
                cmd.Fill(datatable);
                DataGridView.DataSource = datatable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var Selected_Book = DataGridView.CurrentRow.Cells[1].Value.ToString();
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                DataTable datatable = new DataTable();
                String query = "DELETEBOOK '" + Selected_Book + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(query, con);
                cmd.Fill(datatable);
                DataGridView.DataSource = datatable;
                MessageBox.Show("Book '" + Selected_Book + "' Deleted Successfully ");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
