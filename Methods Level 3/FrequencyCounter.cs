using System;
using System.Collections.Generic;

class FrequencyCounter
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }; // Example array
        Console.WriteLine("Original Array: " + string.Join(", ", array));

        Dictionary<int, int> frequency = CountFrequency(array);
        Console.WriteLine("Frequency of Each Element:");
        foreach (var pair in frequency)
        {
            Console.WriteLine(pair.Key + " appears " + pair.Value + " times");
        }
    }

    static Dictionary<int, int> CountFrequency(int[] array)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in array)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        return frequency;
    }
}
