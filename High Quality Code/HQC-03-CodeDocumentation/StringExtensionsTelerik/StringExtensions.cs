//----------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Telerik Academy">
// Copyright © Telerik Academy 2014. All rights reserved. 
// </copyright>
//----------------------------------------------------------------
namespace StringExtensionsTelerik
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains extension methods for class System.String
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the MD5 hash of a string.
        /// </summary>
        /// <param name="input">The string which hash will be generated</param>
        /// <returns>Hexademical string</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Checks if the string can be interpreted as the System.Boolean "true" value.
        /// </summary>
        /// <param name="input">The string to be checked</param>
        /// <returns>True if the string can be interpreted as the System.Boolean "true" value.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts the string to System.Int16.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The Int16 representation of the string.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts the string to System.Int32.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The Int32 representation of the string.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts the string to System.Int64.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The Int64 representation of the string.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts the string to System.DateTime.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The System.DateTime representation of the string.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Takes a string and returns a copy of it with capitalized first letter
        /// </summary>
        /// <param name="input">The string to be manipulated</param>
        /// <returns>A copy of the string with capitalized first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns a substring of the <paramref name="input"/> which is between <paramref name="startString"/>
        /// and <paramref name="endString"/>. Search starts from <paramref name="startFrom"/> index.
        /// </summary>
        /// <param name="input">The string instance.</param>
        /// <param name="startString">The left delimiter of the result substring.</param>
        /// <param name="endString">The right delimiter of the result substring.</param>
        /// <param name="startFrom">The start position of the substring search.</param>
        /// <returns>A string that is the substring which is between <paramref name="startString"/>
        /// and <paramref name="endString"/> (the searching starts from <paramref name="startFrom"/>) OR returns an empty string 
        /// if <paramref name="startString"/> or <paramref name="endString"/> cannot be found in the original string instance.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Replaces all occurrences of bulgarian(Cyrillic) letters in the string with their Latin equivalents.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>A string in which all bulgarian letters are replaced by their Latin equivalents.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Replaces all occurrences of Latin letters in the string with their bulgarian(Cyrillic) equivalents.
        /// </summary>
        /// <param name="input">The string instance.</param>
        /// <returns>A string in which all Latin letters are replaced by their bulgarian(Cyrillic) equivalents.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Returns a string in which the bulgarian(Cyrillic) letters are replaced with their Latin equivalents
        /// and all non-alphabetic and non-numeric characters except for "." are removed(replaced with String.Empty).
        /// </summary>
        /// <param name="input">The string instance.</param>
        /// <returns>A copy of the string instance in which the bulgarian(Cyrillic) letters are replaced with their Latin ///
        /// equivalents and all non-alphabetic and non-numeric characters except for "." are removed(replaced with String.Empty).
        /// </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Returns a string in which spaces are replaced with hyphens, the bulgarian(Cyrillic) letters are replaced with their 
        /// Latin equivalents, and all non-alphabetic and non-numeric characters (excluding the period "." and hyphen "-") are 
        /// removed.
        /// </summary>
        /// <param name="input">The string instance.</param>
        /// <returns>A copy of the string instance in which spaces are replaced with hyphens, the bulgarian(Cyrillic) letters are
        /// replaced with their Latin equivalents, and all non-alphabetic and non-numeric characters (excluding the period "."
        /// and hyphen "-") are removed.
        /// </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Returns a substring of the string instance which starts from index 0 of the original string and whose length is the 
        /// lesser of <paramref name="charsCount"/> and the string instance's length.
        /// </summary>
        /// <param name="input">The string instance.</param>
        /// <param name="charsCount">The number of characters in the substring.</param>
        /// <returns>A string containing the first <paramref name="charsCount"/> number of characters of the string instance.
        /// </returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Returns the file extension of the string (file name), without the "." character.
        /// </summary>
        /// <param name="fileName">The string instance (interpreted as a file name).</param>
        /// <returns>Returns the file extension of the string (file name), without the "." character.
        /// </returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            // Splits the string by "." and takes the last element of the produced array.
            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Returns the corresponding content type for the selected file extension.
        /// </summary>
        /// <param name="fileExtension">The file extension as a string</param>
        /// <returns>The content type of the file extension as a string</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a set of characters from the specified character array into a sequence of bytes.
        /// </summary>
        /// <param name="input">The string instance.</param>
        /// <returns>A byte array containing the specified set of characters.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
