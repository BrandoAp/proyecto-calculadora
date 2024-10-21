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
        double num1 = 0, num2 = 0;
        char Op;
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

        private void addNum (object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            if
                (expressionTxt.Text == "0")
                expressionTxt.Text = "";

            expressionTxt.Text += btn.Text;
        }

        private void clickOp(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            num1 = Convert.ToDouble(expressionTxt.Text);
            Op = Convert.ToChar(btn.Tag);

            if (Op == '²')
            {
                num1 = Math.Pow(num1, 2);
                resultTxt.Text = num1.ToString();
                expressionTxt.Text = "0";
            }
            else if (Op == '√')
            {
                num1 = Math.Sqrt(num1);
                resultTxt.Text = num1.ToString();
                expressionTxt.Text = "0";
            }
            else
            {
                expressionTxt.Text = "0";
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            expressionTxt.Clear();
            resultTxt.Clear();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(expressionTxt.Text);
            if (Op == '+')
            {
                resultTxt.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(resultTxt.Text);

                expressionTxt.Text = "0";
            }
            else if (Op == '-')
            {
                resultTxt.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(resultTxt.Text);

                expressionTxt.Text = "0";
            }
            else if (Op == 'x')
            {
                resultTxt.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(resultTxt.Text);

                expressionTxt.Text = "0";
            }
            else if (Op == '/')
            {
                resultTxt.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(resultTxt.Text);

                expressionTxt.Text = "0";
            }
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
                    using (SqlDataReader reader = command.ExecuteReader())
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