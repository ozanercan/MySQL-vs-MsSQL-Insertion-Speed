using DatabaseSpeedTest.Classes;
using DatabaseSpeedTest.Interfaces;

namespace DatabaseSpeedTest.Interfaces.DataAccessLayer
{
    interface IDal
    {
        void Add(IDatabase databaseType, Person person);
    }
}
