using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClassExampleWF.Utils
{
    /// <summary>
    /// Internal class with utilities to validate inputs.
    /// </summary>
    internal static class InputValidation
    {
        /// <summary>
        /// Converts the string to list.
        /// </summary>
        /// <param name="listAsText">The list as text.</param>
        /// <returns></returns>
        internal static List<int> ConvertStringToList(string listAsText)
        {
            var result = new List<int>();
            foreach (var item in listAsText)
            {
                if (int.TryParse(item.ToString(), out int number))
                {
                    result.Add(number);
                }
            }

            if (result.Count == 0)
            {
                MessageBox.Show("No valid digits found in the first value. Please enter a list of elements.");
            }

            return result;
        }

        /// <summary>
        /// Validates the string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        internal static bool ValidateString(string input, string message)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show(message);
                return false;
            }

            return true;
        }
    }
}
