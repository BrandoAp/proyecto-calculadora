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
            expresionView.Clear();
            resutlView.Clear();
        }

        private void ceroButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("2");
        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("9");
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("+");
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("-");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("x");
        }

        private void exponentButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("^");
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("÷");
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            expresionView.Items.Add("√");
        }

        private void viewHistorial_Click(object sender, EventArgs e)
        {
            CargarHitorial();
        }

        public void CargarHitorial() //recupera la expresion pero no el resultado
        {
            string sql = "Select expresion, resultado from Historial_Calculos;";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        listViewHistorial.Items.Clear();
                        while (reader.Read())
                        {
                            string expresion = reader.GetString(0);
                            decimal resultado = reader.GetDecimal(1);

                            ListViewItem item = new ListViewItem(expresion);
                            item.SubItems.Add(resultado.ToString());

                            listViewHistorial.Items.Add(item);
                        }
                        reader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar el historial de operaciones ",
                    ex.Message);
            }
        }
    }
}