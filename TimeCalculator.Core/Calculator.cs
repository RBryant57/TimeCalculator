using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace local.YellowCaddis.TimeCalculator.Core
{
    /// <summary>
    /// This class contains the logic for doing time math.
    /// </summary>
    public class Calculator
    {

        #region Private Methods

        /// <summary>
        /// This method will return a TimeSpan object for the given string formatted
        /// as a time.
        /// </summary>
        /// <param name="differenceTime">The time formattted string to be converted
        /// into a TimeSpan object.</param>
        /// <returns>TimeSpan object from the converted string.</returns>
        private TimeSpan getDifferenceTime(string differenceTime)
        {
            int pos, pos1;
            int hours, minutes, seconds;
            TimeSpan result;

            if (Regex.IsMatch(differenceTime, "^([0-1][0-9]|[2][0-3]):([0-5][0-9]):([0-5][0-9])$"))
            {
                pos = differenceTime.IndexOf(":");
                hours = Int32.Parse(differenceTime.Substring(0, pos));
                pos++;
                pos1 = differenceTime.IndexOf(":", pos);
                minutes = Int32.Parse(differenceTime.Substring(pos, (pos1 - pos)));
                pos1++;
                seconds = Int32.Parse(differenceTime.Substring(pos1));

                result = new TimeSpan(hours, minutes, seconds);
            }
            else
                result = new TimeSpan();

            return result;
        }

        #endregion
        
        #region Public Methods

        /// <summary>
        /// This method will add an amount of time to a starting time.
        /// </summary>
        /// <param name="startTime">This parameter represents starting time for 
        /// which to add time.</param>
        /// <param name="differenceTime">This parameter represents the 
        /// time to add.</param>
        /// <returns>The resulting time.</returns>
        public DateTime Add(string startTime, string differenceTime)
        {
            DateTime start, result;
            TimeSpan difference = this.getDifferenceTime(differenceTime);

            if (difference.TotalSeconds != 0)
            {
                start = Convert.ToDateTime(startTime);
                result = start.Add(difference);

                return result;
            }
            else
                throw new Exception("Invalid difference time");
        }

        /// <summary>
        /// This method will calculate the difference between a 
        /// starting time and an ending time.
        /// </summary>
        /// <param name="startingTime">This parameter represents 
        /// the starting time.</param>
        /// <param name="endingTime">This parameter represents the 
        /// ending time.</param>
        /// <returns>The elapsed time.</returns>
        public string Elapsed(string startingTime, string endingTime)
        {
            StringBuilder result = new StringBuilder();
            DateTime start, end, elapsed;
            string hour, minute, second;

            start = Convert.ToDateTime(startingTime);
            end = Convert.ToDateTime(endingTime);
            elapsed = new DateTime(Math.Abs((end - start).Ticks));

            // Difference is less than 1 hour
            if (Math.Abs((end - start).Ticks) < Constants.Constants.HOURTICKS)
                result.Append("00:");
            else
            {
                hour = Convert.ToString(elapsed.Hour);
                if (hour.Length < 2)
                    result.Append("0");
                result.Append(hour);
                result.Append(":");
            }

            minute = Convert.ToString(elapsed.Minute);
            if (minute.Length < 2)
                result.Append("0");
            result.Append(minute);
            result.Append(":");

            second = Convert.ToString(elapsed.Second);
            if (second.Length < 2)
                result.Append("0");
            result.Append(second);

            return result.ToString();
        }

        /// <summary>
        /// This method will subtract an amount of time from a starting time.
        /// </summary>
        /// <param name="startTime">This parameter represents the starting 
        /// time from which to subtract time.</param>
        /// <param name="differenceTime">This parameter represents the time 
        /// to subtract.</param>
        /// <returns>The resulting time.</returns>
        public DateTime Subtract(string startTime, string differenceTime)
        {
            DateTime start, result;
            TimeSpan difference = this.getDifferenceTime(differenceTime);

            if (difference.TotalSeconds != 0)
            {
                start = Convert.ToDateTime(startTime);
                result = start.Subtract(difference);

                return result;
            }
            else
                throw new Exception("Invalid difference time");
        }

        #endregion

    }
}