using System;
using System.Collections.Generic;


// from assignment: You will be simulating an emergency room queue by writing a class called ERQueue.
namespace MedicalQueue_Team2
{
	public class ERQueue
	{

	//	public List list()


      public int Enqueue()
		{  // returns number of patients in the queue after adding
			// Add the the Patient to the (List of String)
			// Return Current County
			return 0;
      }

      public Patient Dequeue()
		{  // returns a queue item which should be shown to the user
			// Remove & Return the Person
			// Do this.
			Patient patient = new Patient();

			return patient;
      }

		public string listL()
      { // Returns a list of users / priorities and their position in the queue

			String myString = String.Empty;
			Patient patient = new Patient();

			// For each Patient in the List ...  (For each Node in Linked List)
			// Patient.ToString()
			myString = Patient.ToString() + myString;

			return myString;
			
		}

		public override string ToString()
		{  // ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
			return base.ToString();

		}

	}
}
