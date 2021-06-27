using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string _message;
        public MoodAnalyzer()
        {

        }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyzer(string message)
        {
            this._message = message;
        }

        /// <summary>
        /// Method to analyze mood
        /// </summary>
        /// <returns></returns>
        public string AnalyzeMood()
        {
            try
            {
                if (this._message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }            
        }
    }
}
