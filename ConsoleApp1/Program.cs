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
            int[] arr = new int[100]; // Crear un array de 100 elementos
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1; // Llenar el array con valores del 1 al 100
            }

            long[] arrLong = new long[100]; // Crear un array de long de 100 elementos
            for (int i = 0; i < arrLong.Length; i++)
            {
                arrLong[i] = i + 1000; // Llenar el array con valores del 1000 al 1099
            }

            List<int> ar = arr.ToList(); // Convertir el array 'arr' en una lista
            List<int> a = arr.ToList(); // Convertir el array 'arr' en otra lista

            List<int> b = arr.ToList(); // Convertir el array 'arr' en otra lista

            int arCount = arr.Length; // Obtener la longitud del array 'arr'

            List<long> ar_Long = arrLong.ToList(); // Convertir el array 'arrLong' en una lista de long

            int result_int = 42; // Asignar un valor de ejemplo a 'result_int'

            int Ejercicio = 1; // Definir un valor de ejercicio (por ejemplo, 1)

            int val1 = 10; // Asignar un valor de ejemplo a 'val1'
            int val2 = 20; // Asignar un valor de ejemplo a 'val2'
            int sum = val1 + val2; // Calcular la suma de 'val1' y 'val2'

            #endregion



            RandomService randomService = new RandomService();

            Console.WriteLine("Elige una opción:");
            // Agrega más opciones según sea necesario...

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ImplementOrder();
                    break;
                case 2:
                    Eje(arr);
                    break;
                case 3:
                    val1 = Convert.ToInt32(Console.ReadLine());
                    val2 = Convert.ToInt32(Console.ReadLine());
                    sum = solveMeFirst(val1, val2);
                    Console.WriteLine(sum);
                    break;
                case 4:
                    sum = simpleArraySum(ar);
                    Console.WriteLine(sum);
                    break;
                case 5:
                    long result = aVeryBigSum(ar_Long);
                    Console.WriteLine(result);
                    break;
                case 6:
                    int n = Convert.ToInt32(Console.ReadLine().Trim());

                    List<List<int>> arr2 = new List<List<int>>();

                    for (int i = 0; i < n; i++)
                    {
                        arr2.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                    }

                    result_int = diagonalDifference(arr2);
                    Console.WriteLine(result_int);
                    break;
                case 7:
                    try
                    {
                        Console.WriteLine("Ingrese un número entero:");
                        int n_new = Convert.ToInt32(Console.ReadLine().Trim());

                        Console.WriteLine("Ingrese una lista de números separados por espacios:");
                        List<int> arr3 = Console.ReadLine()
                                                .Trim()
                                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToList();
                        plusMinus(arr3);
                        // Ahora puedes usar n_new y arr3 según sea necesario
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Se esperaba un número entero.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño para ser representado como un número entero.");
                    }



                    break;
                case 8:
                    Console.WriteLine("Ingrese un número entero:");
                    int n_new8 = Convert.ToInt32(Console.ReadLine().Trim());

                    staircase(n_new8);
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





            Console.ReadLine();
        }
        static void ImplementOrder()
        {
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
        }
        static void Eje(int[] arr)
        {

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
                randomNumbers.Add(random.Next(1, 1001));
            }

            return randomNumbers;
        }
    }

    #endregion

}
