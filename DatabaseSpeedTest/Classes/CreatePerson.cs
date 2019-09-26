using DatabaseSpeedTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DatabaseSpeedTest.Classes
{
    public class CreatePerson : IPersonCreate
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=db.mdb;");
        OleDbDataReader dr;
        OleDbCommand cmd;
        Random r = new Random();

        public List<Person> List(int PersonLength)
        {
            List<Person> createdPersons = new List<Person>();
            Console.WriteLine("Persons Started Creating...");

            for (int i = 1; i <= PersonLength; i++)
            {
                createdPersons.Add(Create());
                Console.Title = "Creating Person: " + i;
            }
            Console.WriteLine("Persons Creation Finished!");

            return createdPersons;
        }
        public Person Create()
        {
            Person person = new Person() {
                Name = Name(),
                SurName = SurName(),
                Gender=Gender(),
                PersonNumber=Convert.ToInt64(Number())
            };
            return person;
        }
        public string Number()
        {
            string number = "";
            for (int a = 0; a < 13; a++)
            {
                number += r.Next(0, 9).ToString();
            }
            return number;
        }
        public string Name()
        {
            string name = "";
            con.Open();
            cmd = new OleDbCommand("Select * From Adlar where Kimlik=" + r.Next(0, 9699), con);
            dr = cmd.ExecuteReader();
            if (dr.Read()) name = dr["Alan2"].ToString();
            con.Close();
            return name;
        }
        public string SurName()
        {
            string surname = "";
            con.Open();
            cmd = new OleDbCommand("Select * From Soyisimler where Kimlik=" + r.Next(0, 2446), con);
            dr = cmd.ExecuteReader();
            if (dr.Read()) surname = dr["Alan1"].ToString();
            con.Close();
            return surname;
        }
        public Genders Gender()
        {
            Genders gender;
            if (r.Next(0, 2) == 0)
                gender = Genders.Male;
            else
                gender = Genders.Female;
            return gender;
        }
    }
}
