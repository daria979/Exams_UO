using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentele_Programarii_Sem1
{
    class Program
    {
        static void problema1(ref int n)
        {
            int q=1, cif, numar=0;
            
            do
            {
                cif = n % 10;
                cif = 9 - cif;
                n = n / 10;
                numar = q * cif + numar;
                q = q * 10;
            }while (n == 0);
            n = numar;
        }

        private static void problema2(int v[],int t)
        {
 
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] <= t)
                {
                    int k = t - v[i];
                    for (int j = i + 1; j < v.Length; j++)
                    {
                        if (v[j] == k)
                        {
                            Console.Write($"{i} {j}");
                        }
                    }
                }
            }
        }

        static void problema3()
        {
            List<int> Numere = new List<int>();

            int x,M1=1,M2=1,M3=1;
            x = int.Parse(Console.ReadLine());
            Numere.Add(x);
            while (x!=0)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                    break;
                else
                {
                    Numere.Add(x);
                    
                }
                 
            }
            
            foreach(var item in Numere)
            {
                int n = item;
                if (n >= M1)
                {
                    int aux = M1;
                    M1 = n;
                    n = aux;
                }

                if (n >= M2 && n <= M1)
                {
                    int aux = M2;
                    M2 = n;
                    n = aux;
                }

                if (n >= M3)
                {
                    int aux = M3;
                    M3 = n;
                    n = aux;
                }

                if (M2 >= M1)
                {
                    int aux = M1;
                    M1 = M2;
                    M2 = aux;
                }

                if (M3 >= M2)
                {
                    int aux = M2;
                    M2 = M3;
                    M3 = aux;
                }
            }
            Console.WriteLine();
            
            Console.Write($"{M3}, {M2}, {M1}");
        }

        static bool PrimNumber(int n) 
        {
            if (n % 2 == 0) return false;
            if (n == 2) return true;
            for (int p = 3; p <=Math.Sqrt(n); p= p + 2)
                if (n % p == 0)
                    return false;
            return true;
        }
        private static void problema4()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] M = new int[n, n];
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int y;
                    y = int.Parse(Console.ReadLine());
                    M[i, j] = y;

                    //n-1 pentru ca incepe de la 0
                    if (i + j > n - 1) //conditia pt numerele de sub diagonala secundara
                    {
                        if (PrimNumber(M[i, j])==true)
                        {
                            Sum =Sum+ M[i, j];
                        }
                    }
                }
            }
            Console.WriteLine(Sum);
        }

        private static int problema7(int k,int n)
        {
            k = -1;
            int cif = n % 10;
            if(n/10!=0)
            {
                if ((cif) % 2 == 0)
                {
                    if (cif < k || k == -1)
                        return problema7(cif, n / 10);
                    else
                        return problema7(k, n / 10);
                }
            }
              else
                 return -1;
         }
        
        static void Main(string[] args)
        {
           
        }
    }
}
