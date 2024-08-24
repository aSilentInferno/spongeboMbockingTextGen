using SpongebobMockingTextGen;

namespace SpongeBobMockingTextGen.Test
{
    public class ProgramTests
    {
        [Fact]
        public void ConvertToMockingText_AlternatesCaseCorrectly()
        {
            // Arrange
            string input = "hello world";
            string expected = "hElLo WoRlD";

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToMockingText_IgnoresNonAlphabeticCharacters()
        {
            // Arrange
            string input = "123 hello!";
            string expected = "123 hElLo!";

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToMockingText_ReturnsEmptyStringForEmptyInput()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToMockingText_ReturnsNullForNullInput()
        {
            // Arrange
            string? input = null;

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ConvertToMockingText_HandlesSingleCharacterInput()
        {
            // Arrange
            string input = "a";
            string expected = "a";

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToMockingText_HandlesMixedCaseInput()
        {
            // Arrange
            string input = "HeLLo WoRLd";
            string expected = "hElLo WoRlD";

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToMockingText_NoLetters()
        {
            // Arrange
            string input = "4554 (§/$%)";
            string expected = input;

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToMockingText_EscapeChars()
        {
            // Arrange
            string input = @"Hello \ World";
            string expected = @"hElLo \ WoRlD";

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ConvertToMockingText_Quote()
        {
            // Arrange
            string input = "Hello \"world\"";
            string expected = "hElLo \"WoRlD\"";

            // Act
            string? result = Program.ConvertToMockingText(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
