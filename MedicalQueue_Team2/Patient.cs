/*
 * MedicalQueue_Team2
 * ERQueue - Patient Class
 * Done:
 *		AP 12/2 - added ToString method that returns ["First"   "priority"]
 * Notes:
 *		Group:  Read-only class, do not implement getters;
*/
using System;
namespace MedicalQueue_Team2
{

	public class Patient
	{
		private string first;
		private string last;
		private int priority;

		public string getFirst() { return this.first; }
		public string getLast() { return this.last; }
		public int    getPriority() { return this.priority; }

		// Do we need this constructor since we never call on it? -Jordan

		//public Patient()
		//{
		//	this.first = "";
		//	this.last = "";
		//	this.priority = 0;
		//}

		public Patient(string first, string last, int priority)
		{
			this.first = first;
			this.last = last;
			this.priority = priority;
		}

      public override String ToString()
      {
         return (this.first+ "   " + this.priority.ToString());
      }
	}
}
