using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;

public static class GillaThreads
{
	private sealed class _003CWrap_003Ed__151 : _0021_00210, _00210, _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string body;

		public string _003C_003E3__body;

		public GillaTerms _003C_003E4__this;

		private int width;

		public int _003C_003E3__width;

		private StringBuilder _003Cline_003E5__2;

		private string[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private string _003Cword_003E5__5;

		private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CWrap_003Ed__151(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_019f: Expected I4, but got I8
			//IL_0026: Expected Obj, but got I
			//IL_0156: Expected I4, but got I8
			//IL_0050: Expected Obj, but got I4
			//IL_057f: Expected I4, but got Obj
			//IL_0077: Expected Obj, but got I
			//IL_0086: Expected I4, but got I8
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			//IL_00fb: Expected Obj, but got I
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_0130: Expected Obj, but got I4
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a1: Expected Obj, but got Unknown
			//IL_03bd: Expected Obj, but got I4
			//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ae: Expected Obj, but got Unknown
			//IL_0415: Expected Obj, but got I4
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected Obj, but got Unknown
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected Obj, but got Unknown
			//IL_01da: Expected Obj, but got I
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Expected Obj, but got Unknown
			//IL_02e6: Expected Obj, but got I4
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_052c: Expected Obj, but got Unknown
			object obj;
			bool result;
			int num;
			if (_003C_003E1__state != 2)
			{
				bool flag = _003C_003E1__state == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6F50]");
				obj = 0;
				if (!flag)
				{
					bool flag2 = _003C_003E1__state == 0;
					object obj2 = !flag2;
					result = false;
					if (obj2 != null)
					{
						goto IL_059e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
					object obj3 = 0;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					StringBuilder stringBuilder = default;
					stringBuilder._002Ector();
					object obj4 = this + 72;
					obj4 = stringBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X22_v4-20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X22_v4-20]");
						string[] array = ((string)0).Split(' ', (StringSplitOptions)0);
						object obj5 = this + 80;
						obj5 = array;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 0;
						object obj6 = 0;
						StringSplitOptions stringSplitOptions = (StringSplitOptions)0;
						num = 0;
						goto IL_05a3;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					if (_003Cline_003E5__2 != null)
					{
						StringBuilder stringBuilder2 = _003Cline_003E5__2.Clear();
						goto IL_02f4;
					}
				}
				goto IL_0563;
			}
			result = false;
			int num2 = -1;
			goto IL_05d3;
			IL_059e:
			return result;
			IL_05a3:
			object obj7 = this + 80;
			object obj8 = obj7;
			if (obj7 != null)
			{
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v4+18]");
				bool flag3 = (nint)num3 < (nint)0;
				object obj9 = !flag3;
				int num4 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v4+18]");
				if ((nint)num4 < (nint)0)
				{
					if (obj9 != null)
					{
						goto IL_0571;
					}
					object obj10 = obj7 + num;
					object obj11 = this + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v10+20]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj12 = obj11;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v11+10]");
						if ((nint)0 == 0)
						{
							goto IL_03d5;
						}
						if (_003Cline_003E5__2 != null)
						{
							int length = _003Cline_003E5__2.Length;
							if (length < 1)
							{
								goto IL_02f4;
							}
							bool flag4 = _003Cline_003E5__2 == null;
							string text = null;
							if (!flag4)
							{
								((SymmetricAlgorithm)(object)_003Cline_003E5__2).BlockSize = 0;
								string text2 = default;
								text = text2;
							}
							string s = text + (string)obj + (string)obj11;
							if ((object)_003C_003E4__this != null)
							{
								int num5 = _003C_003E4__this.Measure(s);
								bool flag5 = num5 > width;
								object obj6 = 0;
								if (!flag5)
								{
									goto IL_02f4;
								}
								if (_003Cline_003E5__2 != null)
								{
									((SymmetricAlgorithm)(object)_003Cline_003E5__2).BlockSize = 0;
									object obj13 = this + 24;
									object obj14 = default;
									obj13 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									result = true;
									num2 = 1;
									goto IL_05d3;
								}
							}
						}
					}
				}
				else
				{
					_003C_003E7__wrap2 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (_003Cline_003E5__2 != null)
					{
						int length2 = _003Cline_003E5__2.Length;
						if (length2 < 1)
						{
							result = false;
							goto IL_059e;
						}
						if (_003Cline_003E5__2 != null)
						{
							((SymmetricAlgorithm)(object)_003Cline_003E5__2).BlockSize = 0;
							object obj15 = this + 24;
							object obj16 = default;
							obj15 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							result = true;
							num2 = 2;
							goto IL_05d3;
						}
					}
				}
			}
			goto IL_0563;
			IL_03d5:
			num = ++_003C_003E7__wrap3;
			goto IL_05a3;
			IL_0571:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (byte)(int)ex != 0;
			IL_05d3:
			_003C_003E1__state = num2;
			goto IL_059e;
			IL_02f4:
			if (_003Cline_003E5__2 != null)
			{
				int length3 = _003Cline_003E5__2.Length;
				if (length3 >= 1)
				{
					if (_003Cline_003E5__2 == null)
					{
						goto IL_0563;
					}
					StringBuilder stringBuilder3 = _003Cline_003E5__2.Append(' ');
				}
				if (_003Cline_003E5__2 != null)
				{
					object value = this + 96;
					StringBuilder stringBuilder4 = _003Cline_003E5__2.Append((string)value);
					value = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					StringSplitOptions stringSplitOptions = (StringSplitOptions)0;
					goto IL_03d5;
				}
			}
			goto IL_0563;
			IL_0563:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0571;
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

		private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
		{
			//IL_00ed: Expected Obj, but got I4
			//IL_0107: Expected Obj, but got I4
			//IL_0054: Expected Obj, but got I
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected Obj, but got Unknown
			object obj = _003C_003E1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					obj3 = this;
					goto IL_00af;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C9300]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			object obj5 = default;
			obj5._002Ector();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			object obj6 = obj5 + 56;
			obj6 = _003C_003E4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj3 = obj5;
			goto IL_00af;
			IL_00af:
			object obj7 = obj3 + 40;
			obj7 = _003C_003E3__body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = _003C_003E3__width;
			return (IEnumerator<string>)obj3;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return (IEnumerator)System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator();
		}
	}

	public static readonly int Most;

	private static readonly GillaToys.Limited scheduler;

	private static readonly TaskFactory factory;

	public static TaskScheduler Scheduler
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			return (TaskScheduler)0;
		}
	}

	public static int Running
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I4
			//IL_0099: Expected Obj, but got I
			//IL_00a9: Expected Obj, but got I
			//IL_0051: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
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
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5+28]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public unsafe static int Waiting
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_02fa: Expected Obj, but got I4
			//IL_03e6: Expected Obj, but got I
			//IL_03f6: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			//IL_006b: Expected Obj, but got I4
			//IL_0318: Expected Obj, but got I
			//IL_0328: Expected Obj, but got I
			//IL_0348: Expected Obj, but got I4
			//IL_0350: Expected Obj, but got Ref
			//IL_0359: Expected Obj, but got I4
			//IL_0366: Expected Obj, but got Ref
			//IL_036e: Expected Obj, but got Ref
			//IL_037e: Expected Obj, but got I
			//IL_00a0: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I4
			//IL_00c8: Expected Obj, but got Ref
			//IL_00d1: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got Ref
			//IL_00e6: Expected Obj, but got Ref
			//IL_00f6: Expected Obj, but got I
			//IL_0127: Expected Obj, but got I4
			//IL_012f: Expected Obj, but got Ref
			//IL_0138: Expected Obj, but got I4
			//IL_0145: Expected Obj, but got Ref
			//IL_014d: Expected Obj, but got Ref
			//IL_015d: Expected Obj, but got I
			//IL_0277: Expected Obj, but got I4
			//IL_019d: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got I4
			//IL_01c5: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+8]");
			bool lockTaken = default;
			object obj11 = default;
			object obj12 = default;
			OutOfMemoryException ex = default;
			object obj13 = default;
			object obj14 = default;
			object obj15 = default;
			int result;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+18]");
				Monitor.Enter(0, ref lockTaken);
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v32+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v32+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v21+8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v21+8]");
				bool flag3 = (nint)0 == 0;
				object obj10 = 0;
				obj11 = (object)(&lockTaken);
				obj12 = 0;
				ex = null;
				obj13 = (object)(&obj14);
				obj15 = (object)(&lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+18]");
				obj14 = 0;
				lockTaken = false;
				if (flag3)
				{
					goto IL_0219;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v22+18]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v22+18]");
				bool flag4 = (nint)0 == 0;
				obj10 = 0;
				obj11 = (object)(&lockTaken);
				obj12 = 0;
				ex = null;
				obj13 = (object)(&obj14);
				obj15 = (object)(&lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+18]");
				obj14 = 0;
				lockTaken = false;
				if (flag4)
				{
					goto IL_0227;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v23+18]");
				result = 0;
				obj10 = 0;
				obj11 = (object)(&lockTaken);
				obj12 = 0;
				ex = null;
				obj13 = (object)(&obj14);
				obj15 = (object)(&lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+18]");
				obj14 = 0;
				lockTaken = false;
				goto IL_03b9;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj14 = null;
			lockTaken = false;
			goto IL_01fc;
			IL_01fc:
			OutOfMemoryException ex3 = new OutOfMemoryException();
			goto IL_020a;
			IL_0219:
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0227;
			IL_03b9:
			if (obj15 != null)
			{
				Monitor.Exit(obj13);
				obj11 = 0;
			}
			bool flag5 = ex == null;
			object obj17 = !flag5;
			if (obj17 != null)
			{
				goto IL_01fc;
			}
			bool flag6 = obj12 == null;
			object obj18 = !flag6;
			ex3 = ex;
			if (obj18 == null)
			{
				return result;
			}
			goto IL_020a;
			IL_020a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0219;
			IL_0227:
			NullReferenceException ex5 = new NullReferenceException();
			if ((nint)obj11 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj12 = 1;
			}
			else
			{
				if ((nint)obj11 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					int result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj19 = default;
				ex = (OutOfMemoryException)obj19;
			}
			result = 0;
			goto IL_03b9;
		}
	}

	public unsafe static int MostWaiting
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_026e: Expected Obj, but got I4
			//IL_035a: Expected Obj, but got I
			//IL_036a: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			//IL_006b: Expected Obj, but got I4
			//IL_028c: Expected Obj, but got I
			//IL_029c: Expected Obj, but got I
			//IL_02bc: Expected Obj, but got I4
			//IL_02c4: Expected Obj, but got Ref
			//IL_02cd: Expected Obj, but got I4
			//IL_02da: Expected Obj, but got Ref
			//IL_02e2: Expected Obj, but got Ref
			//IL_02f2: Expected Obj, but got I
			//IL_00a9: Expected Obj, but got I4
			//IL_00b1: Expected Obj, but got Ref
			//IL_00ba: Expected Obj, but got I4
			//IL_00c7: Expected Obj, but got Ref
			//IL_00cf: Expected Obj, but got Ref
			//IL_00df: Expected Obj, but got I
			//IL_011f: Expected Obj, but got I4
			//IL_01eb: Expected Obj, but got I4
			//IL_0100: Expected Obj, but got I4
			//IL_0147: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+8]");
			bool lockTaken = default;
			object obj11 = default;
			object obj12 = default;
			OutOfMemoryException ex = default;
			object obj13 = default;
			object obj14 = default;
			object obj15 = default;
			int result;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+18]");
				Monitor.Enter(0, ref lockTaken);
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v30+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v30+A0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v20+8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v20+8]");
				bool flag3 = (nint)0 == 0;
				object obj10 = 0;
				obj11 = (object)(&lockTaken);
				obj12 = 0;
				ex = null;
				obj13 = (object)(&obj14);
				obj15 = (object)(&lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+18]");
				obj14 = 0;
				lockTaken = false;
				if (flag3)
				{
					goto IL_019b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v21+30]");
				result = 0;
				obj10 = 0;
				obj11 = (object)(&lockTaken);
				obj12 = 0;
				ex = null;
				obj13 = (object)(&obj14);
				obj15 = (object)(&lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+18]");
				obj14 = 0;
				lockTaken = false;
				goto IL_032d;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj14 = null;
			lockTaken = false;
			goto IL_017e;
			IL_018c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_019b;
			IL_019b:
			NullReferenceException ex3 = new NullReferenceException();
			if ((nint)obj11 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj12 = 1;
			}
			else
			{
				if ((nint)obj11 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					int result2 = default;
					return result2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj16 = default;
				ex = (OutOfMemoryException)obj16;
			}
			result = 0;
			goto IL_032d;
			IL_032d:
			if (obj15 != null)
			{
				Monitor.Exit(obj13);
				obj11 = 0;
			}
			bool flag4 = ex == null;
			object obj17 = !flag4;
			if (obj17 != null)
			{
				goto IL_017e;
			}
			bool flag5 = obj12 == null;
			object obj18 = !flag5;
			OutOfMemoryException ex4 = ex;
			if (obj18 == null)
			{
				return result;
			}
			goto IL_018c;
			IL_017e:
			ex4 = new OutOfMemoryException();
			goto IL_018c;
		}
	}

	public unsafe static (int, double, double) Done
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_02ce: Expected Obj, but got I4
			//IL_03d7: Expected Obj, but got I
			//IL_03e7: Expected Obj, but got I
			//IL_01cb: Expected Obj, but got I4
			//IL_01d4: Expected VT, but got I4
			//IL_0051: Expected Obj, but got I
			//IL_007b: Expected Obj, but got I4
			//IL_02ec: Expected Obj, but got I
			//IL_02fc: Expected Obj, but got I
			//IL_031c: Expected Obj, but got I4
			//IL_0325: Expected VT, but got I4
			//IL_032e: Expected Obj, but got I4
			//IL_033f: Expected Obj, but got I4
			//IL_0348: Expected VT, but got I4
			//IL_0350: Expected Obj, but got Ref
			//IL_0358: Expected Obj, but got Ref
			//IL_0368: Expected Obj, but got I
			//IL_0379: Expected Obj, but got Ref
			//IL_00b0: Expected Obj, but got I
			//IL_00f5: Expected F8, but got I
			//IL_00f5: Expected F8, but got I
			//IL_00fe: Expected Obj, but got I4
			//IL_0111: Expected Obj, but got I4
			//IL_011a: Expected VT, but got I4
			//IL_0122: Expected Obj, but got Ref
			//IL_012a: Expected Obj, but got Ref
			//IL_0158: Invalid comparison between VT and I4
			//IL_0169: Expected Obj, but got I4
			//IL_0254: Expected Obj, but got I4
			//IL_029a: Expected VT, but got Obj
			//IL_0191: Expected Obj, but got I4
			//IL_0199: Expected Obj, but got VT
			//IL_01af: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDEAF]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+8]");
			bool lockTaken = default;
			(int, double, double) tuple;
			int num = default;
			object obj13 = default;
			(int, double, double) tuple2 = default;
			object obj14 = default;
			object obj15 = default;
			object obj16 = default;
			object obj11;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+18]");
				Monitor.Enter(0, ref lockTaken);
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v28+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj7 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v28+A0]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v19+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v19+8]");
				bool flag3 = (nint)0 == 0;
				obj11 = 0;
				tuple = ((int, double, double))0;
				object obj12 = 0;
				num = (int)(&lockTaken);
				obj13 = 0;
				tuple2 = ((int, double, double))0;
				obj14 = (object)(&obj15);
				obj16 = (object)(&lockTaken);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+18]");
				obj15 = 0;
				lockTaken = false;
				obj = (object)(&obj15);
				if (flag3)
				{
					goto IL_0204;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA088]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v20+2C]");
				num = 0;
				obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v20+2C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v20+38]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v20+40]");
				(int, double, double) tuple3 = ((int)num2, num3, 0.0);
				obj11 = 0;
				tuple = tuple3;
				obj13 = 0;
				tuple2 = ((int, double, double))0;
				obj14 = (object)(&obj15);
				obj16 = (object)(&lockTaken);
				lockTaken = false;
				goto IL_0387;
			}
			NullReferenceException ex = new NullReferenceException();
			obj11 = 0;
			tuple = ((int, double, double))0;
			obj15 = null;
			lockTaken = false;
			goto IL_01e7;
			IL_0204:
			NullReferenceException ex2 = new NullReferenceException();
			if (num == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj13 = 1;
			}
			else
			{
				if (num != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					(int, double, double) result = default;
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj17 = default;
				tuple2 = ((int, double, double))obj17;
			}
			goto IL_0387;
			IL_01f5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			goto IL_0204;
			IL_0387:
			if (obj16 != null)
			{
				Monitor.Exit(obj14);
				num = 0;
			}
			bool flag4 = tuple2 == ((int, double, double))(object)0;
			object obj18 = !flag4;
			if (obj18 != null)
			{
				goto IL_01e7;
			}
			bool flag5 = obj13 == null;
			object obj19 = !flag5;
			OutOfMemoryException ex3 = (OutOfMemoryException)tuple2;
			if (obj19 == null)
			{
				object obj20 = tuple;
				return tuple2;
			}
			goto IL_01f5;
			IL_01e7:
			ex3 = new OutOfMemoryException();
			goto IL_01f5;
		}
	}

	public static Task<T> Run<T>(Func<T> work)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+10]");
			return ((TaskFactory)0).StartNew(work);
		}
		return (Task<T>)(object)new NullReferenceException();
	}

	public static Task<T> Run<T>(Func<T> work, CancellationToken drop)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_0091: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			return ((TaskFactory)0).StartNew(work, drop);
		}
		return (Task<T>)(object)new NullReferenceException();
	}

	public static Task Run(Action work)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
			return ((TaskFactory)0).StartNew(work);
		}
		return (Task)(object)new NullReferenceException();
	}

	public unsafe static void ClearCounts()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I
		//IL_03f9: Expected Obj, but got I
		//IL_0041: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got Ref
		//IL_0355: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got Ref
		//IL_036a: Expected Obj, but got Ref
		//IL_037a: Expected Obj, but got I
		//IL_038b: Expected Obj, but got Ref
		//IL_00a0: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got Ref
		//IL_00e3: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got Ref
		//IL_00f8: Expected Obj, but got Ref
		//IL_0108: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got Ref
		//IL_0156: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got Ref
		//IL_016b: Expected Obj, but got Ref
		//IL_0280: Expected Obj, but got I4
		//IL_01aa: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+8]");
		bool lockTaken = default;
		object obj11 = default;
		object obj12 = default;
		OutOfMemoryException ex = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+18]");
			Monitor.Enter(0, ref lockTaken);
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v30+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v20+8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v20+8]");
			bool flag3 = (nint)0 == 0;
			object obj10 = 0;
			obj11 = (object)(&lockTaken);
			obj12 = 0;
			ex = null;
			obj13 = (object)(&obj14);
			obj15 = (object)(&lockTaken);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+18]");
			obj14 = 0;
			lockTaken = false;
			object obj16 = (object)(&obj14);
			if (flag3)
			{
				goto IL_0222;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v21+18]");
			obj16 = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v21+18]");
			bool flag4 = (nint)0 == 0;
			obj10 = 0;
			obj11 = (object)(&lockTaken);
			obj12 = 0;
			ex = null;
			obj13 = (object)(&obj14);
			obj15 = (object)(&lockTaken);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5+18]");
			obj14 = 0;
			lockTaken = false;
			if (flag4)
			{
				goto IL_0230;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v2+18]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X9_v2+18]");
			_ = 0;
			obj10 = 0;
			obj11 = (object)(&lockTaken);
			obj12 = 0;
			ex = null;
			obj13 = (object)(&obj14);
			obj15 = (object)(&lockTaken);
			lockTaken = false;
			goto IL_0399;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj14 = null;
		lockTaken = false;
		goto IL_0205;
		IL_0205:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		goto IL_0213;
		IL_0230:
		NullReferenceException ex4 = new NullReferenceException();
		if ((nint)obj11 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			obj12 = 1;
		}
		else
		{
			if ((nint)obj11 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289F3DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			object obj17 = default;
			ex = (OutOfMemoryException)obj17;
		}
		goto IL_0399;
		IL_0399:
		if (obj15 != null)
		{
			Monitor.Exit(obj13);
			obj11 = 0;
		}
		bool flag5 = ex == null;
		object obj18 = !flag5;
		if (obj18 != null)
		{
			goto IL_0205;
		}
		bool flag6 = obj12 == null;
		object obj19 = !flag6;
		ex3 = ex;
		if (obj19 == null)
		{
			return;
		}
		goto IL_0213;
		IL_0213:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_0222;
		IL_0222:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0230;
	}

	static GillaThreads()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_006b: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6890]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA098]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA090]");
		object obj4 = 0;
		int processorCount = Environment.ProcessorCount;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA0A0]");
		object obj7 = 0;
		object obj8 = processorCount * 1431655766;
		object obj9 = obj8 >> 63;
		object obj10 = obj8 >> 32;
		int val = (int)(obj10 + obj9);
		int val2 = Math.Min(3, val);
		int num = Math.Max(1, val2);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8+A0]");
		object obj12 = 0;
		obj12 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GillaToys.Limited limited = default;
		limited._002Ector(num);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v10+A0]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = limited;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CancellationToken none = CancellationToken.None;
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+A0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+8]");
		TaskFactory taskFactory = default;
		taskFactory._002Ector(none, (TaskCreationOptions)8, (TaskContinuationOptions)0, (TaskScheduler)0);
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v15+A0]");
		object obj20 = (nint)0 + (nint)16;
		obj20 = taskFactory;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
