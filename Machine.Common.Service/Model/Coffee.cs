using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.Common.Model
{
		public class Coffee : Drink
		{
				public Coffee(int milkUnits, int numberOfBeans)
				{
						MilkUnits = milkUnits;
						NumberOfBeans = numberOfBeans;
				}
		}
}
