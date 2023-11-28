/* _______________________________________________________________
   |                                                             |        
   | -Nombre del estudiante: Jose David Carranza Angarita        |
   |                                                             |                                       
   |  - Grupo: 213022_77                                         |  
   |                                                             |
   | -Carrera: Ingeniería de Sistemas.                           |                                                              
   |                                                             |              
   |  - Número: Problema #2 - Ejercicio #8                       |
   |                                                             |
   | -Código Fuente: autoría propia.                             |
   |                                                             |
   | -Laboratorio Virtual Paso 5  - fundamentos de programación. |                
   |_____________________________________________________________|
  */


/*________________________________________________________________________________________________
  |                                                                                               |
  |  - En la empresa Colpensiones se requiere un sistema de información así:                      |
  |                                                                                               |
  |  - Por teclado se debe solicitar la cantidad de usuarios a valorar.                           |
  |    (ejemplosi digita 5 deberá repetir los pasos siguientes 5 veces).                          |
  |                                                                                               |
  |  - Se requiere captura por teclado de nombre y edad (siendo la edad un número entero).        | 
  |                                                                                               |
  |  -  Se debe calcular e imprimir en consola el valor total de personas que sí pueden jubilarse |
  |     y el número total de personas que no pueden jubilarse aún.                                |
  |                                                                                               |
  |  - NOTA: La edad de jubilación en hombres es de 62 años.                                      |
  |                                                                                               |
  |  - La edad dejubilación en mujeres es de 57 años.                                             |
  |_______________________________________________________________________________________________|
*/


