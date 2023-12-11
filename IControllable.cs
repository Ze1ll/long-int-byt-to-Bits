using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_int_byt_to_Bits
{
	internal interface IControllable
	{
		bool IsConnected { get; }
		void On();
		void Off();
	}
}
