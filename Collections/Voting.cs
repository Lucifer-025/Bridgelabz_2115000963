using System;
using System.Collections.Generic;
using System.Linq;

class Voting
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
        votes["Alice"] = 5;
        votes["Bob"] = 3;
        votes["Charlie"] = 7;

        var sortedVotes = votes.OrderByDescending(v => v.Value);

        Console.WriteLine("Voting Results:");
        foreach (var vote in sortedVotes)
            Console.WriteLine($"{vote.Key}: {vote.Value} votes");
    }
}
