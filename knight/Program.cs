using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace knight 
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите координаты коня до хода.");
            string first = Console.ReadLine();
            Console.WriteLine("Введите координаты коня после хода.");
            string second = Console.ReadLine();

            IsHorse(first, second, out string output);
            Console.WriteLine(output);
        }
        static void IsHorse(string x, string y, out string output)
        {
            char[] first = x.ToCharArray();
            char[] second = y.ToCharArray();
            if ((first[0] > 'H') || (first[1] > '8') || (second[0] > 'H') || (second[1] > '8'))
                output = "ошибка. таких значений нет.";
            else if (((Math.Abs(first[0] - second[0]) == 1) & (Math.Abs(first[1] - second[1]) == 2)) || (Math.Abs(first[0] - second[0]) == 2) & (Math.Abs(first[1] - second[1]) == 1))
                output = "вы сходили правильно.";
            else
                output = "ход неверный.";
        }
    }
}
