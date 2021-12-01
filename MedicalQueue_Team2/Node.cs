using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Team2
{
   class Node
   {

        private Patient _data;
        private Node _next;

      public myNode(Patient p)
      {
            _data = p;
      }

      public Patient Next
        {
            get { return _next; }
            set { _next = value; }
        }

   }
}
