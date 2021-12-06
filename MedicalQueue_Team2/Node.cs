/*--
 * MedicalQueue_Team2
 * ERQueue - Node Class
*/

namespace MedicalQueue_Team2
{
	class Node
	{
		private Patient _data;
		private Node _next;

		// Changed it from myNode to Node. It thought it was a method and was asking for a return value. Now it sees it as a constructor. -Jordan

		public Node(Patient p)
		{
			_data = p;
		}

		// Created a getter for the Dequeue so I can grab the information
		// from the patient class. Then I'll be able to return the values
		// once values are returned i'll assign the head to the next node. - Jordan
		public Patient grabData
		{
			get { return _data; }
		}

		// Changed this to a node since this is only grabbing the node value. That way we can assign the next head node in dequeue - Jordan
		public Node Next
		{
			get { return _next; }
			set { _next = value; }
		}

		public override string ToString()
		{
			return _data.ToString();
		}
	}
}
