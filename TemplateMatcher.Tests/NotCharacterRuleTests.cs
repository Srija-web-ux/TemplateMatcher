using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMatcher.Rules;

namespace TemplateMatcher.Tests
{
    public class NotCharacterRuleTests
    {
        [Fact]
        public void NotCharacterRule_ShouldMatch_WhenCharacterIsDifferent()
        {
            var rule = new NotCharacterRule('X');
            rule.Matches('A').Should().BeTrue();
            rule.Matches('B').Should().BeTrue();
        }

        [Fact]
        public void NotCharacterRule_ShouldNotMatch_WhenCharacterIsExact()
        {
            var rule = new NotCharacterRule('X');
            rule.Matches('X').Should().BeFalse();
        }
    }
}
