using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            words.Add("Plane");
            words.Add("Mile");
            words.Add("Super");
            words.Add("Darian");
            words.Add("Supercalafragilisticespialadotiuous");
            words.Add("spaghetti");
            words.Add("Mouse");

            FiveLetterWord(words);

            static void FiveLetterWord(List<string> args)
            {
                foreach(string word in args)
                {
                    if (word.Length == 5)
                    {
                        Console.WriteLine(word);
                    }
                }
            }


            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);

            Console.WriteLine(Sum(numbers));
            
            static int Sum(List<int> args)
            {
                int evenSum = 0;
                
                foreach (int num in args)
                {
                    if (num % 2 == 0)
                    {
                        evenSum += num;
                       
                    }
                   
                }
                return evenSum;
            }
        }
    }
}
