using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите количество элементов массива: ");
                int b = Convert.ToInt32(Console.ReadLine());
                double[] a = new double[b];
                int n = a.Length;
                string str;
                int i;
                double sum = 0;
                Random rnd = new Random();
                for (i = 0; i < n; i++)
                {
                    a[i] = rnd.Next(-100, 100);
                    Console.WriteLine(a[i]);
                    sum += a[i];
                }
                double avg;
                avg = sum / n;
                str = "Сумма массива равна " + sum + "\nСреднее арифметическое массива равно  " + avg;
                Console.WriteLine(str);
                Console.WriteLine("Нажмите любую кнопку!");
                Console.ReadKey();
            
        }
    }
}
