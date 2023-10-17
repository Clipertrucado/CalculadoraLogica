using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalLog.Servicios
{
    internal interface OperacionInterface
    {
       
        public string Igualdad(string d1, string d2);

        
        public string Desigualdad(string d1, string d2);

        
        public string Datos();
    }
}

