/* --
 * Assignment:
 *     Main will contain a menu to allow for the queuing, dequeuing and listing the queue by accessing methods of the ERQueue.
 *    Specifically, there should be at least three menu behaviors:
 *    Enqueue: returns number of patients in the queue after adding
 *    Dequeue: returns a queue item which should be shown to the user
 *    ListL Returns a list of users/priorities and their position in the queue
 *    ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
 *    
 *    AP:  Worked on add / enqueue, stubbed in menu methods

Done:
   Console output for Main Menu
   Patient Class

ToDo:
   ERQueue:  
      overrride to String
      List Function
      Enqueu
      Dequeu

   Menu
      Update to run code


ToDO:
   Create node class for holding Patient objects
      ie: 1 patient per node; these are the building blocks for the linked list Class:ERQueue
Node Class:  Has an instance variable that holds the data (Patient instance); 
   Do we want pervious & Next nodes?  Group:  Let's start with just the next node

Console Output
*/


using System;
using System.Collections;

namespace MedicalQueue_Team2
{
    class Program
    {
      ERQueue ourEQ = new ERQueue();
      private int currentCount = 0;

      static void Main(string[] args)
        {
         
         bool IsRunning = true;
         string User_Input;
         ERQueue ourEQ = new ERQueue();

            do
            {
                Console.Write("(A)dd patient " +
                "(P)rocess Current Patient " +
                "(L)ist All in Queue " +
                "(Q)uit\n");
                User_Input = Console.ReadLine().ToUpper();

                switch (User_Input)
                {
                    case "A":
                     Console.Write("\nPress any key to continue...");
                     Console.ReadKey();
                     Console.Clear();
                  // addPatient();
                        break;

                    case "P":
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                  // processPatient();
                        break;

                    case "L":
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                  ourEQ.listL();
                  // listL();
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

// TODO:  prompt for patient info
      public int addPatient()
      {//returns number of patients in the queue after adding

         string first = new string("Mary");
         string last = new string("Smith");
         int priority = 0;

         Patient patient = new Patient(first, last, priority);

         // Update this

      }

      }
   }
