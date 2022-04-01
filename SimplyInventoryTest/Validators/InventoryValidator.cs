using SimplyInventoryTest.Model;

namespace SimplyInventoryTest.Validators
{
    public class InventoryValidator
    {
		public static CheckResult ValidateSave(Inventory model)
		{
			CheckResult checkResult = new CheckResult();
			if (string.IsNullOrWhiteSpace(model.CategoryName))
			{
				checkResult.AddError("You need to enter a Category Name (e.g. Display Goods).", "CategoryName");
			}
			if (string.IsNullOrWhiteSpace(model.DescriptionName))
			{
				checkResult.AddError("You need to enter item's description.", "DescriptionName");
			}
			if (model.QtyNeeded == 0L)
			{
				checkResult.AddError("You need to specify how many you need. (Default is 0)", "QtyNeeded");
			}
			if (model.QtyLeftOver == 0L)
			{
				checkResult.AddError("You need to specify how many you have left. (Default is 0)", "QtyLeftOver");
			}
			return checkResult;
		}

		public static CheckResult ValidateDelete(Inventory inv)
		{
			return CheckResult.Default;
		}
	}
}
