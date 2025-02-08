using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMatcher
{
    public interface IChecker
    {
        bool IsMatch(string template, string text);
    }


}
