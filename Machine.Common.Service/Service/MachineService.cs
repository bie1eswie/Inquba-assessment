using Machine.Common.Helpers;
using Machine.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.Common.Service
{
		public class MachineService : IMachineService
		{
				public int MaximumBeansCapacity { get; set; }
				public int MaximumMilkCapacity { get; set; }

				private static int LOW_BEAN_THRESHOLD = 5;

				public MachineService(int maximumBeansCapacity, int maximumMilkCapacity)
				{
						MaximumBeansCapacity = maximumBeansCapacity;
						MaximumMilkCapacity = maximumMilkCapacity;
				}

				private MachineValidationResult ValidateMachineCapacity(int milkUnits, int numberOfBeans)
				{
						var result = new MachineValidationResult();
						if (MaximumMilkCapacity < milkUnits)
						{
								result.Message += "The machines maximum bean capacity is less than the required amount to make the drink " + Environment.NewLine;
								result.Result = false;
								return result;
						}
						if (MaximumBeansCapacity < numberOfBeans)
						{
								result.Message += "The maximum milk capacity is less than the required amount to make the drink ";
								result.Result = false;
								return result;
						}
						return result;
				}
				private void ManageIngridents(int milkUnits, int numberOfBeans)
				{
								MaximumBeansCapacity -= numberOfBeans;
								MaximumMilkCapacity -= milkUnits;
				}
				public DrinkResult MakeLatte()
				{
						int milkUnits = 2;
						int numberOfBeans = 3;
						DrinkResult drinkResult = new DrinkResult();
						var isMachineCapable = ValidateMachineCapacity(milkUnits, numberOfBeans);
						if (isMachineCapable.Result)
						{
								ManageIngridents(milkUnits, numberOfBeans);
								drinkResult.Drink = new Latte(milkUnits, numberOfBeans);
						}
						else
						{
								drinkResult.IsMachineCapable = isMachineCapable;
						}
						return drinkResult;
				}
				public DrinkResult MakeCappuccino(int amountOfSugar)
				{
						int milkUnits = 3;
						int numberOfBeans = 5;
						DrinkResult drinkResult = new DrinkResult();
						var isMachineCapable = new MachineValidationResult();
						//validate the required anount of sugar
						if (amountOfSugar < 0)
						{
								isMachineCapable.Message = "Amount of sugar is required and it cant be less than 0";
								isMachineCapable.Result = false;
								drinkResult.Drink = null;
								drinkResult.IsMachineCapable = isMachineCapable;
								return drinkResult;
						}
						isMachineCapable = ValidateMachineCapacity(milkUnits, numberOfBeans);
						if (isMachineCapable.Result)
						{
								ManageIngridents(milkUnits, numberOfBeans);
								drinkResult.Drink = new Cappuccino(milkUnits, numberOfBeans, amountOfSugar);
						}
						else
						{
								drinkResult.IsMachineCapable = isMachineCapable;
						}
						return drinkResult;
				}
				public DrinkResult MakeCoffee(bool withMilk)
				{
						int milkUnits = 0;
						int numberOfBeans = 2;
						if (withMilk)
						{
								milkUnits = 1;
						}
						DrinkResult drinkResult = new DrinkResult();
						var isMachineCapable = ValidateMachineCapacity(milkUnits, numberOfBeans);
						if (isMachineCapable.Result)
						{
								ManageIngridents(milkUnits, numberOfBeans);
								drinkResult.Drink = new Coffee(milkUnits, numberOfBeans);
						}
						else
						{
								drinkResult.IsMachineCapable = isMachineCapable;
						}
						return drinkResult;
				}
				public bool CheckBeanCapacity()
				{
						return (MaximumBeansCapacity < LOW_BEAN_THRESHOLD);
				}
		}
}
