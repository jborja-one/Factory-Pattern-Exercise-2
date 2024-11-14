using System;
namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
        public Product LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data");
            return new Product();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the Mongo Database");
        }
    }
}

