using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
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
            string s = Console.ReadLine();
            int sL = s.Length;
            
            char[] arrC = new char[sL]; 
            char[] arrS = new char[sL];
            arrS = s.ToCharArray();
            
            for (int i = 0; i < sL; i++)
            {
                if ((arrS[i] == '{') || (arrS[i] == '}'))
                {
                    arrC[i] = arrS[i];
                }              
            }
            StringBuilder sb = new StringBuilder(arrC.Length);
            string value = sb.Append(arrC).ToString(); 
            Console.WriteLine("Новая строка: {0}", sb);
            Console.ReadKey();
        }
               
    }
}


