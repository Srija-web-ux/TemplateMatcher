using TemplateMatcher;
using System;

class Program
{
    static void Main()
    {
        IChecker checker = new TemplateChecker();

        while (true)
        {
            try
            {
                Console.Write("Enter Template: ");
                string template = Console.ReadLine();
                Console.Write("Enter Text: ");
                string text = Console.ReadLine();
                bool result = checker.IsMatch(template, text);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.Write("\nDo you want to test another case? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes") break;
        }
    }
}
