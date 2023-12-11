using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_int_byt_to_Bits
{
	 interface IBitGetTable
	{
		bool GetBitByIndex(byte index);
		void SetBitByIndex(byte index, bool value);
	}
}
