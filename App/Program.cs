// See https://aka.ms/new-console-template for more information

namespace App
{
    public class Program
    {
        public bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        public String PromptForLeapYear(int year)
        {
            return IsLeapYear(year) switch
            {
                true => "yay",
                false => "nay"
            };
        }

        public static void Main()
        {
            var app = new Program();

            Console.Write("Check if leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(app.PromptForLeapYear(year));
        }
    }
}
