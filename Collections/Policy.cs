using System;
using System.Collections.Generic;
using System.Linq;

class Policy
{
    public string PolicyNumber { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string CoverageType { get; set; }

    public Policy(string number, DateTime expiry, string coverage)
    {
        PolicyNumber = number;
        ExpiryDate = expiry;
        CoverageType = coverage;
    }
}

class Program
{
    static void Main()
    {
        HashSet<string> uniquePolicies = new HashSet<string>();
        SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(Comparer<Policy>.Create((a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate)));

        List<Policy> policies = new List<Policy>
        {
            new Policy("P001", DateTime.Now.AddDays(10), "Health"),
            new Policy("P002", DateTime.Now.AddDays(40), "Car"),
            new Policy("P003", DateTime.Now.AddDays(5), "Home")
        };

        foreach (var policy in policies)
        {
            uniquePolicies.Add(policy.PolicyNumber);
            sortedPolicies.Add(policy);
        }

        Console.WriteLine("Policies expiring soon:");
        foreach (var policy in sortedPolicies.Where(p => (p.ExpiryDate - DateTime.Now).TotalDays <= 30))
        {
            Console.WriteLine(policy.PolicyNumber+" - " +policy.ExpiryDate.ToShortDateString());
        }
    }
}
