using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Podzadanie2
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
             * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
             * (пример палиндрома – «А роза упала на лапу Азора»).
             */
            string pred, tpred;
            Console.WriteLine ("Введите предложение для проверки палиндрома");
            pred = Convert.ToString(Console.ReadLine());
            tpred = pred.ToLower();
            int check= 0;
            int i = 0;
            int j = tpred.Length - 1;
            while (i < j)   
            {
                while (i < j && !char.IsLetterOrDigit(tpred[i])) ++i;
                while (j > i && !char.IsLetterOrDigit(tpred[j])) --j;
                if (tpred[i++] != tpred[j--])
                { check = 0; }
                else { check = 1; }
            }
                if (check == 0)
            {
                Console.WriteLine("Не палиндром");
            }
                else
            {
                Console.WriteLine("Палиндром");
            }
            Console.ReadKey();
        }   
	

	}
    }
    

