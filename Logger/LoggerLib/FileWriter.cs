
namespace LoggerLib
{
    using System;
    using System.IO;

    /// <summary>
    /// Writer class which writes text to specified file.
    /// </summary>
    internal class FileWriter : IWriter
    {
        private readonly object lockObject = new object();
        private readonly string filePath;
        private string message = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileWriter"/> class.
        /// </summary>
        /// <param name="filePath"></param>
        public FileWriter(string filePath)
        {
            if (!IsFilePathValid(filePath, out message))
            {
                throw new ArgumentException(message);
            }

            string filePathWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            this.filePath = filePathWithoutExtension + ".txt";
        }

        /// <summary>
        /// Method to write text to the <see cref="filePath"/>.
        /// </summary>
        /// <param name="log"></param>
        public void Write(string text)
        {
            lock (lockObject)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(text);
                    streamWriter.Close();
                }
            }
        }

        private bool IsFilePathValid(string filePath, out string message)
        {
            bool isValid = true;
            message = string.Empty;

            try
            {
                filePath = Path.GetFullPath(filePath);
            }
            catch (ArgumentNullException)
            {
                isValid = false;
                message = "FilePath cannot be null!";
            }
            catch (ArgumentException)
            {
                isValid = false;
                message = "FilePath is empty, contains only whitespace or invalid characters!";
            }
            catch(NotSupportedException)
            {
                isValid = false;
                message = "FilePath contains a colon that is not part of a volume identifier!";
            }
            catch(System.Security.SecurityException)
            {
                isValid = false;
                message = "FilePath is not accessible, permission denied!";
            }
            catch (PathTooLongException)
            {
                isValid = false;
                message = "Filepath too long!";
            }

            return isValid;
        }
    }
}
