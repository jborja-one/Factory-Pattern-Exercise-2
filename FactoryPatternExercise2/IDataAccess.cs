using System;
namespace FactoryPatternExercise2
{
	public interface IDataAccess
	{
		public Product LoadData();
		public void SaveData();
	}
}

