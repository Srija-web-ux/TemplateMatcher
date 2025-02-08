using System;
using TemplateMatcher.Rules;
public class WildCardRule : IRule
{
    public bool Matches(char textChar) => true; // Always matches any char
}

