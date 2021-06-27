using NUnit.Framework;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        MoodAnalyzer MoodAnalyzer = new MoodAnalyzer();

        /// <summary>
        /// TC 1.1 Given I am in Sad Mood, should return SAD
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
        /// TC 1.2 Given I am in Happy Mood, should return HAPPY
        /// </summary>
        [Test]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            MoodAnalyzer MoodAnalyzer = new MoodAnalyzer(message);

            // Act
            string mood = MoodAnalyzer.AnalyzeMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// TC 2.1 Given Null Mood, should return HAPPY
        /// </summary>
        [Test]
        public void GivenNullMoodShouldReturnHAPPY()
        {
            // Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyzer MoodAnalyzer = new MoodAnalyzer(message);

            // Act
            string mood = MoodAnalyzer.AnalyzeMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}