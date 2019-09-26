using DatabaseSpeedTest.Classes;
using System.Collections.Generic;

namespace DatabaseSpeedTest.Interfaces
{
    interface IPersonCreate
    {
        List<Person> List(int PersonLength);
        Person Create();
        string Number();
        string Name();
        string SurName();
        Genders Gender();
    }
}
