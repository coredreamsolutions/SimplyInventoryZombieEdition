using SimplyInventoryTest.Model;
using SimplyInventoryTest.Validators;

namespace SimplyInventoryTest.Validators
{
	public class MailValidator
	{
		public static CheckResult ValidateSave(Mail model)
		{
			CheckResult checkResult = new CheckResult();
			if (string.IsNullOrWhiteSpace(model.SMTPHostname))
			{
				checkResult.AddError("You need to enter a valid smtp hostname.", "SMTPHostname");
			}
			if (model.SMTPPortNumber == 0L)
			{
				checkResult.AddError("You need to enter the port # (normally 587).", "SMTPPortNumber");
			}
			if (string.IsNullOrWhiteSpace(model.SMTPUsername))
			{
				checkResult.AddError("You need to specify the username (normally your e-mail address).", "SMTPUsername");
			}
			if (string.IsNullOrWhiteSpace(model.SMTPUsername))
			{
				checkResult.AddError("You need to specify the password of your username.", "SMTPUsername");
			}
			if (string.IsNullOrWhiteSpace(model.SenderName))
			{
				checkResult.AddError("You need to specify what the default From address is.", "SenderName");
			}
			if (string.IsNullOrWhiteSpace(model.AddressTo))
			{
				checkResult.AddError("You need to specify what the default To address is.", "AddressTo");
			}
			if (string.IsNullOrWhiteSpace(model.DefaultSubject))
			{
				checkResult.AddError("You need to specify what the default subject will be.", "DefaultSubject");
			}
			if (string.IsNullOrWhiteSpace(model.DefaultMessage))
			{
				checkResult.AddError("You need to specify what the default message will be.", "DefaultMessage");
			}
			return checkResult;
		}

		public static CheckResult ValidateDelete(Mail model)
		{
			return CheckResult.Default;
		}
	}
}
