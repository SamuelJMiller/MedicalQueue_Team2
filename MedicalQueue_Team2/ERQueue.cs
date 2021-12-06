/*
*	MedicalQueue_Team2
*	ERQueue Class
*
*	Done:
*		Dequeue works - Jordan
*		Created the Next variable in Node which should start at the head when caling it. - Jordan
*		Tested Enqueu with fakedata - working - AP
*		added ToString, iterates trhough note list and appends patient.ToString() results - AP
*
*		working on:
*			ERQueue.Enqueue() -SAM
*
*
*	assignment notes:  You will be simulating an emergency room queue by writing a class called ERQueue.
*		The queue will enqueue on demand by menu-driven  user input and will dequeue based on the highest prioity patient in the queue.
*		ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
*/

using System;

namespace MedicalQueue_Team2
{
	public class ERQueue
	{
		private Node _head;
		private Node _current;
		private Patient _patient;
		// Simple method to check and see if there is another element in the list.
		public bool Peek()
		{
			return _head != null;
		}
		// Now this was only to test my Dequeue method. Now what we could do to improve this is looking at the priority value and then inserting that node.
		// That way the highest priority is pulled first. Any thoughts? - Jordan
		// Sam & Andrea:  Same is working on the priority in Enqueue / Dequeue
		public int Enqueue(Patient p)
		{
			// SAM'S CODE
			Node newNode = new Node(p);
			//Patient newNode = new Patient();
			int nodeCount = 0; // Will carry number of nodes which will be returned at the end
			// If no nodes, set the added node as the _head
			if (_head == null)
			{
				_head = newNode;
				return 1; // In this case there is only one node
			}
			else
			{
				// If the new node has a higher priority than the head (lower number), set it as the head and set its _next to the old head
				if (p.getPriority() < _head.grabData.getPriority())
				{
					newNode.Next = _head;
					_head = newNode;
				}
				// Otherwise assume there is a _head and that the new node belongs behind it
				else
				{
					_current = _head;
					// Check each node
					while ( _current != null )
					{
						// If there is more than one node, check the list to find the right spot
						if (_current.Next != null)
						{
							// Check this node to see if  it's the right place for the new node;
							// if the _current data has a higher or equal priority (less than or equal number)
							// and the node after it has a lower priority (higher number),
							// then insert the new node in this location
							if (_current.grabData.getPriority() <= p.getPriority() && _current.Next.grabData.getPriority() > p.getPriority())
							{
								newNode.Next = _current.Next; // Connect new node to rest of list
								_current.Next = newNode;      // Connect _current and any previous nodes to the new node and the rest of the list
								break;
							} else
							{
								_current = _current.Next; // Get next node in chain
							}
						}
						// Otherwise if no match is found, put the new node at the end of the list
						else
						{
							_current.Next = newNode;
							break;
						}
					}
				}
				// Now count the nodes
				_current = _head;
				while ( _current != null )
				{
					++nodeCount;
					if (_current.Next != null)
					{
						_current = _current.Next;
					} else
					{
						break;
					}
				}
				return nodeCount;
			}
		}
		// Dequeue works - Jordan
		public Patient Dequeue()
		{
			if(_head != null)
			{
				_patient = _head.grabData;
				_head = _head.Next;
				return _patient;
			} else {
				return null;
			}
		}

		public string List()
        {
			return ToString();
        }

		public override string ToString()
		{
			_current = _head;
			String strReturn = new string("No patients in queue.\n");
			if (_head == null) { return strReturn; };
			strReturn = _head.grabData.ToString();
			if (_head.Next == null) { return strReturn; };
			_current = _head.Next;
			while (_current != null)
			{
				strReturn = strReturn + "\n" + _current.grabData.ToString();
				_current = _current.Next;
			}
			return strReturn;
		}

		public void loadData()
		{
			// Loadup some data for testing
			fakeData fakeData = new fakeData(this);
		}
	}
}
