﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }

        private readonly ExceptionType _type;

        public MoodAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this._type = type;
        }
    }
}
