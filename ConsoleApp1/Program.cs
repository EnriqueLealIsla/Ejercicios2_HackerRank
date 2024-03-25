using System;
using System.Collections.Generic;
using System.Globalization;
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
            long[] arrLong = new long[100];
            List<int> ar = arr.ToList();
            List<int> a = arr.ToList();

            List<int> b = arr.ToList();

            int arCount = arr.Count();

            List<long> ar_Long = arrLong.ToList();

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
            Console.WriteLine("Acceso");
            for (int i = 0; i < arr.Length; i++)
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
                    double Cantidad_array = arr.Count();
                    if (numerosPositivos[0].Equals(404))
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    else
                        Resultado = (decimal)Convert.ToDouble((int)numerosPositivos.Count() / Cantidad_array);

                    Resultado = Math.Round(Resultado, (int)6);
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    Console.WriteLine(Resultado);
                        Resultado = (decimal)Convert.ToDouble((int)numerosPositivos.Count() / Cantidad_array);
                    Resultado = 0;
                    if (numerosNegativos[0].Equals(404))
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    else
                        Resultado = (decimal)Convert.ToDouble((int)numerosNegativos.Count() / Cantidad_array);
                    Resultado = 0;
                    Resultado = Math.Round(Resultado, (int)6);
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    Console.WriteLine(Resultado);
                        Resultado = (decimal)Convert.ToDouble((int)numerosNegativos.Count() / Cantidad_array);
                    Resultado = 0;
                    if (numerosZero[0].Equals(404))
                        Resultado = (decimal)Convert.ToDouble((int)0 / Cantidad_array);
                    else
                        Resultado = (decimal)Convert.ToDouble((int)numerosZero.Count() / Cantidad_array);

                    Resultado = Math.Round(Resultado, (int)6);

                    Console.WriteLine(Resultado);
                    #endregion

                    Resultado = Math.Round(Resultado, (int)6);

                    Console.WriteLine(Resultado);
                    #endregion
                    break;
                case 2:
                    Eje(arr);
                    break;
                case 3:
                    val1 = Convert.ToInt32(Console.ReadLine());
                    val2 = Convert.ToInt32(Console.ReadLine());
                    sum = simpleClasses.solveMeFirst(val1, val2);
                    Console.WriteLine(sum);
                    break;
                    long result = aVeryBigSum(ar_Long);
                    sum = simpleArraySum(ar);
                    Console.WriteLine(sum);
                    break;
                case 5:
                    long result = aVeryBigSum(ar_Long);
                    break;
                case 6:
                    int n = Convert.ToInt32(Console.ReadLine().Trim());

                    List<List<int>> arr2 = new List<List<int>>();

                    result_int = diagonalDifference(arr2);
                    {
                        arr2.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                    }

                    result_int = diagonalDifference(arr2);
                    break;
                case 7:
                    List<int> arr3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
                    {
                        Console.WriteLine("Ingrese un número entero:");
                        int n_new = Convert.ToInt32(Console.ReadLine().Trim());

                    List<int> arr3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                    break;
                case 8:
                    Console.WriteLine("Ingrese un número entero:");
                    int n_new8 = Convert.ToInt32(Console.ReadLine().Trim());

                    simpleClasses.staircase(n_new8);
                    break;
                case 9:
                    List<int> miArreglo = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };
                    int ContadorMaximo = miArreglo.Count();
                    int[] arregloOrdenado = miArreglo.OrderBy(numero => numero).ToArray();

                    long SumaMinimo = arregloOrdenado[0];
                    long SumaMaximo = arregloOrdenado[ContadorMaximo - 1];
                    long R1 = 0;
                    long R2 = 0;

                    for (int i = 1; i < ContadorMaximo - 1; i++)
                    {
                        SumaMinimo += arregloOrdenado[i];
                        SumaMaximo += arregloOrdenado[i];
                    }
                    Console.WriteLine(SumaMinimo + " " + SumaMaximo);
                    break;
                case 10:
                    List<int> candles = new List<int> { 3, 2, 1, 3 };
                    int Count_candles = candles.Count();
                    int Cantidad_max = candles.Max();

                    int[] candlesCantidadMax = candles.Where(num => num == Cantidad_max).ToArray();

                    Console.WriteLine(candlesCantidadMax.Count());
                    break;
                case 11:
                    string Fecha = "07:05:45PM";
                    DateTime fechaConvertida = DateTime.ParseExact(Fecha, "hh:mm:sstt", CultureInfo.InvariantCulture);
                    Console.WriteLine(fechaConvertida.ToString("HH:mm:ss"));
                    break;
                case 12:
                    List<int> UniverityRank = new List<int> { 73, 67, 38, 33 };


                    for (int i = 0; i < UniverityRank.Count(); i++)
                    {
                        int rank = UniverityRank[i];
                        double Multiplier = Math.Ceiling((double)rank / 5) * 5;

                        if (Multiplier - Convert.ToInt32(UniverityRank[i]) < 0)
                        {
                            Multiplier += 5;
                        }

                        if (UniverityRank[i] > 34)
                        {
                            if (Multiplier - rank < 3 && Multiplier - rank > 0)
                            {

                                if (UniverityRank[i] < 41 && Multiplier - rank > 0)
                                {
                                    UniverityRank[i] = 40;
                                }
                                else
                                {
                                    UniverityRank[i] = (int)Multiplier;
                                }

                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }


                        Console.WriteLine(UniverityRank[i]);
                    }
                    break;
                default:



                    break;
            }


        static int solveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            return a + b;
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

        public static List<int> GenerateRandomNumbers()
        {
            // Crear una lista para almacenar los números aleatorios
            List<int> randomNumbers = new List<int>();

            // Generar 100 números positivos aleatorios
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = random.Next(1, 1001);
                randomNumbers.Add(randomNumber);
            }

            return randomNumbers;
        }


    }

    public class RandomService
    {
        private readonly Random random;

        public RandomService()
        {
            random = new Random();
        }

        public List<int> GenerateRandomNumbers(int count)
        {
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
    }
    

            return randomNumbers;
        }
    }
    
}
