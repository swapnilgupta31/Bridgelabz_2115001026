using System;
using System.Collections.Generic;

class FrequencyCounter {
    static void Main() {
        List<string> words = new List<string> { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> frequency = GetFrequency(words);

        Console.WriteLine("Word Frequencies:");
        foreach (var pair in frequency) {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    }

    static Dictionary<string, int> GetFrequency(List<string> words) {
        Dictionary<string, int> freqDict = new Dictionary<string, int>();
        foreach (string word in words) {
            if (freqDict.ContainsKey(word)) {
                freqDict[word]++;
            } else {
                freqDict[word] = 1;
            }
        }
        return freqDict;
    }
}
