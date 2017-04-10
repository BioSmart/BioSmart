using System;
using SIMOCModel.Enum;

namespace SIMOCModel
{
    public class Error
    {
        public Error(ErrorType errorType, string data, DateTime date)
        {
            ErrorType = errorType;
            Data = data;
            Date = date;
        }

        public ErrorType ErrorType { get; set; }

        public string Data { get; set; }

        public DateTime Date { get; set; }
    }
}