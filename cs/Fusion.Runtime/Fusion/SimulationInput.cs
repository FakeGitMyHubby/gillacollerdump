using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion.Sockets;
using Unity.Collections.LowLevel.Unsafe;

namespace Fusion;

public class SimulationInput
{
	private class DebuggerProxy
	{
		public readonly SimulationInput[] Items;

		public DebuggerProxy(SimulationMessageInternal_SharedModeBatchRequestStateAuthority.List list)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected Obj, but got Unknown
			SimulationInput[] array = list.ToArray();
			object obj = this + 16;
			obj = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	public class Buffer
	{
		private readonly int _capacity;

		private readonly Dictionary<Tick, SimulationInput> _inputs;

		private readonly Dictionary<Tick, double> _insertTimes;

		private SimulationInputHeader _lastUsedInputHeader;

		public int Count
		{
			get
			{
				//IL_0028: Expected I4, but got Obj
				if ((object)_inputs != null)
				{
					return ((Dictionary<Tick, System.__Canon>)(object)_inputs).Count;
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
		}

		public int Capacity => _capacity;

		public bool IsFull
		{
			get
			{
				//IL_0019: Expected Obj, but got I4
				int count = Count;
				object obj = count - _capacity;
				return obj == null;
			}
		}

		public Buffer(int capacity)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0030: Expected Obj, but got I
			//IL_0040: Expected Obj, but got I
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA708]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA710]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA718]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8E90]");
			object obj4 = 0;
			base._002Ector();
			_capacity = capacity;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			TickRate.EqualityComparer equalityComparer = default;
			equalityComparer._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<Tick, System.__Canon> dictionary = default;
			dictionary._002Ector((IEqualityComparer<Tick>)(object)equalityComparer);
			object obj5 = this + 24;
			obj5 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Dictionary<Tick, double> dictionary2 = default;
			dictionary2._002Ector();
			object obj6 = this + 32;
			obj6 = dictionary2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public void Clear()
		{
			((Dictionary<Tick, System.__Canon>)(object)_inputs).Clear();
			_insertTimes.Clear();
		}

