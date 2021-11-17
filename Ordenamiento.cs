using System;

namespace OrdenamientoYBusqueda
{
    class Ordenamiento
    {
        public static void Burbuja(int [] A )
        {
            int N = A.Length;  //Número de elementos del arreglo
            
            // A= {3,5,1,9,2,4
            for( int j=0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    //i=1                    
                    //A[2] < A[1]
                    // 1       5
                    if (A[i + 1] < A[i])
                    {
                        //Aux = 5
                        int Aux = A[i];
                        //A[1] =A[2]
                        //A[1]= 1
                        A[i] = A[i + 1];
                        //A[2]= 5
                        A[i + 1] = Aux;

                    }
                }

            }
            



        }

    }
}
