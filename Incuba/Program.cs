using Machine.Common.Helpers;
using Machine.Common.Service;
using System;

namespace Incuba
{
		class Program
		{
				private static int Maximum_Beans_Capacity = 25;
				private static int Maximum_Milk_Capacity = 20;

				static void Main(string[] args)
				{
						//
						MachineService machine = new MachineService(Maximum_Beans_Capacity, Maximum_Milk_Capacity);

						while (true)
						{
								DrinkResult drinkResult =new DrinkResult();
								Console.ForegroundColor = ConsoleColor.White;
								Console.Clear();
								if (machine.CheckBeanCapacity())
								{
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine("Warning!! Please make sure to re-fill beans in the machine:\r\n");
										Console.ForegroundColor = ConsoleColor.White;
								}
								Console.WriteLine("Choose a drink option below:");
								Console.WriteLine("1) Coffee");
								Console.WriteLine("2) Cappuccino");
								Console.WriteLine("3) Latte");
								Console.WriteLine("off) Exit");
								Console.Write("\r\nSelect an option: ");
								
								Console.WriteLine($"\r\nMaximum Beans Capacity: {machine.MaximumBeansCapacity}");
								Console.WriteLine($"Maximum Milk Capacity: {machine.MaximumMilkCapacity}");

								//machine.CheckBeanCapacity();

								string input = Console.ReadLine();

								switch (input)
								{
										case "1":
												Console.WriteLine("Whould you like some milk with your coffee:" +
																					 Environment.NewLine + "(Y/N)");
												string s_coffeeMilkOption = Console.ReadLine();
												bool withMilk = false;
												while (!ToBool(s_coffeeMilkOption, out withMilk))
												{
														Console.WriteLine("Please enter a correct value for your milk option:" +
														Environment.NewLine + "(Y/N)");
														s_coffeeMilkOption = Console.ReadLine();
												}
												drinkResult = machine.MakeCoffee(withMilk);
												break;
										case "2":
												int amountOfSugar = 0;
												Console.WriteLine("Please input the anount of sugar:");
												string s_AmountOfSugar = Console.ReadLine();
												while (!Int32.TryParse(s_AmountOfSugar, out amountOfSugar) || amountOfSugar < 0)
												{
														Console.WriteLine("Not a valid number, try again.");
														s_AmountOfSugar = Console.ReadLine();
												}
												drinkResult = machine.MakeCappuccino(amountOfSugar);
												break;
										case "3":
												drinkResult = machine.MakeLatte();
												break;
										case "off":
												Environment.Exit(0);
												break;
								}
								ValidateDrinkResult(drinkResult);
						}
				}

				public static bool ToBool(string input,out bool value)
				{
						bool result = false;
						// input will never be null, as you cannot call a method on a null object
						if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
						{
								value = true;
								result = true;
						}
						else if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
						{
								value = false;
								result = false;
						}
						else
						{
								value = false;
								result = false;
						}
						return result;
				}

				public static void ValidateDrinkResult(DrinkResult drinkResult)
				{
						if (!drinkResult.IsMachineCapable.Result)
						{
								Console.WriteLine(drinkResult.IsMachineCapable.Message);
								Console.ReadLine();
						}
				}
		}
}
