using System;
using System.Globalization;
using System.IO;


namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((DateTime.Now).ToString("HH:mm:ss tt"));
           // string Stime = (DateTime.Now).ToString("hh:mm:ss");
            string fname = "Startup.txt";
            File.WriteAllText(fname, ((DateTime.Now).ToString("HH:mm:ss")));//запись и сохранение
            Console.WriteLine();
        }
    }
}
