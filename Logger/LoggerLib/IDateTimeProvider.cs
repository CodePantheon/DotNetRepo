
namespace LoggerLib
{
    using System;

    /// <summary>
    /// Date Time provider interface
    /// </summary>
    public interface IDateTimeProvider
    {
        /// <summary>
        /// Gets Current Date Time.
        /// </summary>
        DateTime CurrentDateTime { get; }
    }
}
