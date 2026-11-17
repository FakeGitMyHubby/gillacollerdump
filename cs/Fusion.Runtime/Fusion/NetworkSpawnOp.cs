using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

namespace Fusion;

public struct NetworkSpawnOp
{
	private sealed class _003C_003Ec__DisplayClass5_1
	{
		public SynchronizationContext capturedContext;

		public NetworkRunnerCallbackArgs.Awaiter._003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

		internal void _003COnCompleted_003Eb__0()
		{
			//IL_00b1: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I
			//IL_00e6: Expected Obj, but got I
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_002d: Expected Obj, but got I4
			//IL_0097: Expected I, but got Obj
			//IL_004b: Expected Obj, but got I
			//IL_0065: Expected Obj, but got I
			//IL_0076: Expected I, but got Obj
			SendOrPostCallback sendOrPostCallback = default;
			while (true)
			{
				SynchronizationContext synchronizationContext = capturedContext;
				object obj = CS_0024_003C_003E8__locals1;
				if (capturedContext != null)
				{
					object obj2 = obj + 24;
					bool flag = obj2 == null;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B68]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B70]");
						object obj5 = 0;
						sendOrPostCallback._002Ector(obj, (IntPtr)obj5);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					nint num = (nint)synchronizationContext;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v72 @ X8_v6 (Il2CppClass<System.Threading.SynchronizationContext>)+188] (should have been resolved before IL gen)");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X20_v2 (System.Object)+10]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+40]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v89 @ X2_v1 (should have been resolved before IL gen)");
			}
		}
	}

	internal class AsyncOpData
	{
		public NetworkSpawnStatus Status;

		public NetworkObject Object;

		private Action m_Completed;

		public event Action Completed
		{
			add
			{
				//IL_006d: Expected Obj, but got I
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Expected Obj, but got Unknown
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj = 0;
				object obj2 = this + 32;
				Delegate obj3 = (Delegate)obj2;
				Delegate obj5 = default;
				while (true)
				{
					Delegate obj4 = Delegate.Combine(obj3, value);
					if ((object)obj4 != null && obj4 != obj)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
					bool flag = (object)obj5 != obj3;
					obj3 = obj5;
					if (!flag)
					{
						return;
					}
				}
				throw new InvalidCastException();
			}
			remove
			{
				//IL_006d: Expected Obj, but got I
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Expected Obj, but got Unknown
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj = 0;
				object obj2 = this + 32;
				Delegate obj3 = (Delegate)obj2;
				Delegate obj5 = default;
				while (true)
				{
					Delegate obj4 = Delegate.Remove(obj3, value);
					if ((object)obj4 != null && obj4 != obj)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
					bool flag = (object)obj5 != obj3;
					obj3 = obj5;
					if (!flag)
					{
						return;
					}
				}
				throw new InvalidCastException();
			}
		}

		public unsafe void Complete([In] ref NetworkSpawnOp op)
		{
			//IL_0010: Expected Obj, but got I
			//IL_04c1: Expected Obj, but got Ref
			//IL_04d1: Expected Obj, but got I
			//IL_0033: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I
			//IL_00a1: Expected Obj, but got I4
			//IL_052f: Expected I4, but got Obj
			//IL_00d3: Expected Obj, but got I
			//IL_00f0: Expected Obj, but got I
			//IL_055c: Expected Obj, but got I
			//IL_01b7: Expected Obj, but got I
			//IL_01f5: Expected Obj, but got I4
			//IL_041e: Expected Obj, but got I
			//IL_043b: Expected Obj, but got I
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected Obj, but got Unknown
			//IL_03a8: Expected Obj, but got I
			//IL_0246: Expected Obj, but got I
			//IL_0266: Expected Obj, but got I
			//IL_028f: Expected Obj, but got I4
			//IL_0589: Expected I4, but got Obj
			//IL_03dd: Expected Obj, but got I
			//IL_03ed: Expected Obj, but got I
			//IL_03fd: Expected Obj, but got I
			//IL_02f7: Expected Obj, but got I
			//IL_0320: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I
			//IL_02c3: Expected Obj, but got I
			//IL_0354: Expected Obj, but got I
			//IL_0484: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B10]");
			object error = 0;
			bool condition = Status == 0;
			Assert.Check(condition, (string)error);
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref op, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D9B18]");
			object error2 = 0;
			bool condition2;
			if (obj != null)
			{
				condition2 = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj3 = 0;
					object obj4 = obj2;
					object obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X11_v12+130]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v15+130]");
					bool flag = num < 0;
					object obj6 = !flag;
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
						object obj7 = (nint)0 + (nint)16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X11_v12+B0]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v15+130]");
						object obj8 = num2 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X11_v14-8]");
						if (0 != (nint)obj5)
						{
							obj7 = obj;
						}
						bool flag2 = obj7 == null;
						bool flag3 = !flag2;
						condition2 = flag3;
						goto IL_04ee;
					}
				}
				condition2 = false;
			}
			goto IL_04ee;
			IL_02e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7970]");
			object obj9 = 0;
			object obj10 = obj9;
			object obj12;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v26+130]");
			bool flag4 = (nint)obj11 < 0;
			object obj13 = !flag4;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X9_v9+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v26+130]");
				object obj15 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X9_v12-8]");
				if (0 == (nint)obj10)
				{
					goto IL_037b;
				}
			}
			throw new InvalidCastException();
			IL_037b:
			object obj16 = this + 24;
			object obj17;
			obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X19_v2+8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X19_v2+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v22+40]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v22+28]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v22+18]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v351 @ X2_v3 (should have been resolved before IL gen)");
			}
			return;
			IL_04ee:
			Assert.Check(condition2, (string)error2);
			NetworkSpawnStatus networkSpawnStatus = (NetworkSpawnStatus)obj;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
				networkSpawnStatus = (NetworkSpawnStatus)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj22 = 0;
					int value__ = ((NetworkSpawnStatus*)(int)networkSpawnStatus)->value__;
					object obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X10_v2 (System.Int32)+130]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X9_v5+130]");
					bool flag5 = num4 < 0;
					object obj24 = !flag5;
					if (obj24 == null)
					{
						networkSpawnStatus = (NetworkSpawnStatus)0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
						object obj25 = (nint)0 + (nint)16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X10_v2 (System.Int32)+B0]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X9_v5+130]");
						object obj26 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X10_v4-8]");
						if (0 != (nint)obj23)
						{
							obj25 = obj;
						}
						networkSpawnStatus = (NetworkSpawnStatus)obj25;
					}
				}
			}
			Status = networkSpawnStatus;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+8]");
			if ((nint)0 != 0)
			{
				if (obj17 != null)
				{
					object obj27 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X9_v9+130]");
					obj12 = 0;
					goto IL_02e7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [op @ X1 (Fusion.NetworkSpawnOp&)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj28 = 0;
					object obj27 = obj17;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X9_v9+130]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X9_v9+130]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v29+130]");
					bool flag6 = num6 < 0;
					object obj30 = !flag6;
					object obj31 = ~obj30;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X9_v9+B0]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v29+130]");
						object obj32 = num7 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X11_v8-8]");
						if (0 == (nint)obj29)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v4+18]");
							obj17 = 0;
							goto IL_037b;
						}
					}
					goto IL_02e7;
				}
			}
			goto IL_037b;
		}
	}

	public readonly NetworkRunner Runner;

	internal readonly NetworkSpawnStatus _status;

	internal readonly object _data;

	public NetworkObject Object
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_001f: Expected Obj, but got I4
			//IL_0061: Expected Obj, but got I
			//IL_0069: Expected I, but got Obj
			//IL_009a: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I
			//IL_0112: Expected I, but got Obj
			//IL_013b: Expected Obj, but got I4
			//IL_00ce: Expected Obj, but got I
			//IL_016f: Expected Obj, but got I
			NetworkObject networkObject = (NetworkObject)_data;
			if (_status != 0)
			{
				bool flag = (object)networkObject == null;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_00f2;
				}
			}
			else if (_data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
				object obj2 = 0;
				nint num = (nint)networkObject;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4 (Il2CppClass<Fusion.NetworkObject>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v15+130]");
				bool flag2 = num2 < 0;
				object obj4 = !flag2;
				object obj5 = ~obj4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4 (Il2CppClass<Fusion.NetworkObject>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v15+130]");
					object obj6 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v6-8]");
					if (0 == (nint)obj3)
					{
						networkObject = (NetworkObject)(object)((MonoBehaviour)networkObject).m_CancellationTokenSource;
						goto IL_0196;
					}
				}
				goto IL_00f2;
			}
			goto IL_0196;
			IL_0196:
			return networkObject;
			IL_00f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7970]");
			object obj7 = 0;
			object obj8 = obj7;
			nint num4 = (nint)networkObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8 (Il2CppClass<Fusion.NetworkObject>)+130]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X1_v2+130]");
			bool flag3 = num5 < 0;
			object obj9 = !flag3;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8 (Il2CppClass<Fusion.NetworkObject>)+B0]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X1_v2+130]");
				object obj11 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v11-8]");
				if (0 == (nint)obj8)
				{
					goto IL_0196;
				}
			}
			return (NetworkObject)(object)new InvalidCastException();
		}
	}

	public unsafe NetworkSpawnStatus Status
	{
		[MethodImpl((MethodImplOptions)256)]
		get
		{
			//IL_00ff: Expected Obj, but got Ref
			//IL_0107: Expected I4, but got Obj
			//IL_0121: Expected Obj, but got I4
			//IL_003e: Expected Obj, but got I
			//IL_0046: Expected I, but got Obj
			//IL_0077: Expected Obj, but got I4
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected Obj, but got Unknown
			//IL_00c0: Expected Obj, but got I
			//IL_013c: Expected I4, but got Obj
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			NetworkSpawnStatus result = (NetworkSpawnStatus)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object data = _data;
				if (_data != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj3 = 0;
					nint num = (nint)data;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X11_v3 (Il2CppClass<System.Object>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X10_v5+130]");
					bool flag2 = num2 < 0;
					object obj5 = !flag2;
					if (obj5 != null)
					{
						object obj6 = _data + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X11_v3 (Il2CppClass<System.Object>)+B0]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X10_v5+130]");
						object obj7 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X11_v5-8]");
						if (0 == (nint)obj4)
						{
							obj = obj6;
						}
						result = (NetworkSpawnStatus)obj;
						goto IL_012f;
					}
				}
				result = (NetworkSpawnStatus)0;
			}
			goto IL_012f;
			IL_012f:
			return result;
		}
	}

	public unsafe bool IsSpawned
	{
		get
		{
			//IL_011d: Expected Obj, but got Ref
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0060: Expected Obj, but got I
			//IL_0068: Expected I, but got Obj
			//IL_0099: Expected Obj, but got I4
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected Obj, but got Unknown
			//IL_00de: Expected Obj, but got I
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			object obj2 = obj;
			if (obj == null)
			{
				obj2 = _data;
				if (_data != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
					object obj3 = 0;
					nint num = (nint)obj2;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X11_v1 (Il2CppClass<System.Object>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X10_v3+130]");
					bool flag = num2 < 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj2 = null;
					}
					else
					{
						object obj6 = _data + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X11_v1 (Il2CppClass<System.Object>)+B0]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X10_v3+130]");
						object obj7 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X11_v3-8]");
						if (0 == (nint)obj4)
						{
							obj = obj6;
						}
						obj2 = obj;
					}
				}
			}
			object obj8 = obj2 - 1;
			return obj8 == null;
		}
	}

	public unsafe bool IsQueued
	{
		get
		{
			//IL_010d: Expected Obj, but got Ref
			//IL_004c: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I4
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00ce: Expected Obj, but got I
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			if (obj != null)
			{
				return false;
			}
			object data = _data;
			if (_data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
				object obj2 = 0;
				nint num = (nint)data;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X11_v3 (Il2CppClass<System.Object>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5+130]");
				bool flag = num2 < 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					object obj5 = _data + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X11_v3 (Il2CppClass<System.Object>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X10_v5+130]");
					object obj6 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X11_v5-8]");
					if (0 == (nint)obj3)
					{
						obj = obj5;
					}
					return obj == null;
				}
			}
			return true;
		}
	}

	public unsafe bool IsFailed
	{
		get
		{
			//IL_0222: Expected Obj, but got Ref
			//IL_0041: Expected Obj, but got I
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0070: Expected I, but got Obj
			//IL_0099: Expected Obj, but got I4
			//IL_0171: Expected I, but got Obj
			//IL_019a: Expected Obj, but got I4
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected Obj, but got Unknown
			//IL_01e3: Expected Obj, but got I
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected Obj, but got Unknown
			//IL_00dd: Expected Obj, but got I
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Expected Obj, but got Unknown
			//IL_0277: Expected Obj, but got I4
			//IL_0299: Expected Obj, but got I4
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			bool flag;
			if (obj != null)
			{
				object obj2 = obj - 1;
				flag = obj2 == null;
				goto IL_02c3;
			}
			object data = _data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7968]");
			object obj3 = 0;
			bool result;
			if (_data != null)
			{
				object obj4 = obj3;
				nint num = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X13_v6 (Il2CppClass<System.Object>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X12_v6+130]");
				bool flag2 = num2 < 0;
				object obj5 = !flag2;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
					object obj7 = _data + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X13_v6 (Il2CppClass<System.Object>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X12_v6+130]");
					object obj8 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X13_v8-8]");
					if (0 != (nint)obj4)
					{
						obj7 = obj;
					}
					object obj9 = obj7 - 1;
					bool flag3 = obj9 == null;
					bool flag4 = !flag3;
					object obj10 = !flag3;
					object obj11 = ~obj10;
					bool flag5 = obj11 == null && obj == null;
					object obj12 = !flag5;
					result = flag4;
					if (obj12 != null)
					{
						goto IL_023f;
					}
				}
			}
			object data2 = _data;
			if (_data != null)
			{
				object obj13 = obj3;
				nint num4 = (nint)data2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X11_v6 (Il2CppClass<System.Object>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X10_v6+130]");
				bool flag6 = num5 < 0;
				object obj14 = !flag6;
				if (obj14 != null)
				{
					object obj15 = _data + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X11_v6 (Il2CppClass<System.Object>)+B0]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X10_v6+130]");
					object obj16 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X11_v8-8]");
					if (0 == (nint)obj13)
					{
						obj = obj15;
					}
					flag = obj == null;
					goto IL_02c3;
				}
			}
			result = false;
			goto IL_023f;
			IL_02c3:
			bool flag7 = !flag;
			result = flag7;
			goto IL_023f;
			IL_023f:
			return result;
		}
	}

	internal unsafe NetworkSpawnOp(NetworkRunner runner, NetworkSpawnStatus status, NetworkObject data)
	{
		//IL_001f: Expected Obj, but got Ref
		Runner = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	internal unsafe NetworkSpawnOp(NetworkRunner runner, NetworkSpawnStatus status, AsyncOpData data)
	{
		//IL_001f: Expected Obj, but got Ref
		Runner = runner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	[MethodImpl((MethodImplOptions)256)]
	internal NetworkObject ConsumeSyncSpawn(NetworkObjectTypeId typeId)
	{
		//IL_0170: Expected Obj, but got I4
		//IL_0180: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0046: Expected VT, but got Obj
		//IL_004e: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I
		//IL_00cb: Invalid comparison between I and VT
		bool flag = _status < (NetworkSpawnStatus)1;
		object obj = !flag;
		object obj2 = _status - 1;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		NetworkObjectTypeId networkObjectTypeId = typeId;
		nint num = (nint)_status;
		if (obj4 == null)
		{
			NetworkObject data = (NetworkObject)_data;
			if (_data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7970]");
				object obj5 = 0;
				networkObjectTypeId = (NetworkObjectTypeId)obj5;
				num = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4 (Il2CppClass<Fusion.NetworkObject>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X1_v1 (Fusion.NetworkObjectTypeId)+130]");
				bool flag3 = num2 < 0;
				object obj6 = !flag3;
				object obj7 = ~obj6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4 (Il2CppClass<Fusion.NetworkObject>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X1_v1 (Fusion.NetworkObjectTypeId)+130]");
					object obj8 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v11-8]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v11-8]");
					if ((object)0 == (object)networkObjectTypeId)
					{
						goto IL_00e2;
					}
				}
				throw new InvalidCastException();
			}
			goto IL_00e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28AA684");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		NetworkObjectSpawnException ex = default;
		NetworkObjectTypeId? id = default;
		ex._002Ector((NetworkSpawnStatus)num, id);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
		return (NetworkObject)(object)new ArgumentNullException();
		IL_00e2:
		return (NetworkObject)_data;
	}

	[MethodImpl((MethodImplOptions)256)]
	internal unsafe NetworkSpawnStatus ConsumeSyncSpawn(out NetworkObject obj)
	{
		//IL_0015: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_00c3: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I
		object data = _data;
		ref NetworkObject reference;
		if (_data != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D7970]");
			object obj2 = 0;
			nint num = (nint)data;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X10_v3 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6 (System.Object)+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X10_v3 (Il2CppClass<System.Object>)+B0]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6 (System.Object)+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X10_v6-8]");
				if (0 == (nint)obj3)
				{
					reference = ref *(NetworkObject*)_data;
					obj3 = obj2;
					nint num4 = (nint)data;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v6 (Il2CppClass<System.Object>)+130]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6 (System.Object)+130]");
					bool flag2 = num5 < 0;
					object obj7 = !flag2;
					object obj8 = ~obj7;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v6 (Il2CppClass<System.Object>)+B0]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6 (System.Object)+130]");
						object obj9 = num6 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X9_v8-8]");
						if (0 == (nint)obj3)
						{
							goto IL_018e;
						}
					}
				}
			}
			data = obj3;
			throw new InvalidCastException();
		}
		reference = ref *(NetworkObject*)null;
		goto IL_018e;
		IL_018e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return _status;
	}

	public unsafe NetworkRunnerCallbackArgs.Awaiter GetAwaiter()
	{
		//IL_000f: Expected VT, but got Obj
		//IL_000a: Expected native int or pointer, but got VT
		NetworkRunnerCallbackArgs.Awaiter awaiter = default;
		System.Runtime.CompilerServices.Unsafe.Write(&((NetworkRunnerCallbackArgs.Awaiter*)(nint)awaiter)->_op, (NetworkSpawnOp)Runner);
		_ = _data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		NetworkRunnerCallbackArgs.Awaiter result = default;
		return result;
	}
}
