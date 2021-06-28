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
        //[Test]
        //public void GivenNullMoodShouldReturnHAPPY()
        //{
        //    // Arrange
        //    string expected = "HAPPY";
        //    string message = null;
        //    MoodAnalyzer MoodAnalyzer = new MoodAnalyzer(message);

        //    // Act
        //    string mood = MoodAnalyzer.AnalyzeMood();

        //    // Assert
        //    Assert.AreEqual(expected, mood);
        //}

        /// <summary>
        /// TC 3.1 Given NULL Mood Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                // Arrange
                string message = null;
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

                // Act
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch(MoodAnalyzerException ex)
            {
                // Assert
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }

        /// <summary>
        /// TC 3.2 Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood
        /// </summary>
        [Test]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                // Arrange
                string message = "";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

                // Act
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                // Assert
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }
    }
}