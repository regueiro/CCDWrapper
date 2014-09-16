using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiMonitorHelper;
using MultiMonitorHelper.Common.Enum;

namespace Tests
{
	[TestClass]
	public class DisplayModelTests
	{
		[TestMethod]
		public void TestRotation()
		{
			var displayModel = DisplayFactory.GetDisplayModel();

			var primary = displayModel.GetActiveDisplays().First(x => x.Settings.IsPrimary);
			var currentOrientation = primary.Settings.Rotation;

			primary.Rotate(DisplayRotation.Rotated180);
			Assert.AreEqual(primary.Settings.Rotation, DisplayRotation.Rotated180);

			primary.Rotate(currentOrientation);
			Assert.AreEqual(primary.Settings.Rotation, currentOrientation);
		}

		[TestMethod]
		public void TestIfPrimaryMonitorExists()
		{
			var displayModel = DisplayFactory.GetDisplayModel();
			var primary = displayModel.GetActiveDisplays().FirstOrDefault(x => x.Settings.IsPrimary);

			Assert.AreNotEqual(primary, null);
		}
	}
}
