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

namespace proyecto_calculadora
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=calculadora;Trusted_Connection=true;";
        public Form1()
        {
            InitializeComponent();
            contentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error el intentar establecer la conexion ", ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Clear();
        }

        private void ceroButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("2");
        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("9");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aqui por el momento no habra ninguna funcionalidad
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add(".");
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("÷");
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("x");
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("-");
        }

        private void sumaButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("+");
        }

        private void exponentButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("^");
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("√");
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            contentListView.Items.Add("%");
        }
    }
}
