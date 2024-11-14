namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?");
            string userResponse = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccess(userResponse);
            data.LoadData();
            Thread.Sleep(1000);
            data.SaveData();
        }
    }
}
