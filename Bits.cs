using long_int_byt_to_Bits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Bits : IBitGetTable
{
public byte Value { get; set; }
	public Bits(byte value)
	{
		Value = value;
	}

	public bool GetBitByIndex(byte index)
	{
		return (Value & (1 << index)) != 0;
	}

	public void SetBitByIndex(byte index, bool value)
	{
		if (value)
		{
			Value |= (byte)(1 << index);
		}
		else
		{
			Value &= (byte)(1 << index);
		}
	}

	public bool this [byte index]
	{
		get => GetBitByIndex(index);
		set => SetBitByIndex(index, value);
	}
	public static implicit operator byte(Bits bit) => bit.Value;
	public static explicit operator Bits(byte value) => new (value);
	public static implicit operator int (Bits bit) => bit.Value;
	public static implicit operator long (Bits bit) => bit.Value;
	
}
