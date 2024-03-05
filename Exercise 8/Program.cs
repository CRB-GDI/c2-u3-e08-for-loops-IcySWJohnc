namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum number : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                //for loop body
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
               
            }
            Console.WriteLine("How many rows of asterisk?");
            int astNum = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < astNum; i++)
            {
                Console.Write("*");
            }
        }
    }
}