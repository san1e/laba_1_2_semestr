using System;

namespace laba_1_2_semestr
{
    internal class Program
    {
        static int[] Random(int n) 
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100,100);
            }
            return arr;
        }
        static int[] ManualSeparate(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            return arr;
        }
        static int[] ManualOneLine()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            return arr;
        }
        static string CW(int[] n )
        {
            string str = string.Join(" ", n);
            return str;
        }
        static int[] Mod(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < 0 )
                {
                    n[i] = Math.Abs(n[i]);
                }
            }
            return n;
        }

        static int[] Min(int[] n)
        {
            int min1 = n[0];
            int min2 = n[1];

            if (min2 < min1)
            {
                int temp = min1;
                min1 = min2;
                min2 = temp;
            }

            for (int i = 2; i < n.Length; i++)
            {
                if (n[i] < min1)
                {
                    min2 = min1;
                    min1 = n[i];
                }
                else if (n[i] < min2)
                {
                    min2 = n[i];
                }
            }
            int[] min = {min1, min2 };
            return min;
        }
        static int[] Min2(int[] n) 
        {
            Array.Sort(n);
            int min1 = n[0];
            int min2 = n[1];
            int[] min = {min1, min2 };
            return min;
        }
        static void Main(string[] args)
        {
            int Case;
            int Choice;
            do
            {
            Console.WriteLine("Випадкове заповнення              - натиснiть 1");
            Console.WriteLine("Ручне заповнення в окремих рядках - натиснiть 2");
            Console.WriteLine("Ручне заповнення в одному рядку   - натиснiть 3");
            Console.WriteLine("Завершити програму                - натиснiть 0");
            Console.WriteLine();
            Console.Write("Введiть обраний варiант: ");
            Case = int.Parse(Console.ReadLine());
            Console.Clear();
                switch (Case)
                {

                    case 1:
                        Console.Write("Кiлькiсть елементiв в массивi:");
                        int n = int.Parse(Console.ReadLine());
                        int[] arr = Random(n);
                        Console.WriteLine($"Згенерований массив: {CW(arr)}");
                        arr = Mod(arr);
                        Console.WriteLine($"Вiдредагований массив: {CW(arr)}");
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine("Циклiчний метод    - натиснiть 1");
                            Console.WriteLine("Бiблiотечний метод - натиснiть 2");
                            Console.WriteLine("Завершити          - натиснiть 0");
                            Console.Write("Оберiть варiант знаходження двох мiнiмальних елементiв:");
                            Choice = int.Parse(Console.ReadLine());
                            switch (Choice)
                            {
                                case 1:
                                    int[] min = Min(arr);
                                    Console.WriteLine($"Два мiнiмальних елемента массива: {CW(min)}");
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    min = Min2(arr);
                                    Console.WriteLine($"Два мiнiмальних елемента массива: {CW(min)}");
                                    Console.WriteLine();
                                    break;
                                case 0:
                                    break;

                            }
                        } while (Choice != 0);
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("Кiлькiсть елементiв в массивi:");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть елементи массиву:");
                        arr = ManualSeparate(n);
                        Console.WriteLine($"Массив: {CW(arr)}");
                        arr = Mod(arr);
                        Console.WriteLine($"Вiдредагований массив: {CW(arr)}");
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine("Циклiчний метод    - натиснiть 1");
                            Console.WriteLine("Бiблiотечний метод - натиснiть 2");
                            Console.WriteLine("Завершити          - натиснiть 0");
                            Console.Write("Оберiть варiант знаходження двох мiнiмальних елементiв:");
                            Choice = int.Parse(Console.ReadLine());
                            switch (Choice)
                            {
                                case 1:
                                    int[] min = Min(arr);
                                    Console.WriteLine($"Два мiнiмальних елемента массива: {CW(min)}");
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    min = Min2(arr);
                                    Console.WriteLine($"Два мiнiмальних елемента массива: {CW(min)}");
                                    Console.WriteLine();
                                    break;
                                case 0:
                                    break;

                            }
                        } while (Choice != 0);
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("Введiть елементи массиву:");
                        arr = ManualOneLine();
                        Console.WriteLine($"Массив: {CW(arr)}");
                        arr = Mod(arr);
                        Console.WriteLine($"Вiдредагований массив: {CW(arr)}");
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine("Циклiчний метод    - натиснiть 1");
                            Console.WriteLine("Бiблiотечний метод - натиснiть 2");
                            Console.WriteLine("Завершити          - натиснiть 0");
                            Console.Write("Оберiть варiант знаходження двох мiнiмальних елементiв:");
                            Choice = int.Parse(Console.ReadLine());
                            switch (Choice)
                            {
                                case 1:
                                    int[] min = Min(arr);
                                    Console.WriteLine($"Два мiнiмальних елемента массива: {CW(min)}");
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    min = Min2(arr);
                                    Console.WriteLine($"Два мiнiмальних елемента массива: {CW(min)}");
                                    Console.WriteLine();
                                    break;
                                case 0:
                                    break;

                            }
                        } while (Choice != 0);
                        Console.Clear();
                        break;

                    case 0:
                        break;
                }
        } while (Case != 0 );
        }
    }
}
