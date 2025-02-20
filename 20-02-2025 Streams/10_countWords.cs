using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCounter {
    static void Main() {
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string word in File.ReadAllText("textfile.txt").Split(' ')) {
            string cleanedWord = word.ToLower().Trim();
            if (!string.IsNullOrEmpty(cleanedWord)) {
                if (!wordCounts.ContainsKey(cleanedWord)) wordCounts[cleanedWord] = 0;
                wordCounts[cleanedWord]++;
            }
        }

        foreach (var word in wordCounts.OrderByDescending(k => k.Value).Take(5))
            Console.WriteLine(word.Key + ": " + word.Value);
    }
}
