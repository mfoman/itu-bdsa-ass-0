// See https://aka.ms/new-console-template for more information

namespace App
{
    public class Program
    {
        /// <summary>
        /// A method to check if given year is a leap year
        /// </summary>
        /// <param name="year"></param>
        /// <returns>true if year is true and false if not</returns>
        public bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        /// <summary>
        /// Prompts the user and returns the response
        /// </summary>
        /// <returns>Returns the string given from GetResponse</returns>
        public String PromptForLeapYear()
        {
            Console.Write("Check if is leap year: ");

            int year = GetInputAsIntOrThrowFormatException();

            bool isLeapYear = IsLeapYear(year);

            return GetResponse(isLeapYear);
        }

        /// <summary>
        /// Returns a literal string response depending on the input
        /// </summary>
        /// <param name="isLeapYear"></param>
        /// <returns>
        /// Returns yay for true and nay for false
        /// </returns>
        public String GetResponse(bool isLeapYear)
        {
            return isLeapYear ? "yay" : "nay";
        }

        /// <summary>
        /// Gets input from the console and casts it to an int, else throws an exception.
        /// </summary>
        /// <returns>The year given from input</returns>
        /// <exception cref="FormatException"></exception>
        public int GetInputAsIntOrThrowFormatException()
        {
            try
            {
                return new ConsoleRetriever().GetInt();
            }
            catch (FormatException)
            {
                throw new FormatException("Sorry, only numbers are allowed!");
            }
        }

        public void Run()
        {
            string response = PromptForLeapYear();
            Console.WriteLine(response);
        }

        public static void Main()
        {
            try
            {
                new Program().Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
