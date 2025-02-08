using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TemplateMatcher.Rules;
using static System.Net.Mime.MediaTypeNames;

public static class RuleFormat
{
    public static List<IRule> ParseTemplate(string template, string text)
    {
        if (string.IsNullOrEmpty(template))
            throw new ArgumentException("Template cannot be empty");

        List<IRule> rules = new List<IRule>();
        int index = 0;

        while (index < template.Length)
        {
            if (template[index] == '*')
            {
                rules.Add(new WildCardRule());
                index++;
            }
            else if (template[index] == '(')
            {
                int endIndex = template.IndexOf(')', index);
                if (endIndex == -1)
                    throw new ArgumentException("Invalid template format: missing closing ')'");

                string[] options = template.Substring(index + 1, endIndex - index - 1).Split('|');
                char[] characters = options.Select(s => s[0]).ToArray();
                rules.Add(new CharacterListRule(characters));
                index = endIndex + 1;
            }
            else if (template[index] == '!')
            {
                if (index + 1 >= template.Length)
                    throw new ArgumentException("'!' must be followed by a character.");

                rules.Add(new NotCharacterRule(template[index + 1]));
                index += 2;
            }
            else
            {
                rules.Add(new ExactCharRule(template[index]));
                index++;
            }
        }
        if (rules.Count != text.Length)
        {
            throw new ArgumentException("Template rules length must match text length");
        }

        return rules;
    }
}
