/* --
   MedicalQueue_Team2

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
   AP:  12/2 - setup class with test data & menu option to load it

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
        // Some methods to make our lives easier :)
        public static void wr()
        {
            Console.WriteLine();
        }

        public static void wr(string s)
        {
            Console.WriteLine(s);
        }

      ERQueue ourEQ = new ERQueue();

      static void Main(string[] args)
        {
         
         bool IsRunning = true;
         string User_Input;
         ERQueue ourEQ = new ERQueue();

            // Menu Loop
            do
            {
            Console.Write("(A)dd patient " +
               "(P)rocess Current Patient " +
               "(L)ist All in Queue " +
               "(Q)uit\n" + 
               "load (T)est data\n");
            User_Input = Console.ReadLine().ToUpper();
            
            switch (User_Input)
            {
            case "A":
               string first = string.Empty;
               string last = string.Empty;
               int priority = 0;

               wr("Enter patient first name:");

               first = Console.ReadLine();
               wr(); // New lines for prettiness
                  wr("Enter patient last name:");

               last = Console.ReadLine();

               wr();
               wr("Enter patient priority:");

               priority = Int32.Parse(Console.ReadLine()); // Assuming correct input :)

               Patient newPatient = new Patient(first, last, priority);

               wr();
               wr("Added patient " + first + ", there are now " + ourEQ.Enqueue(newPatient) + " patient(s) in the queue.");
               wr();
               break;

            case "L":
               Console.Write("\nPress any key to continue...");
               Console.ReadKey();
               Console.Clear();
               Console.WriteLine("debug:");
               Console.WriteLine(ourEQ.ToString()); // I only commented this out to test my Dequeue method - Jordan
               break;

            case "P":
               Console.Write("\nPress any key to continue...");
               Console.ReadKey();
               Console.Clear();
               // Console writing line to see the first names for each person to verify the Dequeue is working properly. -Jordan
               Console.WriteLine(ourEQ.Dequeue().getFirst());
               break;

            case "Q":
               Console.Clear();
               Console.Write("Program closed");
               IsRunning = false;
               break;
                  
            case "T":      // Load fake data
               Console.Clear();
               ourEQ.loadData();
               Console.Write("Data Loaded For Testing \n");
               break;

            default:
               Console.Clear();
               Console.Write("ERROR\n");
               break;
            }
            } while (IsRunning == true);
        }
      }
   }
