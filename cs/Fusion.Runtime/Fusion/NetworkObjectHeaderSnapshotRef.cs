using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

internal struct NetworkObjectHeaderSnapshotRef(NetworkObjectHeaderSnapshot snapshot)
{
	private readonly NetworkObjectHeaderSnapshot _snapshot = snapshot;

	public bool Valid
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			bool flag = _snapshot == null;
			return !flag;
		}
	}

	public Tick Tick
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0041: Expected VT, but got Obj
			NetworkObjectHeaderSnapshot snapshot = _snapshot;
			if (_snapshot != null)
			{
				return snapshot.Tick;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Tick)ex;
		}
	}

	public unsafe ref NetworkObjectHeader Header
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_004c: Expected Obj, but got I
			NetworkObjectHeaderSnapshot snapshot = _snapshot;
			if (_snapshot == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return ref *(NetworkObjectHeader*)ex;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84B8]");
			object error = 0;
			bool flag = snapshot._ptr == null;
			bool condition = !flag;
			Assert.Always(condition, (string)error);
			return ref *(NetworkObjectHeader*)snapshot._ptr;
		}
	}

	public ulong SnapshotCRC
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0041: Expected I8, but got Obj
			if (_snapshot != null)
			{
				return _snapshot.BuildCRC();
			}
			NullReferenceException ex = new NullReferenceException();
			return (ulong)(long)ex;
		}
	}

	internal unsafe Span<int> Raw
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_0091: Expected VT, but got Obj
			//IL_009e: Expected VT, but got I
			//IL_0045: Expected I4, but got I8
			NetworkObjectHeaderSnapshot snapshot = _snapshot;
			if (_snapshot == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (Span<int>)ex;
			}
			Span<int> result = (Span<int>)snapshot._ptr;
			if (snapshot._ptr != null)
			{
				if ((int)(snapshot.WordCount & 0x80000000L) != 0)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
			}
			else
			{
				Span<int> empty = Span<int>.Empty;
				result = empty;
			}
			return result;
		}
	}

	public static implicit operator NetworkObjectHeaderSnapshotRef(NetworkObjectHeaderSnapshot snapshot)
	{
		//IL_0005: Expected VT, but got Obj
		return (NetworkObjectHeaderSnapshotRef)snapshot;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyFrom(NetworkObjectMeta source)
	{
		//IL_0024: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		NetworkObjectHeaderSnapshot snapshot = _snapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
		object error = 0;
		object obj = snapshot.WordCount - source.WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = snapshot.WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_00ac;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_00ac;
			}
		}
		bool flag2 = true;
		goto IL_018b;
		IL_018b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_00ac:
		if (snapshot._ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = source._ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_018b;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe void CopyFrom(NetworkObjectMeta source, OffsetSet ignoredOffsets)
	{
		//IL_0119: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I4
		//IL_0957: Expected I4, but got I8
		//IL_09fe: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_005c: Expected I4, but got I8
		//IL_006c: Expected Obj, but got I
		//IL_0074: Expected I4, but got Obj
		//IL_0082: Expected VT, but got I
		//IL_0981: Expected VT, but got I
		//IL_0275: Expected VT, but got I
		//IL_09c0: Expected Obj, but got I
		//IL_00be: Expected I4, but got I8
		//IL_0649: Expected Obj, but got I4
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected I4, but got Unknown
		//IL_02a3: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I4
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected VT, but got Unknown
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Expected Obj, but got Unknown
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Expected Obj, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected Obj, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected I4, but got Unknown
		//IL_0acf: Invalid comparison between VT and Obj
		//IL_066b: Expected Obj, but got I
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_0699: Expected Obj, but got I4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_0308: Expected Obj, but got I4
		//IL_06f7: Expected Obj, but got I
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_071f: Expected Obj, but got I4
		//IL_06c9: Expected Obj, but got I4
		//IL_0755: Expected Obj, but got I4
		//IL_0765: Expected Obj, but got I
		//IL_0366: Expected Obj, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_0338: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected Obj, but got Unknown
		//IL_07c3: Expected Obj, but got I4
		//IL_03bb: Expected Obj, but got I
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03e9: Expected Obj, but got I4
		//IL_07f0: Expected Obj, but got I
		//IL_081a: Expected Obj, but got I4
		//IL_086f: Expected I4, but got Obj
		//IL_0447: Expected Obj, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_046f: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected VT, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Expected VT, but got Unknown
		//IL_084a: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I
		//IL_04b4: Expected VT, but got I
		//IL_054d: Invalid comparison between VT and Obj
		//IL_0563: Expected Obj, but got I4
		//IL_04f4: Expected VT, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected VT, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected I4, but got Unknown
		//IL_059e: Expected Obj, but got I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected VT, but got Unknown
		//IL_05f2: Expected Obj, but got Ref
		ReadOnlySpan<int> readOnlySpan;
		Span<int> span2;
		object obj2;
		object obj5;
		int num5;
		int num7;
		if (ignoredOffsets != null)
		{
			int[] array = ignoredOffsets._003CsortedOffsets_003EP;
			if (array.Length != 0)
			{
				if ((int)(source.WordCount & -9223372036854775808L) != 0)
				{
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				int num = (int)(source.WordCount & 0xFFFFFFFFL);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D59E0]");
				object obj = 0;
				int num2 = (int)obj;
				readOnlySpan = (Span<int>)source._ptr;
				NetworkObjectHeaderSnapshot snapshot = _snapshot;
				Span<int> span = (Span<int>)snapshot._ptr;
				int num3;
				if (snapshot._ptr != null)
				{
					num3 = snapshot.WordCount;
					int num4 = (int)(snapshot.WordCount & 0x80000000L);
					bool flag = num4 == 0;
					span2 = span;
					if (!flag)
					{
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						span2 = span;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C0]");
					span = (Span<int>)0;
					Span<int> empty = Span<int>.Empty;
					span2 = empty;
					num3 = num;
				}
				ReadOnlySpan<int> values = ignoredOffsets.Values;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4D28]");
				obj2 = 0;
				if (0 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84D0]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
					object obj4 = 0;
					obj5 = 0;
					ReadOnlySpan<int> readOnlySpan2 = values;
					num5 = num;
					object obj6 = 0;
					do
					{
						readOnlySpan2 = (ReadOnlySpan<int>)(readOnlySpan2 + 4);
						string text = (string)obj3;
						object obj7 = readOnlySpan2 - obj5;
						bool flag2 = (nint)obj7 < 0;
						object obj8 = readOnlySpan2 ^ obj5;
						object obj9 = readOnlySpan2 ^ obj7;
						object obj10 = obj8 & obj9;
						bool flag3 = (nint)obj10 < 0;
						bool condition = flag2 == flag3;
						Assert.Check(condition, (string)obj3);
						int num6 = readOnlySpan2 - obj5;
						bool flag4 = readOnlySpan2 <= obj5;
						num2 = 0;
						if (!flag4)
						{
							object obj11 = obj4;
							object obj12 = num3 - obj5;
							bool flag5 = num3 < (nint)obj5;
							object obj13 = !flag5;
							object obj14 = ~obj13;
							if (obj14 == null)
							{
								bool flag6 = (nint)obj12 < num6;
								object obj15 = !flag6;
								if (obj15 != null)
								{
									goto IL_0350;
								}
							}
							System.ThrowHelper.ThrowArgumentOutOfRangeException();
							goto IL_0350;
						}
						goto IL_05ff;
						IL_0350:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X26_v7+20]");
						object obj16 = (nint)0 + (nint)309;
						object obj17 = obj16 & 1;
						bool flag7 = obj17 == null;
						object obj18 = !flag7;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E68]");
						object obj19 = 0;
						object obj20 = obj19;
						object obj21 = num5 - obj5;
						bool flag8 = num5 < (nint)obj5;
						object obj22 = !flag8;
						object obj23 = ~obj22;
						if (obj23 == null)
						{
							bool flag9 = (nint)obj21 < num6;
							object obj24 = !flag9;
							if (obj24 != null)
							{
								goto IL_0431;
							}
						}
						System.ThrowHelper.ThrowArgumentOutOfRangeException();
						goto IL_0431;
						IL_05ff:
						obj6--;
						obj5 = readOnlySpan2 + 1;
						continue;
						IL_0431:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X26_v8+20]");
						object obj25 = (nint)0 + (nint)309;
						object obj26 = obj25 & 1;
						bool flag10 = obj26 == null;
						object obj27 = !flag10;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F0]");
						object obj28 = 0;
						ref int reference = ref *(int*)obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X26_v6 (System.Int32&)+38]");
						span = (Span<int>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X26_v6 (System.Int32&)+38]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X26_v6 (System.Int32&)+38]");
							span = (Span<int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X26_v6 (System.Int32&)+38]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
							}
						}
						Assert.Check(condition: true, num6, num6);
						bool flag11 = readOnlySpan2 == (ReadOnlySpan<int>)obj5;
						num2 = num6;
						text = (string)num6;
						if (!flag11)
						{
							Span<int> span3 = (Span<int>)(span2 + obj5);
							bool flag = (byte)(int)(obj5 & 0xFFFFFFFFL) != 0;
							object obj29 = (flag ? 1u : 0u) << 2;
							ref int reference2 = ref MemoryMarshal.GetReference(span3);
							ReadOnlySpan<int> span4 = (ReadOnlySpan<int>)(readOnlySpan + obj29);
							ref int reference3 = ref MemoryMarshal.GetReference(span4);
							num2 = num6 << 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
							reference = ref reference2;
							text = (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
							span = (Span<int>)readOnlySpan;
						}
						goto IL_05ff;
					}
					while ((nint)obj6 != 1);
				}
				else
				{
					obj5 = 0;
					string text = null;
					num5 = num;
				}
				num7 = num5 - obj5;
				if (num5 <= (nint)obj5)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E50]");
				object obj30 = 0;
				object obj31 = obj30;
				object obj32 = num3 - obj5;
				bool flag12 = num3 < (nint)obj5;
				object obj33 = !flag12;
				object obj34 = ~obj33;
				if (obj34 == null)
				{
					bool flag13 = (nint)obj32 < num7;
					object obj35 = !flag13;
					if (obj35 != null)
					{
						goto IL_06e1;
					}
				}
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				goto IL_06e1;
			}
		}
		NetworkObjectHeaderSnapshot snapshot2 = _snapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
		object error = 0;
		object obj36 = snapshot2.WordCount - source.WordCount;
		bool condition2 = obj36 == null;
		Assert.Check(condition2, (string)error);
		int num8 = snapshot2.WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num8 != 0)
			{
				goto IL_01a1;
			}
		}
		else
		{
			_ = 1;
			bool flag14 = num8 == 0;
			object obj37 = !flag14;
			if (obj37 != null)
			{
				goto IL_01a1;
			}
		}
		bool flag15 = true;
		goto IL_09ee;
		IL_01a1:
		if (snapshot2._ptr != null)
		{
			int num9 = num8 >> 30;
			bool flag16 = source._ptr == null;
			object obj38 = !flag16;
			object obj39 = ~obj38;
			bool flag17 = obj39 == null && num9 == 0;
			flag15 = flag17;
		}
		else
		{
			flag15 = false;
		}
		goto IL_09ee;
		IL_0b1b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_09ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		int num10 = num8;
		int num11 = num8;
		int* ptr = source._ptr;
		ref int reference4 = ref *snapshot2._ptr;
		goto IL_0b1b;
		IL_06e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X19_v13+20]");
		object obj41 = (nint)0 + (nint)309;
		object obj42 = obj41 & 1;
		bool flag18 = obj42 == null;
		object obj43 = !flag18;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		bool flag19 = num5 < (nint)obj5;
		object obj44 = !flag19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6E68]");
		object obj45 = 0;
		object obj46 = obj45;
		if (obj44 == null)
		{
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X19_v14+20]");
		object obj47 = (nint)0 + (nint)309;
		object obj48 = obj47 & 1;
		bool flag20 = obj48 == null;
		object obj49 = !flag20;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F0]");
		object obj50 = 0;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X23_v7+38]");
		bool flag21 = (nint)0 == 0;
		object obj52 = !flag21;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X23_v7+38]");
			bool flag22 = (nint)0 == 0;
			object obj53 = !flag22;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E610");
			}
		}
		num10 = (int)obj2;
		Assert.Check(condition: true, num7, num7);
		if (num5 == (nint)obj5)
		{
			return;
		}
		object obj54 = obj5 & 0xFFFFFFFFL;
		object obj55 = obj54 << 2;
		Span<int> span5 = (Span<int>)(span2 + obj5);
		reference4 = ref MemoryMarshal.GetReference(span5);
		ReadOnlySpan<int> span6 = (ReadOnlySpan<int>)(readOnlySpan + obj55);
		ref int reference5 = ref MemoryMarshal.GetReference(span6);
		num11 = num7 << 2;
		ptr = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference5);
		goto IL_0b1b;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyFrom(NetworkObjectHeaderSnapshotRef source)
	{
		//IL_0024: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		NetworkObjectHeaderSnapshot snapshot = _snapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D84C8]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+24]");
		object obj = -snapshot.WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = snapshot.WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_00af;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_00af;
			}
		}
		bool flag2 = true;
		goto IL_0191;
		IL_0191:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_00af:
		if (snapshot._ptr != null)
		{
			int num2 = num >> 30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [source @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+28]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_0191;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyTo(NetworkObjectMeta destination)
	{
		//IL_0024: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		NetworkObjectHeaderSnapshot snapshot = _snapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7190]");
		object error = 0;
		object obj = snapshot.WordCount - destination.WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = snapshot.WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_00ac;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_00ac;
			}
		}
		bool flag2 = true;
		goto IL_018b;
		IL_018b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_00ac:
		if (destination._ptr != null)
		{
			int num2 = num >> 30;
			bool flag3 = snapshot._ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_018b;
	}

	[MethodImpl((MethodImplOptions)256)]
	public void CopyTo(int[] destination)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AA5C");
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void CopyTo(NetworkObjectHeaderSnapshotRef destination)
	{
		//IL_0024: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_01a1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		NetworkObjectHeaderSnapshot snapshot = _snapshot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7190]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [destination @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+24]");
		object obj = -snapshot.WordCount;
		bool condition = obj == null;
		Assert.Check(condition, (string)error);
		int num = snapshot.WordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_00af;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_00af;
			}
		}
		bool flag2 = true;
		goto IL_0191;
		IL_0191:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_00af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [destination @ X1 (Fusion.NetworkObjectHeaderSnapshotRef)+28]");
		if ((nint)0 != 0)
		{
			int num2 = num >> 30;
			bool flag3 = snapshot._ptr == null;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			bool flag4 = obj5 == null && num2 == 0;
			flag2 = flag4;
		}
		else
		{
			flag2 = false;
		}
		goto IL_0191;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe int* GetBehaviourPtr(NetworkBehaviour behaviour)
	{
		//IL_003c: Expected I, but got Obj
		if (_snapshot != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @310AC04");
			int* result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int*)(nint)ex;
	}
}
