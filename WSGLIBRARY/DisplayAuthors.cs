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
    public partial class DisplayAuthors : Form
    {
        public DisplayAuthors()
        {
            InitializeComponent();
        }

        public String ConString = "Data Source=N3MA;Initial Catalog=BookCatalog;Integrated Security=True";
        private void DisplayAuthors_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);

            try
            {
                DataTable datatable = new DataTable();
                String query = "SELECTAUTHORS";
                SqlDataAdapter cmd = new SqlDataAdapter(query, con);
                cmd.Fill(datatable);
                DataGridView.DataSource = datatable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
