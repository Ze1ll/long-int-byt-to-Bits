using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_int_byt_to_Bits
{
	internal class Device : IControllable
	{
		public bool IsConnected { get; set; }
		public void On()
		{
			IsConnected = true;
			Console.WriteLine("Divace is ON");
		}

		public void Off()
		{
			IsConnected = false;
			Console.WriteLine("Divace is Off");
		}
	}
}
