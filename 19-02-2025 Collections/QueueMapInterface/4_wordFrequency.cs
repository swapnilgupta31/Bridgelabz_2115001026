using System;
using System.Collections.Generic;
using System.IO;

class WordFrequency {
    static void Main() {
        string text = "Hello world, hello Java!";
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        string[] words = text.ToLower().Split(new char[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words) {
            if (wordCount.ContainsKey(word)) {
                wordCount[word]++;
            } else {
                wordCount[word] = 1;
            }
        }

        Console.WriteLine("Word Frequencies:");
        foreach (var pair in wordCount) {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    }
}