using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colpencionesS.A.S
{

    class Program
    {
        public static void Main(string[] args)
        {
            // Damos titulo a la consola del programa
            Console.Title = "COLPENSIONES S.A.S";

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Configuracion de la consola para  introducir y mostrar emojis por consola usando codificación UTF-8
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            //llamamos a la funcion que nos muestra el baner de Colpensiones
            banerColpensiones();

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Llamada a la función validacionDeTrabajadores
            int[] numerosDeUsuarios = validacionDeTrabajadores();

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Llamada a la función AsignarNombresUsuarios
            string[] nombresDeUsuarios = AsignarNombresUsuarios(numerosDeUsuarios);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Llamada a la función AsignarGeneroUsuarios
            string[] generosDeUsuarios = AsignarGeneroUsuarios(numerosDeUsuarios);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Llamada a la función AsignarEdadUsuarios
            int[] edadesDeUsuarios = AsignarEdadUsuarios(numerosDeUsuarios);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Llamada a la función CalcularJubilacion
            CalcularJubilacion(generosDeUsuarios, edadesDeUsuarios ,nombresDeUsuarios);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            Console.ReadKey();

        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // creamos una funcion que nos muestre el banner de Colpensiones S.A.S
        static void banerColpensiones()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n     👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                   BIENVENID@S A COLPENSIONES S.A.S                 \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵👴👵");

        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/


        // Función para almacenar el numero de ususarios a validar en el sistema de Colpensiones S.A.S
        static int[] validacionDeTrabajadores()
        {
            Console.WriteLine("\n\n💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰\n");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("¿Cuantos usuarios desea validar?: ");
            Console.ForegroundColor = ConsoleColor.Green; string input = Console.ReadLine();

            int cantidadUsuarios;
            // Validación de entrada de datos solo números si no es un número se repite el ciclo while
            while (!int.TryParse(input, out cantidadUsuarios))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n¿Cuantos usuarios desea validar?: ");
                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();
            }
            int[] numerosDeUsuarios = new int[cantidadUsuarios];
            Console.WriteLine($"\nValidaremos en el sistema a los siguientes {numerosDeUsuarios.Length} usuarios.");
            Console.WriteLine("\n💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰\n");
            return numerosDeUsuarios;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para asignar nombres a los usuarios a validar en el sistema de Colpensiones S.A.S
        static string[] AsignarNombresUsuarios(int[] numerosDeUsuarios)
        {
            string[] nombresDeUsuarios = new string[numerosDeUsuarios.Length];
            for (int i = 0; i < numerosDeUsuarios.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el nombre del usuario " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                string nombreUsuarios = Console.ReadLine();
                while (!System.Text.RegularExpressions.Regex.IsMatch(nombreUsuarios, @"^[a-zA-ZñÑ\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, ingrese solo letras.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ingrese el nombre del suario " + (i + 1) + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    nombreUsuarios = Console.ReadLine();
                }
                nombresDeUsuarios[i] = nombreUsuarios;
            }
            return nombresDeUsuarios;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para asignar el género a los usuarios
        static string[] AsignarGeneroUsuarios(int[] numerosDeUsuarios)
        {
            string[] generosDeUsuarios = new string[numerosDeUsuarios.Length];

            Console.WriteLine("\n💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰\n");
            for (int i = 0; i < numerosDeUsuarios.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el género del usuario " + (i + 1) + " (M para masculino, F para femenino): ");
                Console.ForegroundColor = ConsoleColor.Green;
                string genero = Console.ReadLine().ToUpper();
                while (genero != "M" && genero != "F")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, ingrese M para masculino o F para femenino.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nIngrese el género del usuario " + (i + 1) + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    genero = Console.ReadLine().ToUpper();
                }
                generosDeUsuarios[i] = genero;
            }
            return generosDeUsuarios;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para asignar la edad a los usuarios
        static int[] AsignarEdadUsuarios(int[] numerosDeUsuarios)
        {
            int[] edadesDeUsuarios = new int[numerosDeUsuarios.Length];
            Console.WriteLine("\n💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰\n");
            for (int i = 0; i < numerosDeUsuarios.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese la edad del usuario " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                int edad;
                while (!int.TryParse(input, out edad))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nIngrese la edad del usuario " + (i + 1) + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine();
                }
                edadesDeUsuarios[i] = edad;
            }
            return edadesDeUsuarios;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para calcular el número de personas que pueden jubilarse
        static void CalcularJubilacion(string[] generosDeUsuarios, int[] edadesDeUsuarios, string[]nombresDeUsuarios)
        {
            int jubilados = 0;
            int noJubilados = 0;
            for (int i = 0; i < generosDeUsuarios.Length; i++)
            {
                if ((generosDeUsuarios[i] == "M" && edadesDeUsuarios[i] >= 62) || (generosDeUsuarios[i] == "F" && edadesDeUsuarios[i] >= 57))
                {
                    jubilados++;
                }
                else
                {
                    noJubilados++;
                }
            }
            Console.WriteLine("\n💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("\nResultado de las validaciones de los usuarios:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEl número total de personas que pueden jubilarse es: " );
            Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{jubilados}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("El número total de personas que no pueden jubilarse aún es: ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{ noJubilados}\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================================================");
            //Iprimimos los nombres de los que se pueden jubilar porque cumplieron los requisitos de edad
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nLos nombres de los usuarios que pueden jubilarse son: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < generosDeUsuarios.Length; i++)
            {
                if ((generosDeUsuarios[i] == "M" && edadesDeUsuarios[i] >= 62) || (generosDeUsuarios[i] == "F" && edadesDeUsuarios[i] >= 57))
                {
                    Console.Write($"{nombresDeUsuarios[i]}, ");
                }
            }
            Console.WriteLine("\n");
            //Iprimimos los nombres de los que no se pueden jubilar porque no cumplieron los requisitos de edad
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Los nombres de los usuarios que no pueden jubilarse aún son: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < generosDeUsuarios.Length; i++)
            {
                if ((generosDeUsuarios[i] == "M" && edadesDeUsuarios[i] < 62) || (generosDeUsuarios[i] == "F" && edadesDeUsuarios[i] < 57))
                {
                    Console.Write($"{nombresDeUsuarios[i]}, ");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰💼📅💰");
        }



    }

}













