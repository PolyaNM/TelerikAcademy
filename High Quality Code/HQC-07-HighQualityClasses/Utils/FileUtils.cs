namespace Utils
{
    using System;

    public static class FileUtils
    {
        public static string GetExtension(string file)
        {
            if (file == null)
            {
                throw new ArgumentException("File cannot be null.");
            }

            int indexOfLastDot = file.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = file.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string file)
        {
            if (file == null)
            {
                throw new ArgumentException("File cannot be null.");
            }

            int indexOfLastDot = file.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return file;
            }

            string fileNameWithoutExtension = file.Substring(0, indexOfLastDot);
            return fileNameWithoutExtension;
        }
    }
}
