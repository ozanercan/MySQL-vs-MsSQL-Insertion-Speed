using DatabaseSpeedTest.Interfaces;
using MySql.Data.MySqlClient;

namespace DatabaseSpeedTest.Classes.Databases
{
    public class MySQL : IDatabase
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=speedtest;Uid=root;Pwd=;");
        MySqlCommand cmd;
        public bool Add(Person person)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand("Insert Into Persons(PersonNumber, Name, Surname, Gender) Values (@number, @name, @surname, @gender)", con);
                cmd.Parameters.AddWithValue("@number", person.PersonNumber);
                cmd.Parameters.AddWithValue("@name", person.Name);
                cmd.Parameters.AddWithValue("@surname", person.SurName);
                cmd.Parameters.AddWithValue("@gender", person.Gender.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (System.Exception error)
            {
                System.Console.WriteLine(error.Message);
                return false;
            }
        }
    }
}
