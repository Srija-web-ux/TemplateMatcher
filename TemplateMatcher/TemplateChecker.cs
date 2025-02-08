using System;
using System.Collections.Generic;
using TemplateMatcher;
using TemplateMatcher.Rules;

public class TemplateChecker : IChecker
{
    public bool IsMatch(string template, string text)
    {
        List<IRule> rules = RuleFormat.ParseTemplate(template, text);

        for (int i = 0; i < text.Length; i++)
        {
            if (!rules[i].Matches(text[i]))
                return false;
        }

        return true;
    }
}
