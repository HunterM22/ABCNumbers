

namespace OP_MelissaHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            ABCNumberProblem();
            //Main calls the method
        }

        private static void ABCNumberProblem()
        {
            string output = string.Empty; //Initialize empty string
            for (int i = 1; i <= 5; i++) //Loop to increment the integer
            {
                int number = i;
                string letters = "abc";
                output += string.Concat(letters, (i.ToString())); //Convert int to string and concatenate results
            }
            Console.WriteLine(output); //Print the output result to the screen
        }




    }
}