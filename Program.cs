using System;
using System.IO;

namespace Лабораторная_работа__4
{
    class Program
    {
       static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input1.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }

            // Вычисление среднего арифметического
            int s = 0;
            float sa = 0;
            for (int i = 0; i < N; i++)
            {
                s += mas[i];
            }
            sa = 1.0f * s / N;

            // вывод количества чисел, больших среднего арифметического исходных чисел
            int kol = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] > sa)
                    kol += 1;
            }
            Console.WriteLine(string.Format("Количество чисел, больших среднего арифметического исходных чисел = {0}", kol));

            //  вывод суммы всех чисел, меньших среднего арифметического
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] < sa)
                    sum += sum;
            }
            Console.WriteLine(string.Format("Сумма всех чисел, меньших среднего арифметического = {0}", sum));

            // Вывод максимально числа
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] > max)
                    max = mas[i];
            }
            Console.WriteLine(string.Format("Максимальное число = {0}", max));


            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();


        }
    }
}
