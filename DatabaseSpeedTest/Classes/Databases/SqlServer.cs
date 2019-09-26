using DatabaseSpeedTest.Interfaces;
using System.Data.SqlClient;

namespace DatabaseSpeedTest.Classes.Databases
{
    public class SqlServer : IDatabase
    {
        SqlConnection con = new SqlConnection("Server=OZAN;Database=SpeedTest;Trusted_Connection=True;");
        SqlCommand cmd;
        public bool Add(Person person)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert Into Persons(PersonNumber, Name, Surname, Gender) Values (@number, @name, @surname, @gender)", con);
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
