using System;

namespace DatabaseSpeedTest.Classes
{
    public class Person : IPerson
    {
        public Int64 PersonNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public Genders Gender { get; set; }
    }
}
