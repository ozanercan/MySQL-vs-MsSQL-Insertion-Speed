using DatabaseSpeedTest.Classes;
using DatabaseSpeedTest.Classes.Databases;

namespace DatabaseSpeedTest.Interfaces
{
    public interface IDatabase
    {
        bool Add(Person person);
    }
}
