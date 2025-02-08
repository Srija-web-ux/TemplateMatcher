using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMatcher.Rules
{
    public class NotCharacterRule : IRule
    {
        private char NotChar;

        public NotCharacterRule(char NotChar)
        {
            this.NotChar = char.ToUpper(NotChar);
        }

        public bool Matches(char c) => char.ToUpper(c) != NotChar; //Matches any char except the given one
    }
}
