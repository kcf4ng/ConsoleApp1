using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello World!");
            Console.WriteLine("第一個 Console 應用程式");
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("1. Console\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("2. 視窗應用程式\n");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("3. 網頁應用程式\n");
            Console.ResetColor();
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\"雙引號\"");
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\r\n換行");
            Console.WriteLine("\t縮排，預設縮排為四格字元");

            //單行註解
            /*
             * 多行註解
             */
            Console.ReadKey();
        }
    }
}
