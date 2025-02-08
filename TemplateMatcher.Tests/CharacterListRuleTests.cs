using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMatcher.Tests
{
    public class CharacterListRuleTests
    {
        [Fact]
        public void CharacterListRule_ShouldMatch_AllowedCharacters()
        {
            var rule = new CharacterListRule(new[] { 'A', 'B', 'C' });
            rule.Matches('A').Should().BeTrue();
            rule.Matches('B').Should().BeTrue();
            rule.Matches('C').Should().BeTrue();
        }

        [Fact]
        public void CharacterListRule_ShouldNotMatch_DisallowedCharacters()
        {
            var rule = new CharacterListRule(new[] { 'A', 'B', 'C' });
            rule.Matches('D').Should().BeFalse();
            rule.Matches('Z').Should().BeFalse();
        }
    }
}
