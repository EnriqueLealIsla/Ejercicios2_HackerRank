using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable
            int[] arr = new int[100];
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar_Long = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            int result_int = 0;

            // Generar 100 números positivos aleatorios
            Random random = new Random();
            int Ejercicio = 0;
            int val1 = 0;
            int val2 = 0;
            int sum = 0;
            #endregion
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 1001);
            }

            switch (Ejercicio)
            {
                case 1:
                    #region Ejercicio de imprimir mediante array posiciones
                    char character = '#';
                    char space = ' ';
                    char[] CharToArray = ("").ToCharArray();
                    int Cantidad = 6;

                    for (int x = 1; x <= Cantidad; x++)
                    {
                        string Response = new string(space, Cantidad - x) + new string(character, x);
                        Console.WriteLine(Response);
                    }
                    #endregion
                    break;
                case 2:
                    #region eje 
                    double Cantidad_array = arr.Count();
                    decimal Resultado = 0;
                    int[] numerosPositivos = arr.Where(num => num > 0).DefaultIfEmpty(404).ToArray();
                    int[] numerosNegativos = arr.Where(num => num < 0).DefaultIfEmpty(404).ToArray();
                    int[] numerosZero = arr.Where(num => num == 0).DefaultIfEmpty(404).ToArray();

                    if (numerosPositivos[0].Equals(404))
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    else
                        Resultado = (decimal)Convert.ToDouble((int)numerosPositivos.Count() / Cantidad_array);

                    Resultado = Math.Round(Resultado, (int)6);

                    Console.WriteLine(Resultado);

                    Resultado = 0;
                    if (numerosNegativos[0].Equals(404))
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    else
                        Resultado = (decimal)Convert.ToDouble((int)numerosNegativos.Count() / Cantidad_array);

                    Resultado = Math.Round(Resultado, (int)6);

                    Console.WriteLine(Resultado);

                    Resultado = 0;
                    if (numerosZero[0].Equals(404))
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    else
                        Resultado = (decimal)Convert.ToDouble((int)numerosZero.Count() / Cantidad_array);

                    Resultado = Math.Round(Resultado, (int)6);

                    Console.WriteLine(Resultado);
                    #endregion
                    break;
                case 3:
                     val1 = Convert.ToInt32(Console.ReadLine());
                     val2 = Convert.ToInt32(Console.ReadLine());
                     sum = solveMeFirst(val1, val2);
                    Console.WriteLine(sum);
                    break;
                case 4:
                    sum = simpleArraySum(ar);
                    break;
                case 5:
                    long result = aVeryBigSum(ar_Long);
                    break;
                case 6:
                    int n = Convert.ToInt32(Console.ReadLine().Trim());

                    List<List<int>> arr2 = new List<List<int>>();

                    for (int i = 0; i < n; i++)
                    {
                        arr2.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                    }

                    result_int = diagonalDifference(arr2);
                    break;
                case 7:
                    int n_new = Convert.ToInt32(Console.ReadLine().Trim());

                    List<int> arr3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                    plusMinus(arr3);
                    break;
                case 8:
                    int n_new8 = Convert.ToInt32(Console.ReadLine().Trim());

                    staircase(n_new8);
                    break;
                default:

                    break;
            }

            
            
           

            Console.ReadLine();
        }
        static int solveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            return a + b;
        }
        public static int simpleArraySum(List<int> ar)
        {
            //int suma = ar.Sum();

            return ar.Sum();
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int PuntosAlice = 0;
            int PuntosBob = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i])
                {

                }
                if (a[i] > b[i])
                    PuntosAlice++;
                if (b[i] > a[i])
                    PuntosBob++;
            }
            List<int> ListaResultados = new List<int>();

            ListaResultados.Add(PuntosAlice);
            ListaResultados.Add(PuntosBob);

            return ListaResultados;
        }
        public static long aVeryBigSum(List<long> ar)
        {
            long Suma_resultado = 0;

            foreach (int item in ar)
                Suma_resultado += item;

            return Suma_resultado;
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int CantidadDimencional = arr[0].Count();
            int Total_Foreach = CantidadDimencional / 3;
            int Suma1 = 0;
            int Suma2 = 0;

            for (int i = 0; i < CantidadDimencional; i++)
            {
                Suma1 += arr[i][i];
                Suma2 += arr[i][(CantidadDimencional - i) - 1];
            }

            if (Suma2 > Suma1)
                return Suma2 - Suma1;
            else
                return Suma1 - Suma2;
        }
        public static void plusMinus(List<int> arr)
        {

            double Cantidad_array = arr.Count();
            decimal Resultado = 0;
            int[] numerosPositivos = arr.Where(num => num > 0).DefaultIfEmpty(404).ToArray();
            int[] numerosNegativos = arr.Where(num => num < 0).DefaultIfEmpty(404).ToArray();
            int[] numerosZero = arr.Where(num => num == 0).DefaultIfEmpty(404).ToArray();

            if (numerosPositivos[0].Equals(404))
                Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
            else
                Resultado = (decimal)Convert.ToDouble((int)numerosPositivos.Count() / Cantidad_array);

            Resultado = Math.Round(Resultado, (int)6);

            Console.WriteLine(Resultado);

            Resultado = 0;
            if (numerosNegativos[0].Equals(404))
                Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
            else
                Resultado = (decimal)Convert.ToDouble((int)numerosNegativos.Count() / Cantidad_array);

            Resultado = Math.Round(Resultado, (int)6);

            Console.WriteLine(Resultado);

            Resultado = 0;
            if (numerosZero[0].Equals(404))
                Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
            else
                Resultado = (decimal)Convert.ToDouble((int)numerosZero.Count() / Cantidad_array);

            Resultado = Math.Round(Resultado, (int)6);

            Console.WriteLine(Resultado);
        }

        public static void staircase(int n)
        {
            char character = '#';
            char space = ' ';
            char[] CharToArray = ("").ToCharArray();

            for (int x = 1; x <= n; x++)
            {
                string Response = new string(space, n - x) + new string(character, x);
                Console.WriteLine(Response);
            }



        }
        }
    }
}
