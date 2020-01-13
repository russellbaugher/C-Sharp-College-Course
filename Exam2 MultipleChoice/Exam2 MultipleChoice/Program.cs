using System;

namespace Exam2_MultipleChoice
{
    class Program
    {
        public static void Main()
        {
            // Init Vars
            string answer = "";
            string option = "";
            int score = 0;
            int tries = 0;

            do // Run Both Questions & Tally Score
            {
                // Reset Score For 2nd Attempt
                score = 0;

                // Display Instructions & Attempt #
                Console.WriteLine("\nMultiple choice questions, select one answer in each question. " +
                                  $"(Note: You have 2 attempts, ATTEMPT: {tries + 1}");

                //Question 1
                Console.WriteLine("\n1. Where is the capital of the State of Florida ?" +
                                  "\nA. Orlando" +
                                  "\nB. Tallahassee" +
                                  "\nC. Miami \nD. Tampa");
                Console.Write("\nAnswer: ");
                answer = Console.ReadLine().ToUpper(); // User Input abcd

                switch (answer)
                {
                    case "A":
                        break;
                    case "B":
                        score += 50;
                        break;
                    case "C":
                        break;
                    case "D":
                        break;
                    default:
                        Console.WriteLine("Invalid Answer");
                        break;
                }

                Console.WriteLine("\n2. Where is Walt Disney World Park Located in Florida ?" +
                                  "\nA. Orlando" +
                                  "\nB. Tallahassee" +
                                  "\nC. Miami" +
                                  "\nD. Tampa");
                Console.Write("\nAnswer: ");
                answer = Console.ReadLine().ToUpper(); // User Input abcd

                switch (answer)
                {
                    case "A":
                        score += 50;
                        break;
                    case "B":
                        break;
                    case "C":
                        break;
                    case "D":
                        break;
                    default:
                        Console.WriteLine("Invalid Answer");
                        break;
                }

                // Display Score
                Console.WriteLine($"\nYour score is {score}%");
                tries++; // Increment tries for 2nd Attempt

                // Test For Conditions That Will End Program
                if (tries == 2 || score == 100)
                {
                    break;
                }
                else
                {
                    // Offer 2nd Attempt if Score < 100
                    Console.Write("\nWould you like to try one more time? (Y/N): ");
                    option = Console.ReadLine().ToUpper(); // User Input y/n
                }

            } while (option != "N");  // User Input N to End Program After 1st Attempt

        } // End Main
    }
}
