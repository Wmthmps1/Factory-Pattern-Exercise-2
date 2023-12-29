using System;
using System.Collections.Generic;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
		{
		}
		
        public List<Product> LoadData()
		{
			Console.WriteLine($"I am reading data from a list");
			return new List<Product>();
		}

        public void SaveData()
		{
			Console.WriteLine($"I am saving data to a list");
		}
    }
}

/*
 * 
 * LoadData(): Just print to the console “I am reading data from {whatever type class this is, i.e: list, SQL database, mongo database}”
and then return a new list of Product.
SaveData(): Print “I am saving data from a {whatever type} database” to the console
 */