/* -- 	ERQueue - Patient Class

Assignment: Patients are added to the queue with two pieces of information:
	Name
	Priority (1:highest priority – 5:lowest priority)
	To manage this information, you will create a simple Patient class with a constructor for the above
	and read-only properties to expose basic data (first, last, priority) data.


Notes:
	Andrea:  Since it is a read-only class, do you think we need the setters?

*/

using System;

public class Patient
{
	public int ID;

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

	public string getFirst() 
	{
		return this.first;
	}

	public string getLast()
	{
		return this.last;
	}

	public int getPriority() 
	{
		return this.priority;	
	}

}
