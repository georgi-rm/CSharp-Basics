using System;

namespace P04PasswordGuess
{
    class P04PasswordGuess
    {
        static void Main(string[] args)
        {
            const string secretPassword = "s3cr3t!P@ssw0rd";

            string enteredPassword = Console.ReadLine();

            if (enteredPassword == secretPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
