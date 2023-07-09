using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;

public class Kata
{
    public static string High(string s)
    {
        string alphabetString = "⠀abcdefghijklmnopqrstuvwxyz";

        char[] alphabetArray = alphabetString.ToCharArray();

        string[] words = s.Split(" ");

        int[] wordsScore = new int[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();

            int wordScore = 0;

            foreach (char c in charArray)
            {
                int charIndex = Array.IndexOf(alphabetArray, c);

                wordScore += charIndex;                
            }

            wordsScore[i] = wordScore;
        }

        int maxScoreWordIndex = Array.IndexOf(wordsScore, wordsScore.Max());

        string maxScoreWord = words[maxScoreWordIndex];

        return maxScoreWord;
    }

    static void Main(string[] args)
    {
        string test = "taxi taxii taxiii";

        Console.WriteLine(High(test));

    }

}


