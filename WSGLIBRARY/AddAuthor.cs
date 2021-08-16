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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        public String ConString = "Data Source=N3MA;Initial Catalog=BookCatalog;Integrated Security=True";

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            String Name = TextBoxTitle.Text;
            String Sex = TextBoxSex.Text;
            String Nationality = TextBoxNationality.Text;

            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String query = "INSERTAUTHOR '" + Name + "', '" + Sex + "', '" + Nationality + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Author " + Name + " added successfully");
                con.Close();

            }
            Close();
        }
    }
}
