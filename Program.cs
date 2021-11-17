using System;

namespace OrdenamientoYBusqueda
{
    class Program
    {
        static void Main()
        {
            int[] A = { 3, 5, 1, 9, 2, 4 };
            ImprimeMatriz(A);
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
