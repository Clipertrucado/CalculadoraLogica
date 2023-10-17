using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalLog.Servicios
{
    internal class OperacionImplementacion : OperacionInterface
    {

        public string Desigualdad(string d1, string d2)
        {
            
            string d3;

            //creamos un if en el que se comparen los dos datos introducidos y dependiendo de si es verdadero o falso devolvera uno opcion u otra
            if (String.Equals(d1, d2))
            {
                d3 = "Falso";
            }
            else
            {
                d3 = "verdadero";
            }

            return d3;
        }

        public string Igualdad(string d1, string d2)
        {
            string d3;
            if (String.Equals(d1, d2))
            {
                d3 = "Verdadero";
            }
            else
            {
                d3 = "Falso";
            }

            return d3;

        }

        public string Datos()
        {

            string d;

            Console.WriteLine("Ingresa una cadena de caracteres para comparar");
            d = (Console.ReadLine());

            return (d);
        }
    }
}
