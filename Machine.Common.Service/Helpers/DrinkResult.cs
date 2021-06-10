using Machine.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.Common.Helpers
{
		public class DrinkResult
		{
				public MachineValidationResult IsMachineCapable { get; set; }
				public Drink Drink { get; set; }

				public DrinkResult()
				{
						IsMachineCapable = new MachineValidationResult();
				}

		}
}
