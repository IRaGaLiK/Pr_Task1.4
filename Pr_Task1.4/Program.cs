using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    static int RomanToInt(string roman)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

        int result = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && romanValues[roman[i]] < romanValues[roman[i + 1]])
            {
                result -= romanValues[roman[i]];
            }
            else
            {
                result += romanValues[roman[i]];
            }
        }

        return result;
    }

    string romanNumeral;
    romanNumeral = Console.ReadLine();
    int number = RomanToInt(romanNumeral);
    Console.WriteLine($"Обычное целое число, соответствующее римской цифре {romanNumeral}, равно: {number}");

