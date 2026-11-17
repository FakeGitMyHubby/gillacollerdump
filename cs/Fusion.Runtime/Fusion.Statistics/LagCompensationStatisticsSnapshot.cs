using System;
using System.Collections;

namespace Fusion.Statistics;

public class LagCompensationStatisticsSnapshot
{
	private int BVHMaxDeep__BackingField;

	private int BVHNodesCount__BackingField;

	private int HitboxesCount__BackingField;

	private double AddOnBufferTime__BackingField;

	private double AddOnBVHTime__BackingField;

	private double UpdateBVHTime__BackingField;

	private double UpdateBufferTime__BackingField;

	private double AdvanceBufferTime__BackingField;

	private double RefitBVHTime__BackingField;

	public double TotalElapsedTime
	{
		get
		{
			double num = AdvanceBufferTime__BackingField + AddOnBufferTime__BackingField;
			double num2 = num + AddOnBVHTime__BackingField;
			double num3 = num2 + UpdateBufferTime__BackingField;
			double num4 = num3 + UpdateBVHTime__BackingField;
			return num4 + RefitBVHTime__BackingField;
		}
	}

	public int BVHMaxDeep
	{
		get
		{
			return BVHMaxDeep__BackingField;
		}
		private set
		{
			BVHMaxDeep__BackingField = value;
		}
	}

	public int BVHNodesCount
	{
		get
		{
			return BVHNodesCount__BackingField;
		}
		private set
		{
			BVHNodesCount__BackingField = value;
		}
	}

	public int HitboxesCount
	{
		get
		{
			return HitboxesCount__BackingField;
		}
		private set
		{
			HitboxesCount__BackingField = value;
		}
	}

	public double AddOnBufferTime
	{
		get
		{
			return AddOnBufferTime__BackingField;
		}
		private set
		{
			AddOnBufferTime__BackingField = value;
		}
	}

	public double AddOnBVHTime
	{
		get
		{
			return AddOnBVHTime__BackingField;
		}
		private set
		{
			AddOnBVHTime__BackingField = value;
		}
	}

	public double UpdateBVHTime
	{
		get
		{
			return UpdateBVHTime__BackingField;
		}
		private set
		{
			UpdateBVHTime__BackingField = value;
		}
	}

	public double UpdateBufferTime
	{
		get
		{
			return UpdateBufferTime__BackingField;
		}
		private set
		{
			UpdateBufferTime__BackingField = value;
		}
	}

	public double AdvanceBufferTime
	{
		get
		{
			return AdvanceBufferTime__BackingField;
		}
		private set
		{
			AdvanceBufferTime__BackingField = value;
		}
	}

	public double RefitBVHTime
	{
		get
		{
			return RefitBVHTime__BackingField;
		}
		private set
		{
			RefitBVHTime__BackingField = value;
		}
	}

	internal void CopyFromSnapshot(LagCompensationStatisticsSnapshot snapshot)
	{
		AddOnBufferTime__BackingField = snapshot.AddOnBufferTime__BackingField;
		BVHMaxDeep__BackingField = snapshot.BVHMaxDeep__BackingField;
		UpdateBVHTime__BackingField = snapshot.UpdateBVHTime__BackingField;
		HitboxesCount__BackingField = snapshot.HitboxesCount__BackingField;
		AdvanceBufferTime__BackingField = snapshot.AdvanceBufferTime__BackingField;
	}

	internal void ClearSnapshot()
	{
		BVHMaxDeep__BackingField = 0;
		HitboxesCount__BackingField = 0;
		AddOnBufferTime__BackingField = 0.0;
		UpdateBVHTime__BackingField = 0.0;
		AdvanceBufferTime__BackingField = 0.0;
	}

	internal void SetBVHMaxDeep(int value, bool overrideValue = default(bool))
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0071;
			}
			ex = new NullReferenceException();
		}
		int num = (int)(((Exception)ex)._className + num);
		goto IL_0071;
		IL_0071:
		((Exception)ex)._className = (string)num;
	}

	internal void SetBVHNodeCount(int value, bool overrideValue = default(bool))
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				return;
			}
			ex = new NullReferenceException();
		}
		int num = (int)(((Exception)ex)._className + num);
	}

	internal void SetHitboxesCount(int value, bool overrideValue = default(bool))
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0071;
			}
			ex = new NullReferenceException();
		}
		int num = (int)(((Exception)ex)._message + num);
		goto IL_0071;
		IL_0071:
		((Exception)ex)._message = (string)num;
	}

	internal void SetAddOnBufferTime(double value, bool overrideValue = default(bool))
	{
		//IL_0080: Expected Obj, but got F8
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0073;
			}
			ex = new NullReferenceException();
		}
		double num = (double)((Exception)ex)._data + num;
		goto IL_0073;
		IL_0073:
		((Exception)ex)._data = (IDictionary)num;
	}

	internal void SetAddOnBVHTime(double value, bool overrideValue = default(bool))
	{
		//IL_0080: Expected Obj, but got F8
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0073;
			}
			ex = new NullReferenceException();
		}
		double num = (double)((Exception)ex)._innerException + num;
		goto IL_0073;
		IL_0073:
		((Exception)ex)._innerException = (Exception)num;
	}

	internal void SetUpdateBVHTime(double value, bool overrideValue = default(bool))
	{
		//IL_0080: Expected Obj, but got F8
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0073;
			}
			ex = new NullReferenceException();
		}
		double num = (double)((Exception)ex)._helpURL + num;
		goto IL_0073;
		IL_0073:
		((Exception)ex)._helpURL = (string)num;
	}

	internal void SetUpdateBufferTime(double value, bool overrideValue = default(bool))
	{
		//IL_0080: Expected Obj, but got F8
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0073;
			}
			ex = new NullReferenceException();
		}
		double num = (double)((Exception)ex)._stackTrace + num;
		goto IL_0073;
		IL_0073:
		((Exception)ex)._stackTrace = num;
	}

	internal void SetAdvanceBufferTime(double value, bool overrideValue = default(bool))
	{
		//IL_0080: Expected Obj, but got F8
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0073;
			}
			ex = new NullReferenceException();
		}
		double num = (double)((Exception)ex)._stackTraceString + num;
		goto IL_0073;
		IL_0073:
		((Exception)ex)._stackTraceString = (string)num;
	}

	internal void SetRefitBVHTime(double value, bool overrideValue = default(bool))
	{
		//IL_0080: Expected Obj, but got F8
		//IL_0039: Expected Obj, but got I4
		bool flag = !overrideValue;
		NullReferenceException ex = (NullReferenceException)(object)this;
		if (!flag)
		{
			bool flag2 = this == null;
			object obj = !flag2;
			ex = (NullReferenceException)(object)this;
			if (obj != null)
			{
				goto IL_0073;
			}
			ex = new NullReferenceException();
		}
		double num = (double)((Exception)ex)._remoteStackTraceString + num;
		goto IL_0073;
		IL_0073:
		((Exception)ex)._remoteStackTraceString = (string)num;
	}
}
