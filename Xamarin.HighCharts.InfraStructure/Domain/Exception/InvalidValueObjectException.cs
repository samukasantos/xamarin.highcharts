﻿
namespace xamarin.highcharts.infrastructure.Domain.Exception
{
    public class InvalidValueObjectException : System.Exception
    {
        #region Constructor

        public InvalidValueObjectException(string message)
            : base(message) { }

        #endregion
    }
}
