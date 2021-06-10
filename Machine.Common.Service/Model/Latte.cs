using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.Common.Model
{
		public class Latte : Drink
		{
				public Latte(int milkUnits, int numberOfBeans)
				{
						MilkUnits = milkUnits;
						NumberOfBeans = numberOfBeans;
				}
		}
}
