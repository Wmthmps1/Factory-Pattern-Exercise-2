using System;
namespace FactoryPatternExercise2
{
	public static class DataAccessFactory
	{
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "mongo":
                    return new MongoDataAccess();

                default:
                    return new SQLDataAccess();
            }
        }

    }
}

/*
 * This shall be a public static class
There will be one method with the following signature: 				public static IDataAccess GetDataAccessType(string databaseType)
Switch on the databaseType variable
If a user types in list this should return a new instance of the ListDataAccess
If a user types in sql this should return a new instance of the SQLDataAccess
If a user types in mongo this should return a new instance of the MongoDataAccess
*/