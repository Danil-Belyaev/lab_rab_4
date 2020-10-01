using System;
using System.IO;

// Изменил подсчет произведения элементов кратных 100
// И заметил, что если подставлять 0, то он компилируется как элемент кратный 10 и 100
// Вроде обошел эту странность, теперь все работает корректно
// Евгений Иванович, пожалуйста, если снова заметите, что код работает неправильно, сообщите мне об этом
// Заранее спасибо!

namespace Лабораторная_работа__4
{
    class Program
    {
       static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input3.txt");
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

            // счетчик элементов кратных 100
            int n100 = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 100 == 0)
                    n100 += 1;
            }

            // вывод произведения чисел, кратных 100
            int kol100 = 1;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] == 0)
                { continue; }
            
                if (n100 != 0)
                { 
                    if (mas[i] % 100 == 0)
                        kol100 *= mas[i];

                }
                else
                {
                    kol100 = 0;
                }
            }
            Console.WriteLine(string.Format("Произведение чисел, кратных 100 = {0}", kol100 ));

            // вывод количества чисел, кратных 10
            int kol10 = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] == 0)
                { continue; }

                if (mas[i] % 10 == 0)
                    kol10 += 1;
            }
            Console.WriteLine(string.Format("\nКоличество чисел, кратных 10 = {0}", kol10));

            // модифицированный массив, в котором все элементы кратные 5 заменены на 5, остальные – на x
            Console.WriteLine("\nМодифицированный массив, в котором все элементы кратные 5 заменены на 5, остальные – на x");
            for (int i = 0; i < N; i++)
            {
                if (mas[i] == 0)
                { Console.Write("x "); }

                if (mas[i] == 0)
                { continue; }

                if (mas[i] % 5 == 0)
                    Console.Write("5 ");
                else
                    Console.Write("x ");
            }
            Console.WriteLine();


            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();


        }
    }
}
