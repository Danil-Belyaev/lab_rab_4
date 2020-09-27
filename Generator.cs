using System;
using System.IO;

namespace generator
{

    class Generator
    {
        static void Main(string[] args)
        {
            int N;
            String FileName;

            Console.Write("Введите колличесвто элементов  0<=N<=100 >");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите имя выходного файла без расширения >");
            FileName = Console.ReadLine();
            FileName += ".txt";

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(FileName);
            Console.SetOut(new_out);

            Console.WriteLine(N);

            Random r = new Random();
            int x = 0;
            for (int i = 0; i < N; i++)
            {
                x = r.Next(-10000, 10000);
                Console.Write(x + " ");
            }

            Console.SetOut(save_out); new_out.Close();
            Console.WriteLine("Файл " + FileName + " оздан!!");
            Console.ReadKey();
        }
    }

}