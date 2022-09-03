// See https://aka.ms/new-console-template for more information

namespace App
{
    public class Program
    {
        public bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        public String PromptForLeapYear()
        {
            Console.Write("Check if is leap year: ");

            int year = GetInputAsIntOrThrowFormatException();

            bool isLeapYear = IsLeapYear(year);

            return GetResponse(isLeapYear);
        }

        public String GetResponse(bool isLeapYear)
        {
            return isLeapYear ? "yay" : "nay";
        }

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
