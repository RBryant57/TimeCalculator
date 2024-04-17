using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace local.YellowCaddis.TimeCalculator.Core.Constants
{
    /// <summary>
    /// This class holds constants needed by the application.
    /// </summary>
    public class Constants
    {
        public const string REGEX_TIME = "^([0-1][0-9]|[2][0-3]):([0-5][0-9]):([0-5][0-9])$";
        public const string TIME_ERROR = "Invalid start time. Start times are in the format hh:mm:ss";
        public const string TITLE = "Time Calculator";
        public const long HOURTICKS = 36000000000;
        public const long TWELVEHOURTICKS = 43200000000;
    }
}