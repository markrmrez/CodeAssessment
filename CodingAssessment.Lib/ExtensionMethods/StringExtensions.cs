using System;
using System.Linq;

namespace CodingAssessment.Lib.ExtensionMethods
{
    public static class StringExtensions
    {
        /// <summary>
        /// This extension method is used to split 
        /// the sting with space and get the last element.
        /// </summary>
        /// <param name="str">The actual string</param>
        /// <returns>Last Element of the String</returns>
        public static string GetLastElement(this String str, char separator)
        {
            return str.Trim().Split(separator).LastOrDefault();
        }
    }
}
