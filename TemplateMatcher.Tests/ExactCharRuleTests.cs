using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMatcher.Tests
{
    public class ExactCharRuleTests
    {
        [Fact]
        public void ExactCharacterRule_ShouldMatch_ExactCharacter()
        {
            var rule = new ExactCharRule('A');
            rule.Matches('A').Should().BeTrue();
        }

        [Fact]
        public void ExactCharacterRule_ShouldNotMatch_WrongCharacter()
        {
            var rule = new ExactCharRule('A');
            rule.Matches('B').Should().BeFalse();
            rule.Matches('C').Should().BeFalse();
        }
    }
}
