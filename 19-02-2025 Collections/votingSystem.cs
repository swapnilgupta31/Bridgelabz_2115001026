using System;
using System.Collections.Generic;

class VotingSystem {
    static void Main() {
        Dictionary<string, int> votes = new Dictionary<string, int>(); // Store votes
        SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(); // Sorted results

        // Simulating votes
        string[] castedVotes = { "Alice", "Bob", "Alice", "Charlie", "Bob", "Alice" };
        foreach (var vote in castedVotes) {
            if (votes.ContainsKey(vote)) {
                votes[vote]++;
            } else {
                votes[vote] = 1;
            }
        }

        // Sorting votes
        foreach (var pair in votes) {
            sortedVotes[pair.Key] = pair.Value;
        }

        Console.WriteLine("Voting Results:");
        foreach (var pair in sortedVotes) {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    }
}
