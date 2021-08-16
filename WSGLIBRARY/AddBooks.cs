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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            String query2 = "SELECTAUTHORS";
            SqlDataAdapter cmd2 = new SqlDataAdapter(query2, con);

            DataTable datatable = new DataTable();
            cmd2.Fill(datatable);
            ComboBoxAuthor.DataSource = datatable;
            ComboBoxAuthor.DisplayMember = "name";
            ComboBoxAuthor.ValueMember = "id";


        }

        private void TextBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        public String ConString = "Data Source=N3MA;Initial Catalog=BookCatalog;Integrated Security=True";
        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
          

            String Title = TextBoxTitle.Text;
            String Author = ComboBoxAuthor.SelectedValue.ToString();
            String Genere = TextBoxGenere.Text;
            String price = TextBoxPrice.Text;
            String ReleaseDate = TextBoxReleaseDate.Text;


            if (con.State == System.Data.ConnectionState.Open)
            {
                String query = "INSERTBOOKS '" + Title + "', '" + Author + "', '" + Genere + "', '" + price + "', '" + ReleaseDate + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book " + Title + " added successfully");
                con.Close();
                ClearTextBoxs();
            }
        }


        private void ClearTextBoxs()
        {
            TextBoxTitle.Clear();
            TextBoxGenere.Clear();
            TextBoxPrice.Clear();
            TextBoxReleaseDate.Clear();

        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addauthor = new AddAuthor();
            addauthor.ShowDialog();
        }
    }
}
