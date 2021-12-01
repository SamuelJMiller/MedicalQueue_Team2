/* --
 * Assignment:
 *     Main will contain a menu to allow for the queuing, dequeuing and listing the queue by accessing methods of the ERQueue.
 *    Specifically, there should be at least three menu behaviors:
 *    Enqueue: returns number of patients in the queue after adding
 *    Dequeue: returns a queue item which should be shown to the user
 *    ListL Returns a list of users/priorities and their position in the queue
 *    ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
 *    
 *    AP:  Worked on Enqueue()

*/


using System;
using System.Collections;

namespace MedicalQueue_Team2
{
   class Program
   {

      // Not sure about protection level - going for the concept of least privledges

      private ERQueue ourEQ;
      private int currentCount;
      private Patient patient;

      static void Main(string[] args)
      {
         ourEQ = new ERQueue();
         //  Add some test patients -AP
         // (new Patient("Bob", "Villa", 3));
         // (new Patient("Sally", "Ride", 2));

      }

      public int Enqueue(Patient patient)
      {  //returns number of patients in the queue after adding


         ourEQ.Enqueue(patient, patient.getPriority());
         currentCount = this.ourEQ.Count;
         return this.currentCount;
      }

      //public Patient Dequeue()
      //{  // returns a queue item which should be shown to the user

         // return (ourEQ.Dequeue)
      //}

      //public List ListL()
      //{  // Returns a list of users/priorities and their position in the queue }

      public override string ToString()
      {  // ToString: Override ToString() to generate a string with the queue in order[  Sue 1] [Dan 2] [Mary 2] [Bob 4] [Jim 5]
         return base.ToString();
      }
   }
}
