using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYD_sample_text
{
    static class String_RYD {
        public static void InvertedString(string s) {
            /*
             * Declaración e inicialización de variables para almacenar la cantidad de veces en las que se repite la letra "e"
             * y se crea un array para poder imprimir el texto al revés y realizar la operación de búsqueda
             */
            int countLetter = 0;
            char[] arr = s.ToCharArray();

            //invierte las posiciones del texto
            Array.Reverse(arr);
            //Imprime resultado, de texto normal y texto al revés, por consola
            Console.WriteLine("El {0} -> {1}", s, new String(arr));

            //Ciclo que realiza la búsqueda de la letra e
            for (int i = 0; i < arr.Length; ++i)
            {
                //Si el valor del índice del array es igual a la letra "e" se incrementa en uno la frecuencia de la letra
                if (arr[i] == 'e')
                {
                    countLetter++;
                }
            }

            //Imprime por consola la frecuencia de la letra e
            Console.WriteLine("Frecuencia de e -> {0}", countLetter);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Función que permite introducir texto desde teclado
            Console.WriteLine("Por favor introduce un texto");
            //Se cacha el texto introducido por teclado en una variable para su posterior tratamiento
            string text = Console.ReadLine();

            //Se llama función que imprime el texto al revés e indica las veces que aparece la letra e
            String_RYD.InvertedString(text);

            //Lineas de código para poder tener activa la consola y no se cierre automáticamente
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
        }
    }
}
