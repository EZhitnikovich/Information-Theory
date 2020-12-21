using System;
using System.Collections.Generic;
using System.Linq;

namespace TI2
{
    public static class TextDecryptor
    {
        //private static readonly Dictionary<char, double> freqTable = new Dictionary<char, double>()
        //{
        //    {'e', 12.31}, {'t', 9.59}, {'a', 8.05}, {'o', 7.94},
        //    {'n', 7.19}, {'i', 7.18}, {'s', 6.59}, {'r', 6.03},
        //    {'h', 5.14}, {'l', 4.03}, {'d', 3.65}, {'c', 3.20},
        //    {'u', 3.10}, {'p', 2.29}, {'f', 2.28}, {'m', 2.25},
        //    {'w', 2.03}, {'y', 1.88}, {'b', 1.62}, {'g', 1.61},
        //    {'v', 0.93}, {'k', 0.52}, {'q', 0.2}, {'x', 0.2},
        //    {'j', 0.1}, {'z', 0.09}
        //};

        private static readonly Dictionary<char, double> freqTable = new Dictionary<char, double>()
        {
            {'e', 12.70}, {'t', 9.05}, {'a', 8.16}, {'o', 7.5},
            {'n', 6.74}, {'i', 6.96}, {'s', 6.32}, {'r', 5.98},
            {'h', 6.09}, {'l', 4.02}, {'d', 4.25}, {'c', 2.78},
            {'u', 2.75}, {'p', 1.92}, {'f', 2.23}, {'m', 2.4},
            {'w', 2.36}, {'y', 1.97}, {'b', 1.49}, {'g', 2.01},
            {'v', 0.98}, {'k', 0.77}, {'q', 0.09}, {'x', 0.15},
            {'j', 0.15}, {'z', 0.07}
        };

        private static Dictionary<char, int> charCounter;

        public static Dictionary<char, double> FreqTable
        {
            get
            {
                return freqTable.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
        }

        public static Dictionary<char, double> AnalysText(string source)
        {
            CountChars(source, out int totalCount);
            Dictionary<char, double> analysedTable = new Dictionary<char, double>();
            foreach (var item in charCounter)
            {
               analysedTable.Add(item.Key, Math.Round((100.0 / totalCount) * item.Value, 2));
            }
            analysedTable = analysedTable.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            return analysedTable;
        }

        public static string ReplaceChars(string source, Dictionary<string, string> dict)
        {
            foreach(var item in dict)
            {
                if (item.Value.ToString() != "")
                {
                    source = source.Replace(item.Key, item.Value.ToUpper());
                }
            }

            return source;
        }

        private static void CountChars(string source, out int totalCount)
        {
            totalCount = 0;

            charCounter = new Dictionary<char, int>() {
                { 'a', 0 }, { 'b', 0 }, { 'c', 0 }, { 'd', 0 },
                { 'e', 0 }, { 'f', 0 }, { 'g', 0 }, { 'h', 0 },
                { 'i', 0 }, { 'j', 0 }, { 'k', 0 }, { 'l', 0 },
                { 'm', 0 }, { 'n', 0 }, { 'o', 0 }, { 'p', 0 },
                { 'q', 0 }, { 'r', 0 }, { 's', 0 }, { 't', 0 },
                { 'u', 0 }, { 'v', 0 }, { 'w', 0 }, { 'x', 0 },
                { 'y', 0 }, { 'z', 0 }
            };

            foreach (char c in source)
            {
                if (char.IsLetter(c))
                {
                    totalCount++;
                }
                char newCharLower = char.ToLower(c);
                if (charCounter.ContainsKey(newCharLower))
                {
                    charCounter[newCharLower]++;
                }
            }
        }
    }
}