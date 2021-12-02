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
			// SAM'S CODE

			Node newNode = new Node(p);
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
						if (_current.Next != null)
                        {
							// Check this node to see if  it's the right place for the new node;
							// if the _current data has a higher or equal priority (less than or equal number)
							// and the node after it has a lower priority (higher number),
							// then insert the new node in this location
							if (_current.grabData.getPriority() <= p.getPriority()
							 && _current.Next.grabData.getPriority() > p.getPriority())
							{
								newNode.Next = _current.Next; // Connect new node to rest of list
								_current.Next = newNode;      // Connect _current and any previous nodes to the new node and the rest of the list
								break;
							} else
                            {
								_current = _current.Next; // Get next node in chain
							}
                        }
						// Else put the new node at the end
						else
                        {
							_current.Next = newNode;
							break;
                        }
                    }
                }

				return nodeCount;
            }

			// JORDAN'S CODE

			//Node createNode = new Node(p);

			//if(_head == null)
   //         {
			//	_head = createNode;
			//	return 0;
			//}

			//_current = _head;

			//while (_current != null)
			//{
			//	if (_current.Next == null)
			//	{
			//		_current.Next = createNode;
			//		break;
			//	}
			//	else
			//	{
			//		_current = _current.Next;
			//	}
			//}
			//return 0;
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
