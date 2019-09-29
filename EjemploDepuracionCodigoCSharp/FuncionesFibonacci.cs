using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDepuracionCodigoCSharp
{
    public class FuncionesFibonacci : Funciones
    {

        public List<int> rellenarFibo()
        {
            int a = 0;
            int b = 1;
            List<int> valores = new List<int>();
            //for (int i = 0; i < this.getNumero(); i++)
            //{
            //    int temp = a;
            //    valores.Add(a);
            //    a = b;
            //    b = temp + b;
            //}
            int i = 0;
            while (i <= this.getNumero()) {
                int temp = a;
                valores.Add(a);
                a = b;
                b = temp + b;
                i++;
            }
            return valores;
        }

    }
}
