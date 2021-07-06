using NUnit.Framework;

namespace MoodAnalyzerProblem.MoodAnalyzerTests
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
            catch (MoodAnalyzerException ex)
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

        /// <summary>
        /// TC 4.1 Given MoodAnalyze class name should return MoodAnalyzer object
        /// </summary>
        [Test]
        public void GivenMoodAnalyzerClassName_ShouldReturnMoodAnalyzeObject()
        {
            // Arrange
            string message = null;
            object expected = new MoodAnalyzer(message);

            // Act
            object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");

            expected.Equals(obj);
        }

        /// <summary>
        /// TC 4.2 Given Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void CreateMoodAnalyze_ImproperClassName_ShouldThrowMoodAnalysisException()
        {
            try
            {
                // Arrange
                string className = "MoodAnalyzers.MoodAnalyzer";
                string constructorName = "MoodAnalyzer";

                // Act
                object obj = MoodAnalyzerFactory.CreateMoodAnalyze(className, constructorName);
            }
            catch (MoodAnalyzerException ex)
            {
                // Assert
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        /// <summary>
        /// TC 4.3 Given Class When Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [Test]
        public void CreateMoodAnalyze_ConstructorNotProper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                // Arrange
                string className = "MoodAnalyzerProblem.MoodAnalyzer";
                string constructorName = "MoodAnalyzers";

                // Act
                object obj = MoodAnalyzerFactory.CreateMoodAnalyze(className, constructorName);
            }
            catch (MoodAnalyzerException ex)
            {
                // Assert
                Assert.AreEqual("Constructor is not found", ex.Message);
            }
        }
    }
}