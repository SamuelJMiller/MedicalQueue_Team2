/*
 *    MedicalQueue_Team2
 *     ERQueue - Patient Class

Assignment: Patients are added to the queue with two pieces of information:  Name [first last] and (1:highest priority – 5:lowest priority)
	To manage this information, you will create a simple Patient class with a constructor for the above
	and read-only properties to expose basic data (first, last, priority) data.
Done:
	AP 12/2 - added ToString method that returns ["First"   "priority"]

Notes:
*/
using System;
namespace MedicalQueue_Team2
{

	public class Patient
	{
		private string first;
		private string last;
		private int priority;


		public Patient()
		{
			this.first = "";
			this.last = "";
			this.priority = 0;
		}

		public Patient(string first, string last, int priority)
		{
			this.first = first;
			this.last = last;
			this.priority = priority;
		}
      public override string ToString()
      {
         return (first + "   " + priority.ToString());
      }


      public string getFirst()	 { return (this.first); }
		public string getLast()		 { return this.last; }
		public int	  getPriority() { return this.priority; }

		// Andrea:  Since it is a read-only class, do you think we need the setters?
		//  Group:  No - remove the setters.
		// public void setFirst(string first) { this.first = first; }
		// public void setLast(string last) { this.last = last; }
		// public void setPriority(int priority) { this.priority = priority; }

	}
}
