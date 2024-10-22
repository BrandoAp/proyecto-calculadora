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
            string num = btn.Text;

            if (expressionTxt.Text == "0")
                expressionTxt.Text = num;
            else
                expressionTxt.Text += num;
        }

        private void clickOp(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            Op = Convert.ToChar(btn.Tag);

            if(Op == '²')
            {
                //Intentamos convertir el valor del expresionTxt a numero
                if (double.TryParse(expressionTxt.Text, out num1))
                {
                    num1 = Convert.ToDouble(expressionTxt.Text);
                    num1 = Math.Pow(num1, 2);
                    resultTxt.Text = num1.ToString();

                    expressionTxt.Text = $"({expressionTxt.Text})²";

                    Modelo_Calculadora modelo = new Modelo_Calculadora(expressionTxt.Text, num1);
                    saveHistory(modelo);
                }
                
            }
            else if (Op == '√')
            {
                //Intentamos convertir el valor del expresionTxt a numero
                if (double.TryParse(expressionTxt.Text, out num1))
                {
                    if (num1 > 0)
                    {
                        num1 = Math.Sqrt(num1);
                        resultTxt.Text = num1.ToString();

                        expressionTxt.Text = $"√({expressionTxt.Text})";

                        Modelo_Calculadora modelo = new Modelo_Calculadora(expressionTxt.Text, num1);
                        saveHistory(modelo);
                    }
                    else
                        MessageBox.Show("Error! No existen raices de números negativos");
                }
                
            }
            else
            {
                //Concatenamos el operador al texto actual sin reinciar el campo
                if (!string.IsNullOrWhiteSpace(expressionTxt.Text))
                {
                    num1 = Convert.ToDouble(expressionTxt.Text);

                    expressionTxt.Text += " " + Op.ToString() + " "; 
                }
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            expressionTxt.Clear();
            resultTxt.Clear();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] expressionParts = expressionTxt.Text.Split(' ');

                if (expressionParts.Length == 3)
                {
                    num1 = Convert.ToDouble(expressionParts[0]);
                    Op = Convert.ToChar(expressionParts[1]);
                    num2 = Convert.ToDouble(expressionParts[2]);

                    double resultado = 0;

                    switch (Op)
                    {
                        case '+':
                            resultado = num1 + num2;
                            break;
                        case '-':
                            resultado = num1 - num2;
                            break;
                        case 'x':
                            resultado = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                            }
                            else
                            {
                                MessageBox.Show("No se puede dividir entre 0.");
                                return;
                            }
                            break;
                    }
                    resultTxt.Text = resultado.ToString();

                    string expresionCompleta = num1 + " " +  Op.ToString() + " " + num2;

                    Modelo_Calculadora modelo = new Modelo_Calculadora(expresionCompleta, resultado);
                    saveHistory(modelo);

                    expressionTxt.Text = expresionCompleta;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error en la operacion " + ex.Message);
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