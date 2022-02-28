using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3_1_2
{
    public class TextAnalizator
    {
        private char[] newLineChars = Environment.NewLine.ToCharArray();
        private Dictionary<string, int> wordCount = new Dictionary<string, int>();
        public string[] Words { get; private set; }

        public string Text { set; get; }

        public TextAnalizator(string text)
        {
            Text = text;

            SplitTextToWords();

            CountWords();
        }

        private void SplitTextToWords()
        {
            var delimeters = new char[]
            { ' ' , '!', '"', ';', ':', ',', '.', '?', '(', ')', '-' }.
            Concat(newLineChars).
            ToArray();

            Words = Text.
                ToLower().
                Trim().
                Split(delimeters, StringSplitOptions.RemoveEmptyEntries).
                ToArray();
        }

        private void CountWords()
        {
            foreach (var word in Words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount.Add(word, 1);
                }
                else
                {
                    wordCount[word]++;
                }
            }
        }
        // Выводит частоту слов относительно всех слов
        public void PrintWordFrequencyFromAllWords()
        {
            // Сортировка словаря по значению
            var sortedDictionary = wordCount.OrderByDescending(pair => pair.Value);

            foreach (var pair in sortedDictionary)
            {
                double wordFrequency = (double)pair.Value / Words.Length * 100;
                Console.WriteLine($"[{pair.Key}] : {wordFrequency: 0.00}%");
            }
        }

        public void PrintWordCount()
        {
            // Сортируем словарь по значению
            var sortedDictionary = wordCount.OrderByDescending(pair => pair.Value);

            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine($"[{pair.Key}] : {pair.Value}");
            }
        }

        public void PrintUniqueWords()
        {
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"[{pair.Key}]");
            }
        }
    }
}
