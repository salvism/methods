using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            // - Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod,
            // əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi.

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int number;

            //Console.Write("Enter a number: ");
            //string numberStr = Console.ReadLine();
            //number = Convert.ToInt32(numberStr);

            //int index = FindIndex(arr, number);

            //Console.WriteLine(index);

            #endregion

            #region task2

            //- Verilmiş yazını əksinə çevirən metod
            //(misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)

            //Console.Write("Enter something: ");
            //string word = Console.ReadLine();

            //string newWord = Reverse(word);

            //Console.Write(newWord);

            #endregion

            #region task3

            // - Verilmiş yazıda rəqəm olub olmadığını tapan metod

            //Console.Write("Enter something: ");
            //string word = Console.ReadLine();

            //var check = FindInt(word);
            //Console.WriteLine(check);

            #endregion
        }

        static int FindIndex(int[] arr, int num)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    index = i;
                    return index;
                }
            }

            return -1;
        }

        static string Reverse(string s) 
        {
            string sNew = "";
            for (int i = s.Length - 1; i > -1; i--)
            {
                sNew += s[i];
            }

            return sNew;
        }

        static bool FindInt(string s)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (s[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
