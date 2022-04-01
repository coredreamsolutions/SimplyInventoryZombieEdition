using SimplyInventoryTest.Model;

namespace SimplyInventoryTest.Validators
{
    public class ContactValidator
    {
		public static CheckResult ValidateSave(Contact model)
		{
			CheckResult checkResult = new CheckResult();

			if (string.IsNullOrWhiteSpace(model.ContactName))
			{
				checkResult.AddError("You need to enter a name.", "ContactName");
			}

			if (string.IsNullOrWhiteSpace(model.ContactEMail))
			{
				checkResult.AddError("You need to enter a e-mail address.", "ContactEMail");
			}

			return checkResult;
		}

		public static CheckResult ValidateDelete(Contact model)
		{
			return CheckResult.Default;
		}
	}
}
