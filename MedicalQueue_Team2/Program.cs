/* --
	MedicalQueue_Team2

* Assignment:
*	Main will contain a menu to allow for the queuing, dequeuing and listing the queue by accessing methods of the ERQueue.
*	Specifically, there should be at least three menu behaviors:
*	Enqueue: returns number of patients in the queue after adding
*	Dequeue: returns a queue item which should be shown to the user
*	ListL Returns a list of users/priorities and their position in the queue
*	ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
*
*	AP:  Worked on add / enqueue, stubbed in menu methods

Done:
	Console output for Main Menu
	Patient Class
	AP:  12/2 - setup class with test data & menu option to load it

ToDo:
	ERQueue:
		overrride to String
		List Function
		Enqueue
		Dequeue

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

namespace MedicalQueue_Team2
{
	class Program
	{
		// Some methods to make our lives easier :)
		public static void wr(string s = "")
		{
			Console.WriteLine(s);
		}

		// Made main private to keep variables safe . -Jordan
		private static void Main(string[] args)
		{
			bool IsRunning = true;
			ERQueue ourEQ = new ERQueue();
			// Menu Loop
			do {
				wr("(A)dd patient " +
					"(P)rocess Current Patient " +
					"(L)ist All in Queue " +
					"(Q)uit " +
					"(T)est data");
					//User_Input = Console.ReadLine().ToUpper(); -Read comment below
				// Since we dont have to validate are we okay with inserting the Console ReadLine. To avoid creating temp data that were going to throw away? -Jordan

				switch (Console.ReadLine().ToUpper()) {
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
					Console.Clear();
					wr(ourEQ.List()); // I only commented this out to test my Dequeue method - Jordan
					break;

				case "P":
					Console.Clear();
					// Console writing line to see the first names for each person to verify the Dequeue is working properly. -Jordan
					// AP - update when return ToString output fixed
					if (ourEQ.Peek() == true) { wr(ourEQ.Dequeue().getFirst()); }
					else { wr("No patients in queue."); }
					break;

				case "Q":
					Console.Clear();
					wr("Program closed");
					IsRunning = false;
					break;

				case "T":      // Load fake data
					Console.Clear();
					ourEQ.loadData();
					wr("Data Loaded For Testing");
					break;

				default:
					Console.Clear();
					wr("ERROR");
					break;
				}
			} while (IsRunning == true);
		}
	}
}
