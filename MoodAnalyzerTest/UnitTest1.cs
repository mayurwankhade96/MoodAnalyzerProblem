using NUnit.Framework;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{    
    public class Tests
    {
        MoodAnalyzer MoodAnalyzer = new MoodAnalyzer();

        /// <summary>
        /// Given I am in Sad Mood, should return SAD
        /// </summary>
        [Test]
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";

            // Act
            string message = MoodAnalyzer.AnalyzeMood("I am in Sad Mood");

            // Assert
            Assert.AreEqual(expected, message);
        }

        /// <summary>
        /// Given I am in Any Mood, should return SAD
        /// </summary>
        [Test]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            // Arrange
            string expected = "HAPPY";

            // Act
            string message = MoodAnalyzer.AnalyzeMood("I am in Any Mood");

            // Assert
            Assert.AreEqual(expected, message);
        }
    }
}