using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.Common.Model
{
		public class Cappuccino : Drink
		{
				public int AmountOfSugar { get; set; }

				public Cappuccino(int milkUnits, int numberOfBeans,int amountOfSugar)
				{
						MilkUnits = milkUnits;
						NumberOfBeans = numberOfBeans;
						AmountOfSugar = amountOfSugar;
				}
		}
}
