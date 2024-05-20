using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "HelloWorld";
            char[] CapitalLetter = ReturnChars(name);

            Console.WriteLine(CapitalLetter);
        }

        static char[] ReturnChars(string name)
        {
           
            char[] results = new char[name.Length];
            int index = 0;
            foreach(char c in name) 
            {
                if (c >= 'A' && c <= 'Z') 
                {

                    results[index] = c;
                    index ++;
                }
            } return results;

        }
    }


}
