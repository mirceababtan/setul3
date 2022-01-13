using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul3
{
    class Program
    {

        private static void problema1()
        {
            int n,suma=0;
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Introduceti elementele:");
            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                suma += array[i];
            }

            Console.WriteLine($"Suma elementelor este egala cu {suma}");

        }

        private static void problema2()
        {
            int n, k,poz=-1;
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti k:");
            k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Introduceti elementele:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] == k)
                {
                    poz = i;
                    break;
                }

            }

            Console.WriteLine(poz);
        }

        private static void problema3()
        {
            int n, pozMax=0, pozMin=0, Max, Min;
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());


            int[] array = new int[n];
            Console.WriteLine("Introduceti elementele:");

            array[0] = int.Parse(Console.ReadLine());
            Max = array[0];
            Min = array[0];

            for (int i = 1; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > Max)
                {
                    Max = array[i];
                    pozMax = i;
                }
                if (array[i] < Min)
                {
                    Min = array[i];
                    pozMin = i;
                }
            }

            Console.WriteLine($"Pozitia maximului este {pozMax}, iar a minimului {pozMin}.");
        }

        private static void problema4()
        {
            int n, apMax = 1, apMin = 1, Max, Min;
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());


            int[] array = new int[n];
            Console.WriteLine("Introduceti elementele:");

            array[0] = int.Parse(Console.ReadLine());
            Max = array[0];
            Min = array[0];

            for (int i = 1; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] == Max)
                {
                    apMax++;
                }
                else if(array[i]>Max)
                {
                    Max = array[i];
                    apMax = 1;
                }
                if (array[i] == Min)
                {
                    apMin++;
                }
                else if(array[i]<Min)
                {
                    Min = array[i];
                    apMin = 1;
                }
            }

            Console.WriteLine($"Maximul este {Max} si apare de {apMax} ori, iar a minimul {Min} si apare de {apMin}.");
        }

        private static void problema5()
        {
            int n, e, k;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("valoarea e=");
            e = int.Parse(Console.ReadLine());

            Console.WriteLine("pozitia k=");
            k = int.Parse(Console.ReadLine());

            int[] array = new int[n + 1];

            Console.WriteLine("Introduceti secventa:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n-1; i >= k; i--)
            {
                array[i+1] = array[i];
                if (i == k)
                    array[k] = e;
            }
            n++;
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

        }

        private static void problema6()
        {
            int n, k;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("k=");
            k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Introduceti secventa:");

            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if(k+1 <= i)
                {
                    array[i - 1] = array[i];
                }
            }
            n--;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }

        private static void problema7()
        {
            int n;
            Console.WriteLine("introduceti n=");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int[] auxArray = new int[n];

            Console.WriteLine("introduceti elementele vectorului:");

            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0, v = n-1; i < n; i++, v--)
            {
                auxArray[i] = array[v];
            }

            for(int i=0;i<n;i++)
            {
                Console.WriteLine(auxArray[i] + " ");
            }
        }

        private static void problema8()
        {
            int n,k;
            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("introducet secventa:");

            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            k = array[0];
            for(int i=0;i<n-1;i++)
            {
                array[i] = array[i + 1];
            }
            array[n-1] = k;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }

        private static void problema9()
        {
            int n, k;
            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("k=");
            k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int[] auxArray = new int[2 * n];

            Console.WriteLine("Introduceti secventa:");
            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                auxArray[i] = array[i];
                auxArray[i + n] = array[i];
            }

            for(int i=n-k+1,j=0;i<=n+k-1;i++,j++)
            {
                array[j] = auxArray[i];
            }
            for(int i=0;i<n;i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int problema10(int[] array,int val, int low, int upp)
        {
            if (low > upp)
                return -1;
            else
            {
                int mij;
                mij = (upp + low) / 2;
                if (val < array[mij])
                    problema10(array,val, low, mij - 1);
                else if (val == array[mij])
                    return mij;
                else
                    problema10(array,val, mij + 1, upp);
                return array[mij];
            }

        }

        private static void problema11()
        {
            int n;
            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            array[0] = 1;
            array[1] = 1;

            for(int i=2;i<Math.Sqrt(n);i++)
            {
                if (array[i] == 0)
                {
                    for (int j = i; j < n / i; j++)
                    {
                        array[i * j] = 1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {

                if(array[i] == 0)
                { 
                Console.WriteLine(i + " ");
                }
            }
        }

        private static void problema12()
        {
            int[] array = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            int n = 10;
            Console.WriteLine("Sortare prin selectie");
            Console.WriteLine("Vectorul initial:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            int aux, min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                aux = array[min];
                array[min] = array[i];
                array[i] = aux;
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul sortat:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        private static void problema13()
        {
            int[] array = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int n = 10, val, ok;
            Console.WriteLine("Sortare prin insertie");
            Console.WriteLine("Vectorul initial:");
            for (int i  = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            for (int i = 1; i < n; i++)
            {
                val = array[i];
                ok = 0;
                for (int j = i - 1; j >= 0 && ok != 1;)
                {
                    if (val < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = val;
                    }
                    else
                    {
                        ok = 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul sortat:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static void problema14()
        {
            int n = 10, k = 0, aux;
            int[] array = new int[10] { 0, 11, 23, 0, 14, 0, 0, 73, 4, 2 };

            Console.WriteLine("Vectorul initial:");
            for(int i=0;i<n;i++)
            {
                Console.Write(array[i] + " ");
            }

            for(int i=0;i<n-k;i++)
            {
                if(array[i] == 0)
                {
                    if (k == 0)
                    {
                        array[i] = array[i+1];
                    }
                    else
                    {
                        array[i] = array[i + k];
                    }
                        k++;
                }    
            }
            for(int i=n-k;i<n;i++)
            {
                array[i] = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul final:");
            for(int i=0;i<n;i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        private static void problema15()
        {

        }

        static void Main(string[] args)
        {
            //problema1();

            //problema2();

            //problema3();

            //problema4();

            //problema5();

            //problema6();

            //problema7();

            //problema8();

            //problema9();


            //int[] array = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(problema10(array, 3, 0, 4));

            //problema11();

            //problema12();

            //problema13();

            //problema14();

            problema15();

        }
    }
}
