using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public Product LoadData()
		{
			Console.WriteLine("I am reading data from List");
			return new Product();
		}

		public void SaveData()
		{
			Console.WriteLine("I am saving data from the List");
		}
	}
}

