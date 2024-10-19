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
                MessageBox.Show("Conexion Establecida");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error el intentar establecer la conexion ", ex.Message);
            }

        }
    }
}
