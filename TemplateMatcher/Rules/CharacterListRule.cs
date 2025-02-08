using System;
using System.Linq;
using TemplateMatcher.Rules;

public class CharacterListRule : IRule
{

    private readonly HashSet<char> allowedChars;

    public CharacterListRule(char[] validCharacters)
    {
        allowedChars = new HashSet<char>(validCharacters.Select(char.ToUpper)); // Matches any one (Case insensitive)
    }

    public bool Matches(char c) => allowedChars.Contains(char.ToUpper(c));




}
