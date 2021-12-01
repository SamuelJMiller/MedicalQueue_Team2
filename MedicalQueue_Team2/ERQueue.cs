using System;
using System.Collections.Generic;


// from assignment: You will be simulating an emergency room queue by writing a class called ERQueue.
namespace MedicalQueue_Team2
{
	public class ERQueue
	{

		private Node _head;

		public Node Head
        {
			get { return _head; }
			set { _head = value; }
        }

		public int Enqueue(Patient p)
        {
			return 0;
        }

		public Patient Dequeue()
        {

        }

		public string List()
        {
			string final = string.Emtpy;



			return final;
        }


		public override string ToString()
		{  // ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
			return base.ToString();

		}

	}
}
