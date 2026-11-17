using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Fusion;
using Fusion.Sockets;
using UnityEngine;

public class GillaNetWatch : MonoBehaviour, _0021_00210, _00210
{
	public sealed class Single<T> where T : NetworkBehaviour
	{
		private const float Grace = default(float);

		private readonly List<T> all;

		private T current;

		private float seenAt;

		private int frame;

		public T Current
		{
			get
			{
				//IL_0046: Expected Obj, but got I
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected Obj, but got Unknown
				//IL_007b: Expected Obj, but got I4
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0010: Expected Obj, but got Unknown
				//IL_00c6: Expected Obj, but got I4
				//IL_0ac7: Expected Obj, but got I4
				//IL_0120: Expected Obj, but got I4
				//IL_014f: Expected Obj, but got I
				//IL_016d: Expected Obj, but got I4
				//IL_0176: Expected Obj, but got I4
				//IL_09f4: Expected Obj, but got I4
				//IL_0379: Expected Obj, but got I
				//IL_03a3: Expected Obj, but got I4
				//IL_02f3: Expected Obj, but got I4
				//IL_0c48: Expected Obj, but got I4
				//IL_04c5: Expected Obj, but got I
				//IL_04d5: Expected Obj, but got I
				//IL_03d1: Expected Obj, but got I
				//IL_03ef: Expected Obj, but got I4
				//IL_042c: Expected Obj, but got I4
				//IL_0449: Invalid comparison between F4 and I4
				//IL_0460: Unknown result type (might be due to invalid IL or missing references)
				//IL_0465: Expected Obj, but got Unknown
				//IL_01be: Expected Obj, but got I
				//IL_050b: Expected Obj, but got I
				//IL_0548: Expected Obj, but got I4
				//IL_047c: Expected Obj, but got I4
				//IL_0aff: Expected Obj, but got I4
				//IL_0208: Expected Obj, but got I
				//IL_0224: Expected Obj, but got I4
				//IL_022d: Expected Obj, but got I4
				//IL_0626: Expected Obj, but got I
				//IL_0648: Expected Obj, but got I4
				//IL_068a: Expected Obj, but got I4
				//IL_05c5: Expected Obj, but got I
				//IL_05d5: Expected Obj, but got I
				//IL_05ec: Expected Obj, but got I4
				//IL_06c7: Expected Obj, but got I4
				//IL_0277: Unknown result type (might be due to invalid IL or missing references)
				//IL_027c: Expected Obj, but got Unknown
				//IL_0294: Expected Obj, but got I4
				//IL_029d: Expected Obj, but got I4
				//IL_02ad: Expected Obj, but got I
				//IL_070c: Expected Obj, but got I4
				//IL_09b9: Expected Obj, but got I4
				//IL_02cc: Expected Obj, but got I4
				//IL_02d5: Expected Obj, but got I4
				//IL_02e5: Expected Obj, but got I
				//IL_076f: Expected Obj, but got I
				//IL_0c85: Expected Obj, but got I
				//IL_07f9: Expected Obj, but got I
				//IL_07b3: Expected Obj, but got I8
				//IL_0816: Expected Obj, but got I
				//IL_0cba: Expected Obj, but got I
				//IL_08a9: Expected Obj, but got I4
				//IL_085a: Expected Obj, but got I8
				//IL_08cc: Expected Obj, but got I
				//IL_089b: Expected Obj, but got I8
				//IL_0be6: Expected Obj, but got I
				//IL_0c10: Expected Obj, but got I4
				//IL_08b7: Expected Obj, but got I4
				//IL_0911: Expected VT, but got I
				//IL_0949: Expected VT, but got I
				//IL_096a: Expected Obj, but got I4
				int frameCount = Time.frameCount;
				object obj;
				if (frame == frameCount)
				{
					obj = this + 24;
					goto IL_0a98;
				}
				int frameCount2 = Time.frameCount;
				frame = frameCount2;
				float unscaledTime = Time.unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj2 = 0;
				obj = this + 24;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = (UnityEngine.Object)obj != null;
				UnityEngine.Object obj5 = (UnityEngine.Object)obj;
				bool flag3 = !flag2;
				object obj6 = 0;
				UnityEngine.Object obj7 = null;
				object obj15 = default;
				if (!flag3)
				{
					if (obj != null)
					{
						object obj8 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v84+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X22_v5 (UnityEngine.Object)+40]");
						bool flag5 = (UnityEngine.Object)0 == null;
						bool flag6 = !flag5;
						object obj10 = !flag6;
						obj6 = 0;
						obj7 = null;
						if (obj10 != null)
						{
							goto IL_02ea;
						}
						object obj11 = obj;
						if (obj != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v55+40]");
							UnityEngine.Object obj12 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v55+40]");
							if ((nint)0 != 0)
							{
								object obj13 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v90+E4]");
								bool flag7 = (nint)0 == 0;
								object obj14 = !flag7;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X22_v23 (UnityEngine.Object)+30]");
								bool flag8 = (UnityEngine.Object)0;
								bool flag9 = !flag8;
								obj15 = 109891584;
								obj6 = 0;
								obj7 = null;
								if (!flag9)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X22_v23 (UnityEngine.Object)+30]");
									if ((nint)0 == 0)
									{
										goto IL_0a60;
									}
									ArgumentNullException ex = new ArgumentNullException();
									object obj16 = ex & 1;
									bool flag10 = obj16 == null;
									obj15 = 109891584;
									obj6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v55+40]");
									obj7 = (UnityEngine.Object)0;
									if (!flag10)
									{
										obj5 = (UnityEngine.Object)obj;
										obj15 = 109891584;
										obj6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v55+40]");
										obj7 = (UnityEngine.Object)0;
										goto IL_0a9d;
									}
								}
								goto IL_02ea;
							}
						}
					}
					goto IL_0a60;
				}
				goto IL_0a9d;
				IL_02ea:
				obj = 0;
				obj5 = null;
				goto IL_0a9d;
				IL_0a9d:
				object obj17 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v14+E4]");
				bool flag11 = (nint)0 == 0;
				object obj18 = !flag11;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag12 = obj5 != null;
				bool flag13 = !flag12;
				UnityEngine.Object obj19 = null;
				float num = unscaledTime;
				if (!flag13)
				{
					object obj20 = obj;
					if (obj == null)
					{
						goto IL_0a60;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
					object obj21 = 0;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v76+E4]");
					bool flag14 = (nint)0 == 0;
					object obj23 = !flag14;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v51+40]");
					bool flag15 = GillaNetGuard.IsMasters((NetworkObject)0);
					bool flag16 = !flag15;
					object obj24 = !flag16;
					if (obj24 != null)
					{
						goto IL_0a51;
					}
					num = unscaledTime - seenAt;
					bool flag17 = (double)num < 3.0;
					object obj25 = !flag17;
					float num2 = num - 3f;
					bool flag18 = num2 == 0f;
					object obj26 = ~obj25;
					object obj27 = obj26 | flag18;
					if (obj27 != null)
					{
						goto IL_0a98;
					}
					obj = 0;
					obj19 = null;
				}
				List<T> list = all;
				UnityEngine.Object obj29;
				if ((object)all != null)
				{
					int num3 = list._size;
					if (list._size < 1)
					{
						object obj28 = 0;
						obj29 = null;
						goto IL_0c1e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5468]");
					object obj31 = 0;
					obj29 = null;
					IntPtr intPtr2 = default;
					IntPtr intPtr = intPtr2;
					object obj42 = default;
					object obj44 = default;
					Span<int> span = default;
					while ((object)all != null)
					{
						nint num4 = 0;
						num3--;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v12 (Il2CppClass<GillaNetWatch+Single`1>)+A8]");
						object obj32 = 0;
						System.__Canon _Canon = ((List<System.__Canon>)(object)all).get_Item(num3);
						object obj33 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v14+E4]");
						bool flag19 = (nint)0 == 0;
						object obj34 = !flag19;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if ((UnityEngine.Object)(object)_Canon == null)
						{
							if ((object)all == null)
							{
								break;
							}
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v48 (Il2CppClass<GillaNetWatch+Single`1>)+A8]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v49+48]");
							object obj28 = 0;
							((List<System.__Canon>)(object)all).RemoveAt(num3);
							obj19 = (UnityEngine.Object)num3;
						}
						else
						{
							if (_Canon == null)
							{
								break;
							}
							object obj36 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v29 (System.__Canon)+40]");
							NetworkObject networkObject = (NetworkObject)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v34+E4]");
							bool flag20 = (nint)0 == 0;
							object obj37 = !flag20;
							if (obj37 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag21 = GillaNetGuard.IsMasters(networkObject);
							bool flag22 = !flag21;
							object obj28 = 0;
							obj19 = null;
							if (!flag22)
							{
								object obj38 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X0_v38+E4]");
								bool flag23 = (nint)0 == 0;
								object obj39 = !flag23;
								if (obj39 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag24 = obj29 == null;
								bool flag25 = !flag24;
								object obj40 = !flag25;
								object obj41 = obj42;
								object obj43 = obj44;
								NetworkObject networkObject2 = networkObject;
								object obj45 = obj30;
								object obj46 = obj15;
								UnityEngine.Object obj47 = null;
								object obj48 = obj2;
								IntPtr intPtr3 = intPtr;
								object obj49 = obj31;
								if (obj40 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v29 (System.__Canon)+40]");
									object obj50 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v29 (System.__Canon)+40]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X27_v8+20]");
									object obj51 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X27_v8+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X25_v7+4]");
										object obj52 = 0 & -9223372036854775808L;
										if (obj52 != null)
										{
											System.ThrowHelper.ThrowArgumentOutOfRangeException();
										}
									}
									if (span.IsEmpty)
									{
										networkObject2 = null;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X27_v8+20]");
										object obj53 = 0;
										networkObject2 = (NetworkObject)obj53;
									}
									if ((object)obj29 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X22_v14 (UnityEngine.Object)+40]");
									obj43 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X22_v14 (UnityEngine.Object)+40]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X25_v6+20]");
									object obj54 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X25_v6+20]");
									object obj56;
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X24_v9+4]");
										object obj55 = 0 & -9223372036854775808L;
										if (obj55 != null)
										{
											System.ThrowHelper.ThrowArgumentOutOfRangeException();
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X24_v9+4]");
										obj56 = 0 & 0xFFFFFFFFL;
									}
									else
									{
										obj56 = 0;
									}
									obj47 = (UnityEngine.Object)obj31;
									if (span.IsEmpty)
									{
										obj46 = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X25_v6+20]");
										object obj57 = 0;
										obj46 = obj57;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
									object obj58 = 0;
									object obj59 = obj58;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v53+E4]");
									bool flag26 = (nint)0 == 0;
									object obj60 = !flag26;
									if (obj60 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag27 = System.Runtime.CompilerServices.Unsafe.As<NetworkObject, UIntPtr>(ref networkObject2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46);
									obj41 = obj56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X25_v6+20]");
									span = (Span<int>)0;
									obj45 = obj30;
									obj48 = obj2;
									intPtr3 = intPtr2;
									obj49 = obj31;
									obj42 = obj56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X25_v6+20]");
									span = (Span<int>)0;
									obj44 = obj43;
									networkObject = networkObject2;
									obj15 = obj46;
									obj28 = 0;
									obj19 = obj47;
									intPtr = intPtr2;
									if (flag27)
									{
										goto IL_0b36;
									}
								}
								obj42 = obj41;
								obj44 = obj43;
								networkObject = networkObject2;
								obj30 = obj45;
								obj15 = obj46;
								obj28 = 0;
								obj19 = obj47;
								obj29 = (UnityEngine.Object)(object)_Canon;
								obj2 = obj48;
								intPtr = intPtr3;
								obj31 = obj49;
							}
						}
						goto IL_0b36;
						IL_0b36:
						if (num3 > 0)
						{
							continue;
						}
						goto IL_0c1e;
					}
				}
				goto IL_0a60;
				IL_0a51:
				seenAt = unscaledTime;
				goto IL_0a98;
				IL_0a60:
				return (T)(object)new NullReferenceException();
				IL_0c1e:
				object obj61 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v20+E4]");
				bool flag28 = (nint)0 == 0;
				object obj62 = !flag28;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj29 != null)
				{
					current = (T)obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					goto IL_0a51;
				}
				goto IL_0a98;
				IL_0a98:
				return (T)obj;
			}
		}

		public void Add(T t)
		{
			//IL_0010: Expected Obj, but got I
			//IL_01b7: Expected Obj, but got I4
			//IL_018c: Expected I4, but got I8
			//IL_0065: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I4
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected Obj, but got Unknown
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)t != (UnityEngine.Object)null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v7 (Il2CppClass<GillaNetWatch+Single`1>)+A8]");
				object obj4 = 0;
				bool flag2 = ((List<System.__Canon>)(object)all).Contains((System.__Canon)(object)t);
				bool flag3 = !flag2;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					List<System.__Canon> list = (List<System.__Canon>)(object)all;
					System.__Canon[] items = list._items;
					int version = list._version + 1;
					list._version = version;
					bool flag4 = list._size < items.Length;
					object obj6 = !flag4;
					if (obj6 == null)
					{
						object obj7 = items + list._size;
						int size = list._size + 1;
						list._size = size;
						object obj8 = obj7 + 32;
						obj8 = t;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						list.AddWithResize((System.__Canon)(object)t);
					}
				}
			}
			frame = -1;
		}

		public void Remove(T t)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_0068: Expected Obj, but got I4
			//IL_00d0: Expected I4, but got I8
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (Il2CppClass<GillaNetWatch+Single`1>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj2 = 0;
			bool flag = ((List<System.__Canon>)(object)all).Remove((System.__Canon)(object)t);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)current == (UnityEngine.Object)t)
			{
				current = null;
			}
			frame = -1;
		}

		public void Clear()
		{
			//IL_0096: Expected I4, but got I8
			List<T> list = all;
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
			}
			current = null;
			frame = -1;
		}

		public Single()
		{
			//IL_0016: Expected Obj, but got I
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			//IL_005c: Expected I4, but got I8
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Il2CppClass<GillaNetWatch+Single`1>)+A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<System.__Canon> list = default;
			list._002Ector();
			object obj2 = this + 16;
			obj2 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			frame = -1;
			base._002Ector();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__19_0;

		public static Action<string> _003C_003E9__19_1;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DB0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj2 = default;
			obj2._002Ector();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+A0]");
			object obj4 = 0;
			obj4 = obj2;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		internal void _003CFusion_002EINetworkRunnerCallbacks_002EOnShutdown_003Eb__19_0(string _)
		{
		}

		internal void _003CFusion_002EINetworkRunnerCallbacks_002EOnShutdown_003Eb__19_1(string why)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0079: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EC0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj2 = 0;
			string message = (string)obj + why;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
		}
	}

	private static string LastWhy__BackingField;

	private static int reported;

	private const int ReportMost = default(int);

	private float joinedAt;

	private string lost;

	private string failed;

	private readonly SortedDictionary<int, string> inRoom;

	private const int LoopDrops = default(int);

	private const float LoopWindow = default(float);

	private const float LoopAvoid = default(float);

	private static readonly Dictionary<string, List<float>> droppedBy;

	private bool ended;

	public static string LastWhy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+A0]");
			return (string)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+A0]");
			object obj4 = 0;
			obj4 = value;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+A0]");
		object obj7 = 0;
		obj7 = obj3;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9+A0]");
		object obj10 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v10+10]");
		((Dictionary<System.__Canon, System.__Canon>)0).Clear();
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnConnectedToServer(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj2 = 0;
		float unscaledTime = Time.unscaledTime;
		object obj3 = obj;
		joinedAt = unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7+A0]");
		object obj7 = 0;
		obj7 = obj2;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private unsafe void Fusion_002EINetworkRunnerCallbacks_002EOnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0090: Expected Obj, but got Ref
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got Ref
		//IL_0060: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj2 = 0;
		object obj3 = default;
		string text = ((Enum)(&obj3)).ToString();
		object obj4 = this + 40;
		obj4 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = default;
		string text2 = ((Enum)(&obj5)).ToString();
		string message = (string)obj + text2;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
	}

	private unsafe void Fusion_002EINetworkRunnerCallbacks_002EOnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0090: Expected Obj, but got Ref
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got Ref
		//IL_0060: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj2 = 0;
		object obj3 = default;
		string text = ((Enum)(&obj3)).ToString();
		object obj4 = this + 48;
		obj4 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = default;
		string text2 = ((Enum)(&obj5)).ToString();
		string message = (string)obj + text2;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
	}

	private unsafe void Fusion_002EINetworkRunnerCallbacks_002EOnShutdown(NetworkRunner runner, ShutdownReason reason)
	{
		//IL_0026: Invalid comparison between F4 and I4
		//IL_0076: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I4
		//IL_0bff: Expected Obj, but got I
		//IL_0c19: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_0c38: Invalid comparison between F4 and I4
		//IL_0164: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_0c71: Expected Obj, but got I
		//IL_0c9b: Expected Obj, but got I4
		//IL_01d0: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_0210: Expected I4, but got F4
		//IL_0301: Expected Obj, but got I
		//IL_11dc: Invalid comparison between F4 and I4
		//IL_02ad: Expected Obj, but got I
		//IL_047b: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I4
		//IL_04dc: Expected Obj, but got I4
		//IL_04f9: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I4
		//IL_0cbe: Expected Obj, but got I
		//IL_0ce8: Expected Obj, but got I4
		//IL_0d20: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got Ref
		//IL_040d: Expected I4, but got Obj
		//IL_0416: Expected Obj, but got I4
		//IL_1200: Expected Obj, but got I
		//IL_1232: Expected Obj, but got I
		//IL_1242: Expected Obj, but got I
		//IL_045e: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I
		//IL_038a: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I4
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3c: Expected Obj, but got Unknown
		//IL_0d4c: Expected Obj, but got I
		//IL_0d6f: Expected Obj, but got Ref
		//IL_05d3: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I
		//IL_0604: Expected Obj, but got I
		//IL_05ae: Expected Obj, but got I
		//IL_05be: Expected Obj, but got I
		//IL_0d88: Expected Obj, but got I
		//IL_0db2: Expected Obj, but got I4
		//IL_0641: Invalid comparison between F4 and I4
		//IL_0e1a: Expected Obj, but got I
		//IL_0e34: Expected Obj, but got I
		//IL_0e55: Expected Obj, but got I
		//IL_0e7f: Expected Obj, but got I4
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddd: Expected Obj, but got Unknown
		//IL_0df7: Expected Obj, but got I4
		//IL_0eb7: Expected Obj, but got I4
		//IL_1277: Expected Obj, but got I
		//IL_1287: Expected Obj, but got I
		//IL_07d4: Expected Obj, but got I
		//IL_0793: Expected Obj, but got I4
		//IL_0854: Expected Obj, but got I
		//IL_0800: Expected Obj, but got I
		//IL_0f1c: Expected Obj, but got I4
		//IL_08e1: Expected Obj, but got I
		//IL_12df: Expected Obj, but got I
		//IL_1300: Expected Obj, but got I
		//IL_132a: Expected Obj, but got I4
		//IL_088d: Expected Obj, but got I
		//IL_0f44: Expected Obj, but got I
		//IL_0f54: Expected Obj, but got I
		//IL_092a: Expected Obj, but got I
		//IL_0f95: Expected Obj, but got I
		//IL_0fbf: Expected Obj, but got I4
		//IL_0915: Expected Obj, but got I
		//IL_0957: Expected Obj, but got I
		//IL_0967: Expected Obj, but got I
		//IL_0981: Expected Obj, but got I4
		//IL_09ad: Expected Obj, but got I
		//IL_0ffc: Expected Obj, but got I
		//IL_09c2: Expected Obj, but got I
		//IL_09eb: Expected Obj, but got I
		//IL_0a1c: Expected Obj, but got I
		//IL_0a46: Expected Obj, but got I4
		//IL_1022: Expected Obj, but got I
		//IL_1032: Expected Obj, but got I
		//IL_1042: Expected Obj, but got I
		//IL_1064: Expected Obj, but got I4
		//IL_106c: Expected I, but got Obj
		//IL_135a: Expected Obj, but got I4
		//IL_1102: Expected Obj, but got I
		//IL_1112: Expected Obj, but got I
		//IL_1134: Expected Obj, but got I4
		//IL_0a8d: Expected Obj, but got I4
		//IL_0b66: Expected Obj, but got I
		//IL_0b90: Expected Obj, but got I4
		//IL_108a: Expected Obj, but got I
		//IL_10a4: Expected Obj, but got I
		//IL_10ac: Expected I, but got Obj
		//IL_10bd: Expected I, but got Obj
		//IL_10db: Expected Obj, but got I
		//IL_0b21: Expected Obj, but got I4
		//IL_0ad3: Expected Obj, but got I4
		//IL_0abd: Expected Obj, but got I
		//IL_1152: Expected Obj, but got I
		//IL_116c: Expected Obj, but got I
		//IL_1174: Expected I, but got Obj
		//IL_1185: Expected I, but got Obj
		//IL_11a3: Expected Obj, but got I
		//IL_11be: Expected Obj, but got I4
		//IL_0b51: Expected Obj, but got I
		if (~(ended ? 1u : 0u) == 0)
		{
			return;
		}
		float num = joinedAt;
		ended = true;
		bool flag = joinedAt < 0f;
		float num2 = -1f;
		if (!flag)
		{
			num = Time.unscaledTime;
			num2 = num - joinedAt;
		}
		string text = lost;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE138]");
		object obj = 0;
		bool flag2 = text._stringLength < 0;
		bool flag3 = text._stringLength == 0;
		int num3 = text._stringLength ^ text._stringLength;
		int num4 = text._stringLength & num3;
		bool flag4 = num4 < 0;
		bool flag5 = flag2 == flag4;
		object obj2 = !flag3;
		object obj3 = flag5 & obj2;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			object obj5 = 40;
		}
		else
		{
			object obj5 = 48;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GillaNetWatch)+v412 @ X8_v9]");
		string text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DE0]");
		object format = 0;
		object arg = default;
		string text3 = string.Format((string)format, arg);
		string text6;
		if (text2._stringLength > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7260]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7210]");
			object obj7 = 0;
			string text4 = (string)obj7;
			string text5 = (string)obj6 + text2 + (string)obj7;
			text6 = text5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj8 = 0;
			text6 = (string)obj8;
			string text4 = null;
		}
		string text8;
		ShutdownReason shutdownReason;
		if (!(num2 < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DC8]");
			object format2 = 0;
			object arg2 = default;
			string text7 = string.Format((string)format2, arg2);
			text8 = text7;
			shutdownReason = (ShutdownReason)num2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DD8]");
			object obj10 = 0;
			text8 = (string)obj10;
			shutdownReason = reason;
		}
		string message = text3 + text6 + text8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		if (reason == 0)
		{
			return;
		}
		SessionInfo sessionInfo = runner.SessionInfo__BackingField;
		string text9;
		if (~(sessionInfo._isValid ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj14 = 0;
			text9 = (string)((sessionInfo.Name__BackingField != null) ? sessionInfo.Name__BackingField : obj14);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj15 = 0;
			text9 = (string)obj15;
		}
		string text13;
		if (!(num2 < 0f))
		{
			if (reason == (ShutdownReason)4 && text9._stringLength >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
				object obj16 = 0;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v140+E4]");
				bool flag7 = (nint)0 == 0;
				object obj18 = !flag7;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NoteDrop(text9);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DF0]");
			object obj19 = 0;
			bool flag8 = text2._stringLength > 0;
			object obj20 = 0;
			string text10 = text2;
			if (!flag8)
			{
				string text11 = ((Enum)(&shutdownReason)).ToString();
				shutdownReason = (ShutdownReason)obj;
				obj20 = 0;
				text10 = text11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X0_v131+E4]");
			bool flag9 = (nint)0 == 0;
			object obj23 = !flag9;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text12 = Words(text10);
			text13 = (string)obj19 + text12;
			object obj24 = 0;
			string text14 = text12;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v124+E4]");
			bool flag10 = (nint)0 == 0;
			object obj27 = !flag10;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text13 = NetworkBootstrap.JoinWhy(reason, text2);
			object obj24 = 0;
			string text14 = text2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
		object obj28 = 0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v16+E4]");
		bool flag11 = (nint)0 == 0;
		object obj30 = !flag11;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj31 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj32 = !flag12;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj28;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v20+A0]");
		object obj33 = 0;
		obj33 = text13;
		object obj34 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj35 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v23+A0]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v29+8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v29+8]");
		if ((nint)0 > (nint)19)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v23+E4]");
		bool flag13 = (nint)0 == 0;
		object obj38 = !flag13;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj39 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v118+A0]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v29+8]");
			obj37 = 0;
		}
		object obj40 = obj37 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA0]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		string value = ((Enum)(&shutdownReason)).ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC3B8]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBE88]");
		object obj42 = 0;
		dictionary.Add((System.__Canon)key, (System.__Canon)(object)value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DF8]");
		object key2 = 0;
		dictionary.Add((System.__Canon)key2, (System.__Canon)(object)text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj43 = 0;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v32+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		double num5;
		float num7 = default;
		double num8;
		float num6;
		if (num2 < 0f)
		{
			if ((double)num2 == -0.5)
			{
				num5 = -1.0;
				num6 = num7;
				goto IL_0dc0;
			}
			num6 = num2 + -0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			num8 = -0.5;
		}
		else
		{
			if ((double)num2 == 0.5)
			{
				num5 = 1.0;
				num6 = num7;
				goto IL_0dc0;
			}
			num6 = num2 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			num8 = 0.5;
		}
		goto IL_0e0a;
		IL_0e0a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DC0]");
		object key3 = 0;
		System.__Canon value2 = default;
		dictionary.Add((System.__Canon)key3, value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
		object obj47 = 0;
		object obj48 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X0_v39+E4]");
		bool flag15 = (nint)0 == 0;
		object obj49 = !flag15;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj50 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v43+E4]");
		bool flag16 = (nint)0 == 0;
		object obj51 = !flag16;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj50 = obj47;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v43+A0]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBF08]");
		object key4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v50+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v43+E4]");
			bool flag17 = (nint)0 == 0;
			object obj53 = !flag17;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj54 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ X0_v99+E4]");
			bool flag18 = (nint)0 == 0;
			object obj55 = !flag18;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		System.__Canon value3 = default;
		dictionary.Add((System.__Canon)key4, value3);
		SessionInfo sessionInfo2 = runner.SessionInfo__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEF8]");
		object key5 = 0;
		System.__Canon value4;
		if (~(sessionInfo2._isValid ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj56 = 0;
			value4 = (System.__Canon)((sessionInfo2.Region__BackingField != null) ? sessionInfo2.Region__BackingField : obj56);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj57 = 0;
			value4 = (System.__Canon)obj57;
		}
		dictionary.Add((System.__Canon)key5, value4);
		SessionInfo sessionInfo3 = runner.SessionInfo__BackingField;
		System.__Canon value5;
		if (~(sessionInfo3._isValid ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj58 = 0;
			value5 = (System.__Canon)((sessionInfo3.Name__BackingField != null) ? sessionInfo3.Name__BackingField : obj58);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj59 = 0;
			value5 = (System.__Canon)obj59;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEE8]");
		object key6 = 0;
		dictionary.Add((System.__Canon)key6, value5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
		object obj60 = 0;
		object obj61 = obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v51+E4]");
		bool flag19 = (nint)0 == 0;
		object obj62 = !flag19;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj61 = obj60;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v51+A0]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E10]");
		object key7 = 0;
		object value6;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E00]");
			value6 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E08]");
			value6 = 0;
		}
		dictionary.Add((System.__Canon)key7, (System.__Canon)value6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj64 = 0;
		object obj65 = obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v53+E4]");
		bool flag20 = (nint)0 == 0;
		object obj66 = !flag20;
		if (obj66 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isFocused = Application.isFocused;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D0C60]");
		object value7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DB8]");
		object key8 = 0;
		bool flag21 = !isFocused;
		object obj67 = !flag21;
		object obj68 = ~obj67;
		if (obj68 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DE8]");
			value7 = 0;
		}
		dictionary.Add((System.__Canon)key8, (System.__Canon)value7);
		string value8 = Host(runner);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E18]");
		object key9 = 0;
		dictionary.Add((System.__Canon)key9, (System.__Canon)(object)value8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D98]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4351AFC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E20]");
		object obj70 = 0;
		object obj71 = obj42;
		System.__Canon _Canon = (System.__Canon)obj70;
		System.__Canon _Canon2 = default;
		dictionary.Add((System.__Canon)obj70, _Canon2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DB0]");
		object obj72 = 0;
		object obj73 = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v69+E4]");
		bool flag22 = (nint)0 == 0;
		object obj74 = !flag22;
		if (obj74 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj73 = obj72;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v69+A0]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DD0]");
		object function = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X8_v91+8]");
		Action<string> done = (Action<string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ X8_v91+8]");
		bool flag23 = (nint)0 == 0;
		object obj76 = !flag23;
		nint num9 = (nint)_Canon2;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v69+E4]");
			bool flag24 = (nint)0 == 0;
			object obj77 = !flag24;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj78 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X8_v95+A0]");
				obj75 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DA0]");
			object obj80 = 0;
			num9 = (nint)obj80;
			Action<System.__Canon> action = default;
			action._002Ector(obj75, (IntPtr)obj80);
			object obj81 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1097 @ X8_v94+A0]");
			object obj82 = (nint)0 + (nint)8;
			obj82 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj73 = obj72;
			obj71 = 0;
			_Canon = (System.__Canon)(object)action;
			done = (Action<string>)action;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v69+E4]");
		bool flag25 = (nint)0 == 0;
		object obj83 = !flag25;
		if (obj83 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj73 = obj72;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v69+A0]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v85+10]");
		Action<string> action2 = (Action<string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ X8_v85+10]");
		bool flag26 = (nint)0 == 0;
		object obj85 = !flag26;
		if (obj85 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X0_v69+E4]");
			bool flag27 = (nint)0 == 0;
			object obj86 = !flag27;
			if (obj86 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj87 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X8_v89+A0]");
				obj84 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2DA8]");
			object obj89 = 0;
			num9 = (nint)obj89;
			Action<System.__Canon> action3 = default;
			action3._002Ector(obj84, (IntPtr)obj89);
			object obj90 = obj72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v88+A0]");
			object obj91 = (nint)0 + (nint)16;
			obj91 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj71 = 0;
			_Canon = (System.__Canon)(object)action3;
			action2 = (Action<string>)action3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
		object obj92 = 0;
		object obj93 = obj92;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X0_v71+E4]");
		bool flag28 = (nint)0 == 0;
		object obj94 = !flag28;
		if (obj94 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaCloud.Run((string)function, (Dictionary<string, object>)(object)dictionary, done, action2);
		return;
		IL_0dc0:
		num8 = (double)num6 + num5;
		object obj95 = num6 & 1;
		bool flag29 = obj95 == null;
		object obj96 = !flag29;
		if (obj96 != null)
		{
			num6 = (float)num8;
		}
		goto IL_0e0a;
	}

	private static string Words(string name)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		if (name != null)
		{
			if (name._stringLength < 1)
			{
				goto IL_0280;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj2 = 0;
			int num = 0;
			while (true)
			{
				if (num != 0)
				{
					char c = name.get_Chars(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X23_v5+90]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v11+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (char.IsUpper(c))
					{
						int index = num - 1;
						char c2 = name.get_Chars(index);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X23_v5+90]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+E4]");
						bool flag2 = (nint)0 == 0;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag3 = char.IsUpper(c2);
						bool flag4 = !flag3;
						object obj7 = !flag4;
						if (obj7 == null)
						{
							if (stringBuilder == null)
							{
								break;
							}
							StringBuilder stringBuilder2 = stringBuilder.Append(' ');
						}
					}
				}
				char c3 = name.get_Chars(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X23_v5+90]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				char value = char.ToUpperInvariant(c3);
				if (stringBuilder == null)
				{
					break;
				}
				StringBuilder stringBuilder3 = stringBuilder.Append(value);
				num++;
				if (num < name._stringLength)
				{
					continue;
				}
				goto IL_0280;
			}
		}
		goto IL_02cf;
		IL_0280:
		if (stringBuilder != null)
		{
			nint num2 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+168]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+170]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X2_v3 (should have been resolved before IL gen)");
		}
		goto IL_02cf;
		IL_02cf:
		return (string)(object)new NullReferenceException();
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnPlayerJoined(NetworkRunner runner, PlayerRef player)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected VT, but got Unknown
		//IL_007c: Expected VT, but got I4
		//IL_023c: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_0061: Expected VT, but got I4
		//IL_0159: Expected VT, but got Obj
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I
		//IL_01e0: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		string text = (string)obj;
		GillaNetWatch gillaNetWatch;
		NetworkRunner networkRunner = default;
		if ((object)networkRunner != null)
		{
			PlayerRef playerRef = default;
			PlayerRef player2 = (PlayerRef)(playerRef & 0xFFFFFFFFL);
			string playerUserId = networkRunner.GetPlayerUserId(player2);
			if (playerUserId == null)
			{
				playerRef = (PlayerRef)0;
				gillaNetWatch = this;
				text = (string)obj;
			}
			else
			{
				playerRef = (PlayerRef)0;
				gillaNetWatch = this;
				text = playerUserId;
			}
			goto IL_022c;
		}
		NullReferenceException ex = new NullReferenceException();
		gillaNetWatch = this;
		goto IL_00fa;
		IL_022c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj2 = 0;
		gillaNetWatch = (GillaNetWatch)(object)gillaNetWatch.inRoom;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef2 = default;
		int playerId = playerRef2.PlayerId;
		bool flag2 = (object)gillaNetWatch == null;
		networkRunner = null;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E90]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @43519F0");
			return;
		}
		goto IL_00fa;
		IL_00fa:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag3 = (nint)networkRunner != 1;
		NullReferenceException ex3 = ex2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			object obj7 = default;
			object obj6 = obj7;
			PlayerRef player2 = (PlayerRef)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj9 = default;
			object obj8 = obj9 & 1;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				goto IL_022c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj10 = obj7;
			networkRunner = (NetworkRunner)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			PlayerRef playerRef = (PlayerRef)0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnPlayerLeft(NetworkRunner runner, PlayerRef player)
	{
		//IL_0010: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef = default;
		int playerId = playerRef.PlayerId;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E98]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4351EF0");
	}

	private unsafe string Host(NetworkRunner runner)
	{
		//IL_0010: Expected VT, but got I
		//IL_0547: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_004a: Expected VT, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_01cd: Expected I4, but got I8
		//IL_0092: Expected VT, but got I4
		//IL_00a0: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_0222: Expected VT, but got I
		//IL_0234: Expected Obj, but got Ref
		//IL_00cb: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_011c: Invalid comparison between VT and I4
		//IL_0330: Expected Obj, but got I4
		//IL_0350: Expected Obj, but got Ref
		//IL_0359: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I4
		//IL_0680: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_038f: Expected Obj, but got I4
		//IL_041b: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got Ref
		//IL_03f7: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I4
		//IL_04bc: Expected Obj, but got I4
		//IL_03dc: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_051b: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got I4
		//IL_0615: Expected Obj, but got Ref
		//IL_061e: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		int raw = ((PlayerRef)0).Raw;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2 (System.Int32)+E4]");
		OutOfMemoryException ex = (OutOfMemoryException)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2 (System.Int32)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)runner != (UnityEngine.Object)null;
		bool flag3 = !flag2;
		PlayerRef playerRef = (PlayerRef)0;
		UnityEngine.Object obj2 = null;
		object obj3 = 109895680;
		OutOfMemoryException ex2;
		OutOfMemoryException ex4 = default;
		int num;
		OutOfMemoryException ex3;
		OutOfMemoryException ex5;
		if (!flag3)
		{
			bool flag4 = (object)runner == null;
			ex2 = null;
			ex3 = ex4;
			ex5 = null;
			playerRef = (PlayerRef)0;
			obj2 = null;
			obj3 = 109895680;
			if (flag4)
			{
				goto IL_0440;
			}
			PlayerRef localPlayer = runner.LocalPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			obj3 = 0;
			ex = (OutOfMemoryException)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v14 (System.OutOfMemoryException)+E4]");
			bool flag5 = (nint)0 == 0;
			object obj4 = !flag5;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = localPlayer < (object)1;
			playerRef = localPlayer;
			obj2 = null;
			PlayerRef playerRef2 = localPlayer;
			if (!flag6)
			{
				PlayerRef localPlayer2 = runner.LocalPlayer;
				ex = (OutOfMemoryException)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v14 (System.OutOfMemoryException)+E4]");
				bool flag7 = (nint)0 == 0;
				object obj5 = !flag7;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int playerId = playerRef.PlayerId;
				obj2 = null;
				num = playerId;
				playerRef2 = localPlayer;
				goto IL_0577;
			}
		}
		num = -1;
		goto IL_0577;
		IL_0440:
		int num2 = 0;
		throw new NullReferenceException();
		IL_0577:
		bool flag8 = inRoom == null;
		ex2 = null;
		ex3 = ex4;
		ex5 = null;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E88]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E68]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E70]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E60]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			PlayerRef playerRef2 = (PlayerRef)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4351E64");
			ex = (OutOfMemoryException)(&ex2);
			object obj10 = default;
			object obj11 = default;
			OutOfMemoryException ex8 = default;
			object obj20 = default;
			string result2 = default;
			object obj14;
			OutOfMemoryException ex7;
			OutOfMemoryException ex9;
			OutOfMemoryException ex6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B6BD84");
				object obj9 = obj10 & 1;
				string result;
				object obj15;
				object obj16;
				if (obj9 != null)
				{
					obj2 = (UnityEngine.Object)obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B6BE5C");
					if (num == (nint)obj11)
					{
						continue;
					}
					if (obj8 == null)
					{
						break;
					}
					if ((nint)obj2.m_CachedPtr < 1)
					{
						continue;
					}
					bool flag9 = (nint)obj2.m_CachedPtr < 41;
					object obj12 = !flag9;
					object obj13 = ~obj12;
					num2 = 0;
					result = (string)obj8;
					if (obj13 == null)
					{
						string text = ((string)obj8).Substring(0, 40);
						num2 = 40;
						result = text;
					}
					ex2 = ex6;
					ex3 = null;
					obj14 = 0;
					ex7 = ex8;
					ex9 = ex4;
					ex5 = ex6;
					ex6 = (OutOfMemoryException)(&ex2);
					obj15 = 9;
					obj16 = 0;
				}
				else
				{
					ex2 = ex6;
					ex3 = null;
					obj14 = 0;
					ex7 = ex8;
					ex9 = ex4;
					ex5 = ex6;
					ex6 = (OutOfMemoryException)(&ex2);
					obj15 = 10;
					num2 = 0;
					result = null;
					obj16 = 0;
				}
				while (true)
				{
					obj2 = (UnityEngine.Object)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B6BDF0");
					bool flag10 = obj16 == null;
					object obj17 = !flag10;
					if (obj17 == null)
					{
						bool flag11 = ex3 == null;
						object obj18 = !flag11;
						OutOfMemoryException ex10 = ex6;
						if (obj18 == null)
						{
							if ((nint)obj15 != 10)
							{
								bool flag12 = obj15 == null;
								object obj19 = !flag12;
								if (obj19 != null)
								{
									goto IL_062c;
								}
							}
							result = (string)playerRef2.Raw;
							goto IL_062c;
						}
					}
					else
					{
						OutOfMemoryException ex10 = new OutOfMemoryException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
					if ((nint)obj2 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						ex3 = (OutOfMemoryException)1;
						ex = (OutOfMemoryException)1;
						obj16 = obj14;
					}
					else
					{
						if ((nint)obj2 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						obj16 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj14 = obj20;
					}
					obj15 = 0;
					result = null;
					continue;
					IL_062c:
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A14B4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result2;
			}
			NullReferenceException ex11 = new NullReferenceException();
			ex2 = ex6;
			ex3 = null;
			obj14 = 0;
			ex7 = ex8;
			ex9 = ex4;
			ex5 = ex6;
			ex6 = (OutOfMemoryException)(&ex2);
		}
		goto IL_0440;
	}

	private unsafe static void NoteDrop(string room)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_0733: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got Ref
		//IL_018b: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_0748: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_02f7: Expected F4, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_028b: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I4
		//IL_07f1: Expected Obj, but got I
		//IL_0801: Expected Obj, but got I
		//IL_082b: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I
		//IL_05f5: Expected Obj, but got I
		//IL_061e: Expected Obj, but got I
		//IL_0647: Expected Obj, but got I
		//IL_0671: Expected Obj, but got I4
		//IL_0410: Expected Obj, but got I
		//IL_06a7: Expected Obj, but got I
		//IL_06d1: Expected Obj, but got I4
		//IL_0441: Expected Obj, but got I
		//IL_046a: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I4
		//IL_04f4: Expected Obj, but got I
		//IL_0509: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I4
		//IL_07d3: Expected Obj, but got I4
		//IL_0851: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I4
		//IL_05b6: Expected Obj, but got I
		//IL_05c6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v8+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E30]");
		object obj7 = 0;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v5+10]");
		bool flag2 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)room, out var value);
		bool flag3 = !flag2;
		object obj9 = !flag3;
		System.__Canon _Canon = (System.__Canon)(&value);
		System.__Canon _Canon2 = (System.__Canon)(object)room;
		List<float> list = default;
		if (obj9 == null)
		{
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v82+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v82+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E38]");
			object obj14 = 0;
			obj8 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v53+10]");
			((Dictionary<System.__Canon, System.__Canon>)0).set_Item((System.__Canon)(object)room, (System.__Canon)(object)list);
			_Canon = (System.__Canon)(object)list;
			_Canon2 = (System.__Canon)(object)room;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC40]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E40]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Predicate<float> predicate = default;
		predicate._002Ector(obj2, (IntPtr)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFC28]");
		object obj17 = 0;
		int num = list.RemoveAll(predicate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v84 (System.Collections.Generic.List`1<System.Single>)+10]");
		object obj19 = 0;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v84 (System.Collections.Generic.List`1<System.Single>)+1C]");
		object obj21 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v84 (System.Collections.Generic.List`1<System.Single>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v13+18]");
		bool flag5 = num2 < 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v84 (System.Collections.Generic.List`1<System.Single>)+18]");
			object obj23 = obj19 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v84 (System.Collections.Generic.List`1<System.Single>)+18]");
			object obj24 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+10]");
			_ = 0;
			Predicate<float> predicate2 = predicate;
			System.__Canon _Canon3 = (System.__Canon)(object)list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X9_v5+20]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v49+A8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v50+70]");
			Predicate<float> predicate2 = (Predicate<float>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3 (System.Object)+10]");
			list.AddWithResize(0f);
			System.__Canon _Canon3 = (System.__Canon)(object)list;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v17 (System.__Canon)+18]");
		if ((nint)0 < (nint)2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v17 (System.__Canon)+1C]");
		object obj28 = (nint)0 + (nint)1;
		object obj29 = obj27;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj30 = !flag6;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj31 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v22+A0]");
		object obj34 = 0;
		object obj35 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v21+E4]");
		bool flag8 = (nint)0 == 0;
		object obj36 = !flag8;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v10+8]");
		if ((UnityEngine.Object)0 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v10+8]");
			if (((NetworkBootstrap)0).RejoinsByCode)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E58]");
				object format = 0;
				object arg = default;
				object arg2 = default;
				string message = string.Format((string)format, room, arg, arg2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj38 = 0;
				object obj39 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v39+E4]");
				bool flag9 = (nint)0 == 0;
				object obj40 = !flag9;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v10+8]");
				((NetworkBootstrap)0).RejoinPublicInstead();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D11B0]");
				object obj41 = 0;
				object obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X0_v52+E4]");
				bool flag10 = (nint)0 == 0;
				object obj43 = !flag10;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj44 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v56+E4]");
				bool flag11 = (nint)0 == 0;
				object obj45 = !flag11;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj44 = obj41;
				}
				object obj46 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v56+A0]");
				object obj47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v44+E4]");
				bool flag12 = (nint)0 == 0;
				object obj48 = !flag12;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if ((UnityEngine.Object)obj47 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2BF8]");
					object top = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E50]");
					object bottom = 0;
					((GillaHud)obj47).Alert((string)top, (string)bottom, 4f);
				}
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2E48]");
		object format2 = 0;
		object arg3 = default;
		object arg4 = default;
		string message2 = string.Format((string)format2, room, arg3, arg4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj50 = 0;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v28+E4]");
		bool flag13 = (nint)0 == 0;
		object obj52 = !flag13;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj53 = 0;
		object obj54 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v35+E4]");
		bool flag14 = (nint)0 == 0;
		object obj55 = !flag14;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeration.Avoid(room, 1800f);
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnInput(NetworkRunner runner, NetworkInput input)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnConnectRequest(NetworkRunner runner, NetworkRunnerUpdaterDefault.PlayerLoopSystemRegistration.ConnectRequest request, byte[] token)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ReadOnlySpan<byte> data)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSceneLoadDone(NetworkRunner runner)
	{
	}

	private void Fusion_002EINetworkRunnerCallbacks_002EOnSceneLoadStart(NetworkRunner runner)
	{
	}

	public GillaNetWatch()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EA0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EA8]");
		object obj3 = 0;
		joinedAt = -1f;
		object obj4 = this + 40;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = this + 48;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @435173C");
		object obj6 = this + 56;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}

	static GillaNetWatch()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDF88]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2EB0]");
		object obj3 = 0;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+A0]");
		object obj5 = 0;
		obj5 = obj;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+A0]");
		object obj8 = (nint)0 + (nint)16;
		obj8 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
