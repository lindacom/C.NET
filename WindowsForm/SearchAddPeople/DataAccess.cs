using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace FormUI
{
    class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            //connection to sql database
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("mySampleDb")))
            {
                // query databae with lastname parameter match and return as a list Person
                return connection.Query<Person>($"select * from People where LastName = '{lastName}'").ToList();
            }
        }
        
         internal void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("mySampleDb")))
            {
                List<Person> people = new List<Person>();

                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
           
                // add new people to database using stored procedure passing in the people parameter
            connection.Execute("dbo.mystoredprocedure @FirstName, @LastName, @EmailAddress, @PhoneNumber", people)
            }

        }
    }
}
