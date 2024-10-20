using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyecto_calculadora.Modelo
{
    public class Modelo_Calculadora
    {
        private int id_expresion { get; set;}
        private string expresion { get; set;}
        private double resultado { get; set;}
        private DateTime fecha_hora { get; set;}

        public Modelo_Calculadora (string expresion, double resultado)
        {
            this.expresion = expresion;
            this.resultado = resultado;
        }

    }
}
