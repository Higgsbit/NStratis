﻿namespace nStratis.BouncyCastle.math.ec.endo
{
	internal interface GlvEndomorphism
		: ECEndomorphism
	{
		BigInteger[] DecomposeScalar(BigInteger k);
	}
}
