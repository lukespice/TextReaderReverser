using System;
using System.Linq;
using Xunit;

namespace TextReaderReverser.UnitTests
{
    public class StringExtensonsTests
    {
        /*
         * a. The first character of the first line of the output 
         * should be the last character of the last line of the input
         */
        [Fact]
        public void FirstCharacterOfFirstLine_ShouldBe_LastCharacterOfLastLine()
        {
            var multiLineText = $"abcd{Environment.NewLine}efg";

            var reversed = multiLineText.Reverse();

            Assert.Equal('g', reversed.ToCharArray().First());
        }

        /*
         * b. The first character of the second line of the output 
         * should be the last character of the second-last line of the input
         */
        [Fact]
        public void FirstCharacterOfSecondLine_ShouldBe_LastCharacterOfSecondLastLine()
        {
            var multiLineText = $"abcd{Environment.NewLine}efg{Environment.NewLine}hijk{Environment.NewLine}lmnop{Environment.NewLine}qrst";

            var reversed = multiLineText.Reverse();
            var lines = reversed.Split(Environment.NewLine);

            Assert.Equal('p', lines[1].First());
        }

        /*
         * c. The last character of the last line of the output 
         * should be the first character of the first line of the input
         */
        [Fact]
        public void LastCharacterOfLastLine_ShouldBe_FirstCharacterOfFirstLine()
        {
            var multiLineText = $"abcd{Environment.NewLine}efg{Environment.NewLine}hijk{Environment.NewLine}lmnop{Environment.NewLine}qrst";

            var reversed = multiLineText.Reverse();
            var lines = reversed.Split(Environment.NewLine);

            Assert.Equal('a', lines.Last().Last());
        }
    }
}
