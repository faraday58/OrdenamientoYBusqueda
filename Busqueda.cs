using System;

namespace OrdenamientoYBusqueda
{
    class Busqueda
    {
        public static int Directa(int[] A, int X )
        {
            int N = A.Length;
            for(int i=0; i< N; i++  )
            {
                if(A[i] == X  )
                {
                    return i ;
                }
            }
            return -1;

        }



    }
}
