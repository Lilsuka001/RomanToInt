
using System;
using System.Collections.Generic;
using System.Threading.Channels;

class Program
{
    static int RomanToInt(string roman)
    {
        Dictionary<char, int> romanNums = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int preValue = 0;
        int result = 0;
        foreach (char romaNum in roman)
        {
            int value = romanNums[romaNum];
            if (value>preValue)
            {
                result += value - 2 * preValue;

            }
            else { result += value; }
            preValue = value;
        }
        return result;
    }

    static void Main(string[] args)
    {
        string romanNumeral = "XIX";
        Console.WriteLine("Римское число {0} эквивалентно обычному числу {1}", romanNumeral, RomanToInt(romanNumeral));
    }
}
    




