using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Fusion;

internal class Timeline
{
	public RingBuffer<TimelinePoint> Points;

	private bool _hasSinglePoint
	{
		get
		{
			//IL_0045: Expected I4, but got Obj
			//IL_0023: Expected Obj, but got I4
			if ((object)Points != null)
			{
				int capacity = Points.Capacity;
				object obj = capacity - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool IsEmpty
	{
		get
		{
			//IL_0028: Expected I4, but got Obj
			if ((object)Points != null)
			{
				return Points.IsEmpty;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public Timeline(int capacity)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA020]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA028]");
		object obj2 = 0;
		base._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RingBuffer<TimelinePoint> ringBuffer = default;
		ringBuffer._002Ector(capacity);
		object obj3 = this + 16;
		obj3 = ringBuffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	public void Clear()
	{
		Points.Clear();
	}

	public void AddPoint(TimelinePoint point, double tickDeltaDouble, bool allowInactiveHandling = default(bool))
	{
		//IL_00f2: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I
		nint num = default;
		object obj = num & 1;
		if (obj != null)
		{
			bool isEmpty = Points.IsEmpty;
			bool flag = !isEmpty;
			object obj2 = !flag;
			if (obj2 == null)
			{
				bool hasSinglePoint = _hasSinglePoint;
				bool flag2 = !hasSinglePoint;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					ref TimelinePoint reference = ref Points.Back();
					bool flag3 = allowInactiveHandling;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v11 (Fusion.TimelinePoint&)+8]");
					object obj4 = (nint)(flag3 ? 1 : 0) - (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C128]");
					if ((nint)obj4 >= 0)
					{
						Points.PushBack(reference);
					}
				}
			}
		}
		Points.PushBack(point);
	}

	public unsafe InterpolationParams GetInterpolationParams(double time)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0134: Expected F8, but got I4
		//IL_0052: Expected F8, but got I4
		//IL_0063: Expected VT, but got I4
		//IL_006c: Expected VT, but got I4
		//IL_0075: Expected VT, but got I4
		//IL_00bb: Expected F8, but got I4
		//IL_095a: Expected native int or pointer, but got VT
		//IL_0967: Expected native int or pointer, but got VT
		//IL_0974: Expected native int or pointer, but got VT
		//IL_0981: Expected native int or pointer, but got VT
		//IL_098e: Expected native int or pointer, but got VT
		//IL_078d: Expected VT, but got I4
		//IL_015b: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_0194: Expected F8, but got I4
		//IL_00ef: Expected F8, but got I4
		//IL_0100: Expected VT, but got Ref
		//IL_01bb: Expected Obj, but got I
		//IL_01c3: Expected I, but got Obj
		//IL_01e2: Invalid comparison between I and F8
		//IL_05c3: Expected F8, but got I4
		//IL_05cc: Expected VT, but got I4
		//IL_0209: Expected F8, but got I
		//IL_0219: Invalid comparison between I and F8
		//IL_022a: Expected Obj, but got I4
		//IL_024a: Invalid comparison between F8 and I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_05e2: Expected I, but got Obj
		//IL_0620: Expected F8, but got I4
		//IL_0683: Expected F8, but got I4
		//IL_068c: Expected VT, but got I4
		//IL_0285: Expected Obj, but got I
		//IL_0292: Expected I4, but got I8
		//IL_0653: Expected F8, but got I4
		//IL_0664: Expected VT, but got Ref
		//IL_06a2: Expected I, but got Obj
		//IL_06d8: Expected F8, but got I4
		//IL_09b2: Expected F8, but got I4
		//IL_0720: Expected VT, but got Ref
		//IL_02cb: Expected Obj, but got I4
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected Obj, but got Unknown
		//IL_030c: Expected F8, but got I4
		//IL_0908: Expected Obj, but got I4
		//IL_0357: Expected F8, but got I4
		//IL_086a: Expected Obj, but got I
		//IL_087a: Expected VT, but got I
		//IL_0896: Expected VT, but got Obj
		//IL_03ac: Invalid comparison between I4 and F8
		//IL_03bd: Expected Obj, but got I4
		//IL_03d5: Invalid comparison between F8 and I4
		//IL_03e6: Expected Obj, but got I4
		//IL_08c0: Expected VT, but got Obj
		//IL_0419: Invalid comparison between I4 and F8
		//IL_045a: Expected F8, but got I4
		//IL_046a: Expected VT, but got I4
		//IL_04ad: Expected F8, but got I4
		//IL_04fc: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I4
		//IL_055f: Expected Obj, but got I4
		//IL_058c: Expected VT, but got I4
		if ((object)Points == null)
		{
			goto IL_0725;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA030]");
		object obj = 0;
		nint num = (nint)obj;
		bool flag = Points.IsEmpty;
		if (flag)
		{
			goto IL_0049;
		}
		double num2 = default;
		TimelinePoint to;
		Status status;
		InterpolationParams result;
		TimelinePoint timelinePoint;
		int num4;
		object obj7;
		int num6;
		int num7;
		int num8;
		object obj9;
		double num3;
		if (_hasSinglePoint)
		{
			bool flag2 = (object)Points == null;
			num2 = 0.0;
			if (flag2)
			{
				goto IL_0725;
			}
			ref TimelinePoint reference = ref Points.Back();
			to = reference;
			num2 = 0.0;
			status = (Status)0;
			result = (InterpolationParams)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			timelinePoint = reference;
		}
		else
		{
			bool flag3 = (object)Points == null;
			num3 = time;
			num2 = 0.0;
			num4 = 109899776;
			if (flag3)
			{
				goto IL_076e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA050]");
			object obj2 = 0;
			num = (nint)obj2;
			ref TimelinePoint reference2 = ref Points.Front();
			bool flag4 = (object)Points == null;
			num3 = time;
			num2 = 0.0;
			num4 = 109899776;
			if (flag4)
			{
				goto IL_077c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA040]");
			object obj3 = 0;
			num = (nint)obj3;
			ref TimelinePoint reference3 = ref Points.Back();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v53 (Fusion.TimelinePoint&)+8]");
			if (0.0 < time)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v55 (Fusion.TimelinePoint&)+8]");
				num3 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v55 (Fusion.TimelinePoint&)+8]");
				bool flag5 = 0.0 < time;
				object obj4 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v55 (Fusion.TimelinePoint&)+8]");
				double num5 = 0.0 - time;
				bool flag6 = num5 == 0.0;
				object obj5 = ~obj4;
				object obj6 = obj5 | flag6;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA060]");
					obj7 = 0;
					num6 = -1;
					num4 = 109899776;
					while (true)
					{
						bool flag7 = (object)Points == null;
						num2 = 0.0;
						if (flag7)
						{
							break;
						}
						int count = Points.Count;
						num7 = num6 + 1;
						object obj8 = count - 1;
						bool flag8 = num7 >= (nint)obj8;
						flag = (byte)count != 0;
						if (flag8)
						{
							goto IL_0049;
						}
						bool flag9 = (object)Points == null;
						num2 = 0.0;
						num = num7;
						if (flag9)
						{
							goto IL_0752;
						}
						obj9 = obj7;
						TimelinePoint timelinePoint2 = Points.get_Item(num7);
						bool flag10 = (object)Points == null;
						num2 = 0.0;
						num = num7;
						if (!flag10)
						{
							obj9 = obj7;
							num8 = num6 + 2;
							TimelinePoint timelinePoint3 = Points.get_Item(num8);
							num6++;
							bool flag11 = (double)num7 < time;
							object obj10 = !flag11;
							double num9 = (double)num7 - time;
							bool flag12 = num9 == 0.0;
							object obj11 = !flag12;
							object obj12 = obj10 & obj11;
							num = num8;
							num4 = num7;
							if (obj12 != null)
							{
								continue;
							}
							bool flag13 = !((double)num8 > time);
							num = num8;
							num4 = num7;
							if (flag13)
							{
								continue;
							}
							goto IL_0440;
						}
						goto IL_0760;
					}
					goto IL_0744;
				}
				bool flag14 = (object)Points == null;
				num2 = 0.0;
				timelinePoint = (TimelinePoint)109899776;
				if (flag14)
				{
					goto IL_07ae;
				}
				num = (nint)obj3;
				timelinePoint = Points.Back();
				bool flag15 = (object)Points == null;
				num2 = 0.0;
				if (flag15)
				{
					goto IL_07bc;
				}
				ref TimelinePoint reference4 = ref Points.Back();
				to = reference4;
				num2 = 1.0;
				status = (Status)1;
				result = (InterpolationParams)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4);
			}
			else
			{
				bool flag16 = (object)Points == null;
				num3 = time;
				num2 = 0.0;
				timelinePoint = (TimelinePoint)109899776;
				if (flag16)
				{
					goto IL_0792;
				}
				num = (nint)obj2;
				timelinePoint = Points.Front();
				bool flag17 = (object)Points == null;
				num3 = time;
				num2 = 0.0;
				if (flag17)
				{
					goto IL_07a0;
				}
				ref TimelinePoint reference5 = ref Points.Front();
				to = reference5;
				num2 = 0.0;
				status = (Status)2;
				result = (InterpolationParams)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference5);
			}
		}
		goto IL_0952;
		IL_0760:
		NullReferenceException ex = new NullReferenceException();
		goto IL_076e;
		IL_09e8:
		status = (Status)0;
		goto IL_0952;
		IL_0440:
		bool flag18 = (object)Points == null;
		num2 = 0.0;
		num = num8;
		timelinePoint = (TimelinePoint)num7;
		if (flag18)
		{
			goto IL_07ca;
		}
		obj9 = obj7;
		TimelinePoint timelinePoint4 = Points.get_Item(num6);
		bool flag19 = (object)Points == null;
		num2 = 0.0;
		num = num6;
		timelinePoint = timelinePoint4;
		if (flag19)
		{
			goto IL_07d8;
		}
		int index = num6 + 1;
		TimelinePoint timelinePoint5 = Points.get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v75+E4]");
		bool flag20 = (nint)0 == 0;
		object obj15 = !flag20;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num10 = time - (double)num7;
		object obj16 = num8 - num7;
		double v = num10 / (double)obj16;
		double num11 = Maths.Clamp01(v);
		num2 = num11;
		result = (InterpolationParams)0;
		to = timelinePoint5;
		timelinePoint = timelinePoint4;
		goto IL_09e8;
		IL_076e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_077c;
		IL_0792:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_07a0;
		IL_07d8:
		NullReferenceException ex4 = new NullReferenceException();
		bool flag21 = num != 1;
		NullReferenceException ex5 = ex4;
		if (!flag21)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj18 = default;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj20 = default;
			object obj19 = obj20 & 1;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v24+A0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v9+20]");
				result = (InterpolationParams)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v9+20]");
				bool flag22 = (nint)0 == 0;
				to = (TimelinePoint)this;
				if (!flag22)
				{
					double time2 = result.Time;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v663 @ X8_v10 (System.Double)+1D8] (should have been resolved before IL gen)");
					to = (TimelinePoint)this;
				}
				goto IL_09e8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj22 = obj18;
			num = 101790920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj9 = 0;
			NullReferenceException ex6 = default;
			ex5 = ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		InterpolationParams result2 = default;
		return result2;
		IL_07bc:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_07ca;
		IL_07ca:
		NullReferenceException ex8 = new NullReferenceException();
		goto IL_07d8;
		IL_077c:
		NullReferenceException ex9 = new NullReferenceException();
		timelinePoint = (TimelinePoint)num4;
		goto IL_0792;
		IL_0744:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_0752;
		IL_07a0:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_07ae;
		IL_07ae:
		NullReferenceException ex12 = new NullReferenceException();
		goto IL_07bc;
		IL_0725:
		NullReferenceException ex13 = new NullReferenceException();
		num3 = time;
		num4 = 109899776;
		goto IL_0744;
		IL_0752:
		NullReferenceException ex14 = new NullReferenceException();
		goto IL_0760;
		IL_0952:
		InterpolationParams interpolationParams = default;
		((InterpolationParams*)(nint)interpolationParams)->Time = time;
		System.Runtime.CompilerServices.Unsafe.Write(&((InterpolationParams*)(nint)interpolationParams)->From, (Tick)timelinePoint);
		System.Runtime.CompilerServices.Unsafe.Write(&((InterpolationParams*)(nint)interpolationParams)->To, (Tick)to);
		((InterpolationParams*)(nint)interpolationParams)->Alpha = (float)num2;
		((InterpolationParams*)(nint)interpolationParams)->Status = status;
		return result;
		IL_0049:
		num2 = 0.0;
		status = (Status)0;
		result = (InterpolationParams)flag;
		to = (TimelinePoint)0;
		timelinePoint = (TimelinePoint)0;
		goto IL_0952;
	}
}
