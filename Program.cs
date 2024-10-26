namespace day2_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 3

            int sum = 0;
            
            while (sum <= 100)
            {
                Console.WriteLine("enter a number you have sum");
                int number=int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($" you sum {sum} is exceeds 100 now");

        }
    }
}
