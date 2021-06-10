using Machine.Common.Service;
using NUnit.Framework;

namespace MachineServiceTest
{
		public class Tests
		{
				[SetUp]
				public void Setup()
				{
				}

				[Test]
				public void MakeLatteTest()
				{
						MachineService machineService = new MachineService(20,25);
						var drinkResult = machineService.MakeLatte();
						Assert.IsTrue(drinkResult.IsMachineCapable.Result);
						Assert.IsNotNull(drinkResult.Drink, "A drink can not be empty");
				}

				[Test]
				public void MakeCappuccinoTest()
				{
						MachineService machineService = new MachineService(20, 25);
						var drinkResult = machineService.MakeCappuccino(-1);
						Assert.IsTrue(drinkResult.IsMachineCapable.Result);
						Assert.IsNotNull(drinkResult.Drink, "A drink can not be empty");
				}
				[Test]
				public void MakeCoffeeTest()
				{
						MachineService machineService = new MachineService(20, 25);
						var drinkResult = machineService.MakeCoffee(true);
						Assert.IsTrue(drinkResult.IsMachineCapable.Result);
						Assert.IsNotNull(drinkResult.Drink, "A drink can not be empty");
				}
		}
}