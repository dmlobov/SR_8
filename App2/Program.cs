using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            string path = @"C:\Документы\Temp\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(random.Next(0, 100));
                }
            }
            int S = 0;
            using (StreamReader sr = new StreamReader(path))
            {
               
                for (int i = 0; i < n; i++)
                {
                    S += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
