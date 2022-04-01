using Dapper;
using SimplyInventoryTest.Core;
using SimplyInventoryTest.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace SimplyInventoryTest.Repositories
{
    public class MailRepository
    {
		public static List<Mail> GetSettings()
		{
			List<Mail> result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				result = connection.Query<Mail>(
					@"SELECT * FROM Mail;", null, null, true, null, null).ToList<Mail>();
			}
			return result;
		}

		public static Mail GetEnabledMailSetting()
		{
			Mail result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				Mail mail = connection.Query<Mail>(
					@"SELECT * FROM Mail;", null, null, true, null, null).FirstOrDefault<Mail>();
				result = mail;
			}
			return result;
		}
		public static long CountRows()
		{
			long result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				result = connection.Query<long>(
					@"SELECT COUNT(*) FROM Mail;", null, null, true, null, null).FirstOrDefault<long>();
			}
			return result;
		}

		public static void SaveMail(Mail mail, IDbTransaction trans = null)
		{
			using (SQLiteConnection connection = Database.GetConnection())
			{
				if (mail.MailID == 0L)
				{
					mail.MailID = connection.Query<long>(
						@"INSERT INTO Mail (SMTPHostname, SMTPPortNumber, SMTPUsername, SMTPPassword, SenderName, AddressTo, DefaultSubject, DefaultMessage) 
                          VALUES (@SMTPHostname, @SMTPPortNumber, @SMTPUsername, @SMTPPassword, @SenderName, @AddressTo, @DefaultSubject, @DefaultMessage);
						  SELECT last_insert_rowid()",
						  mail, trans, true, null, null).FirstOrDefault<long>();
				}
				else
				{
					string sqlQuery = 
						@"UPDATE Mail 
                             SET SMTPHostname = @SMTPHostname, 
                                 SMTPPortNumber = @SMTPPortNumber, 
                                 SMTPUsername = @SMTPUsername,                 
                                 SMTPPassword = @SMTPPassword,
                                 SenderName = @SenderName,
                                 AddressTo = @AddressTo,              
                                 DefaultSubject = @DefaultSubject,
                                 DefaultMessage = @DefaultMessage
                           WHERE MailID = @MailID;";
					connection.Execute(sqlQuery, mail, null, null, null);
				}
			}
		}
	}
}
