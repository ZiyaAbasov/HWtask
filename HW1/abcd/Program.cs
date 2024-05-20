namespace abcd
{
    internal class Program 
    { 

        static void Main(string[] args)
        {
            int sumofnumber = SUM(15); 


            Console.WriteLine(sumofnumber);
        }

        static int SUM(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

}
