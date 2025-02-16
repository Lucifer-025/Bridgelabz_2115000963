using System;

class Sentence
{
    static void Main()
    {
        string[] sentences = {
            "The sky is blue.",
            "Hello world!",
            "Welcome to C# programming.",
            "This is an example sentence."
        };

        string searchWord = "C#";
        int index = FindSentenceContainingWord(sentences, searchWord);

        if (index != -1)
        {
            Console.Write("First sentence containing '");
            Console.Write(searchWord);
            Console.Write("' is at index ");
            Console.WriteLine(index);
        }
        else
        {
            Console.Write("No sentence found containing '");
            Console.Write(searchWord);
            Console.WriteLine("'.");
        }
    }

    static int FindSentenceContainingWord(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (IndexOf(sentences[i], word) != -1) // Custom search function
            {
                return i;
            }
        }
        return -1;
    }

    static int IndexOf(string sentence, string word)
    {
        int sentenceLength = sentence.Length;
        int wordLength = word.Length;

        for (int i = 0; i <= sentenceLength - wordLength; i++)
        {
            int j;
            for (j = 0; j < wordLength; j++)
            {
                if (sentence[i + j] != word[j])
                {
                    break;
                }
            }
            if (j == wordLength)
            {
                return i;
            }
        }
        return -1;
    }
}
