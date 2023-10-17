using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalLog.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        public int Menu()
        {
            //sera el encargado de recoger el valor que el usuario seleccione 
            int opcionIntroducida;

            Console.WriteLine("#################################");
            Console.WriteLine("      0. Cerrar aplicación");
            Console.WriteLine("      1. Igualdad");
            Console.WriteLine("      2. Desigualdad");
            Console.WriteLine("#################################");

            //le da el valor de un solo digito 
            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            //Le devuelve a quien lo llamo "opcionIntroducida"
            return opcionIntroducida;

        }
    }
}
