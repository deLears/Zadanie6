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
            string s = Convert.ToString(Console.ReadLine());
            string Neo = "";
            int sL = s.Length;
            int Count = 0;
            bool[] arrC = new bool[sL];
            //char[] arrS = new char[sL];
            //arrS = s.ToCharArray();

            for (int i = 0; i < sL; i++)
            {
                if ((s.Substring(i) == "}" ) || (s.Substring(i) == "{"))
                {
                    arrC[i] = true;
                    Count++;
                }
                else
                {
                    arrC[i] = false;
                }
            }
            for (int i = 0; i < sL; i++)
            {
                if (arrC[i]==true)
                {
                    Neo += s[i];
                }
            }
            Console.Write("Новая строка:");
            Console.Write(Neo);
            Console.ReadKey();
            

        }
               
    }
}


