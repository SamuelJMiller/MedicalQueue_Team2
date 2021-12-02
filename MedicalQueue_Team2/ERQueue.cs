using System;
using System.Collections.Generic;


// from assignment: You will be simulating an emergency room queue by writing a class called ERQueue.
namespace MedicalQueue_Team2
{
	public class ERQueue
	{

		private Node _head;
		private Node _current;
		private Patient _patient;

		//Created the Next variable in Node which should start at the head when caling it. - Jordan 

		//public Node Head
		//      {
		//	get { return _head; }
		//	set { _head = value; }
		//      }

		// Canvas : The queue will enqueue on demand by menu-driven  user input,
		// and will dequeue based on the highest prioity patient in the queue.


		// Now this was only to test my Dequeue method. Now what we could do to improve this is looking at the priority value and then inserting that node.
		// That way the highest priority is pulled first. Any thoughts? - Jordan 

		public int Enqueue(Patient p)
        {
			Node createNode = new Node(p);

			if(_head == null)
            {
				_head = createNode;
				return 0;
			}

			_current = _head;

			while (_current != null)
			{
				if (_current.Next == null)
				{
					_current.Next = createNode;
					break;
				}
				else
				{
					_current = _current.Next;
				}
			}
			return 0;
        }

		// Dequeue works - Jordan
		public Patient Dequeue()
        {
			if(_head != null)
            {
				_patient = _head.grabData;
				_head = _head.Next;
				return _patient;
            }
			else
            {
				return null;
            }
        }

		public string List()
        {
			string final = string.Empty;



			return final;
        }


		public override string ToString()
		{  // ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
			return base.ToString();

		}

	}
}
