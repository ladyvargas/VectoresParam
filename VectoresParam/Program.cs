using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int n = 10;
            int []x = new int[MAX];
            leer(x);
            imprimir(x);
            buscar(x, n);
            if (buscar(x, n))
            {
                Console.WriteLine("\nNumero encontrado = {0} ", n);
            }
            else
            {
                Console.WriteLine("\nNumero no encontrado = {0} ", n);
            }
            buscar2(x, n);
            if (buscar2(x, n))
            {
                Console.WriteLine("\nNumero encontrado = {0} ", n);
            }
            else
            {
                Console.WriteLine("\nNumero no encontrado = {0} ", n);
            }
            Console.ReadKey();
        }
        public static void leer(int[] x)
        {
            for (int i =0; i<MAX; i++)
            {
                Console.WriteLine("\nIngresa el elemento {0}", i+0);
                x[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void imprimir(int[] x)
        {
            int  b;
            foreach (int num in x)
            {
                Console.WriteLine("\nElemento {0}", num);
            }
        }

        public static bool buscar(int[] x, int a)
        {
            bool n = false;
            foreach (int num in x)
            {
                if (a == num)
                {
                    n = true;
                    break;
                }
                else
                {
                    n = false;
                }
            }
            return n;
        }

        public static bool buscar2(int[] x, int a)
        {
            bool e = false;
            int i = 0;
            while (i<MAX && e==false)
            {
                if (x[i]==a)
                {
                    e = true;
                }
                i++;
            }
            return e;
        }
    }
}
