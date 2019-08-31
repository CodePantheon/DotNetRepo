using System;
using System.Windows.Forms;

namespace CodePantheon.LogIO
{
    /// <summary>
    /// 
    /// </summary>
    internal class TextLogWriter : ILogWriter
    {
        public void WriteLog(LogData logData)
        {
            MessageBox.Show(
                "Implement write log method yourself, see log below:" + Environment.NewLine + logData.ToString(), 
                "TextLogWriter");
        }
    }
}