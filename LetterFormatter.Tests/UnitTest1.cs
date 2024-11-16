using Xunit;
using LetterFormatter; 
using System.Collections.Generic;


namespace LetterFormatter.Tests
{
    public class FormatterTests
    {
        [Fact]
        public void Test_ValidInput_ShouldReturnFormattedText()
        {
            
            int K = 20;
            var lines = new List<string> { "Привет!", "Напиши мне.", "Пока =)" };

            
            var result = Formatter.FormatText(K, lines);

            
            Assert.Equal("++++++Привет!+++++++\n++++Напиши мне.+++++\n++++++Пока =)+++++++", result);
        }


        [Fact]
        public void Test_ImpossibleFormatting_ShouldReturnImpossible()
        {
            
            int K = 5;
            var lines = new List<string> { "Привет." };

            
            var result = Formatter.FormatText(K, lines);

            
            Assert.Equal("Impossible.", result);
        }

        public void Test_SingleCharacter_ShouldBeFormatted()
        {
            
            int K = 3;
            var lines = new List<string> { "A" };

            
            var result = Formatter.FormatText(K, lines);

            
            Assert.Equal(" A ", result);
        }

        [Fact]
        public void Test_ExactWidth_ShouldNotAddSpaces()
        {
            
            int K = 10;
            var lines = new List<string> { "1234567890" };

            
            var result = Formatter.FormatText(K, lines);

            
            Assert.Equal("1234567890", result);
        }
    }
}