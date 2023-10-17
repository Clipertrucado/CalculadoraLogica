using CalLog.Servicios;

namespace CalLog.Controladores
{
    /// <summary>
    /// Clase principal del programa
    /// 101023 - sav
    /// </summary>

    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicación
        /// 101023 - sav
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            MenuInterface menuInterfaz = new MenuImplementacion();
            OperacionInterface operacionInter = new OperacionImplementacion();

            //creamos un tipo bool para poder cerrar el while
            bool cerrarMenu = false;


            // este int sera el encargado de guardar el valor seleccionado en el menu
            int opcionSeleccionada;

            //crearemos un while para que nos mantengamos en el menu siempre que no se diga lo contrario
            while (!cerrarMenu)
            {
                //llamamos al metodo menu 
                opcionSeleccionada = menuInterfaz.Menu();


                Console.WriteLine(opcionSeleccionada);

                //creo las variables que usare para comparar y escribir el resultado 
                string d1;
                string d2;
                string resul;

                //le damos a estas variables el valor que devuelve la llamada al metodo
                d1 = operacionInter.Datos();
                d2 = operacionInter.Datos();

                //compara la opcion seleccionada y entra en el casos correcto
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso uno 0");
                        cerrarMenu = true;
                        break;

                    case 1:

                        //le damos el valor de la llamada al metodo y le pasamos los datos que obtuvimos del metodo "Datos"
                        resul = operacionInter.Igualdad(d1, d2);
                        Console.WriteLine("El resultado de la igualdad es: " + resul);
                        break;

                    case 2:

                        resul = operacionInter.Desigualdad(d1, d2);
                        Console.WriteLine("El resultado de la desigualdad es: " + resul);
                        break;

                    default:
                        Console.WriteLine("");
                        break;

                }

            }

        }

    }

}