namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            while (valid == false)
            {
                DateTime current = DateTime.Now;
                DateTime target = new DateTime(2025, 4, 4, 15, 15, 0);
                TimeSpan difference = target - current;

                Console.WriteLine(difference);
                Thread.Sleep(1000);
                
                if (current == target)
                {
                    valid = true;
                }
            }
        }
    }
}
