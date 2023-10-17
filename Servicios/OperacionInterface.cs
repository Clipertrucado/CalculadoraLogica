using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalLog.Servicios
{
    internal interface OperacionInterface
    {
        /// <summary>
        /// sera el metodo al que llamaremos para comparar la igualdad
        /// sav - 17/10/2023
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public string Igualdad(string d1, string d2);

        /// <summary>
        /// sera el metodo al que llamaremos para comparar la desigualdad
        /// sav - 17/10/2023 
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public string Desigualdad(string d1, string d2);

        /// <summary>
        /// sera el encargado de fuardar los datos que despues compararemos 
        /// </summary>
        /// <returns></returns>
        public string Datos();
    }
}

