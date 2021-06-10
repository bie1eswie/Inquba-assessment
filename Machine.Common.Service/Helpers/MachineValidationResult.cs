using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.Common.Helpers
{
		public class MachineValidationResult
		{
				public bool Result { get; set; }
				public string Message { get; set; }

				public MachineValidationResult()
				{
						Result = true;
				}
		}
}
