using DatabaseSpeedTest.Interfaces;
using DatabaseSpeedTest.Interfaces.DataAccessLayer;

namespace DatabaseSpeedTest.Classes
{
    public class Process : IDal
    {
        public void Add(IDatabase databaseType, Person person)
        {
            databaseType.Add(person);
        }
    }
}
