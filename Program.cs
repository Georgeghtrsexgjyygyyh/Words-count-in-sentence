using System;
using System.Reflection;
using System.Collections.Generic;

namespace Program_word_count {

    class Program
    {

        static void Main(string[] args)
        {
        //script

            Console.Title = "Words couting";


            Console.WriteLine("Enter a sentence: ");

            string? sentence = Console.ReadLine();

            int sentence_length = CoutingLenght(sentence);

            Console.WriteLine("There are " + sentence_length + " words in that sentence.");



            //Wait before end
            Console.ReadKey();

        //script
        }


        static int CoutingLenght(string sentence)
        {
            int sentence_length = Convert.ToInt32(sentence.Split(' ').Length);
            return sentence_length;
        }

    }

}
