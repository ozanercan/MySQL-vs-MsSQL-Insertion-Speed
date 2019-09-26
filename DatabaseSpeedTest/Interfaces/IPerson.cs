using DatabaseSpeedTest.Classes;
using System;

namespace DatabaseSpeedTest
{
    interface IPerson
    {
        Int64 PersonNumber { get; set; }
        string Name { get; set; }
        string SurName { get; set; }
        Genders Gender { get; set; }
    }
}
