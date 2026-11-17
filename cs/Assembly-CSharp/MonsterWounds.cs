using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class MonsterWounds : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass257_0
	{
		public MonsterPlayer _003C_003E4__this;

		public Vector3 at;

		public Vector3 way;

		internal void _003CSmashing_003Eb__0()
		{
			//IL_0014: Expected VT, but got I4
			Vector3 faces = default;
			_003C_003E4__this.SmashOne((Vector3)0, faces);
		}
	}

	private class Chain
	{
		public Transform upper;

		public Transform lower;

		public Transform end;

		public Vector3 at;

		public Vector3 hip;

		public Quaternion turn;

		public float low = 3.4028235E+38f;
	}

	private class Thrown : MonoBehaviour
	{
		private Mesh mesh;

		private float wait;

		private float over;

		private float t;

		private Vector3 size;

		public void Begin(Mesh baked, float after, float seconds)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_002d: Expected F4, but got I
			//IL_003d: Invalid comparison between F4 and I
			//IL_007d: Expected VT, but got F4
			object obj = this + 32;
			obj = baked;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			if (!(seconds < 0f))
			{
				num = seconds;
			}
			wait = after;
			over = num;
			Transform transform = base.transform;
			Vector3 localScale = transform.localScale;
			size = (Vector3)num;
		}

		private void Update()
		{
			//IL_0090: Invalid comparison between F8 and I4
			//IL_00d1: Expected VT, but got I4
			float deltaTime = Time.deltaTime;
			if ((t += deltaTime) > wait)
			{
				Transform transform = base.transform;
				float num = t - wait;
				float num2 = num / over;
				double num3 = 1.0 - (double)num2;
				if (num3 < 0.0 || num3 > 1.0)
				{
				}
				transform.localScale = (Vector3)0;
			}
		}

		private void OnDestroy()
		{
			//IL_0010: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I4
			//IL_007b: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (mesh != null)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(mesh);
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public MonsterWounds _003C_003E4__this;

		public MonsterNavMesh.Arm a;

		internal void _003CArmOff_003Eb__0()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0093: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (_003C_003E4__this != null)
			{
				_003C_003E4__this.ArmComesOff(a, loud: true);
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public Vector3[] at;

		public float units;

		public int[][] lists;

		public int[] tris;

		public int[] points;

		internal unsafe void _003CPrepare_003Eb__0()
		{
			//IL_0a43: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0046: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I4
			//IL_008a: Expected Obj, but got I4
			//IL_0a5b: Expected Obj, but got I4
			//IL_0a76: Expected Obj, but got I4
			//IL_01b3: Expected I, but got Obj
			//IL_00aa: Expected Obj, but got I4
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected Obj, but got Unknown
			//IL_00ea: Expected Obj, but got I
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected Obj, but got Unknown
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected Obj, but got Unknown
			//IL_0156: Expected Obj, but got I4
			//IL_0166: Expected Obj, but got I
			//IL_0253: Expected Obj, but got I4
			//IL_028d: Expected Obj, but got I8
			//IL_02a6: Expected Obj, but got I4
			//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ea: Expected Obj, but got Unknown
			//IL_0b2d: Expected Obj, but got I4
			//IL_061b: Expected Obj, but got I
			//IL_0623: Expected I, but got Obj
			//IL_02ec: Expected Obj, but got I
			//IL_0516: Expected Obj, but got I4
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Expected Obj, but got Unknown
			//IL_053f: Expected Obj, but got I4
			//IL_056f: Expected Obj, but got I4
			//IL_0680: Expected Obj, but got I4
			//IL_0339: Expected Obj, but got I4
			//IL_06c6: Expected Obj, but got I8
			//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d4: Expected Obj, but got Unknown
			//IL_06fd: Expected I, but got Obj
			//IL_039c: Expected Obj, but got I
			//IL_03ac: Expected Obj, but got I
			//IL_03ce: Expected Obj, but got I4
			//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a00: Expected Obj, but got Unknown
			//IL_0b5b: Expected Obj, but got I4
			//IL_0420: Expected Obj, but got I
			//IL_0ae6: Expected Obj, but got I4
			//IL_0af6: Expected I, but got Obj
			//IL_0929: Expected Obj, but got I
			//IL_0937: Expected Obj, but got I4
			//IL_0958: Expected Obj, but got I4
			//IL_09a5: Expected I4, but got Obj
			//IL_075e: Expected Obj, but got I4
			//IL_0445: Expected Obj, but got I
			//IL_0466: Expected Obj, but got I4
			//IL_07ac: Expected Obj, but got I
			//IL_07ca: Expected Obj, but got I
			//IL_07fe: Expected Obj, but got I4
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Expected Obj, but got Unknown
			//IL_04a9: Expected Obj, but got I4
			//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected Obj, but got Unknown
			//IL_04de: Expected I, but got Obj
			//IL_04ee: Expected Obj, but got I
			//IL_083c: Expected Obj, but got I
			//IL_084c: Expected Obj, but got I
			//IL_0875: Expected Obj, but got I4
			//IL_08d7: Expected VT, but got Ref
			//IL_08e7: Expected Obj, but got I
			//IL_08f7: Expected Obj, but got I
			//IL_08a0: Expected Obj, but got I
			//IL_08b6: Expected Obj, but got I
			Vector3[] array = at;
			bool flag = at == null;
			List<int> list = (List<int>)109895680;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5640]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
				List<int> list2 = (List<int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
				list = (List<int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5608]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6BA8]");
				object obj3 = 0;
				object obj5 = default;
				object obj4 = obj5;
				object obj7 = default;
				object obj6 = obj7;
				float num2 = default;
				float num = num2;
				Vector3[] array2 = at;
				object obj8 = 0;
				object obj9 = 0;
				object obj14 = default;
				List<int> list3 = default;
				List<int> list4 = default;
				List<int> list5 = default;
				object obj19 = default;
				while (true)
				{
					object obj10 = array2.Length;
					bool flag2 = (nint)obj8 < array2.Length;
					object obj11 = !flag2;
					bool flag3 = (nint)obj8 >= array2.Length;
					obj5 = obj4;
					obj7 = obj6;
					num2 = num;
					array = array2;
					object obj12 = obj8;
					object obj23;
					nint num3;
					if (!flag3)
					{
						bool flag4 = (nint)obj8 < array2.Length;
						obj11 = !flag4;
						if (obj11 == null)
						{
							object obj13 = (object)array2 + obj9;
							obj9 += 12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v17+28]");
							obj5 = 0;
							obj12 = obj8 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v17+20]");
							obj7 = 0 * obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v17+28]");
							num2 = 0f * units;
							array = at;
							bool flag5 = at == null;
							object obj15 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X9_v17+28]");
							obj4 = 0;
							obj6 = obj7;
							num = num2;
							array2 = at;
							obj8 = obj12;
							if (obj15 == null)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						num3 = (nint)list2;
						list3._002Ector();
						Vector3[] array3 = at;
						bool flag6 = at == null;
						list2 = list3;
						if (flag6)
						{
							break;
						}
						num3 = array3.Length;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						int[][] array4 = lists;
						bool flag7 = lists == null;
						list2 = list3;
						if (flag7)
						{
							break;
						}
						bool flag8 = array4.Length < 1;
						obj11 = !flag8;
						flag3 = array4.Length < 1;
						if (flag3)
						{
							goto IL_05a5;
						}
						object obj16 = array4.Length & 0xFFFFFFFFL;
						object obj17 = obj10;
						object obj18 = obj19;
						object obj20 = 0;
						bool flag9 = flag3;
						nint num4 = array3.Length;
						Vector3[] array5 = array;
						object obj21 = obj12;
						while (true)
						{
							bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
							obj11 = !flag10;
							if (obj11 != null)
							{
								break;
							}
							object obj22 = (object)lists + obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v23+20]");
							IEnumerable<int> enumerable = (IEnumerable<int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v23+20]");
							object obj24;
							if ((nint)0 != 0)
							{
								bool flag11 = list3 == null;
								obj10 = obj17;
								obj19 = obj18;
								obj23 = 1;
								obj24 = obj20;
								flag3 = flag9;
								num3 = num4;
								array = array5;
								obj12 = obj21;
								list2 = list3;
								list = list4;
								if (flag11)
								{
									goto end_IL_0a51;
								}
								obj18 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v23+20]");
								list3.AddRange((IEnumerable<int>)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
								bool flag12 = (nint)0 < (nint)1;
								obj11 = !flag12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v4 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
								flag3 = (nint)0 < (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v23+20]");
								num4 = 0;
								if (!flag3)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v23+20]");
									array = (Vector3[])((nint)0 + (nint)32);
									obj10 = obj17;
									obj12 = obj21;
									while (true)
									{
										bool flag13 = list4 == null;
										obj19 = obj18;
										obj23 = 1;
										obj24 = obj20;
										num3 = (nint)enumerable;
										list2 = list3;
										list = list4;
										if (flag13)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
										obj17 = 0;
										Vector3[] array6 = array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
										bool flag14 = (nint)array6 < 0;
										object obj26 = !flag14;
										if (obj26 != null)
										{
											goto end_IL_0b14;
										}
										obj21 = (object)list4 + (object)array;
										obj25--;
										bool flag15 = (nint)obj25 < 1;
										obj11 = !flag15;
										array5 = (Vector3[])(array + 4);
										_ = 1;
										flag3 = (nint)obj25 != 1;
										num4 = (nint)enumerable;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
										obj10 = 0;
										array = array5;
										obj12 = obj21;
										if (flag3)
										{
											continue;
										}
										goto IL_050c;
									}
									goto end_IL_0a51;
								}
							}
							goto IL_050c;
							IL_050c:
							obj16 = array4.Length;
							obj24 = obj20 + 1;
							bool flag16 = (nint)obj24 < array4.Length;
							obj11 = !flag16;
							flag3 = (nint)obj24 < array4.Length;
							obj10 = obj17;
							obj19 = obj18;
							obj23 = 1;
							num3 = num4;
							array = array5;
							obj12 = obj21;
							obj20 = obj24;
							flag9 = flag3;
							if (flag3)
							{
								continue;
							}
							goto IL_05a5;
							continue;
							end_IL_0b14:
							break;
						}
					}
					goto IL_0a18;
					IL_09bb:
					bool flag17 = list5 == null;
					list2 = list5;
					list = list4;
					if (flag17)
					{
						break;
					}
					int[] array7 = list5.ToArray();
					object obj27 = this + 48;
					obj27 = array7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					return;
					IL_0a18:
					throw new IndexOutOfRangeException();
					IL_05a5:
					bool flag18 = list3 == null;
					list2 = list3;
					list = list4;
					if (flag18)
					{
						break;
					}
					int[] array8 = list3.ToArray();
					object obj28 = this + 40;
					obj28 = array8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5628]");
					object obj29 = 0;
					num3 = (nint)obj29;
					list5._002Ector();
					bool flag19 = list4 == null;
					list2 = list5;
					list = list4;
					if (flag19)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
					bool flag20 = (nint)0 < (nint)1;
					obj11 = !flag20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
					flag3 = (nint)0 < (nint)1;
					if (flag3)
					{
						goto IL_09bb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj30 = 0 & 0xFFFFFFFFL;
					obj23 = list4 + 32;
					object obj31 = obj10;
					object obj32 = obj19;
					int num5 = 0;
					bool flag21 = flag3;
					nint num6 = (nint)obj29;
					Vector3[] array9 = array;
					object obj33 = obj12;
					while (true)
					{
						bool flag22 = num5 < (nint)obj30;
						obj11 = !flag22;
						if (obj11 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X23_v4+v92 @ X22_v7 (System.Int32)]");
						IEnumerable<int> enumerable;
						if ((nint)0 != 0)
						{
							bool flag23 = list5 == null;
							obj10 = obj31;
							obj19 = obj32;
							enumerable = (IEnumerable<int>)num5;
							flag3 = flag21;
							num3 = num6;
							array = array9;
							obj12 = obj33;
							list2 = list5;
							list = list4;
							if (flag23)
							{
								goto end_IL_0a51;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
							object obj34 = 0;
							array = (Vector3[])obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
							obj12 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
							bool flag24 = (nint)0 == 0;
							obj10 = obj31;
							obj19 = obj32;
							enumerable = (IEnumerable<int>)num5;
							flag3 = flag21;
							num3 = num6;
							list2 = list5;
							list = list4;
							if (flag24)
							{
								goto end_IL_0a51;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
							obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v17+18]");
							obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v17+18]");
							bool flag25 = num7 < 0;
							object obj35 = !flag25;
							if (obj35 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj36 = num8 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
								array9 = (Vector3[])((nint)0 + (nint)1);
							}
							else
							{
								Vector3 vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v18 (UnityEngine.Vector3)+A8]");
								object obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v19+70]");
								obj32 = 0;
								list5.AddWithResize(num5);
								num6 = num5;
								array9 = (Vector3[])obj2;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
						obj30 = 0;
						enumerable = (IEnumerable<int>)(num5 + 1);
						IEnumerable<int> enumerable2 = enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
						bool flag26 = (nint)enumerable2 < 0;
						obj11 = !flag26;
						IEnumerable<int> enumerable3 = enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v8 (System.Collections.Generic.List`1<System.Int32>)+18]");
						flag3 = (nint)enumerable3 < 0;
						obj10 = obj31;
						obj19 = obj32;
						num3 = num6;
						array = array9;
						obj12 = obj33;
						num5 = (int)enumerable;
						flag21 = flag3;
						if (flag3)
						{
							continue;
						}
						goto IL_09bb;
					}
					goto IL_0a18;
					continue;
					end_IL_0a51:
					break;
				}
			}
			throw new NullReferenceException();
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_1
	{
		public Vector3[] pa;

		public Vector3[] pf;

		public int[] pc;

		public Bounds pb;

		public Mesh mesh;

		internal unsafe GillaWounds.BoneShape _003CPrepare_003Eb__1()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0078: Expected Obj, but got I4
			//IL_0045: Expected VT, but got Ref
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = default;
			return GillaWounds.Shaped(mesh, pa, pf, pc, (Bounds)(&obj4));
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public MonsterWounds _003C_003E4__this;

		public Vector3 at;

		public float near;

		internal void _003CBlast_003Eb__0()
		{
			//IL_0015: Expected F4, but got VT
			//IL_0015: Expected VT, but got I
			IntPtr intPtr = default;
			_003C_003E4__this.Blast((Vector3)(nint)intPtr, (float)at);
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public MonsterWounds _003C_003E4__this;

		public Vector3 at;

		internal void _003CTrapped_003Eb__0()
		{
			//IL_000f: Expected VT, but got I
			IntPtr intPtr = default;
			_003C_003E4__this.Trapped((Vector3)(nint)intPtr);
		}
	}

	private sealed class _003CLoad_003Ed__83 : _0021_00210, _0021_00211, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonsterWounds _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CLoad_003Ed__83(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0272: Expected I4, but got I8
			//IL_018b: Expected I4, but got I8
			//IL_02e0: Expected I4, but got Obj
			//IL_004a: Expected Obj, but got I4
			//IL_0070: Expected I4, but got I8
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Expected Obj, but got Unknown
			//IL_020b: Expected Obj, but got I
			//IL_0213: Expected I, but got Obj
			//IL_0244: Expected Obj, but got I4
			//IL_0294: Expected Obj, but got I
			//IL_00fd: Expected Obj, but got I
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected Obj, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected Obj, but got Unknown
			bool result;
			int num;
			MonsterGore baked;
			if (_003C_003E1__state != 2)
			{
				MonsterWounds monsterWounds = _003C_003E4__this;
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 0;
					object obj = !flag;
					result = false;
					if (obj != null)
					{
						goto IL_02ff;
					}
					_003C_003E1__state = -1;
					if ((object)_003C_003E4__this != null && (object)monsterWounds.skin != null)
					{
						Mesh sharedMesh = monsterWounds.skin.sharedMesh;
						if ((object)sharedMesh != null)
						{
							string name = sharedMesh.name;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC90]");
							object obj2 = 0;
							string path = (string)obj2 + name;
							ResourceRequest resourceRequest = Resources.LoadAsync<T>(path);
							object obj3 = _003C_003E4__this + 128;
							obj3 = resourceRequest;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj4 = this + 24;
							obj4 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							result = true;
							num = 1;
							goto IL_0304;
						}
					}
				}
				else
				{
					_003C_003E1__state = -1;
					if ((object)_003C_003E4__this != null && monsterWounds.loading != null)
					{
						UnityEngine.Object asset = monsterWounds.loading.asset;
						if ((object)asset != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC80]");
							object obj5 = 0;
							nint num2 = (nint)asset;
							object obj6 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v5 (Il2CppClass<UnityEngine.Object>)+130]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v14+130]");
							bool flag2 = num3 < 0;
							object obj7 = !flag2;
							if (obj7 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X9_v5 (Il2CppClass<UnityEngine.Object>)+B0]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v14+130]");
								object obj8 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X9_v7-8]");
								baked = (MonsterGore)((0 != (nint)obj6) ? null : asset);
								goto IL_0313;
							}
						}
						baked = null;
						goto IL_0313;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			result = false;
			num = -1;
			goto IL_0304;
			IL_0313:
			IEnumerator enumerator = _003C_003E4__this.Prepare(baked);
			object obj9 = this + 24;
			obj9 = enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			result = true;
			num = 2;
			goto IL_0304;
			IL_0304:
			_003C_003E1__state = num;
			goto IL_02ff;
			IL_02ff:
			return result;
		}

		private void System_002ECollections_002EIEnumerator_002EReset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			throw new ArgumentNullException();
		}
	}

	private const int SaysWound = default(int);

	private const int SaysArmOff = default(int);

	private const int SaysTrapped = default(int);

	public float tearReach;

	public float tearAgainReach;

	public float slowest;

	public float pieceLife;

	public float pieceShrink;

	public float throwSpeed;

	public float bleedSeconds;

	public int bleedPulses;

	public int gushDroplets;

	private float Pace__BackingField;

	private float Wreck__BackingField;

	private float Side__BackingField;

	[NonSerialized]
	public bool Quiet;

	private MonsterBrain brain;

	private SkinnedMeshRenderer skin;

	private SkinnedMeshRenderer poser;

	private MonsterGore gore;

	private GillaWounds wounds;

	private ResourceRequest loading;

	private bool ready;

	private bool started;

	private float perUnit;

	private float height;

	private float seed;

	private readonly Dictionary<string, Transform> named;

	private readonly List<(Vector4, bool)> waiting;

	private readonly List<Action> waitingCalls;

	private readonly List<MonsterGore.Limb> pickFrom;

	private readonly List<float> pickWeights;

	private readonly int[] armState;

	private readonly bool[] hangs;

	private readonly int[] legHits;

	private int headHits;

	private int torsoHits;

	private int brokeFirst;

	private int trappedSide;

	private float torsoSide;

	private float limp;

	private float armWeight;

	private Transform pelvis;

	private Transform spine;

	private Transform chest;

	private Transform head;

	private readonly Chain[] arms;

	private readonly Chain[] legs;

	private readonly Transform[] spiderLegs;

	private int spiderCount;

	private readonly float[] hanging;

	private readonly Vector3[] elbow;

	private readonly Vector3[] elbowWas;

	private readonly Vector3[] wrist;

	private readonly Vector3[] wristWas;

	private readonly bool[] swinging;

	private readonly float[] armClear;

	private float clock;

	private float thrash;

	private float lurch;

	private Vector3 trapAt;

	private bool trapHeld;

	private static Mesh warmMesh;

	public float Pace
	{
		get
		{
			return Pace__BackingField;
		}
		private set
		{
			Pace__BackingField = value;
		}
	}

	public float Wreck
	{
		get
		{
			return Wreck__BackingField;
		}
		private set
		{
			Wreck__BackingField = value;
		}
	}

	public float Side
	{
		get
		{
			return Side__BackingField;
		}
		private set
		{
			Side__BackingField = value;
		}
	}

	public bool Ready => ready;

	public GillaWounds Wounds => wounds;

	public MonsterGore Gore => gore;

	private static float Saying(int says, GoreSection section)
	{
		int num = says << 3;
		return (float)num + (float)(int)section;
	}

	public bool ArmIsOff(int side)
	{
		//IL_00db: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		int[] array = armState;
		if (armState != null)
		{
			bool flag = array.Length < side;
			object obj = !flag;
			object obj2 = array.Length - side;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = armState + side;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				object obj6 = -2;
				return obj6 == null;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	public bool ArmHangs(int side)
	{
		//IL_00be: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		bool[] array = hangs;
		if (hangs != null)
		{
			bool flag = array.Length < side;
			object obj = !flag;
			object obj2 = array.Length - side;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = hangs + side;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				return false;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj2 = this + 88;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7C00]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj5 = default;
		if (obj5 != null)
		{
			enabled = false;
			return;
		}
		Begin();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (skin != null)
		{
			Mesh sharedMesh = skin.sharedMesh;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (sharedMesh != null)
			{
				IEnumerator routine = Load();
				Coroutine coroutine = StartCoroutine(routine);
			}
		}
	}

	private IEnumerator Load()
	{
		//IL_0010: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB68]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	private void Begin()
	{
		//IL_125d: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I
		//IL_01e4: Expected F4, but got I
		//IL_0261: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_0560: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I4
		//IL_12d8: Expected Obj, but got I4
		//IL_035b: Expected Obj, but got I8
		//IL_036b: Expected Obj, but got I
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_05ae: Expected Obj, but got I
		//IL_12b5: Expected Obj, but got I4
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05f8: Expected Obj, but got I
		//IL_1216: Expected Obj, but got I4
		//IL_0625: Expected Obj, but got I4
		//IL_03c7: Expected Obj, but got I4
		//IL_12ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f1: Expected Obj, but got Unknown
		//IL_132f: Expected Obj, but got I4
		//IL_03f6: Expected Obj, but got I
		//IL_064b: Expected Obj, but got I
		//IL_0504: Expected Obj, but got I4
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_06f8: Expected Obj, but got I
		//IL_0449: Expected Obj, but got I4
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_0738: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got I4
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected Obj, but got Unknown
		//IL_077a: Expected Obj, but got I
		//IL_078a: Expected Obj, but got I
		//IL_079a: Expected Obj, but got I
		//IL_047c: Expected Obj, but got I
		//IL_04a2: Expected Obj, but got I4
		//IL_07e9: Expected Obj, but got I4
		//IL_04dd: Expected Obj, but got I
		//IL_04ed: Expected Obj, but got I
		//IL_082c: Expected I, but got Obj
		//IL_083c: Expected Obj, but got I
		//IL_085e: Expected Obj, but got I4
		//IL_086e: Expected Obj, but got I
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_08e5: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I
		//IL_0905: Expected Obj, but got I
		//IL_0954: Expected Obj, but got I4
		//IL_09fb: Expected Obj, but got I8
		//IL_0997: Expected I, but got Obj
		//IL_09a7: Expected Obj, but got I
		//IL_09c9: Expected Obj, but got I4
		//IL_09d9: Expected Obj, but got I
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected Obj, but got Unknown
		//IL_0a62: Expected Obj, but got I
		//IL_0a72: Expected Obj, but got I
		//IL_0a82: Expected Obj, but got I
		//IL_0ad1: Expected Obj, but got I4
		//IL_0b14: Expected I, but got Obj
		//IL_0b24: Expected Obj, but got I
		//IL_0b46: Expected Obj, but got I4
		//IL_0b56: Expected Obj, but got I
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected Obj, but got Unknown
		//IL_0bcd: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I
		//IL_0bed: Expected Obj, but got I
		//IL_0c3c: Expected Obj, but got I4
		//IL_0ce3: Expected Obj, but got I8
		//IL_0c7f: Expected I, but got Obj
		//IL_0c8f: Expected Obj, but got I
		//IL_0cb1: Expected Obj, but got I4
		//IL_0cc1: Expected Obj, but got I
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected Obj, but got Unknown
		//IL_0d4a: Expected Obj, but got I
		//IL_0d5a: Expected Obj, but got I
		//IL_0d6a: Expected Obj, but got I
		//IL_137c: Expected Obj, but got I
		//IL_139e: Expected Obj, but got I4
		//IL_13a7: Expected Obj, but got I4
		//IL_0da8: Expected Obj, but got I4
		//IL_0dc6: Expected Obj, but got I
		//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected Obj, but got Unknown
		//IL_0e08: Expected Obj, but got I8
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected Obj, but got Unknown
		//IL_0e9c: Expected Obj, but got I8
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Expected Obj, but got Unknown
		//IL_0ebb: Expected Obj, but got I4
		//IL_0ecb: Expected I4, but got Obj
		//IL_1356: Expected Obj, but got I4
		//IL_0f0a: Expected Obj, but got I
		//IL_0f4b: Expected Obj, but got I4
		//IL_1142: Expected Obj, but got I
		//IL_114b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Expected Obj, but got Unknown
		//IL_116f: Expected Obj, but got I4
		//IL_117f: Expected Obj, but got I
		//IL_1187: Expected Obj, but got I4
		//IL_119d: Expected Obj, but got I4
		//IL_11b5: Expected Obj, but got I
		//IL_0fe0: Expected Obj, but got I4
		//IL_0ff0: Expected Obj, but got I
		//IL_0ff9: Expected Obj, but got I4
		//IL_10c4: Expected Obj, but got I4
		//IL_10cd: Expected Obj, but got I4
		//IL_10dd: Expected Obj, but got I
		//IL_103b: Expected I, but got Obj
		//IL_104b: Expected Obj, but got I
		//IL_106d: Expected Obj, but got I4
		//IL_107d: Expected Obj, but got I
		//IL_1086: Expected Obj, but got I4
		//IL_109b: Expected Obj, but got I
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Expected Obj, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1113: Expected Obj, but got Unknown
		bool flag = (byte)(~(started ? 1u : 0u)) != 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = this + 88;
		_ = 1;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			MonsterBrain monsterBrain = default;
			brain = monsterBrain;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F1DC");
		object obj8 = this + 96;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB500]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj13 = default;
		float num2;
		string text;
		UnityEngine.Object obj14;
		if (obj13 != null)
		{
			bool flag4 = (object)obj13 == null;
			text = null;
			obj14 = null;
			if (flag4)
			{
				goto IL_1223;
			}
			float num = ((CharacterController)obj13).height;
			num2 = num;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
			num2 = 0f;
		}
		Transform transform = base.transform;
		bool flag5 = (object)transform == null;
		text = null;
		obj14 = null;
		string text2;
		Dictionary<System.__Canon, System.__Canon> dictionary2 = default;
		string text4;
		Transform[] array2 = default;
		string text3 = default;
		object obj15 = default;
		if (!flag5)
		{
			Vector3 lossyScale = transform.lossyScale;
			float num3 = num2 * (float)obj15;
			height = num3;
			float value = UnityEngine.Random.value;
			object obj16 = obj2;
			float num = value * 1.1339039E+09f;
			seed = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = skin == null;
			bool flag8 = !flag7;
			object obj18 = !flag8;
			if (obj18 != null)
			{
				return;
			}
			bool flag9 = obj8 == null;
			obj15 = 1133903872;
			text = null;
			obj14 = null;
			if (!flag9)
			{
				Transform[] bones = ((SkinnedMeshRenderer)obj8).bones;
				bool flag10 = bones == null;
				obj15 = 1133903872;
				text = null;
				obj14 = null;
				if (!flag10)
				{
					bool flag11 = bones.Length < 1;
					text = null;
					if (flag11)
					{
						goto IL_0550;
					}
					object obj19 = bones.Length & 0xFFFFFFFFL;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB18]");
					object obj20 = 0;
					object obj21 = bones + 32;
					text2 = text3;
					Dictionary<System.__Canon, System.__Canon> dictionary = dictionary2;
					Transform[] array = null;
					text4 = null;
					obj14 = null;
					while (true)
					{
						bool flag12 = System.Runtime.CompilerServices.Unsafe.As<Transform[], UIntPtr>(ref array) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
						object obj22 = !flag12;
						if (obj22 != null)
						{
							break;
						}
						object obj23 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v118+E4]");
						bool flag13 = (nint)0 == 0;
						object obj24 = !flag13;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X26_v7+v361 @ X24_v11 (UnityEngine.Transform[])*8]");
						bool flag14 = (UnityEngine.Object)0 != null;
						bool flag15 = !flag14;
						text = null;
						obj14 = null;
						if (flag15)
						{
							goto IL_04fa;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X26_v7+v361 @ X24_v11 (UnityEngine.Transform[])*8]");
						bool flag16 = (nint)0 == 0;
						text3 = text2;
						obj15 = 1133903872;
						text = null;
						obj14 = null;
						if (!flag16)
						{
							dictionary = (Dictionary<System.__Canon, System.__Canon>)(object)named;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X26_v7+v361 @ X24_v11 (UnityEngine.Transform[])*8]");
							string text5 = ((UnityEngine.Object)0).name;
							bool flag17 = (object)named == null;
							text3 = text2;
							obj15 = 1133903872;
							text = null;
							obj14 = null;
							if (!flag17)
							{
								text2 = (string)obj20;
								Dictionary<string, Transform> dictionary3 = named;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X26_v7+v361 @ X24_v11 (UnityEngine.Transform[])*8]");
								((Dictionary<System.__Canon, System.__Canon>)(object)dictionary3).set_Item((System.__Canon)(object)text5, (System.__Canon)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X26_v7+v361 @ X24_v11 (UnityEngine.Transform[])*8]");
								text = (string)0;
								obj14 = (UnityEngine.Object)(object)text5;
								goto IL_04fa;
							}
						}
						goto IL_1223;
						IL_04fa:
						obj19 = bones.Length;
						array2 = (Transform[])(array + 1);
						bool flag18 = (nint)array2 < bones.Length;
						text3 = text2;
						dictionary2 = dictionary;
						array = array2;
						text4 = text;
						if (flag18)
						{
							continue;
						}
						goto IL_0550;
					}
					goto IL_11fc;
				}
			}
		}
		goto IL_1223;
		IL_11fc:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		text3 = text2;
		obj15 = 1133903872;
		text = text4;
		goto IL_1223;
		IL_0550:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F8]");
		object obj25 = 0;
		Transform transform2 = Bone((string)obj25);
		bool flag19 = (object)transform2 == null;
		object obj26 = !flag19;
		obj14 = transform2;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB48]");
			object obj27 = 0;
			Transform transform3 = Bone((string)obj27);
			obj14 = transform3;
		}
		bool flag20 = (object)this == null;
		obj15 = 1133903872;
		NullReferenceException ex2 = default;
		if (!flag20)
		{
			object obj28 = this + 256;
			spine = (Transform)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB40]");
			object obj29 = 0;
			Transform transform4 = Bone((string)obj29);
			bool flag21 = (object)transform4 == null;
			object obj30 = !flag21;
			Transform transform5 = transform4;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB38]");
				object obj31 = 0;
				Transform transform6 = Bone((string)obj31);
				transform5 = transform6;
			}
			object obj32 = this + 264;
			chest = transform5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj33 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v41+E4]");
			bool flag22 = (nint)0 == 0;
			object obj34 = !flag22;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform transform7;
			if (spine != null)
			{
				bool flag23 = (object)spine == null;
				obj15 = 1133903872;
				text = null;
				obj14 = null;
				if (flag23)
				{
					goto IL_1223;
				}
				transform7 = spine.parent;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC958]");
				object obj35 = 0;
				transform7 = Bone((string)obj35);
			}
			object obj36 = this + 248;
			obj36 = transform7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48F0]");
			object obj37 = 0;
			Transform transform8 = Bone((string)obj37);
			head = transform8;
			object obj38 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7728]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7730]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4908]");
			object obj41 = 0;
			Chain[] array3 = arms;
			text = (string)obj40;
			text3 = (string)obj41;
			Chain chain = ChainOf((string)obj39, (string)obj40, (string)obj41);
			bool flag24 = arms == null;
			obj15 = 1133903872;
			obj14 = (UnityEngine.Object)obj39;
			if (!flag24)
			{
				bool flag25 = chain == null;
				UnityEngine.Object obj42 = (UnityEngine.Object)obj39;
				if (!flag25)
				{
					nint num4 = (nint)array3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v68 (Il2CppClass<Chain[]>)+40]");
					obj42 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag26 = ex2 == null;
					obj15 = 1133903872;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v68 (Il2CppClass<Chain[]>)+40]");
					obj14 = (UnityEngine.Object)0;
					if (flag26)
					{
						goto IL_1231;
					}
				}
				bool flag27 = array3.Length == 0;
				text2 = text3;
				text4 = text;
				obj14 = obj42;
				if (flag27)
				{
					goto IL_11fc;
				}
				object obj43 = arms + 32;
				obj43 = chain;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7740]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7738]");
				object obj45 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
				object obj46 = 0;
				Chain[] array4 = arms;
				text = (string)obj45;
				text3 = (string)obj46;
				Chain chain2 = ChainOf((string)obj44, (string)obj45, (string)obj46);
				bool flag28 = arms == null;
				obj15 = 1133903872;
				obj14 = (UnityEngine.Object)obj44;
				if (!flag28)
				{
					bool flag29 = chain2 == null;
					UnityEngine.Object obj47 = (UnityEngine.Object)obj44;
					if (!flag29)
					{
						nint num5 = (nint)array4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v67 (Il2CppClass<Chain[]>)+40]");
						obj47 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag30 = ex2 == null;
						obj15 = 1133903872;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v67 (Il2CppClass<Chain[]>)+40]");
						obj14 = (UnityEngine.Object)0;
						if (flag30)
						{
							goto IL_1231;
						}
					}
					object obj48 = array4.Length & 0xFFFFFFFEL;
					bool flag31 = obj48 == null;
					text2 = text3;
					text4 = text;
					obj14 = obj47;
					if (flag31)
					{
						goto IL_11fc;
					}
					object obj49 = arms + 40;
					obj49 = chain2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB50]");
					object obj50 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB28]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AD0]");
					object obj52 = 0;
					Chain[] array5 = legs;
					text = (string)obj51;
					text3 = (string)obj52;
					Chain chain3 = ChainOf((string)obj50, (string)obj51, (string)obj52);
					bool flag32 = legs == null;
					obj15 = 1133903872;
					obj14 = (UnityEngine.Object)obj50;
					if (!flag32)
					{
						bool flag33 = chain3 == null;
						UnityEngine.Object obj53 = (UnityEngine.Object)obj50;
						if (!flag33)
						{
							nint num6 = (nint)array5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v66 (Il2CppClass<Chain[]>)+40]");
							obj53 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag34 = ex2 == null;
							obj15 = 1133903872;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v66 (Il2CppClass<Chain[]>)+40]");
							obj14 = (UnityEngine.Object)0;
							if (flag34)
							{
								goto IL_1231;
							}
						}
						bool flag35 = array5.Length == 0;
						text2 = text3;
						text4 = text;
						obj14 = obj53;
						if (flag35)
						{
							goto IL_11fc;
						}
						object obj54 = legs + 32;
						obj54 = chain3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB60]");
						object obj55 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB58]");
						object obj56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7AD8]");
						object obj57 = 0;
						Chain[] array6 = legs;
						text = (string)obj56;
						text3 = (string)obj57;
						Chain chain4 = ChainOf((string)obj55, (string)obj56, (string)obj57);
						bool flag36 = legs == null;
						obj15 = 1133903872;
						obj14 = (UnityEngine.Object)obj55;
						if (!flag36)
						{
							bool flag37 = chain4 == null;
							UnityEngine.Object obj58 = (UnityEngine.Object)obj55;
							if (!flag37)
							{
								nint num7 = (nint)array6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v65 (Il2CppClass<Chain[]>)+40]");
								obj58 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag38 = ex2 == null;
								obj15 = 1133903872;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v65 (Il2CppClass<Chain[]>)+40]");
								obj14 = (UnityEngine.Object)0;
								if (flag38)
								{
									goto IL_1231;
								}
							}
							object obj59 = array6.Length & 0xFFFFFFFEL;
							bool flag39 = obj59 == null;
							text2 = text3;
							text4 = text;
							obj14 = obj58;
							if (flag39)
							{
								goto IL_11fc;
							}
							object obj60 = legs + 40;
							obj60 = chain4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5CF8]");
							object obj61 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB30]");
							object obj62 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB20]");
							object obj63 = 0;
							int num8 = 0;
							object obj65 = default;
							object obj73 = default;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
								object obj64 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								bool flag40 = obj65 == null;
								obj15 = 1133903872;
								obj14 = (UnityEngine.Object)2;
								if (flag40)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v75+18]");
								bool flag41 = (nint)0 == 0;
								text2 = text3;
								text4 = text;
								obj14 = (UnityEngine.Object)2;
								if (!flag41)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C95B8]");
									object obj66 = 0;
									obj14 = (UnityEngine.Object)obj66;
									object obj67 = obj65 + 32;
									obj67 = obj66;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X21_v14-8]");
									object obj68 = 0 & 0xFFFFFFFEL;
									bool flag42 = obj68 == null;
									text2 = text3;
									text4 = text;
									if (!flag42)
									{
										obj14 = (UnityEngine.Object)obj61;
										object obj69 = obj65 + 40;
										obj69 = obj61;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X21_v16-10]");
										if ((nint)0 < (nint)1)
										{
											goto IL_11c8;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X21_v16-10]");
										object obj70 = 0 & 0xFFFFFFFFL;
										object obj71 = obj65 + 32;
										object obj72 = obj73;
										object obj74 = 0;
										text2 = text3;
										int num9 = (int)dictionary2;
										Transform[] array7 = array2;
										text4 = text;
										while (true)
										{
											bool flag43 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj74) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70);
											object obj75 = !flag43;
											obj73 = obj72;
											if (obj75 != null)
											{
												break;
											}
											string text6 = num8.ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X29_v5+v326 @ X28_v7*8]");
											string text7 = (string)obj62 + text6 + (string)obj63 + (string)0;
											Transform transform9 = Bone(text7);
											object obj76 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v58+E4]");
											bool flag44 = (nint)0 == 0;
											object obj77 = !flag44;
											if (obj77 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag45 = transform9 != null;
											bool flag46 = !flag45;
											obj14 = null;
											if (!flag46)
											{
												num9 = spiderCount;
												array7 = spiderLegs;
												int num10 = spiderCount + 1;
												spiderCount = num10;
												bool flag47 = spiderLegs == null;
												obj73 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X29_v5+v326 @ X28_v7*8]");
												text3 = (string)0;
												obj15 = 1133903872;
												text = null;
												obj14 = null;
												if (flag47)
												{
													goto end_IL_136c;
												}
												bool flag48 = (object)transform9 == null;
												UnityEngine.Object obj78 = null;
												if (!flag48)
												{
													nint num11 = (nint)array7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v64 (Il2CppClass<UnityEngine.Transform[]>)+40]");
													obj78 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag49 = ex2 == null;
													obj73 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X29_v5+v326 @ X28_v7*8]");
													text3 = (string)0;
													obj15 = 1133903872;
													text = null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v64 (Il2CppClass<UnityEngine.Transform[]>)+40]");
													obj14 = (UnityEngine.Object)0;
													if (flag49)
													{
														goto IL_1231;
													}
												}
												bool flag50 = num9 < array7.Length;
												object obj79 = !flag50;
												obj73 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X29_v5+v326 @ X28_v7*8]");
												text2 = (string)0;
												text4 = null;
												obj14 = obj78;
												if (obj79 != null)
												{
													break;
												}
												object obj80 = array7 + num9;
												object obj81 = obj80 + 32;
												obj81 = transform9;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												obj14 = transform9;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v75+18]");
											obj70 = 0;
											object obj82 = obj74 + 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v75+18]");
											bool flag51 = (nint)obj82 < 0;
											obj73 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X29_v5+v326 @ X28_v7*8]");
											text3 = (string)0;
											dictionary2 = (Dictionary<System.__Canon, System.__Canon>)num9;
											array2 = array7;
											text = null;
											obj72 = 0;
											obj74 = obj82;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X29_v5+v77 @ X28_v5*8]");
											text2 = (string)0;
											text4 = null;
											if (flag51)
											{
												continue;
											}
											goto IL_11c8;
										}
									}
								}
								goto IL_11fc;
								IL_11c8:
								int num12 = num8 + 1;
								bool flag52 = num12 < 4;
								num8 = num12;
								if (!flag52)
								{
									return;
								}
								continue;
								end_IL_136c:
								break;
							}
						}
					}
				}
			}
		}
		goto IL_1223;
		IL_1223:
		ex2 = new NullReferenceException();
		goto IL_1231;
		IL_1231:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	private Transform Bone(string name)
	{
		//IL_0056: Expected Obj, but got I4
		if (name != null)
		{
			if ((object)named != null)
			{
				bool flag = ((Dictionary<System.__Canon, System.__Canon>)(object)named).TryGetValue((System.__Canon)(object)name, out System.__Canon value);
				bool flag2 = !flag;
				object obj = !flag2;
				object obj2 = ~obj;
				if (obj2 == null)
				{
					return (Transform)(object)value;
				}
				return null;
			}
			return (Transform)(object)new NullReferenceException();
		}
		return null;
	}

	private Chain ChainOf(string upper, string lower, string end)
	{
		//IL_0010: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Transform transform = Bone(upper);
		Transform transform2 = Bone(lower);
		Transform transform3 = Bone(end);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = transform != null;
		bool flag3 = !flag2;
		Chain result = null;
		if (!flag3)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = transform2 != null;
			bool flag6 = !flag5;
			result = null;
			if (!flag6)
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v17+E4]");
				bool flag7 = (nint)0 == 0;
				object obj7 = !flag7;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = transform3 != null;
				bool flag9 = !flag8;
				result = null;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB78]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					_ = 2139095039;
					object obj9 = default;
					obj9._002Ector();
					object obj10 = obj9 + 16;
					obj10 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj11 = obj9 + 24;
					obj11 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj12 = obj9 + 32;
					obj12 = transform3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					result = (Chain)obj9;
				}
			}
		}
		return result;
	}

	private IEnumerator Prepare(MonsterGore baked)
	{
		//IL_0010: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB80]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj4 = obj2 + 40;
		obj4 = baked;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		return (IEnumerator)obj2;
	}

	public void PrepareNow(MonsterGore baked)
	{
		//IL_0015: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		Begin();
		IEnumerator enumerator = Prepare(baked);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj = 0;
		bool flag2 = default;
		object obj9 = default;
		object obj10;
		do
		{
			nint num = (nint)enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4 (Il2CppClass<System.Collections.IEnumerator>)+98]");
			object obj3 = (nint)0 + (nint)8;
			bool flag = flag2;
			object obj5;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v6-8]");
				object obj4 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj2--;
				obj4 = obj2 - 1;
				bool flag3 = obj4 == null;
				obj5 = obj3 + 16;
				flag2 = (nint)obj2 != 1;
				flag = flag2;
				obj3 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj6 = num + obj3;
			object obj7 = obj6 + 312;
			flag2 = flag;
			obj5 = obj3;
			goto IL_0146;
			IL_0146:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X0_v7] (should have been resolved before IL gen)");
			object obj8 = obj9 & 1;
			bool flag4 = obj8 == null;
			obj10 = !flag4;
			continue;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			goto IL_0146;
		}
		while (obj10 != null);
	}

	public unsafe void Blast(Vector3 at, float near)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0115: Expected F4, but got I
		//IL_0137: Expected Obj, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_08c8: Expected Obj, but got I
		//IL_08ec: Expected Obj, but got I
		//IL_08fd: Expected I, but got Obj
		//IL_0992: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0a01: Expected Obj, but got I4
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected Obj, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected Obj, but got Unknown
		//IL_0215: Expected F4, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		//IL_0d0a: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_0747: Expected F4, but got I4
		//IL_0a14: Expected F4, but got I4
		//IL_0a1d: Expected F4, but got I4
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected Obj, but got Unknown
		//IL_0782: Expected F4, but got I4
		//IL_078b: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_0a40: Invalid comparison between F4 and I
		//IL_0a52: Expected F4, but got I4
		//IL_0d20: Invalid comparison between Obj and F4
		//IL_0d31: Expected Obj, but got I4
		//IL_0ab8: Expected Obj, but got I4
		//IL_0a2b: Expected Obj, but got I4
		//IL_0cd0: Expected VT, but got I4
		//IL_0a8a: Expected F4, but got I4
		//IL_07a0: Expected Obj, but got I
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_0ac6: Invalid comparison between F4 and I4
		//IL_0aa1: Expected F4, but got I4
		//IL_0aaa: Expected Obj, but got I4
		//IL_0367: Expected Obj, but got I
		//IL_0af5: Expected VT, but got Ref
		//IL_0800: Expected VT, but got I4
		//IL_0800: Expected Obj, but got I
		//IL_0b8a: Expected Obj, but got I4
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected Obj, but got Unknown
		//IL_083f: Expected VT, but got I4
		//IL_083f: Expected Obj, but got I
		//IL_0861: Expected Ref, but got VT
		//IL_0861: Expected VT, but got I4
		//IL_0861: Expected VT, but got I
		//IL_0861: Expected VT, but got Ref
		//IL_0874: Expected F4, but got I4
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_0c81: Invalid comparison between Obj and F4
		//IL_0402: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I4
		//IL_04ca: Expected Obj, but got I
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0504: Expected Obj, but got I
		//IL_051e: Expected Ref, but got VT
		//IL_051e: Expected VT, but got I
		//IL_051e: Expected VT, but got I4
		//IL_051e: Expected VT, but got Ref
		//IL_0560: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I
		//IL_05b4: Expected Ref, but got VT
		//IL_05b4: Expected VT, but got I
		//IL_05b4: Expected VT, but got I4
		//IL_05b4: Expected VT, but got Ref
		//IL_060e: Expected Obj, but got I4
		//IL_066a: Expected Obj, but got I4
		//IL_0bf5: Invalid comparison between F4 and I4
		//IL_0c13: Invalid comparison between F4 and I4
		//IL_0c26: Expected Obj, but got I4
		//IL_0c40: Expected Obj, but got I4
		//IL_065c: Expected Obj, but got I4
		//IL_0c62: Expected Obj, but got I4
		//IL_068c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB88]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj29 = default;
		Vector3 vector = default;
		object obj13;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			bool flag = isActiveAndEnabled;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v47+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				flag = Application.isPlaying;
				bool flag4 = !flag;
				object obj8 = !flag4;
				if (obj8 != null)
				{
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Object)+24]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Object)+24]");
			bool flag5 = (nint)0 < (nint)0;
			object obj9 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Object)+24]");
			bool flag6 = (nint)0 == 0;
			object obj10 = ~obj9;
			object obj11 = obj10 | flag6;
			if (obj11 != null)
			{
				return;
			}
			if (~(ready ? 1u : 0u) == 0)
			{
				MonsterGore monsterGore = gore;
				if ((object)gore != null)
				{
					MonsterNavMesh.Arm[] array = monsterGore.arms;
					if (monsterGore.arms != null)
					{
						object obj12 = array.Length;
						if (array.Length >= 1)
						{
							float num2 = 2.139095E+09f;
							obj13 = 0;
							object obj14 = 0;
							IntPtr intPtr = default;
							while (true)
							{
								bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
								object obj15 = !flag7;
								if (obj15 != null)
								{
									break;
								}
								object obj16 = (object)monsterGore.arms + obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v33+20]");
								object obj17 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v33+20]");
								if ((nint)0 != 0)
								{
									Chain[] array2 = arms;
									if (arms != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X26_v10+10]");
										object obj18 = -2;
										bool flag8 = obj18 == null;
										object obj19 = !flag8;
										bool flag9 = (nint)obj19 < array2.Length;
										object obj20 = !flag9;
										if (obj20 != null)
										{
											break;
										}
										int[] array3 = armState;
										if (armState != null)
										{
											bool flag10 = (nint)obj19 < array3.Length;
											object obj21 = !flag10;
											if (obj21 != null)
											{
												break;
											}
											object obj22 = (object)arms + obj19;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X11_v9+20]");
											object obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ X11_v9+20]");
											if ((nint)0 != 0)
											{
												object obj24 = (object)armState + obj19;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X11_v11+20]");
												if ((nint)0 != 2)
												{
													MonsterGore monsterGore2 = gore;
													if ((object)gore != null)
													{
														bool flag11 = (byte)(~(monsterGore2.legs ? 1u : 0u)) != 0;
														object obj25 = !flag11;
														if (obj25 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X26_v10+10]");
															object obj26 = -2;
															bool flag12 = obj26 == null;
															bool flag13 = (flag12 ? 1 : 0) < array3.Length;
															object obj27 = !flag13;
															if (obj27 != null)
															{
																break;
															}
															object obj28 = armState + flag12;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ X8_v46+20]");
															if ((nint)0 == 2)
															{
																goto IL_0b80;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+10]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+10]");
															Vector3 position = ((Transform)0).position;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+18]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+18]");
																Vector3 position2 = ((Transform)0).position;
																float num3 = ToSegment((Vector3)(&obj29), (Vector3)0, (Vector3)(nint)intPtr, out *(Vector3*)vector);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+18]");
																if ((nint)0 != 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+18]");
																	Vector3 position3 = ((Transform)0).position;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+20]");
																	if ((nint)0 != 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X28_v10+20]");
																		Vector3 position4 = ((Transform)0).position;
																		num = ToSegment((Vector3)(&obj29), (Vector3)0, (Vector3)(nint)intPtr, out *(Vector3*)vector);
																		int[] array4 = armState;
																		if (num3 < num)
																		{
																			num = num3;
																		}
																		if (armState != null)
																		{
																			bool flag14 = (nint)obj19 < array4.Length;
																			object obj30 = !flag14;
																			if (obj30 != null)
																			{
																				break;
																			}
																			object obj31 = (object)armState + obj19;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v39+20]");
																			if ((nint)0 == 1)
																			{
																				object obj32 = 36;
																			}
																			else
																			{
																				object obj32 = 32;
																			}
																			float num4 = num;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterWounds)+v1140 @ X8_v41]");
																			float num5 = num4 - 0f;
																			bool flag15 = num5 < 0f;
																			float num6 = num - num2;
																			bool flag16 = num6 < 0f;
																			object obj33 = flag15 & flag16;
																			bool flag17 = obj33 == null;
																			object obj34 = !flag17;
																			object obj35 = ~obj34;
																			if (obj35 == null)
																			{
																				num2 = num;
																			}
																			object obj36 = !flag17;
																			object obj37 = ~obj36;
																			if (obj37 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v33+20]");
																				obj13 = 0;
																				flag = (byte)(&obj29) != 0;
																			}
																			else
																			{
																				flag = (byte)(&obj29) != 0;
																			}
																			goto IL_0b80;
																		}
																	}
																}
															}
														}
													}
													goto IL_0b3b;
												}
											}
											goto IL_0b80;
										}
									}
								}
								goto IL_0b3b;
								IL_0b80:
								obj12 = array.Length;
								obj14++;
								if ((nint)obj14 < array.Length)
								{
									continue;
								}
								goto IL_06a8;
							}
							goto IL_0b49;
						}
						obj13 = 0;
						goto IL_06c5;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
				object obj38 = 0;
				List<System.__Canon> list = (List<System.__Canon>)(object)waitingCalls;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDB98]");
				object obj39 = 0;
				Action action = default;
				action._002Ector(obj2, (IntPtr)obj39);
				if ((object)waitingCalls != null)
				{
					System.__Canon[] items = list._items;
					int version = list._version + 1;
					list._version = version;
					if (list._items != null)
					{
						bool flag18 = list._size < items.Length;
						object obj40 = !flag18;
						if (obj40 == null)
						{
							object obj41 = list._items + list._size;
							int size = list._size + 1;
							list._size = size;
							object obj42 = obj41 + 32;
							obj42 = action;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							((List<System.__Canon>)(object)waitingCalls).AddWithResize((System.__Canon)(object)action);
						}
						return;
					}
				}
			}
		}
		goto IL_0b3b;
		IL_0b3b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0b49;
		IL_06a8:
		if (obj13 != null)
		{
			goto IL_06c5;
		}
		goto IL_06e5;
		IL_0c95:
		float num7;
		object obj43;
		if ((double)num7 < 1.0)
		{
			obj43 = 3;
		}
		else
		{
			float num8 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB6C]");
			bool flag19 = !(num8 < 0f);
			float num9 = 17276928f;
			if (!flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3 (System.Object)+24]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
				bool flag20 = num10 <= 0;
				num9 = 17276928f;
				if (!flag20)
				{
					num9 = 17276928f;
					obj43 = 2;
					goto IL_0cb9;
				}
			}
			obj43 = 1;
		}
		goto IL_0cb9;
		IL_06c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X22_v13+10]");
		Say(1, (GoreSection)0, vector);
		goto IL_06e5;
		IL_06e5:
		MonsterGore monsterGore3 = gore;
		if ((object)gore != null)
		{
			MonsterGore.Limb[] limbs = monsterGore3.limbs;
			if (monsterGore3.limbs != null)
			{
				float num9 = limbs.Length;
				if (limbs.Length >= 1)
				{
					object obj44 = monsterGore3.limbs + 32;
					num7 = 2.139095E+09f;
					object obj45 = 0;
					while (true)
					{
						bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9);
						object obj46 = !flag21;
						if (obj46 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X23_v9+v243 @ X22_v11*8]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X23_v9+v243 @ X22_v11*8]");
						if ((nint)0 != 0 && (object)wounds != null)
						{
							GillaWounds gillaWounds = wounds;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X24_v10+18]");
							Vector3 vector2 = gillaWounds.World((string)0, (Vector3)0);
							if ((object)wounds != null)
							{
								GillaWounds gillaWounds2 = wounds;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X24_v10+18]");
								Vector3 vector3 = gillaWounds2.World((string)0, (Vector3)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X24_v10+18]");
								float num11 = ToSegment((Vector3)(&obj29), (Vector3)0, (Vector3)0, out *(Vector3*)vector);
								num9 = limbs.Length;
								obj45++;
								if (!(num7 < num11))
								{
									num7 = num11;
								}
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9))
								{
									continue;
								}
								goto IL_0c95;
							}
						}
						goto IL_0b3b;
					}
					goto IL_0b49;
				}
				num7 = 2.139095E+09f;
				num9 = 2.139095E+09f;
				goto IL_0c95;
			}
		}
		goto IL_0b3b;
		IL_0cb9:
		float num12 = default;
		ref Vector3 point = default;
		while (true)
		{
			if (Pick((Vector3)0, (byte)(&num12) != 0, out var limb, out point))
			{
				if (num12 == 0f)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ stack_-58_v6 (System.Single)+10]");
				Say(0, (GoreSection)0, (Vector3)(&limb));
			}
			obj43--;
			if ((nint)obj43 == 1)
			{
				return;
			}
		}
		goto IL_0b3b;
		IL_0b49:
		throw new IndexOutOfRangeException();
	}

	public unsafe void Trapped(Vector3 at)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b7: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_0130: Expected VT, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I4
		//IL_016c: Expected VT, but got Ref
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBC8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bool flag = isActiveAndEnabled;
		bool flag2 = !flag;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v21+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			bool flag4 = !isPlaying;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				return;
			}
		}
		if (~(ready ? 1u : 0u) == 0)
		{
			object obj9 = default;
			ref Vector3 point = default;
			if (Pick((Vector3)1, (byte)(&obj9) != 0, out var limb, out point))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ stack_-38_v4+10]");
				Say(2, (GoreSection)0, (Vector3)(&limb));
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj10 = 0;
		List<System.__Canon> list = (List<System.__Canon>)(object)waitingCalls;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBD0]");
		object obj11 = 0;
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj11);
		System.__Canon[] items = list._items;
		int version = list._version + 1;
		list._version = version;
		bool flag5 = list._size < items.Length;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			object obj13 = items + list._size;
			int size = list._size + 1;
			list._size = size;
			object obj14 = obj13 + 32;
			obj14 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		else
		{
			list.AddWithResize((System.__Canon)(object)action);
		}
	}

	public void Stabbed(GoreSection section, Vector3 point)
	{
		//IL_00df: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_00b9: Expected VT, but got I
		//IL_007f: Expected Obj, but got I4
		bool flag = isActiveAndEnabled;
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			bool flag4 = !isPlaying;
			object obj5 = !flag4;
			if (obj5 != null)
			{
				return;
			}
		}
		if (~(ready ? 1u : 0u) == 0)
		{
			IntPtr intPtr = default;
			Say(0, section, (Vector3)(nint)intPtr);
		}
	}

	public unsafe bool Hit(Vector3 at, float reach, out GoreSection section, out Vector3 point)
	{
		//IL_000e: Expected F4, but got I4
		//IL_0009: Expected native int or pointer, but got VT
		//IL_0602: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_05cb: Expected Obj, but got I4
		//IL_052e: Expected F4, but got I
		//IL_0529: Expected native int or pointer, but got VT
		//IL_00c7: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_011e: Expected F4, but got I
		//IL_0127: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_072c: Expected Obj, but got I4
		//IL_0569: Expected VT, but got I4
		//IL_0569: Expected Obj, but got I
		//IL_0589: Expected VT, but got I4
		//IL_059a: Expected Ref, but got F4
		//IL_0167: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I8
		//IL_02f8: Expected VT, but got I4
		//IL_02f8: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_0631: Expected Obj, but got I4
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0339: Expected VT, but got I4
		//IL_0339: Expected Obj, but got I
		//IL_035b: Expected VT, but got I4
		//IL_035b: Expected VT, but got I
		//IL_035b: Expected VT, but got Ref
		//IL_03b8: Expected F4, but got I
		//IL_03c1: Expected Obj, but got Ref
		//IL_0761: Expected Obj, but got I4
		//IL_046e: Invalid comparison between F4 and I
		//IL_04cf: Expected Obj, but got I
		//IL_04d7: Expected F4, but got Obj
		//IL_04e7: Expected F4, but got I
		//IL_04f7: Expected F4, but got I
		//IL_06f1: Expected Obj, but got I
		((Vector3*)(nint)at)->x = 1f;
		_ = 0;
		ref GoreSection reference = ref *(GoreSection*)null;
		if (~(ready ? 1u : 0u) != 0)
		{
			goto IL_05d8;
		}
		MonsterGore monsterGore = gore;
		float num8;
		object obj4;
		if ((object)gore != null)
		{
			MonsterGore.Limb[] limbs = monsterGore.limbs;
			if (monsterGore.limbs != null)
			{
				object obj = limbs.Length;
				float num2 = default;
				float num4 = default;
				float num5;
				float num6;
				if (limbs.Length >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
					object obj3 = 0;
					float num = num2;
					float num3 = num4;
					MonsterWounds monsterWounds = this;
					num5 = num2;
					num6 = num4;
					obj4 = 0;
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
					float num7 = 0f;
					object obj6 = 17276928;
					num8 = reach;
					float num10 = default;
					float num9 = num10;
					object obj7 = 0;
					object obj14 = default;
					while (true)
					{
						bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
						object obj8 = !flag;
						if (obj8 != null)
						{
							break;
						}
						object obj9 = (object)monsterGore.limbs + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+20]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+20]");
						if ((nint)0 == 0)
						{
							goto IL_05e6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+10]");
						int num11;
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+10]");
							if ((nint)0 != 2)
							{
								goto IL_02bd;
							}
							int[] array = armState;
							if (armState == null)
							{
								goto IL_05e6;
							}
							obj6 = array.Length;
							if (array.Length == 0)
							{
								break;
							}
							num11 = array[0];
						}
						else
						{
							int[] array2 = armState;
							if (armState == null)
							{
								goto IL_05e6;
							}
							obj6 = array2.Length;
							object obj11 = array2.Length & 0xFFFFFFFEL;
							if (obj11 == null)
							{
								break;
							}
							num11 = array2[1];
						}
						bool flag2 = num11 == 2;
						object obj12 = obj6;
						if (!flag2)
						{
							goto IL_02bd;
						}
						goto IL_0627;
						IL_0627:
						obj = limbs.Length;
						obj5++;
						bool flag3 = (nint)obj5 < limbs.Length;
						obj6 = obj12;
						if (flag3)
						{
							continue;
						}
						goto IL_04fc;
						IL_02bd:
						if ((object)wounds != null)
						{
							GillaWounds gillaWounds = wounds;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+18]");
							Vector3 vector = gillaWounds.World((string)0, (Vector3)0);
							if ((object)wounds != null)
							{
								GillaWounds gillaWounds2 = wounds;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+18]");
								Vector3 vector2 = gillaWounds2.World((string)0, (Vector3)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+18]");
								num7 = ToSegment((Vector3)(&obj7), (Vector3)0, (Vector3)0, out point);
								num = perUnit;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+38]");
								num3 = 0f * perUnit;
								float num12 = num7 - num3;
								bool flag4 = !(num12 < num9);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+20]");
								num10 = 0f;
								monsterWounds = (MonsterWounds)(&obj7);
								obj12 = obj6;
								if (!flag4)
								{
									monsterWounds = (MonsterWounds)obj3;
									bool flag5 = monsterWounds.trappedSide == 0;
									object obj13 = !flag5;
									if (obj13 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num13 = reach - (float)obj7;
									float num14 = num4 - (float)obj14;
									float num15 = num13 * num13;
									float num16 = num14 * num14;
									float num17 = num15 + num16;
									float num18 = num2 * num2;
									float num19 = num17 + num18;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									float num20;
									float num21;
									float num22;
									if (num19 > 0f)
									{
										num20 = num13 / num19;
										num21 = num14 / num19;
										num22 = num2 / num19;
									}
									else
									{
										object obj15 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v23+A0]");
										object obj16 = 0;
										num20 = (float)obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v24+4]");
										num21 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v24+8]");
										num22 = 0f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X29_v8+38]");
									float num23 = 0f * perUnit;
									float num24 = num20 * num23;
									num3 = num21 * num23;
									num = num22 * num23;
									num8 = (float)obj7 + num24;
									num10 = (float)obj14 + num3;
									num5 = num;
									num6 = num10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+20]");
									obj4 = 0;
									num7 = num;
									obj12 = obj6;
									num9 = num12;
								}
								goto IL_0627;
							}
						}
						goto IL_05e6;
					}
					goto IL_05f4;
				}
				num5 = num2;
				num6 = num4;
				obj4 = 0;
				num8 = reach;
				goto IL_0519;
			}
		}
		goto IL_05e6;
		IL_04fc:
		if (obj4 != null)
		{
			goto IL_0519;
		}
		goto IL_05d8;
		IL_05e6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05f4;
		IL_05f4:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (byte)(int)ex2 != 0;
		IL_05d8:
		return false;
		IL_0519:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X27_v7+10]");
		((Vector3*)(nint)at)->x = 0f;
		if ((object)wounds != null)
		{
			GillaWounds gillaWounds3 = wounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X27_v7+18]");
			Vector3 vector3 = gillaWounds3.OnBody((string)0, (Vector3)0);
			GillaWounds gillaWounds4 = wounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X27_v7+10]");
			Vector3 vector4 = gillaWounds4.NearestSkin((GoreSection)0, (Vector3)0);
			reference = ref *(GoreSection*)num8;
			return true;
		}
		goto IL_05e6;
	}

	private unsafe bool Pick(Vector3 at, bool low, out MonsterGore.Limb limb, out Vector3 point)
	{
		//IL_1ff1: Expected Obj, but got I4
		//IL_1ffb: Expected F4, but got I4
		//IL_203e: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_0056: Invalid comparison between F4 and I4
		//IL_00f1: Expected Obj, but got I4
		//IL_00fb: Expected F4, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I4
		//IL_019d: Expected F4, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got I4
		//IL_0732: Expected F8, but got I4
		//IL_209d: Expected Obj, but got I4
		//IL_20a7: Expected F4, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_0255: Expected F4, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_0749: Expected Obj, but got I
		//IL_0769: Expected Obj, but got I4
		//IL_0773: Expected F4, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I4
		//IL_02d8: Expected F4, but got I4
		//IL_07a9: Expected Obj, but got I
		//IL_07b9: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I4
		//IL_036c: Invalid comparison between F4 and I4
		//IL_16cc: Expected F4, but got I4
		//IL_16d5: Expected F4, but got I4
		//IL_2270: Invalid comparison between F4 and I4
		//IL_2281: Expected Obj, but got I4
		//IL_228b: Invalid comparison between F4 and I4
		//IL_22a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22aa: Expected I4, but got Unknown
		//IL_07ee: Expected F8, but got I
		//IL_07fe: Expected Obj, but got I
		//IL_080e: Expected Obj, but got I
		//IL_0818: Expected F4, but got I4
		//IL_0821: Expected F4, but got I4
		//IL_082a: Expected F4, but got I4
		//IL_03bc: Expected F8, but got I4
		//IL_03c5: Expected Obj, but got I4
		//IL_26b5: Invalid comparison between F4 and I4
		//IL_26c6: Expected Obj, but got I4
		//IL_26cf: Invalid comparison between F4 and I4
		//IL_26e0: Expected Obj, but got I4
		//IL_26ed: Expected I4, but got Obj
		//IL_2622: Invalid comparison between Ref and Obj
		//IL_2633: Expected Obj, but got I4
		//IL_264c: Invalid comparison between F4 and I4
		//IL_2748: Expected Obj, but got I4
		//IL_2761: Invalid comparison between F4 and I4
		//IL_1707: Expected Obj, but got I4
		//IL_1fa6: Expected I4, but got Obj
		//IL_084a: Expected Obj, but got Ref
		//IL_0874: Expected Obj, but got I4
		//IL_088e: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I4
		//IL_0416: Expected F4, but got I4
		//IL_1756: Expected Obj, but got I
		//IL_1768: Expected VT, but got I4
		//IL_22d6: Expected Obj, but got I
		//IL_22de: Invalid comparison between VT and Obj
		//IL_22ef: Expected Obj, but got I4
		//IL_2308: Invalid comparison between F4 and I4
		//IL_231a: Invalid comparison between VT and Obj
		//IL_232c: Expected Obj, but got I4
		//IL_08ac: Expected Obj, but got I
		//IL_08ce: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_049f: Invalid comparison between F4 and I4
		//IL_04b6: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected I4, but got Unknown
		//IL_0a1f: Expected Obj, but got I4
		//IL_0a39: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got I4
		//IL_177a: Expected I4, but got VT
		//IL_1796: Invalid comparison between F4 and I4
		//IL_17a7: Expected Obj, but got I4
		//IL_17b1: Invalid comparison between F4 and I4
		//IL_17cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d0: Expected I4, but got Unknown
		//IL_17d9: Expected Obj, but got I4
		//IL_092a: Expected Obj, but got I4
		//IL_0944: Invalid comparison between F4 and I4
		//IL_04ff: Expected Obj, but got I4
		//IL_051b: Expected F4, but got Obj
		//IL_18c9: Expected Obj, but got I
		//IL_18d8: Expected I4, but got VT
		//IL_18e9: Expected I4, but got Obj
		//IL_0a6b: Expected I4, but got I8
		//IL_0ab7: Expected Obj, but got I4
		//IL_0ad1: Expected Obj, but got I4
		//IL_259c: Expected Obj, but got I
		//IL_25a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25aa: Expected Obj, but got Unknown
		//IL_25cb: Expected Obj, but got I4
		//IL_25ec: Invalid comparison between F4 and I4
		//IL_1905: Expected Obj, but got I4
		//IL_181c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Expected VT, but got Unknown
		//IL_183d: Expected Obj, but got I4
		//IL_1846: Expected Obj, but got I4
		//IL_0992: Expected Obj, but got I4
		//IL_09ac: Expected Obj, but got I4
		//IL_0553: Expected Obj, but got I4
		//IL_055d: Expected F4, but got I4
		//IL_0a98: Expected Obj, but got I
		//IL_0afb: Expected VT, but got I4
		//IL_0afb: Expected Obj, but got I
		//IL_0b19: Expected Obj, but got I4
		//IL_0b29: Expected F4, but got I
		//IL_0b39: Expected F8, but got I
		//IL_0b49: Expected F8, but got I
		//IL_0b65: Expected Obj, but got I4
		//IL_20e7: Expected Obj, but got I4
		//IL_059d: Expected F8, but got I
		//IL_05ad: Expected F8, but got I
		//IL_05bd: Expected F4, but got I
		//IL_05d9: Expected VT, but got I4
		//IL_05d9: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I4
		//IL_0601: Expected F4, but got I4
		//IL_2139: Expected Obj, but got I
		//IL_0b8f: Expected VT, but got I4
		//IL_0b8f: Expected Obj, but got I
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected Obj, but got Unknown
		//IL_0bc0: Expected VT, but got I
		//IL_0bc9: Expected VT, but got I4
		//IL_1963: Expected F4, but got Obj
		//IL_197c: Expected VT, but got I4
		//IL_197c: Expected Obj, but got I4
		//IL_198d: Expected Obj, but got I4
		//IL_19b1: Expected F8, but got I
		//IL_19c1: Expected F8, but got I
		//IL_0fbf: Expected VT, but got Ref
		//IL_105b: Invalid comparison between F4 and I4
		//IL_106c: Expected Obj, but got I4
		//IL_1076: Invalid comparison between F4 and I4
		//IL_1088: Invalid comparison between F4 and I4
		//IL_0643: Expected F8, but got I
		//IL_065f: Expected VT, but got I4
		//IL_065f: Expected Obj, but got I
		//IL_16bd: Expected Obj, but got I4
		//IL_0be7: Expected Obj, but got I
		//IL_0c09: Expected Obj, but got I4
		//IL_0c2b: Invalid comparison between F4 and I4
		//IL_0c40: Expected Obj, but got I4
		//IL_0c4d: Expected I4, but got Obj
		//IL_06b7: Expected F4, but got I
		//IL_19f9: Expected F8, but got I
		//IL_1a09: Expected F8, but got I
		//IL_10a8: Expected F4, but got I4
		//IL_0d93: Expected Obj, but got I4
		//IL_0da3: Expected F8, but got I
		//IL_0db3: Expected F4, but got I
		//IL_0dc3: Expected F4, but got I
		//IL_0dd3: Expected F8, but got I
		//IL_0de3: Expected F4, but got I
		//IL_0df3: Expected F4, but got I
		//IL_0e03: Expected F4, but got I
		//IL_0e13: Expected F8, but got I
		//IL_0e23: Expected F8, but got I
		//IL_0e3f: Expected Obj, but got I4
		//IL_06a2: Expected F4, but got I
		//IL_267c: Expected Obj, but got I
		//IL_269e: Expected Obj, but got I4
		//IL_0c7d: Expected Obj, but got I4
		//IL_0c9f: Invalid comparison between F4 and I4
		//IL_0cdb: Expected F8, but got I
		//IL_0ceb: Expected F4, but got I
		//IL_0cfb: Expected F4, but got I
		//IL_0d0b: Expected F8, but got I
		//IL_0d1b: Expected F4, but got I
		//IL_0d2b: Expected F4, but got I
		//IL_0d3b: Expected F4, but got I
		//IL_0d4b: Expected F8, but got I
		//IL_0d5b: Expected F8, but got I
		//IL_06f3: Expected F8, but got I
		//IL_1a39: Expected VT, but got I4
		//IL_1a39: Expected Obj, but got I4
		//IL_1a58: Expected VT, but got I4
		//IL_1a58: Expected VT, but got I4
		//IL_1a58: Expected VT, but got Ref
		//IL_10ed: Expected Obj, but got I4
		//IL_1105: Expected F8, but got I
		//IL_1115: Expected F4, but got I
		//IL_1125: Expected F4, but got I
		//IL_1135: Expected F8, but got I
		//IL_1145: Expected F8, but got I
		//IL_114e: Expected F8, but got I4
		//IL_1173: Expected Obj, but got I4
		//IL_0e5d: Expected Obj, but got I
		//IL_0e72: Expected Obj, but got I
		//IL_0e90: Expected Obj, but got I4
		//IL_0ea8: Expected F8, but got I
		//IL_0eb8: Expected F4, but got I
		//IL_0ec8: Expected F4, but got I
		//IL_0ed8: Expected F8, but got I
		//IL_0ee8: Expected F4, but got I
		//IL_0ef8: Expected F4, but got I
		//IL_0f08: Expected F4, but got I
		//IL_0f18: Expected F8, but got I
		//IL_0f28: Expected F8, but got I
		//IL_06d4: Expected F8, but got I
		//IL_1b16: Invalid comparison between F4 and I
		//IL_1b2c: Expected F4, but got Obj
		//IL_2380: Expected F4, but got I
		//IL_2380: Expected F4, but got I
		//IL_239c: Invalid comparison between F4 and I4
		//IL_23ab: Expected F8, but got I4
		//IL_1191: Expected F8, but got I
		//IL_11b0: Expected I4, but got Obj
		//IL_11ed: Expected Obj, but got I4
		//IL_1205: Expected F8, but got I
		//IL_1215: Expected F4, but got I
		//IL_1225: Expected F4, but got I
		//IL_122e: Expected F8, but got I4
		//IL_1260: Expected Obj, but got I4
		//IL_0fa5: Expected F8, but got I
		//IL_1c06: Invalid comparison between F4 and I4
		//IL_1c17: Expected Obj, but got I4
		//IL_129c: Expected Obj, but got I4
		//IL_12bc: Invalid comparison between F4 and I4
		//IL_21a2: Invalid comparison between F4 and I4
		//IL_21b3: Expected Obj, but got I4
		//IL_21c9: Expected VT, but got Obj
		//IL_21d2: Expected VT, but got I4
		//IL_21ea: Expected F8, but got I
		//IL_21fa: Expected F4, but got I
		//IL_220a: Expected F4, but got I
		//IL_221a: Expected F8, but got I
		//IL_222a: Expected F4, but got I
		//IL_223a: Expected F4, but got I
		//IL_224a: Expected F8, but got I
		//IL_0f90: Expected F8, but got I
		//IL_247f: Expected Obj, but got I4
		//IL_1347: Expected Obj, but got I
		//IL_1357: Expected Obj, but got I
		//IL_1c8f: Expected F4, but got I
		//IL_1c9f: Expected VT, but got I
		//IL_1ce6: Invalid comparison between F8 and I
		//IL_1396: Expected Obj, but got I4
		//IL_13ae: Expected F8, but got I
		//IL_13be: Expected F4, but got I
		//IL_13ce: Expected F4, but got I
		//IL_13d7: Expected F8, but got I4
		//IL_13fe: Expected Obj, but got I4
		//IL_12e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12eb: Expected Obj, but got Unknown
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_1319: Expected Obj, but got Unknown
		//IL_1d4c: Expected Obj, but got I
		//IL_1d54: Expected F4, but got Obj
		//IL_1d64: Expected F8, but got I
		//IL_1d74: Expected F8, but got I
		//IL_24a6: Expected F4, but got I
		//IL_141c: Expected Obj, but got I
		//IL_1424: Expected I4, but got Obj
		//IL_145f: Expected Obj, but got I4
		//IL_1477: Expected F8, but got I
		//IL_1487: Expected F4, but got I
		//IL_1497: Expected F4, but got I
		//IL_14a0: Expected F8, but got I4
		//IL_14c7: Expected Obj, but got I4
		//IL_2721: Expected Obj, but got I4
		//IL_152a: Expected Obj, but got I4
		//IL_1dab: Expected Obj, but got I4
		//IL_1dc4: Invalid comparison between F8 and I4
		//IL_1e3c: Expected Obj, but got I
		//IL_1e44: Expected F4, but got Obj
		//IL_1e54: Expected F8, but got I
		//IL_1e64: Expected F8, but got I
		//IL_166f: Expected F8, but got I
		//IL_167f: Expected F4, but got I
		//IL_168f: Expected F4, but got I
		//IL_1604: Expected Obj, but got I
		//IL_252f: Expected Obj, but got I4
		//IL_2553: Expected F8, but got I
		//IL_2563: Expected F4, but got I
		//IL_257e: Expected Obj, but got I4
		//IL_1e73: Expected I4, but got Obj
		//IL_1e7e: Expected I4, but got Obj
		//IL_1e8e: Expected F8, but got I
		//IL_1e9e: Expected F4, but got I
		//IL_1eb9: Expected Obj, but got I4
		//IL_1f53: Expected VT, but got I4
		//IL_1f53: Expected Obj, but got I4
		//IL_1f70: Expected VT, but got I4
		//IL_1f70: Expected I4, but got Obj
		//IL_1f81: Expected Ref, but got F4
		((bool*)(low ? 1 : 0))->m_value = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		_ = 0;
		ref MonsterGore.Limb reference = ref *(MonsterGore.Limb*)null;
		List<MonsterGore.Limb> list = pickFrom;
		bool flag = pickFrom == null;
		object obj = 0;
		float num = 0f;
		float num3 = default;
		float num2 = num3;
		double num5 = default;
		double num4 = num5;
		double num7 = default;
		double num6 = num7;
		ref Vector3 reference2 = ref System.Runtime.CompilerServices.Unsafe.As<MonsterGore.Limb, Vector3>(ref limb);
		Vector3 vector = at;
		bool flag2 = low;
		ref MonsterGore.Limb reference3 = ref limb;
		object obj2 = 109895680;
		object obj6;
		bool flag5;
		double num9;
		object obj3;
		bool flag4;
		ref MonsterGore.Limb reference4;
		if (!flag)
		{
			int version = list._version + 1;
			bool flag3 = list._size < 1;
			obj3 = !flag3;
			float num8 = (float)list._size - 1f;
			flag4 = num8 == 0f;
			list._size = 0;
			list._version = version;
			flag5 = list._size < 1;
			reference2 = ref System.Runtime.CompilerServices.Unsafe.As<MonsterGore.Limb, Vector3>(ref limb);
			if (!flag5)
			{
				Array.Clear(list._items, 0, list._size);
				reference2 = ref *(Vector3*)null;
			}
			list = (List<MonsterGore.Limb>)(object)pickWeights;
			bool flag6 = pickWeights == null;
			obj = 0;
			num = 0f;
			num2 = num3;
			num4 = num5;
			num6 = num7;
			vector = at;
			flag2 = low;
			reference3 = ref limb;
			obj2 = 109895680;
			if (!flag6)
			{
				version = list._version + 1;
				list._size = 0;
				list._version = version;
				Transform transform = base.transform;
				bool flag7 = (object)transform == null;
				obj = 0;
				num = 0f;
				num2 = num3;
				num4 = num5;
				num6 = num7;
				vector = at;
				flag2 = low;
				reference3 = ref limb;
				obj2 = 109895680;
				if (!flag7)
				{
					Vector3 position = transform.position;
					object obj4 = at & 1;
					bool flag8 = obj4 == null;
					obj2 = 109895680;
					if (flag8)
					{
						goto IL_0711;
					}
					list = (List<MonsterGore.Limb>)(object)gore;
					bool flag9 = (object)gore == null;
					obj = 0;
					num = 0f;
					num2 = num3;
					num4 = num5;
					num6 = num7;
					vector = at;
					flag2 = low;
					reference3 = ref limb;
					obj2 = 109895680;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+30]");
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+30]");
						bool flag10 = (nint)0 == 0;
						obj = 0;
						num = 0f;
						num2 = num3;
						num4 = num5;
						num6 = num7;
						vector = at;
						flag2 = low;
						reference3 = ref limb;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
							bool flag11 = (nint)0 < (nint)1;
							obj3 = !flag11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
							num8 = 0f - 1f;
							flag4 = num8 == 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
							if ((nint)0 < (nint)1)
							{
								goto IL_0711;
							}
							num2 = num3;
							num4 = num5;
							num6 = num7;
							num9 = 2139095039.0;
							obj6 = 0;
							version = 2139095039;
							while (true)
							{
								bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
								obj3 = !flag12;
								num8 = (float)obj6 - (float)obj5;
								flag4 = num8 == 0f;
								if (obj3 != null)
								{
									break;
								}
								list = (List<MonsterGore.Limb>)(object)(obj2 + obj6);
								object syncRoot = list._syncRoot;
								bool flag13 = list._syncRoot == null;
								obj = 0;
								num = 0f;
								reference4 = ref *(MonsterGore.Limb*)1;
								vector = at;
								flag2 = low;
								reference3 = ref limb;
								if (!flag13)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+10]");
									version = 1 << 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+10]");
									bool flag14 = (nint)0 < (nint)5;
									object obj7 = !flag14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+10]");
									num8 = 0f - 5f;
									bool flag15 = num8 == 0f;
									list = (List<MonsterGore.Limb>)(version & 0x32);
									object obj8 = ~obj7;
									if (((obj8 | flag15) ? 1 : 0) != 0)
									{
										bool flag16 = (nint)list < 0;
										obj3 = !flag16;
										flag4 = list == null;
										num8 = (float)list;
									}
									else
									{
										flag4 = true;
										obj3 = 0;
									}
									if (flag4)
									{
										goto IL_258c;
									}
									bool flag17 = (object)wounds == null;
									obj = 0;
									num = 0f;
									reference4 = ref *(MonsterGore.Limb*)1;
									vector = at;
									flag2 = low;
									reference3 = ref limb;
									if (!flag17)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+24]");
										num6 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+28]");
										num4 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+20]");
										num2 = 0f;
										GillaWounds gillaWounds = wounds;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+18]");
										Vector3 vector2 = gillaWounds.World((string)0, (Vector3)0);
										bool flag18 = (object)wounds == null;
										obj = 0;
										num = 0f;
										reference4 = ref *(MonsterGore.Limb*)1;
										vector = at;
										flag2 = low;
										reference3 = ref limb;
										if (!flag18)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+34]");
											num4 = 0.0;
											GillaWounds gillaWounds2 = wounds;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+18]");
											position = gillaWounds2.World((string)0, (Vector3)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+24]");
											nint num10 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+30]");
											if (num10 < 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+24]");
												num2 = 0f;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+30]");
												num2 = 0f;
											}
											if (num9 < (double)num2)
											{
												float num11 = (float)num6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+30]");
												num6 = 0.0;
											}
											else
											{
												float num11 = (float)num6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+30]");
												num6 = 0.0;
												num9 = num2;
											}
											goto IL_258c;
										}
									}
								}
								goto IL_187f;
								IL_258c:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
								obj5 = 0;
								obj6++;
								object obj9 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
								bool flag19 = (nint)obj9 < 0;
								obj3 = !flag19;
								float num12 = (float)obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
								num8 = num12 - 0f;
								flag4 = num8 == 0f;
								object obj10 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X19_v8+18]");
								if ((nint)obj10 < 0)
								{
									continue;
								}
								goto IL_0702;
							}
							goto IL_1f98;
						}
					}
				}
			}
		}
		goto IL_187f;
		IL_0711:
		num2 = num3;
		num4 = num5;
		num6 = num7;
		num9 = 2139095039.0;
		goto IL_2079;
		IL_2079:
		list = (List<MonsterGore.Limb>)(object)gore;
		bool flag20 = (object)gore == null;
		obj = 0;
		num = 0f;
		vector = at;
		flag2 = low;
		reference3 = ref limb;
		float num14;
		if (!flag20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+30]");
			object syncRoot = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+30]");
			bool flag21 = (nint)0 == 0;
			obj = 0;
			num = 0f;
			vector = at;
			flag2 = low;
			reference3 = ref limb;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+18]");
				list = (List<MonsterGore.Limb>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB58]");
					double num13 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBA0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73B0]");
					object obj12 = 0;
					num = 0f;
					num14 = 0f;
					num2 = 0f;
					int version = 17276928;
					reference3 = ref *(MonsterGore.Limb*)null;
					object obj14 = default;
					while (true)
					{
						bool flag22 = System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref System.Runtime.CompilerServices.Unsafe.As<MonsterGore.Limb, byte>(ref reference3), ref *(byte*)list);
						obj3 = !flag22;
						float num8 = (float)(ref reference3) - (float)list;
						flag4 = num8 == 0f;
						if (obj3 != null)
						{
							break;
						}
						list = (List<MonsterGore.Limb>)((ref *(byte*)syncRoot) + (ref System.Runtime.CompilerServices.Unsafe.As<MonsterGore.Limb, byte>(ref reference3)));
						System.__Canon syncRoot2 = (System.__Canon)list._syncRoot;
						bool flag23 = list._syncRoot == null;
						obj = 0;
						vector = at;
						flag2 = low;
						obj2 = 1;
						if (flag23)
						{
							goto IL_187f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
						list = (List<MonsterGore.Limb>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
						bool flag24 = (nint)0 < (nint)3;
						obj3 = !flag24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
						num8 = 0f - 3f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
						if ((nint)0 != 3)
						{
							bool flag25 = (nint)list < 2;
							obj3 = !flag25;
							num8 = (float)list - 2f;
							flag4 = num8 == 0f;
							if ((nint)list != 2)
							{
								goto IL_0a9d;
							}
							list = (List<MonsterGore.Limb>)(object)armState;
							bool flag26 = armState == null;
							obj = 0;
							vector = at;
							flag2 = low;
							obj2 = 1;
							if (flag26)
							{
								goto IL_187f;
							}
							version = list._size;
							if (list._size == 0)
							{
								break;
							}
							list = (List<MonsterGore.Limb>)list._syncRoot;
						}
						else
						{
							list = (List<MonsterGore.Limb>)(object)armState;
							bool flag27 = armState == null;
							obj = 0;
							vector = at;
							flag2 = low;
							obj2 = 1;
							if (flag27)
							{
								goto IL_187f;
							}
							version = list._size;
							if ((int)(list._size & 0xFFFFFFFEL) == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
							list = (List<MonsterGore.Limb>)0;
						}
						bool flag28 = (nint)list < 2;
						obj3 = !flag28;
						num8 = (float)list - 2f;
						flag4 = (nint)list == 2;
						object obj13 = obj14;
						int num15 = version;
						if (!flag4)
						{
							goto IL_0a9d;
						}
						goto IL_2129;
						IL_2129:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+18]");
						list = (List<MonsterGore.Limb>)0;
						reference3 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference3, 1);
						ref MonsterGore.Limb reference5 = ref reference3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X26_v5 (System.Object)+18]");
						flag5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference5) < unchecked((nint)null);
						obj14 = obj13;
						version = num15;
						if (flag5)
						{
							continue;
						}
						goto IL_16b4;
						IL_0a9d:
						bool flag29 = (object)wounds == null;
						obj = 0;
						vector = at;
						flag2 = low;
						obj2 = 1;
						Vector3 a;
						Vector3 b;
						float num17;
						float num20;
						float num18;
						double num19;
						double num16;
						float num11;
						if (!flag29)
						{
							GillaWounds gillaWounds3 = wounds;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+18]");
							Vector3 vector3 = gillaWounds3.World((string)0, (Vector3)0);
							bool flag30 = (object)wounds == null;
							obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
							num2 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
							num4 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
							num6 = 0.0;
							vector = at;
							flag2 = low;
							obj2 = 1;
							if (!flag30)
							{
								GillaWounds gillaWounds4 = wounds;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+18]");
								Vector3 position = gillaWounds4.World((string)0, (Vector3)0);
								object obj15 = at & 1;
								bool flag31 = obj15 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+18]");
								a = (Vector3)0;
								b = (Vector3)0;
								if (flag31)
								{
									goto IL_0faa;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
								list = (List<MonsterGore.Limb>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
								bool flag32 = (nint)0 < (nint)3;
								obj3 = !flag32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
								num8 = 0f - 3f;
								flag4 = num8 == 0f;
								object obj16 = !flag4;
								if ((obj3 & obj16) == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
									bool flag33 = (nint)0 < (nint)1;
									obj3 = !flag33;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
									num8 = 0f - 1f;
									flag4 = num8 == 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+10]");
									flag5 = (nint)0 != 1;
									obj13 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
									num16 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
									num17 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
									num18 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
									num19 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
									num20 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
									num11 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
									num2 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
									num4 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
									num6 = 0.0;
									num15 = version;
									if (flag5)
									{
										goto IL_2129;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+18]");
								bool flag34 = (nint)0 == 0;
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
								num16 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
								num17 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
								num18 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
								num19 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
								num20 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
								num11 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
								num2 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
								num4 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
								num6 = 0.0;
								vector = at;
								flag2 = low;
								obj2 = 1;
								if (!flag34)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBC0]");
									object obj17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+18]");
									bool flag35 = ((string)0).StartsWith((string)obj17);
									bool flag36 = !flag35;
									object obj18 = !flag36;
									obj13 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
									num16 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
									num17 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
									num18 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
									num19 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
									num20 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
									num11 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
									num2 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
									num4 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
									num6 = 0.0;
									num15 = version;
									if (obj18 == null)
									{
										float num21 = height * (float)num13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
										nint num22 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
										if (num22 < 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
											num6 = 0.0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
											num6 = 0.0;
										}
										num2 = (float)num9 + num21;
										float num23 = (float)num6 - num2;
										bool flag37 = num23 == 0f;
										obj14 = !flag37;
										flag5 = num6 > (double)num2;
										a = (Vector3)obj17;
										b = (Vector3)0;
										obj13 = obj14;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
										num16 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
										num17 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
										num18 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
										num19 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
										num20 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
										num11 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
										num4 = 0.0;
										num15 = version;
										if (!flag5)
										{
											goto IL_0faa;
										}
									}
									goto IL_2129;
								}
							}
						}
						goto IL_187f;
						IL_0faa:
						float num24 = ToSegment((Vector3)(&num), a, b, out reference2);
						num4 = perUnit;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
						float num25 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+2C]");
						num17 = num25 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
						float num26 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
						num20 = num26 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
						float num27 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+34]");
						num18 = num27 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+38]");
						double num28 = 0.0 * (double)perUnit;
						num2 = num24 - (float)num28;
						bool flag38 = num2 < 0f;
						obj3 = !flag38;
						flag4 = num2 == 0f;
						num11 = ((!(num2 < 0f)) ? num2 : 0f);
						object obj19 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X0_v66+E4]");
						list = (List<MonsterGore.Limb>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X0_v66+E4]");
						bool flag39 = (nint)0 == 0;
						object obj20 = !flag39;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						List<System.__Canon> list2 = (List<System.__Canon>)(object)pickFrom;
						bool flag40 = pickFrom == null;
						obj = 0;
						num = num17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
						double num29 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
						float num30 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
						float num31 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+30]");
						num16 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
						num19 = 0.0;
						num6 = 0.0;
						num8 = num2;
						vector = at;
						flag2 = low;
						obj2 = 1;
						if (!flag40)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+38]");
							num19 = 0.0;
							System.__Canon[] items = list2._items;
							num16 = perUnit;
							version = (int)obj11;
							int version2 = list2._version + 1;
							list2._version = version2;
							bool flag41 = list2._items == null;
							obj = 0;
							num = num17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
							num29 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
							num30 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
							num31 = 0f;
							num6 = 0.0;
							num8 = num2;
							vector = at;
							list = (List<MonsterGore.Limb>)(object)list2._items;
							flag2 = low;
							obj2 = 1;
							if (!flag41)
							{
								version2 = list2._size;
								bool flag42 = list2._size < items.Length;
								obj3 = !flag42;
								num8 = (float)list2._size - (float)items.Length;
								flag4 = num8 == 0f;
								if (obj3 == null)
								{
									object obj21 = list2._items + list2._size;
									version = list2._size + 1;
									list2._size = version;
									list = (List<MonsterGore.Limb>)(obj21 + 32);
									list = (List<MonsterGore.Limb>)list._syncRoot;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1322 @ X9_v19 (System.Int32)+20]");
									object obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ X8_v61+A8]");
									list = (List<MonsterGore.Limb>)0;
									((List<System.__Canon>)(object)pickFrom).AddWithResize((System.__Canon)list._syncRoot);
								}
								List<float> list3 = pickWeights;
								bool flag43 = pickWeights == null;
								obj = 0;
								num = num17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
								num29 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
								num30 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
								num31 = 0f;
								num6 = 0.0;
								reference4 = ref *(MonsterGore.Limb*)list._syncRoot;
								vector = at;
								flag2 = low;
								obj2 = 1;
								if (!flag43)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+10]");
									list = (List<MonsterGore.Limb>)0;
									version = (int)obj12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+1C]");
									version2 = (int)((nint)0 + (nint)1);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+10]");
									bool flag44 = (nint)0 == 0;
									obj = 0;
									num = num17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
									num29 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
									num30 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
									num31 = 0f;
									num6 = 0.0;
									reference4 = ref *(MonsterGore.Limb*)list._syncRoot;
									vector = at;
									flag2 = low;
									obj2 = 1;
									if (!flag44)
									{
										float num32 = num17 * num17;
										float num33 = num20 * num20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+18]");
										version2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+18]");
										bool flag45 = (nint)0 < (nint)list._size;
										object obj23 = !flag45;
										float num34 = num32 + num33;
										float num35 = num18 * num18;
										float num36 = num35 + num34;
										double num37 = num19 * num16;
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
										float num38 = num36 + (float)num37;
										float num39 = num11 + (float)num13;
										float num40 = (float)num19 * num38;
										float num41 = num39 * num39;
										float num42 = (float)num16 * num40;
										float num43 = num39 * num41;
										num11 = num42 / num43;
										if (obj23 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+10]");
											nint num44 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+18]");
											object obj24 = num44 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X0_v70 (System.Collections.Generic.List`1<System.Single>)+18]");
											version = (int)((nint)0 + (nint)1);
										}
										else
										{
											pickWeights.AddWithResize(num11);
										}
										num2 = num14 + num11;
										obj13 = obj14;
										num = num17;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+28]");
										num29 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+24]");
										num30 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X24_v9 (System.__Canon)+20]");
										num31 = 0f;
										num14 = num2;
										num4 = num41;
										num6 = num43;
										num15 = version;
										goto IL_2129;
									}
								}
							}
						}
						goto IL_187f;
					}
					goto IL_1f98;
				}
				num = 0f;
				num14 = 0f;
				goto IL_2267;
			}
		}
		goto IL_187f;
		IL_187f:
		ref Vector3 reference6 = ref reference2;
		throw new NullReferenceException();
		IL_16b4:
		obj2 = 1;
		goto IL_2267;
		IL_2267:
		bool flag46 = num14 < 0f;
		obj3 = !flag46;
		flag4 = num14 == 0f;
		object obj25 = ~obj3;
		flag5 = (byte)((obj25 | flag4) ? 1 : 0) != 0;
		float num45 = num14;
		if (!flag5)
		{
			num2 = UnityEngine.Random.value;
			List<float> list4 = pickWeights;
			bool flag47 = pickWeights == null;
			obj = 0;
			float num11 = num14;
			float num8 = num14;
			vector = at;
			flag2 = low;
			if (!flag47)
			{
				float num46 = num14 * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C76A8]");
				obj2 = 0;
				float num47 = num2;
				Vector3 vector4 = (Vector3)0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v55 (System.Collections.Generic.List`1<System.Single>)+18]");
					list = (List<MonsterGore.Limb>)(-1);
					bool flag48 = vector4 < (object)list;
					obj3 = !flag48;
					num8 = (float)vector4 - (float)list;
					flag4 = num8 == 0f;
					flag5 = vector4 >= (object)list;
					obj = 0;
					num11 = num46;
					num2 = num47;
					reference6 = ref reference2;
					vector = vector4;
					flag2 = low;
					if (flag5)
					{
						break;
					}
					num2 = list4.get_Item((int)vector4);
					num11 = num46 - num2;
					bool flag49 = num11 < 0f;
					obj3 = !flag49;
					flag4 = num11 == 0f;
					object obj26 = ~obj3;
					flag5 = (byte)((obj26 | flag4) ? 1 : 0) != 0;
					obj = 0;
					reference6 = ref reference2;
					num8 = num11;
					vector = vector4;
					flag2 = low;
					if (flag5)
					{
						break;
					}
					list4 = pickWeights;
					vector = vector4 + 1;
					bool flag50 = pickWeights == null;
					object obj27 = !flag50;
					obj = 0;
					num8 = num11;
					flag2 = low;
					num46 = num11;
					num47 = num2;
					vector4 = vector;
					if (obj27 != null)
					{
						continue;
					}
					goto IL_187f;
				}
				bool flag51 = pickFrom == null;
				reference2 = ref reference6;
				if (!flag51)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBB8]");
					object obj28 = 0;
					System.__Canon _Canon = ((List<System.__Canon>)(object)pickFrom).get_Item((int)vector);
					((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)_Canon != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					list = (List<MonsterGore.Limb>)((bool*)(flag2 ? 1 : 0))->m_value;
					bool flag52 = !((bool*)(flag2 ? 1 : 0))->m_value;
					reference2 = ref reference6;
					if (!flag52)
					{
						bool flag53 = (object)wounds == null;
						reference2 = ref reference6;
						if (!flag53)
						{
							num2 = (float)list._syncRoot;
							Vector3 vector5 = wounds.World((string)list._size, (Vector3)0);
							list = (List<MonsterGore.Limb>)((bool*)(flag2 ? 1 : 0))->m_value;
							bool flag54 = !((bool*)(flag2 ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+28]");
							num4 = 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
							num6 = 0.0;
							reference2 = ref reference6;
							if (!flag54)
							{
								bool flag55 = (object)wounds == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+28]");
								num4 = 0.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
								num6 = 0.0;
								reference2 = ref reference6;
								if (!flag55)
								{
									Vector3 vector6 = wounds.World((string)list._size, (Vector3)0);
									float num48 = ToSegment((Vector3)(&obj), (Vector3)list._size, (Vector3)0, out reference6);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+2C]");
									float num49 = 0f - (float)list._syncRoot;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+30]");
									double num50 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
									double num51 = num50 - 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+34]");
									double num52 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+28]");
									double num53 = num52 - 0.0;
									float num54 = num49 * num49;
									double num55 = num51 * num51;
									float num56 = num54 + (float)num55;
									double num57 = num53 * num53;
									float num58 = (float)num57 + num56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
									bool flag56 = !(num58 > 0f);
									float num59 = (float)list._syncRoot;
									float num60 = 0.5f;
									if (!flag56)
									{
										float num61 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+28]");
										num59 = num61 - 0f;
										float num62 = (float)obj - (float)list._syncRoot;
										object obj29 = default;
										double num63 = (double)obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
										double num64 = num63 - 0.0;
										float num65 = num49 * num62;
										double num66 = num51 * num64;
										float num67 = num65 + (float)num66;
										double num68 = num53 * (double)num59;
										float num69 = (float)num68 + num67;
										num60 = num69 / num58;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE70]");
									nint num70 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
									float num71 = UnityEngine.Random.Range(num70, 0f);
									float num72 = num60 + num71;
									bool flag57 = num72 < 0f;
									double num73 = 0.0;
									if (!flag57)
									{
										float num74 = num72 - 1f;
										bool flag58 = num74 == 0f;
										object obj14 = !flag58;
										bool flag59 = (double)num72 > 1.0;
										num73 = 1.0;
										if (!flag59)
										{
											num73 = num72;
										}
									}
									double num75 = num51 * num73;
									float num76 = num49 * (float)num73;
									double num77 = num53 * num73;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
									double num13 = 0.0 + num75;
									num11 = num2 + num76;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+28]");
									num9 = 0.0 + num77;
									double num78 = num7 - num13;
									float num79 = num3 - num11;
									double num80 = num5 - num9;
									object obj30 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X0_v19+E4]");
									bool flag60 = (nint)0 == 0;
									object obj31 = !flag60;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num81 = num79 * num79;
									double num82 = num78 * num78;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									float num18 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									vector = (Vector3)0;
									float num83 = num81 + (float)num82;
									double num84 = num80 * num80;
									double num85 = num84 + (double)num83;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
									float num86;
									double num87;
									double num88;
									if (num85 > 0.0)
									{
										num86 = num79 / (float)num85;
										num87 = num78 / num85;
										num88 = num80 / num85;
									}
									else
									{
										float x = vector.x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1336 @ X8_v31 (System.Single)+A0]");
										object obj32 = 0;
										num86 = (float)obj32;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X8_v32+4]");
										num87 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1337 @ X8_v32+8]");
										num88 = 0.0;
									}
									Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
									float num31 = 0f;
									double num89 = num85;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
									double num90 = num89 * 0.0;
									double num91 = num84;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
									double num92 = num91 * 0.0;
									double num93 = num75;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
									double num94 = num93 * 0.0;
									float num20 = num86 + (float)num90;
									double num19 = num87 + num92;
									double num95 = num88 + num94;
									object obj33 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ X0_v25+E4]");
									bool flag61 = (nint)0 == 0;
									object obj34 = !flag61;
									if (obj34 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
									bool flag62 = num94 < (double)num18;
									obj3 = !flag62;
									double num96 = num94 - (double)num18;
									flag4 = num96 == 0.0;
									if (num94 > (double)num18)
									{
										num2 = num20 / (float)num94;
										num6 = num19 / num94;
										num4 = num95 / num94;
									}
									else
									{
										float x2 = vector.x;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1458 @ X8_v27 (System.Single)+A0]");
										object obj35 = 0;
										num2 = (float)obj35;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ X8_v28+4]");
										num6 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ X8_v28+8]");
										num4 = 0.0;
									}
									list = (List<MonsterGore.Limb>)((bool*)(flag2 ? 1 : 0))->m_value;
									bool flag63 = !((bool*)(flag2 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+28]");
									double num29 = 0.0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
									float num30 = 0f;
									reference2 = ref reference6;
									int version = 17276928;
									obj2 = 109891584;
									if (!flag63)
									{
										flag2 = (byte)(int)wounds != 0;
										bool flag64 = (byte)(int)(~wounds) != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+28]");
										num29 = 0.0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+24]");
										num30 = 0f;
										reference2 = ref reference6;
										version = 17276928;
										obj2 = 109891584;
										if (!flag64)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v5 (System.Collections.Generic.List`1<MonsterGore+Limb>)+38]");
											float num97 = 0f * perUnit;
											double num98 = num4 * (double)num97;
											double num99 = num6 * (double)num97;
											float num100 = num2 * num97;
											double num101 = num9 + num98;
											double num102 = num13 + num99;
											float num103 = num11 + num100;
											Vector3 vector7 = wounds.OnBody((string)list._size, (Vector3)0);
											Vector3 vector8 = wounds.NearestSkin((GoreSection)(int)list._items, (Vector3)0);
											reference4 = ref *(MonsterGore.Limb*)num103;
											num45 = num14;
											goto IL_26ac;
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_187f;
		}
		goto IL_26ac;
		IL_26ac:
		bool flag65 = num45 < 0f;
		object obj36 = !flag65;
		bool flag66 = num45 == 0f;
		object obj37 = !flag66;
		return (byte)(obj36 & obj37) != 0;
		IL_1f98:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_0702:
		reference4 = ref *(MonsterGore.Limb*)1;
		goto IL_2079;
	}

	private unsafe static float ToSegment(Vector3 at, Vector3 a, Vector3 b, out Vector3 nearest)
	{
		//IL_008a: Expected F8, but got I4
		//IL_026b: Expected native int or pointer, but got VT
		//IL_0278: Expected native int or pointer, but got VT
		//IL_0285: Expected native int or pointer, but got VT
		//IL_029f: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I4
		//IL_0118: Invalid comparison between F8 and I4
		//IL_0127: Expected F8, but got I4
		object obj2 = default;
		object obj3 = default;
		object obj = obj2 - obj3;
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 - obj6;
		object obj8 = default;
		object obj9 = default;
		object obj7 = obj8 - obj9;
		object obj10 = obj4 * obj4;
		object obj11 = obj7 * obj7;
		object obj12 = obj10 + obj11;
		object obj13 = obj * obj;
		object obj14 = obj13 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		bool flag = (nint)obj14 <= 0;
		double num = 0.0;
		object obj16 = default;
		object obj18 = default;
		object obj20 = default;
		if (!flag)
		{
			object obj15 = obj16 - obj6;
			object obj17 = obj18 - obj9;
			object obj19 = obj20 - obj3;
			object obj21 = obj15 * obj4;
			object obj22 = obj17 * obj7;
			object obj23 = obj21 + obj22;
			object obj24 = obj19 * obj;
			object obj25 = obj24 + obj23;
			double num2 = (double)obj25 / (double)obj14;
			bool flag2 = num2 < 0.0;
			num = 0.0;
			if (!flag2)
			{
				bool flag3 = !(num2 > 1.0);
				num = num2;
				if (!flag3)
				{
					num = 1.0;
				}
			}
		}
		double num3 = (double)obj4 * num;
		double num4 = (double)obj7 * num;
		double num5 = (double)obj * num;
		double num6 = (double)obj6 + num3;
		double num7 = (double)obj9 + num4;
		double num8 = (double)obj3 + num5;
		((Vector3*)(nint)at)->x = (float)num6;
		((Vector3*)(nint)at)->y = (float)num7;
		((Vector3*)(nint)at)->z = (float)num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj26 = 0;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj28 = !flag4;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num9 = (double)obj18 - num7;
		double num10 = (double)obj16 - num6;
		double num11 = (double)obj20 - num8;
		double num12 = num10 * num10;
		double num13 = num9 * num9;
		double num14 = num12 + num13;
		double num15 = num11 * num11;
		float result = (float)num15 + (float)num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		return result;
	}

	private void Say(int says, GoreSection section, Vector3 point)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I4
		//IL_0138: Expected VT, but got I4
		//IL_0113: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = brain != null;
		bool flag3 = !flag2;
		UnityEngine.Object obj4 = null;
		if (!flag3)
		{
			MonsterBrain monsterBrain = brain;
			obj4 = monsterBrain.net;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj4 != null && ((MonsterNet)obj4).Live)
		{
			if (!((MonsterNet)obj4).CanSay)
			{
				return;
			}
			((MonsterNet)obj4).Say((Vector4)0);
		}
		bool flag5 = !Quiet;
		Take((Vector4)flag5, loud: false);
	}

	public unsafe void Take(Vector4 said, bool loud)
	{
		//IL_0091: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected VT, but got Unknown
		//IL_00ba: Expected I4, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_0556: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_01c6: Invalid comparison between Obj and F8
		//IL_021a: Expected VT, but got Ref
		//IL_0050: Invalid comparison between Obj and F8
		//IL_0178: Expected Obj, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected I4, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected Obj, but got Unknown
		//IL_05f5: Invalid comparison between I4 and F8
		//IL_0277: Unsupported input type for neg.
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected I4, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_059b: Expected Obj, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected VT, but got Unknown
		//IL_0468: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I
		//IL_03af: Expected Obj, but got I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected I4, but got Unknown
		//IL_03a0: Expected Obj, but got I
		Begin();
		double num2 = default;
		if (~(ready ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBE0]");
			object obj = 0;
			List<(Vector4, bool)> list = waiting;
			Vector4 item = (Vector4)(said & 1);
			(Vector4, bool) tuple = (item, (byte)(int)obj != 0);
			if ((object)waiting != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector4, System.Boolean>>)+10]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector4, System.Boolean>>)+1C]");
				object obj3 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector4, System.Boolean>>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector4, System.Boolean>>)+18]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v8+18]");
					bool flag = num < 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector4, System.Boolean>>)+18]");
						object obj5 = (nint)0 * (nint)20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector4, System.Boolean>>)+10]");
						object obj6 = 0 + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v4 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector4, System.Boolean>>)+18]");
						object obj7 = (nint)0 + (nint)1;
						_ = 0;
						_ = 0;
					}
					else
					{
						waiting.AddWithResize(((Vector4, bool))(&num2));
					}
					return;
				}
			}
			goto IL_04e8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj8 = 0;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
		object obj11 = default;
		double num3;
		double num4;
		if ((nint)obj11 < 0)
		{
			if (obj11 == (object)(-0.5))
			{
				num3 = -1.0;
				num4 = num2;
				goto IL_0564;
			}
			num4 = (double)obj11 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		}
		else
		{
			if (obj11 == (object)0.5)
			{
				num3 = 1.0;
				num4 = num2;
				goto IL_0564;
			}
			num4 = (double)obj11 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		}
		goto IL_05ae;
		IL_0564:
		double num5 = num4 + num3;
		object obj12 = num4 & 1;
		bool flag3 = obj12 == null;
		object obj13 = !flag3;
		if (obj13 != null)
		{
			num4 = num5;
		}
		goto IL_05ae;
		IL_05ae:
		double num6 = 0.0 - num4;
		GoreSection goreSection = (GoreSection)(num4 & 7);
		object obj14 = num4 & 0xFFFFFFF8L;
		object obj15 = num6 & 7;
		GoreSection goreSection2 = ((!(0.0 < num4)) ? ((GoreSection)(0 - obj15)) : goreSection);
		if ((nint)obj14 == 8)
		{
			MonsterGore monsterGore = gore;
			if ((object)gore != null)
			{
				MonsterNavMesh.Arm[] array = monsterGore.arms;
				if (monsterGore.arms != null)
				{
					object obj16 = array.Length;
					if (array.Length >= 1)
					{
						object obj17 = 0;
						while (true)
						{
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
							object obj18 = !flag4;
							if (obj18 != null)
							{
								break;
							}
							object obj19 = (object)monsterGore.arms + obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v29+20]");
							MonsterNavMesh.Arm arm = (MonsterNavMesh.Arm)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v29+20]");
							if ((nint)0 == 0)
							{
								goto IL_04e8;
							}
							if (arm.section == goreSection2)
							{
								bool loud2 = (byte)(said & 1) != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v29+20]");
								ArmOff((MonsterNavMesh.Arm)0, loud2);
							}
							obj16 = array.Length;
							obj17++;
							if ((nint)obj17 < array.Length)
							{
								continue;
							}
							goto IL_062c;
						}
						goto IL_04f6;
					}
					goto IL_062c;
				}
			}
		}
		else if ((object)wounds != null)
		{
			Vector3 point = (Vector3)(said & 1);
			wounds.AddSoon(goreSection2, point, burst: false);
			Note(goreSection2, point);
			if ((nint)obj14 == 16)
			{
				object obj20 = goreSection2 & (GoreSection)0xFF;
				int num7;
				if ((nint)obj20 != 4)
				{
					if ((nint)obj20 == 5)
					{
						num7 = 1;
					}
					else
					{
						object obj21 = default;
						bool flag5 = (nint)obj21 < 0;
						int num8 = ((!flag5) ? 1 : 0);
						num7 = num8;
					}
				}
				else
				{
					num7 = 0;
				}
				trappedSide = num7;
				trapHeld = false;
			}
			goto IL_062c;
		}
		goto IL_04e8;
		IL_062c:
		Recount();
		return;
		IL_04f6:
		throw new IndexOutOfRangeException();
		IL_04e8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04f6;
	}

	private void Note(GoreSection section, Vector3 point)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I4
		//IL_0319: Expected I4, but got Obj
		//IL_0169: Expected Obj, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_0156: Expected I4, but got Obj
		//IL_01f1: Expected Obj, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0219: Expected Obj, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_027b: Expected I4, but got I8
		object obj = section & (GoreSection)0xFF;
		if ((nint)obj <= 3)
		{
			if (obj != null)
			{
				if ((nint)obj == 1)
				{
					int num = torsoHits + 1;
					torsoHits = num;
					object obj2 = default;
					double num2 = (((nint)obj2 >= 0) ? 1.0 : (-1.0));
					double num3 = num2 + (double)torsoSide;
					torsoSide = (float)num3;
					return;
				}
				goto IL_015b;
			}
			int num4 = headHits + 1;
			headHits = num4;
			return;
		}
		if ((nint)obj != 4)
		{
			if ((nint)obj != 5)
			{
				goto IL_015b;
			}
			int[] array = legHits;
			if (legHits != null)
			{
				object obj3 = array[1] + 1;
				array[1] = (int)obj3;
				return;
			}
		}
		else
		{
			int[] array2 = legHits;
			if (legHits != null)
			{
				object obj4 = array2[0] + 1;
				array2[0] = (int)obj4;
				return;
			}
		}
		goto IL_031e;
		IL_031e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_032c;
		IL_032c:
		throw new IndexOutOfRangeException();
		IL_015b:
		object obj5 = section & (GoreSection)0xFF;
		int[] array3 = armState;
		object obj6 = obj5 - 2;
		bool flag = obj6 == null;
		int num5 = ((!flag) ? 1 : 0);
		if (armState == null)
		{
			goto IL_031e;
		}
		bool flag2 = num5 < array3.Length;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			object obj8 = section & (GoreSection)0xFF;
			object obj9 = obj8 - 2;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			object obj11 = (object)armState + obj10;
			object obj12 = obj11 + 32;
			bool flag4 = obj12 == null;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				obj12 = 1;
				if ((int)(brokeFirst & 0x80000000L) != 0)
				{
					brokeFirst = num5;
				}
			}
			return;
		}
		goto IL_032c;
	}

	private void Recount()
	{
		//IL_011c: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_015a: Invalid comparison between F4 and I4
		//IL_0169: Expected F8, but got I4
		//IL_0571: Expected Obj, but got I
		//IL_0598: Invalid comparison between F4 and I4
		//IL_05a7: Expected F8, but got I4
		//IL_05d2: Invalid comparison between F8 and I4
		//IL_05e1: Expected F8, but got I4
		//IL_028d: Expected Obj, but got I8
		//IL_0296: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I4
		//IL_040d: Expected Obj, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_0455: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I4
		//IL_0467: Expected Obj, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0351: Expected Obj, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		MonsterGore monsterGore = gore;
		float num = ArmWeight(0, monsterGore.legs);
		float num2 = LegWeight(0);
		float num3 = num + num2;
		float num4 = ArmWeight(1, monsterGore.legs);
		float num5 = LegWeight(1);
		float num6 = num4 + num5;
		float num7 = ArmWeight(0, monsterGore.legs);
		float num8 = ArmWeight(1, monsterGore.legs);
		float num9 = num7 + num8;
		armWeight = num9;
		float num10 = LegWeight(0);
		float num11 = LegWeight(1);
		float num12 = num3 + num6;
		int num13 = torsoHits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC30]");
		object obj = (nint)num13 * (nint)0;
		int num14 = headHits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		object obj2 = (nint)num14 * (nint)0;
		float num15 = num12 + (float)obj;
		float num16 = num15 + (float)obj2;
		bool flag = num16 < 0f;
		double num17 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)num16 > 1.0);
			num17 = num16;
			if (!flag2)
			{
				num17 = 1.0;
			}
		}
		float num18 = num6 - num3;
		float num19 = num10 + num11;
		Wreck__BackingField = (float)num17;
		float num20 = torsoSide;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		float num21 = num20 * 0f;
		float num22 = num18 + num21;
		float num23 = num22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		float num24 = num23 / 0f;
		bool flag3 = (double)num24 < -1.0;
		double num25 = -1.0;
		if (!flag3)
		{
			bool flag2 = !((double)num24 > 1.0);
			num25 = num24;
			if (!flag2)
			{
				num25 = 1.0;
			}
		}
		Side__BackingField = (float)num25;
		float num26 = num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF4]");
		float num27 = num26 * 0f;
		float num28 = armWeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float num29 = num28 * 0f;
		int num30 = torsoHits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
		object obj3 = (nint)num30 * (nint)0;
		float num31 = num27 + num29;
		float num32 = (float)obj3 + num31;
		bool flag4 = num32 < 0f;
		double num33 = 0.0;
		if (!flag4)
		{
			bool flag2 = !((double)num32 > 1.0);
			num33 = num32;
			if (!flag2)
			{
				num33 = 1.0;
			}
		}
		limp = (float)num33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D110");
		bool flag5 = num17 < 0.0;
		double num34 = 0.0;
		if (!flag5)
		{
			bool flag2 = !(num17 > 1.0);
			num34 = num17;
			if (!flag2)
			{
				num34 = 1.0;
			}
		}
		int[] array = armState;
		double num35 = (double)slowest + -1.0;
		double num36 = num35 * num34;
		double num37 = num36 + 1.0;
		Pace__BackingField = (float)num37;
		bool[] array2 = hangs;
		object obj4 = array.Length & 0xFFFFFFFFL;
		object obj5 = 1;
		object obj6 = 0;
		while (obj6 != obj4)
		{
			object obj7 = (object)array + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X14_v4+20]");
			bool flag8;
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X14_v4+20]");
				if ((nint)0 != 1)
				{
					goto IL_03e4;
				}
				if (~(monsterGore.legs ? 1u : 0u) != 0)
				{
					object obj8 = obj6 ^ 1;
					bool flag6 = (nint)obj8 < array.Length;
					object obj9 = !flag6;
					if (obj9 != null)
					{
						break;
					}
					object obj10 = (object)array + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X14_v12+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X14_v12+20]");
						if ((nint)0 != 1)
						{
							goto IL_03e4;
						}
						object obj11 = obj6 - brokeFirst;
						bool flag7 = obj11 == null;
						flag8 = flag7;
						goto IL_03f2;
					}
				}
			}
			flag8 = true;
			goto IL_03f2;
			IL_03f2:
			bool flag9 = (nint)obj6 < array2.Length;
			object obj12 = !flag9;
			if (obj12 != null)
			{
				break;
			}
			object obj13 = (object)array2 + obj6;
			object obj14 = obj5 & 1;
			bool flag10 = obj14 == null;
			object obj15 = !flag10;
			obj5 = 0;
			obj6 = 1;
			if (obj15 == null)
			{
				return;
			}
			continue;
			IL_03e4:
			flag8 = false;
			goto IL_03f2;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private float ArmWeight(int side, bool onLegs)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00a5: Expected F4, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_0149: Expected F4, but got I
		//IL_0154: Expected Obj, but got I4
		//IL_00e6: Expected F4, but got I
		//IL_010e: Expected F4, but got I4
		//IL_00fb: Expected F4, but got I
		int[] array = armState;
		if (armState != null)
		{
			bool flag = array.Length < side;
			object obj = !flag;
			object obj2 = array.Length - side;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = armState + side;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
				float result = 0f;
				bool flag3 = !onLegs;
				object obj6 = !flag3;
				object obj7 = ~obj6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					result = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABF8]");
				float num = 0f;
				object obj8 = !flag3;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					num = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v2+20]");
				if ((nint)0 != 1)
				{
					result = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v2+20]");
				if ((nint)0 == 2)
				{
					result = num;
				}
				return result;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private float LegWeight(int side)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I
		int[] array = legHits;
		if (legHits != null)
		{
			bool flag = array.Length < side;
			object obj = !flag;
			object obj2 = array.Length - side;
			bool flag2 = obj2 == null;
			object obj3 = ~obj;
			object obj4 = obj3 | flag2;
			if (obj4 == null)
			{
				object obj5 = legHits + side;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2+20]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B000]");
				object obj6 = num * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
				object obj7;
				if (trappedSide == side)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
					obj7 = 0;
				}
				else
				{
					obj7 = 0;
				}
				return (float)obj7 + (float)obj6;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	private void ArmOff(MonsterNavMesh.Arm a, bool loud)
	{
		//IL_0010: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_010e: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I4
		//IL_0183: Expected I4, but got I8
		//IL_019d: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBE8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj4 = obj2 + 24;
			obj4 = a;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			MonsterNavMesh.Arm arm = (MonsterNavMesh.Arm)obj4;
			if (obj4 != null)
			{
				int[] array = armState;
				object obj5 = arm.section - 2;
				bool flag = obj5 == null;
				int num = ((!flag) ? 1 : 0);
				if (armState != null)
				{
					bool flag2 = num < array.Length;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						object obj7 = arm.section - 2;
						bool flag3 = obj7 == null;
						object obj8 = !flag3;
						object obj9 = (object)armState + obj8;
						object obj10 = obj9 + 32;
						if ((nint)obj10 == 2)
						{
							return;
						}
						obj10 = 2;
						int num2 = (int)(brokeFirst & 0x80000000L);
						bool flag4 = num2 == 0;
						object obj11 = !flag4;
						if (obj11 == null)
						{
							if (loud)
							{
								goto IL_01c8;
							}
						}
						else
						{
							brokeFirst = num;
							bool flag5 = !loud;
							object obj12 = !flag5;
							if (obj12 != null)
							{
								goto IL_01c8;
							}
						}
						ArmComesOff((MonsterNavMesh.Arm)obj4, loud: false);
						return;
					}
					goto IL_02b9;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_02b9;
		IL_01c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBF0]");
		object obj14 = 0;
		Action action = default;
		action._002Ector(obj2, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaWounds.Later(action);
		return;
		IL_02b9:
		throw new IndexOutOfRangeException();
	}

	private void ArmComesOff(MonsterNavMesh.Arm a, bool loud)
	{
		//IL_005e: Expected VT, but got I4
		//IL_0084: Expected VT, but got I4
		//IL_002c: Expected VT, but got I4
		//IL_009a: Expected F4, but got I
		//IL_00ab: Expected F4, but got I
		//IL_00b4: Unsupported input type for neg.
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00fc: Expected F4, but got VT
		//IL_00fc: Expected VT, but got I4
		//IL_00fc: Expected VT, but got I4
		//IL_0050: Expected VT, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_01b0: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_01f8: Expected Obj, but got I4
		//IL_0254: Expected VT, but got I4
		//IL_027e: Expected Obj, but got VT
		//IL_029b: Expected Obj, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02dd: Expected VT, but got I4
		//IL_0d88: Expected Obj, but got I
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Expected Obj, but got Unknown
		//IL_0ddb: Expected Obj, but got I4
		//IL_034e: Expected F4, but got I
		//IL_035e: Expected Obj, but got I
		//IL_0378: Invalid comparison between F4 and I
		//IL_03d9: Expected Obj, but got I
		//IL_03e1: Expected F4, but got Obj
		//IL_03f1: Expected F4, but got I
		//IL_0401: Expected F4, but got I
		//IL_0e01: Expected Obj, but got I
		//IL_0b52: Expected Obj, but got I
		//IL_0b6f: Expected Obj, but got I
		//IL_0b7f: Expected Obj, but got I
		//IL_0bb1: Expected Obj, but got I
		//IL_0bc1: Expected Obj, but got I
		//IL_0bd8: Expected F4, but got Obj
		//IL_0be0: Invalid comparison between F4 and Obj
		//IL_0c0b: Expected F4, but got VT
		//IL_0e35: Expected Obj, but got I4
		//IL_05cc: Expected Obj, but got I
		//IL_05d4: Expected F4, but got Obj
		//IL_05e4: Expected F4, but got I
		//IL_05f4: Expected F4, but got I
		//IL_0c92: Expected Obj, but got I4
		//IL_06c6: Expected Obj, but got I
		//IL_06ce: Expected F4, but got Obj
		//IL_06de: Expected F4, but got I
		//IL_06ee: Expected F4, but got I
		//IL_0cd3: Expected Obj, but got I4
		//IL_0728: Expected VT, but got I4
		//IL_0d0b: Expected Obj, but got I4
		//IL_077d: Expected VT, but got I4
		//IL_0743: Expected VT, but got Obj
		//IL_088e: Expected Obj, but got I
		//IL_08b8: Expected Obj, but got I4
		//IL_08ed: Expected F4, but got VT
		//IL_08ed: Expected VT, but got I4
		//IL_08fd: Expected Obj, but got I
		//IL_079b: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I4
		//IL_091c: Expected Obj, but got I
		//IL_07f2: Expected F4, but got I
		//IL_0802: Expected F4, but got I
		//IL_0836: Expected F4, but got I
		//IL_0836: Expected F4, but got I
		//IL_0836: Expected F4, but got VT
		//IL_0836: Expected VT, but got I4
		//IL_0846: Expected F4, but got I
		//IL_0853: Expected F4, but got VT
		//IL_0870: Expected F4, but got I
		//IL_0879: Expected VT, but got I4
		//IL_0960: Expected VT, but got I4
		//IL_098b: Expected Obj, but got I4
		//IL_09c7: Expected Obj, but got I4
		//IL_0a17: Expected Obj, but got I
		//IL_0a41: Expected Obj, but got I4
		//IL_0a72: Expected F4, but got VT
		//IL_0a72: Expected VT, but got I4
		//IL_0a7c: Expected Obj, but got VT
		//IL_0aab: Expected Obj, but got VT
		//IL_0d29: Expected Obj, but got I
		//IL_0d53: Expected Obj, but got I4
		//IL_0b04: Expected F4, but got I
		//IL_0b04: Expected F4, but got I
		//IL_0b04: Expected F4, but got VT
		//IL_0b04: Expected VT, but got I4
		//IL_0b04: Expected VT, but got I4
		//IL_0b04: Expected VT, but got I4
		Vector3 vector;
		if (loud)
		{
			bool flag = skin.enabled;
			bool flag2 = !flag;
			vector = (Vector3)0;
			if (!flag2)
			{
				GameObject gameObject = Throw(a);
				vector = (Vector3)gameObject;
			}
		}
		else
		{
			vector = (Vector3)0;
		}
		GameObject piece = default;
		wounds.ArmTorn(a.section, vector, (Vector3)0, piece);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+44]");
		float num = -0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+40]");
		float num2 = -0;
		object obj = 0 - a.way;
		float num3 = a.radius;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
		float num4 = num3 * 0f;
		wounds.Stump(a.section, (Vector3)0, (Vector3)0, (float)a.cut);
		Transform transform = Bone(a.upper);
		if (!loud)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = transform == null;
		bool flag5 = !flag4;
		object obj5 = !flag5;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Vector3 vector2 = wounds.World(a.upper, (Vector3)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj9 = a.way * a.cut;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+44]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj10 = num5 * 0;
		object obj11 = a.cut + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+38]");
		float num6 = 0f + (float)obj10;
		Vector3 vector3 = wounds.World(a.upper, (Vector3)0);
		object obj12 = default;
		float num7 = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+34]");
		float num8 = num7 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj13 = 0;
		object obj14 = obj11 - a.cut;
		object obj15 = obj13;
		float num9 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+38]");
		float num10 = num9 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = obj14 * obj14;
		float num11 = num8 * num8;
		float num12 = (float)obj17 + num11;
		float num13 = num10 * num10;
		float num14 = num13 + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num15 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num16;
		float num17;
		float num18;
		if (num14 > 0f)
		{
			num16 = (float)obj14 / num14;
			num17 = num8 / num14;
			num18 = num10 / num14;
		}
		else
		{
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v75+A0]");
			object obj20 = 0;
			num16 = (float)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v76+4]");
			num17 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v76+8]");
			num18 = 0f;
		}
		object obj21 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v21+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+18]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+18]");
		object obj23 = num19 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+1C]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+1C]");
		object obj24 = num20 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
		object obj25 = 0;
		object obj26 = obj25;
		object obj27 = obj23 + obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+20]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+20]");
		object obj28 = num21 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v26+A0]");
		object obj29 = 0;
		float num22 = (float)obj28 + (float)obj27;
		float num23 = (float)obj29;
		bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num22) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
		float num24 = num18;
		float num25 = num16;
		float num26 = num17;
		float num27 = (float)a.cut;
		if (!flag8)
		{
			float num28 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+18]");
			float num29 = num28 * 0f;
			float num30 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+1C]");
			float num31 = num30 * 0f;
			float num32 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+20]");
			num27 = num32 * 0f;
			float num33 = num29 + num31;
			float num34 = num27 + num33;
			float num35 = num34 / num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+18]");
			num23 = 0f * num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+1C]");
			num6 = 0f * num35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+20]");
			num22 = 0f * num35;
			num25 = num16 - num23;
			num26 = num17 - num6;
			num24 = num18 - num22;
			num = num18;
			num2 = num17;
		}
		object obj30 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v28+E4]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num36 = num25 * num25;
		float num37 = num26 * num26;
		float num38 = num36 + num37;
		float num39 = num24 * num24;
		float num40 = num38 + num39;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num41;
		float num42;
		float num43;
		if (num40 > num15)
		{
			num41 = num25 / num40;
			num42 = num26 / num40;
			num43 = num24 / num40;
		}
		else
		{
			object obj32 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v69+A0]");
			object obj33 = 0;
			num41 = (float)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v70+4]");
			num42 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v70+8]");
			num43 = 0f;
		}
		float num44 = num41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float num45 = num44 * 0f;
		float num46 = num42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float num47 = num46 * 0f;
		float num48 = num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA10]");
		float num49 = num48 * 0f;
		object obj34 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+18]");
		float num50 = 0f + num45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+1C]");
		float num51 = 0f + num47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v22+20]");
		float num52 = 0f + num49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v33+E4]");
		bool flag10 = (nint)0 == 0;
		object obj35 = !flag10;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num53 = num50 * num50;
		float num54 = num51 * num51;
		float num55 = num53 + num54;
		float num56 = num52 * num52;
		float num57 = num55 + num56;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float seconds;
		float fine;
		if (num57 > num15)
		{
			seconds = num50 / num57;
			fine = num51 / num57;
			float num58 = num52 / num57;
		}
		else
		{
			object obj36 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v65+A0]");
			object obj37 = 0;
			seconds = (float)obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v66+4]");
			fine = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v66+8]");
			float num58 = 0f;
		}
		Dismemberment dismemberment = Tearing();
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v40+E4]");
		bool flag11 = (nint)0 == 0;
		object obj39 = !flag11;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag12 = dismemberment != null;
		bool flag13 = !flag12;
		Vector3 vector4 = (Vector3)0;
		if (!flag13)
		{
			vector4 = (Vector3)dismemberment.bloodMaterial;
		}
		object obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v38+E4]");
		bool flag14 = (nint)0 == 0;
		object obj41 = !flag14;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag15 = dismemberment != null;
		bool flag16 = !flag15;
		Vector3 vector5 = (Vector3)0;
		if (!flag16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj42 = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X0_v76+E4]");
			bool flag17 = (nint)0 == 0;
			object obj44 = !flag17;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA0C]");
			num = 0f;
			AudioClip[] tearSounds = dismemberment.tearSounds;
			Vector3 cut = a.cut;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+34]");
			nint num59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+38]");
			Sfx.Play(tearSounds, (Vector3)0, (float)cut, num59, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+34]");
			num15 = 0f;
			num57 = (float)a.cut;
			num27 = dismemberment.tearVolume;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+38]");
			num6 = 0f;
			vector5 = (Vector3)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
		object obj45 = 0;
		object obj46 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v43+E4]");
		bool flag18 = (nint)0 == 0;
		object obj47 = !flag18;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Blood.Burst(vector4, (Vector3)0, null, (float)a.cut);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9820]");
		object obj49 = 0;
		GameObject gameObject2 = default;
		gameObject2._002Ector((string)obj49);
		Transform transform2 = gameObject2.transform;
		transform2.SetParent(transform, worldPositionStays: true);
		transform2.position = (Vector3)0;
		Blood.Spray(transform2, vector4, (Material)gushDroplets, seconds, bleedPulses, 0, fine);
		GameObject obj50 = transform2.gameObject;
		object obj51 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v51+E4]");
		bool flag19 = (nint)0 == 0;
		object obj52 = !flag19;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float t = bleedSeconds + 2f;
		UnityEngine.Object.Destroy(obj50, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D30]");
		object obj53 = 0;
		object obj54 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v56+E4]");
		bool flag20 = (nint)0 == 0;
		object obj55 = !flag20;
		if (obj55 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaSplatter.Around((Vector3)0, (float)a.cut);
		if ((UnityEngine.Object)vector != null)
		{
			Transform b = ((GameObject)vector).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D38]");
			object obj56 = 0;
			object obj57 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X0_v64+E4]");
			bool flag21 = (nint)0 == 0;
			object obj58 = !flag21;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 cut2 = a.cut;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+34]");
			nint num60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+38]");
			int many = default;
			GillaStrands gillaStrands = GillaStrands.Between(transform, b, (Vector3)15, (Vector3)0, (Vector3)0, (float)cut2, num60, many, 0f);
		}
	}

	private static Dismemberment Tearing()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v1+8]");
		UnityEngine.Object obj9 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v1+8]");
		bool flag4 = (UnityEngine.Object)0 != null;
		bool flag5 = !flag4;
		UnityEngine.Object obj11 = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v1+8]");
			if ((nint)0 == 0)
			{
				goto IL_01bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X20_v3 (UnityEngine.Object)+68]");
			obj11 = (UnityEngine.Object)0;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = obj11 != null;
		bool flag8 = !flag7;
		Dismemberment result = null;
		if (!flag8)
		{
			if ((object)obj11 == null)
			{
				goto IL_01bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v4 (UnityEngine.Object)+20]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X19_v4 (UnityEngine.Object)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11+18]");
					if ((nint)0 == 0)
					{
						goto IL_01c9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v11+20]");
					result = (Dismemberment)0;
					goto IL_028f;
				}
			}
			result = null;
		}
		goto IL_028f;
		IL_028f:
		return result;
		IL_01c9:
		return (Dismemberment)(object)new IndexOutOfRangeException();
		IL_01bb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c9;
	}

	private unsafe GameObject Throw(MonsterNavMesh.Arm a)
	{
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I
		//IL_0518: Expected Obj, but got Ref
		//IL_0531: Expected Obj, but got I
		//IL_05b2: Expected Obj, but got Ref
		//IL_05dc: Expected Obj, but got I
		//IL_0300: Expected VT, but got I4
		//IL_0300: Expected VT, but got I4
		//IL_06fa: Expected VT, but got I4
		//IL_06fa: Expected VT, but got I4
		//IL_070a: Expected Obj, but got I
		//IL_0753: Expected Obj, but got I
		//IL_0772: Expected Obj, but got I
		//IL_078c: Expected Obj, but got I
		//IL_0395: Expected VT, but got I4
		//IL_03a5: Expected Obj, but got I
		//IL_087f: Expected Obj, but got I
		//IL_08c6: Expected VT, but got I4
		//IL_08f0: Expected VT, but got I4
		//IL_099f: Expected Obj, but got I
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected Obj, but got Unknown
		//IL_09e1: Expected VT, but got I4
		//IL_0a1d: Expected VT, but got I4
		//IL_1791: Expected Obj, but got I
		//IL_17a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a6: Expected Obj, but got Unknown
		//IL_17b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bb: Expected Obj, but got Unknown
		//IL_17e5: Expected Obj, but got I4
		//IL_0a8c: Expected Obj, but got I
		//IL_0aa6: Invalid comparison between F8 and I
		//IL_0b0f: Expected Obj, but got I
		//IL_0b17: Expected F8, but got Obj
		//IL_0b27: Expected F8, but got I
		//IL_0b37: Expected F8, but got I
		//IL_180b: Expected Obj, but got I
		//IL_1567: Expected Obj, but got I
		//IL_1584: Expected Obj, but got I
		//IL_18c4: Expected Obj, but got I4
		//IL_0be6: Expected Obj, but got I
		//IL_0bee: Expected F8, but got Obj
		//IL_0bfe: Expected F8, but got I
		//IL_0c0e: Expected F8, but got I
		//IL_15f4: Expected F4, but got I
		//IL_1633: Expected VT, but got I4
		//IL_0c5d: Expected VT, but got I4
		//IL_0c6d: Expected Obj, but got I
		//IL_0cc1: Expected Obj, but got I4
		//IL_0e06: Expected Obj, but got I
		//IL_0e30: Expected Obj, but got I4
		//IL_0e5d: Expected Obj, but got I
		//IL_0ce9: Expected Obj, but got I8
		//IL_0cf9: Expected Obj, but got I
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected Obj, but got Unknown
		//IL_0d10: Expected Obj, but got I4
		//IL_0d21: Expected Obj, but got I4
		//IL_1692: Expected Obj, but got I4
		//IL_165a: Expected Obj, but got I4
		//IL_18ea: Expected Obj, but got I
		//IL_190c: Expected Obj, but got I4
		//IL_0eae: Expected Obj, but got I4
		//IL_0d50: Expected Obj, but got I4
		//IL_108e: Expected Obj, but got I
		//IL_10b8: Expected Obj, but got I4
		//IL_0d82: Expected Obj, but got I
		//IL_0d92: Expected Obj, but got I
		//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Expected Obj, but got Unknown
		//IL_0dbf: Expected Obj, but got I4
		//IL_0dcf: Expected Obj, but got I
		//IL_0dd8: Expected Obj, but got I4
		//IL_0de8: Expected Obj, but got I
		//IL_16d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d5: Expected Obj, but got Unknown
		//IL_16f7: Expected Obj, but got I
		//IL_0eef: Expected Obj, but got I
		//IL_1192: Expected Obj, but got I4
		//IL_11d5: Expected VT, but got I4
		//IL_0f3e: Expected Obj, but got I4
		//IL_1735: Expected Obj, but got I
		//IL_175f: Expected Obj, but got I4
		//IL_0f67: Expected Obj, but got I8
		//IL_0f77: Expected Obj, but got I
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Expected Obj, but got Unknown
		//IL_0f8e: Expected Obj, but got I4
		//IL_0f9f: Expected Obj, but got I4
		//IL_16b9: Expected Obj, but got I4
		//IL_146e: Expected Obj, but got I
		//IL_1498: Expected Obj, but got I4
		//IL_127a: Expected Obj, but got I
		//IL_1294: Expected Obj, but got I
		//IL_120d: Expected VT, but got Obj
		//IL_14c6: Expected VT, but got Ref
		//IL_0fce: Expected Obj, but got I4
		//IL_1000: Expected Obj, but got I
		//IL_1010: Expected Obj, but got I
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected Obj, but got Unknown
		//IL_103d: Expected Obj, but got I4
		//IL_104d: Expected Obj, but got I
		//IL_1057: Expected Obj, but got I4
		//IL_1067: Expected Obj, but got I
		//IL_1349: Expected VT, but got I4
		//IL_135b: Expected VT, but got I4
		//IL_1379: Expected Obj, but got I
		//IL_13b5: Expected Obj, but got I4
		//IL_13f6: Expected Obj, but got I4
		//IL_143a: Expected Obj, but got I4
		GameObject result;
		object obj6;
		if (a != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = a.piece == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			result = null;
			if (obj4 != null)
			{
				goto IL_14d7;
			}
			object obj5 = obj;
			obj6 = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = (UnityEngine.Object)obj6 == null;
			bool flag6 = !flag5;
			object obj9 = default;
			object obj8 = obj9;
			if (flag6)
			{
				goto IL_04b8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC00]");
			object obj11 = 0;
			GameObject gameObject = default;
			gameObject._002Ector((string)obj11);
			if ((object)gameObject != null)
			{
				Transform transform = gameObject.transform;
				if ((object)skin != null)
				{
					Transform transform2 = skin.transform;
					if ((object)transform2 != null)
					{
						Transform parent = transform2.parent;
						if ((object)transform != null)
						{
							transform.SetParent(parent, worldPositionStays: false);
							Transform transform3 = gameObject.transform;
							if ((object)skin != null)
							{
								Transform transform4 = skin.transform;
								if ((object)transform4 != null)
								{
									Vector3 localPosition = transform4.localPosition;
									if ((object)skin != null)
									{
										Transform transform5 = skin.transform;
										if ((object)transform5 != null)
										{
											Quaternion localRotation = transform5.localRotation;
											if ((object)transform3 != null)
											{
												transform3.SetLocalPositionAndRotation((Vector3)0, (Quaternion)0);
												Transform transform6 = gameObject.transform;
												if ((object)skin != null)
												{
													Transform transform7 = skin.transform;
													if ((object)transform7 != null)
													{
														Vector3 localScale = transform7.localScale;
														if ((object)transform6 != null)
														{
															transform6.localScale = (Vector3)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
															object obj12 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
															SkinnedMeshRenderer skinnedMeshRenderer = default;
															poser = skinnedMeshRenderer;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															if ((object)skin != null)
															{
																Transform[] bones = skin.bones;
																if ((object)poser != null)
																{
																	poser.bones = bones;
																	if ((object)skin != null)
																	{
																		Transform rootBone = skin.rootBone;
																		if ((object)poser != null)
																		{
																			poser.rootBone = rootBone;
																			if (obj6 != null)
																			{
																				((Renderer)obj6).enabled = false;
																				object obj13 = default;
																				obj8 = obj13;
																				goto IL_04b8;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_14dc;
		IL_143f:
		GameObject gameObject2 = default;
		Transform thing = gameObject2.transform;
		Renderer renderer = default;
		Bounds bounds = renderer.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v120+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = default;
		Rigidbody rigidbody = default;
		bool flag8 = GillaDoor.OutOfSlabs(thing, (Bounds)(&obj17), rigidbody);
		result = gameObject2;
		goto IL_14d7;
		IL_14ea:
		return (GameObject)(object)new IndexOutOfRangeException();
		IL_1075:
		Dismemberment dismemberment = Tearing();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v66+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = dismemberment != null;
		bool flag11 = !flag10;
		AudioClip[] array = null;
		if (!flag11)
		{
			if ((object)dismemberment == null)
			{
				goto IL_14dc;
			}
			array = dismemberment.dropSounds;
		}
		TornPiece tornPiece = default;
		object obj21 = tornPiece + 32;
		obj21 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDBF8]");
		object obj22 = 0;
		_ = pieceLife;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
		Thrown thrown = default;
		Mesh mesh = default;
		double num7;
		double num9;
		double num11;
		if ((object)thrown != null)
		{
			float num = pieceShrink;
			float after = pieceLife - pieceShrink;
			thrown.Begin(mesh, after, pieceShrink);
			object obj23 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ X0_v107+E4]");
			bool flag12 = (nint)0 == 0;
			object obj24 = !flag12;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = dismemberment != null;
			bool flag14 = !flag13;
			Vector3 dir = (Vector3)0;
			if (!flag14)
			{
				if ((object)dismemberment == null)
				{
					goto IL_14dc;
				}
				dir = (Vector3)dismemberment.bloodMaterial;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj25 = 0;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ X0_v111+E4]");
			bool flag15 = (nint)0 == 0;
			object obj27 = !flag15;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPlaying = Application.isPlaying;
			bool flag16 = !isPlaying;
			double num2 = 9.0;
			double num4 = default;
			double num3 = num4;
			int num5 = 0;
			Material material = null;
			if (flag16)
			{
				goto IL_143f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E40]");
			object obj29 = 0;
			GameObject gameObject3 = default;
			gameObject3._002Ector((string)obj29);
			if ((object)gameObject3 != null)
			{
				Transform transform8 = gameObject3.transform;
				Transform parent2 = gameObject2.transform;
				if ((object)transform8 != null)
				{
					transform8.SetParent(parent2, worldPositionStays: false);
					if ((object)wounds != null)
					{
						Vector3 vector = wounds.World(a.upper, (Vector3)0);
						transform8.position = (Vector3)0;
						float num6 = (float)(0.0 - num7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
						object obj30 = 0;
						object obj31 = obj30;
						float num8 = (float)(0.0 - num9);
						double num10 = 0.0 - num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ X0_v135+E4]");
						bool flag17 = (nint)0 == 0;
						object obj32 = !flag17;
						if (obj32 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Blood.Spray(transform8, dir, (Material)45, num6, 3, 0, num8);
						num2 = 2.0;
						double num12 = num10;
						num = num8;
						after = num6;
						num3 = 1.0;
						num5 = 3;
						material = (Material)45;
						goto IL_143f;
					}
				}
			}
		}
		goto IL_14dc;
		IL_04b8:
		BoxCollider boxCollider = default;
		if (obj6 != null)
		{
			((SkinnedMeshRenderer)obj6).sharedMesh = a.piece;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			mesh._002Ector();
			object obj34 = default;
			string text = ((Enum)(&obj34)).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E48]");
			object obj35 = 0;
			string text2 = (string)obj35 + text;
			if ((object)mesh != null)
			{
				mesh.name = text2;
				if (obj6 != null)
				{
					((SkinnedMeshRenderer)obj6).BakeMesh(mesh, false);
					mesh.RecalculateBounds();
					object obj36 = default;
					string text3 = ((Enum)(&obj36)).ToString();
					string text4 = (string)obj35 + text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					gameObject2._002Ector(text4);
					if ((object)gameObject2 != null)
					{
						Transform transform9 = gameObject2.transform;
						if (obj6 != null)
						{
							Transform transform10 = ((Component)obj6).transform;
							if ((object)transform10 != null)
							{
								Vector3 position = transform10.position;
								if (obj6 != null)
								{
									Transform transform11 = ((Component)obj6).transform;
									if ((object)transform11 != null)
									{
										Quaternion rotation = transform11.rotation;
										if ((object)transform9 != null)
										{
											transform9.SetPositionAndRotation((Vector3)0, (Quaternion)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
											object obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
											MeshFilter meshFilter = default;
											if ((object)meshFilter != null)
											{
												meshFilter.sharedMesh = mesh;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
												object obj39 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E00]");
												object obj40 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E08]");
												object obj41 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
												MonsterGore monsterGore = gore;
												if ((object)gore != null && (object)wounds != null)
												{
													Material[] mats = wounds.PieceLook(a.slots, monsterGore.flesh);
													if ((object)tornPiece != null)
													{
														Material[] sharedMaterials = tornPiece.Own(mats);
														if ((object)renderer != null)
														{
															renderer.sharedMaterials = sharedMaterials;
															gameObject2.layer = 2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DE8]");
															object obj42 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
															Bounds bounds2 = mesh.bounds;
															if ((object)boxCollider != null)
															{
																boxCollider.center = (Vector3)0;
																Bounds bounds3 = mesh.bounds;
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																boxCollider.size = (Vector3)0;
																if ((object)rigidbody != null)
																{
																	rigidbody.mass = 3f;
																	rigidbody.interpolation = (RigidbodyInterpolation)1;
																	rigidbody.collisionDetectionMode = (CollisionDetectionMode)3;
																	if ((object)wounds != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																		double num13 = (double)a.way * 3.0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+44]");
																		nint num14 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
																		object obj43 = num14 * 0;
																		double num15 = (double)a.cut + num13;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+38]");
																		object obj44 = 0 + obj43;
																		Vector3 vector2 = wounds.World(a.upper, (Vector3)0);
																		if ((object)wounds != null)
																		{
																			Vector3 vector3 = wounds.World(a.upper, (Vector3)0);
																			double num16 = num15 - (double)a.cut;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
																			object obj45 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+34]");
																			object obj47 = default;
																			object obj46 = obj47 - 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ X1 (MonsterNavMesh+Arm)+38]");
																			object obj48 = obj44 - 0;
																			object obj49 = obj45;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v73+E4]");
																			bool flag18 = (nint)0 == 0;
																			object obj50 = !flag18;
																			if (obj50 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			}
																			double num17 = num16 * num16;
																			object obj51 = obj46 * obj46;
																			double num18 = num17 + (double)obj51;
																			object obj52 = obj48 * obj48;
																			double num19 = (double)obj52 + num18;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
																			object obj53 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																			if (num19 > 0.0)
																			{
																				num7 = num16 / num19;
																				double num20 = (double)obj46 / num19;
																				num11 = (double)obj48 / num19;
																				num9 = num20;
																			}
																			else
																			{
																				object obj54 = obj53;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X8_v103+A0]");
																				object obj55 = 0;
																				num7 = (double)obj55;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X8_v104+8]");
																				num11 = 0.0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X8_v104+4]");
																				num9 = 0.0;
																			}
																			object obj56 = obj53;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X8_v47+A0]");
																			object obj57 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+20]");
																			double num21 = 0.0 * 0.5;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+18]");
																			double num22 = 0.0 * 0.5;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+1C]");
																			double num23 = 0.0 * 0.5;
																			Vector3 insideUnitSphere = UnityEngine.Random.insideUnitSphere;
																			double num24 = num7 + num22;
																			double num25 = 0.5;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
																			double num26 = num25 * 0.0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+18]");
																			nint num27 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
																			object obj58 = num27 * 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+1C]");
																			nint num28 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
																			object obj59 = num28 * 0;
																			double num29 = num9 + num23;
																			double num30 = num11 + num21;
																			object obj60 = obj45;
																			double num31 = num24 + num26;
																			double num32 = num29 + (double)obj58;
																			double num33 = num30 + (double)obj59;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X0_v80+E4]");
																			bool flag19 = (nint)0 == 0;
																			object obj61 = !flag19;
																			if (obj61 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+1C]");
																			nint num34 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																			double num36;
																			double num38;
																			double num40;
																			if (num34 > 0)
																			{
																				double num35 = num31;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+1C]");
																				num36 = num35 / 0.0;
																				double num37 = num32;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+1C]");
																				num38 = num37 / 0.0;
																				double num39 = num33;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v48+1C]");
																				num40 = num39 / 0.0;
																			}
																			else
																			{
																				object obj62 = obj53;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X8_v98+A0]");
																				object obj63 = 0;
																				num36 = (double)obj63;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X8_v99+4]");
																				num38 = 0.0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X8_v99+8]");
																				num40 = 0.0;
																			}
																			double num41 = num36 * (double)throwSpeed;
																			double num42 = num38 * (double)throwSpeed;
																			double num43 = num40 * (double)throwSpeed;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEC4]");
																			float num44 = UnityEngine.Random.Range(0.75f, 0f);
																			double num45 = num41 * (double)num44;
																			double num46 = num42 * (double)num44;
																			double num47 = num43 * (double)num44;
																			rigidbody.linearVelocity = (Vector3)0;
																			Vector3 insideUnitSphere2 = UnityEngine.Random.insideUnitSphere;
																			double num48 = num45 * 9.0;
																			double num49 = num46 * 9.0;
																			double num12 = num47 * 9.0;
																			rigidbody.angularVelocity = (Vector3)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
																			object obj64 = 0;
																			object obj65 = obj64;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
																			object obj66 = default;
																			if (obj66 != null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v88+18]");
																				bool flag20 = (nint)0 < (nint)1;
																				Collider collider = (Collider)1;
																				if (flag20)
																				{
																					goto IL_0df6;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v88+18]");
																				object obj67 = 0 & 0xFFFFFFFFL;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
																				object obj68 = 0;
																				object obj69 = obj66 + 32;
																				object obj70 = 0;
																				object obj71 = obj64;
																				Collider collider2 = (Collider)1;
																				while (true)
																				{
																					bool flag21 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj67);
																					object obj72 = !flag21;
																					if (obj72 != null)
																					{
																						break;
																					}
																					object obj73 = obj68;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X0_v159+E4]");
																					bool flag22 = (nint)0 == 0;
																					object obj74 = !flag22;
																					if (obj74 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X23_v18+v547 @ X24_v20*8]");
																					Physics.IgnoreCollision(boxCollider, (Collider)0);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v88+18]");
																					obj67 = 0;
																					obj70++;
																					object obj75 = obj70;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v88+18]");
																					bool flag23 = (nint)obj75 < 0;
																					obj65 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X23_v18+v547 @ X24_v20*8]");
																					collider = (Collider)0;
																					obj71 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X23_v18+v547 @ X24_v20*8]");
																					collider2 = (Collider)0;
																					if (flag23)
																					{
																						continue;
																					}
																					goto IL_0df6;
																				}
																				goto IL_14ea;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_14dc;
		IL_14d7:
		return result;
		IL_14dc:
		NullReferenceException ex = new NullReferenceException();
		goto IL_14ea;
		IL_0df6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E28]");
		object obj76 = 0;
		object obj77 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X0_v90+E4]");
		bool flag24 = (nint)0 == 0;
		object obj78 = !flag24;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj79 = 0;
		object obj80 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X0_v94+E4]");
		bool flag25 = (nint)0 == 0;
		object obj81 = !flag25;
		if (obj81 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj80 = obj76;
		}
		object obj82 = obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ X0_v94+A0]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v64+E4]");
		bool flag26 = (nint)0 == 0;
		object obj84 = !flag26;
		if (obj84 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag27 = (UnityEngine.Object)obj83 != null;
		bool flag28 = !flag27;
		object obj85 = 0;
		Collider collider3 = null;
		if (flag28)
		{
			goto IL_1075;
		}
		if (obj83 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DD8]");
			object obj86 = 0;
			obj85 = obj86;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
			Collider collider4 = default;
			if ((object)collider4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v144 (UnityEngine.Collider)+18]");
				bool flag29 = (nint)0 < (nint)1;
				collider3 = (Collider)1;
				if (flag29)
				{
					goto IL_1075;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v144 (UnityEngine.Collider)+18]");
				object obj87 = 0 & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj88 = 0;
				object obj89 = collider4 + 32;
				object obj90 = 0;
				object obj91 = obj86;
				Collider collider5 = (Collider)1;
				while (true)
				{
					bool flag30 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj90) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj87);
					object obj92 = !flag30;
					if (obj92 != null)
					{
						break;
					}
					object obj93 = obj88;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X0_v146+E4]");
					bool flag31 = (nint)0 == 0;
					object obj94 = !flag31;
					if (obj94 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X23_v17+v548 @ X24_v17*8]");
					Physics.IgnoreCollision(boxCollider, (Collider)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v144 (UnityEngine.Collider)+18]");
					obj87 = 0;
					obj90++;
					object obj95 = obj90;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v144 (UnityEngine.Collider)+18]");
					bool flag32 = (nint)obj95 < 0;
					obj85 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X23_v17+v548 @ X24_v17*8]");
					collider3 = (Collider)0;
					obj91 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X23_v17+v548 @ X24_v17*8]");
					collider5 = (Collider)0;
					if (flag32)
					{
						continue;
					}
					goto IL_1075;
				}
				goto IL_14ea;
			}
		}
		goto IL_14dc;
	}

	public void Died()
	{
		//IL_0016: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_003e: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		if (~(Quiet ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC08]");
			object obj2 = 0;
			Action action = default;
			action._002Ector(this, (IntPtr)obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaWounds.Later(action);
		}
	}

	public float StepLoud()
	{
		//IL_003b: Invalid comparison between F4 and I4
		//IL_004c: Expected Obj, but got I4
		//IL_0057: Invalid comparison between F4 and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_0502: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_00fb: Invalid comparison between F4 and I4
		//IL_0112: Expected Obj, but got F4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01cf: Invalid comparison between F4 and I4
		//IL_01e6: Expected Obj, but got F4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I4
		//IL_035d: Expected Obj, but got I
		//IL_03da: Invalid comparison between F4 and I4
		//IL_03e9: Expected F8, but got I4
		//IL_047d: Expected Obj, but got I4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04cf: Expected F8, but got I
		bool flag = (byte)(~(ready ? 1u : 0u)) != 0;
		double num = 1.0;
		if (!flag)
		{
			float num2 = Wreck__BackingField;
			bool flag2 = Wreck__BackingField < 0f;
			object obj = !flag2;
			bool flag3 = Wreck__BackingField == 0f;
			object obj2 = ~obj;
			object obj3 = obj2 | flag3;
			num = 1.0;
			if (obj3 == null)
			{
				MonsterGore monsterGore = gore;
				if ((object)gore != null)
				{
					if (!monsterGore.legs)
					{
						object obj4 = 280;
					}
					else
					{
						object obj4 = 288;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterWounds)+v256 @ X8_v8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterWounds)+v256 @ X8_v8]");
					if ((nint)0 != 0)
					{
						num2 = Side__BackingField;
						bool flag4 = Side__BackingField < 0f;
						object obj6 = Side__BackingField ^ Side__BackingField;
						object obj7 = Side__BackingField & obj6;
						bool flag5 = (nint)obj7 < 0;
						bool flag6 = flag4 == flag5;
						bool flag7 = flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X21_v5+18]");
						bool flag8 = (nint)(flag7 ? 1 : 0) < (nint)0;
						object obj8 = !flag8;
						if (obj8 != null)
						{
							goto IL_04e2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterWounds)+v256 @ X8_v8]");
						object obj9 = (nint)0 + (nint)(flag6 ? 1 : 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9+20]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v9+20]");
						bool flag9 = (nint)0 == 0;
						num = 1.0;
						if (!flag9)
						{
							bool flag10 = Side__BackingField < 0f;
							object obj11 = Side__BackingField ^ Side__BackingField;
							object obj12 = Side__BackingField & obj11;
							bool flag11 = (nint)obj12 < 0;
							bool flag12 = flag10 == flag11;
							object obj13 = !flag12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X21_v5+18]");
							bool flag13 = (nint)obj13 < 0;
							object obj14 = !flag13;
							if (obj14 != null)
							{
								goto IL_04e2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonsterWounds)+v256 @ X8_v8]");
							object obj15 = 0 + obj13;
							object obj16 = obj15 + 32;
							bool flag14 = obj16 == null;
							num = 1.0;
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v10+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v10+20]");
									Vector3 position = ((Transform)0).position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X21_v5+18]");
									bool flag15 = (nint)obj13 < 0;
									object obj17 = !flag15;
									if (obj17 != null)
									{
										goto IL_04e2;
									}
									object obj18 = obj16;
									if (obj16 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v12+20]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v12+20]");
											Vector3 position2 = ((Transform)0).position;
											object obj19 = default;
											bool flag16 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
											num = 1.0;
											if (!flag16)
											{
												MonsterGore monsterGore2 = gore;
												if ((object)gore == null)
												{
													goto IL_04d4;
												}
												if (~(monsterGore2.legs ? 1u : 0u) != 0)
												{
													bool[] array = hangs;
													if (hangs == null)
													{
														goto IL_04d4;
													}
													bool flag17 = (flag6 ? 1 : 0) < array.Length;
													object obj20 = !flag17;
													if (obj20 != null)
													{
														goto IL_04e2;
													}
													object obj21 = hangs + flag6;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v16+20]");
													if ((nint)0 != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
														num = 0.0;
														goto IL_04ed;
													}
												}
												bool flag18 = limp < 0f;
												double num3 = 0.0;
												if (!flag18)
												{
													bool flag19 = !((double)limp > 1.0);
													num3 = limp;
													if (!flag19)
													{
														num3 = 1.0;
													}
												}
												double num4 = num3 * -0.5;
												num = num4 + 1.0;
											}
											goto IL_04ed;
										}
									}
								}
								goto IL_04d4;
							}
						}
						goto IL_04ed;
					}
				}
				goto IL_04d4;
			}
		}
		goto IL_04ed;
		IL_04e2:
		throw new IndexOutOfRangeException();
		IL_04ed:
		return (float)num;
		IL_04d4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04e2;
	}

	private void LateUpdate()
	{
		//IL_001a: Invalid comparison between F4 and I4
		//IL_002b: Expected Obj, but got I4
		//IL_0036: Invalid comparison between F4 and I4
		//IL_0047: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I4
		//IL_0077: Invalid comparison between F4 and I4
		//IL_0088: Expected Obj, but got I4
		//IL_0093: Invalid comparison between F4 and I4
		//IL_00a4: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I4
		//IL_00e9: Invalid comparison between F4 and I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0108: Invalid comparison between F4 and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_02b6: Expected Obj, but got I4
		//IL_024a: Invalid comparison between F4 and I4
		//IL_025b: Expected Obj, but got I4
		//IL_0269: Invalid comparison between F4 and I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028f: Expected F4, but got I4
		//IL_02e0: Invalid comparison between F4 and I4
		//IL_02f1: Expected Obj, but got I4
		//IL_02fa: Invalid comparison between F4 and I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_0321: Expected F4, but got I4
		if (~(ready ? 1u : 0u) != 0)
		{
			return;
		}
		float num = Wreck__BackingField;
		bool flag = Wreck__BackingField < 0f;
		object obj = !flag;
		bool flag2 = Wreck__BackingField == 0f;
		object obj2 = !flag2;
		object obj3 = obj & obj2;
		if (obj3 == null)
		{
			num = thrash;
			bool flag3 = thrash < 0f;
			object obj4 = !flag3;
			bool flag4 = thrash == 0f;
			object obj5 = !flag4;
			object obj6 = obj4 & obj5;
			if (obj6 == null)
			{
				MonsterBrain monsterBrain = brain;
				num = monsterBrain.SnareLeft__BackingField;
				bool flag5 = monsterBrain.SnareLeft__BackingField < 0f;
				object obj7 = !flag5;
				bool flag6 = monsterBrain.SnareLeft__BackingField == 0f;
				object obj8 = ~obj7;
				object obj9 = obj8 | flag6;
				if (obj9 != null)
				{
					return;
				}
			}
		}
		MonsterBrain monsterBrain2 = brain;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = monsterBrain2.animator == null;
		bool flag9 = !flag8;
		object obj13 = !flag9;
		if (obj13 != null)
		{
			return;
		}
		MonsterBrain monsterBrain3 = brain;
		if (!monsterBrain3.animator.isActiveAndEnabled)
		{
			return;
		}
		MonsterBrain monsterBrain4 = brain;
		float dt;
		if (~(monsterBrain4.weeping ? 1u : 0u) == 0)
		{
			bool flag10 = monsterBrain4.AnimPace__BackingField < 0f;
			object obj14 = !flag10;
			bool flag11 = monsterBrain4.AnimPace__BackingField == 0f;
			object obj15 = ~obj14;
			object obj16 = obj15 | flag11;
			dt = 0f;
			if (obj16 != null)
			{
				goto IL_033e;
			}
		}
		bool flag12 = (byte)(~(monsterBrain4.Dead__BackingField ? 1u : 0u)) != 0;
		object obj17 = !flag12;
		if (obj17 == null)
		{
			float speed = monsterBrain4.animator.speed;
			bool flag13 = speed < 0f;
			object obj18 = !flag13;
			bool flag14 = speed == 0f;
			object obj19 = ~obj18;
			object obj20 = obj19 | flag14;
			dt = 0f;
			if (obj20 != null)
			{
				goto IL_033e;
			}
		}
		dt = Time.deltaTime;
		goto IL_033e;
		IL_033e:
		Show(dt);
	}

	public void Show(float dt)
	{
		//IL_0013: Invalid comparison between F4 and I4
		//IL_0027: Invalid comparison between F4 and I4
		//IL_0044: Expected Obj, but got F4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00bd: Expected F8, but got I4
		//IL_1846: Expected Obj, but got I4
		//IL_184e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1853: Expected Obj, but got Unknown
		//IL_18ab: Invalid comparison between F8 and I4
		//IL_18be: Expected Obj, but got F8
		//IL_18c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cb: Expected Obj, but got Unknown
		//IL_18fd: Expected Obj, but got I4
		//IL_192d: Expected Obj, but got I4
		//IL_1945: Invalid comparison between F8 and I4
		//IL_1967: Expected Obj, but got I4
		//IL_197d: Expected I4, but got Obj
		//IL_0154: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_0249: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I4
		//IL_03c4: Invalid comparison between F8 and I4
		//IL_03d3: Expected F8, but got I4
		//IL_02cc: Expected Obj, but got I4
		//IL_19c5: Expected Obj, but got I4
		//IL_19ce: Expected Obj, but got I4
		//IL_0300: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I4
		//IL_0468: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I4
		//IL_04eb: Expected Obj, but got I4
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		//IL_0598: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I4
		//IL_05aa: Expected Obj, but got I4
		//IL_053d: Expected Obj, but got I4
		//IL_056b: Expected Obj, but got I
		//IL_07a2: Invalid comparison between F4 and I4
		//IL_07b9: Expected Obj, but got F4
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_07f0: Expected Obj, but got I4
		//IL_080b: Expected Obj, but got I4
		//IL_063b: Invalid comparison between F4 and I4
		//IL_0652: Expected Obj, but got F4
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_0699: Expected Obj, but got I4
		//IL_0824: Invalid comparison between F4 and I4
		//IL_083b: Expected Obj, but got F4
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_0872: Expected Obj, but got I4
		//IL_0891: Expected Obj, but got I
		//IL_06b2: Invalid comparison between F4 and I4
		//IL_06c9: Expected Obj, but got F4
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected Obj, but got Unknown
		//IL_0714: Expected Obj, but got I
		//IL_1b14: Invalid comparison between F4 and I4
		//IL_08d0: Expected Obj, but got I
		//IL_219a: Invalid comparison between F4 and I4
		//IL_21a9: Expected F8, but got I4
		//IL_1a57: Expected F8, but got I
		//IL_1ae3: Expected F4, but got I4
		//IL_1aec: Expected F8, but got I4
		//IL_0753: Expected Obj, but got I
		//IL_1bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfd: Expected Obj, but got Unknown
		//IL_1c42: Expected F4, but got I
		//IL_0950: Invalid comparison between F8 and I4
		//IL_0963: Expected Obj, but got F8
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Obj, but got Unknown
		//IL_09a2: Expected Obj, but got I4
		//IL_0a63: Invalid comparison between F4 and I4
		//IL_1b44: Expected Obj, but got I4
		//IL_1b5c: Invalid comparison between F8 and I4
		//IL_1b7c: Expected Obj, but got I4
		//IL_1b92: Expected I4, but got Obj
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected Obj, but got Unknown
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected Obj, but got Unknown
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected Obj, but got Unknown
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected Obj, but got Unknown
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected Obj, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0d69: Expected Obj, but got I4
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Expected Obj, but got Unknown
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected Obj, but got Unknown
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected Obj, but got Unknown
		//IL_2040: Expected Obj, but got I4
		//IL_0d9b: Expected Obj, but got I4
		//IL_0e6d: Expected VT, but got I4
		//IL_0f04: Expected Obj, but got I4
		//IL_0f0d: Expected Obj, but got I4
		//IL_16ad: Expected Obj, but got I4
		//IL_0f3b: Expected Obj, but got I
		//IL_0f4b: Expected Obj, but got I
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected Obj, but got Unknown
		//IL_0f7f: Expected Obj, but got I4
		//IL_0f90: Expected Obj, but got I4
		//IL_0fc0: Expected F8, but got I
		//IL_177a: Invalid comparison between F4 and I4
		//IL_1d6e: Expected VT, but got I4
		//IL_1d7e: Expected VT, but got I4
		//IL_1da4: Expected VT, but got I4
		//IL_173e: Invalid comparison between F8 and I4
		//IL_17aa: Expected VT, but got I4
		//IL_17aa: Expected VT, but got I4
		//IL_1fc9: Expected VT, but got I4
		//IL_0fe0: Expected Obj, but got I4
		//IL_100d: Expected Obj, but got I
		//IL_13da: Expected Obj, but got I4
		//IL_10e3: Expected F8, but got I
		//IL_10ee: Invalid comparison between F4 and I4
		//IL_1105: Expected Obj, but got F4
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected Obj, but got Unknown
		//IL_114f: Expected F4, but got VT
		//IL_1157: Expected Obj, but got VT
		//IL_1dd0: Expected VT, but got Obj
		//IL_1de8: Expected Obj, but got I
		//IL_106e: Invalid comparison between F4 and I4
		//IL_1407: Expected Obj, but got I
		//IL_118b: Invalid comparison between F8 and I4
		//IL_11a1: Expected F4, but got VT
		//IL_11a9: Expected Obj, but got VT
		//IL_15f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fd: Expected Obj, but got Unknown
		//IL_109b: Expected Obj, but got I4
		//IL_1357: Expected F8, but got I
		//IL_1367: Expected F8, but got I
		//IL_1374: Expected F4, but got VT
		//IL_1388: Expected VT, but got I4
		//IL_1391: Expected VT, but got I4
		//IL_11d2: Expected Obj, but got I
		//IL_1db3: Expected F4, but got VT
		//IL_1dc3: Expected Obj, but got I
		//IL_1e05: Expected Obj, but got I
		//IL_10ce: Expected Obj, but got VT
		//IL_1478: Expected Obj, but got I4
		//IL_2207: Expected Obj, but got I
		//IL_2224: Expected Obj, but got I
		//IL_223c: Expected Obj, but got I
		//IL_22b7: Invalid comparison between F4 and Obj
		//IL_1e13: Invalid comparison between F8 and I4
		//IL_1e22: Expected F8, but got I4
		//IL_14b7: Expected Obj, but got I4
		//IL_1e3d: Expected F4, but got VT
		//IL_1e69: Invalid comparison between F8 and I4
		//IL_1e89: Invalid comparison between F8 and I4
		//IL_1e98: Expected F8, but got I4
		//IL_14e7: Expected Obj, but got I
		//IL_14f4: Invalid comparison between F4 and I4
		//IL_150d: Expected VT, but got I
		//IL_1f1c: Expected F8, but got I
		//IL_1f77: Expected Obj, but got I
		//IL_1304: Expected F8, but got I4
		//IL_152e: Expected F8, but got I
		//IL_1554: Expected F4, but got VT
		//IL_1554: Expected VT, but got I
		//IL_1554: Expected Obj, but got I
		//IL_15b5: Expected VT, but got I4
		//IL_15d8: Expected Obj, but got I4
		//IL_15e1: Expected VT, but got I4
		MonsterBrain monsterBrain = brain;
		float num = clock + dt;
		clock = num;
		double num9;
		if ((object)brain != null)
		{
			bool flag = monsterBrain.SnareLeft__BackingField < 0f;
			bool flag2 = monsterBrain.SnareLeft__BackingField == 0f;
			object obj = monsterBrain.SnareLeft__BackingField ^ monsterBrain.SnareLeft__BackingField;
			object obj2 = monsterBrain.SnareLeft__BackingField & obj;
			bool flag3 = (nint)obj2 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			object obj4 = flag4 & obj3;
			object obj5 = ~obj4;
			double num2 = ((obj5 != null) ? 0.0 : 1.0);
			bool flag5 = flag == flag3;
			object obj6 = !flag2;
			object obj7 = flag5 & obj6;
			object obj8 = ~obj7;
			double num3 = ((obj8 != null) ? 3.0 : 9.0);
			double num4 = num2 - (double)thrash;
			double num5 = num3 * (double)dt;
			double num6 = num3 * (double)dt;
			double num7 = 0.0 - num6;
			bool flag6 = num4 < 0.0;
			object obj9 = num4 ^ num4;
			object obj10 = num4 & obj9;
			bool flag7 = (nint)obj10 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			bool flag8 = flag6 == flag7;
			object obj11 = !flag8;
			object obj12 = ~obj11;
			if (obj12 != null)
			{
				num7 = num5;
			}
			bool flag9 = num4 < num5;
			object obj13 = !flag9;
			double num8 = num4 - num5;
			bool flag10 = num8 == 0.0;
			num9 = (double)thrash + num7;
			object obj14 = !flag10;
			object obj15 = obj13 & obj14;
			if ((int)(~obj15) == 0)
			{
				num2 = num9;
			}
			thrash = (float)num2;
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				Vector3 position = transform.position;
				MonsterBrain monsterBrain2 = brain;
				if ((object)brain != null)
				{
					bool flag11 = (byte)(~(monsterBrain2.Dead__BackingField ? 1u : 0u)) != 0;
					object obj16 = !flag11;
					if (obj16 != null || (double)monsterBrain2.ClimbPitch__BackingField > 1.0)
					{
						goto IL_018d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj18 = 0;
					object obj19 = obj17;
					object obj20 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v10+A0]");
					object obj21 = 0;
					UnityEngine.Object obj22 = (UnityEngine.Object)obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v11+E4]");
					bool flag12 = (nint)0 == 0;
					object obj23 = !flag12;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag13 = (UnityEngine.Object)obj21 != null;
					bool flag14 = !flag13;
					object obj24 = 0;
					if (!flag14)
					{
						if (obj21 == null)
						{
							goto IL_17d4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X20_v6 (UnityEngine.Object)+A9]");
						bool flag15 = (nint)0 == 0;
						obj24 = 0;
						if (!flag15)
						{
							object obj25 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X0_v89+E4]");
							bool flag16 = (nint)0 == 0;
							object obj26 = !flag16;
							if (obj26 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X20_v6 (UnityEngine.Object)+C0]");
							bool flag17 = (UnityEngine.Object)0 == brain;
							bool flag18 = !flag17;
							object obj27 = !flag18;
							obj24 = 0;
							if (obj27 != null)
							{
								goto IL_018d;
							}
						}
					}
					Transform transform2 = base.transform;
					if ((object)transform2 != null)
					{
						Vector3 forward = transform2.forward;
						Vector3 vector = Across();
						MonsterBrain monsterBrain3 = brain;
						if ((object)brain != null)
						{
							double num10 = (double)monsterBrain3.AnimSpeed__BackingField * 1.5;
							bool flag19 = num10 < 0.0;
							double num11 = 0.0;
							if (!flag19)
							{
								bool flag20 = !(num10 > 1.0);
								num11 = num10;
								if (!flag20)
								{
									num11 = 1.0;
								}
							}
							object obj28 = 1;
							object obj29 = 0;
							object obj61 = default;
							object obj62 = default;
							object obj63 = default;
							object obj65 = default;
							object obj69 = default;
							object obj75 = default;
							object obj80 = default;
							Quaternion a = default;
							Quaternion b = default;
							while (true)
							{
								Chain[] array = legs;
								if (legs == null)
								{
									break;
								}
								bool flag21 = (nint)obj29 < array.Length;
								object obj30 = !flag21;
								float num15;
								float num32;
								float num73;
								double num74;
								float num77;
								float num82;
								float num107;
								bool flag50;
								double num21;
								float num23;
								double num33;
								double num35;
								if (obj30 == null)
								{
									object obj31 = (object)legs + obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v16+20]");
									Keep((Chain)0);
									bool[] array2 = hangs;
									if (hangs == null)
									{
										break;
									}
									bool flag22 = (nint)obj29 < array2.Length;
									object obj32 = !flag22;
									if (obj32 == null)
									{
										object obj33 = (object)hangs + obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X8_v18+20]");
										bool flag23 = (nint)0 == 0;
										object obj34 = !flag23;
										if (obj34 == null)
										{
											Chain[] array3 = arms;
											if (arms == null)
											{
												break;
											}
											bool flag24 = (nint)obj29 < array3.Length;
											object obj35 = !flag24;
											if (obj35 != null)
											{
												goto IL_17e2;
											}
											object obj36 = (object)arms + obj29;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v104+20]");
											Keep((Chain)0);
										}
										object obj37 = obj28 & 1;
										bool flag25 = obj37 == null;
										object obj38 = !flag25;
										obj28 = 0;
										obj29 = 1;
										if (obj38 != null)
										{
											continue;
										}
										MonsterGore monsterGore = gore;
										if ((object)gore == null)
										{
											break;
										}
										double num29;
										double num34;
										if (~(monsterGore.legs ? 1u : 0u) == 0)
										{
											Chain[] array4 = legs;
											if (legs == null)
											{
												break;
											}
											float num12 = Side__BackingField;
											bool flag26 = Side__BackingField < 0f;
											object obj39 = Side__BackingField ^ Side__BackingField;
											object obj40 = Side__BackingField & obj39;
											bool flag27 = (nint)obj40 < 0;
											bool flag28 = flag26 == flag27;
											bool flag29 = (flag28 ? 1 : 0) < array4.Length;
											object obj41 = !flag29;
											if (obj41 != null)
											{
												goto IL_17e2;
											}
											bool flag30 = Side__BackingField < 0f;
											object obj42 = Side__BackingField ^ Side__BackingField;
											object obj43 = Side__BackingField & obj42;
											bool flag31 = (nint)obj43 < 0;
											bool flag32 = flag30 == flag31;
											object obj44 = legs + flag32;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v96+20]");
											Chain chain = (Chain)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v96+20]");
											double num14;
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X8_v96+20]");
												float num13 = Stance((Chain)0, (float)num9, dt);
												num12 = Side__BackingField;
												num14 = num13;
											}
											else
											{
												num14 = 0.5;
											}
											num15 = Wreck__BackingField;
											float num16 = num12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9B0]");
											float num17 = num16 * 0f;
											float num18 = Wreck__BackingField;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
											float num19 = num18 * 0f;
											float num20 = num17 * limp;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
											num21 = 0.0;
											float num22 = num19;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
											num23 = num22 + 0f;
											double num24 = num14 * (double)num20;
											float num25 = num12 * num23;
											double num26 = num11 * num24;
											float num27 = Wreck__BackingField;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADA4]");
											float num28 = num27 * 0f;
											num29 = (double)num25 + num26;
											float num30 = num28;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
											float num31 = num30 + 0f;
											num32 = 0f;
											num33 = 0.0;
											num34 = num31;
											num35 = num28;
										}
										else
										{
											Chain[] array5 = arms;
											if (arms == null)
											{
												break;
											}
											bool flag33 = Side__BackingField < 0f;
											object obj45 = Side__BackingField ^ Side__BackingField;
											object obj46 = Side__BackingField & obj45;
											bool flag34 = (nint)obj46 < 0;
											bool flag35 = flag33 == flag34;
											object obj47 = !flag35;
											bool flag36 = (nint)obj47 < array5.Length;
											object obj48 = !flag36;
											if (obj48 != null)
											{
												goto IL_17e2;
											}
											bool flag37 = Side__BackingField < 0f;
											object obj49 = Side__BackingField ^ Side__BackingField;
											object obj50 = Side__BackingField & obj49;
											bool flag38 = (nint)obj50 < 0;
											bool flag39 = flag37 == flag38;
											object obj51 = !flag39;
											object obj52 = (object)arms + obj51;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X8_v89+20]");
											Chain chain = (Chain)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X8_v89+20]");
											double num37;
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X8_v89+20]");
												float num36 = Stance((Chain)0, (float)num9, dt);
												num37 = num36;
											}
											else
											{
												num37 = 1.0;
											}
											float num38 = lurch;
											if (dt > 0f)
											{
												double num39 = num37 - (double)lurch;
												float num40 = dt * 9f;
												float num41 = dt * 9f;
												float num42 = 0f - num41;
												bool flag40 = num39 < 0.0;
												object obj53 = num39 ^ num39;
												object obj54 = num39 & obj53;
												bool flag41 = (nint)obj54 < 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
												bool flag42 = flag40 == flag41;
												object obj55 = !flag42;
												object obj56 = ~obj55;
												if (obj56 != null)
												{
													num42 = num40;
												}
												bool flag43 = num39 < (double)num40;
												object obj57 = !flag43;
												double num43 = num39 - (double)num40;
												bool flag44 = num43 == 0.0;
												num38 += num42;
												object obj58 = !flag44;
												object obj59 = obj57 & obj58;
												if ((int)(~obj59) != 0)
												{
													num38 = (float)num37;
												}
											}
											lurch = num38;
											float num44 = armWeight;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
											float num45 = num44 / 0f;
											bool flag45 = num45 < 0f;
											double num46 = 0.0;
											if (!flag45)
											{
												bool flag46 = !((double)num45 > 1.0);
												num46 = num45;
												if (!flag46)
												{
													num46 = 1.0;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											float num47 = 0f - num45;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADDC]");
											float num48 = 0f * num47;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
											float num49 = 0f * num47;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B9F0]");
											object obj60 = 0 * obj61;
											float num50 = num38;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA60]");
											float num51 = num50 * 0f;
											double num52 = num11 * (double)num48;
											double num53 = num11 * (double)num49;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
											num23 = 0f;
											float num54 = num47 * (float)obj60;
											double num55 = Wreck__BackingField;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADA4]");
											double num56 = num55 * 0.0;
											double num57 = num52 + (double)num51;
											num33 = num46 * num53;
											num15 = Side__BackingField;
											float num58 = num54 * (float)obj62;
											double num59 = num56;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA44]");
											num35 = num59 + 0.0;
											num29 = (double)Side__BackingField * num57;
											float num60 = num58 * (float)obj63;
											num34 = num35 + num33;
											num21 = Wreck__BackingField;
											num32 = num60;
										}
										float num61 = clock;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
										float x = num61 * 0f;
										float num62 = Mathf.PerlinNoise(x, seed);
										float num63 = clock;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF38]");
										float y = num63 * 0f;
										float num64 = num62 + -0.5f;
										float num65 = Mathf.PerlinNoise(seed, y);
										float num66 = num65 + -0.5f;
										float num67 = num64;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA18]");
										float num68 = num67 * 0f;
										float num69 = num66;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
										float num70 = num69 * 0f;
										float num71 = num68 * Wreck__BackingField;
										float num72 = Wreck__BackingField * num70;
										num73 = clock;
										num74 = num29 + (double)num71;
										float num75 = clock;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB38]");
										float num76 = num75 * 0f;
										num77 = (float)num34 + num72;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
										float num78 = num76;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
										float num79 = num78 * 0f;
										float num80 = num79;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7FC]");
										float num81 = num80 + 0f;
										num82 = thrash * num81;
										if (num82 > 0f)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C6D8]");
											object obj64 = 0 * obj65;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BCC8]");
											object obj66 = obj64 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
											object obj67 = obj66 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B5B0]");
											object obj68 = 0 * obj69;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B058]");
											object obj70 = obj68 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB8]");
											object obj71 = obj70 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
											float num83 = clock;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE0C]");
											float num84 = num83 * 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107BB40]");
											object obj72 = obj67 * 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C608]");
											object obj73 = obj71 * 0;
											float num85 = num84;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB38]");
											float num86 = num85 + 0f;
											double num87 = (double)obj72 + (double)obj73;
											float num88 = num86 + seed;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
											float num89 = clock;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC10]");
											float num90 = num89 * 0f;
											float num91 = num90;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABD0]");
											float num92 = num91 + 0f;
											float num93 = num92 + seed;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
											float num94 = num88;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
											float num95 = num94 * 0f;
											float num96 = num93;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
											float num97 = num96 * 0f;
											double num98 = height;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
											num35 = num98 * 0.0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
											object obj74 = 0 * obj75;
											float num99 = num95 + num97;
											num73 = num82 * (float)obj74;
											double num100 = (double)num99 * 0.5;
											num77 += num73;
											double num101 = num100 + 0.5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
											double num102 = 0.0 * num87;
											double num103 = num35 * num101;
											float num104 = num82 * (float)num102;
											double num105 = (double)num82 * num103;
											num74 += (double)num104;
											double num106 = (double)num32 + num105;
											num15 = num82;
											num33 = num87;
											num107 = (float)num106;
										}
										else
										{
											num107 = num32;
										}
										Chain[] array6 = legs;
										if (legs == null)
										{
											break;
										}
										bool flag47 = array6[0] == null;
										object obj76 = !flag47;
										if (obj76 == null)
										{
											bool flag48 = array6[1] == null;
											object obj77 = !flag48;
											if (obj77 == null)
											{
												Chain[] array7 = arms;
												if (arms == null)
												{
													break;
												}
												if (array7[0] == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C028]");
													bool flag49 = (nint)0 == 0;
													flag50 = flag49;
													goto IL_1fce;
												}
											}
										}
										flag50 = false;
										goto IL_1fce;
									}
								}
								goto IL_17e2;
								IL_1fce:
								object obj78 = obj18;
								double num108 = 1.0 * num74;
								double num109 = num7 * num74;
								double num110 = 1.0 * (double)num77;
								double num111 = num7 * (double)num77;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ X0_v29+E4]");
								bool flag51 = (nint)0 == 0;
								object obj79 = !flag51;
								if (obj79 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								double num112 = num110 + num108;
								double num113 = num111 + num109;
								bool flag52 = pelvis != null;
								bool flag53 = !flag52;
								double num114 = num15;
								float num115 = num107;
								Vector3 vector2 = (Vector3)0;
								if (!flag53)
								{
									if ((object)pelvis == null)
									{
										break;
									}
									Vector3 position2 = pelvis.position;
									num35 = 1.0 * (double)obj80;
									num33 = (double)monsterBrain2.ClimbPitch__BackingField * (double)obj80;
									num114 = num7 * (double)obj80;
									pelvis.position = (Vector3)0;
									Tilt(pelvis, (Vector3)0);
									num23 = num32;
									num111 = 1.0;
									num115 = num73;
									vector2 = (Vector3)0;
								}
								Tilt(spine, vector2);
								double num116 = num113;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
								double num117 = num116 * 0.0;
								Tilt(chest, vector2);
								bool flag54 = !flag50;
								object obj81 = !flag54;
								object obj82 = 0;
								double num118 = num9;
								float dt2 = dt;
								if (obj81 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj83 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4158]");
									object obj84 = 0;
									object obj85 = this + 380;
									double num119 = num21;
									float num120 = num23;
									double num121 = num114;
									double num122 = num33;
									object obj86 = 0;
									double num123 = num9;
									object obj87 = 0;
									float num124 = dt;
									Vector3 vector3 = vector2;
									double num125 = num35;
									double num126 = num117;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC84]");
									double num127 = 0.0;
									while (true)
									{
										Chain[] array8 = legs;
										if (legs == null)
										{
											break;
										}
										bool flag55 = (nint)obj87 < array8.Length;
										object obj88 = !flag55;
										if (obj88 == null)
										{
											object obj89 = (object)legs + obj87;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v44+20]");
											Chain chain2 = (Chain)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v44+20]");
											bool flag56 = (nint)0 == 0;
											Quaternion quaternion = (Quaternion)vector3;
											float num128 = (float)num127;
											if (!flag56)
											{
												float much;
												Chain c;
												if ((nint)obj87 == trappedSide && thrash > 0f)
												{
													bool flag57 = (byte)(~(trapHeld ? 1u : 0u)) != 0;
													object obj90 = !flag57;
													if (obj90 == null)
													{
														trapHeld = true;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+30]");
														_ = 0;
														obj85 = chain2.at;
													}
													much = (float)trapAt;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v44+20]");
													c = (Chain)0;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+2C]");
													num111 = 0.0;
													bool flag58 = Side__BackingField < 0f;
													object obj91 = Side__BackingField ^ Side__BackingField;
													object obj92 = Side__BackingField & obj91;
													bool flag59 = (nint)obj92 < 0;
													bool flag60 = flag58 == flag59;
													bool flag61 = (nint)obj87 != (flag60 ? 1 : 0);
													num115 = (float)chain2.at;
													Chain chain3 = (Chain)vector3;
													if (!flag61)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
														num112 = (double)Side__BackingField * (double)limp;
														bool flag62 = !(num112 > 0.0);
														num115 = (float)chain2.at;
														chain3 = (Chain)vector3;
														if (!flag62)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v44+20]");
															float num129 = Stance((Chain)0, (float)num123, 0f);
															object obj93 = obj83;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1958 @ X8_v57+A0]");
															object obj94 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+18]");
															nint num130 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+18]");
															object obj95 = num130 * 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+1C]");
															nint num131 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+1C]");
															object obj96 = num131 * 0;
															object obj97 = obj84;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1975 @ X8_v59+A0]");
															object obj98 = 0;
															object obj99 = obj95 + obj96;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+20]");
															float num132 = 0f;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+20]");
															float num133 = num132 * 0f;
															float num134 = num133 + (float)obj99;
															float num135 = (float)chain2.at - (float)chain2.hip;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+30]");
															float num136 = 0f;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+3C]");
															float num137 = num136 - 0f;
															if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num134) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj98))
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+2C]");
																double num138 = 0.0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+38]");
																double num139 = num138 - 0.0;
																float num140 = num135;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+18]");
																float num141 = num140 * 0f;
																double num142 = num139;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+1C]");
																double num143 = num142 * 0.0;
																float num144 = num141 + (float)num143;
																float num145 = num137;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+20]");
																float num146 = num145 * 0f;
																float num147 = num146 + num144;
																float num148 = num147 / num134;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+18]");
																float num149 = 0f * num148;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ X8_v58+20]");
																float num150 = 0f * num148;
																num135 -= num149;
																num137 -= num150;
															}
															bool flag63 = num112 < 0.0;
															double num151 = 0.0;
															if (!flag63)
															{
																bool flag64 = !(num112 > 1.0);
																num151 = num112;
																if (!flag64)
																{
																	num151 = 1.0;
																}
															}
															num120 = (float)chain2.hip;
															double num152 = num9 + (double)chain2.low;
															num121 = num111 - num152;
															if (num121 < 0.0)
															{
																num121 = 0.0;
															}
															bool flag65 = num112 < 0.0;
															double num153 = 0.0;
															if (!flag65)
															{
																bool flag66 = !(num112 > 1.0);
																num153 = num112;
																if (!flag66)
																{
																	num153 = 1.0;
																}
															}
															double num154 = num151;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB3C]");
															double num155 = num154 * 0.0;
															double num156 = num153;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC84]");
															double num157 = num156 * 0.0;
															double num158 = num155 + 1.0;
															double num159 = num157 + 1.0;
															float num160 = num135 * (float)num158;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+3C]");
															num122 = 0.0;
															double num161 = num121 * num159;
															num115 = num120 + num160;
															num111 = num152 + num161;
															num119 = 1.0;
															num123 = num9;
															num124 = dt;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v44+20]");
															chain3 = (Chain)0;
														}
													}
													vector3 = (Vector3)chain3;
													much = num115;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X8_v44+20]");
													c = (Chain)0;
												}
												Solve(c, vector3, much);
												if ((object)chain2.end == null)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+48]");
												num126 = 0.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v8 (MonsterWounds+Chain)+4C]");
												num125 = 0.0;
												num128 = (float)chain2.turn;
												chain2.end.rotation = (Quaternion)0;
												quaternion = (Quaternion)0;
											}
											Chain[] array9 = arms;
											if (arms == null)
											{
												break;
											}
											bool flag67 = (nint)obj87 < array9.Length;
											object obj100 = !flag67;
											if (obj100 == null)
											{
												object obj101 = (object)arms + obj87;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v47+20]");
												Chain chain4 = (Chain)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v47+20]");
												bool flag68 = (nint)0 == 0;
												vector2 = (Vector3)quaternion;
												if (!flag68)
												{
													bool[] array10 = hangs;
													if (hangs == null)
													{
														break;
													}
													bool flag69 = (nint)obj87 < array10.Length;
													object obj102 = !flag69;
													if (obj102 != null)
													{
														goto IL_17e2;
													}
													object obj103 = (object)hangs + obj87;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1963 @ X8_v50+20]");
													bool flag70 = (nint)0 == 0;
													object obj104 = !flag70;
													vector2 = (Vector3)quaternion;
													if (obj104 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v47+20]");
														num128 = Stance((Chain)0, (float)num123, num124);
														bool flag71 = !(num128 > 0f);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v47+20]");
														vector2 = (Vector3)0;
														if (!flag71)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X22_v9 (MonsterWounds+Chain)+30]");
															num126 = 0.0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v47+20]");
															nint num162 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ X8_v47+20]");
															Solve((Chain)num162, (Vector3)0, (float)chain4.at);
															if ((object)chain4.end == null)
															{
																break;
															}
															Quaternion rotation = chain4.end.rotation;
															Quaternion quaternion2 = Quaternion.Internal_Slerp(ref a, ref b, num128);
															chain4.end.rotation = (Quaternion)0;
															b = chain4.turn;
															a = (Quaternion)chain4.at;
															obj86 = 0;
															vector2 = (Vector3)0;
															num125 = num128;
														}
													}
												}
												obj87++;
												bool flag72 = (nint)obj87 != 2;
												num21 = num119;
												num23 = num120;
												num114 = num121;
												num33 = num122;
												obj82 = obj86;
												num118 = num123;
												dt2 = num124;
												num35 = num125;
												num117 = num126;
												vector3 = vector2;
												num127 = num128;
												if (flag72)
												{
													continue;
												}
												goto IL_1675;
											}
										}
										goto IL_17e2;
									}
									break;
								}
								goto IL_1675;
								IL_1675:
								Arms(dt2, (float)num118);
								object obj105 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1633 @ X0_v38+E4]");
								bool flag73 = (nint)0 == 0;
								object obj106 = !flag73;
								if (obj106 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (head != null)
								{
									double num163 = (double)headHits * 0.25;
									float num164 = Wreck__BackingField;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
									float num165 = num164 * 0f;
									double num166 = num163 + (double)num165;
									if (num166 < 0.0 || !(num166 > 1.0))
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
										Tilt(head, (Vector3)0);
									}
								}
								if (num82 > 0f)
								{
									Flail((Vector3)0, (Vector3)0, 1f);
								}
								return;
							}
						}
					}
				}
			}
		}
		goto IL_17d4;
		IL_018d:
		Arms(dt, (float)num9);
		return;
		IL_17e2:
		throw new IndexOutOfRangeException();
		IL_17d4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_17e2;
	}

	private static void Tilt(Transform bone, Vector3 over)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_00b4: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (bone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			object obj7 = default;
			if ((nint)obj7 > 0)
			{
			}
			Vector3 fromDirection = default;
			Vector3 toDirection = default;
			Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
			Quaternion rotation = bone.rotation;
			bone.rotation = (Quaternion)0;
		}
	}

	private Vector3 Across()
	{
		//IL_041f: Expected VT, but got Obj
		//IL_005a: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I
		//IL_04a6: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I8
		//IL_0253: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I4
		//IL_04c4: Expected Obj, but got I
		//IL_04cc: Expected VT, but got Obj
		//IL_04ee: Expected Obj, but got I4
		Chain[] array = arms;
		if (arms == null)
		{
			goto IL_0403;
		}
		if (array.Length == 0)
		{
			goto IL_0411;
		}
		Chain chain = array[0];
		bool flag = array[0] == null;
		object obj = !flag;
		UnityEngine.Object obj2;
		if (obj == null)
		{
			Chain[] array2 = legs;
			if (legs == null)
			{
				goto IL_0403;
			}
			if (array2.Length == 0)
			{
				goto IL_0411;
			}
			chain = array2[0];
			if (array2[0] == null)
			{
				obj2 = null;
				goto IL_044d;
			}
		}
		obj2 = chain.upper;
		goto IL_044d;
		IL_046c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = obj2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		UnityEngine.Object obj9;
		Vector3 result;
		if (obj6 == null)
		{
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = obj9 == null;
			bool flag7 = !flag6;
			object obj10 = !flag7;
			if (obj10 == null)
			{
				if ((object)obj9 != null)
				{
					Vector3 position = ((Transform)obj9).position;
					if ((object)obj2 != null)
					{
						Vector3 position2 = ((Transform)obj2).position;
						object obj12 = default;
						object obj11 = obj12 - obj12;
						object obj14 = default;
						object obj13 = obj14 - obj14;
						object obj15 = obj11 * obj11;
						object obj16 = obj13 * obj13;
						object obj17 = obj15 + obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEA8]");
						if ((nint)obj17 <= 0)
						{
							goto IL_03ac;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
						object obj18 = 0;
						result = (Vector3)obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v10 (UnityEngine.Vector3)+E4]");
						bool flag8 = (nint)0 == 0;
						object obj19 = !flag8;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
						if ((nint)obj14 <= 0)
						{
						}
						goto IL_03e5;
					}
				}
				goto IL_0403;
			}
		}
		goto IL_03ac;
		IL_044d:
		if (array.Length == 1)
		{
			goto IL_0411;
		}
		Chain chain2 = array[1];
		bool flag9 = array[1] == null;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Chain[] array3 = legs;
			if (legs == null)
			{
				goto IL_0403;
			}
			object obj21 = array3.Length & 0xFFFFFFFEL;
			if (obj21 == null)
			{
				goto IL_0411;
			}
			chain2 = array3[1];
			if (array3[1] == null)
			{
				obj9 = null;
				goto IL_046c;
			}
		}
		obj9 = chain2.upper;
		goto IL_046c;
		IL_0403:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0411;
		IL_03e5:
		return result;
		IL_0411:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		return (Vector3)ex2;
		IL_03ac:
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			result = transform.right;
			goto IL_03e5;
		}
		goto IL_0403;
	}

	private static void Keep(Chain c)
	{
		if (c != null)
		{
			Vector3 position = c.end.position;
			Vector3 vector = default;
			c.at = vector;
			Quaternion rotation = c.end.rotation;
			c.turn = (Quaternion)vector;
			Vector3 position2 = c.upper.position;
			c.hip = vector;
		}
	}

	private float Stance(Chain c, float floor, float dt)
	{
		//IL_0025: Invalid comparison between F4 and I4
		//IL_0200: Invalid comparison between F4 and I4
		//IL_020f: Expected F8, but got I4
		//IL_00a6: Invalid comparison between F4 and I4
		//IL_00b9: Expected Obj, but got F4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_024e: Invalid comparison between F4 and I4
		//IL_0273: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [c @ X1 (MonsterWounds+Chain)+2C]");
		float num = 0f - floor;
		bool flag = c.low == 2.139095E+09f;
		float num2 = num;
		if (!flag)
		{
			float num3 = height * dt;
			float num4 = num - c.low;
			float num5 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			float num6 = num5 * 0f;
			float num7 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
			float num8 = num7 * 0f;
			float num9 = 0f - num8;
			bool flag2 = num4 < 0f;
			object obj = num4 ^ num4;
			object obj2 = num4 & obj;
			bool flag3 = (nint)obj2 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			bool flag4 = flag2 == flag3;
			object obj3 = !flag4;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				num9 = num6;
			}
			bool flag5 = num4 < num6;
			object obj5 = !flag5;
			float num10 = num4 - num6;
			bool flag6 = num10 == 0f;
			float num11 = c.low + num9;
			object obj6 = !flag6;
			object obj7 = obj5 & obj6;
			object obj8 = ~obj7;
			if (obj8 != null)
			{
				num11 = num;
			}
			num2 = ((!(num < num11)) ? num11 : num);
		}
		float num12 = num - num2;
		c.low = num2;
		float num13 = height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B010]");
		float num14 = num13 * 0f;
		float num15 = height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		float num16 = num15 * 0f;
		float num17 = num12 + num14;
		float num18 = num17 / num16;
		bool flag7 = num18 < 0f;
		double num19 = 0.0;
		if (!flag7)
		{
			bool flag8 = !((double)num18 > 1.0);
			num19 = num18;
			if (!flag8)
			{
				num19 = 1.0;
			}
		}
		double num20 = num19 + num19;
		double num21 = num19 * 3.0;
		double num22 = num19 * num20;
		double num23 = num19 * num22;
		double num24 = num19 * num21;
		double num25 = num24 - num23;
		double num26 = 1.0 - num25;
		double num27 = num26 * 0.0;
		double num28 = num25 + num27;
		return 1f - (float)num28;
	}

	private float Wave(float one, float other, float from)
	{
		float num = clock * one;
		float num2 = num + from;
		float num3 = seed + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num4 = clock * other;
		float num5 = from;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
		float num6 = num5 * 0f;
		float num7 = num6 + num4;
		float num8 = seed + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
		float num9 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num10 = num9 * 0f;
		float num11 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
		float num12 = num11 * 0f;
		return num10 + num12;
	}

	private void Arms(float dt, float floor)
	{
		//IL_1a8a: Expected Obj, but got I
		//IL_1a9a: Expected Obj, but got I
		//IL_1aab: Expected Obj, but got I4
		//IL_1ab4: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_19c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c9: Expected Obj, but got Unknown
		//IL_19d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d7: Expected Obj, but got Unknown
		//IL_0094: Invalid comparison between F4 and I4
		//IL_0209: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I4
		//IL_0242: Expected F4, but got I
		//IL_1eda: Expected Obj, but got I4
		//IL_0250: Invalid comparison between F4 and I4
		//IL_0261: Expected Obj, but got I4
		//IL_026a: Invalid comparison between F4 and I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I
		//IL_1b10: Invalid comparison between F8 and I4
		//IL_1b23: Expected Obj, but got F8
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b30: Expected Obj, but got Unknown
		//IL_1b58: Expected Obj, but got I4
		//IL_019a: Expected F8, but got I4
		//IL_0309: Expected Obj, but got I
		//IL_1b77: Invalid comparison between Obj and F4
		//IL_1b88: Expected Obj, but got I4
		//IL_1ba0: Invalid comparison between F4 and I4
		//IL_1bc8: Expected Obj, but got I4
		//IL_1bde: Expected I4, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_0874: Expected Obj, but got I4
		//IL_1c48: Expected Obj, but got I4
		//IL_03af: Expected Obj, but got I4
		//IL_0597: Expected Obj, but got I4
		//IL_044e: Expected Obj, but got I4
		//IL_05c6: Expected Obj, but got F4
		//IL_0600: Expected Obj, but got I4
		//IL_1c5f: Invalid comparison between F4 and I4
		//IL_0824: Expected Obj, but got I4
		//IL_0835: Expected VT, but got I4
		//IL_062f: Expected Obj, but got F4
		//IL_1cc1: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_0673: Expected Obj, but got I4
		//IL_1c98: Expected Obj, but got I4
		//IL_06ac: Expected Obj, but got F4
		//IL_1749: Expected Obj, but got I4
		//IL_07eb: Expected Obj, but got I4
		//IL_06e6: Expected Obj, but got I4
		//IL_1783: Expected Obj, but got I
		//IL_1793: Expected F4, but got I
		//IL_17ab: Expected Obj, but got I
		//IL_17c8: Expected Obj, but got I
		//IL_08cb: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I4
		//IL_0715: Expected Obj, but got F4
		//IL_180c: Expected Obj, but got I4
		//IL_095f: Expected Obj, but got I4
		//IL_09b1: Expected Obj, but got I4
		//IL_1883: Expected Obj, but got I
		//IL_1894: Expected Obj, but got I
		//IL_18dc: Expected Obj, but got I4
		//IL_0a03: Expected Obj, but got I4
		//IL_0a4c: Expected Obj, but got I
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abc: Expected Obj, but got Unknown
		//IL_0b0d: Expected Obj, but got F4
		//IL_192e: Expected Obj, but got I4
		//IL_0b51: Expected Obj, but got I4
		//IL_196a: Expected Obj, but got I
		//IL_197a: Expected F4, but got I
		//IL_1992: Expected Obj, but got I
		//IL_19b0: Expected VT, but got I4
		//IL_19b0: Expected Obj, but got I
		//IL_19b5: Expected I, but got Obj
		//IL_0ba3: Expected Obj, but got I4
		//IL_0bec: Expected Obj, but got I
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected Obj, but got Unknown
		//IL_0c6c: Expected Obj, but got F4
		//IL_0cb0: Expected Obj, but got I4
		//IL_0d26: Expected Obj, but got I4
		//IL_0d9c: Expected Obj, but got I4
		//IL_0dee: Expected Obj, but got I4
		//IL_0ef4: Invalid comparison between F8 and I4
		//IL_0f14: Expected F8, but got I4
		//IL_0f34: Expected Obj, but got I4
		//IL_0f86: Expected Obj, but got I4
		//IL_105f: Invalid comparison between F8 and I4
		//IL_107f: Expected F8, but got I4
		//IL_109f: Expected Obj, but got I4
		//IL_1f12: Expected Obj, but got I4
		//IL_1147: Invalid comparison between F4 and I
		//IL_11a3: Expected Obj, but got I
		//IL_11ab: Expected F4, but got Obj
		//IL_11bb: Expected F4, but got I
		//IL_1e33: Expected Obj, but got I4
		//IL_1209: Expected Obj, but got F4
		//IL_124d: Expected Obj, but got I4
		//IL_129f: Expected Obj, but got I4
		//IL_12db: Expected F4, but got I
		//IL_1f4a: Expected Obj, but got I4
		//IL_1362: Invalid comparison between F4 and I
		//IL_13be: Expected Obj, but got I
		//IL_13c6: Expected F4, but got Obj
		//IL_13d6: Expected F4, but got I
		//IL_1e61: Expected Obj, but got I4
		//IL_14ae: Expected Obj, but got F4
		//IL_14f2: Expected Obj, but got I4
		//IL_151f: Invalid comparison between I and F4
		//IL_1648: Expected Obj, but got I4
		//IL_157f: Expected Obj, but got I4
		//IL_1675: Invalid comparison between I and F4
		//IL_1687: Expected VT, but got I4
		//IL_1690: Expected VT, but got I4
		//IL_15d5: Expected Obj, but got I
		//IL_15de: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e3: Expected Obj, but got Unknown
		//IL_1607: Unknown result type (might be due to invalid IL or missing references)
		//IL_160c: Expected Obj, but got Unknown
		//IL_1628: Expected Obj, but got F8
		//IL_16d1: Expected VT, but got I4
		//IL_16da: Expected VT, but got I4
		Vector3 vector = Across();
		float num = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		float num2 = num / 0f;
		float num3 = dt * 1.1167334E+09f;
		float num4 = 0f - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D110");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		float num6 = num5 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		float num8 = default;
		float num7 = num8;
		object obj3 = 40;
		object obj4 = 0;
		double num9 = 1.0;
		float num10 = num4;
		float num11 = num2;
		float num12 = num6;
		float num13 = dt;
		object obj18 = default;
		object obj39 = default;
		object obj41 = default;
		object obj70 = default;
		Vector3 tipWanted = default;
		float num99 = default;
		while (true)
		{
			Chain[] array = arms;
			object obj9;
			if (arms != null)
			{
				bool flag = (nint)obj4 < array.Length;
				object obj5 = !flag;
				if (obj5 != null)
				{
					break;
				}
				object obj6 = (object)arms + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v11+20]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X8_v11+20]");
				if ((nint)0 == 0)
				{
					goto IL_19bb;
				}
				float[] array2 = hanging;
				object obj8 = (object)hanging + obj4;
				if (num13 > 0f)
				{
					if (hanging != null)
					{
						obj9 = array2.Length;
						bool flag2 = (nint)obj4 < array2.Length;
						object obj10 = !flag2;
						if (obj10 != null)
						{
							break;
						}
						bool[] array3 = hangs;
						if (hangs != null)
						{
							object obj11 = array3.Length;
							bool flag3 = (nint)obj4 < array3.Length;
							object obj12 = !flag3;
							if (obj12 != null)
							{
								break;
							}
							object obj13 = (object)hangs + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ X10_v27+20]");
							double num14 = (((nint)0 != 0) ? num9 : 0.0);
							double num15 = num14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v13+20]");
							double num16 = num15 - 0.0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
							bool flag4 = num16 < 0.0;
							object obj14 = num16 ^ num16;
							object obj15 = num16 & obj14;
							bool flag5 = (nint)obj15 < 0;
							bool flag6 = flag4 == flag5;
							object obj16 = !flag6;
							object obj17 = ~obj16;
							num7 = ((obj17 != null) ? num11 : num10);
							bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num11);
							object obj19 = !flag7;
							float num17 = (float)obj18 - num11;
							bool flag8 = num17 == 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v13+20]");
							num3 = 0f + num7;
							object obj20 = !flag8;
							object obj21 = obj19 & obj20;
							num12 = (((int)(~obj21) != 0) ? ((float)num14) : num3);
							goto IL_1ec1;
						}
					}
				}
				else if (hanging != null)
				{
					obj9 = array2.Length;
					bool flag9 = (nint)obj4 < array2.Length;
					object obj22 = !flag9;
					if (obj22 != null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v13+20]");
					num12 = 0f;
					goto IL_1ec1;
				}
			}
			goto IL_19f8;
			IL_1c56:
			double num18;
			Transform transform;
			Vector3[] array4;
			Vector3 tipNow;
			if (num13 > 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj23 = 0;
				object obj24 = obj23;
				num18 = (((nint)obj3 != 40) ? num9 : (-1.0));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ X0_v27+E4]");
				bool flag10 = (nint)0 == 0;
				object obj25 = !flag10;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (chest != null)
				{
					transform = chest;
					bool flag11 = (object)chest == null;
					object obj26 = !flag11;
					if (obj26 != null)
					{
						goto IL_08ae;
					}
				}
				else
				{
					transform = base.transform;
					if ((object)transform != null)
					{
						goto IL_08ae;
					}
				}
			}
			else
			{
				array4 = elbow;
				bool flag12 = elbow == null;
				object obj27 = !flag12;
				float num19 = num7;
				tipNow = (Vector3)0;
				if (obj27 != null)
				{
					goto IL_1ca6;
				}
			}
			goto IL_19f8;
			IL_19bb:
			obj3 += 12;
			obj4++;
			if ((nint)obj3 == 64)
			{
				return;
			}
			continue;
			IL_08ae:
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj28 = 0;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1277 @ X0_v33+E4]");
			bool flag13 = (nint)0 == 0;
			object obj30 = !flag13;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector3 gravity = Physics.gravity;
			Vector3[] array5 = elbow;
			float num23;
			double num37;
			if (elbow != null)
			{
				bool flag14 = (nint)obj4 < array5.Length;
				object obj31 = !flag14;
				if (obj31 != null)
				{
					break;
				}
				Vector3[] array6 = wrist;
				if (wrist != null)
				{
					bool flag15 = (nint)obj4 < array6.Length;
					object obj32 = !flag15;
					if (obj32 != null)
					{
						break;
					}
					Vector3[] array7 = elbowWas;
					if (elbowWas != null)
					{
						bool flag16 = (nint)obj4 < array7.Length;
						object obj33 = !flag16;
						if (obj33 != null)
						{
							break;
						}
						object obj11 = (object)elbow + obj3;
						object obj34 = (object)elbowWas + obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X11_v6-8]");
						nint num20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X10_v13-8]");
						object obj35 = num20 - 0;
						object obj36 = (object)wrist + obj3;
						object obj37 = (object)elbow + obj3;
						object obj38 = obj11 - obj34;
						double num21 = -1.0 * (double)obj39;
						float num22 = num6 * num23;
						object obj40 = obj35 * obj41;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A984]");
						object obj42 = 0 * obj38;
						double num24 = num21 + (double)obj40;
						float num25 = num22 + (float)obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X11_v6-8]");
						double num26 = 0.0 + num24;
						float num27 = (float)obj11 + num25;
						obj37 = num27;
						Vector3[] array8 = wrist;
						if (wrist != null)
						{
							bool flag17 = (nint)obj4 < array8.Length;
							object obj43 = !flag17;
							if (obj43 != null)
							{
								break;
							}
							Vector3[] array9 = wristWas;
							if (wristWas != null)
							{
								bool flag18 = (nint)obj4 < array9.Length;
								object obj44 = !flag18;
								if (obj44 != null)
								{
									break;
								}
								object obj45 = (object)wristWas + obj3;
								object obj46 = (object)wrist + obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X9_v21-8]");
								nint num28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X9_v24-8]");
								object obj47 = num28 - 0;
								object obj48 = obj36 - obj45;
								object obj49 = obj47 * obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A984]");
								object obj50 = 0 * obj48;
								double num29 = num21 + (double)obj49;
								float num30 = num22 + (float)obj50;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X8_v38-8]");
								double num31 = 0.0 + num29;
								float num32 = (float)obj46 + num30;
								obj46 = num32;
								Vector3[] array10 = elbowWas;
								if (elbowWas != null)
								{
									bool flag19 = (nint)obj4 < array10.Length;
									object obj51 = !flag19;
									if (obj51 != null)
									{
										break;
									}
									object obj52 = (object)elbowWas + obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X11_v6-8]");
									_ = 0;
									obj52 = obj11;
									Vector3[] array11 = wristWas;
									if (wristWas != null)
									{
										bool flag20 = (nint)obj4 < array11.Length;
										object obj53 = !flag20;
										if (obj53 != null)
										{
											break;
										}
										object obj54 = (object)wristWas + obj3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X9_v21-8]");
										_ = 0;
										obj54 = obj36;
										Vector3[] array12 = elbow;
										if (elbow != null)
										{
											bool flag21 = (nint)obj4 < array12.Length;
											object obj55 = !flag21;
											if (obj55 != null)
											{
												break;
											}
											float[] array13 = armClear;
											if (armClear != null)
											{
												bool flag22 = (nint)obj4 < array13.Length;
												object obj56 = !flag22;
												if (obj56 != null)
												{
													break;
												}
												object obj57 = (object)elbow + obj3;
												object obj58 = (object)armClear + obj4;
												float num33 = dt * (float)num18;
												float num34 = floor * (float)num18;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v16-8]");
												double num35 = 0.0 - -1.0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v16-4]");
												double num36 = 0.0 - num37;
												double num38 = (double)num8 * num18;
												float num39 = (float)obj57 - num23;
												float num40 = num33 * (float)num35;
												float num41 = num34 * (float)num36;
												double num42 = num38 * (double)num39;
												float num43 = num40 + num41;
												double num44 = num42 + (double)num43;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X9_v29+20]");
												double num45 = 0.0 - num44;
												if (num45 < 0.0)
												{
													num45 = 0.0;
												}
												float num46 = num33 * (float)num45;
												float num47 = num34 * (float)num45;
												double num48 = num38 * num45;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v16-8]");
												float num49 = 0f + num46;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X10_v16-4]");
												float num50 = 0f + num47;
												double num51 = (double)obj57 + num48;
												Vector3[] array14 = wrist;
												if (wrist != null)
												{
													bool flag23 = (nint)obj4 < array14.Length;
													object obj59 = !flag23;
													if (obj59 != null)
													{
														break;
													}
													float[] array15 = armClear;
													if (armClear != null)
													{
														bool flag24 = (nint)obj4 < array15.Length;
														object obj60 = !flag24;
														if (obj60 != null)
														{
															break;
														}
														object obj61 = (object)wrist + obj3;
														object obj62 = (object)armClear + obj4;
														float num52 = (float)obj61 - num23;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X10_v18-8]");
														double num53 = 0.0 - -1.0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X10_v18-4]");
														double num54 = 0.0 - num37;
														double num55 = num38 * (double)num52;
														float num56 = num33 * (float)num53;
														float num57 = num34 * (float)num54;
														float num58 = num56 + num57;
														double num59 = num55 + (double)num58;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X9_v32+20]");
														double num60 = 0.0 - num59;
														if (num60 < 0.0)
														{
															num60 = 0.0;
														}
														float num61 = num33 * (float)num60;
														float num62 = num34 * (float)num60;
														double num63 = num38 * num60;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X10_v18-8]");
														float num64 = 0f + num61;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X10_v18-4]");
														float num65 = 0f + num62;
														double num66 = (double)obj61 + num63;
														Vector3[] array16 = elbow;
														if (elbow != null)
														{
															bool flag25 = (nint)obj4 < array16.Length;
															object obj63 = !flag25;
															if (obj63 != null)
															{
																break;
															}
															object obj64 = (object)elbow + obj3;
															object obj65 = obj;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ X0_v39+E4]");
															bool flag26 = (nint)0 == 0;
															object obj66 = !flag26;
															if (obj66 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															float num67 = (float)obj64 - num7;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v9-8]");
															float num68 = 0f - num12;
															float num69 = num67 * num67;
															float num70 = num68 * num68;
															Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
															float num71 = num70 + num69;
															Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
															float num72;
															float num73;
															if (num71 > 0f)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																num72 = num67 / num71;
																num73 = num68 / num69;
															}
															else
															{
																object obj67 = obj2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ X8_v64+A0]");
																object obj68 = 0;
																num73 = (float)obj68;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X8_v65+8]");
																num72 = 0f;
															}
															bool flag27 = (nint)obj4 < array16.Length;
															object obj69 = !flag27;
															if (obj69 != null)
															{
																break;
															}
															float num74 = num73 * (float)obj70;
															float num75 = (float)obj18 * num72;
															float num76 = num12 + num74;
															float num77 = num7 + num75;
															obj64 = num77;
															Vector3[] array17 = elbow;
															if (elbow != null)
															{
																bool flag28 = (nint)obj4 < array17.Length;
																object obj71 = !flag28;
																if (obj71 != null)
																{
																	break;
																}
																Vector3[] array18 = wrist;
																if (wrist != null)
																{
																	bool flag29 = (nint)obj4 < array18.Length;
																	object obj72 = !flag29;
																	if (obj72 != null)
																	{
																		break;
																	}
																	object obj73 = (object)elbow + obj3;
																	Transform transform2 = (Transform)(object)((object)wrist + obj3);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X22_v6 (UnityEngine.Transform)-8]");
																	float num19 = 0f;
																	object obj74 = obj;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ X0_v43+E4]");
																	bool flag30 = (nint)0 == 0;
																	object obj75 = !flag30;
																	if (obj75 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	float num78 = num19;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X8_v53-8]");
																	float num79 = num78 - 0f;
																	object obj76 = (object)transform2 - obj73;
																	float num80 = num79 * num79;
																	object obj77 = obj76 * obj76;
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
																	float num81 = num80 + (float)obj77;
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
																	float num82;
																	float num83;
																	if (num81 > 0f)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																		num82 = (float)obj76 / num81;
																		num83 = num79 / (float)obj77;
																	}
																	else
																	{
																		object obj78 = obj2;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ X8_v62+A0]");
																		object obj79 = 0;
																		num83 = (float)obj79;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1441 @ X8_v63+8]");
																		num82 = 0f;
																	}
																	bool flag31 = (nint)obj4 < array18.Length;
																	object obj80 = !flag31;
																	if (obj80 != null)
																	{
																		break;
																	}
																	float num84 = num7 - num7;
																	float num85 = num12 - num12;
																	float num86 = num3 - num3;
																	float num87 = num84 * num84;
																	float num88 = num85 * num85;
																	float num89 = num86 * num86;
																	float num90 = num88 + num89;
																	float num91 = num87 + num90;
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																	float num92 = num83 * (float)obj70;
																	float num93 = num91 * num82;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X8_v53-8]");
																	float num94 = 0f + num92;
																	float num95 = (float)obj73 + num93;
																	transform2 = (Transform)num95;
																	Vector3[] array19 = wrist;
																	if (wrist != null)
																	{
																		bool flag32 = (nint)obj4 < array19.Length;
																		object obj81 = !flag32;
																		if (obj81 != null)
																		{
																			break;
																		}
																		object obj82 = (object)wrist + obj3;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X10_v19-4]");
																		if (0f < floor)
																		{
																			Vector3[] array20 = wristWas;
																			if (wristWas == null)
																			{
																				goto IL_19f8;
																			}
																			bool flag33 = (nint)obj4 < array20.Length;
																			object obj83 = !flag33;
																			if (obj83 != null)
																			{
																				break;
																			}
																			object obj84 = (object)wrist + obj3;
																			object obj85 = (object)wristWas + obj3;
																			object obj86 = obj84 - obj85;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1467 @ X8_v61-8]");
																			nint num96 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1462 @ X9_v41-8]");
																			object obj87 = num96 - 0;
																			object obj88 = obj87 * 63;
																			double num97 = (double)obj86 * 0.5;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1462 @ X9_v41-8]");
																			object obj89 = 0 + obj88;
																			double num98 = (double)obj85 + num97;
																			obj85 = num98;
																		}
																		array4 = elbow;
																		if (elbow != null)
																		{
																			bool flag34 = (nint)obj4 < array4.Length;
																			object obj90 = !flag34;
																			if (obj90 != null)
																			{
																				break;
																			}
																			object obj91 = (object)elbow + obj3;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1251 @ X9_v39-4]");
																			bool flag35 = !(0f < floor);
																			tipWanted = (Vector3)0;
																			tipNow = (Vector3)0;
																			num9 = 1.0;
																			num10 = num4;
																			num11 = num2;
																			num13 = dt;
																			if (!flag35)
																			{
																				tipWanted = (Vector3)0;
																				tipNow = (Vector3)0;
																				num9 = 1.0;
																				num10 = num4;
																				num11 = num2;
																				num13 = dt;
																			}
																			goto IL_1ca6;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_19f8;
			IL_1ca6:
			bool flag36 = (nint)obj4 < array4.Length;
			object obj92 = !flag36;
			if (obj92 != null)
			{
				break;
			}
			float[] array21 = hanging;
			if (hanging != null)
			{
				bool flag37 = (nint)obj4 < array21.Length;
				object obj93 = !flag37;
				if (obj93 != null)
				{
					break;
				}
				object obj94 = (object)array4 + obj3;
				object obj95 = (object)hanging + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v22-8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v22-4]");
				num99 = 0f;
				object obj96 = obj94;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X9_v14+20]");
				object obj97 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+10]");
				Aim((Transform)0, tipNow, tipWanted, num12);
				int[] array22 = armState;
				if (armState != null)
				{
					bool flag38 = (nint)obj4 < array22.Length;
					object obj98 = !flag38;
					if (obj98 != null)
					{
						break;
					}
					object obj99 = (object)armState + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ X8_v24+20]");
					if ((nint)0 == 2)
					{
						goto IL_19bb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+18]");
						Transform transform2 = (Transform)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+20]");
						Vector3 position2 = ((Transform)0).position;
						Vector3[] array23 = wrist;
						if (wrist != null)
						{
							bool flag39 = (nint)obj4 < array23.Length;
							object obj100 = !flag39;
							if (obj100 != null)
							{
								break;
							}
							float[] array24 = hanging;
							if (hanging != null)
							{
								bool flag40 = (nint)obj4 < array24.Length;
								object obj101 = !flag40;
								if (obj101 != null)
								{
									break;
								}
								object obj102 = (object)wrist + obj3;
								object obj103 = (object)hanging + obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v27-8]");
								obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v27-4]");
								num99 = 0f;
								obj96 = obj102;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X9_v18+20]");
								obj97 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+18]");
								Aim((Transform)0, (Vector3)0, tipWanted, num12);
								nint num100 = unchecked((nint)null);
								goto IL_19bb;
							}
						}
					}
				}
			}
			goto IL_19f8;
			IL_1ec1:
			bool flag41 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			object obj104 = !flag41;
			if (obj104 != null)
			{
				break;
			}
			bool flag42 = num12 < 0f;
			object obj105 = !flag42;
			bool flag43 = num12 == 0f;
			object obj106 = ~obj105;
			object obj107 = obj106 | flag43;
			if (obj107 != null)
			{
				goto IL_19bb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+10]");
				Vector3 position3 = ((Transform)0).position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+18]");
					Vector3 position4 = ((Transform)0).position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X24_v4+20]");
						Vector3 position5 = ((Transform)0).position;
						object obj108 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X0_v18+E4]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD9A1]");
							bool flag44 = (nint)0 == 0;
							object obj109 = !flag44;
							if (obj109 == null)
							{
								_ = 1;
							}
						}
						object obj110 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X0_v20+E4]");
						bool flag45 = (nint)0 == 0;
						object obj111 = !flag45;
						if (obj111 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool[] array25 = swinging;
						if (swinging != null)
						{
							bool flag46 = (nint)obj4 < array25.Length;
							object obj112 = !flag46;
							if (obj112 != null)
							{
								break;
							}
							float num101 = num7 - num7;
							object obj113 = (object)swinging + obj4;
							Vector3[] array26 = elbow;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X9_v9+20]");
							if ((nint)0 != 0)
							{
								if (elbow == null)
								{
									goto IL_19f8;
								}
								bool flag47 = (nint)obj4 < array26.Length;
								object obj114 = !flag47;
								if (obj114 != null)
								{
									break;
								}
								object obj115 = (object)elbow + obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X10_v25-8]");
								float num102 = 0f - num12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X10_v25-4]");
								float num103 = 0f - num3;
								float num104 = (float)obj115 - num7;
								float num105 = num102 * num102;
								float num106 = num103 * num103;
								float num107 = num105 + num106;
								float num108 = num104 * num104;
								num101 = (float)obj18 * (float)obj18;
								float num109 = num107 + num108;
								num37 = (double)num101 * 4.0;
								bool flag48 = !((double)num109 > num37);
								num99 = num12;
								float num110 = num12;
								num23 = num101;
								if (flag48)
								{
									goto IL_1c56;
								}
							}
							Vector3[] array27 = elbowWas;
							_ = 1;
							if (elbowWas != null)
							{
								bool flag49 = (nint)obj4 < array27.Length;
								object obj116 = !flag49;
								if (obj116 != null)
								{
									break;
								}
								object obj117 = (object)elbowWas + obj3;
								obj117 = num7;
								if (elbow != null)
								{
									bool flag50 = (nint)obj4 < array26.Length;
									object obj118 = !flag50;
									if (obj118 != null)
									{
										break;
									}
									object obj119 = (object)elbow + obj3;
									obj119 = num7;
									Vector3[] array28 = wristWas;
									if (wristWas != null)
									{
										bool flag51 = (nint)obj4 < array28.Length;
										object obj120 = !flag51;
										if (obj120 != null)
										{
											break;
										}
										object obj121 = (object)wristWas + obj3;
										Vector3[] array29 = wrist;
										obj121 = num7;
										if (wrist != null)
										{
											bool flag52 = (nint)obj4 < array29.Length;
											object obj122 = !flag52;
											if (obj122 != null)
											{
												break;
											}
											object obj123 = (object)wrist + obj3;
											obj123 = num7;
											float num110 = num99;
											num23 = num101;
											num37 = num12;
											goto IL_1c56;
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_19f8;
			IL_19f8:
			NullReferenceException ex = new NullReferenceException();
			break;
		}
		throw new IndexOutOfRangeException();
	}

	private static void Aim(Transform bone, Vector3 tipNow, Vector3 tipWanted, float much)
	{
		//IL_009f: Invalid comparison between F4 and I
		//IL_0133: Invalid comparison between F4 and I
		//IL_015a: Expected VT, but got I4
		Vector3 position = bone.position;
		float num = much - much;
		object obj2 = default;
		object obj = obj2 - obj2;
		object obj4 = default;
		object obj3 = obj4 - obj4;
		Vector3 position2 = bone.position;
		float num2 = num * num;
		object obj5 = obj * obj;
		float num3 = num2 + (float)obj5;
		object obj6 = obj3 * obj3;
		float num4 = (float)obj6 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if (!(num4 < 0f))
		{
			object obj7 = default;
			float num5 = (float)obj7 - much;
			object obj9 = default;
			object obj8 = obj9 - obj2;
			object obj11 = default;
			object obj10 = obj11 - obj4;
			float num6 = num5 * num5;
			object obj12 = obj8 * obj8;
			float num7 = num6 + (float)obj12;
			object obj13 = obj10 * obj10;
			float num8 = (float)obj13 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			if (!(num8 < 0f))
			{
				Vector3 fromDirection = default;
				Vector3 toDirection = default;
				Quaternion quaternion = Quaternion.Internal_FromToRotation(ref fromDirection, ref toDirection);
				Quaternion a = default;
				Quaternion b = default;
				float t = default;
				Quaternion quaternion2 = Quaternion.Internal_Slerp(ref a, ref b, t);
				Quaternion rotation = bone.rotation;
				bone.rotation = (Quaternion)0;
			}
		}
	}

	private void Flail(Vector3 ahead, Vector3 across, float env)
	{
		//IL_134e: Expected Obj, but got I4
		//IL_136e: Expected F4, but got VT
		//IL_1393: Expected Obj, but got I
		//IL_13a3: Expected F4, but got I
		//IL_0080: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I
		//IL_0ac7: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0af4: Expected Obj, but got I
		//IL_0b13: Expected F4, but got VT
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Expected Obj, but got Unknown
		//IL_0eef: Expected VT, but got F4
		//IL_0172: Expected Obj, but got I4
		//IL_0b51: Expected F4, but got VT
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0f2d: Expected Obj, but got I4
		//IL_0cd5: Expected Obj, but got I
		//IL_0f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f40: Expected Obj, but got Unknown
		//IL_0f5b: Expected Obj, but got I4
		//IL_03fb: Expected Obj, but got I
		//IL_0e1a: Expected Obj, but got VT
		//IL_0e99: Expected VT, but got I4
		//IL_0e99: Expected Obj, but got I
		//IL_0eb2: Expected VT, but got I4
		//IL_0ec2: Expected Obj, but got I
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected Obj, but got Unknown
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Expected Obj, but got Unknown
		//IL_071a: Expected VT, but got I4
		//IL_071a: Expected Obj, but got I
		//IL_10cd: Expected Obj, but got I4
		//IL_0879: Expected Obj, but got I
		//IL_09be: Expected Obj, but got F4
		//IL_0a3d: Expected VT, but got I4
		//IL_0a3d: Expected Obj, but got I
		//IL_0a45: Expected VT, but got F4
		//IL_0a56: Expected VT, but got I4
		//IL_0a66: Expected Obj, but got I
		//IL_0a7e: Expected Obj, but got I
		//IL_1111: Expected Obj, but got I
		//IL_1255: Expected Obj, but got VT
		//IL_12d4: Expected VT, but got I4
		//IL_12d4: Expected Obj, but got I
		//IL_12dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e2: Expected Obj, but got Unknown
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f0: Expected Obj, but got Unknown
		//IL_1311: Expected VT, but got I4
		//IL_1321: Expected Obj, but got I
		MonsterGore monsterGore = gore;
		if ((object)gore != null)
		{
			float num2 = default;
			float num = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
			float num3 = num * 0f;
			if (monsterGore.legs)
			{
				num3 = num2;
			}
			object obj = 0;
			float num4 = num2;
			float num6 = default;
			float num5 = num6;
			float num8 = default;
			float num7 = num8;
			Vector3 vector = default;
			float num9 = (float)vector;
			float num11 = default;
			float num10 = num11;
			MonsterWounds monsterWounds = this;
			float num12 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A89C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF58]");
			float num13 = 0f;
			Vector3 axis = default;
			Vector3 vector3 = default;
			Vector3 vector2 = default;
			while (true)
			{
				Chain[] array = arms;
				if (arms == null)
				{
					break;
				}
				bool flag = (nint)obj < array.Length;
				object obj3 = !flag;
				if (obj3 == null)
				{
					object obj4 = (object)arms + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v8+20]");
					object obj5 = 0;
					object obj6 = obj * obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v8+20]");
					bool flag2 = (nint)0 == 0;
					Quaternion quaternion = (Quaternion)vector2;
					Transform transform = (Transform)(object)monsterWounds;
					if (!flag2)
					{
						bool[] array2 = hangs;
						if (hangs == null)
						{
							break;
						}
						bool flag3 = (nint)obj < array2.Length;
						object obj7 = !flag3;
						if (obj7 != null)
						{
							goto IL_133e;
						}
						object obj8 = (object)hangs + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v22+20]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						quaternion = (Quaternion)vector2;
						transform = (Transform)(object)monsterWounds;
						if (obj9 == null)
						{
							float num14 = clock;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF58]");
							float num15 = num14 * 0f;
							float num16 = (float)obj6 + num15;
							float num17 = seed + num16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
							float num18 = clock;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFA0]");
							float num19 = num18 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
							object obj10 = obj6 * 0;
							float num20 = (float)obj10 + num19;
							float num21 = seed + num20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
							float num22 = num17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
							float num23 = num22 * 0f;
							float num24 = num21;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
							float num25 = num24 * 0f;
							float num26 = num23 + num25;
							float num27 = num26 * 1.1133256E+09f;
							float num28 = num3 * num27;
							Quaternion quaternion2 = Quaternion.Internal_AngleAxis(num28, ref axis);
							double num29 = (double)obj6 + 1.0;
							float num30 = clock;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF24]");
							float num31 = num30 * 0f;
							double num32 = num29 + (double)num31;
							double num33 = (double)seed + num32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
							float num34 = clock;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB40]");
							float num35 = num34 * 0f;
							double num36 = num29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
							double num37 = num36 * 0.0;
							double num38 = num37 + (double)num35;
							double num39 = (double)seed + num38;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
							double num40 = num33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
							double num41 = num40 * 0.0;
							double num42 = num39;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
							double num43 = num42 * 0.0;
							double num44 = num41 + num43;
							double num45 = num44 * 66.0;
							float num46 = num3 * (float)num45;
							Quaternion quaternion3 = Quaternion.Internal_AngleAxis(num46, ref axis);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+10]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+10]");
							Quaternion rotation = ((Transform)0).rotation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+10]");
							if ((nint)0 == 0)
							{
								break;
							}
							float num47 = num8 * num8;
							float num48 = num28 * num46;
							float num49 = num8 * num46;
							float num50 = num28 * num8;
							float num51 = num8 * env;
							float num52 = (float)vector * num8;
							float num53 = num8 * num11;
							float num54 = num6 * num8;
							float num55 = num47 - num48;
							float num56 = num6 * num11;
							float num57 = (float)vector * num11;
							float num58 = num49 + num50;
							float num59 = num6 * env;
							float num60 = (float)vector * env;
							float num61 = num51 + num52;
							float num62 = num28 * num11;
							float num63 = num53 + num54;
							float num64 = (float)vector * num46;
							float num65 = num55 - num56;
							float num66 = num59 + num58;
							float num67 = num6 * num46;
							float num68 = num62 + num61;
							float num69 = num28 * env;
							float num70 = num64 + num63;
							float num71 = num65 - num60;
							float num72 = num66 - num57;
							float num73 = num68 - num67;
							float num74 = num70 - num69;
							float num75 = num71 * num8;
							float num76 = num71 * env;
							float num77 = num72 * num46;
							float num78 = num71 * num11;
							float num79 = num73 * num8;
							float num80 = num74 * num8;
							float num81 = num74 * num11;
							float num82 = num72 * num11;
							float num83 = num73 * num46;
							float num84 = num75 - num77;
							float num85 = num76 + num79;
							float num86 = num74 * num46;
							float num87 = num72 * env;
							float num88 = num78 + num80;
							float num89 = num73 * env;
							float num90 = num73 * num11;
							float num91 = num84 - num81;
							float num92 = num82 + num85;
							float num93 = num83 + num88;
							float num94 = num91 - num89;
							float num95 = num92 - num86;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+10]");
							((Transform)0).rotation = (Quaternion)0;
							float num96 = clock;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A988]");
							float num97 = num96 * 0f;
							double num98 = (double)obj6 + 2.0;
							double num99 = num98 + (double)num97;
							double num100 = (double)seed + num99;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
							float num101 = clock;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADE4]");
							float num102 = num101 * 0f;
							double num103 = num98;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
							double num104 = num103 * 0.0;
							double num105 = num104 + (double)num102;
							double num106 = (double)seed + num105;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
							double num107 = num100;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
							double num108 = num107 * 0.0;
							double num109 = num106;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
							double num110 = num109 * 0.0;
							double num111 = num108 + num110;
							double num112 = num111 * 1109393408.0;
							float num113 = num3 * (float)num112;
							Quaternion quaternion4 = Quaternion.Internal_AngleAxis(num113, ref axis);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+18]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+18]");
							Quaternion rotation2 = ((Transform)0).rotation;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+18]");
							if ((nint)0 == 0)
							{
								break;
							}
							float num114 = num94 * num94;
							float num115 = num113 * num113;
							float num116 = num94 * num8;
							float num117 = num8 * num94;
							float num118 = num94 * num6;
							float num119 = num6 * num94;
							float num120 = num94 * num113;
							float num121 = num113 * num94;
							float num122 = num114 - num115;
							float num123 = num6 * num6;
							float num124 = num113 * num8;
							float num125 = num116 + num117;
							float num126 = num113 * num6;
							float num127 = num118 + num119;
							float num128 = num8 * num113;
							float num129 = num6 * num113;
							float num130 = num120 + num121;
							float num131 = num6 * num8;
							object obj11 = num8 * num8;
							float num132 = num122 - num123;
							num7 = num126 + num125;
							num5 = num128 + num127;
							num4 = num131 + num130;
							num9 = num132 - (float)obj11;
							num10 = num7 - num129;
							num13 = num5 - num124;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+18]");
							((Transform)0).rotation = (Quaternion)0;
							vector3 = (Vector3)num8;
							axis = vector;
							quaternion = (Quaternion)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v4+18]");
							transform = (Transform)0;
							num12 = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A89C]");
							obj2 = 0;
						}
					}
					Chain[] array3 = legs;
					if (legs == null)
					{
						break;
					}
					bool flag5 = (nint)obj < array3.Length;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						object obj13 = (object)legs + obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v11+20]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v11+20]");
						bool flag6 = (nint)0 == 0;
						float num133 = (float)vector3;
						float num134 = num9;
						vector2 = (Vector3)quaternion;
						monsterWounds = (MonsterWounds)(object)transform;
						if (!flag6)
						{
							bool flag7 = (nint)obj == trappedSide;
							num133 = (float)vector3;
							num134 = num9;
							vector2 = (Vector3)quaternion;
							monsterWounds = (MonsterWounds)(object)transform;
							if (!flag7)
							{
								double num135 = (double)obj6 + 3.0;
								float num136 = clock;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A814]");
								float num137 = num136 * 0f;
								double num138 = num135 + (double)num137;
								double num139 = (double)seed + num138;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
								float num140 = clock;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8A4]");
								float num141 = num140 * 0f;
								double num142 = num135;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
								double num143 = num142 * 0.0;
								double num144 = num143 + (double)num141;
								double num145 = (double)seed + num144;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
								double num146 = num139;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								double num147 = num146 * 0.0;
								double num148 = num145;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
								double num149 = num148 * 0.0;
								double num150 = num147 + num149;
								double num151 = num150 * 30.0;
								float num152 = (float)num151 * num12;
								Quaternion quaternion5 = Quaternion.Internal_AngleAxis(num152, ref axis);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X26_v5+10]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X26_v5+10]");
								Quaternion rotation3 = ((Transform)0).rotation;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X26_v5+10]");
								if ((nint)0 == 0)
								{
									break;
								}
								float num153 = num9 * num9;
								float num154 = num152 * num152;
								float num155 = num9 * (float)vector;
								float num156 = (float)vector * num9;
								float num157 = num9 * num6;
								float num158 = num6 * num9;
								float num159 = num9 * num152;
								float num160 = num152 * num9;
								float num161 = num153 - num154;
								float num162 = num6 * num6;
								float num124 = num152 * (float)vector;
								float num163 = num155 + num156;
								float num126 = num152 * num6;
								float num127 = num157 + num158;
								float num128 = (float)vector * num152;
								float num164 = num6 * num152;
								float num165 = num159 + num160;
								float num131 = num6 * (float)vector;
								object obj15 = vector * vector;
								float num166 = num161 - num162;
								num7 = num126 + num163;
								num5 = num128 + num127;
								num4 = num131 + num165;
								num134 = num166 - (float)obj15;
								num10 = num7 - num164;
								num13 = num5 - num124;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X26_v5+10]");
								((Transform)0).rotation = (Quaternion)0;
								num133 = num8;
								axis = vector;
								vector2 = (Vector3)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X26_v5+10]");
								monsterWounds = (MonsterWounds)0;
							}
						}
						obj++;
						bool flag8 = (nint)obj != 2;
						vector3 = (Vector3)num133;
						num9 = num134;
						if (flag8)
						{
							continue;
						}
						if (spiderCount < 1)
						{
							return;
						}
						object obj16 = 4;
						while (true)
						{
							Transform[] array4 = spiderLegs;
							if (spiderLegs == null)
							{
								break;
							}
							object obj17 = obj16 - 4;
							bool flag9 = (nint)obj17 < array4.Length;
							object obj18 = !flag9;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
								object obj19 = obj17 * 0;
								double num167 = (double)clock * 11.0;
								double num168 = (double)obj19 + num167;
								double num169 = (double)seed + num168;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
								double num170 = (double)clock * 16.0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA3C]");
								object obj20 = obj19 * 0;
								double num171 = (double)obj20 + num170;
								double num172 = (double)seed + num171;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D050");
								double num173 = num169;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
								double num174 = num173 * 0.0;
								double num175 = num172;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF3C]");
								double num176 = num175 * 0.0;
								double num177 = num174 + num176;
								double num178 = num177 * 16.0;
								float num179 = (float)num178 * num12;
								Quaternion quaternion6 = Quaternion.Internal_AngleAxis(num179, ref axis);
								Transform[] array5 = spiderLegs;
								if (spiderLegs == null)
								{
									break;
								}
								bool flag10 = (nint)obj17 < array5.Length;
								object obj21 = !flag10;
								if (obj21 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v18 (UnityEngine.Transform[])+v126 @ X21_v9*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v18 (UnityEngine.Transform[])+v126 @ X21_v9*8]");
									Quaternion rotation4 = ((Transform)0).rotation;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v17 (UnityEngine.Transform[])+v126 @ X21_v9*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									float num180 = num134 * num134;
									float num181 = num179 * num179;
									float num182 = num134 * (float)vector;
									float num183 = (float)vector * num134;
									float num184 = num134 * num6;
									float num185 = num6 * num134;
									float num186 = num134 * num179;
									float num187 = num179 * num134;
									float num188 = num180 - num181;
									float num189 = num6 * num6;
									float num190 = num179 * (float)vector;
									float num191 = num182 + num183;
									float num126 = num179 * num6;
									float num192 = num184 + num185;
									float num193 = (float)vector * num179;
									float num194 = num6 * num179;
									float num195 = num186 + num187;
									float num196 = num6 * (float)vector;
									object obj22 = vector * vector;
									float num197 = num188 - num189;
									num7 = num126 + num191;
									num5 = num193 + num192;
									num4 = num196 + num195;
									num134 = num197 - (float)obj22;
									num10 = num7 - num194;
									num13 = num5 - num190;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v17 (UnityEngine.Transform[])+v126 @ X21_v9*8]");
									((Transform)0).rotation = (Quaternion)0;
									obj16++;
									object obj23 = obj16 - 4;
									bool flag11 = (nint)obj23 < spiderCount;
									axis = vector;
									vector2 = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v17 (UnityEngine.Transform[])+v126 @ X21_v9*8]");
									monsterWounds = (MonsterWounds)0;
									if (!flag11)
									{
										return;
									}
									continue;
								}
							}
							goto IL_133e;
						}
						break;
					}
				}
				goto IL_133e;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_133e;
		IL_133e:
		throw new IndexOutOfRangeException();
	}

	private static void Solve(Chain c, Vector3 target, float much)
	{
		//IL_0049: Invalid comparison between F8 and I4
		//IL_0058: Expected F8, but got I4
		//IL_0d11: Expected Obj, but got I
		//IL_0d9b: Expected Obj, but got I4
		//IL_0179: Invalid comparison between F4 and I
		//IL_0896: Expected Obj, but got I4
		//IL_09ad: Invalid comparison between F4 and I
		//IL_0e57: Expected Obj, but got I4
		//IL_0343: Invalid comparison between F4 and I
		//IL_0352: Expected F8, but got I4
		//IL_09e4: Expected Obj, but got I
		//IL_09fc: Expected Obj, but got I
		//IL_0a0c: Expected F4, but got I
		//IL_0b1e: Invalid comparison between F4 and I
		//IL_0cba: Expected Obj, but got I4
		//IL_0dd8: Expected Obj, but got I4
		//IL_04d7: Invalid comparison between F4 and I
		//IL_0530: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0550: Expected F4, but got Obj
		//IL_0560: Expected F4, but got I
		//IL_0570: Expected F4, but got I
		//IL_06da: Expected VT, but got I4
		//IL_0779: Invalid comparison between F4 and I
		//IL_07a0: Invalid comparison between F8 and I
		//IL_07f7: Expected VT, but got I4
		Vector3 position = c.upper.position;
		Vector3 position2 = c.lower.position;
		Vector3 position3 = c.end.position;
		double num = default;
		bool flag = num < 0.0;
		double num2 = 0.0;
		if (!flag)
		{
			bool flag2 = !(num > 1.0);
			num2 = num;
			if (!flag2)
			{
				num2 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		object obj4 = default;
		object obj3 = obj4 - obj4;
		float num3 = much - much;
		object obj6 = default;
		object obj5 = obj6 - obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v10+E4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num4 = num3 * num3;
		object obj7 = obj3 * obj3;
		float num5 = num4 + (float)obj7;
		object obj8 = obj5 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if ((nint)obj5 < 0)
		{
			return;
		}
		object obj11 = obj6 - obj6;
		float num6 = much - much;
		float num7 = (float)obj4 - (float)obj4;
		float num8 = num6 * num6;
		float num9 = num7 * num7;
		float num10 = num8 + num9;
		object obj12 = obj11 * obj11;
		float num11 = (float)obj12 + num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		if (num10 < 0f)
		{
			return;
		}
		float num12 = much - much;
		object obj13 = obj4 - obj4;
		object obj14 = obj6 - obj6;
		float num13 = num12 * (float)num2;
		double num14 = (double)obj13 * num2;
		double num15 = (double)obj14 * num2;
		float num16 = much + num13;
		double num17 = (double)obj4 + num14;
		double num18 = (double)obj6 + num15;
		object obj15 = obj;
		float num19 = num16 - much;
		double num20 = num17 - (double)obj4;
		double num21 = num18 - (double)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num22 = num19 * num19;
		double num23 = num20 * num20;
		float num24 = num22 + (float)num23;
		double num25 = num21 * num21;
		double num26 = num25 + (double)num24;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		float num27 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		float num28 = num27 + 0f;
		if (!(num26 < (double)num28))
		{
			float num29 = (float)obj5 + num10;
			float num30 = num29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A978]");
			float num31 = num30 + 0f;
			bool flag5 = !(num26 > (double)num31);
			num28 = (float)num26;
			if (!flag5)
			{
				num28 = num31;
			}
		}
		object obj17 = obj4 - obj4;
		object obj18 = obj6 - obj6;
		float num32 = much - much;
		object obj19 = obj17 * obj11;
		float num33 = (float)obj18 * num7;
		float num34 = (float)obj18 * num6;
		float num35 = num32 * (float)obj11;
		float num36 = (float)obj19 - num33;
		float num37 = num32 * num7;
		float num38 = (float)obj17 * num6;
		float num39 = num34 - num35;
		float num40 = num37 - num38;
		float num41 = num36 * num36;
		float num42 = num39 * num39;
		float num43 = num41 + num42;
		float num44 = num40 * num40;
		float num45 = num44 + num43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
		bool flag6 = !(num45 < 0f);
		float num46 = num7;
		float num47 = num6;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v38+A0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+48]");
			num34 = 0f;
			float num48 = (float)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+48]");
			num46 = num48 * 0f;
			float num49 = (float)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+50]");
			num35 = num49 * 0f;
			float num50 = (float)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+4C]");
			num47 = num50 * 0f;
			float num51 = num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+50]");
			float num52 = num51 * 0f;
			float num53 = num32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+4C]");
			float num54 = num53 * 0f;
			num36 = num35 - num47;
			num39 = num46 - num52;
			float num55 = (float)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+48]");
			float num56 = num55 * 0f;
			num40 = num54 - num56;
			float num57 = num36 * num36;
			float num58 = num39 * num39;
			float num59 = num57 + num58;
			float num60 = num40 * num40;
			float num61 = num60 + num59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			if (!(num61 > 0f))
			{
				float num62 = (float)obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+3C]");
				num46 = num62 * 0f;
				float num63 = (float)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+3C]");
				num34 = num63 * 0f;
				float num64 = (float)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+44]");
				num35 = num64 * 0f;
				float num65 = (float)obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+40]");
				num47 = num65 * 0f;
				float num66 = num32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+44]");
				float num67 = num66 * 0f;
				float num68 = num32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v40+40]");
				float num69 = num68 * 0f;
				num36 = num35 - num47;
				num39 = num46 - num67;
				num40 = num69 - num34;
			}
		}
		float num70 = num32 * num32;
		object obj23 = obj17 * obj17;
		object obj24 = obj;
		float num71 = num70 + (float)obj23;
		object obj25 = obj18 * obj18;
		float num72 = (float)obj25 + num71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X0_v23+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F4]");
		bool flag8 = num72 < 0f;
		double num73 = 0.0;
		if (!flag8)
		{
			float num74 = num32 * num6;
			float num75 = (float)obj17 * num7;
			float num76 = num74 + num75;
			object obj27 = obj18 * obj11;
			float num77 = (float)obj27 + num76;
			float num78 = num77 / num72;
			bool flag9 = (double)num78 < -1.0;
			double num79 = -1.0;
			if (!flag9)
			{
				bool flag10 = !((double)num78 > 1.0);
				num79 = num78;
				if (!flag10)
				{
					num79 = 1.0;
				}
			}
			object obj28 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ X0_v49+E4]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D000");
			double num80 = num79;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
			num73 = num80 * 0.0;
		}
		object obj30 = obj5 * obj5;
		object obj31 = obj5 + obj5;
		float num81 = num10 * num10;
		float num82 = (float)obj30 + num81;
		float num83 = num28 * num28;
		float num84 = num82 - num83;
		float num85 = (float)obj31 * num10;
		float num86 = num84 / num85;
		bool flag12 = (double)num86 < -1.0;
		double num87 = -1.0;
		if (!flag12)
		{
			bool flag13 = !((double)num86 > 1.0);
			num87 = num86;
			if (!flag13)
			{
				num87 = 1.0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610CFE0");
		object obj32 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X0_v27+E4]");
		bool flag14 = (nint)0 == 0;
		object obj33 = !flag14;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		double num88 = num87;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABE4]");
		double num89 = num88 * 0.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
		float num90;
		float num91;
		float num92;
		if (num10 > 0f)
		{
			num90 = num36 / num10;
			num91 = num39 / num10;
			num92 = num40 / num10;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ X8_v30+A0]");
			object obj36 = 0;
			num90 = (float)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v31+4]");
			num91 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v31+8]");
			num92 = 0f;
		}
		float num93 = (float)num89 - (float)num73;
		Vector3 axis = default;
		Quaternion quaternion = Quaternion.Internal_AngleAxis(num93, ref axis);
		Quaternion rotation = c.lower.rotation;
		float num94 = num92 * num91;
		float num95 = num91 * num92;
		float num96 = num92 * num90;
		float num97 = num90 * num92;
		float num98 = num92 * num93;
		float num99 = num93 * num92;
		float num100 = num93 * num91;
		float num101 = num94 + num95;
		float num102 = num93 * num90;
		float num103 = num91 * num90;
		float num104 = num96 + num97;
		float num105 = num91 * num93;
		float num106 = num90 * num93;
		float num107 = num98 + num99;
		float num108 = num90 * num91;
		float num109 = num102 + num101;
		float num110 = num105 + num104;
		float num111 = num108 + num107;
		float num112 = num109 - num106;
		float num113 = num110 - num100;
		float num114 = num111 - num103;
		c.lower.rotation = (Quaternion)0;
		Vector3 position4 = c.end.position;
		float num115 = num113 - (float)obj4;
		float num116 = num114 - much;
		float num117 = num112 - (float)obj6;
		float num118 = num115 * num115;
		float num119 = num116 * num116;
		float num120 = num119 + num118;
		float num121 = num117 * num117;
		float num122 = num121 + num120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
		if (num122 > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A7F0]");
			if (num26 > 0.0)
			{
				Vector3 toDirection = default;
				Quaternion quaternion2 = Quaternion.Internal_FromToRotation(ref axis, ref toDirection);
				Quaternion rotation2 = c.upper.rotation;
				c.upper.rotation = (Quaternion)0;
			}
		}
	}

	public static void WarmUp(Transform under)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_13e6: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_0f52: Expected Obj, but got I
		//IL_0f6c: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I
		//IL_1006: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_1035: Expected Obj, but got I4
		//IL_1415: Expected Obj, but got I4
		//IL_1064: Expected Obj, but got I
		//IL_1081: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I4
		//IL_10b5: Expected Obj, but got I4
		//IL_021f: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I
		//IL_1437: Expected Obj, but got I8
		//IL_1458: Expected Obj, but got I4
		//IL_116e: Expected Obj, but got I4
		//IL_10fb: Expected I, but got Obj
		//IL_110b: Expected Obj, but got I
		//IL_112d: Expected Obj, but got I4
		//IL_1146: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected Obj, but got Unknown
		//IL_1482: Expected Obj, but got I4
		//IL_1492: Expected Obj, but got I4
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b7: Expected Obj, but got Unknown
		//IL_14c9: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I
		//IL_02e5: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I
		//IL_120a: Expected Obj, but got I
		//IL_122f: Expected Obj, but got I4
		//IL_14f8: Expected Obj, but got I4
		//IL_1273: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		//IL_12b1: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_0387: Expected Obj, but got I
		//IL_12e0: Expected Obj, but got I4
		//IL_151a: Expected Obj, but got I8
		//IL_153b: Expected Obj, but got I4
		//IL_130f: Expected Obj, but got I
		//IL_132c: Expected Obj, but got I
		//IL_03b1: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_135b: Expected Obj, but got I4
		//IL_1565: Expected Obj, but got I4
		//IL_1575: Expected Obj, but got I4
		//IL_1595: Unknown result type (might be due to invalid IL or missing references)
		//IL_159a: Expected Obj, but got Unknown
		//IL_15ac: Expected Obj, but got I4
		//IL_03eb: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I4
		//IL_0474: Expected Obj, but got I
		//IL_15db: Expected Obj, but got I4
		//IL_04ab: Expected Obj, but got I4
		//IL_04d5: Expected Obj, but got I8
		//IL_04f4: Expected Obj, but got I
		//IL_0504: Expected Obj, but got I
		//IL_0514: Expected Obj, but got I
		//IL_0540: Expected Obj, but got I4
		//IL_0572: Expected Obj, but got I4
		//IL_0582: Expected Obj, but got I4
		//IL_05a1: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected Obj, but got Unknown
		//IL_0603: Expected Obj, but got I4
		//IL_0629: Expected Obj, but got I
		//IL_0639: Expected Obj, but got I
		//IL_0649: Expected Obj, but got I
		//IL_0684: Expected Obj, but got I4
		//IL_06b7: Expected Obj, but got I
		//IL_06c7: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I4
		//IL_0756: Expected Obj, but got I
		//IL_079e: Expected Obj, but got I4
		//IL_07ae: Expected Obj, but got I4
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_085f: Expected Obj, but got I
		//IL_08b7: Expected Obj, but got I
		//IL_08cf: Expected Obj, but got I4
		//IL_08d7: Expected I4, but got Obj
		//IL_0914: Expected Obj, but got I
		//IL_0924: Expected Obj, but got I
		//IL_0943: Expected Obj, but got I
		//IL_094b: Expected I4, but got Obj
		//IL_0970: Expected Obj, but got I4
		//IL_09b0: Expected Obj, but got I
		//IL_09c7: Expected I4, but got Obj
		//IL_09ec: Expected Obj, but got I4
		//IL_0a2c: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I
		//IL_0a63: Expected Obj, but got I4
		//IL_0a6b: Expected I4, but got Obj
		//IL_0a74: Expected Obj, but got I4
		//IL_0a9c: Expected Obj, but got I4
		//IL_0aa4: Expected I4, but got Obj
		//IL_0af2: Expected Obj, but got I4
		//IL_0afa: Expected I4, but got Obj
		//IL_0b2c: Expected Obj, but got I4
		//IL_0b3c: Expected Obj, but got I4
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0b88: Expected Obj, but got I4
		//IL_0b90: Expected I4, but got Obj
		//IL_0bdc: Expected Obj, but got I4
		//IL_0be4: Expected I4, but got Obj
		//IL_0c1f: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I
		//IL_1601: Expected Obj, but got I4
		//IL_1613: Expected Obj, but got I4
		//IL_0c5d: Expected Obj, but got I4
		//IL_0c6f: Expected Obj, but got I4
		//IL_0c8d: Expected Obj, but got I
		//IL_0ca5: Expected Obj, but got I
		//IL_0cb5: Expected Obj, but got I
		//IL_0cc5: Expected Obj, but got I
		//IL_0d11: Expected Obj, but got I4
		//IL_0d23: Expected Obj, but got I4
		//IL_0d56: Expected Obj, but got I
		//IL_0d66: Expected Obj, but got I
		//IL_0d8d: Expected Obj, but got I4
		//IL_0d9f: Expected Obj, but got I4
		//IL_0dc9: Expected Obj, but got I4
		//IL_0dd9: Expected Obj, but got I4
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got Unknown
		//IL_0e07: Expected Obj, but got I4
		//IL_0e53: Expected Obj, but got I4
		//IL_0e9d: Expected Obj, but got I4
		//IL_0ee6: Expected Obj, but got I
		//IL_0efe: Expected Obj, but got I4
		//IL_0f2f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CB0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj6 = default;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC18]");
		object obj7 = 0;
		object obj8 = obj3;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v4+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)obj10 == null;
		bool flag4 = !flag3;
		int num = 0;
		UnityEngine.Object obj12 = null;
		if (flag4)
		{
			goto IL_0f42;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E18]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Mesh mesh = default;
		mesh._002Ector();
		bool flag5 = (object)mesh == null;
		int num2 = 0;
		Vector4[] array = null;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC30]");
			object obj14 = 0;
			mesh.name = (string)obj14;
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v33+A0]");
			object obj16 = 0;
			obj16 = mesh;
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Vector3[] array2 = default;
			bool flag6 = array2 == null;
			num2 = 0;
			array = (Vector4[])3;
			if (!flag6)
			{
				bool flag7 = array2.Length == 0;
				num2 = 0;
				array = (Vector4[])3;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj19 = 0;
					object obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X9_v7+A0]");
					object obj21 = 0;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X9_v8+8]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X9_v8+8]");
					_ = 0;
					object obj24 = array2.Length & 0xFFFFFFFEL;
					bool flag8 = obj24 == null;
					num2 = 0;
					array = (Vector4[])3;
					if (!flag8)
					{
						object obj25 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X9_v10+A0]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X9_v11+18]");
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X9_v11+20]");
						obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X9_v11+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X9_v11+20]");
						_ = 0;
						bool flag9 = array2.Length < 2;
						object obj27 = !flag9;
						object obj28 = array2.Length - 2;
						bool flag10 = obj28 == null;
						object obj29 = ~obj27;
						object obj30 = obj29 | flag10;
						num2 = 0;
						array = (Vector4[])3;
						if (obj30 == null)
						{
							object obj31 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v41+A0]");
							object obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v42+3C]");
							obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v42+44]");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6748]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v42+3C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v42+44]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Vector2[] array3 = default;
							bool flag11 = array3 == null;
							num2 = 0;
							array = (Vector4[])3;
							if (flag11)
							{
								goto IL_1380;
							}
							bool flag12 = array3.Length == 0;
							num2 = 0;
							array = (Vector4[])3;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6AF8]");
								object obj34 = 0;
								object obj35 = obj34;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X9_v13+A0]");
								object obj36 = 0;
								obj22 = obj36;
								object obj37 = array3.Length & 0xFFFFFFFEL;
								bool flag13 = obj37 == null;
								num2 = 0;
								array = (Vector4[])3;
								if (!flag13)
								{
									object obj38 = obj34;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X9_v17+A0]");
									object obj39 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X9_v18+10]");
									obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X9_v18+10]");
									_ = 0;
									bool flag14 = array3.Length < 2;
									object obj40 = !flag14;
									object obj41 = array3.Length - 2;
									bool flag15 = obj41 == null;
									object obj42 = ~obj40;
									object obj43 = obj42 | flag15;
									num2 = 0;
									array = (Vector4[])3;
									if (obj43 == null)
									{
										object obj44 = obj34;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v50+A0]");
										object obj45 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v51+28]");
										obj22 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v51+28]");
										_ = 0;
										object obj46 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v52+A0]");
										object obj47 = 0;
										bool flag16 = obj47 == null;
										num2 = 0;
										array = (Vector4[])3;
										if (!flag16)
										{
											((Mesh)obj47).SetVertices(array2);
											object obj48 = obj7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v54+A0]");
											object obj49 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
											Vector3[] array4 = default;
											bool flag17 = array4 == null;
											num2 = 0;
											array = (Vector4[])3;
											if (!flag17)
											{
												bool flag18 = array4.Length == 0;
												num2 = 0;
												array = (Vector4[])3;
												if (!flag18)
												{
													object obj50 = obj19;
													object obj51 = array4.Length & 0xFFFFFFFEL;
													bool flag19 = obj51 == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X9_v21+A0]");
													object obj52 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v22+54]");
													obj22 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v22+5C]");
													obj23 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v22+54]");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X9_v22+5C]");
													_ = 0;
													num2 = 0;
													array = (Vector4[])3;
													if (!flag19)
													{
														object obj53 = obj19;
														bool flag20 = array4.Length < 2;
														object obj54 = !flag20;
														object obj55 = array4.Length - 2;
														bool flag21 = obj55 == null;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X9_v23+A0]");
														object obj56 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v24+54]");
														obj22 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v24+5C]");
														obj23 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v24+54]");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v24+5C]");
														_ = 0;
														object obj57 = ~obj54;
														object obj58 = obj57 | flag21;
														num2 = 0;
														array = (Vector4[])3;
														if (obj58 == null)
														{
															object obj59 = obj19;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v59+A0]");
															object obj60 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v60+54]");
															obj22 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v60+5C]");
															obj23 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v60+54]");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v60+5C]");
															_ = 0;
															bool flag22 = obj49 == null;
															num2 = 0;
															array = (Vector4[])3;
															if (!flag22)
															{
																((Mesh)obj49).SetNormals(array4);
																object obj61 = obj7;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v61+A0]");
																object obj62 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C87F8]");
																object obj63 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																Vector4[] array5 = default;
																bool flag23 = array5 == null;
																num2 = 0;
																array = (Vector4[])3;
																if (!flag23)
																{
																	bool flag24 = array5.Length == 0;
																	num2 = 0;
																	array = array5;
																	if (!flag24)
																	{
																		bool flag25 = array5.Length == 1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FBF0]");
																		obj22 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FBF0]");
																		_ = 0;
																		num2 = 0;
																		array = array5;
																		if (!flag25)
																		{
																			bool flag26 = array5.Length < 2;
																			object obj64 = !flag26;
																			object obj65 = array5.Length - 2;
																			bool flag27 = obj65 == null;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FBF0]");
																			_ = 0;
																			object obj66 = ~obj64;
																			object obj67 = obj66 | flag27;
																			num2 = 0;
																			array = array5;
																			if (obj67 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107FBF0]");
																				_ = 0;
																				bool flag28 = obj62 == null;
																				num2 = 0;
																				array = array5;
																				if (!flag28)
																				{
																					((Mesh)obj62).SetTangents(array5);
																					object obj68 = obj7;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v64+A0]");
																					object obj69 = 0;
																					bool flag29 = obj69 == null;
																					num2 = 0;
																					array = array5;
																					if (!flag29)
																					{
																						((Mesh)obj69).SetUVs(0, array3);
																						object obj70 = obj7;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v66+A0]");
																						object obj71 = 0;
																						bool flag30 = obj71 == null;
																						object obj72 = 0;
																						num2 = (int)array3;
																						array = null;
																						if (!flag30)
																						{
																							((Mesh)obj71).SetUVs(1, array3);
																							object obj73 = obj7;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v68+A0]");
																							object obj74 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
																							object obj75 = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6780]");
																							object obj76 = 0;
																							num2 = (int)obj76;
																							List<Vector3> list = default;
																							list._002Ector((IEnumerable<Vector3>)array2);
																							bool flag31 = obj74 == null;
																							obj72 = 0;
																							array = (Vector4[])(object)array2;
																							if (!flag31)
																							{
																								((Mesh)obj74).SetUVs(2, list);
																								object obj77 = obj7;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v70+A0]");
																								object obj78 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
																								num2 = (int)obj76;
																								List<Vector3> list2 = default;
																								list2._002Ector((IEnumerable<Vector3>)array2);
																								bool flag32 = obj78 == null;
																								obj72 = 0;
																								array = (Vector4[])(object)array2;
																								if (!flag32)
																								{
																									((Mesh)obj78).SetUVs(3, list2);
																									object obj79 = obj7;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v72+A0]");
																									object obj80 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C86F8]");
																									object obj81 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																									BoneWeight[] array6 = default;
																									bool flag33 = array6 == null;
																									obj72 = 0;
																									num2 = (int)list2;
																									array = (Vector4[])3;
																									if (!flag33)
																									{
																										bool flag34 = array6.Length == 0;
																										obj72 = 0;
																										num2 = (int)list2;
																										array = (Vector4[])(object)array6;
																										if (!flag34)
																										{
																											bool flag35 = array6.Length == 1;
																											_ = 0;
																											_ = 1065353216;
																											_ = 0;
																											_ = 0;
																											_ = 0;
																											obj72 = 0;
																											num2 = (int)list2;
																											array = (Vector4[])(object)array6;
																											if (!flag35)
																											{
																												bool flag36 = array6.Length < 2;
																												object obj82 = !flag36;
																												object obj83 = array6.Length - 2;
																												bool flag37 = obj83 == null;
																												_ = 1065353216;
																												_ = 0;
																												_ = 0;
																												_ = 0;
																												_ = 0;
																												object obj84 = ~obj82;
																												object obj85 = obj84 | flag37;
																												obj72 = 0;
																												num2 = (int)list2;
																												array = (Vector4[])(object)array6;
																												if (obj85 == null)
																												{
																													_ = 0;
																													_ = 1065353216;
																													_ = 0;
																													_ = 0;
																													_ = 0;
																													bool flag38 = obj80 == null;
																													obj72 = 0;
																													num2 = (int)list2;
																													array = (Vector4[])(object)array6;
																													if (!flag38)
																													{
																														((Mesh)obj80).boneWeights = array6;
																														object obj86 = obj7;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X8_v76+A0]");
																														object obj87 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7350]");
																														object obj88 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																														Matrix4x4[] array7 = default;
																														bool flag39 = array7 == null;
																														obj72 = 0;
																														num2 = 0;
																														array = (Vector4[])1;
																														if (!flag39)
																														{
																															bool flag40 = array7.Length == 0;
																															obj72 = 0;
																															num2 = 0;
																															array = (Vector4[])1;
																															if (flag40)
																															{
																																goto IL_138e;
																															}
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8758]");
																															object obj89 = 0;
																															object obj90 = obj89;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v82+A0]");
																															object obj91 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v83+60]");
																															obj23 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v83+70]");
																															obj22 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v83+60]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v83+70]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v83+40]");
																															_ = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v83+50]");
																															_ = 0;
																															bool flag41 = obj87 == null;
																															obj72 = 0;
																															num2 = 0;
																															array = (Vector4[])1;
																															if (!flag41)
																															{
																																((Mesh)obj87).bindposes = array7;
																																object obj92 = obj7;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v84+A0]");
																																object obj93 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
																																object obj94 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																																int[] array8 = default;
																																bool flag42 = array8 == null;
																																obj72 = 0;
																																num2 = 0;
																																array = (Vector4[])3;
																																if (!flag42)
																																{
																																	bool flag43 = array8.Length < 1;
																																	object obj95 = !flag43;
																																	object obj96 = array8.Length - 1;
																																	bool flag44 = obj96 == null;
																																	object obj97 = ~obj95;
																																	object obj98 = obj97 | flag44;
																																	obj72 = 0;
																																	num2 = 0;
																																	array = (Vector4[])(object)array8;
																																	if (obj98 == null)
																																	{
																																		bool flag45 = array8.Length == 2;
																																		array8[1] = 1;
																																		obj72 = 0;
																																		num2 = 0;
																																		array = (Vector4[])(object)array8;
																																		if (!flag45)
																																		{
																																			array8[2] = 2;
																																			bool flag46 = obj93 == null;
																																			obj72 = 0;
																																			num2 = 0;
																																			array = (Vector4[])(object)array8;
																																			if (!flag46)
																																			{
																																				((Mesh)obj93).SetTriangles(array8, 0);
																																				object obj99 = obj7;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v88+A0]");
																																				object obj100 = 0;
																																				bool flag47 = obj100 == null;
																																				obj72 = 0;
																																				num2 = 0;
																																				array = (Vector4[])(object)array8;
																																				if (!flag47)
																																				{
																																					((Mesh)obj100).RecalculateBounds();
																																					obj72 = 0;
																																					num = 0;
																																					obj12 = null;
																																					goto IL_0f42;
																																				}
																																			}
																																			goto IL_1380;
																																		}
																																	}
																																	goto IL_138e;
																																}
																															}
																														}
																													}
																													goto IL_1380;
																												}
																											}
																										}
																										goto IL_138e;
																									}
																								}
																							}
																						}
																					}
																				}
																				goto IL_1380;
																			}
																		}
																	}
																	goto IL_138e;
																}
															}
															goto IL_1380;
														}
													}
												}
												goto IL_138e;
											}
										}
										goto IL_1380;
									}
								}
							}
						}
					}
				}
				goto IL_138e;
			}
		}
		goto IL_1380;
		IL_138e:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_139c;
		IL_0f42:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC20]");
		object obj102 = 0;
		GameObject gameObject = default;
		gameObject._002Ector((string)obj102);
		bool flag48 = (object)gameObject == null;
		num2 = 0;
		array = (Vector4[])obj102;
		if (!flag48)
		{
			Transform transform = gameObject.transform;
			bool flag49 = (object)transform == null;
			num2 = 0;
			array = null;
			if (!flag49)
			{
				transform.SetParent(under, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4B90]");
				object obj103 = 0;
				array = (Vector4[])obj103;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				SkinnedMeshRenderer skinnedMeshRenderer = default;
				bool flag50 = (object)skinnedMeshRenderer == null;
				object obj72 = 0;
				num2 = 0;
				if (!flag50)
				{
					object obj104 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v14+A0]");
					object sharedMesh = 0;
					skinnedMeshRenderer.sharedMesh = (Mesh)sharedMesh;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
					object obj105 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
					Transform transform2 = gameObject.transform;
					Transform[] array9 = default;
					bool flag51 = array9 == null;
					obj72 = 0;
					num2 = 0;
					array = null;
					if (!flag51)
					{
						bool flag52 = (object)transform2 == null;
						Vector4[] array10 = null;
						if (!flag52)
						{
							nint num3 = (nint)array9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v28 (Il2CppClass<UnityEngine.Transform[]>)+40]");
							array10 = (Vector4[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag53 = ex == null;
							obj72 = 0;
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v28 (Il2CppClass<UnityEngine.Transform[]>)+40]");
							array = (Vector4[])0;
							if (flag53)
							{
								goto IL_139c;
							}
						}
						bool flag54 = array9.Length == 0;
						obj72 = 0;
						num2 = 0;
						array = array10;
						if (flag54)
						{
							goto IL_138e;
						}
						object obj106 = array9 + 32;
						obj106 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						skinnedMeshRenderer.bones = array9;
						Transform rootBone = gameObject.transform;
						skinnedMeshRenderer.rootBone = rootBone;
						skinnedMeshRenderer.sharedMaterial = (Material)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC28]");
						object obj107 = 0;
						GameObject gameObject2 = default;
						gameObject2._002Ector((string)obj107);
						bool flag55 = (object)gameObject2 == null;
						obj72 = 0;
						num2 = 0;
						array = (Vector4[])obj107;
						if (!flag55)
						{
							Transform transform3 = gameObject2.transform;
							bool flag56 = (object)transform3 == null;
							obj72 = 0;
							num2 = 0;
							array = null;
							if (!flag56)
							{
								transform3.SetParent(under, worldPositionStays: false);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF0]");
								object obj108 = 0;
								array = (Vector4[])obj108;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
								MeshFilter meshFilter = default;
								bool flag57 = (object)meshFilter == null;
								obj72 = 0;
								num2 = 0;
								if (!flag57)
								{
									object obj109 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v24+A0]");
									object sharedMesh2 = 0;
									meshFilter.sharedMesh = (Mesh)sharedMesh2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4DF8]");
									object obj110 = 0;
									array = (Vector4[])obj110;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
									Renderer renderer = default;
									bool flag58 = (object)renderer == null;
									obj72 = 0;
									num2 = 0;
									if (!flag58)
									{
										renderer.sharedMaterial = (Material)obj6;
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_1380;
		IL_1380:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_138e;
		IL_139c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
	}

	public MonsterWounds()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0417: Expected F4, but got I
		//IL_0429: Expected F4, but got I
		//IL_0463: Expected F4, but got I
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_0273: Expected Obj, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC48]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC58]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC68]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107E0A0]");
		tearReach = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4C0]");
		pieceShrink = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C5D8]");
		bleedPulses = 0;
		bleedSeconds = 4f;
		Pace__BackingField = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B4C8]");
		perUnit = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj7 = this + 152;
		obj7 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<(Vector4, bool)> list = default;
		list._002Ector();
		object obj8 = this + 160;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list2 = default;
		list2._002Ector();
		object obj9 = this + 168;
		obj9 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDC78]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list3 = default;
		list3._002Ector();
		object obj11 = this + 176;
		obj11 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C73E0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<float> list4 = default;
		list4._002Ector();
		object obj13 = this + 184;
		obj13 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj14 = this + 192;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5040]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj17 = this + 200;
		object obj18 = default;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj19 = this + 208;
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		brokeFirst = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Chain[] array = default;
		arms = array;
		object obj21 = this + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Chain[] array2 = default;
		legs = array2;
		object obj22 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Transform[] array3 = default;
		spiderLegs = array3;
		object obj24 = this + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		float[] array4 = default;
		hanging = array4;
		object obj26 = this + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array5 = default;
		elbow = array5;
		object obj27 = this + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array6 = default;
		elbowWas = array6;
		object obj28 = this + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array7 = default;
		wrist = array7;
		object obj29 = this + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Vector3[] array8 = default;
		wristWas = array8;
		object obj30 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		bool[] array9 = default;
		swinging = array9;
		object obj31 = this + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		float[] array10 = default;
		armClear = array10;
		object obj32 = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		lurch = 1f;
		base._002Ector();
	}

	private void _003CDied_003Eb__105_0()
	{
		//IL_0010: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I4
		//IL_00ec: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I4
		//IL_0401: Expected Obj, but got I
		//IL_0419: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I4
		//IL_03b7: Expected VT, but got I4
		//IL_03b7: Expected Obj, but got I
		//IL_01b4: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I4
		//IL_029d: Expected VT, but got I4
		//IL_029d: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Dismemberment dismemberment = Tearing();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (brain != null)
		{
			Vector3 middle = brain.Middle;
			object obj7 = 0;
		}
		else
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			object obj7 = 0;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = default;
		float num5 = default;
		float num8 = default;
		if (dismemberment != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v20+A0]");
			object obj12 = 0;
			Transform transform2 = base.transform;
			Vector3 forward = transform2.forward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D20]");
			object obj13 = 0;
			float num = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num3 = num * 0f;
			float num4 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num6 = num4 * 0f;
			float num7 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE24]");
			float num9 = num7 * 0f;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21+18]");
			float num10 = 0f + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21+1C]");
			float num11 = 0f + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21+20]");
			float num12 = 0f + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v34+E4]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Blood.Burst((Vector3)dismemberment.bloodMaterial, (Vector3)0, null, num2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EC0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4EB8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v11+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj21 = 0;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v24+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v20 (UnityEngine.Object)+70]");
			Sfx.Play((AudioClip[])0, (Vector3)0, num2, num5, num8);
		}
	}
}
