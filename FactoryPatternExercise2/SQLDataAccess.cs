using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
        public Product LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data");
            return new Product();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the SQL Database");
        }
    }
}

