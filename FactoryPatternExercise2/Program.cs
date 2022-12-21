namespace FactoryPatternExercise2
{
    public class Program
    {
        public static object MyPrice { get; private set; }
        public static object MyName { get; private set; }

        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();


            foreach (var item in products)
            {
                Console.WriteLine($"Name:  {item.Name}  Price: {item.Price}");
            }
            
            

        }
    }
}
