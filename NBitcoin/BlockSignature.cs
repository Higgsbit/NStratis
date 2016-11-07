﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin.DataEncoders;

namespace NBitcoin
{
	/// <summary>
	/// A representation of a block signature.
	/// </summary>
	public class BlockSignature : IBitcoinSerializable
	{
		public BlockSignature()
		{

		}

		private byte[] signature;

		public byte[] Signature
		{
			get
			{
				return signature;
			}
			set
			{
				signature = value;
			}
		}

		internal void SetNull()
		{
			signature = new byte[0];
		}

		public static bool operator ==(BlockSignature a, BlockSignature b)
		{
			if (System.Object.ReferenceEquals(a, b))
				return true;

			if (((object)a == null) || ((object)b == null))
				return false;

			return a.signature.SequenceEqual(b.signature);
		}

		public static bool operator !=(BlockSignature a, BlockSignature b)
		{
			return !(a == b);
		}

		#region IBitcoinSerializable Members

		public void ReadWrite(BitcoinStream stream)
		{
			stream.ReadWriteAsVarString(ref signature);
		}

		public override string ToString()
		{
			return Encoders.Hex.EncodeData(this.signature);
		}

		#endregion
	}
}