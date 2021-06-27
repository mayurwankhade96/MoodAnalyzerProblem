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
            string message = "I am in Sad Mood";
            MoodAnalyzer MoodAnalyzer = new MoodAnalyzer(message);

            // Act
            string mood = MoodAnalyzer.AnalyzeMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Given I am in Any Mood, should return SAD
        /// </summary>
        [Test]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyzer MoodAnalyzer = new MoodAnalyzer(message);

            // Act
            string mood = MoodAnalyzer.AnalyzeMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}