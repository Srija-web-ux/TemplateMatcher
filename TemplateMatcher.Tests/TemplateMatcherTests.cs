using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMatcher;

namespace TemplateMatcher.Tests
{
    public class TemplateMatcherTests
    {
        private readonly TemplateChecker _matcher = new TemplateChecker();

        [Fact]
        public void IsMatch_ShouldReturnTrue_WhenTextMatchesTemplate()
        {
            _matcher.IsMatch("(B|D|E)**AC*", "BPQACC").Should().BeTrue();
        }

        [Fact]
        public void IsMatch_ShouldReturnFalse_WhenTextDoesNotMatchTemplate()
        {
            _matcher.IsMatch("(B|D|E)**AC*", "BPQBCC").Should().BeFalse();
        }

        [Fact]
        public void IsMatch_ShouldThrowException_WhenTemplateIsEmpty()
        {
            var act = () => _matcher.IsMatch("", "ABC");
            act.Should().Throw<ArgumentException>().WithMessage("Template cannot be empty");
        }

        [Fact]
        public void IsMatch_ShouldThrowException_WhenTemplateLengthDoesNotMatchTextLength()
        {
            var act = () => _matcher.IsMatch("(A|B|C)*D", "ABCDE");
            act.Should().Throw<ArgumentException>().WithMessage("Template rules length must match text length");
        }

        [Fact]
        public void IsMatch_ShouldReturnTrue_WhenUsingNotCharacterRule()
        {
            _matcher.IsMatch("!X*", "YA").Should().BeTrue(); 
        }

        [Fact]
        public void IsMatch_ShouldReturnFalse_WhenUsingNotCharacterRuleIncorrectly()
        {
            _matcher.IsMatch("!X*", "XA").Should().BeFalse(); 
        }
    }
}
