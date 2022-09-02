// See https://aka.ms/new-console-template for more information

namespace App
{
    public class Program
    {
        public bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        public static void Main() { }
    }
}
