using Animals;
using System;

namespace Utils
{
    class StringUtils
    {

        public bool ValidateText(string incomingTxt)
        {
            int checkForInt;

            if (int.TryParse(incomingTxt, out checkForInt))
            {
                Console.WriteLine("Input cannot be a number. Try again.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(incomingTxt))
            {
                Console.WriteLine("Something went wrong. Please try again.");
                return false;
            }
            else
                return true;
        }

        public string UppercaseFirst(string incomingTxt)
        {
            return char.ToUpper(incomingTxt[0]) + incomingTxt.Substring(1).ToLower();
        }
    }
}
