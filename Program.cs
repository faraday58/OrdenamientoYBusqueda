using System;
using System.Diagnostics;
namespace OrdenamientoYBusqueda
{
    class Program
    {
        static void Main()
        {
            //int[] A = { 3, 5, 1, 9, 2, 4 };
            Random random = new Random();
            int N = 5000;
            int[] A = new int[N];
            for(int i=0; i< N; i++)
            {
                A[i]= (int)(random.NextDouble() * 1000);
            }
             
           // ImprimeMatriz(A);
            /*int indice = Busqueda.Directa(A,11);
            if(indice != -1  )
            {
                Console.WriteLine("El número buscado está en la posición: {0}", indice);
            }
            else
            {
                Console.WriteLine("No se encuentra el valor en el arreglo");
            }*/

            Stopwatch sw = new Stopwatch();
            sw.Start();
            //Instrucción a medir rendimiento
            Ordenamiento.Burbuja(A);
            sw.Stop();          


            ImprimeMatriz(A);
            Console.WriteLine(" \n \n Tiempo de ejecución del algoritmo de burbuja es: {0} [ms]", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        static void ImprimeMatriz(int[] A)
        {
            foreach(int elemento in A)
            {
                Console.Write("{0}, ",elemento);
            }
            Console.WriteLine();
        }

    }
}
