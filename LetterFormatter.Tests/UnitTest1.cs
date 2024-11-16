using Xunit;
using LetterFormatter; // Подключение основного проекта
using System.Collections.Generic;


namespace LetterFormatter.Tests
{
    public class FormatterTests
    {
        [Fact]
        public void Test_ValidInput_ShouldReturnFormattedText()
        {
            // Arrange
            int K = 20;
            var lines = new List<string> { "Привет!", "Напиши мне.", "Пока =)" };

            // Act
            var result = Formatter.FormatText(K, lines);

            // Assert
            Assert.Equal("++++++Привет!+++++++\n++++Напиши мне.+++++\n++++++Пока =)+++++++", result);
        }

        [Fact]
        public void Test_ImpossibleFormatting_ShouldReturnImpossible()
        {
            // Arrange
            int K = 5;
            var lines = new List<string> { "Привет." };

            // Act
            var result = Formatter.FormatText(K, lines);

            // Assert
            Assert.Equal("Impossible.", result);
        }
    }
}