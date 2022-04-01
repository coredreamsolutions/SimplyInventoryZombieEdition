using System.Collections.Generic;
using System.Linq;

namespace SimplyInventoryTest.Validators
{
    public class CheckResult
    {
		public bool Failed
		{
			get { return Items.Any((CheckItem i) => i.IsError);	}
		}
		public List<CheckItem> Items { get; set; }

		public CheckResult()
		{
			Items = new List<CheckItem>();
		}

		public void AddError(string message, string property)
		{
			Items.Add(new CheckItem(true, message, property));
		}

		public void AddWarning(string message, string property)
		{
			Items.Add(new CheckItem(false, message, property));
		}

		public static readonly CheckResult Default = new CheckResult();
	}
}
