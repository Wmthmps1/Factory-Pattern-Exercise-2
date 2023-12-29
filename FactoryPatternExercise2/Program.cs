namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which type of database would you like to access?");
            Console.WriteLine("Choose between List, Mongo, or SQL.");
            string databaseType = Console.ReadLine();

            while (databaseType.ToLower() != "list" && databaseType.ToLower() != "mongo" && databaseType.ToLower() != "sql")
            {
                Console.WriteLine("Invalid Entry.");
                Console.WriteLine("Please choose between List, Mongo, and SQL.");
                databaseType = Console.ReadLine();
            }

            IDataAccess userChoice = DataAccessFactory.GetDataAccessType(databaseType);
            userChoice.LoadData();
            userChoice.SaveData();
        }
    }
}

/*
 * 
In one solution, you will need to create some new types.
X-A class called Product with 2 properties, Name and Price
X-An interface called IDataAccess with 2 methods, LoadData() and SaveData()
X-3 classes that implement the interface and its members (the methods), ListDataAccess, SQLDataAccess, and MongoDataAccess
X-Last you will need to create a class called DataAccessFactory


The 3 classes that implement your IDataAccess interface should provide implementations for the 2 methods 
X-LoadData(): Just print to the console “I am reading data from {whatever type class this is, i.e: list, SQL database, mongo database}”
    and then return a new list of Product.
-SaveData(): Print “I am saving data from a {whatever type} database” to the console


Once those 3 classes have the methods implemented, you will need to fill out your factory
This shall be a public static class
There will be one method with the following signature: 				public static IDataAccess GetDataAccessType(string databaseType)
Switch on the databaseType variable
If a user types in list this should return a new instance of the ListDataAccess
If a user types in sql this should return a new instance of the SQLDataAccess
If a user types in mongo this should return a new instance of the MongoDataAccess


Lastly in the Main()
Ask the user what database they want to use: a List, SQL, or Mongo
Store their response in a variable
Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
Call the LoadData and SaveData methods of the IDataAccess variable
Run the program a few times using the different types.
*/