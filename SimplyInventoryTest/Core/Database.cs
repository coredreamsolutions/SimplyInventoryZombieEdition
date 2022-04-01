using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace SimplyInventoryTest.Core
{ 

	public class Database
	{
		private static string _ConnectionString;

		public static string ConnectionString
		{
			get
			{
				if (_ConnectionString == null)
				{
					_ConnectionString = "Data Source=" +
						Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.db3");
				}
				return _ConnectionString;
			}
		}

		public static SQLiteConnection GetConnection()
		{
			return new SQLiteConnection(ConnectionString);
		}

		public static DataTable Select(string sql, params SQLiteParameter[] param)
		{
			DataTable result;
			using (SQLiteConnection connection = GetConnection())
			{
				using (SQLiteCommand sqliteCommand = new SQLiteCommand(sql, connection))
				{
					using (SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(sqliteCommand))
					{
						sqliteCommand.Parameters.AddRange(param);
						connection.Open();
						DataTable dataTable = new DataTable("data");
						sqliteDataAdapter.Fill(dataTable);
						result = dataTable;
					}
				}
			}
			return result;
		}

		public static DataSet SelectTwo(string sql, params SQLiteParameter[] param)
		{
			DataSet result;
			using (SQLiteConnection connection = GetConnection())
			{
				using (SQLiteCommand sqliteCommand = new SQLiteCommand(sql, connection))
				{
					using (SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(sqliteCommand))
					{
						sqliteCommand.Parameters.AddRange(param);
						connection.Open();
						DataSet dataSet = new DataSet("data");
						sqliteDataAdapter.Fill(dataSet);
						result = dataSet;
					}
				}
			}
			return result;
		}
	}
}
