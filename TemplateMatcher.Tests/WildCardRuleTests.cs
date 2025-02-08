using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMatcher.Tests
{
    public class WildCardRuleTests
    {
        [Fact]
        public void WildcardRule_ShouldMatch_AnyCharacter()
        {
            var rule = new WildCardRule();

            rule.Matches('A').Should().BeTrue();
            rule.Matches('z').Should().BeTrue();
            rule.Matches('1').Should().BeTrue();
            rule.Matches('!').Should().BeTrue();
        }
    }
}
