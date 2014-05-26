// Write a program that extracts from a given text all sentences containing given word.

using System;

class SentencesContainingGivenWordExtractor
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        {
            string checkingSentence = sentence.ToLower();
            int index = checkingSentence.IndexOf(word.ToLower() + " ");

            if (index > -1)
            {
                Console.Write(sentence.Trim());
                Console.WriteLine(".");
            }
        }
    }
}
