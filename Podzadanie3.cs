using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Podzadanie3
    {
        static void Main(string[] args)
        {
            /*Дана строка S.Из строки требуется удалить текст, заключенный в фигурные скобки.
             * В строке может быть несколько фрагментов, заключённых в фигурные скобки.Возможно использование вложенных фигурных скобок,
             * необходимо, чтобы программа это учитывала.
             */
            Console.Write("Введите строку с некоторым количеством фигурных скобок типа");
            Console.WriteLine(@"{ или }");
            string s = Convert.ToString(Console.ReadLine());
            string k=s;
            int j = 1;
            int h = 1;
            while (s.Contains('{') || s.Contains('{'))
            
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == '{' || s[i] == '}')
                    {
                    if (s[i + 1] != '{' || s[i] == '}')
                    {
                        s = s.Remove(i, 1);
                       
                    }
                    
                    }

                }
                               
            
            Console.Write("Новая строка:");
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
