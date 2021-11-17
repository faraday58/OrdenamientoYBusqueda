using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
