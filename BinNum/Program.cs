using System;
using System.IO;
using System.Text;

namespace BinNum
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var Stroka = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); 
           byte[] byteArr = new byte[Stroka.Length];

            int i = 0;
            while (i< Stroka.Length)
                    {
                     byteArr[i] = byte.Parse(Stroka[i]);
                     i++;
             //   Console.WriteLine(byteArr[i]);
                    }
           File.WriteAllBytes("bytes.bin", byteArr);
           Console.WriteLine($"Файл сохранен: ");
           
        }
    }
}
