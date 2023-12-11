using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_int_byt_to_Bits
{
	internal class Devices 
	{
		public List<IControllable> DevicesList { get; init; }
		public Devices()
		{
			DevicesList =
				[
					new Device(),
					new Device(),
					new Device(),
					new Device(),
					new Device(),
					new Device(),
					new Device(),
					new Device()
				];
				
				

		}

		public void Action (Bits bits)
		{
			for (byte i = 0; i < DevicesList.Count; i++)
			{
				if (bits[i])
					if (DevicesList[i].IsConnected && !bits[i])
						DevicesList[i].Off();
					else if (!DevicesList[i].IsConnected && bits[i])
						DevicesList[i].On();
				
				Console.WriteLine($"Devise {i} Is On");
			}
		}
	}
}
