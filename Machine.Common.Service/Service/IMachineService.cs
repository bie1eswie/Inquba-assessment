using Machine.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.Common.Service
{
		public interface IMachineService
		{
				DrinkResult MakeCappuccino(int amountOfSugar);
				DrinkResult MakeLatte();
				DrinkResult MakeCoffee(bool withMilk);
		}
}
