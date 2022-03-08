using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text-i daxil edin");
            string text = Console.ReadLine();
            Console.WriteLine(VowelLetter(text));
        }
        static int VowelLetter(string text)
        {
            char[] letter = { 'a', 'u', 'e', 'o', 'i' };
            int count = 0;
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < letter.Length; j++)
                {

                    if (text[i] == letter[j])
                    {
                        count++;
                    }
                }
            return count;
        }
    }
}
