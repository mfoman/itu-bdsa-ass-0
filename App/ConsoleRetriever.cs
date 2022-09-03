namespace App
{
    public class ConsoleRetriever
    {
        public virtual int GetInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
