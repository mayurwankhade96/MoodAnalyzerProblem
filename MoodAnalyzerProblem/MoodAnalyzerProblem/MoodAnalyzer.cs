using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        /// <summary>
        /// Method to analyze mood
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string AnalyzeMood(string message)
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