		public int CopySortedTo(SimulationInput[] array)
		{
			//IL_0373: Expected Obj, but got I4
			//IL_0016: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I4
			//IL_003b: Expected Obj, but got I4
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected I4, but got Unknown
			//IL_00aa: Expected Obj, but got I4
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected I4, but got Unknown
			//IL_0170: Expected Obj, but got I
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected Obj, but got Unknown
			//IL_01df: Expected Obj, but got I
			//IL_01e8: Expected Obj, but got I4
			//IL_0399: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Expected Obj, but got Unknown
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Expected I4, but got Unknown
			//IL_03d6: Expected I4, but got Obj
			//IL_0209: Expected Obj, but got I4
			//IL_035a: Expected I4, but got Obj
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected Obj, but got Unknown
			//IL_02d4: Expected Obj, but got I4
			//IL_02f6: Expected Obj, but got I
			bool flag = array == null;
			object obj = 109899776;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA7B8]");
				obj = 0;
				object obj2 = array.Length;
				int count = Count;
				object obj3 = count - array.Length;
				bool flag2 = (nint)obj3 < 0;
				bool flag3 = obj3 == null;
				int num = count ^ array.Length;
				int num2 = count ^ obj3;
				int num3 = num & num2;
				bool flag4 = num3 < 0;
				bool flag5 = flag2 == flag4;
				object obj4 = !flag5;
				bool condition = (byte)((obj4 | flag3) ? 1 : 0) != 0;
				Assert.Always(condition, (string)obj);
				Array.Clear(array, 0, array.Length);
				if ((object)_inputs != null)
				{
					ValueCollection<> values = ((Dictionary<Tick, System.__Canon>)(object)_inputs).Values;
					if (values != null)
					{
						values.CopyTo((_003F[])(object)array, 0);
						if ((object)_inputs != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA790]");
							obj = 0;
							int count2 = ((Dictionary<Tick, System.__Canon>)(object)_inputs).Count;
							ArraySpecialized.Sort(array, 0, count2);
							Dictionary<Tick, System.__Canon> inputs = (Dictionary<Tick, System.__Canon>)(object)_inputs;
							if ((object)_inputs != null)
							{
								object obj5 = array + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA7C0]");
								object error = 0;
								object obj6 = 0;
								object obj8;
								do
								{
									int count3 = inputs.Count;
									obj3 = obj6 - count3;
									flag2 = (nint)obj3 < 0;
									flag3 = obj3 == null;
									num = obj6 ^ count3;
									num2 = obj6 ^ obj3;
									num3 = num & num2;
									flag4 = num3 < 0;
									condition = (nint)obj6 >= count3;
									obj2 = obj6;
									if (!condition)
									{
										bool flag6 = (nint)obj6 < array.Length;
										object obj7 = !flag6;
										if (obj7 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v1+v168 @ X22_v6*8]");
											flag2 = (nint)0 < (nint)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v1+v168 @ X22_v6*8]");
											flag3 = (nint)0 == 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v1+v168 @ X22_v6*8]");
											nint num4 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v1+v168 @ X22_v6*8]");
											num2 = (int)(num4 ^ 0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v1+v168 @ X22_v6*8]");
											num3 = (int)((nint)0 & (nint)num2);
											flag4 = num3 < 0;
											condition = !flag3;
											Assert.Check(condition, (string)error);
											inputs = (Dictionary<Tick, System.__Canon>)(object)_inputs;
											obj2 = obj6 + 1;
											bool flag7 = (object)_inputs == null;
											obj8 = !flag7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v1+v168 @ X22_v6*8]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X24_v1+v168 @ X22_v6*8]");
											obj3 = 0;
											obj6 = obj2;
											continue;
										}
										IndexOutOfRangeException ex = new IndexOutOfRangeException();
										return (int)ex;
									}
									if ((object)_inputs == null)
									{
										break;
									}
									return ((Dictionary<Tick, System.__Canon>)(object)_inputs).Count;
								}
								while (obj8 != null);
							}
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		public bool Contains(Tick tick)
		{
			//IL_003e: Expected I4, but got Obj
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected VT, but got Unknown
			if ((object)_inputs != null)
			{
				Tick key = (Tick)(tick & 0xFFFFFFFFL);
				return ((Dictionary<Tick, System.__Canon>)(object)_inputs).ContainsKey(key);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public SimulationInput Get(Tick tick)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected VT, but got Unknown
			if ((object)_inputs != null)
			{
				Tick key = (Tick)(tick & 0xFFFFFFFFL);
				return (SimulationInput)(object)((Dictionary<Tick, System.__Canon>)(object)_inputs).get_Item(key);
			}
			return (SimulationInput)(object)new NullReferenceException();
		}

		public bool TryGet(Tick tick, out SimulationInput input)
		{
			//IL_0042: Expected I4, but got Obj
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected VT, but got Unknown
			if ((object)_inputs != null)
			{
				Tick key = (Tick)(tick & 0xFFFFFFFFL);
				return ((Dictionary<Tick, System.__Canon>)(object)_inputs).TryGetValue(key, out System.Runtime.CompilerServices.Unsafe.As<SimulationInput, System.__Canon>(ref input));
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public unsafe bool TryGet(Tick tick, out SimulationInput input, out double? timeInserted)
		{
			//IL_0117: Expected I4, but got Obj
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected VT, but got Unknown
			//IL_0027: Expected Obj, but got I
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected VT, but got Unknown
			if ((object)_inputs == null)
			{
				goto IL_0109;
			}
			Tick key = (Tick)(tick & 0xFFFFFFFFL);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA7D8]");
			object obj = 0;
			bool flag = ((Dictionary<Tick, System.__Canon>)(object)_inputs).TryGetValue(key, out System.Runtime.CompilerServices.Unsafe.As<SimulationInput, System.__Canon>(ref input));
			ref double? reference;
			if (flag)
			{
				if ((object)_insertTimes == null)
				{
					goto IL_0109;
				}
				Tick key2 = (Tick)(tick & 0xFFFFFFFFL);
				if (_insertTimes.TryGetValue(key2, out var value))
				{
					double? num = value;
					reference = ref *(double?*)null;
					goto IL_0136;
				}
			}
			else
			{
				ref SimulationInput reference2 = ref *(SimulationInput*)null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			}
			reference = ref *(double?*)null;
			_ = 0;
			goto IL_0136;
			IL_0136:
			return flag;
			IL_0109:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public bool Add(SimulationInput input, double? timeInserted = null)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0267: Expected I4, but got Obj
			//IL_0054: Expected Obj, but got I4
			//IL_009d: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I
			//IL_00c5: Expected Obj, but got I
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			//IL_0107: Expected Obj, but got I
			//IL_0133: Expected Obj, but got I
			//IL_0152: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA7E0]");
			object error = 0;
			bool flag = input == null;
			bool condition = !flag;
			Assert.Check(condition, (string)error);
			if (input != null)
			{
				bool flag2 = Contains((Tick)input.Header);
				bool flag3 = !flag2;
				object obj = !flag3;
				if (obj == null)
				{
					int count = Count;
					if (count != _capacity)
					{
						ref SimulationInputHeader header = ref input.Header;
						if ((object)_inputs != null)
						{
							((Dictionary<Tick, System.__Canon>)(object)_inputs).Add((Tick)header, (System.__Canon)(object)input);
							object obj2 = (_003F?)timeInserted & 0xFF;
							if (obj2 != null)
							{
								ref SimulationInputHeader header2 = ref input.Header;
								double? num = default;
								double value = num.Value;
								if ((object)_insertTimes == null)
								{
									goto IL_0259;
								}
								_insertTimes.Add((Tick)header2, value);
							}
							return true;
						}
						goto IL_0259;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v16+A0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+10]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+10]");
					if ((nint)0 != 0)
					{
						PlayerRef player = input.Player;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						ref SimulationInputHeader header3 = ref input.Header;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA7F0]");
						object format = 0;
						object arg = default;
						object arg2 = default;
						string text = string.Format((string)format, arg, arg2);
						object obj9 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v213 @ X8_v26+198] (should have been resolved before IL gen)");
					}
				}
				return false;
			}
			goto IL_0259;
			IL_0259:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public bool Remove(Tick tick, out SimulationInput removed)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected VT, but got Unknown
			Tick tick2 = (Tick)(tick & 0xFFFFFFFFL);
			double? timeInserted;
			return Remove(tick2, out removed, out timeInserted);
		}

		public unsafe bool Remove(Tick tick, out SimulationInput removed, out double? timeInserted)
		{
			//IL_01d6: Expected I4, but got Obj
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected VT, but got Unknown
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected VT, but got Unknown
			bool flag;
			ref double? reference;
			if ((object)_inputs != null)
			{
				Tick key = (Tick)(tick & 0xFFFFFFFFL);
				flag = ((Dictionary<Tick, System.__Canon>)(object)_inputs).Remove(key, out System.Runtime.CompilerServices.Unsafe.As<SimulationInput, System.__Canon>(ref removed));
				if (!flag)
				{
					goto IL_01b4;
				}
				if (removed != null)
				{
					_lastUsedInputHeader = removed.Header;
					if (removed != null)
					{
						ref SimulationInputHeader header = ref removed.Header;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v12 (Fusion.SimulationInputHeader&)+8]");
						_ = 0;
						if (removed != null)
						{
							ref SimulationInputHeader header2 = ref removed.Header;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v14 (Fusion.SimulationInputHeader&)+C]");
							_ = 0;
							if (removed != null)
							{
								ref SimulationInputHeader header3 = ref removed.Header;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v16 (Fusion.SimulationInputHeader&)+4]");
								_ = 0;
								if ((object)_insertTimes != null)
								{
									Tick key2 = (Tick)(tick & 0xFFFFFFFFL);
									if (!_insertTimes.Remove(key2, out var value))
									{
										goto IL_01b4;
									}
									double? num = value;
									reference = ref *(double?*)null;
									goto IL_01f5;
								}
							}
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_01b4:
			reference = ref *(double?*)null;
			_ = 0;
			goto IL_01f5;
			IL_01f5:
			return flag;
		}

		public SimulationInputHeader GetLastUsedInputHeader()
		{
			return _lastUsedInputHeader;
		}
	}

	private int _sent;

	private bool _delayed;

	private bool _pooled;

	private PlayerRef _player;

	internal unsafe int* _ptr;

	private Fusion.IntrusiveLinkedListNode<SimulationInput> _node;

	internal bool Delayed
	{
		get
		{
			return _delayed;
		}
		set
		{
			_delayed = value;
		}
	}

	public PlayerRef Player
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
			object error = 0;
			bool condition = !_pooled;
			Assert.Check(condition, (string)error);
			return _player;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
			object error = 0;
			bool condition = !_pooled;
			Assert.Check(condition, (string)error);
			_player = value;
		}
	}

	public unsafe ref SimulationInputHeader Header
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
			object error = 0;
			bool condition = !_pooled;
			Assert.Check(condition, (string)error);
			return ref *(SimulationInputHeader*)_ptr;
		}
	}

	public unsafe int* Data
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
			object error = 0;
			bool condition = !_pooled;
			Assert.Check(condition, (string)error);
			return _ptr + 4;
		}
	}

	public int Sent
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
			object error = 0;
			bool condition = !_pooled;
			Assert.Check(condition, (string)error);
			return _sent;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
			object error = 0;
			bool condition = !_pooled;
			Assert.Check(condition, (string)error);
			_sent = value;
		}
	}

	public unsafe void Clear(int wordCount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_0132: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
		object error = 0;
		bool condition = !_pooled;
		Assert.Check(condition, (string)error);
		int num = wordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8E]");
		if ((nint)0 != 0)
		{
			if (num == 0)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				return;
			}
		}
		bool flag2 = num >> 30 != 0 || _ptr == null;
		bool condition2 = !flag2;
		Assert.Always(condition2, (nint)_ptr, num);
		UnsafeUtility.MemClear(_ptr, num);
	}

	public unsafe void CopyFrom(SimulationInput source, int wordCount)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
		object error = 0;
		bool condition = !_pooled;
		Assert.Check(condition, (string)error);
		int num = wordCount << 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (num != 0)
			{
				goto IL_0065;
			}
		}
		else
		{
			_ = 1;
			bool flag = num == 0;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0065;
			}
		}
		object obj2 = 1;
		goto IL_015e;
		IL_015e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		return;
		IL_0065:
		if (_ptr != null)
		{
			bool flag2 = num >> 30 != 0 || source._ptr == null;
			object obj4 = !flag2;
			obj2 = obj4;
		}
		else
		{
			obj2 = 0;
		}
		goto IL_015e;
	}

	internal unsafe void Serialize(SimulationInput previous, SimulationConfig config, Fusion.Sockets.WriteBuffer writer, ReadBuffer reader)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_0459: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I
		//IL_0176: Expected I8, but got Obj
		//IL_04a9: Expected Obj, but got I4
		//IL_0354: Expected I4, but got I8
		//IL_0370: Expected Obj, but got I8
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected I8, but got Unknown
		//IL_0392: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA770]");
		object error = 0;
		bool condition = !_pooled;
		Assert.Check(condition, (string)error);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA778]");
		object error2 = 0;
		object obj = config.Topology - 1;
		bool condition2 = obj == null;
		Assert.Always(condition2, (string)error2);
		int* ptr = _ptr;
		int* ptr2 = previous._ptr;
		int inputDataWordCount = config.InputDataWordCount;
		if (writer != null)
		{
			object obj2 = config.InputDataWordCount + 4;
			if ((nint)obj2 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
				object obj3 = 0;
				int num = 0;
				nint num2 = 109899776;
				object obj7;
				do
				{
					if (ptr != ptr2)
					{
						writer.IntVar(num);
						object obj4 = obj3;
						num2 = (nint)ptr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v33+E4]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj5 = num2 - (nint)ptr2;
						object obj6 = obj5 >> 63;
						long value = obj6 ^ obj5;
						writer.LongVar(value);
						inputDataWordCount = config.InputDataWordCount;
					}
					num++;
					obj7 = inputDataWordCount + 4;
					ptr++;
					ptr2++;
				}
				while (num < (nint)obj7);
			}
			writer.IntVar(16383);
			return;
		}
		int num3 = config.InputDataWordCount << 2;
		object obj8 = num3 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CEC8B]");
		if ((nint)0 != 0)
		{
			if (obj8 != null)
			{
				goto IL_0208;
			}
		}
		else
		{
			_ = 1;
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_0208;
			}
		}
		bool flag2 = true;
		goto IL_0449;
		IL_0449:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40D8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F862C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		int num4 = reader.IntVar();
		if (num4 == 16383)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D41D0]");
		object obj11 = 0;
		int num5 = num4;
		int num12;
		do
		{
			long num6 = reader.LongVar();
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long num7 = num6 >> 1;
			long num8 = num6 & 1;
			int num9 = (int)(num5 & 0xFFFFFFFFL);
			int num10 = num9 << 2;
			object obj14 = -num8;
			long num11 = num7 ^ obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X19_v7 (System.Int32*)+v424 @ X21_v7 (System.Int32)*4]");
			object obj15 = 0 + num11;
			num12 = reader.IntVar();
		}
		while (num12 != 16383);
		return;
		IL_0208:
		if (ptr != null)
		{
			object obj16 = obj8 >> 30;
			bool flag4 = ptr2 == null;
			object obj17 = !flag4;
			object obj18 = ~obj17;
			bool flag5 = obj18 == null && obj16 == null;
			flag2 = flag5;
		}
		else
		{
			flag2 = false;
		}
		goto IL_0449;
	}

	internal unsafe void PoolInit(Simulation simulation, SimulationConfig config)
	{
		//IL_00a8: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got VT
		bool flag = _ptr == null;
		object obj = !flag;
		if (obj == null)
		{
			int count = config.InputDataWordCount + 4;
			int* ptr = simulation.NativeAllocInputData(count);
			_ptr = ptr;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA788]");
		object error = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64DA780]");
		object error2 = 0;
		bool condition = _sent == 0;
		Assert.Check(condition, (string)error);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		object obj5 = _player - none;
		bool condition2 = obj5 == null;
		Assert.Check(condition2, (string)error2);
		_pooled = false;
	}

	internal void PoolReset(Simulation simulation)
	{
		//IL_0045: Expected VT, but got I4
		SimulationConfig config = simulation._config;
		int wordCount = config.InputDataWordCount + 4;
		Clear(wordCount);
		_sent = 0;
		_player = (PlayerRef)0;
		_pooled = true;
	}
}
