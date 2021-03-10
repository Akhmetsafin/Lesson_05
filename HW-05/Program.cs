using System;
using System.IO;

namespace HW_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите текст для сохранения\n");
            string text = Console.ReadLine();// сохраняемая строка
            Console.Write($"Файл сохранить как: ");
            string Dir_FName=Console.ReadLine();// название файла, c расширением txt
            string fname = Dir_FName+".txt";
            File.WriteAllText(fname, text);//запись и сохранение
        }
    }
}
