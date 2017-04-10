using System;
using SIMOCModel.Enum;

namespace SIMOCModel.Events
{
    public class ErrorEventArgs : EventArgs
    {
        public ErrorEventArgs(ErrorType errorType, Exception exception)
        {
            ErrorType = errorType;
            Exception = exception;
        }

        public ErrorEventArgs(ErrorType errorType, string message)
        {
            ErrorType = errorType;
            Exception = new Exception(message);
        }

        public ErrorType ErrorType { get; set; }

        public Exception Exception { get; set; }
    }
}
