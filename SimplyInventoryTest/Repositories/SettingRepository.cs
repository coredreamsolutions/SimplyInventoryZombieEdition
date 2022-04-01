using Dapper;
using SimplyInventoryTest.Core;
using SimplyInventoryTest.Model;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace SimplyInventoryTest.Repositories
{
    internal class SettingRepository
    {
		public static Setting GetSettings()
		{
			Setting result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				Setting setting = connection.Query<Setting>(
					@"SELECT * FROM Settings;", null, null, true, null, null).FirstOrDefault<Setting>();
				result = setting;
			}
			return result;
		}

		public static void UpdateSettings(Setting setting, IDbTransaction trans = null)
		{
			using (SQLiteConnection connection = Database.GetConnection())
			{
				string sqlQuery = @"UPDATE Settings 
                                       SET ShowStoreLogo = @ShowStoreLogo
					                 WHERE SettingsID = @SettingsID;";
				connection.Execute(sqlQuery, setting, null, null, null);
			}
		}
	}
}
