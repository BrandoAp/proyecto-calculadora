using proyecto_calculadora.Modelo;
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
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        private void addNum(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            //Si el numero inicial es 0, se elimina para concatenar numeros
            if (expressionTxt.Text == "0")
                expressionTxt.Text = "";

            expressionTxt.Text += btn.Text;
        }

        private void clickOp(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            Op = Convert.ToChar(btn.Tag);

            expressionTxt.Text += " " + Op.ToString() + " ";
        }
        private void clearAll(object sender, EventArgs e)
        {
            expressionTxt.Clear();
            resultTxt.Clear();
        }

        private void clearLastAdd(object sender, EventArgs e)
        {
            // Verifica si el TextBox no está vacío
            if (expressionTxt.Text.Length > 0)
            {
                // Elimina el último carácter del TextBox
                expressionTxt.Text = expressionTxt.Text.Substring(0, expressionTxt.Text.Length - 1);
            }
        }


        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = expressionTxt.Text.Replace("x", "*");

                double resultado = EvaluateExpression(expression);

                resultTxt.Text = resultado.ToString();

                Modelo_Calculadora modelo = new Modelo_Calculadora(expression, resultado);
                saveHistory(modelo);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operacion " + ex.Message);
            }
        }

        private double EvaluateExpression(String expression)
        {
            try
            {
                var table = new System.Data.DataTable();
                var value = table.Compute(expression, null);
                return Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la expresion "+ ex.Message);
                return 0;
            }
        }

        private void viewHistorial_Click(object sender, EventArgs e)
        {
            CargarHitorial();
        }

        public void CargarHitorial()
        {
            string sql = "Select expresion, resultado from Historial_Calculos;";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listViewHistorial.Items.Clear();
                        while (reader.Read())
                        {
                            listViewHistorial.Items.Add(reader.GetString(0) + " = " + reader.GetDecimal(1));
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
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void saveHistory(Modelo_Calculadora modelo)
        {
            string sql = "INSERT INTO Historial_Calculos (expresion, resultado) VALUES (@expresion, @resultado);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@expresion", modelo.expresion);
                        command.Parameters.AddWithValue("@resultado", modelo.resultado);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al guardar la operacion en el historial: ", ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }
    }
}