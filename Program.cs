using System;

namespace OrdenamientoYBusqueda
{
    class Program
    {
        static void Main()
        {
            int[] A = { 3, 5, 1, 9, 2, 4 };
            ImprimeMatriz(A);
            int indice = Busqueda.Directa(A,11);
            if(indice != -1  )
            {
                Console.WriteLine("El número buscado está en la posición: {0}", indice);
            }
            else
            {
                Console.WriteLine("No se encuentra el valor en el arreglo");
            }

            Ordenamiento.Burbuja(A);
            ImprimeMatriz(A);
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
