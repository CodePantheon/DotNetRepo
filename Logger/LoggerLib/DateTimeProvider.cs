
namespace LoggerLib
{
    using System;

    /// <summary>
    /// Implementation class for <see cref="IDateTimeProvider"/> interface.
    /// </summary>
    internal class DateTimeProvider : IDateTimeProvider
    {
        /// <summary>
        /// Provides current Date and Time.
        /// </summary>
        public DateTime CurrentDateTime
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
