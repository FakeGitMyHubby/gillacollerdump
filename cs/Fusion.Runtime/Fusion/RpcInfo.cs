using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Fusion;

public struct RpcInfo
{
	public readonly Tick Tick;

	public readonly PlayerRef Source;

	public readonly RpcChannel Channel;

	private readonly IntPtr _validationResult;

	public readonly bool IsInvokeLocal;

	public bool IsValidating
	{
		get
		{
			bool flag = _validationResult == (IntPtr)0;
			return !flag;
		}
	}

	private unsafe RpcInfo(Tick tick, PlayerRef source, bool isInvokeLocal, RpcChannel channel, bool* validationResult)
	{
		//IL_000b: Expected VT, but got I4
		Tick = (Tick)0;
		_validationResult = (IntPtr)0;
		Tick = tick;
		Source = source;
		IsInvokeLocal = isInvokeLocal;
		Channel = channel;
		_validationResult = (nint)validationResult;
	}

	public unsafe static RpcInfo FromLocal(NetworkRunner runner, RpcChannel channel, RpcHostMode hostMode)
	{
		//IL_0104: Expected VT, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_0053: Expected VT, but got I4
		//IL_009f: Expected native int or pointer, but got VT
		//IL_00b3: Expected native int or pointer, but got VT
		//IL_00c5: Expected native int or pointer, but got VT
		//IL_00d2: Expected native int or pointer, but got VT
		//IL_00e0: Expected native int or pointer, but got VT
		if ((object)runner != null && (object)runner._simulation != null)
		{
			PlayerRef source = (PlayerRef)((Enum)(object)runner._simulation).System_002EIConvertible_002EToUInt16((IFormatProvider)0);
			RpcInfo rpcInfo = (RpcInfo)ResolveLocalSourcePlayer(runner, source, hostMode);
			Simulation simulation = runner._simulation;
			if ((object)runner._simulation != null)
			{
				RpcInfo rpcInfo2 = default;
				((RpcInfo*)(nint)rpcInfo2)->Channel = channel;
				_ = 0;
				((RpcInfo*)(nint)rpcInfo2)->_validationResult = (IntPtr)0;
				System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)rpcInfo2)->Tick, simulation._tick);
				System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)rpcInfo2)->Source, (PlayerRef)rpcInfo);
				((RpcInfo*)(nint)rpcInfo2)->IsInvokeLocal = true;
				_ = 0;
				_ = 0;
				return rpcInfo;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (RpcInfo)ex;
	}

	public unsafe static RpcInfo FromRemote([In] ref RpcInvokeContext context, RpcHostMode hostMode, RpcChannel channel)
	{
		//IL_001e: Expected VT, but got I
		//IL_001e: Expected Obj, but got VT
		//IL_002a: Expected native int or pointer, but got VT
		//IL_0046: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected VT, but got Unknown
		//IL_006b: Expected native int or pointer, but got VT
		//IL_0079: Expected native int or pointer, but got VT
		//IL_0086: Expected native int or pointer, but got VT
		//IL_0093: Expected native int or pointer, but got VT
		RpcInvokeContext rpcInvokeContext = context;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+14]");
		RpcInfo rpcInfo = (RpcInfo)ResolveRemoteSourcePlayer((NetworkRunner)rpcInvokeContext, (PlayerRef)0, hostMode);
		RpcInfo rpcInfo2 = default;
		((RpcInfo*)(nint)rpcInfo2)->Channel = channel;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+10]");
		object obj = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+10]");
		Tick tick = (Tick)(0 & obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ X0 (Fusion.RpcInvokeContext&)+38]");
		((RpcInfo*)(nint)rpcInfo2)->_validationResult = (IntPtr)0;
		((RpcInfo*)(nint)rpcInfo2)->IsInvokeLocal = false;
		System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)rpcInfo2)->Tick, tick);
		System.Runtime.CompilerServices.Unsafe.Write(&((RpcInfo*)(nint)rpcInfo2)->Source, (PlayerRef)rpcInfo);
		return rpcInfo;
	}

	internal static PlayerRef ResolveLocalSourcePlayer(NetworkRunner runner, PlayerRef source, RpcHostMode hostMode)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_0123: Expected VT, but got Obj
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected VT, but got Unknown
		//IL_00e3: Expected Obj, but got I4
		//IL_0110: Expected VT, but got I4
		bool flag = hostMode == 0;
		object obj = !flag;
		PlayerRef result = source;
		if (obj == null)
		{
			if ((object)runner == null || (object)runner._simulation == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (PlayerRef)ex;
			}
			PlayerRef player = (PlayerRef)(source & 0xFFFFFFFFL);
			bool flag2 = runner._simulation.IsHostPlayer(player);
			bool flag3 = !flag2;
			result = source;
			if (!flag3)
			{
				bool isSinglePlayer = runner.IsSinglePlayer;
				bool flag4 = !isSinglePlayer;
				object obj2 = !flag4;
				object obj3 = ~obj2;
				result = ((obj3 != null) ? ((PlayerRef)0) : source);
			}
		}
		return result;
	}

	internal static PlayerRef ResolveRemoteSourcePlayer(NetworkRunner runner, PlayerRef source, RpcHostMode hostMode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0052: Invalid comparison between VT and I4
		//IL_0063: Expected Obj, but got I4
		//IL_001e: Invalid comparison between VT and I4
		//IL_0136: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		PlayerRef result;
		if ((nint)0 != 0)
		{
			if (source == (PlayerRef)(object)0)
			{
				goto IL_0079;
			}
			result = source;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = source == (PlayerRef)(object)0;
			object obj3 = !flag;
			result = source;
			if (obj3 == null)
			{
				goto IL_0079;
			}
		}
		goto IL_0163;
		IL_0163:
		return result;
		IL_0079:
		bool flag2 = hostMode != (RpcHostMode)1;
		result = source;
		if (!flag2)
		{
			if ((object)runner == null || (object)runner._simulation == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (PlayerRef)ex;
			}
			bool flag3 = runner._simulation.TryGetHostPlayer(out var player);
			bool flag4 = !flag3;
			result = source;
			if (!flag4)
			{
				result = player;
			}
		}
		goto IL_0163;
	}

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I4
		//IL_0053: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got Ref
		//IL_0180: Expected Obj, but got I8
		//IL_0125: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_01fa: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got Ref
		//IL_0367: Expected Obj, but got I8
		//IL_030c: Expected I, but got Obj
		//IL_031c: Expected Obj, but got I
		//IL_0345: Expected Obj, but got I
		//IL_0394: Expected Obj, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got I4
		//IL_0454: Expected Obj, but got I4
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_03e1: Expected I, but got Obj
		//IL_03f1: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04b7: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got Ref
		//IL_0556: Expected Obj, but got I4
		//IL_0566: Expected Obj, but got I4
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected Obj, but got Unknown
		//IL_04f3: Expected I, but got Obj
		//IL_0503: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_05a9: Expected Obj, but got I
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got I4
		//IL_0669: Expected Obj, but got I4
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Unknown
		//IL_05f6: Expected I, but got Obj
		//IL_0606: Expected Obj, but got I
		//IL_062f: Expected Obj, but got I
		//IL_06ac: Expected Obj, but got I
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_06f2: Expected Obj, but got Ref
		//IL_0763: Expected Obj, but got I8
		//IL_0708: Expected I, but got Obj
		//IL_0718: Expected Obj, but got I
		//IL_0741: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object[] array = default;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A38]");
			object obj2 = 0;
			bool flag = obj2 == null;
			object obj3 = 8;
			IndexOutOfRangeException ex = default;
			object obj4;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				obj4 = 0;
				if (flag2)
				{
					goto IL_07e1;
				}
			}
			if (array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
				object obj5 = 0;
				object obj6 = array + 32;
				obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object obj7 = default;
				bool flag3 = obj7 == null;
				object obj8 = default;
				obj3 = (object)(&obj8);
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
					obj4 = 0;
					if (flag4)
					{
						goto IL_07e1;
					}
				}
				object obj9 = array.Length & 0xFFFFFFFEL;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A50]");
					object obj10 = 0;
					object obj11 = array + 40;
					obj11 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag5 = obj10 == null;
					obj3 = obj7;
					if (!flag5)
					{
						nint num3 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
						obj4 = 0;
						if (flag6)
						{
							goto IL_07e1;
						}
					}
					bool flag7 = array.Length < 2;
					object obj12 = !flag7;
					object obj13 = array.Length - 2;
					bool flag8 = obj13 == null;
					object obj14 = ~obj12;
					object obj15 = obj14 | flag8;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj16 = 0;
						object obj17 = array + 48;
						obj17 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj18 = default;
						bool flag9 = obj18 == null;
						object obj19 = default;
						obj3 = (object)(&obj19);
						if (!flag9)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
							obj3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag10 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
							obj4 = 0;
							if (flag10)
							{
								goto IL_07e1;
							}
						}
						object obj20 = array.Length & 0xFFFFFFFCL;
						if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A58]");
							object obj21 = 0;
							object obj22 = array + 56;
							obj22 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag11 = obj21 == null;
							obj3 = obj18;
							if (!flag11)
							{
								nint num5 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
								obj3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag12 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
								obj4 = 0;
								if (flag12)
								{
									goto IL_07e1;
								}
							}
							bool flag13 = array.Length < 4;
							object obj23 = !flag13;
							object obj24 = array.Length - 4;
							bool flag14 = obj24 == null;
							object obj25 = ~obj23;
							object obj26 = obj25 | flag14;
							if (obj26 == null)
							{
								object obj27 = array + 64;
								obj27 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj29 = default;
								bool flag15 = obj29 == null;
								object obj30 = default;
								obj3 = (object)(&obj30);
								if (!flag15)
								{
									nint num6 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									obj3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag16 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
									obj4 = 0;
									if (flag16)
									{
										goto IL_07e1;
									}
								}
								bool flag17 = array.Length < 5;
								object obj31 = !flag17;
								object obj32 = array.Length - 5;
								bool flag18 = obj32 == null;
								object obj33 = ~obj31;
								object obj34 = obj33 | flag18;
								if (obj34 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A40]");
									object obj35 = 0;
									object obj36 = array + 72;
									obj36 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag19 = obj35 == null;
									obj3 = obj29;
									if (!flag19)
									{
										nint num7 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
										obj3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag20 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
										obj4 = 0;
										if (flag20)
										{
											goto IL_07e1;
										}
									}
									bool flag21 = array.Length < 6;
									object obj37 = !flag21;
									object obj38 = array.Length - 6;
									bool flag22 = obj38 == null;
									object obj39 = ~obj37;
									object obj40 = obj39 | flag22;
									if (obj40 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A30]");
										object obj41 = 0;
										object obj42 = array + 80;
										obj42 = obj35;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										object obj43 = default;
										bool flag23 = obj43 == null;
										object obj44 = default;
										obj3 = (object)(&obj44);
										if (!flag23)
										{
											nint num8 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
											obj3 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag24 = ex == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
											obj4 = 0;
											if (flag24)
											{
												goto IL_07e1;
											}
										}
										object obj45 = array.Length & 0xFFFFFFF8L;
										if (obj45 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8A48]");
											object format = 0;
											object obj46 = array + 88;
											obj46 = obj43;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											return string.Format((string)format, array);
										}
									}
								}
							}
						}
					}
				}
			}
			ex = new IndexOutOfRangeException();
			obj4 = obj3;
			goto IL_07e1;
		}
		goto IL_07f9;
		IL_07e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex2 = new ArgumentNullException();
		goto IL_07f9;
		IL_07f9:
		return (string)(object)new NullReferenceException();
	}

	public unsafe void Cancel()
	{
		if (_validationResult != (IntPtr)0)
		{
			void* ptr = (void*)_validationResult;
			ptr = null;
		}
	}
}
