using System;
using System.Text.RegularExpressions;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerFactory
    {
        /// <summary>
        /// CreateMoodAnalyze method to create object of MoodAnalyzer class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyze(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();

                    Type moodAnalyzeType = executing.GetType(className);

                    return Activator.CreateInstance(moodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
    }
}
