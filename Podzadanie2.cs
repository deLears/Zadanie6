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
            Console.WriteLine("Введите предложение для проверки палиндрома");
            string pred = Console.ReadLine();
            string tpred = pred.ToLower();
            char[] Bms = tpred.ToCharArray();
            int Cc = 0;
            for (int i = 0; i < Bms.Length; i++)
            {
                if (Bms[i]==Bms[Bms.Length-2])
                {
                    Cc++;
                }
            }
            if (Cc==pred.Length)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
            Console.ReadKey();
        }
       
        }   
	

	}
    

    

