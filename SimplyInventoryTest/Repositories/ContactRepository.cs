using Dapper;
using SimplyInventoryTest.Core;
using SimplyInventoryTest.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace SimplyInventoryTest.Repositories
{
    internal class ContactRepository
    {
		public static List<Contact> GetContacts()
		{
			List<Contact> result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				result = connection.Query<Contact>("SELECT * FROM Contacts;", null, null, true, null, null).ToList<Contact>();
			}
			return result;
		}

		public static Contact GetContactsById()
		{
			Contact result;
			using (SQLiteConnection connection = Database.GetConnection())
			{
				Contact contact = connection.Query<Contact>("SELECT * FROM Contacts;", null, null, true, null, null).FirstOrDefault<Contact>();
				result = contact;
			}
			return result;
		}

		public static void SaveContact(Contact contact, IDbTransaction trans = null)
		{
			using (SQLiteConnection connection = Database.GetConnection())
			{
				if (contact.ContactID == 0L)
				{
					contact.ContactID = connection.Query<long>(
						@"INSERT INTO Contacts (ContactName, ContactEMail)
                               VALUES (@ContactName, @ContactEMail); 
                               SELECT last_insert_rowid()", 
						contact, trans, true, null, null).FirstOrDefault<long>();
				}
				else
				{
					string sql = @"UPDATE Contacts 
                                      SET ContactName = @ContactName, ContactEMail = @ContactEMail
								    WHERE ContactID = @ContactID;";
					connection.Execute(sql, contact, null, null, null);
				}
			}
		}
	}
}
