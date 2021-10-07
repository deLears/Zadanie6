using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение.
            Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
            Найти самое длинное слово в строке.
            */
            Console.Write("Введите строку: ");
            string vvod = Console.ReadLine();
            string[] str = vvod.Split(new Char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int max = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > max)
                {
                    max = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadKey();
           
        }
    }
}
