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
    }
}
