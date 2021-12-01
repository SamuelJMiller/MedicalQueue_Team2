/* --
 * Assignment:
 *     Main will contain a menu to allow for the queuing, dequeuing and listing the queue by accessing methods of the ERQueue.
 *    Specifically, there should be at least three menu behaviors:
 *    Enqueue: returns number of patients in the queue after adding
 *    Dequeue: returns a queue item which should be shown to the user
 *    ListL Returns a list of users/priorities and their position in the queue
 *    ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]

*/


using System;

namespace MedicalQueue_Team2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool IsRunning = true;
            string User_Input;

            do
            {
                Console.Write("(A)dd patient " +
                "(P)rocess Current Patient " +
                "(L)ist All in Queue " +
                "(Q)uit\n");
                User_Input = Console.ReadLine();

                switch (User_Input)
                {
                    case "A":
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "P":
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "L":
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "Q":
                        Console.Clear();
                        Console.Write("Program closed");
                        IsRunning = false;
                        break;

                    default:
                        Console.Clear();
                        Console.Write("ERROR\n");
                        break;
                }

            } while (IsRunning == true);
        }

      public int Enqueue()
      {  //returns number of patients in the queue after adding
         
         return 0;
      }

      public PriorityQueue Dequeue()
      {  // returns a queue item which should be shown to the user
         
      }

      public List ListL()
      {  // Returns a list of users/priorities and their position in the queue
         
      }

      public override string ToString()
      {  // ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
         return base.ToString();
      }
   }
}
