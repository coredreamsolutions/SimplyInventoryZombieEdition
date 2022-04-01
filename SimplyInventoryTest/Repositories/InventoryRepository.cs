using Dapper;
using SimplyInventoryTest.Core;
using SimplyInventoryTest.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;

namespace SimplyInventoryTest.Repositories
{
    public class InventoryRepository
    {

		public static List<Inventory> SearchInventory(string searchData)
		{	
			string sqlQuery = "SELECT * FROM Inventory WHERE InventoryID != 0 ";

			if (!string.IsNullOrWhiteSpace(searchData))
            {
				sqlQuery += @" AND CategoryName LIKE @CategoryName AND DescriptionName LIKE @DescriptionName;";
				searchData = "%" + searchData + "%";
			}

			List<Inventory> result;
			Debug.Print(sqlQuery);

			using (SQLiteConnection connection = Database.GetConnection())
			{
				//result = connection.Query<Inventory>(sqlQuery, null, null, true, null, null).ToList<Inventory>();
				result = connection.Query<Inventory>(sqlQuery, new
				{
					CategoryName = searchData,
					DescriptionName = searchData
				}, null, true, null, null).ToList<Inventory>();
			}
			return result;	
		}
		/*public static List<Inventory> SearchInventory(string category = null, string description = null)
		{
			string text = "SELECT * FROM Inventory WHERE InventoryID != 0 ";

			if (!string.IsNullOrWhiteSpace(category))
			{
				text += " AND CategoryName LIKE @categoryName ";
				category = "%" + category + "%";
			}
			if (!string.IsNullOrWhiteSpace(description))
			{
				text += " AND DescriptionName LIKE @descriptionName ";
				description = "%" + description + "%";
			}

			List<Inventory> result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				result = connection.Query<Inventory>(text, new
				{
					categoryName = category,
					descriptionName = description
				}, null, true, null, null).ToList<Inventory>();
			}
			return result;
		}
*/
		public static List<Inventory> GetAllInventory()
		{
			List<Inventory> result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				result = connection.Query<Inventory>(
					@"SELECT * FROM Inventory ORDER BY CategoryName;", 
					null, null, true, null, null).ToList<Inventory>();
			}
			return result;
		}

		public static List<Inventory> GetAllInventoryByDescription()
		{
			List<Inventory> result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				result = connection.Query<Inventory>(
					@"SELECT * FROM Inventory ORDER BY DescriptionName;", 
					null, null, true, null, null).ToList<Inventory>();
			}
			return result;
		}

		public static void SaveItem(Inventory inventory, IDbTransaction trans = null)
		{
			using (SQLiteConnection connection = Database.GetConnection())
			{
				if (inventory.InventoryID == 0L)
				{
					inventory.InventoryID = connection.Query<long>(
						@"INSERT INTO Inventory (CategoryName, DescriptionName, QtyNeeded, QtyLeftOver)
						VALUES (@CategoryName, @DescriptionName, @QtyNeeded, @QtyLeftOver);
                        SELECT last_insert_rowid()", inventory, trans, true, null, null).FirstOrDefault<long>();
				}
				else
				{
					string sqlQuery = 
						@"UPDATE Inventory 
                             SET CategoryName = @CategoryName, 
                                 DescriptionName = @DescriptionName, 
                                 QtyNeeded = @QtyNeeded, 
							     QtyLeftOver = @QtyLeftOver
                           WHERE InvID = @InventoryID;";
					connection.Execute(sqlQuery, inventory, trans, null, null);
				}
			}
		}
	}
}
