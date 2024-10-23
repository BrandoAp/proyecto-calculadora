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
            var btn = ((Button)sender); // Obtiene ell boton que fue presionado
            
            // Si el campo de texto tiene un "0" lo reemplaza
            if (expressionTxt.Text == "0")
                expressionTxt.Text = "";

            expressionTxt.Text += btn.Text; // agrega el numero presionado a la expresion
        }

        private void clickOp(object sender, EventArgs e)
        {
            var btn = ((Button)sender); // Obtiene el boton presionado
            Op = Convert.ToChar(btn.Tag); //convierte el tag del boton a caracter (operador)

            //Si el campo de texto tiene un "0" lo reemplaza
            if (expressionTxt.Text == "0")
                expressionTxt.Text = "";

            //Agrega el operador a la expresion con espacios entre el numero y el operador
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

        private void addPoint(object sender, EventArgs e)
        {
            // Obtener el último número de la expresión, separando por operadores
            string[] partes = expressionTxt.Text.Split(' ');

            // Si la última parte no contiene un punto decimal, se puede agregar
            if (!partes[partes.Length - 1].Contains("."))
            {
                // Añadir punto decimal al número actual
                expressionTxt.Text += ".";
            }
        }


        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Reemplaza 'x' por '*' para lograr multiplicar
                string expression = expressionTxt.Text.Replace("x", "*");

                // Evalua la expresion y obtiene el resultado
                double resultado = EvaluateExpression(expression);

                resultTxt.Text = resultado.ToString(); //Muestra el resultado en el campo de texto resultTxt

                // Crea una instancia del modelo para guardar la operacion en el historial
                Modelo_Calculadora modelo = new Modelo_Calculadora(expression, resultado);
                saveHistory(modelo); // Guarda la expresion y el resultado en la base de datos
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
                // Maneja la operacion de raiz si esta en la expresion
                if (expression.Contains("√"))
                {
                    //Divide la expresion por simbolo y elimina las entradas vacias
                    string[] partes = expression.Split(new[] { '√' }, StringSplitOptions.RemoveEmptyEntries);
                    if (partes.Length == 1)
                    {
                        double numb = Convert.ToDouble(partes[0].Trim()); //Convierte la cadena a double y elimina los espacio en ambos lados
                        return Math.Sqrt(numb); // Calcula la raiz cuadrada
                    }
                    else
                    {
                        //Si hay algo antes del simbolo, guarda la parte antes de la raiz
                        string beforeSqrt = partes[0].Trim();
                        double numbSqrt = Convert.ToDouble(partes[1].Trim()); // convierte la partes despues del simbolo a un numero

                        //Si hay algo antes de la raiz evalua esa parte
                        //Si no hay nada antes el resultado sera 0
                        double resultS = (beforeSqrt.Length > 0) ? EvaluateExpression(beforeSqrt) : 0;
                        return Math.Sqrt(numbSqrt); // Calcula la raiz y la retorna
                    }
                }

                if (expression.Contains("^"))
                {
                    //Divide la expresion en dos partes usando el simbolo como operador
                    string[] partes = expression.Split('^');

                    //Convierte la primera parte de la expresion a un numero
                    double baseNum = Convert.ToDouble(partes[0].Trim());

                    //Convierte la segunda parte de la expresion a un numero
                    double exponent = Convert.ToDouble(partes[1].Trim());
                   
                    return Math.Pow(baseNum, exponent); //Retorna el resultado de la potencia
                }

                //Crea la instancia de la clase DataTable, que se utiliza para realizar cálculos de expresiones
                var table = new System.Data.DataTable();

                /*Usa el metodo Compute para evualuar expresions que se pasa como una cadena
                 expression contiene la cadena que es se usa como expresion*/
                var value = table.Compute(expression, null);

                return Convert.ToDouble(value); //Convierte el resultado de la evaluacion a tipo double y se retorna
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la expresion " + ex.Message);
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