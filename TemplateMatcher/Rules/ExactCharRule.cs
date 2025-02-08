using System;
using TemplateMatcher.Rules;

public class ExactCharRule : IRule
{
    private readonly char expectedChar;

    public ExactCharRule(char expectedChar)
    {
        this.expectedChar = char.ToUpper(expectedChar);// Matches the Exact Char(Case Insensitive)
    }

    public bool Matches(char textChar)
    {
        return char.ToUpper(textChar) == expectedChar;
    }
}
