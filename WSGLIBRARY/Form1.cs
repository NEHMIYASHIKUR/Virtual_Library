using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSGLIBRARY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AddBooks addBooks = new AddBooks();
        DisplayAuthors displayAuthors = new DisplayAuthors();
        DisplayBooks displayBooks = new DisplayBooks();
        private void DisplayBooks_Click(object sender, EventArgs e)
        {
            displayBooks.ShowDialog();
        }

        private void AddBooks_Click(object sender, EventArgs e)
        {
            addBooks.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayAuthors.ShowDialog();
        }
    }
}
