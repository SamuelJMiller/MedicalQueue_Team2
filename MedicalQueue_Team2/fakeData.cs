/*
 *  MedicalQueue_Team2
 *  ERQueue - Test Data
*/
namespace MedicalQueue_Team2
{
	class fakeData
	{
		public fakeData(ERQueue ourEQ)
		{
			ourEQ.Enqueue(new Patient("Mary", "Jane", 4));
			ourEQ.Enqueue(new Patient("Joe", "Camel", 1));
			ourEQ.Enqueue(new Patient("Jordan", "Martin", 5));
			ourEQ.Enqueue(new Patient("Andrea", "Powell", 3));
		}
	}
}
