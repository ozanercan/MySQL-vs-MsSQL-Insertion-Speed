using DatabaseSpeedTest.Classes;
using DatabaseSpeedTest.Classes.Databases;
using System;
using System.Collections.Generic;

namespace DatabaseSpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();

            CreatePerson createPerson = new CreatePerson();

            List<Person> createdPersons = createPerson.List(500);


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Persons Started SQL Server Database Saving!");
            DateTime startTime = DateTime.Now;
            foreach(Person item in createdPersons)
            {
                process.Add(new SqlServer(), item);
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Persons SQL Server Database Saving Finished!");
            TimeSpan differenceTime = endTime - startTime;
            Console.WriteLine($"{ differenceTime.TotalSeconds } Seconds");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine($"Persons Started MySQL Database Saving! { startTime }");
            startTime = DateTime.Now;
            foreach (Person item in createdPersons)
            {
                process.Add(new MySQL(), item);
            }
            endTime = DateTime.Now;
            Console.WriteLine($"Persons MySQL Database Saving Finished! { DateTime.Now }");
            differenceTime = endTime - startTime;
            Console.WriteLine($"{ differenceTime.TotalSeconds } Seconds");

            Console.ReadKey();
        }
    }
}
