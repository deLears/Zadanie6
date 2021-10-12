using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Podzadanie2
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
                         * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
                         * (пример палиндрома – «А роза упала на лапу Азора»).
                         */
            Console.WriteLine("Введите предложение для проверки палиндрома");
            string pred = Console.ReadLine();
            string tpred = pred.ToLower();
            bool IsPalindrome = true;
            
            int i = 0, j = tpred.Length - 1;
                while (i < j)
                {
                    if (char.IsWhiteSpace(tpred[i]) || char.IsPunctuation(tpred[i]))
                        i++;
                    else if (char.IsWhiteSpace(tpred[j]) || char.IsPunctuation(tpred[j]))
                        j--;
                    else if (char.ToLowerInvariant(tpred[i++]) != char.ToLowerInvariant(tpred[j--]))
                    IsPalindrome =false;
                }


            if (IsPalindrome == true)
            {
                Console.WriteLine("Палиндром");
            }
            else Console.WriteLine("НЕТ");
            Console.ReadKey();

        }
    }
}
