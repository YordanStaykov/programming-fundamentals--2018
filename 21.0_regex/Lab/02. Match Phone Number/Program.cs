using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string phone = Console.ReadLine();
        string pattern = @"[\+]359( |-)2(\1)[\d]{3}(\1)[\d]{4}\b";

        MatchCollection phoneMatches = Regex.Matches(phone, pattern);

        var matchedPhones = phoneMatches
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}