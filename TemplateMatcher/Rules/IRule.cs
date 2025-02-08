using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMatcher.Rules
{
    public interface IRule // Base Interface
    {
        bool Matches(char textChar);
    }
}
