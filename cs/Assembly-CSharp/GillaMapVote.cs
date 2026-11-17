using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion;
using UnityEngine;

public class GillaMapVote : MonoBehaviour
{
	private sealed class _003CStart_003Ed__58 : _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GillaLoading _003C_003E4__this;

		private int _003Ci_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CStart_003Ed__58(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0197: Expected I4, but got I8
			//IL_0021: Expected Obj, but got I4
			//IL_039d: Expected I4, but got Obj
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected Obj, but got Unknown
			//IL_01e5: Expected Obj, but got I4
			//IL_0232: Expected Obj, but got I
			//IL_025c: Expected Obj, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Expected Obj, but got Unknown
			//IL_008c: Expected Obj, but got I
			//IL_02f2: Expected Obj, but got I
			//IL_0302: Expected Obj, but got I
			//IL_032c: Expected Obj, but got I
			//IL_0356: Expected Obj, but got I4
			//IL_00ab: Expected Obj, but got I
			//IL_00cc: Expected Obj, but got I
			//IL_00f6: Expected Obj, but got I4
			//IL_012c: Expected Obj, but got I
			//IL_0156: Expected Obj, but got I4
			GillaLoading gillaLoading = _003C_003E4__this;
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0381;
				}
				_003C_003E1__state = -1;
				float unscaledTime = Time.unscaledTime;
				if ((object)_003C_003E4__this != null)
				{
					gillaLoading.started = unscaledTime;
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21E8]");
					object format = 0;
					object arg = default;
					string message = string.Format((string)format, arg);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj3 = 0;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v26+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.Log(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CBEA8]");
					object obj6 = 0;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v33+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					GillaIntegrity.Begin();
					_003Ci_003E5__2 = 0;
					goto IL_01d1;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (++_003Ci_003E5__2 < 2)
				{
					goto IL_01d1;
				}
				if ((object)_003C_003E4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C71A8]");
					object obj9 = 0;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+E4]");
					bool flag4 = (nint)0 == 0;
					object obj11 = !flag4;
					if (obj11 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AsyncOperation asyncOperation = GillaSceneGuard.LoadLobby(gillaLoading.next);
					object obj12 = _003C_003E4__this + 104;
					obj12 = asyncOperation;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					if (obj12 != null)
					{
						((AsyncOperation)obj12).allowSceneActivation = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21F8]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D21F0]");
						object obj14 = 0;
						string message2 = (string)obj13 + gillaLoading.next + (string)obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
						object obj15 = 0;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v17+E4]");
						bool flag5 = (nint)0 == 0;
						object obj17 = !flag5;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogError(message2);
					}
					goto IL_0381;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_01d1:
			object obj18 = this + 24;
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			_ = 1;
			return true;
			IL_0381:
			return false;
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

	[Serializable]
	public class MapEntry
	{
		public string label;

		public Texture2D preview;

		public Texture2D cover;

		public Transform[] apeSpawns;

		public Transform monsterSpawn;

		public MapEntry()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected Obj, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8428]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
			object obj2 = 0;
			object obj3 = this + 16;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj4 = this + 40;
			object obj5 = default;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
		}
	}

	internal class Canvas
	{
		private readonly int w;

		private readonly int h;

		private readonly Texture2D tex;

		private readonly Color32[] px;

		private readonly Renderer screen;

		private readonly MaterialPropertyBlock block;

		public Canvas(Renderer r, int width, int height)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected Obj, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected Obj, but got Unknown
			//IL_0091: Expected Obj, but got I
			//IL_00a1: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I
			//IL_0109: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got I4
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Expected Obj, but got Unknown
			//IL_020a: Expected Obj, but got I4
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4178]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			MaterialPropertyBlock materialPropertyBlock = default;
			materialPropertyBlock._002Ector();
			object obj3 = this + 48;
			obj3 = materialPropertyBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			base._002Ector();
			object obj4 = this + 40;
			obj4 = r;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Texture2D texture2D = default;
			texture2D._002Ector(width, height, (TextureFormat)4, mipChain: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2248]");
			object name = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4170]");
			object obj6 = 0;
			texture2D.filterMode = (FilterMode)0;
			texture2D.wrapMode = (TextureWrapMode)1;
			texture2D.name = (string)name;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v16+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			texture2D.hideFlags = ((~(object)Application.isPlaying != null) ? ((HideFlags)52) : ((HideFlags)0));
			object obj8 = this + 24;
			obj8 = texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj9 = h * w;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			object obj10 = this + 32;
			object obj11 = default;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}

		public void Clear(Color32 a, Color32 b)
		{
			//IL_003c: Expected Obj, but got I4
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0069: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got I4
			//IL_0088: Expected Obj, but got I4
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected Obj, but got Unknown
			//IL_00d8: Expected Obj, but got I4
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected Obj, but got Unknown
			int num = h;
			if (h < 1)
			{
				return;
			}
			int num2 = w;
			object obj = 0;
			do
			{
				if (num2 >= 1)
				{
					object obj2 = obj & 1;
					bool flag = obj2 == null;
					object obj3 = !flag;
					object obj4;
					if (obj3 == null)
					{
						Color32 color = a;
						obj4 = 0;
					}
					else
					{
						Color32 color = b;
						obj4 = 0;
					}
					while (true)
					{
						Color32[] array = px;
						if (px != null)
						{
							object obj5 = obj * num2;
							object obj6 = obj4 + obj5;
							bool flag2 = (nint)obj6 < array.Length;
							object obj7 = !flag2;
							if (obj7 == null)
							{
								object obj8 = (object)px + obj6;
								obj4++;
								num2 = w;
								if ((nint)obj4 >= w)
								{
									break;
								}
								continue;
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
						}
						throw new IndexOutOfRangeException();
					}
					num = h;
				}
				obj++;
			}
			while ((nint)obj < num);
		}

		public void Set(int x, int y, Color32 c)
		{
			//IL_001f: Expected I4, but got I8
			//IL_0039: Expected Obj, but got I4
			//IL_00ca: Expected Obj, but got I4
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected Obj, but got Unknown
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected Obj, but got Unknown
			//IL_0101: Expected Obj, but got I4
			int num = y | x;
			int num2 = (int)(num & 0x80000000L);
			bool flag = num2 == 0;
			object obj = !flag;
			if (obj != null || w <= x || h <= y)
			{
				return;
			}
			Color32[] array = px;
			if (px != null)
			{
				int num3 = ~y;
				object obj2 = h + num3;
				object obj3 = obj2 * w;
				object obj4 = x + obj3;
				bool flag2 = (nint)obj4 < array.Length;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					object obj6 = (object)px + obj4;
					return;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			throw new IndexOutOfRangeException();
		}

		public void Fill(RectInt r, Color32 c)
		{
			//IL_000e: Expected I4, but got VT
			//IL_001c: Expected Obj, but got VT
			//IL_002c: Expected Obj, but got I
			//IL_0289: Expected Obj, but got I4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected I4, but got Unknown
			//IL_0067: Expected Obj, but got I4
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected I4, but got Unknown
			//IL_00d4: Expected Obj, but got I4
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_02a4: Expected Obj, but got VT
			//IL_02cf: Expected Obj, but got VT
			//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Expected Obj, but got Unknown
			//IL_0311: Expected Obj, but got I4
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Expected Obj, but got Unknown
			//IL_0397: Expected Obj, but got I4
			//IL_01a1: Expected Obj, but got I4
			//IL_035f: Expected Obj, but got I4
			//IL_01e0: Expected VT, but got I8
			//IL_01f2: Expected I4, but got VT
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected VT, but got Unknown
			//IL_0210: Expected I, but got VT
			int num = r >> 32;
			Color32 color = default;
			object obj = color >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num2 = obj + num;
			RectInt rectInt = (RectInt)(color + r);
			object obj5 = num - num2;
			bool flag2 = (nint)obj5 < 0;
			bool flag3 = obj5 == null;
			int num3 = num ^ num2;
			int num4 = num ^ obj5;
			int num5 = num3 & num4;
			bool flag4 = num5 < 0;
			bool flag5 = flag2 == flag4;
			object obj6 = !flag3;
			object obj7 = flag5 & obj6;
			object obj8 = ~obj7;
			int num6 = ((obj8 != null) ? num2 : num);
			object obj9 = r - rectInt;
			bool flag6 = (nint)obj9 < 0;
			bool flag7 = obj9 == null;
			object obj10 = r ^ rectInt;
			object obj11 = r ^ obj9;
			object obj12 = obj10 & obj11;
			bool flag8 = (nint)obj12 < 0;
			bool flag9 = flag6 == flag8;
			object obj13 = !flag7;
			object obj14 = flag9 & obj13;
			object obj15 = ~obj14;
			IntPtr intPtr = default;
			RectInt rectInt3;
			if (obj15 == null)
			{
				RectInt rectInt2 = r;
				nint num7 = intPtr;
				rectInt3 = r;
			}
			else
			{
				RectInt rectInt2 = r;
				nint num7 = intPtr;
				rectInt3 = rectInt;
			}
			while (true)
			{
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (num == num6)
				{
					break;
				}
				object obj18 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v7+E4]");
				bool flag11 = (nint)0 == 0;
				object obj19 = !flag11;
				RectInt rectInt4 = r;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					rectInt4 = r;
				}
				while (true)
				{
					object obj20 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v9+E4]");
					bool flag12 = (nint)0 == 0;
					object obj21 = !flag12;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (rectInt3 != rectInt4)
					{
						Color32 color2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
						Set((int)rectInt4, num, color2);
						RectInt rectInt5 = (RectInt)(rectInt4 + 1);
						RectInt rectInt2 = rectInt4;
						nint num7 = (nint)color2;
						rectInt4 = rectInt5;
						continue;
					}
					break;
				}
				num++;
			}
		}

		public void Outline(RectInt r, Color32 c)
		{
			//IL_000e: Expected I4, but got VT
			//IL_001c: Expected Obj, but got VT
			//IL_002c: Expected Obj, but got I
			//IL_038d: Expected Obj, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected I4, but got Unknown
			//IL_0067: Expected Obj, but got VT
			//IL_0092: Expected Obj, but got VT
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected Obj, but got Unknown
			//IL_00d4: Expected Obj, but got I4
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected Obj, but got Unknown
			//IL_03a8: Expected Obj, but got I4
			//IL_03db: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Expected I4, but got Unknown
			//IL_0415: Expected Obj, but got I4
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Expected Obj, but got Unknown
			//IL_048e: Expected Obj, but got I4
			//IL_0240: Expected Obj, but got I4
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected I4, but got Unknown
			//IL_0181: Expected Obj, but got I4
			//IL_04c6: Expected Obj, but got I4
			//IL_01b0: Expected VT, but got I8
			//IL_01c2: Expected I4, but got VT
			//IL_01d4: Expected VT, but got I8
			//IL_01e6: Expected I4, but got VT
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected VT, but got Unknown
			//IL_0201: Expected VT, but got I4
			//IL_0211: Expected I, but got VT
			//IL_02c5: Expected Obj, but got I4
			//IL_02f4: Expected VT, but got I8
			//IL_0306: Expected I4, but got VT
			//IL_0318: Expected VT, but got I8
			//IL_0345: Expected VT, but got I4
			//IL_034d: Expected VT, but got I4
			//IL_0355: Expected I, but got VT
			int num = r >> 32;
			Color32 color = default;
			object obj = color >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C64A8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RectInt rectInt = (RectInt)(color + r);
			int num2 = obj + num;
			object obj5 = r - rectInt;
			bool flag2 = (nint)obj5 < 0;
			bool flag3 = obj5 == null;
			object obj6 = r ^ rectInt;
			object obj7 = r ^ obj5;
			object obj8 = obj6 & obj7;
			bool flag4 = (nint)obj8 < 0;
			bool flag5 = flag2 == flag4;
			object obj9 = !flag3;
			object obj10 = flag5 & obj9;
			object obj11 = ~obj10;
			RectInt rectInt2 = ((obj11 != null) ? rectInt : r);
			object obj12 = num - num2;
			bool flag6 = (nint)obj12 < 0;
			bool flag7 = obj12 == null;
			int num3 = num ^ num2;
			int num4 = num ^ obj12;
			int num5 = num3 & num4;
			bool flag8 = num5 < 0;
			bool flag9 = flag6 == flag8;
			object obj13 = !flag7;
			object obj14 = flag9 & obj13;
			object obj15 = ~obj14;
			int num6 = ((obj15 != null) ? num2 : num);
			int num7 = num6 - 1;
			RectInt rectInt3 = r;
			IntPtr intPtr = default;
			nint num8 = intPtr;
			RectInt rectInt4 = r;
			while (true)
			{
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v5+E4]");
				bool flag10 = (nint)0 == 0;
				object obj17 = !flag10;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj18 = obj2;
				if (rectInt2 == rectInt4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
				bool flag11 = (nint)0 == 0;
				object obj19 = !flag11;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Color32 c2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
				Set((int)rectInt4, num, c2);
				Color32 color2 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
				Set((int)rectInt4, num7, color2);
				RectInt rectInt5 = (RectInt)(rectInt4 + 1);
				color = (Color32)num7;
				rectInt3 = rectInt4;
				num8 = (nint)color2;
				rectInt4 = rectInt5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v7+E4]");
			bool flag12 = (nint)0 == 0;
			object obj20 = !flag12;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num9 = rectInt2 - 1;
			while (true)
			{
				object obj21 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v10+E4]");
				bool flag13 = (nint)0 == 0;
				object obj22 = !flag13;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (num6 != num)
				{
					object obj23 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v12+E4]");
					bool flag14 = (nint)0 == 0;
					object obj24 = !flag14;
					if (obj24 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Color32 c3 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
					Set((int)r, num, c3);
					Color32 color3 = (Color32)((nint)intPtr & 0xFFFFFFFFL);
					Set(num9, num, color3);
					int num10 = num + 1;
					color = (Color32)num;
					rectInt3 = (RectInt)num9;
					num8 = (nint)color3;
					num = num10;
					continue;
				}
				break;
			}
		}

		public unsafe void Text(ScreenFont font, int x, int y, string s, Color32[] colours, int scale, bool centred = default(bool))
		{
			//IL_0044: Expected Obj, but got I4
			//IL_0060: Expected Obj, but got Ref
			if (font == null)
			{
				return;
			}
			bool flag = string.IsNullOrEmpty(s);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj == null)
			{
				ShiftAuth.Style style = default;
				object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref style, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				ShiftAuth.Style s2 = default;
				if (centred)
				{
					int num = font.DrawCentred(px, w, h, x, y, s, ref s2);
				}
				else
				{
					int num2 = font.Draw(px, w, h, x, y, s, ref s2);
				}
			}
		}

		public void Picture(Color32[] src, int sw, int sh, int x, int y, int scale, float bright)
		{
			//IL_0025: Invalid comparison between F4 and I4
			//IL_0034: Invalid comparison between F4 and I4
			//IL_004c: Expected Obj, but got F8
			//IL_0059: Expected Obj, but got F4
			//IL_008e: Expected Obj, but got I4
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected Obj, but got Unknown
			//IL_037d: Invalid comparison between F4 and I4
			//IL_03c5: Expected Obj, but got I4
			//IL_03cf: Expected F4, but got I4
			//IL_00da: Expected F4, but got I4
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Expected Obj, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected Obj, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected Obj, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected Obj, but got Unknown
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected Obj, but got Unknown
			//IL_016d: Expected Obj, but got I4
			//IL_063c: Expected Obj, but got I4
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected Obj, but got Unknown
			//IL_01e3: Expected Obj, but got I
			//IL_020d: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got I4
			//IL_0406: Expected Obj, but got I
			//IL_044c: Expected Obj, but got I
			//IL_0461: Expected Obj, but got I
			//IL_0481: Expected Obj, but got I
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_048e: Expected Obj, but got Unknown
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected Obj, but got Unknown
			//IL_04e4: Expected I4, but got I8
			//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f1: Expected Obj, but got Unknown
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Expected Obj, but got Unknown
			//IL_055e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0563: Expected I4, but got Unknown
			//IL_056c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0571: Expected Obj, but got Unknown
			//IL_0579: Unknown result type (might be due to invalid IL or missing references)
			//IL_057e: Expected I4, but got Unknown
			//IL_0586: Unknown result type (might be due to invalid IL or missing references)
			//IL_058b: Expected I4, but got Unknown
			//IL_0593: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Expected I4, but got Unknown
			//IL_060f: Expected Obj, but got I4
			//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Expected I4, but got Unknown
			//IL_05c7: Expected I4, but got Obj
			//IL_05d9: Expected VT, but got I4
			//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e7: Expected Obj, but got Unknown
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Expected Obj, but got Unknown
			//IL_0277: Expected Obj, but got I4
			if (sh < 1)
			{
				return;
			}
			float num = bright - 1f;
			bool flag = num < 0f;
			bool flag2 = num == 0f;
			object obj = (double)bright ^ 1.0;
			object obj2 = bright ^ num;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			object obj5 = flag4 & obj4;
			object obj6 = ~obj5;
			float num2 = ((obj6 != null) ? bright : 1f);
			if (bright < 0f)
			{
				num2 = 0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107EF90]");
			int num3 = 0;
			int num4 = sh;
			int num5 = sw;
			Color32[] array = src;
			object obj7 = 0;
			float num6 = 0f;
			Canvas canvas = this;
			object obj13 = default;
			float num9 = default;
			float num10 = default;
			float num11 = default;
			object obj14 = default;
			object obj15 = default;
			object obj29 = default;
			object obj32 = default;
			bool flag9;
			do
			{
				if (sw >= 1)
				{
					object obj8 = ~obj7;
					object obj9 = obj7 * scale;
					object obj10 = y + obj9;
					object obj11 = obj8 + sh;
					object obj12 = obj11 * sw;
					int num7 = num4;
					int num8 = num5;
					Color32[] array2 = array;
					obj13 = obj13;
					num9 = num9;
					num10 = num10;
					num11 = num11;
					obj14 = obj14;
					obj15 = obj15;
					object obj16 = 0;
					int num12 = x;
					int num13 = num3;
					float num14 = num6;
					Canvas canvas2 = canvas;
					bool flag8;
					do
					{
						object obj17 = obj16 + obj12;
						bool flag5 = (nint)obj17 < src.Length;
						object obj18 = !flag5;
						if (obj18 == null)
						{
							object obj19 = (object)src + obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v19+20]");
							int num15 = 0;
							if ((double)bright < 1.0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
								object obj20 = 0;
								canvas2 = (Canvas)obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v10 (GillaMapVote+Canvas)+E4]");
								bool flag6 = (nint)0 == 0;
								obj9 = !flag6;
								if (obj9 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									canvas2 = (Canvas)obj20;
									obj15 = obj20;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v10 (GillaMapVote+Canvas)+A0]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								int num16 = num15 >> 24;
								int num17 = num15 & 0xFF;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v22+C]");
								object obj22 = (nint)0 >> 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v22+C]");
								object obj23 = (nint)num17 - (nint)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v22+C]");
								object obj24 = (nint)0 & (nint)0xFF;
								object obj25 = num16 - obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
								object obj26 = num14 & 0xFF000000FFL;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								num9 = num2 * (float)obj23;
								float num18 = num2 * (float)obj25;
								int num19 = (int)(num13 & 0xFF000000FFL);
								object obj27 = obj26 - num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								object obj28 = obj27 * obj29;
								object obj30 = obj28 + num19;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
								num14 = num18 + (float)obj22;
								num11 = num9 + (float)obj24;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction USHL not yet implemented.\"");
								num13 = (int)(obj30 & 0xFF0000FF0000L);
								object obj31 = num11 & 0xFF;
								int num20 = num13 | num14;
								int num21 = num20 | obj31;
								num15 = num21 | obj32;
								obj13 = obj24;
								num10 = num2;
							}
							if (scale >= 1)
							{
								object obj33 = 0;
								bool flag7;
								do
								{
									obj15 = 0;
									int num22;
									do
									{
										num22 = num12 + obj15;
										num8 = (int)(obj10 + obj33);
										Set(num22, num8, (Color32)num15);
										obj15++;
									}
									while (scale != (nint)obj15);
									obj14 = obj33 + 1;
									flag7 = (nint)obj14 != scale;
									num7 = num15;
									array2 = (Color32[])num22;
									canvas2 = this;
									obj33 = obj14;
								}
								while (flag7);
							}
							object obj34 = obj16 + 1;
							int num23 = num12 + scale;
							flag8 = (nint)obj34 != sw;
							num4 = num7;
							num5 = num8;
							array = array2;
							num3 = num13;
							num6 = num14;
							canvas = canvas2;
							obj16 = obj34;
							num12 = num23;
							continue;
						}
						IndexOutOfRangeException ex = new IndexOutOfRangeException();
						throw new NullReferenceException();
					}
					while (flag8);
				}
				object obj35 = obj7 + 1;
				flag9 = (nint)obj35 != sh;
				obj7 = obj35;
			}
			while (flag9);
		}

		public Texture2D Bake()
		{
			if ((object)tex != null)
			{
				tex.SetPixels32(px);
				if ((object)tex != null)
				{
					tex.Apply(updateMipmaps: true);
					return tex;
				}
			}
			return (Texture2D)(object)new NullReferenceException();
		}

		public void Show()
		{
			//IL_0010: Expected Obj, but got I
			//IL_015b: Expected Obj, but got I4
			//IL_009e: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I4
			//IL_00fd: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(screen == null))
			{
				tex.SetPixels32(px);
				tex.Apply(updateMipmaps: true);
				screen.GetPropertyBlock(block);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v11+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+A0]");
				object obj8 = 0;
				MaterialPropertyBlock materialPropertyBlock = block;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v7+8]");
				materialPropertyBlock.SetTexture(0, tex);
				screen.SetPropertyBlock(block);
			}
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Renderer, Canvas> _003C_003E9__65_0;

		public static Func<MapEntry, Color32[]> _003C_003E9__65_1;

		public static Func<MapEntry, bool> _003C_003E9__67_0;

		public static Func<KeyValuePair<PlayerRef, byte>, int> _003C_003E9__105_1;

		public static Func<int, int> _003C_003E9__105_2;

		public static Func<KeyValuePair<PlayerRef, byte>, bool> _003C_003E9__106_0;

		public static Func<KeyValuePair<PlayerRef, byte>, int> _003C_003E9__106_1;

		public static Func<int, int> _003C_003E9__106_2;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2240]");
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

		internal Canvas _003COnEnable_003Eb__65_0(Renderer r)
		{
			//IL_0010: Expected Obj, but got I
			//IL_00c1: Expected Obj, but got I4
			//IL_0064: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = r != null;
			bool flag3 = !flag2;
			Canvas result = null;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Canvas canvas = default;
				canvas._002Ector(r, 256, 208);
				result = canvas;
			}
			return result;
		}

		internal Color32[] _003COnEnable_003Eb__65_1(MapEntry m)
		{
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected Obj, but got Unknown
			if (m != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(m.preview != null))
				{
					goto IL_0124;
				}
				if ((object)m.preview != null)
				{
					string text = ((Enum)(object)m.preview).ToString();
					object obj4 = text & 1;
					if (obj4 == null)
					{
						goto IL_0124;
					}
					if ((object)m.preview != null)
					{
						return m.preview.GetPixels32();
					}
				}
			}
			return (Color32[])(object)new NullReferenceException();
			IL_0124:
			return null;
		}

		internal bool _003CLeftMode_003Eb__67_0(MapEntry m)
		{
			//IL_0157: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_009c: Expected Obj, but got I
			//IL_00b4: Expected Obj, but got I
			//IL_0103: Expected Obj, but got I4
			//IL_013a: Expected Obj, but got I
			if (m != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(m.monsterSpawn != null))
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+A0]");
				object obj6 = 0;
				object obj7 = obj6;
				if (obj6 != null)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v9+E4]");
					bool flag2 = (nint)0 == 0;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Transform monsterSpawn = m.monsterSpawn;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+B0]");
					return monsterSpawn == (UnityEngine.Object)0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int _003CMonsterIndex_003Eb__105_1(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = default;
			return playerRef.PlayerId;
		}

		internal int _003CMonsterIndex_003Eb__105_2(int i)
		{
			return i;
		}

		internal bool _003CApeNumber_003Eb__106_0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object obj = kv & 0xFF00000000L;
			object obj2 = obj - 12884901888L;
			bool flag = obj2 == null;
			return !flag;
		}

		internal int _003CApeNumber_003Eb__106_1(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = default;
			return playerRef.PlayerId;
		}

		internal int _003CApeNumber_003Eb__106_2(int i)
		{
			return i;
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public GillaModeRound round;

		internal bool _003CMonsterIndex_003Eb__0(KeyValuePair<PlayerRef, byte> kv)
		{
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected Obj, but got Unknown
			//IL_00da: Expected I4, but got Obj
			//IL_0043: Expected Obj, but got I
			//IL_006d: Expected Obj, but got I4
			//IL_0097: Expected Obj, but got VT
			object obj = kv & 0xFF00000000L;
			if ((long)obj == 12884901888L)
			{
				if ((object)round != null)
				{
					PlayerRef monster = round.Monster;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
					object obj2 = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v7+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj5 = monster - kv;
					bool flag2 = obj5 == null;
					return !flag2;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	public MapEntry[] maps;

	public PressKey[] panels;

	public Renderer[] panelScreens;

	public Renderer[] panelCovers;

	public Renderer board;

	public Transform lobby;

	public NetworkObject roundPrefab;

	public TextAsset titleFont;

	public TextAsset textFont;

	public string monsterName;

	public AudioClip tickSound;

	public AudioClip startSound;

	public AudioClip apesWinSound;

	private static GillaMapVote Instance__BackingField;

	private string ShownLine__BackingField;

	private string ShownWords__BackingField;

	public const string TheirTurnLine = null;

	public const string TheirTurnLineTwo = null;

	private const string TheirTurn = null;

	private const int PW = default(int);

	private const int PH = default(int);

	private const int BW = default(int);

	private const int BH = default(int);

	private static readonly int BaseMap;

	private static readonly Color32 Black;

	private static readonly Color32 Scan;

	private static readonly Color32 Lit;

	private static readonly Color32 Mid;

	private static readonly Color32 Low;

	private static readonly Color32 Picked;

	private static readonly Color32 Grey;

	private static readonly Color32[] HeadText;

	private static readonly Color32[] WhiteText;

	private static readonly Color32[] PickedText;

	private static readonly Color32[] DimText;

	private Canvas boardCanvas;

	private Canvas[] panelCanvas;

	private Color32[][] pictures;

	private ScreenFont title;

	private ScreenFont text;

	private int seenRound;

	private int lastTick;

	private int paidRound;

	private GillaModeRound seenIn;

	private byte seenPhase;

	private bool inHunt;

	private bool becameMonster;

	private bool outOfIt;

	private bool infected;

	private float nextCheck;

	private float nextDraw;

	private string drawn;

	private static int RoundsPlayed__BackingField;

	public const string TogetherIn = null;

	private const int Solid = default(int);

	public const float MonsterApart = default(float);

	public const float DoorStep = default(float);

	private const int MostLamps = default(int);

	private static readonly Vector3[] Around;

	private static readonly string[] GillaFigure;

	private static readonly Color32 MonsterRed;

	private static readonly Color32 MonsterFace;

	private static readonly Color32 GillaWhite;

	private static readonly Color32 GillaFace;

	private static readonly Color32 Infected;

	private static readonly Color32 InfectedFace;

	private static MaterialPropertyBlock coverBlock;

	private static readonly int BaseColor;

	public static GillaMapVote Instance
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
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
			return (GillaMapVote)0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
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

	public string ShownLine
	{
		get
		{
			return ShownLine__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 136;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public string ShownWords
	{
		get
		{
			return ShownWords__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 144;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	public static int RoundsPlayed
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+48]");
			return 0;
		}
		private set
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
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
		}
	}

	public static bool OutOfHunt
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01d2: Expected Obj, but got I4
			//IL_01f8: Expected Obj, but got I
			//IL_021a: Expected Obj, but got I4
			//IL_02b5: Expected Obj, but got I
			//IL_02d7: Expected Obj, but got I4
			//IL_00a4: Expected Obj, but got I4
			//IL_0252: Expected Obj, but got I4
			//IL_02f5: Expected Obj, but got I
			//IL_01a8: Expected I4, but got Obj
			//IL_0124: Expected Obj, but got I4
			//IL_028a: Expected Obj, but got I4
			//IL_032a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj8 != null)
			{
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v13+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v17+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v17+A0]");
				object obj14 = 0;
				object obj15 = obj14;
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v15+D9]");
					if ((nint)0 == 0)
					{
						goto IL_018c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v17+E4]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v23+E4]");
					bool flag7 = (nint)0 == 0;
					object obj18 = !flag7;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj17 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v23+A0]");
					object obj19 = 0;
					object obj20 = obj19;
					if (obj19 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v23+DB]");
						bool flag8 = (nint)0 == 0;
						return !flag8;
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			goto IL_018c;
			IL_018c:
			return false;
		}
	}

	public static bool InHunt
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_05e7: Expected Obj, but got I
			//IL_0609: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			//IL_062f: Expected Obj, but got I
			//IL_0651: Expected Obj, but got I4
			//IL_0767: Expected Obj, but got I
			//IL_0777: Expected Obj, but got I
			//IL_0799: Expected Obj, but got I4
			//IL_0677: Expected Obj, but got I
			//IL_0699: Expected Obj, but got I4
			//IL_07bf: Expected Obj, but got I
			//IL_07e1: Expected Obj, but got I4
			//IL_011f: Expected Obj, but got I4
			//IL_06d1: Expected Obj, but got I4
			//IL_07ff: Expected Obj, but got I
			//IL_05cf: Expected I4, but got Obj
			//IL_01ac: Expected Obj, but got I4
			//IL_0709: Expected Obj, but got I4
			//IL_082c: Expected Obj, but got I
			//IL_022c: Expected Obj, but got I4
			//IL_0741: Expected Obj, but got I4
			//IL_0861: Expected Obj, but got I
			//IL_0287: Expected Obj, but got I4
			//IL_02bf: Expected Obj, but got I4
			//IL_03b3: Expected Obj, but got I4
			//IL_03e2: Expected Obj, but got I
			//IL_044a: Expected Obj, but got I4
			//IL_04aa: Expected Obj, but got I4
			//IL_04d9: Expected Obj, but got I
			//IL_0530: Expected Obj, but got I
			//IL_057b: Expected Obj, but got I4
			//IL_05b2: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaModeRound current = GillaModeRound.Current;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v2+8]");
			UnityEngine.Object obj12 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj8;
			}
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v13+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj18 != null)
			{
				object obj20 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v19+E4]");
				bool flag7 = (nint)0 == 0;
				object obj21 = !flag7;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj22 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v23+E4]");
				bool flag8 = (nint)0 == 0;
				object obj23 = !flag8;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj22 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v23+A0]");
				object obj24 = 0;
				if (obj24 == null)
				{
					goto IL_05c1;
				}
				if (((UnityEngine.Behaviour)obj24).isActiveAndEnabled)
				{
					object obj25 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v28+E4]");
					bool flag9 = (nint)0 == 0;
					object obj26 = !flag9;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj27 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v32+E4]");
					bool flag10 = (nint)0 == 0;
					object obj28 = !flag10;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj27 = obj8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v32+A0]");
					object obj29 = 0;
					object obj30 = obj29;
					if (obj29 == null)
					{
						goto IL_05c1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v25+D9]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v32+E4]");
						bool flag11 = (nint)0 == 0;
						object obj31 = !flag11;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj32 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+E4]");
						bool flag12 = (nint)0 == 0;
						object obj33 = !flag12;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj32 = obj8;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+A0]");
						object obj34 = 0;
						object obj35 = obj34;
						if (obj34 == null)
						{
							goto IL_05c1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v32+DB]");
						bool flag13 = (nint)0 == 0;
						object obj36 = !flag13;
						if (obj36 == null)
						{
							object obj37 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v37+E4]");
							bool flag14 = (nint)0 == 0;
							object obj38 = !flag14;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if ((UnityEngine.Object)current != (UnityEngine.Object)null)
							{
								if ((object)current == null)
								{
									goto IL_05c1;
								}
								if (current.Live)
								{
									byte phase = current.Phase;
									int num = phase & 0xFF;
									if (num == 1)
									{
										object obj39 = obj15;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v45+E4]");
										bool flag15 = (nint)0 == 0;
										object obj40 = !flag15;
										if (obj40 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v2+8]");
										if ((UnityEngine.Object)0 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v2+8]");
											if ((nint)0 == 0)
											{
												goto IL_05c1;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v4 (UnityEngine.Object)+A4]");
											bool flag16 = (nint)0 == 0;
											object obj41 = !flag16;
											if (obj41 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v4 (UnityEngine.Object)+90]");
												if ((nint)0 == 1)
												{
													object obj42 = obj15;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v49+E4]");
													bool flag17 = (nint)0 == 0;
													object obj43 = !flag17;
													if (obj43 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v4 (UnityEngine.Object)+B0]");
													if ((UnityEngine.Object)0 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v4 (UnityEngine.Object)+B0]");
														if ((nint)0 == 0)
														{
															goto IL_05c1;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v4 (UnityEngine.Object)+B0]");
														if (((NetworkRunner)0).IsRunning)
														{
															object obj44 = obj15;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v55+E4]");
															bool flag18 = (nint)0 == 0;
															object obj45 = !flag18;
															if (obj45 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															NetworkRunner runner = ((SimulationBehaviour)current)._runner;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v4 (UnityEngine.Object)+B0]");
															return runner == (UnityEngine.Object)0;
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
			return false;
			IL_05c1:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static bool HuntingApes
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0380: Expected Obj, but got I
			//IL_03a2: Expected Obj, but got I4
			//IL_0057: Expected Obj, but got I4
			//IL_03c8: Expected Obj, but got I
			//IL_03ea: Expected Obj, but got I4
			//IL_044d: Expected Obj, but got I
			//IL_046f: Expected Obj, but got I4
			//IL_00f4: Expected Obj, but got I4
			//IL_0422: Expected Obj, but got I4
			//IL_048d: Expected Obj, but got I
			//IL_0368: Expected I4, but got Obj
			//IL_017c: Expected Obj, but got I4
			//IL_0270: Expected Obj, but got I4
			//IL_02d2: Expected Obj, but got VT
			//IL_0332: Expected Obj, but got I4
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_033f: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaModeRound current = GillaModeRound.Current;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj3;
			}
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v9+A0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj11 != null)
			{
				object obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v20+E4]");
				bool flag6 = (nint)0 == 0;
				object obj16 = !flag6;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v20+A0]");
				object obj17 = 0;
				object obj18 = obj17;
				if (obj17 == null)
				{
					goto IL_035a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+D9]");
				if ((nint)0 != 0)
				{
					object obj19 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v23+E4]");
					bool flag7 = (nint)0 == 0;
					object obj20 = !flag7;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)current != (UnityEngine.Object)null)
					{
						if ((object)current == null)
						{
							goto IL_035a;
						}
						if (current.Live)
						{
							byte phase = current.Phase;
							int num = phase & 0xFF;
							if (num == 1)
							{
								object obj21 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v31+E4]");
								bool flag8 = (nint)0 == 0;
								object obj22 = !flag8;
								if (obj22 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								if (Hunts(current))
								{
									(int, int) tuple = current.Apes();
									object obj23 = tuple >> 32;
									bool flag9 = (nint)obj23 < 0;
									bool flag10 = obj23 == null;
									object obj24 = obj23 ^ obj23;
									object obj25 = obj23 & obj24;
									bool flag11 = (nint)obj25 < 0;
									bool flag12 = flag9 == flag11;
									object obj26 = !flag10;
									return (byte)((flag12 & obj26) ? 1 : 0) != 0;
								}
							}
						}
					}
				}
			}
			return false;
			IL_035a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static Color32 C(byte r, byte g, byte b)
	{
		//IL_0045: Expected VT, but got I8
		int num = g & 0xFF;
		int num2 = num << 8;
		int num3 = num2 | b;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return (Color32)(num3 | 0xFF000000L);
	}

	private void Awake()
	{
		//IL_0010: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+A0]");
		object obj6 = 0;
		obj6 = this;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void OnDestroy()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_012e: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_01ee: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)obj8 == this)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v14+A0]");
			object obj14 = 0;
			obj14 = 0;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
	}

	private void OnEnable()
	{
		//IL_0010: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I
		//IL_02f9: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I4
		//IL_07e3: Expected Obj, but got I
		//IL_07f3: Expected Obj, but got I
		//IL_0803: Expected Obj, but got I
		//IL_0826: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03e1: Expected Obj, but got I4
		//IL_0340: Expected Obj, but got I4
		//IL_08c5: Expected Obj, but got I
		//IL_08d5: Expected Obj, but got I
		//IL_08e6: Expected Obj, but got I
		//IL_08f6: Expected Obj, but got I
		//IL_0918: Expected Obj, but got I4
		//IL_0844: Expected Obj, but got I
		//IL_085e: Expected Obj, but got I
		//IL_086f: Expected I, but got Obj
		//IL_088d: Expected Obj, but got I
		//IL_047a: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c1: Expected Obj, but got I4
		//IL_0428: Expected Obj, but got I4
		//IL_0501: Expected Obj, but got I4
		//IL_0936: Expected Obj, but got I
		//IL_0950: Expected Obj, but got I
		//IL_0961: Expected I, but got Obj
		//IL_097f: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_0713: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I
		//IL_073b: Expected I, but got Obj
		//IL_0587: Expected Obj, but got I
		//IL_0597: Expected Obj, but got I
		//IL_05ab: Expected Obj, but got I8
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected Obj, but got Unknown
		//IL_05ca: Expected Obj, but got I4
		//IL_0768: Expected Obj, but got I
		//IL_0776: Expected I, but got Obj
		//IL_09c0: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I4
		//IL_0635: Expected Obj, but got I
		//IL_0651: Expected Obj, but got I4
		//IL_06bf: Expected Obj, but got I4
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_067c: Expected I, but got Obj
		//IL_0696: Expected Obj, but got I
		//IL_06a8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = titleFont != null;
		bool flag3 = !flag2;
		object obj4 = 0;
		ScreenFont screenFont = null;
		if (!flag3)
		{
			string baked = titleFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont2 = default;
			screenFont2._002Ector(baked);
			obj4 = 0;
			screenFont = screenFont2;
		}
		object obj6 = this + 176;
		obj6 = screenFont;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X21_v4-50]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		object obj9 = 0;
		ScreenFont screenFont3 = null;
		if (!flag6)
		{
			string baked2 = textFont.text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			ScreenFont screenFont4 = default;
			screenFont4._002Ector(baked2);
			obj9 = 0;
			screenFont3 = screenFont4;
		}
		object obj11 = this + 184;
		obj11 = screenFont3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2240]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X21_v7-78]");
		bool flag8 = (UnityEngine.Object)0 != null;
		bool flag9 = !flag8;
		int num = 0;
		UnityEngine.Object obj15 = null;
		int num2 = default;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8160]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Canvas canvas = default;
			canvas._002Ector(board, 512, 128);
			object obj17 = this + 152;
			obj17 = canvas;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = 128;
			num = 512;
			obj15 = (UnityEngine.Object)(object)canvas;
		}
		object obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v24+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8170]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v33+8]");
		Func<System.__Canon, System.__Canon> selector = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v33+8]");
		bool flag11 = (nint)0 == 0;
		object obj22 = !flag11;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v24+E4]");
			bool flag12 = (nint)0 == 0;
			object obj23 = !flag12;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v37+A0]");
				obj20 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8190]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2230]");
			object obj26 = 0;
			Func<System.__Canon, System.__Canon> func = default;
			func._002Ector(obj20, (IntPtr)obj26);
			object obj27 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v36+A0]");
			object obj28 = (nint)0 + (nint)8;
			obj28 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = 0;
			selector = func;
		}
		IEnumerable<System.__Canon> source = Enumerable.Select((IEnumerable<System.__Canon>)(object)panelScreens, selector);
		System.__Canon[] array = Enumerable.ToArray(source);
		object obj29 = this + 160;
		obj29 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj30 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v32+E4]");
		bool flag13 = (nint)0 == 0;
		object obj31 = !flag13;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj14;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v32+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2208]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v27+10]");
		Func<System.__Canon, System.__Canon> selector2 = (Func<System.__Canon, System.__Canon>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v27+10]");
		bool flag14 = (nint)0 == 0;
		object obj35 = !flag14;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v32+E4]");
			bool flag15 = (nint)0 == 0;
			object obj36 = !flag15;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj37 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v31+A0]");
				obj32 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2210]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2238]");
			object obj39 = 0;
			Func<System.__Canon, System.__Canon> func2 = default;
			func2._002Ector(obj32, (IntPtr)obj39);
			object obj40 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v30+A0]");
			object obj41 = (nint)0 + (nint)16;
			obj41 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			num2 = 0;
			selector2 = func2;
		}
		object obj42 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X20_v13-80]");
		IEnumerable<System.__Canon> source2 = Enumerable.Select((IEnumerable<System.__Canon>)0, selector2);
		System.__Canon[] array2 = Enumerable.ToArray(source2);
		object obj43 = this + 168;
		obj43 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj44 = this + 232;
		obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Draw(null);
		object obj45 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v44+E4]");
		bool flag16 = (nint)0 == 0;
		object obj46 = !flag16;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		PressKey[] array3 = panels;
		bool flag17 = array3.Length < 1;
		GillaModeRound gillaModeRound = null;
		if (!flag17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2228]");
			object obj48 = 0;
			object obj49 = array3.Length & 0xFFFFFFFFL;
			object obj50 = array3 + 32;
			int num3 = num2;
			object obj51 = 0;
			object obj52 = obj42;
			GillaModeRound gillaModeRound2 = null;
			Action<System.__Canon> action = default;
			bool flag22;
			do
			{
				bool flag18 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49);
				object obj53 = !flag18;
				if (obj53 == null)
				{
					object obj54 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v57+E4]");
					bool flag19 = (nint)0 == 0;
					object obj55 = !flag19;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X27_v7+v145 @ X24_v8*8]");
					bool flag20 = (UnityEngine.Object)0 != null;
					bool flag21 = !flag20;
					obj42 = 0;
					gillaModeRound = null;
					if (!flag21)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action._002Ector((object)this, (IntPtr)obj48);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X27_v7+v145 @ X24_v8*8]");
						((PressKey)0).Pressed += (Action<PressKey>)action;
						num3 = 0;
						obj42 = 0;
						gillaModeRound = (GillaModeRound)(object)action;
					}
					obj49 = array3.Length;
					obj51++;
					flag22 = (nint)obj51 < array3.Length;
					num2 = num3;
					obj52 = obj42;
					gillaModeRound2 = gillaModeRound;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag22);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2218]");
		object obj57 = 0;
		Action action2 = default;
		action2._002Ector(this, (IntPtr)obj57);
		KillCam.Died += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2220]");
		object obj58 = 0;
		Action action3 = default;
		action3._002Ector(this, (IntPtr)obj58);
		KillCam.Dying += action3;
	}

	private void OnDisable()
	{
		//IL_01cb: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_0213: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I8
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_023e: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I4
		//IL_0276: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_02c9: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_013c: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		PressKey[] array = panels;
		if (array.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6090]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2228]");
			object obj3 = 0;
			object obj4 = array.Length & 0xFFFFFFFFL;
			object obj5 = array + 32;
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			nint num = default;
			IntPtr intPtr = num;
			object obj10 = 0;
			Action<System.__Canon> action = default;
			bool flag5;
			do
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
				object obj11 = !flag;
				if (obj11 == null)
				{
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v23+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X27_v5+v81 @ X23_v8*8]");
					bool flag3 = (UnityEngine.Object)0 != null;
					bool flag4 = !flag3;
					obj9 = 0;
					num = unchecked((nint)null);
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						action._002Ector((object)this, (IntPtr)obj3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X27_v5+v81 @ X23_v8*8]");
						((PressKey)0).Pressed -= (Action<PressKey>)action;
						obj6 = 0;
						obj9 = 0;
						num = (nint)action;
					}
					obj4 = array.Length;
					obj10++;
					flag5 = (nint)obj10 < array.Length;
					obj8 = obj9;
					intPtr = num;
					continue;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			while (flag5);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2218]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2220]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action2 = default;
		action2._002Ector(this, (IntPtr)obj15);
		KillCam.Died -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action action3 = default;
		action3._002Ector(this, (IntPtr)obj16);
		KillCam.Dying -= action3;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCorpse.ClearAll();
			LeftMode();
		}
	}

	private void LeftMode()
	{
		//IL_0015: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_04c2: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I
		//IL_04fc: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I
		//IL_06b8: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got I
		//IL_059f: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I4
		//IL_06d6: Expected Obj, but got I
		//IL_060d: Expected Obj, but got I
		//IL_0627: Expected Obj, but got I
		//IL_0638: Expected I, but got Obj
		//IL_0656: Expected Obj, but got I
		//IL_0671: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I4
		//IL_03f5: Expected Obj, but got I
		if (~(inHunt ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		inHunt = false;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		bool isMonster = MonsterPlayer.IsMonster;
		bool flag2 = !isMonster;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		if (!flag2)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v42+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v46+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v34+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = (UnityEngine.Object)obj10 != null;
			bool flag7 = !flag6;
			object obj12 = 0;
			num = 0;
			if (!flag7)
			{
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v50+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v54+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v54+A0]");
				object obj17 = 0;
				((MonsterPlayer)obj17).Become(0);
				obj12 = 0;
				num = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj18 = 0;
		object obj19 = obj4;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = (UnityEngine.Object)obj21 != null;
		bool flag12 = !flag11;
		object obj23 = 0;
		UnityEngine.Object obj24 = null;
		if (!flag12)
		{
			object obj25 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v13+A0]");
			object obj26 = 0;
			object obj27 = obj26;
			object obj28 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v18+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v15+B0]");
			bool flag14 = (UnityEngine.Object)0 == lobby;
			bool flag15 = !flag14;
			object obj30 = !flag15;
			object obj32 = default;
			object obj31 = obj32;
			object obj33 = 0;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2240]");
				object obj34 = 0;
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v27+E4]");
				bool flag16 = (nint)0 == 0;
				object obj36 = !flag16;
				if (obj36 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj35 = obj34;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v27+A0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v24+18]");
				Func<System.__Canon, bool> func = (Func<System.__Canon, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v24+18]");
				bool flag17 = (nint)0 == 0;
				object obj38 = !flag17;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v27+E4]");
					bool flag18 = (nint)0 == 0;
					object obj39 = !flag18;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj40 = obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v28+A0]");
						obj37 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2368]");
					object obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2370]");
					object obj42 = 0;
					Func<System.__Canon, bool> func2 = default;
					func2._002Ector(obj37, (IntPtr)obj42);
					object obj43 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v27+A0]");
					object obj44 = (nint)0 + (nint)24;
					obj44 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj32 = 0;
					func = func2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2360]");
				object obj45 = 0;
				obj33 = obj45;
				bool flag19 = Enumerable.Any((IEnumerable<System.__Canon>)(object)maps, func);
				bool flag20 = !flag19;
				obj31 = obj32;
				obj23 = obj45;
				obj24 = (UnityEngine.Object)(object)func;
				if (flag20)
				{
					goto IL_04b2;
				}
			}
			object obj46 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v17+A0]");
			object obj47 = 0;
			object obj48 = obj47 + 176;
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj32 = obj31;
			obj23 = obj33;
			obj24 = null;
		}
		goto IL_04b2;
		IL_04b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj49 = 0;
		object obj50 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2378]");
		object message = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v14+E4]");
		bool flag21 = (nint)0 == 0;
		object obj51 = !flag21;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I
		//IL_05f9: Expected Obj, but got I4
		//IL_0706: Expected Obj, but got I
		//IL_0716: Expected Obj, but got I
		//IL_0738: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_0631: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0669: Expected Obj, but got I4
		//IL_0691: Expected Obj, but got I
		//IL_06bb: Expected Obj, but got I4
		//IL_06d9: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I4
		//IL_047f: Expected Obj, but got I4
		//IL_04fa: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Application.isPlaying)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj4;
		}
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v11+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v2+8]");
		UnityEngine.Object obj12 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v2+8]");
		bool flag5 = (UnityEngine.Object)0 != null;
		bool flag6 = !flag5;
		UnityEngine.Object obj14 = null;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X22_v3 (UnityEngine.Object)+B0]");
			obj14 = (UnityEngine.Object)0;
		}
		object obj15 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj14 != null;
		bool flag9 = !flag8;
		UnityEngine.Object obj17 = null;
		UnityEngine.Object obj18 = null;
		if (!flag9)
		{
			bool isRunning = ((NetworkRunner)obj14).IsRunning;
			bool flag10 = !isRunning;
			obj17 = null;
			obj18 = null;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X22_v3 (UnityEngine.Object)+A4]");
				bool flag11 = (nint)0 == 0;
				object obj19 = !flag11;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X22_v3 (UnityEngine.Object)+90]");
					if ((nint)0 == 1)
					{
						bool isSharedModeMasterClient = ((NetworkRunner)obj14).IsSharedModeMasterClient;
						bool flag12 = !isSharedModeMasterClient;
						obj17 = null;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v2+8]");
							bool settled = ((NetworkBootstrap)0).Settled;
							bool flag13 = !settled;
							obj17 = null;
							if (!flag13)
							{
								float unscaledTime = Time.unscaledTime;
								double num = nextCheck;
								bool flag14 = unscaledTime < nextCheck;
								obj17 = null;
								if (!flag14)
								{
									float unscaledTime2 = Time.unscaledTime;
									unscaledTime = unscaledTime2 + 2f;
									nextCheck = unscaledTime;
									MakeRound((NetworkRunner)obj14);
									num = 2.0;
									obj17 = obj14;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
						object obj20 = 0;
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v54+E4]");
						bool flag15 = (nint)0 == 0;
						object obj22 = !flag15;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GillaModeRound current = GillaModeRound.Current;
						obj18 = current;
						goto IL_063f;
					}
				}
				obj17 = null;
				obj18 = null;
			}
		}
		goto IL_063f;
		IL_0522:
		float unscaledTime3 = Time.unscaledTime;
		if (!(unscaledTime3 < nextDraw))
		{
			float unscaledTime4 = Time.unscaledTime;
			float num2 = unscaledTime4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
			float num3 = num2 + 0f;
			nextDraw = num3;
			Draw((GillaModeRound)obj18);
		}
		return;
		IL_063f:
		object obj23 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v20+E4]");
		bool flag16 = (nint)0 == 0;
		object obj24 = !flag16;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (obj18 != null)
		{
			bool live = ((GillaModeRound)obj18).Live;
			bool flag17 = !live;
			object obj25 = !flag17;
			object obj26 = ~obj25;
			if (obj26 != null)
			{
				obj18 = null;
			}
		}
		Follow((GillaModeRound)obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5BF8]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v27+E4]");
		bool flag18 = (nint)0 == 0;
		object obj29 = !flag18;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj27;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v27+A0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v14+8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v15+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj32 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v32+E4]");
			bool flag19 = (nint)0 == 0;
			object obj33 = !flag19;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag20 = obj18 == null;
			bool flag21 = !flag20;
			object obj34 = !flag21;
			UnityEngine.Object obj35 = null;
			if (obj34 == null)
			{
				byte phase = ((GillaModeRound)obj18).Phase;
				int num4 = phase & 0xFF;
				bool flag22 = num4 == 1;
				obj35 = null;
				if (flag22)
				{
					goto IL_0522;
				}
			}
			object obj36 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v37+E4]");
			bool flag23 = (nint)0 == 0;
			object obj37 = !flag23;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCorpse.ClearHunts();
		}
		goto IL_0522;
	}

	private unsafe void MakeRound(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0580: Expected Obj, but got I
		//IL_05a2: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_010c: Expected VT, but got I4
		//IL_05c0: Expected Obj, but got I
		//IL_05cd: Expected VT, but got Obj
		//IL_01e5: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		//IL_05e2: Expected Obj, but got I
		//IL_05fa: Expected Obj, but got I
		//IL_060a: Expected Obj, but got I
		//IL_0612: Expected VT, but got Obj
		//IL_061a: Expected VT, but got Obj
		//IL_0627: Expected VT, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_036c: Expected VT, but got I4
		//IL_026d: Expected VT, but got Ref
		//IL_026d: Expected VT, but got I4
		//IL_02ac: Expected VT, but got Obj
		//IL_0388: Invalid comparison between VT and I4
		//IL_02ca: Expected Obj, but got I
		//IL_02da: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I4
		//IL_03c8: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_051f: Expected VT, but got I4
		//IL_0541: Expected VT, but got I4
		//IL_0416: Expected Obj, but got I4
		//IL_0426: Expected Obj, but got Ref
		//IL_045a: Expected I, but got Obj
		//IL_0465: Expected Obj, but got I
		//IL_0493: Expected Obj, but got VT
		//IL_04c8: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)current != (UnityEngine.Object)null;
		bool flag4 = !flag3;
		UnityEngine.Object obj7 = null;
		if (!flag4)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v75+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaModeRound current2 = GillaModeRound.Current;
			bool flag6 = (object)current2 == null;
			Vector3? vector = (Vector3?)(object)0;
			UnityEngine.Object obj10 = null;
			NetworkRunner networkRunner = runner;
			if (flag6)
			{
				goto IL_04f3;
			}
			bool live = current2.Live;
			bool flag7 = !live;
			object obj11 = !flag7;
			obj7 = null;
			if (obj11 != null)
			{
				return;
			}
		}
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v22+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((UnityEngine.Object)roundPrefab == (UnityEngine.Object)null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj14 = 0;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v70+E4]");
			bool flag9 = (nint)0 == 0;
			object obj16 = !flag9;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2388]");
			object message = 0;
			Debug.LogError(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5230]");
		object obj17 = 0;
		Vector3? vector2 = (Vector3)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4140]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v22+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5368]");
		object obj21 = 0;
		Quaternion? quaternion = (Quaternion?)obj20;
		Quaternion quaternion2 = (Quaternion)obj21;
		Quaternion? quaternion3 = (Quaternion)obj21;
		if ((object)runner != null)
		{
			Quaternion? quaternion4 = default;
			NetworkObject networkObject = runner.Spawn(roundPrefab, vector2, (Quaternion?)(object)0, (PlayerRef?)(object)(&quaternion4), null, (NetworkSpawnFlags)0);
			SessionInfo sessionInfo = runner.SessionInfo__BackingField;
			bool flag10 = runner.SessionInfo__BackingField == null;
			quaternion = quaternion3;
			Vector3? vector = vector2;
			quaternion2 = (Quaternion)roundPrefab;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2380]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5650]");
				object obj23 = 0;
				string message2 = (string)obj22 + sessionInfo.Name__BackingField + (string)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj24 = 0;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v60+E4]");
				bool flag11 = (nint)0 == 0;
				object obj26 = !flag11;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.Log(message2);
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			Vector3? vector = (Vector3?)(object)0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag12 = quaternion2 != (Quaternion)(object)1;
		NullReferenceException ex3 = ex2;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
			NetworkRunner networkRunner2 = default;
			nint num = (nint)networkRunner2;
			UnityEngine.Object obj10 = (UnityEngine.Object)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C655C8");
			object obj28 = default;
			object obj27 = obj28 & 1;
			bool flag13 = obj27 == null;
			NetworkRunner networkRunner = networkRunner2;
			if (!flag13)
			{
				object obj29 = 0;
				networkRunner = networkRunner2;
				object obj31 = default;
				object obj30 = (object)(&obj31);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				if ((object)networkRunner2 != null)
				{
					nint num2 = (nint)networkRunner;
					SceneRef sceneRef = ((Fusion.NetworkSceneManagerDummy)(object)networkRunner2).GetSceneRef((GameObject)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					string text = default;
					string text2 = default;
					string message3 = text + (string)sceneRef + text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E68");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v51+E4]");
					bool flag14 = (nint)0 == 0;
					object obj32 = !flag14;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogError(message3);
					return;
				}
				goto IL_04f3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0B0");
			object obj33 = networkRunner;
			quaternion2 = (Quaternion)(101789696 + 1224);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0C0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
			Vector3? vector = (Vector3?)(object)0;
			NullReferenceException ex4 = default;
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		return;
		IL_04f3:
		throw new NullReferenceException();
	}

	public unsafe void VoteFor(int map)
	{
		//IL_0010: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_016c: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		//IL_01b9: Expected Obj, but got I4
		//IL_0200: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v2+8]");
		UnityEngine.Object obj12 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)current == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null || !current.Live)
		{
			return;
		}
		byte phase = current.Phase;
		int num = phase & 0xFF;
		bool flag7 = num == 0;
		object obj15 = !flag7;
		if (obj15 != null)
		{
			return;
		}
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X9_v2+8]");
		bool flag9 = (UnityEngine.Object)0 == null;
		bool flag10 = !flag9;
		object obj18 = !flag10;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X21_v4 (UnityEngine.Object)+90]");
			if ((nint)0 == 1)
			{
				object obj19 = default;
				current.RPC_Vote((byte)map, (RpcInfo)(&obj19));
			}
		}
	}

	private void OnPanel(PressKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I
		//IL_0161: Invalid comparison between F4 and I4
		//IL_0172: Expected Obj, but got I4
		//IL_01db: Expected Obj, but got I4
		//IL_0306: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6168]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		int num = Array.IndexOf((System.__Canon[])(object)panels, (System.__Canon)(object)key);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)current != (UnityEngine.Object)null;
		bool flag4 = !flag3;
		GillaMapVote gillaMapVote = (GillaMapVote)flag3;
		GillaMapVote gillaMapVote2;
		int mode;
		if (!flag4)
		{
			bool live = current.Live;
			bool flag5 = !live;
			gillaMapVote = (GillaMapVote)live;
			if (!flag5)
			{
				byte phase = current.Phase;
				int num2 = phase & 0xFF;
				bool flag6 = num2 != 3;
				gillaMapVote = (GillaMapVote)phase;
				if (!flag6)
				{
					PressKey[] array = panels;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
					object obj8 = 0;
					gillaMapVote2 = (GillaMapVote)obj8;
					bool flag7 = gillaMapVote2.nextDraw == 0f;
					object obj9 = !flag7;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (num != 0)
					{
						if (array.Length >= 2)
						{
							object obj10 = array.Length - 1;
							if ((nint)obj10 == num)
							{
								mode = 1;
								goto IL_02ed;
							}
						}
						bool flag8;
						if (array.Length == 3)
						{
							object obj11 = num - 1;
							flag8 = obj11 == null;
						}
						else
						{
							flag8 = false;
						}
						object obj12 = !flag8;
						mode = ((obj12 != null) ? (-1) : 2);
					}
					else
					{
						mode = 0;
					}
					goto IL_02ed;
				}
			}
		}
		gillaMapVote.VoteFor(num);
		return;
		IL_02ed:
		gillaMapVote2.PickMode(mode);
	}

	public static int ModeOf(int panel, int count)
	{
		//IL_0048: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		int num = default;
		if (num != 0)
		{
			if (count >= 2)
			{
				object obj = count - 1;
				if ((nint)obj == num)
				{
					return 1;
				}
			}
			bool flag;
			if (count == 3)
			{
				object obj2 = num - 1;
				flag = obj2 == null;
			}
			else
			{
				flag = false;
			}
			object obj3 = !flag;
			if (obj3 == null)
			{
				return 2;
			}
			return -1;
		}
		return num;
	}

	public static string ModeLabel(int mode)
	{
		//IL_002a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		object result;
		if (mode == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23A0]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23A8]");
			result = 0;
		}
		if (mode == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22F0]");
			result = 0;
		}
		return (string)result;
	}

	public unsafe void PickMode(int mode)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		//IL_00d1: Expected I4, but got I8
		//IL_00eb: Expected Obj, but got I4
		//IL_008b: Expected I4, but got I8
		//IL_0109: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_0131: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I4
		//IL_0198: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I
		//IL_0316: Expected Obj, but got I4
		//IL_0372: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			if ((int)(mode & 0x80000000L) != 0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
			int num = (int)(mode & 0x80000000L);
			bool flag3 = num == 0;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v10+A0]");
		object obj10 = 0;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v3+8]");
		UnityEngine.Object obj12 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)current == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null || !current.Live)
		{
			return;
		}
		byte phase = current.Phase;
		int num2 = phase & 0xFF;
		if (num2 != 3)
		{
			return;
		}
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v20+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v3+8]");
		bool flag8 = (UnityEngine.Object)0 == null;
		bool flag9 = !flag8;
		object obj17 = !flag9;
		if (obj17 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X21_v5 (UnityEngine.Object)+90]");
		if ((nint)0 == 1)
		{
			IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)current)._runner.ActivePlayers;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2398]");
			object obj18 = 0;
			int players = Enumerable.Count(activePlayers);
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v16+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (GillaModeRound.ModeAllowed(mode, players))
			{
				object obj21 = default;
				current.RPC_ModeVote((byte)mode, (RpcInfo)(&obj21));
			}
		}
	}

	private unsafe void Follow(GillaModeRound round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0bf4: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_0c38: Expected F4, but got I4
		//IL_037e: Expected Obj, but got I4
		//IL_0124: Expected I4, but got I8
		//IL_0133: Expected I4, but got I8
		//IL_015e: Expected F4, but got I4
		//IL_05c7: Expected VT, but got I4
		//IL_08ad: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I
		//IL_01b6: Expected I4, but got Obj
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0991: Expected Obj, but got I4
		//IL_099e: Expected F4, but got I8
		//IL_08d1: Invalid comparison between F4 and I4
		//IL_0414: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_0ca1: Invalid comparison between F4 and I4
		//IL_0654: Expected VT, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_02ba: Expected Obj, but got I4
		//IL_09bd: Expected I4, but got F4
		//IL_09c6: Invalid comparison between F4 and I4
		//IL_09d7: Expected Obj, but got I4
		//IL_09f0: Invalid comparison between F4 and I4
		//IL_0a01: Expected Obj, but got I4
		//IL_0c5f: Expected Obj, but got I
		//IL_0c89: Expected Obj, but got I4
		//IL_0675: Expected VT, but got I4
		//IL_049b: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I4
		//IL_097b: Expected Obj, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0a46: Expected Obj, but got I4
		//IL_0693: Expected Obj, but got I
		//IL_06bd: Expected Obj, but got I4
		//IL_04b9: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I4
		//IL_06fd: Expected Obj, but got I4
		//IL_0705: Expected VT, but got I4
		//IL_0aba: Expected Obj, but got I4
		//IL_0723: Expected Obj, but got I
		//IL_0743: Expected Obj, but got I
		//IL_0765: Expected Obj, but got I4
		//IL_07a8: Expected VT, but got I4
		//IL_0565: Expected Obj, but got I4
		//IL_0b14: Expected Obj, but got I
		//IL_07ce: Expected Obj, but got I
		//IL_058b: Expected VT, but got Ref
		//IL_0594: Expected F4, but got I4
		//IL_07f4: Expected Obj, but got I4
		//IL_07fd: Expected VT, but got I4
		//IL_0b63: Expected Obj, but got I
		//IL_0b8d: Expected Obj, but got I4
		//IL_081d: Expected VT, but got I4
		//IL_0bc4: Expected VT, but got I4
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
		if ((UnityEngine.Object)round == (UnityEngine.Object)null)
		{
			if (~(inHunt ? 1u : 0u) == 0)
			{
				ComeBack();
			}
			return;
		}
		PlayerRef localPlayer = ((SimulationBehaviour)round)._runner.LocalPlayer;
		object obj4 = obj;
		object obj5 = this + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (round != (UnityEngine.Object)obj5)
		{
			seenIn = round;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			paidRound = -1;
			seenRound = -1;
		}
		byte phase = round.Phase;
		int num = phase & 0xFF;
		bool flag3 = num != 1;
		float num2 = 0f;
		bool flag4 = false;
		float pitchMax = default;
		float pitchMin = default;
		if (!flag3)
		{
			int round2 = round.Round;
			bool flag5 = round2 == seenRound;
			num2 = 0f;
			flag4 = false;
			if (!flag5)
			{
				int round3 = round.Round;
				seenRound = round3;
				NetworkDictionary<PlayerRef, byte> players = round.Players;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
				object obj7 = 0;
				int num3 = (int)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
				object obj9 = default;
				object obj8 = obj9 & 1;
				bool flag6 = obj8 == null;
				float num4 = default;
				pitchMax = num4;
				float num5 = default;
				pitchMin = num5;
				float num6 = default;
				num2 = num6;
				object obj10 = default;
				flag4 = (byte)(&obj10) != 0;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
					object obj11 = 0;
					object obj12 = obj11;
					int num7;
					if ((nint)obj10 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v106+E4]");
						bool flag7 = (nint)0 == 0;
						object obj13 = !flag7;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num7 = MonsterIndex(round, localPlayer);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X0_v106+E4]");
						bool flag8 = (nint)0 == 0;
						object obj14 = !flag8;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						num7 = ApeNumber(round, localPlayer);
					}
					object obj15 = obj10 - 3;
					bool flag9 = obj15 == null;
					GoIn(round, flag9, num7);
					num3 = num7;
					pitchMax = num4;
					pitchMin = num5;
					num2 = num6;
					flag4 = flag9;
				}
			}
		}
		byte phase2 = round.Phase;
		int num8 = phase2 & 0xFF;
		bool flag10 = num8 == 0;
		object obj16 = !flag10;
		if (obj16 == null && ~(inHunt ? 1u : 0u) == 0)
		{
			ComeBack();
		}
		if (~(inHunt ? 1u : 0u) == 0)
		{
			byte phase3 = round.Phase;
			int num9 = phase3 & 0xFF;
			if (num9 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
				object obj17 = 0;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v86+E4]");
				bool flag11 = (nint)0 == 0;
				object obj19 = !flag11;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (Hunts(round))
				{
					bool flag12 = (byte)(~(infected ? 1u : 0u)) != 0;
					object obj20 = !flag12;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
						object obj21 = 0;
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v90+E4]");
						bool flag13 = (nint)0 == 0;
						object obj23 = !flag13;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						if (MonsterPlayer.IsMonster)
						{
							becameMonster = true;
						}
						else if (~(becameMonster ? 1u : 0u) == 0)
						{
							bool flag14 = (byte)(~(outOfIt ? 1u : 0u)) != 0;
							object obj24 = !flag14;
							if (obj24 == null)
							{
								outOfIt = true;
								object obj25 = default;
								round.RPC_Out((RpcInfo)(&obj25));
								num2 = 0f;
								flag4 = false;
							}
						}
					}
				}
			}
		}
		byte phase4 = round.Phase;
		bool flag15 = seenPhase == phase4;
		PlayerRef playerRef = (PlayerRef)flag4;
		if (!flag15)
		{
			if (seenPhase != 255)
			{
				Announce(round);
			}
			byte phase5 = round.Phase;
			seenPhase = phase5;
			byte phase6 = round.Phase;
			int num10 = phase6 & 0xFF;
			bool flag16 = num10 != 2;
			playerRef = (PlayerRef)flag4;
			if (!flag16)
			{
				bool flag17 = (byte)(~(inHunt ? 1u : 0u)) != 0;
				playerRef = (PlayerRef)flag4;
				if (!flag17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
					object obj26 = 0;
					object obj27 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v72+E4]");
					bool flag18 = (nint)0 == 0;
					object obj28 = !flag18;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool isMonster = MonsterPlayer.IsMonster;
					bool flag19 = !isMonster;
					object obj29 = !flag19;
					playerRef = (PlayerRef)flag4;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
						object obj30 = 0;
						object obj31 = obj;
						object obj32 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v41+A0]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v76+E4]");
						bool flag20 = (nint)0 == 0;
						object obj34 = !flag20;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag21 = (UnityEngine.Object)obj33 != null;
						bool flag22 = !flag21;
						playerRef = (PlayerRef)0;
						if (!flag22)
						{
							object obj35 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v43+A0]");
							object obj36 = 0;
							KillCam killCam = (KillCam)obj36;
							bool flag23 = (byte)(~(killCam.Busy__BackingField ? 1u : 0u)) != 0;
							object obj37 = !flag23;
							playerRef = (PlayerRef)0;
							if (obj37 == null)
							{
								killCam.Heal();
								playerRef = (PlayerRef)0;
							}
						}
					}
				}
			}
			byte phase7 = round.Phase;
			int num11 = phase7 & 0xFF;
			if (num11 == 2)
			{
				PlayedOne(round, localPlayer);
				playerRef = localPlayer;
			}
		}
		byte phase8 = round.Phase;
		int num12 = phase8 & 0xFF;
		bool flag24 = num12 == 0;
		object obj38 = !flag24;
		if (obj38 == null)
		{
			num2 = round.VoteEnds;
			if (num2 > 0f)
			{
				float voteEnds = round.VoteEnds;
				goto IL_0947;
			}
		}
		byte phase9 = round.Phase;
		int num13 = phase9 & 0xFF;
		if (num13 == 3)
		{
			float modeEnds = round.ModeEnds;
			goto IL_0947;
		}
		object obj39 = 0;
		float num14 = 4.2949673E+09f;
		goto IL_0c97;
		IL_0947:
		num2 = round.Now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj40 = 0;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v51+E4]");
		bool flag25 = (nint)0 == 0;
		object obj42 = !flag25;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		obj39 = 0;
		num14 = num2;
		goto IL_0c97;
		IL_0c97:
		if (num14 == (float)lastTick)
		{
			return;
		}
		float num15 = num14 - 1f;
		lastTick = (int)num14;
		bool flag26 = num15 < 4f;
		object obj43 = !flag26;
		float num16 = num15 - 4f;
		bool flag27 = num16 == 0f;
		object obj44 = !flag27;
		object obj45 = obj43 & obj44;
		if (obj45 != null)
		{
			return;
		}
		object obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X0_v28+E4]");
		bool flag28 = (nint)0 == 0;
		object obj47 = !flag28;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(tickSound != null))
		{
			return;
		}
		object obj48 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v32+E4]");
		bool flag29 = (nint)0 == 0;
		object obj49 = !flag29;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (board != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
			Transform transform = board.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
			object obj51 = 0;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v42+E4]");
			bool flag30 = (nint)0 == 0;
			object obj53 = !flag30;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AudioClip[] clips = default;
			Sfx.Play(clips, (Vector3)0, num2, pitchMin, pitchMax);
		}
	}

	private void PlayedOne(GillaModeRound round, PlayerRef me)
	{
		//IL_007b: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I4
		int round2 = round.Round;
		if (round2 == paidRound)
		{
			return;
		}
		int round3 = round.Round;
		if (round3 != seenRound)
		{
			return;
		}
		NetworkDictionary<PlayerRef, byte> players = round.Players;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61C0]");
		object obj = 0;
		object obj2 = me & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9B65C");
		object obj4 = default;
		object obj3 = obj4 & 1;
		if (obj3 != null)
		{
			int round4 = round.Round;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
			object obj5 = 0;
			paidRound = round4;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v19+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+48]");
			object obj11 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v19+A0]");
			object obj14 = 0;
			object obj15 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCloud.PlayedRound();
		}
	}

	public static Vector3 Beside(Vector3 spawn, int number)
	{
		//IL_00d7: Invalid comparison between VT and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got I
		//IL_01b5: Expected Obj, but got I4
		//IL_03e2: Expected VT, but got I4
		//IL_03e2: Expected VT, but got I8
		//IL_0400: Expected Obj, but got I4
		//IL_0408: Expected VT, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_021f: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I4
		//IL_0432: Expected VT, but got I8
		//IL_0450: Expected Obj, but got I4
		//IL_0458: Expected VT, but got I4
		//IL_0276: Expected Obj, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b2: Expected Obj, but got I
		//IL_02dc: Expected VT, but got I4
		//IL_02fd: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_032f: Expected Obj, but got I
		//IL_03aa: Invalid comparison between F4 and I
		Vector3 vector = default;
		bool flag = vector < (object)1;
		Vector3 result = vector;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B030]");
			object obj = vector * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			object obj2 = obj * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
			object obj4 = default;
			object obj3 = obj4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
			object obj7 = default;
			object obj8 = default;
			object obj6 = obj7 * obj8;
			object obj10 = default;
			object obj9 = obj3 * obj10;
			object obj12 = default;
			object obj11 = obj12 + obj9;
			object obj14 = default;
			object obj13 = obj14 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj15 = 0;
			object obj16 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v8+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v9+18]");
			object obj19 = 0 * obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v9+20]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj20 = num * 0;
			object obj21 = obj14 + obj19;
			object obj22 = obj12 + obj20;
			object obj23 = obj11 + obj20;
			object obj24 = obj13 + obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj25 = !flag2;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			QueryTriggerInteraction queryTriggerInteraction = default;
			bool flag3 = Physics.Linecast((Vector3)4294951163L, (Vector3)1, 0, queryTriggerInteraction);
			bool flag4 = !flag3;
			object obj26 = !flag4;
			result = (Vector3)flag3;
			if (obj26 == null)
			{
				object obj27 = obj15;
				object obj28 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v14+A0]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v15+18]");
				object obj30 = 0 * obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v15+20]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				object obj31 = num2 * 0;
				float radius = (float)obj13 + (float)obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v12+E4]");
				bool flag5 = (nint)0 == 0;
				object obj32 = !flag5;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = Physics.CheckSphere((Vector3)4294951163L, radius, 1, (QueryTriggerInteraction)0);
				bool flag7 = !flag6;
				object obj33 = !flag7;
				result = (Vector3)flag6;
				if (obj33 == null)
				{
					object obj34 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v20+A0]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+18]");
					object obj36 = 0 * obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+20]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					object obj37 = num3 * 0;
					float num4 = (float)obj13 + (float)obj36;
					object obj38 = obj11 + obj37;
					result = GillaTeleport.FloorUnder((Vector3)0, num4);
					object obj39 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v24+A0]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v25+18]");
					object obj41 = 0 * obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v25+20]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
					object obj42 = num5 * 0;
					object obj43 = obj13 + obj41;
					object obj44 = obj11 + obj42;
					float num6 = num4 - (float)obj43;
					object obj45 = obj38 - obj44;
					float num7 = num6 * num6;
					object obj46 = obj45 * obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
					float num8 = (float)obj46 + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
					if (!(num8 < 0f))
					{
					}
				}
			}
		}
		return result;
	}

	public unsafe Pose MonsterStart(MapEntry map, int number, int apes)
	{
		//IL_32e6: Expected F4, but got I4
		//IL_0042: Expected F4, but got I4
		//IL_0068: Expected Obj, but got I
		//IL_0099: Expected VT, but got Obj
		//IL_00bb: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_330c: Expected Obj, but got I
		//IL_3324: Expected Obj, but got I
		//IL_335f: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got Ref
		//IL_0124: Expected VT, but got I4
		//IL_0124: Expected VT, but got I4
		//IL_0f34: Expected native int or pointer, but got VT
		//IL_0f4e: Expected VT, but got I
		//IL_0f49: Expected native int or pointer, but got VT
		//IL_0f56: Expected VT, but got Ref
		//IL_0154: Expected Obj, but got I
		//IL_337d: Expected Obj, but got I
		//IL_338d: Expected Obj, but got I
		//IL_339d: Expected Obj, but got I
		//IL_33ad: Expected Obj, but got I
		//IL_01e9: Expected F4, but got I
		//IL_01f9: Expected F4, but got I
		//IL_0212: Expected F4, but got I4
		//IL_03a4: Expected F4, but got I
		//IL_03b4: Expected F4, but got I
		//IL_03cd: Expected F4, but got I4
		//IL_03ec: Expected Obj, but got I
		//IL_0404: Expected F4, but got I
		//IL_0414: Expected F4, but got I
		//IL_0424: Expected VT, but got I
		//IL_043d: Expected F4, but got I4
		//IL_0459: Expected F4, but got I4
		//IL_0462: Expected Obj, but got I4
		//IL_33ea: Expected Obj, but got I4
		//IL_3405: Invalid comparison between F4 and I4
		//IL_0281: Expected F4, but got I
		//IL_0291: Expected F4, but got I
		//IL_02aa: Expected F4, but got I4
		//IL_048a: Expected Obj, but got I4
		//IL_02ef: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I4
		//IL_0fdf: Expected Obj, but got I4
		//IL_04ec: Expected Obj, but got I4
		//IL_101a: Expected Obj, but got I
		//IL_1032: Expected F4, but got I4
		//IL_1043: Expected Obj, but got F4
		//IL_1050: Expected F4, but got Obj
		//IL_0c3c: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I4
		//IL_2814: Expected Obj, but got I
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected I4, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected I4, but got Unknown
		//IL_106e: Expected Obj, but got I
		//IL_1076: Expected I, but got Obj
		//IL_1098: Expected Obj, but got I4
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_0584: Expected Obj, but got I4
		//IL_2879: Expected Obj, but got I
		//IL_2889: Expected Obj, but got I
		//IL_289f: Expected Obj, but got I
		//IL_3458: Expected I, but got Obj
		//IL_347a: Expected Obj, but got I4
		//IL_0cb2: Expected Obj, but got I4
		//IL_3dde: Expected Obj, but got I
		//IL_3dee: Expected Obj, but got I
		//IL_2907: Expected Obj, but got I4
		//IL_10cc: Expected I, but got Obj
		//IL_084e: Expected Obj, but got I4
		//IL_085b: Expected Obj, but got I4
		//IL_2984: Expected Obj, but got I
		//IL_2994: Expected Obj, but got I
		//IL_29a9: Expected VT, but got I
		//IL_29b9: Expected Obj, but got I
		//IL_10e9: Expected F4, but got I
		//IL_10f9: Expected Obj, but got I
		//IL_0874: Expected Obj, but got I
		//IL_087c: Expected VT, but got Obj
		//IL_089e: Expected Obj, but got I4
		//IL_069f: Expected Obj, but got I4
		//IL_29c6: Expected Obj, but got Ref
		//IL_29d6: Expected F4, but got I
		//IL_2a02: Expected F4, but got VT
		//IL_292b: Expected Obj, but got I
		//IL_293b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2940: Expected Obj, but got Unknown
		//IL_2956: Expected Obj, but got I
		//IL_08d8: Expected Obj, but got I
		//IL_08ea: Expected VT, but got I4
		//IL_08ea: Expected VT, but got Obj
		//IL_3520: Expected Obj, but got I
		//IL_06e6: Expected Obj, but got I
		//IL_06f6: Expected Obj, but got I
		//IL_070c: Expected Obj, but got I
		//IL_2a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3a: Expected F4, but got VT
		//IL_2a43: Expected VT, but got I4
		//IL_34a0: Expected Obj, but got I
		//IL_34b0: Expected native int or pointer, but got F4
		//IL_34b5: Invalid comparison between I and F4
		//IL_34c6: Expected Obj, but got I4
		//IL_34d7: Expected native int or pointer, but got F4
		//IL_34f3: Expected native int or pointer, but got F4
		//IL_34f8: Invalid comparison between I and F4
		//IL_1239: Expected Obj, but got I
		//IL_1249: Expected Obj, but got I
		//IL_1262: Expected F4, but got I4
		//IL_12bb: Expected F4, but got I
		//IL_11f0: Expected native int or pointer, but got F4
		//IL_094d: Expected Obj, but got I
		//IL_095d: Expected Obj, but got I
		//IL_0973: Expected Obj, but got I
		//IL_0765: Expected Obj, but got I
		//IL_078e: Expected Obj, but got I4
		//IL_2d5a: Expected I4, but got I8
		//IL_2d62: Expected VT, but got I4
		//IL_38eb: Expected Obj, but got I
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected Obj, but got Unknown
		//IL_116b: Expected Obj, but got I4
		//IL_1185: Invalid comparison between F4 and I4
		//IL_0ae6: Expected Obj, but got I
		//IL_0af6: Expected Obj, but got I
		//IL_0b0b: Expected VT, but got I
		//IL_0b2c: Expected Obj, but got I
		//IL_3c23: Expected I4, but got I8
		//IL_3c3d: Expected Obj, but got I4
		//IL_2a55: Expected I4, but got I8
		//IL_0de1: Expected Obj, but got I
		//IL_0df1: Expected Obj, but got I
		//IL_0e07: Expected Obj, but got I
		//IL_09e7: Expected Obj, but got I
		//IL_0a10: Expected Obj, but got I4
		//IL_313c: Expected Obj, but got I
		//IL_3166: Expected Obj, but got I4
		//IL_3e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9b: Expected F4, but got Unknown
		//IL_3ea4: Expected F4, but got I4
		//IL_35c8: Expected Obj, but got I
		//IL_35db: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e0: Expected Obj, but got Unknown
		//IL_0b41: Expected Obj, but got I
		//IL_0b51: Expected Obj, but got I
		//IL_0b6e: Expected VT, but got Ref
		//IL_0b77: Expected F4, but got I4
		//IL_0b80: Expected F4, but got I4
		//IL_0bb1: Expected F4, but got VT
		//IL_0bd1: Expected Obj, but got Ref
		//IL_31a3: Expected VT, but got I4
		//IL_319e: Expected native int or pointer, but got VT
		//IL_31c7: Expected VT, but got I4
		//IL_31c2: Expected native int or pointer, but got VT
		//IL_3d9f: Expected VT, but got Ref
		//IL_3dba: Invalid comparison between F4 and I4
		//IL_3557: Expected Obj, but got I
		//IL_3578: Expected Obj, but got I4
		//IL_0e5f: Expected Obj, but got I
		//IL_0e88: Expected Obj, but got I4
		//IL_0eb1: Invalid comparison between F4 and I4
		//IL_0a7e: Expected F4, but got I4
		//IL_0ab1: Expected F4, but got VT
		//IL_3ca8: Expected Obj, but got I
		//IL_3cc9: Expected VT, but got Ref
		//IL_3920: Expected VT, but got Ref
		//IL_1409: Expected VT, but got Ref
		//IL_139a: Expected native int or pointer, but got F4
		//IL_0f6b: Expected Obj, but got I
		//IL_0f7b: Expected Obj, but got I
		//IL_0f90: Expected VT, but got I
		//IL_2a78: Expected I4, but got Obj
		//IL_205d: Expected native int or pointer, but got F4
		//IL_2076: Expected F4, but got I
		//IL_2086: Expected Obj, but got I
		//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fb: Expected Obj, but got Unknown
		//IL_1315: Expected Obj, but got I4
		//IL_132f: Invalid comparison between F4 and I4
		//IL_0edf: Expected Obj, but got I
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected Obj, but got Unknown
		//IL_0f0a: Expected Obj, but got I
		//IL_3cde: Expected Obj, but got I
		//IL_3cf6: Expected Obj, but got I
		//IL_3d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d18: Expected Obj, but got Unknown
		//IL_3b40: Expected Obj, but got I4
		//IL_1447: Expected Obj, but got I
		//IL_2de5: Expected Obj, but got I
		//IL_2ded: Expected VT, but got Obj
		//IL_2e0f: Expected Obj, but got I4
		//IL_396e: Expected Obj, but got I
		//IL_3935: Expected Obj, but got I
		//IL_3945: Expected native int or pointer, but got F4
		//IL_394a: Invalid comparison between I and F4
		//IL_36ef: Expected Obj, but got I4
		//IL_212f: Expected native int or pointer, but got F4
		//IL_15a5: Expected Obj, but got I4
		//IL_3655: Expected Obj, but got I
		//IL_3676: Expected Obj, but got I4
		//IL_3eb9: Expected Obj, but got I
		//IL_3ed1: Expected Obj, but got I
		//IL_3ef2: Expected Obj, but got I
		//IL_3f1c: Expected Obj, but got I4
		//IL_20d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d6: Expected Obj, but got Unknown
		//IL_1fe0: Expected Obj, but got I4
		//IL_153e: Expected native int or pointer, but got F4
		//IL_2e78: Expected VT, but got I4
		//IL_2e78: Expected VT, but got I4
		//IL_2e88: Expected Obj, but got I
		//IL_2e98: Expected Obj, but got I
		//IL_2eae: Expected Obj, but got I
		//IL_2eeb: Expected F4, but got Obj
		//IL_2efb: Expected F4, but got I
		//IL_2f0b: Expected F4, but got I
		//IL_2f13: Expected F4, but got Obj
		//IL_1601: Expected VT, but got Ref
		//IL_149a: Unknown result type (might be due to invalid IL or missing references)
		//IL_149f: Expected Obj, but got Unknown
		//IL_14b9: Expected Obj, but got I4
		//IL_14d3: Invalid comparison between F4 and I4
		//IL_2f5f: Expected Obj, but got I4
		//IL_2fef: Expected Obj, but got I
		//IL_2fff: Expected Obj, but got I
		//IL_3014: Expected VT, but got I
		//IL_301c: Expected F4, but got Obj
		//IL_3041: Expected Obj, but got I
		//IL_3049: Expected I4, but got Obj
		//IL_305f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3064: Expected VT, but got Unknown
		//IL_306c: Invalid comparison between VT and I4
		//IL_3085: Expected F4, but got I
		//IL_3095: Expected VT, but got I
		//IL_30a5: Expected F4, but got Obj
		//IL_30b5: Expected F4, but got I
		//IL_30c5: Expected F4, but got I
		//IL_2f83: Expected Obj, but got I
		//IL_2f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f98: Expected Obj, but got Unknown
		//IL_2fae: Expected Obj, but got I
		//IL_2fca: Expected F4, but got Obj
		//IL_167c: Expected Obj, but got I
		//IL_169e: Expected Obj, but got I4
		//IL_16e3: Expected Obj, but got I4
		//IL_30eb: Expected Obj, but got Ref
		//IL_30f3: Expected native int or pointer, but got VT
		//IL_310d: Expected VT, but got I
		//IL_3108: Expected native int or pointer, but got VT
		//IL_3115: Expected VT, but got Obj
		//IL_174c: Expected VT, but got Ref
		//IL_17c6: Expected Obj, but got I
		//IL_1810: Expected VT, but got Ref
		//IL_1831: Expected Obj, but got I4
		//IL_1887: Expected VT, but got Ref
		//IL_18a8: Expected Obj, but got I4
		//IL_18d8: Expected Obj, but got I4
		//IL_1943: Expected VT, but got Ref
		//IL_1964: Expected Obj, but got I4
		//IL_19a5: Expected Obj, but got I4
		//IL_19cd: Expected Obj, but got I8
		//IL_19d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19db: Expected I4, but got Unknown
		//IL_1a4d: Expected Obj, but got I4
		//IL_1a5a: Expected F4, but got I8
		//IL_38ad: Expected Obj, but got I4
		//IL_38c5: Expected VT, but got Ref
		//IL_370d: Expected Obj, but got I
		//IL_3744: Expected Obj, but got I
		//IL_37c4: Expected Obj, but got I
		//IL_37f0: Expected Obj, but got I
		//IL_380d: Expected Obj, but got I
		//IL_3848: Expected VT, but got I4
		//IL_385c: Expected Obj, but got I
		//IL_3886: Expected Obj, but got I4
		//IL_1a9b: Expected VT, but got Ref
		//IL_1a9b: Expected VT, but got I4
		//IL_1aee: Expected Obj, but got Ref
		//IL_1ed0: Expected Obj, but got I
		//IL_1ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ede: Expected Obj, but got Unknown
		//IL_1eff: Expected Obj, but got I4
		//IL_1f20: Invalid comparison between F4 and I4
		//IL_1b19: Expected Obj, but got I
		//IL_1b21: Expected VT, but got Obj
		//IL_1b43: Expected Obj, but got I4
		//IL_1b9b: Expected Obj, but got I
		//IL_1bac: Expected VT, but got I4
		//IL_1bac: Expected VT, but got Obj
		//IL_1bf0: Expected VT, but got Ref
		//IL_1bf9: Expected F4, but got I4
		//IL_1c2f: Expected Obj, but got I
		//IL_1c3f: Expected Obj, but got I
		//IL_1c55: Expected Obj, but got I
		//IL_1ca9: Expected VT, but got Ref
		//IL_1cb2: Expected F4, but got I4
		//IL_1ce8: Expected F4, but got I
		//IL_1cf8: Expected Obj, but got I
		//IL_1d21: Expected Obj, but got I4
		//IL_1e10: Expected Obj, but got I
		//IL_1e20: Expected Obj, but got I
		//IL_1e3d: Expected VT, but got Ref
		//IL_1e46: Expected F4, but got I4
		//IL_1e4f: Expected F4, but got I4
		//IL_1e58: Expected F4, but got I4
		//IL_1e81: Expected F4, but got I4
		//IL_1e91: Expected F4, but got VT
		//IL_1eaa: Expected F4, but got I4
		//IL_1eb2: Expected Obj, but got Ref
		//IL_1ebb: Expected F4, but got I4
		//IL_1d8f: Expected F4, but got I4
		//IL_1d98: Expected F4, but got I4
		//IL_1da1: Expected F4, but got I4
		//IL_1dca: Expected F4, but got I4
		//IL_1dda: Expected F4, but got VT
		//IL_1df3: Expected F4, but got I4
		bool flag = map == null;
		int num = number;
		float num3 = default;
		float num2 = num3;
		float num5 = default;
		float num4 = num5;
		float num7 = default;
		float num6 = num7;
		float num8 = 0f;
		MapEntry mapEntry = map;
		Vector3 forward2 = default;
		Pose pose = default;
		Pose pose2;
		UnityEngine.Object obj12;
		Pose pose3 = default;
		int num9;
		float num10;
		float num11;
		float num12;
		if (!flag)
		{
			bool flag2 = (object)map.monsterSpawn == null;
			num = number;
			num2 = num3;
			num4 = num5;
			num6 = num7;
			num8 = 0f;
			mapEntry = map;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
				object obj = 0;
				Vector3 position = map.monsterSpawn.position;
				Vector3 forward = map.monsterSpawn.forward;
				Vector3 v = (Vector3)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v997 @ X0_v39 (UnityEngine.Vector3)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj2 = !flag3;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23E8]");
				object obj3 = 0;
				Vector3 vector = Flat(v);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X8_v21+A0]");
				object obj6 = 0;
				Vector3 upwards = default;
				Quaternion quaternion = Quaternion.Internal_LookRotation(ref forward2, ref upwards);
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X0_v44+E4]");
				bool flag4 = (nint)0 == 0;
				object obj8 = !flag4;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = (object)(&pose);
				pose2 = new Pose((Vector3)0, (Quaternion)0);
				if (number > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2410]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					num9 = 0;
					string text = (string)obj10;
					if (map.label == (string)obj10)
					{
						Transform[] apeSpawns = map.apeSpawns;
						bool flag5 = map.apeSpawns == null;
						num = 0;
						num10 = num3;
						num11 = num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+20]");
						num12 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+18]");
						num2 = 0f;
						num4 = num5;
						num6 = num7;
						num8 = 0f;
						mapEntry = (MapEntry)obj10;
						if (flag5)
						{
							goto IL_31d9;
						}
						if (apeSpawns.Length != 0)
						{
							bool flag6 = apeSpawns.Length == 0;
							num = 0;
							num10 = num3;
							num11 = num5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+20]");
							num12 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+18]");
							num2 = 0f;
							num4 = num5;
							num6 = num7;
							num8 = 0f;
							mapEntry = (MapEntry)obj10;
							if (flag6)
							{
								goto IL_3204;
							}
							int value = ((int*)num9)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2102 @ X0_v268 (System.Int32)+E4]");
							bool flag7 = (nint)0 == 0;
							object obj11 = !flag7;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag8 = apeSpawns[0] != null;
							num = 0;
							text = null;
							obj12 = (UnityEngine.Object)flag8;
							goto IL_336d;
						}
					}
					num = 0;
					obj12 = null;
					goto IL_336d;
				}
				((Pose*)(nint)pose3)->position = (Vector3)pose2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X19_v20+2C]");
				System.Runtime.CompilerServices.Unsafe.Write(&((Pose*)(nint)pose3)->rotation, (Quaternion)0);
				return (Pose)(&pose2);
			}
		}
		goto IL_31d9;
		IL_3274:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_3282;
		IL_31d9:
		NullReferenceException ex2 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_31f6;
		IL_324a:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_3258;
		IL_3910:
		num10 = num3;
		object obj13 = default;
		forward2 = (Vector3)(&obj13);
		goto IL_3282;
		IL_323c:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_324a;
		IL_11cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num = 0;
		goto IL_3510;
		IL_3266:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_3274;
		IL_395e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2968 @ X0_v170 (System.Single)+8]");
		mapEntry = (MapEntry)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2968.m_value (System.Single) (should have been resolved before IL gen)");
		goto IL_3910;
		IL_322e:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_323c;
		IL_3204:
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		goto IL_3212;
		IL_204e:
		throw new NullReferenceException();
		IL_3212:
		IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
		goto IL_3220;
		IL_0f9e:
		Transform parent = map.monsterSpawn.parent;
		int value2 = ((int*)num9)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2192 @ X8_v33 (System.Int32)+E4]");
		bool flag9 = (nint)0 == 0;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag10 = parent != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj15 = 0;
		bool flag11 = !flag10;
		float num13 = 12f;
		num = 0;
		NullReferenceException ex9 = (NullReferenceException)num5;
		UnityEngine.Object obj16 = null;
		float num14 = (float)obj12;
		bool flag16;
		List<(Vector3, Vector3)> list2 = default;
		List<Vector3> list3 = default;
		float num35 = default;
		object obj70;
		float num34 = default;
		float num18;
		object obj24 = default;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E10]");
			UnityEngine.Object obj17 = (UnityEngine.Object)0;
			nint num15 = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2287 @ X0_v132 (Il2CppClass<UnityEngine.Object>)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj18 = !flag12;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num16 = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ X0_v135 (Il2CppClass<UnityEngine.Object>)+E4]");
			bool flag13 = (nint)0 == 0;
			object obj19 = !flag13;
			nint num17 = num16;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				num17 = (nint)obj17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X0_v136 (Il2CppClass<UnityEngine.Object>)+A0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v118+40]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v118+40]");
			bool flag14 = (nint)0 == 0;
			num = 0;
			num10 = num3;
			mapEntry = null;
			if (!flag14)
			{
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCAF8]");
				num18 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2386 @ X8_v119+12E]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2386 @ X8_v119+12E]");
				if ((nint)0 == 0)
				{
					goto IL_11cf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2386 @ X8_v119+98]");
				float num19 = 0f + 8f;
				bool flag15 = flag16;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X10_v68 (System.Single)-8]");
					obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X10_v68 (System.Single)-8]");
					bool flag17 = 0f < ((float*)(nint)num18)->m_value;
					object obj25 = !flag17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X10_v68 (System.Single)-8]");
					float num20 = 0f - ((float*)(nint)num18)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2439 @ X10_v68 (System.Single)-8]");
					if (0f == ((float*)(nint)num18)->m_value)
					{
						break;
					}
					obj23--;
					bool flag18 = (nint)obj23 < 1;
					obj25 = !flag18;
					num20 = (float)obj23 - 1f;
					bool flag19 = num20 == 0f;
					num18 = num19 + 16f;
					flag16 = (nint)obj23 != 1;
					num19 = num18;
					flag15 = flag16;
					if (flag16)
					{
						continue;
					}
					goto IL_11cf;
				}
				float num21 = (float)obj22 + ((float*)(nint)num19)->m_value;
				float num22 = num21 + 312f;
				num18 = num19;
				num = 0;
				flag16 = flag15;
				goto IL_3510;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			List<Vector3> list = default;
			list._002Ector();
			Vector3 position2 = map.monsterSpawn.position;
			bool flag20 = list == null;
			num10 = num3;
			mapEntry = null;
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
				object obj29 = (nint)0 + (nint)1;
				object obj30 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
				bool flag21 = (nint)0 == 0;
				num10 = num3;
				mapEntry = null;
				if (!flag21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					nint num23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v39+18]");
					bool flag22 = num23 < 0;
					object obj31 = !flag22;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj32 = (nint)0 * (nint)12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
						object obj33 = 0 + obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
						object obj34 = (nint)0 + (nint)1;
						mapEntry = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X9_v25+20]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2463 @ X8_v111+A8]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2465 @ X8_v112+70]");
						list.AddWithResize((Vector3)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2465 @ X8_v112+70]");
						mapEntry = (MapEntry)0;
					}
					object obj37 = (object)(&pose);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v41+2C]");
					num6 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v41+2C]");
					_ = 0;
					bool flag23 = list2 == null;
					num10 = num3;
					num8 = (float)pose2;
					if (!flag23)
					{
						Enumerator<, > val = (Enumerator<, >)0;
						num10 = num3;
						float num24 = num2;
						float num25 = num7;
						num8 = (float)pose2;
						Vector3 vector2 = (Vector3)1;
						object obj43 = default;
						NullReferenceException ex11 = default;
						float num31 = default;
						Vector3 upwards2 = default;
						float num32 = default;
						(Vector3, Vector3) tuple2 = default;
						Vector3 position3 = default;
						int num26;
						double num27;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
							if ((nint)0 >= (nint)1)
							{
								break;
							}
							num26 = -1;
							Quaternion rotation = (Quaternion)num;
							NullReferenceException ex10 = ex9;
							num27 = -1.0;
							int num28 = (int)(num26 & 0x80000000L);
							bool flag24 = num28 == 0;
							object obj38 = !flag24;
							double num29 = num8;
							if (obj38 == null)
							{
								bool flag25 = num27 < 15.0;
								num29 = 15.0;
								if (!flag25)
								{
									(Vector3, Vector3) tuple = list2.get_Item(num26);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj39 = 0;
									object obj40 = obj39;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3032 @ X8_v55+A0]");
									object obj41 = 0;
									object obj42 = obj43 - obj41;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3033 @ X8_v56+8]");
									object obj44 = ex11 - 0;
									NullReferenceException ex12 = (NullReferenceException)(obj42 * obj42);
									object obj45 = obj44 * obj44;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
									object obj46 = obj45 + (object)ex12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
									float num30;
									NullReferenceException ex13;
									if ((nint)obj46 >= 0)
									{
										num30 = num31;
										ex13 = ex11;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
										object obj47 = 0;
										Vector3 at = (Vector3)obj47;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3124 @ X0_v96 (UnityEngine.Vector3)+E4]");
										bool flag26 = (nint)0 == 0;
										object obj48 = !flag26;
										if (obj48 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Vector3 vector3 = Clearest(at);
										ex12 = ex10;
										num30 = num25;
										ex13 = ex10;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj49 = 0;
									object obj50 = obj49;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3153 @ X8_v63+A0]");
									object obj51 = 0;
									Quaternion quaternion2 = Quaternion.Internal_LookRotation(ref forward2, ref upwards2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23E8]");
									object obj52 = 0;
									object obj53 = obj52;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3178 @ X0_v85+E4]");
									bool flag27 = (nint)0 == 0;
									object obj54 = !flag27;
									if (obj54 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									pose = new Pose((Vector3)0, (Quaternion)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									object obj55 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
									object obj56 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
									object obj57 = (nint)0 + (nint)1;
									object obj58 = obj56;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									bool flag28 = (nint)0 == 0;
									num = 0;
									num10 = num24;
									num11 = (float)ex12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3154 @ X8_v64+20]");
									num12 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3154 @ X8_v64+18]");
									num2 = 0f;
									num4 = (float)ex10;
									num6 = num25;
									num8 = num32;
									mapEntry = null;
									if (!flag28)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										nint num33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X9_v29+18]");
										bool flag29 = num33 < 0;
										object obj59 = !flag29;
										if (obj59 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj60 = (nint)0 * (nint)12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
											object obj61 = 0 + obj60;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ X0_v64 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj62 = (nint)0 + (nint)1;
											num4 = (float)ex10;
											num6 = num25;
											num8 = num32;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v70+20]");
											object obj63 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3310 @ X8_v77+A8]");
											object obj64 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3315 @ X8_v78+70]");
											list.AddWithResize((Vector3)0);
											num4 = (float)ex10;
											num6 = num25;
											num8 = num32;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2428]");
										object obj65 = 0;
										num = (int)obj65;
										list2.RemoveAt(num26);
										vector2++;
										bool flag30 = vector2 <= (object)number;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3154 @ X8_v64+20]");
										num34 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3154 @ X8_v64+18]");
										tuple2 = ((Vector3, Vector3))0;
										num10 = num24;
										num11 = (float)ex12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3154 @ X8_v64+20]");
										num12 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3154 @ X8_v64+18]");
										num24 = 0f;
										ex9 = ex13;
										num25 = num30;
										if (!flag30)
										{
											object obj66 = (object)(&position3);
											((Pose*)(nint)pose3)->position = position3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3343 @ X8_v75+C]");
											System.Runtime.CompilerServices.Unsafe.Write(&((Pose*)(nint)pose3)->rotation, (Quaternion)0);
											return (Pose)list2;
										}
										continue;
									}
									goto IL_31d9;
								}
							}
							Vector3 position4 = map.monsterSpawn.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
							object obj67 = 0;
							object obj68 = obj67;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2957 @ X0_v72+E4]");
							bool flag31 = (nint)0 == 0;
							object obj69 = !flag31;
							if (obj69 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Vector3 vector4 = Beside(vector2, 0);
							((Pose*)(nint)pose3)->position = (Vector3)0;
							_ = 0;
							_ = 0;
							_ = 0;
							System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)pose3, new Pose((Vector3)0, rotation));
							return pose3;
						}
						num26 = -1;
						num9 = 0;
						num27 = -1.0;
						Enumerator<, > enumerator = list3.GetEnumerator();
						num6 = num35;
						Enumerator<, > val2 = default;
						num8 = (float)val2;
						float num36 = 2.139095E+09f;
						float num39 = default;
						while (val.MoveNext())
						{
							num = (int)obj70;
							(Vector3, Vector3) tuple3 = list2.get_Item(num9);
							object obj71 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3101 @ X0_v126+E4]");
							bool flag32 = (nint)0 == 0;
							object obj72 = !flag32;
							if (obj72 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							float num37 = (float)tuple2 - num35;
							float num38 = num34 - num39;
							float num40 = num37 * num37;
							num6 = num38 * num38;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
							num8 = num6 + num40;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
							if (!(num36 < num8))
							{
								num36 = num8;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6A20]");
						object obj73 = 0;
						mapEntry = (MapEntry)obj73;
						val.Dispose();
						num2 = num24;
						forward2 = (Vector3)(&val);
						goto IL_31f6;
					}
				}
			}
		}
		goto IL_31d9;
		IL_31f6:
		OutOfMemoryException ex14 = new OutOfMemoryException();
		goto IL_3204;
		IL_3220:
		NullReferenceException ex15 = new NullReferenceException();
		goto IL_322e;
		IL_336d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B8]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C0]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7598]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7580]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		list3._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		mapEntry = (MapEntry)obj77;
		list2._002Ector();
		Transform[] apeSpawns2 = map.apeSpawns;
		bool flag33 = map.apeSpawns == null;
		num10 = num3;
		num11 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+20]");
		num12 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+18]");
		num2 = 0f;
		num4 = num5;
		num6 = num7;
		num8 = 0f;
		(Vector3, Vector3) tuple4;
		float num41;
		float num56 = default;
		if (!flag33)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2430]");
			obj70 = 0;
			num11 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+20]");
			num12 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+18]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v22+18]");
			tuple4 = ((Vector3, Vector3))0;
			num4 = num5;
			num6 = num7;
			num8 = 0f;
			num41 = num5;
			float num42 = num7;
			float num43 = 0f;
			object obj78 = 0;
			int num44 = apes;
			while (true)
			{
				bool flag34 = (nint)obj78 < apeSpawns2.Length;
				object obj25 = !flag34;
				float num20 = (float)obj78 - (float)apeSpawns2.Length;
				bool flag19 = num20 == 0f;
				flag16 = (nint)obj78 >= apeSpawns2.Length;
				if (flag16)
				{
					break;
				}
				bool flag35 = (nint)obj78 < apeSpawns2.Length;
				object obj79 = !flag35;
				num10 = num3;
				float num45;
				if (obj79 == null)
				{
					int value3 = ((int*)num9)->m_value;
					object obj80 = (object)apeSpawns2 + obj78;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2147 @ X8_v208+20]");
					num44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2146 @ X0_v249 (System.Int32)+E4]");
					bool flag36 = (nint)0 == 0;
					object obj81 = !flag36;
					if (obj81 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag37 = (UnityEngine.Object)num44 == null;
					bool flag38 = !flag37;
					num = 0;
					num45 = num8;
					mapEntry = null;
					if (!flag38)
					{
						goto IL_054a;
					}
					bool flag39 = obj78 == null;
					object obj82 = obj78 - apes;
					bool flag40 = (nint)obj82 < 0;
					int num46 = obj78 ^ apes;
					object obj83 = obj78 ^ obj82;
					int num47 = num46 & obj83;
					bool flag41 = num47 < 0;
					bool flag42 = flag40 == flag41;
					bool flag43 = !flag42;
					bool flag44 = (((object)obj12 != null) ? flag39 : flag43);
					if (flag44)
					{
						bool flag45 = num44 == 0;
						num = 0;
						num10 = num3;
						mapEntry = null;
						if (!flag45)
						{
							Vector3 position5 = ((Transform)num44).position;
							bool flag46 = list3 == null;
							num = 0;
							num10 = num3;
							mapEntry = null;
							if (!flag46)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								object obj84 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
								object obj85 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
								object obj86 = (nint)0 + (nint)1;
								object obj87 = obj85;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
								bool flag47 = (nint)0 == 0;
								num = 0;
								num10 = num3;
								mapEntry = null;
								if (!flag47)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X9_v101+18]");
									obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
									nint num48 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X9_v101+18]");
									bool flag48 = num48 < 0;
									object obj88 = !flag48;
									if (obj88 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										float num49 = 0f * 12f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
										float num50 = 0f + num49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										float num51 = 0f + 1f;
										num = 0;
										num45 = num8;
										mapEntry = null;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v222+20]");
										object obj89 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ X8_v223+A8]");
										object obj90 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2228 @ X8_v224+70]");
										list3.AddWithResize((Vector3)0);
										num = 0;
										num45 = num8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2228 @ X8_v224+70]");
										mapEntry = (MapEntry)0;
									}
									goto IL_054a;
								}
							}
						}
					}
					else
					{
						bool flag49 = num44 == 0;
						num = 0;
						num10 = num3;
						mapEntry = null;
						if (!flag49)
						{
							Vector3 position6 = ((Transform)num44).position;
							Vector3 forward3 = ((Transform)num44).forward;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
							object obj91 = 0;
							Vector3 v2 = (Vector3)obj91;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2396 @ X0_v258 (UnityEngine.Vector3)+E4]");
							bool flag50 = (nint)0 == 0;
							object obj92 = !flag50;
							if (obj92 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Vector3 vector5 = Flat(v2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F8]");
							object obj93 = 0;
							(Vector3, Vector3) tuple5 = ((Vector3)obj93, (Vector3)0);
							bool flag51 = list2 == null;
							num = 0;
							num10 = num3;
							num11 = num4;
							num12 = num6;
							num2 = num8;
							mapEntry = (MapEntry)obj93;
							if (!flag51)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
								object obj94 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F0]");
								object obj95 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+1C]");
								object obj96 = (nint)0 + (nint)1;
								object obj97 = obj95;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
								bool flag52 = (nint)0 == 0;
								num = 0;
								num10 = num3;
								num11 = num4;
								num12 = num6;
								num2 = num8;
								mapEntry = (MapEntry)obj93;
								if (!flag52)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v216+18]");
									obj24 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
									nint num52 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v216+18]");
									bool flag53 = num52 < 0;
									object obj98 = !flag53;
									if (obj98 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
										float num53 = 0f * 24f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
										float num54 = 0f + num53;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
										float num55 = 0f + 1f;
										_ = 0;
										num56 = 0f;
										num = 0;
										num11 = num4;
										num12 = num6;
										num2 = num8;
										tuple4 = tuple5;
										num45 = (float)tuple5;
										num41 = num4;
										num42 = num6;
										num43 = num8;
										mapEntry = (MapEntry)obj93;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X9_v98+20]");
										object obj99 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2686 @ X8_v217+A8]");
										object obj100 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2229 @ X8_v218+70]");
										num = 0;
										list2.AddWithResize(((Vector3, Vector3))(&forward2));
										num35 = 0f;
										num56 = 0f;
										num11 = num4;
										num12 = num6;
										num2 = num8;
										tuple4 = tuple5;
										forward2 = (Vector3)tuple5;
										num45 = (float)tuple5;
										num41 = num4;
										num42 = num6;
										num43 = num8;
										mapEntry = (MapEntry)(&forward2);
									}
									goto IL_054a;
								}
							}
						}
					}
					goto IL_31d9;
				}
				goto IL_3204;
				IL_054a:
				apeSpawns2 = map.apeSpawns;
				obj78++;
				bool flag54 = map.apeSpawns == null;
				object obj101 = !flag54;
				num8 = num45;
				if (obj101 != null)
				{
					continue;
				}
				num10 = num3;
				num8 = num45;
				goto IL_31d9;
			}
			bool flag55 = list3 == null;
			num10 = num3;
			if (!flag55)
			{
				if (apeSpawns2.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
					bool flag56 = (nint)0 == 0;
					object obj102 = !flag56;
					if (obj102 == null)
					{
						bool flag57 = apeSpawns2.Length == 0;
						num10 = num3;
						if (flag57)
						{
							goto IL_3204;
						}
						int value4 = ((int*)num9)->m_value;
						obj12 = apeSpawns2[0];
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2268 @ X0_v241 (System.Int32)+E4]");
						bool flag58 = (nint)0 == 0;
						object obj103 = !flag58;
						if (obj103 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag59 = obj12 != null;
						bool flag60 = !flag59;
						num = 0;
						if (!flag60)
						{
							Transform[] apeSpawns3 = map.apeSpawns;
							bool flag61 = map.apeSpawns == null;
							num = 0;
							num10 = num3;
							mapEntry = null;
							if (!flag61)
							{
								bool flag62 = apeSpawns3.Length == 0;
								num = 0;
								num10 = num3;
								mapEntry = null;
								if (flag62)
								{
									goto IL_3204;
								}
								bool flag63 = (object)apeSpawns3[0] == null;
								num = 0;
								num10 = num3;
								mapEntry = null;
								if (!flag63)
								{
									Vector3 position7 = apeSpawns3[0].position;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									object obj104 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43C8]");
									object obj105 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+1C]");
									object obj106 = (nint)0 + (nint)1;
									object obj107 = obj105;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
									bool flag64 = (nint)0 == 0;
									num = 0;
									num10 = num3;
									mapEntry = null;
									if (!flag64)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v204+18]");
										obj24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										nint num57 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v204+18]");
										bool flag65 = num57 < 0;
										object obj25 = !flag65;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
										float num58 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v204+18]");
										float num20 = num58 - 0f;
										bool flag19 = num20 == 0f;
										if (obj25 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj108 = (nint)0 * (nint)12;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+10]");
											object obj109 = 0 + obj108;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ X0_v52 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+18]");
											object obj110 = (nint)0 + (nint)1;
											num = 0;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X9_v91+20]");
											object obj111 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2468 @ X8_v205+A8]");
											object obj112 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2174 @ X8_v206+70]");
											list3.AddWithResize((Vector3)0);
											num = 0;
										}
										goto IL_0f9e;
									}
								}
							}
							goto IL_31d9;
						}
					}
				}
				goto IL_0f9e;
			}
		}
		goto IL_31d9;
		IL_3510:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2486 @ X0_v137 (System.Single)+8]");
		mapEntry = (MapEntry)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2486.m_value (System.Single) (should have been resolved before IL gen)");
		object obj113 = default;
		if (obj113 == null)
		{
			goto IL_204e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CCB00]");
		object obj115 = 0;
		float num60 = default;
		float num59 = num60;
		float num61 = num34;
		float num62 = 0f;
		object obj116 = obj24;
		float num63 = num18;
		object obj117 = obj113;
		int num64 = num;
		float num65 = num11;
		float num66 = num12;
		float num67 = num2;
		float num68 = num4;
		float num69 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
		float num70 = 0f;
		float num71 = num41;
		UnityEngine.Object obj121 = default;
		object obj127 = default;
		float num96 = default;
		(Vector3, Vector3) tuple7 = default;
		object obj155 = default;
		while (true)
		{
			object obj118 = obj117;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2611 @ X8_v162+12E]");
			object obj119 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2611 @ X8_v162+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1379;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2611 @ X8_v162+98]");
			float num72 = 0f + 8f;
			bool flag66 = flag16;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2724 @ X10_v63 (System.Single)-8]");
				obj116 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2724 @ X10_v63 (System.Single)-8]");
				bool flag67 = 0 < (nint)obj114;
				object obj25 = !flag67;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2724 @ X10_v63 (System.Single)-8]");
				float num20 = 0f - (float)obj114;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2724 @ X10_v63 (System.Single)-8]");
				if (0 == (nint)obj114)
				{
					break;
				}
				obj119--;
				bool flag68 = (nint)obj119 < 1;
				obj25 = !flag68;
				num20 = (float)obj119 - 1f;
				bool flag19 = num20 == 0f;
				num63 = num72 + 16f;
				flag16 = (nint)obj119 != 1;
				num72 = num63;
				flag66 = flag16;
				if (flag16)
				{
					continue;
				}
				goto IL_1379;
			}
			float num73 = (float)obj118 + ((float*)(nint)num72)->m_value;
			float num74 = num73 + 312f;
			num63 = num72;
			num = num64;
			flag16 = flag66;
			goto IL_35b8;
			IL_36b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3083.m_value (System.Single) (should have been resolved before IL gen)");
			int value5 = ((int*)num9)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3088 @ X0_v185 (System.Int32)+E4]");
			bool flag69 = (nint)0 == 0;
			object obj120 = !flag69;
			if (obj120 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag70 = obj121 == null;
			bool flag71 = !flag70;
			object obj122 = !flag71;
			num = 0;
			UnityEngine.Object obj123 = null;
			if (obj122 == null)
			{
				bool flag72 = (object)obj121 == null;
				num = 0;
				num10 = num3;
				num11 = num65;
				num12 = num66;
				num2 = num67;
				forward2 = (Vector3)(&obj13);
				num4 = num68;
				num6 = num69;
				num8 = num70;
				mapEntry = null;
				if (flag72)
				{
					goto IL_323c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3087 @ X0_v184 (UnityEngine.Object)+E4]");
				bool flag73 = (nint)0 == 0;
				num = 0;
				obj123 = null;
				if (!flag73)
				{
					int value6 = ((int*)num9)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3087 @ X0_v184 (UnityEngine.Object)+A0]");
					UnityEngine.Object obj17 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3250 @ X0_v190 (System.Int32)+E4]");
					bool flag74 = (nint)0 == 0;
					object obj124 = !flag74;
					if (obj124 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag75 = obj17 == null;
					bool flag76 = !flag75;
					object obj125 = !flag76;
					num = 0;
					obj123 = null;
					if (obj125 == null)
					{
						Transform transform = ((Component)obj121).transform;
						bool flag77 = (object)transform == null;
						num = 0;
						num10 = num3;
						num11 = num65;
						num12 = num66;
						num2 = num67;
						forward2 = (Vector3)(&obj13);
						num4 = num68;
						num6 = num69;
						num8 = num70;
						mapEntry = null;
						if (flag77)
						{
							goto IL_324a;
						}
						bool flag78 = transform.IsChildOf(parent);
						bool flag79 = !flag78;
						num = 0;
						obj123 = parent;
						if (!flag79)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
							object obj126 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							bool flag80 = obj127 == null;
							num = 0;
							num10 = num3;
							num11 = num65;
							num12 = num66;
							num2 = num67;
							forward2 = (Vector3)(&obj13);
							num4 = num68;
							num6 = num69;
							num8 = num70;
							mapEntry = (MapEntry)2;
							if (flag80)
							{
								goto IL_3258;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
							bool flag81 = (nint)0 == 0;
							num = 0;
							num10 = num3;
							num11 = num65;
							num12 = num66;
							num2 = num67;
							forward2 = (Vector3)(&obj13);
							num4 = num68;
							num6 = num69;
							num8 = num70;
							mapEntry = (MapEntry)2;
							if (flag81)
							{
								goto IL_3266;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
							bool flag82 = (nint)0 < (nint)1;
							object obj25 = !flag82;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
							float num20 = 0f - 1f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
							bool flag19 = (nint)0 == 1;
							_ = 1065353216;
							num = 0;
							num10 = num3;
							num11 = num65;
							num12 = num66;
							num2 = num67;
							forward2 = (Vector3)(&obj13);
							num4 = num68;
							num6 = num69;
							num8 = num70;
							mapEntry = (MapEntry)2;
							if (flag19)
							{
								goto IL_3274;
							}
							_ = 3212836864L;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
							flag16 = (nint)0 < (nint)1;
							num = 0;
							obj123 = (UnityEngine.Object)2;
							if (!flag16)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
								object obj128 = 0 & 0xFFFFFFFFL;
								int num44 = obj127 + 32;
								float num75 = num59;
								float num76 = num61;
								float num77 = num56;
								object obj129 = obj116;
								float num78 = num63;
								bool flag83 = false;
								num11 = num65;
								num12 = num66;
								num2 = num67;
								(Vector3, Vector3) tuple6 = tuple4;
								num4 = num68;
								num6 = num69;
								num8 = num70;
								mapEntry = (MapEntry)2;
								float num79 = 3.2128369E+09f;
								UnityEngine.Object obj130 = null;
								while (true)
								{
									bool flag84 = System.Runtime.CompilerServices.Unsafe.As<UnityEngine.Object, UIntPtr>(ref obj130) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj128);
									object obj131 = !flag84;
									num = (flag83 ? 1 : 0);
									num10 = num3;
									forward2 = (Vector3)(&obj13);
									if (obj131 != null)
									{
										break;
									}
									Vector3 foot = ((GillaDoor)obj121).Foot;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
									object obj132 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2586 @ X26_v24 (System.Int32)+v1115 @ X19_v44 (UnityEngine.Object)*4]");
									float num80 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD3C]");
									float num81 = num80 * 0f;
									object obj133 = obj132;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3497 @ X8_v182+A0]");
									object obj134 = 0;
									float num82 = num81;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3087 @ X0_v184 (UnityEngine.Object)+144]");
									float num83 = num82 * 0f;
									float num84 = num81;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3087 @ X0_v184 (UnityEngine.Object)+148]");
									float num85 = num84 * 0f;
									float num86 = num81;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3087 @ X0_v184 (UnityEngine.Object)+14C]");
									float num87 = num86 * 0f;
									float num88 = num8 + num83;
									float num89 = num6 + num85;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3498 @ X8_v183+18]");
									nint num90 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
									object obj135 = num90 * 0;
									float num91 = num4 + num87;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3498 @ X8_v183+1C]");
									nint num92 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
									object obj136 = num92 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3498 @ X8_v183+20]");
									nint num93 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
									object obj137 = num93 * 0;
									float num43 = num88 + (float)obj135;
									float num42 = num89 + (float)obj136;
									num71 = num91 + (float)obj137;
									Vector3 vector6 = GillaTeleport.FloorUnder((Vector3)0, num43);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
									object obj138 = 0;
									object obj139 = obj138;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3525 @ X0_v205+E4]");
									bool flag85 = (nint)0 == 0;
									object obj140 = !flag85;
									if (obj140 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag86 = Standing((Vector3)0, (Vector3)(&num62), flag83, out *(Vector3*)apes);
									bool flag87 = !flag86;
									num = (flag83 ? 1 : 0);
									num65 = num71;
									num66 = num42;
									num67 = num43;
									num68 = num71;
									num69 = num42;
									num70 = num43;
									obj123 = (UnityEngine.Object)(&num62);
									if (flag87)
									{
										goto IL_1ec0;
									}
									Vector3 foot2 = ((GillaDoor)obj121).Foot;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
									object obj141 = 0;
									Vector3 v3 = (Vector3)obj141;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3587 @ X0_v213 (UnityEngine.Vector3)+E4]");
									bool flag88 = (nint)0 == 0;
									object obj142 = !flag88;
									if (obj142 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									float num94 = num43 - num62;
									float num95 = num42 - num96;
									Vector3 vector7 = Flat(v3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F8]");
									object obj143 = 0;
									(Vector3, Vector3) tuple2 = ((Vector3)obj143, (Vector3)flag83);
									bool flag89 = list2 == null;
									num = (flag83 ? 1 : 0);
									num10 = num3;
									num11 = num71;
									num12 = num95;
									num2 = num94;
									forward2 = (Vector3)(&obj13);
									num4 = 0f;
									num6 = num96;
									num8 = num62;
									mapEntry = (MapEntry)obj143;
									if (!flag89)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
										object obj144 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C75F0]");
										object obj145 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+1C]");
										object obj146 = (nint)0 + (nint)1;
										object obj147 = obj145;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
										bool flag90 = (nint)0 == 0;
										num = (flag83 ? 1 : 0);
										num10 = num3;
										num11 = num71;
										num12 = num95;
										num2 = num94;
										forward2 = (Vector3)(&obj13);
										num4 = 0f;
										num6 = num96;
										num8 = num62;
										mapEntry = (MapEntry)obj143;
										if (!flag90)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
											num78 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X8_v194+18]");
											obj129 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
											nint num97 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X8_v194+18]");
											bool flag91 = num97 < 0;
											object obj148 = !flag91;
											if (obj148 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
												float num98 = 0f * 24f;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+10]");
												float num99 = 0f + num98;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v54 (System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>)+18]");
												num79 = 0f + 1f;
												_ = 0;
												num75 = 0f;
												num76 = 0f;
												num78 = 0f;
												num = (flag83 ? 1 : 0);
												num65 = num71;
												num66 = num95;
												num67 = num94;
												num68 = 0f;
												num69 = num96;
												num70 = (float)tuple2;
												num71 = num96;
												num42 = num62;
												num43 = 0f;
												obj123 = (UnityEngine.Object)obj143;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ X9_v70+20]");
												object obj149 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3599 @ X8_v195+A8]");
												object obj150 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3572 @ X8_v196+70]");
												num = 0;
												list2.AddWithResize(((Vector3, Vector3))(&tuple7));
												num75 = 0f;
												num76 = 0f;
												num77 = 0f;
												num65 = num71;
												num66 = num95;
												num67 = num94;
												tuple6 = tuple2;
												num68 = 0f;
												num69 = num96;
												num70 = (float)tuple2;
												num71 = num96;
												num42 = num62;
												num43 = 0f;
												obj123 = (UnityEngine.Object)(&tuple7);
												num79 = 0f;
											}
											goto IL_1ec0;
										}
									}
									goto IL_3220;
									IL_1ec0:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
									obj128 = 0;
									obj17 = (UnityEngine.Object)(obj130 + 1);
									UnityEngine.Object obj151 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
									bool flag92 = (nint)obj151 < 0;
									obj25 = !flag92;
									float num100 = (float)obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
									num20 = num100 - 0f;
									flag19 = num20 == 0f;
									UnityEngine.Object obj152 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1596 @ X0_v198+18]");
									flag16 = (nint)obj152 < 0;
									num59 = num75;
									num61 = num76;
									num56 = num77;
									obj116 = obj129;
									num63 = num78;
									tuple4 = tuple6;
									flag83 = (byte)num != 0;
									num11 = num65;
									num12 = num66;
									num2 = num67;
									num4 = num68;
									num6 = num69;
									num8 = num70;
									mapEntry = (MapEntry)(object)obj123;
									obj130 = obj17;
									if (flag16)
									{
										continue;
									}
									goto IL_1fc6;
								}
								goto IL_3212;
							}
						}
					}
				}
			}
			goto IL_1fc6;
			IL_1fc6:
			bool flag93 = obj113 == null;
			object obj153 = !flag93;
			num34 = num61;
			obj24 = obj116;
			num18 = num63;
			num11 = num65;
			num12 = num66;
			num2 = num67;
			num4 = num68;
			num6 = num69;
			num8 = num70;
			mapEntry = (MapEntry)(object)obj123;
			obj117 = obj113;
			num64 = num;
			if (obj153 != null)
			{
				continue;
			}
			goto IL_204e;
			IL_151d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num = 0;
			goto IL_36b6;
			IL_1379:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num = 0;
			goto IL_35b8;
			IL_35b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2846 @ X0_v179 (System.Single)+8]");
			mapEntry = (MapEntry)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2846.m_value (System.Single) (should have been resolved before IL gen)");
			object obj154 = obj155 & 1;
			bool flag94 = obj154 == null;
			num34 = num61;
			obj24 = obj116;
			num18 = num63;
			num11 = num65;
			num12 = num66;
			num2 = num67;
			num4 = num68;
			num6 = num69;
			num8 = num70;
			if (flag94)
			{
				break;
			}
			bool flag95 = obj113 == null;
			num10 = num3;
			num11 = num65;
			num12 = num66;
			num2 = num67;
			forward2 = (Vector3)(&obj13);
			num4 = num68;
			num6 = num69;
			num8 = num70;
			if (flag95)
			{
				goto IL_322e;
			}
			object obj156 = obj113;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2959 @ X8_v165+12E]");
			object obj157 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2959 @ X8_v165+12E]");
			if ((nint)0 == 0)
			{
				goto IL_151d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2959 @ X8_v165+98]");
			float num101 = 0f + 8f;
			bool flag96 = flag16;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3045 @ X10_v58 (System.Single)-8]");
				obj116 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3045 @ X10_v58 (System.Single)-8]");
				bool flag97 = 0 < (nint)obj115;
				object obj25 = !flag97;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3045 @ X10_v58 (System.Single)-8]");
				float num20 = 0f - (float)obj115;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3045 @ X10_v58 (System.Single)-8]");
				if (0 == (nint)obj115)
				{
					break;
				}
				obj157--;
				bool flag98 = (nint)obj157 < 1;
				obj25 = !flag98;
				num20 = (float)obj157 - 1f;
				bool flag19 = num20 == 0f;
				num63 = num101 + 16f;
				flag16 = (nint)obj157 != 1;
				num101 = num63;
				flag96 = flag16;
				if (flag16)
				{
					continue;
				}
				goto IL_151d;
			}
			float num102 = (float)obj156 + ((float*)(nint)num101)->m_value;
			float num103 = num102 + 312f;
			num63 = num101;
			flag16 = flag96;
			goto IL_36b6;
		}
		Vector3 vector8 = (Vector3)(&obj13);
		num13 = vector8.x;
		if (vector8.x == 0f)
		{
			goto IL_3910;
		}
		float value7 = ((float*)(nint)num13)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		num18 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2745 @ X8_v155 (System.Single)+12E]");
		object obj158 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2745 @ X8_v155 (System.Single)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_210e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2745 @ X8_v155 (System.Single)+98]");
		float num104 = 0f + 8f;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2899 @ X10_v42 (System.Single)-8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2899 @ X10_v42 (System.Single)-8]");
			if (0f == ((float*)(nint)num18)->m_value)
			{
				break;
			}
			obj158--;
			num18 = num104 + 16f;
			bool flag99 = (nint)obj158 != 1;
			num104 = num18;
			if (flag99)
			{
				continue;
			}
			goto IL_210e;
		}
		float num105 = value7 + ((float*)(nint)num104)->m_value;
		float num106 = num105 + 312f;
		goto IL_395e;
		IL_3282:
		OutOfMemoryException ex16 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289DAC4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
		Pose result = default;
		return result;
		IL_3258:
		NullReferenceException ex17 = new NullReferenceException();
		goto IL_3266;
		IL_210e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num = 0;
		goto IL_395e;
	}

	private unsafe static bool Standing(Vector3 floor, Vector3 from, bool offWalls, out Vector3 at)
	{
		//IL_066f: Expected native int or pointer, but got VT
		//IL_067c: Expected native int or pointer, but got VT
		//IL_0689: Expected native int or pointer, but got VT
		//IL_06e9: Invalid comparison between F4 and I
		//IL_0605: Expected Obj, but got I4
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected I4, but got Unknown
		//IL_0015: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0a08: Expected Obj, but got I
		//IL_0a18: Expected Obj, but got I
		//IL_0a35: Expected Obj, but got I
		//IL_0a52: Expected Obj, but got I
		//IL_0a77: Expected Obj, but got I
		//IL_0ab7: Expected Obj, but got I4
		//IL_05db: Expected VT, but got I8
		//IL_071a: Expected Obj, but got I
		//IL_0ad5: Expected Obj, but got I
		//IL_0add: Expected F8, but got Obj
		//IL_0aed: Expected F8, but got I
		//IL_0afd: Expected F8, but got I
		//IL_0b27: Expected Obj, but got I4
		//IL_096e: Expected Obj, but got I
		//IL_09ac: Expected Obj, but got I
		//IL_09e2: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I
		//IL_073f: Expected Obj, but got I
		//IL_0b7c: Expected VT, but got I4
		//IL_0b7c: Expected VT, but got I8
		//IL_0b8e: Expected Obj, but got I4
		//IL_063a: Expected I4, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_0361: Invalid comparison between F8 and I
		//IL_015b: Expected Obj, but got I8
		//IL_016b: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_0b4e: Expected Obj, but got I4
		//IL_087e: Expected Obj, but got I
		//IL_088e: Expected Obj, but got I
		//IL_08ab: Expected Obj, but got I
		//IL_08c8: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I
		//IL_092d: Expected Obj, but got I4
		//IL_03d5: Expected VT, but got I4
		//IL_03d5: Expected VT, but got I8
		//IL_03f3: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		//IL_024a: Expected VT, but got I8
		//IL_024a: Expected VT, but got Ref
		//IL_041e: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_0493: Expected VT, but got I4
		//IL_051f: Invalid comparison between F4 and I
		//IL_0774: Expected Obj, but got I
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected Obj, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected Obj, but got Unknown
		//IL_07c5: Expected VT, but got I8
		//IL_07cd: Expected F4, but got Obj
		//IL_07dd: Expected F4, but got I
		//IL_07ed: Expected F4, but got I
		//IL_081b: Expected VT, but got I8
		//IL_0830: Expected F4, but got Obj
		//IL_0840: Expected F4, but got I
		//IL_0858: Expected F4, but got I
		//IL_053b: Expected native int or pointer, but got VT
		//IL_0548: Expected native int or pointer, but got VT
		//IL_0555: Expected native int or pointer, but got VT
		//IL_056c: Expected VT, but got I4
		float num2 = default;
		float num3 = default;
		float num = num2 - num3;
		float num5 = default;
		object obj = default;
		float num4 = num5 - (float)obj;
		float num7 = default;
		float num8 = default;
		float num6 = num7 - num8;
		((Vector3*)(nint)from)->x = num5;
		((Vector3*)(nint)from)->y = num2;
		((Vector3*)(nint)from)->z = num7;
		float num9 = num4 * num4;
		float num10 = num * num;
		float num11 = num9 + num10;
		float num12 = num6 * num6;
		float num13 = num12 + num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
		if (num13 < 0f)
		{
			goto IL_05fc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj2 = 0;
		object obj3 = floor & 1;
		bool flag = obj3 == null;
		ref Vector3 reference = default;
		QueryTriggerInteraction queryTriggerInteraction = (QueryTriggerInteraction)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		Vector3 vector = from;
		float num14 = num5;
		float num15 = num7;
		double num16;
		double num17;
		double num18;
		if (!flag)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v25+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
			object obj6 = 0;
			num16 = (double)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27+4]");
			num17 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27+8]");
			num18 = 0.0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v27+A0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v28+50]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v28+50]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27+18]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				object obj11 = num19 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27+1C]");
				double num20 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				double num21 = num20 * 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27+20]");
				double num22 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
				double num23 = num22 * 0.0;
				float num24 = num5 + (float)obj11;
				float num25 = num2 + (float)num21;
				float num26 = num7 + (float)num23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X21_v11+18]");
				bool flag3 = (nint)0 < (nint)1;
				queryTriggerInteraction = (QueryTriggerInteraction)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				vector = from;
				float num27 = num5;
				if (flag3)
				{
					goto IL_0306;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X21_v11+18]");
				object obj12 = 0 & 0xFFFFFFFFL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v28+50]");
				object obj14 = (nint)0 + (nint)40;
				bool flag5 = default;
				bool flag4 = flag5;
				Vector3 vector2 = from;
				double num29 = default;
				double num28 = num29;
				float num30 = num8;
				float num31 = num3;
				object obj15 = 0;
				float num32 = num7;
				float num33 = num5;
				double num34 = num16;
				double num35 = num17;
				double num36 = num18;
				object obj19 = default;
				IntPtr intPtr = default;
				object obj20 = default;
				while (true)
				{
					bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
					object obj16 = !flag6;
					if (obj16 != null)
					{
						break;
					}
					object obj17 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X0_v44+E4]");
					bool flag7 = (nint)0 == 0;
					object obj18 = !flag7;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag8 = Physics.Raycast((Vector3)(&obj19), (Vector3)4294951163L, out *(RaycastHit*)1, num24, 0, (QueryTriggerInteraction)(nint)intPtr);
					bool flag9 = !flag8;
					num21 = num25;
					double num37 = num24;
					num23 = num26;
					if (!flag9)
					{
						double num38 = 1.0 - (double)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X26_v8-8]");
						num21 = 0.0 * num38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X26_v8-4]");
						num23 = 0.0 * num38;
						num37 = (double)obj14 * num38;
						num34 -= num21;
						num35 -= num23;
						num36 -= num37;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X21_v11+18]");
					obj12 = 0;
					obj15++;
					obj14 += 12;
					object obj21 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X21_v11+18]");
					bool flag10 = (nint)obj21 < 0;
					queryTriggerInteraction = (QueryTriggerInteraction)0;
					flag5 = true;
					vector = (Vector3)4294951163L;
					num8 = (float)obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X26_v8-4]");
					num3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X26_v8-8]");
					num27 = 0f;
					num16 = num34;
					num17 = num35;
					num18 = num36;
					flag4 = true;
					vector2 = (Vector3)4294951163L;
					num28 = 1.0;
					num30 = (float)obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X26_v8-4]");
					num31 = 0f;
					num32 = (float)num37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X26_v8-8]");
					num33 = 0f;
					if (flag10)
					{
						continue;
					}
					goto IL_0306;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			NullReferenceException ex2 = new NullReferenceException();
			return (byte)(int)ex2 != 0;
		}
		goto IL_09f0;
		IL_093b:
		object obj22;
		return (byte)(obj22 & 1) != 0;
		IL_05fc:
		obj22 = 0;
		goto IL_093b;
		IL_09f0:
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v10+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v11+18]");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		object obj26 = num39 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v11+1C]");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		object obj27 = num40 * 0;
		object obj28 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v11+20]");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
		object obj29 = num41 * 0;
		float num42 = num14 + (float)obj26;
		float num43 = num15 + (float)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v7+E4]");
		bool flag11 = (nint)0 == 0;
		object obj30 = !flag11;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Physics.CheckSphere((Vector3)4294951163L, num42, 1, (QueryTriggerInteraction)0))
		{
			goto IL_05fc;
		}
		object obj31 = obj2;
		object obj32 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v16+A0]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v17+18]");
		float num44 = 0f * num42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v17+20]");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		object obj34 = num45 * 0;
		float maxDistance = from.x + num44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X0_v12+E4]");
		bool flag12 = (nint)0 == 0;
		object obj35 = !flag12;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag13 = Physics.Raycast((Vector3)4294951163L, (Vector3)1, maxDistance, 0, queryTriggerInteraction);
		obj22 = (flag13 ? 1 : 0) ^ 1;
		goto IL_093b;
		IL_0306:
		double num46 = num16 * num16;
		double num47 = num17 * num17;
		double num48 = num46 + num47;
		double num49 = num18 * num18;
		double num50 = num48 + num49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		if (num50 > 0.0)
		{
			float num51 = num5 + (float)num16;
			float num52 = num2 + (float)num17;
			float num53 = num7 + (float)num18;
			object obj36 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v35+A0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v36+18]");
			nint num54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj39 = num54 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v36+1C]");
			nint num55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj40 = num55 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v36+20]");
			nint num56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A880]");
			object obj41 = num56 * 0;
			object obj42 = obj38;
			float num57 = num52 + (float)obj40;
			float num58 = num53 + (float)obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v32+E4]");
			bool flag14 = (nint)0 == 0;
			object obj43 = !flag14;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag15 = Physics.Linecast((Vector3)4294951163L, (Vector3)1, 0, queryTriggerInteraction);
			bool flag16 = !flag15;
			object obj44 = !flag16;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v36+18]");
				nint num59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
				object obj45 = num59 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v36+1C]");
				nint num60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
				object obj46 = num60 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v36+20]");
				nint num61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
				object obj47 = num61 * 0;
				float num62 = num51 + (float)obj45;
				float num63 = num52 + (float)obj46;
				float num64 = num53 + (float)obj47;
				Vector3 vector3 = GillaTeleport.FloorUnder((Vector3)0, num62);
				float num65 = num63 - num63;
				float num66 = num64 - num64;
				float num67 = num62 - num62;
				float num68 = num65 * num65;
				float num69 = num67 * num67;
				float num70 = num69 + num68;
				float num71 = num66 * num66;
				float num72 = num71 + num70;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A87C]");
				if (!(num72 < 0f))
				{
					((Vector3*)(nint)from)->x = num62;
					((Vector3*)(nint)from)->y = num63;
					((Vector3*)(nint)from)->z = num64;
					bool flag5 = false;
					vector = (Vector3)1;
					num8 = num58;
					num3 = num57;
					num14 = num62;
					num15 = num64;
					goto IL_09f0;
				}
			}
			goto IL_05fc;
		}
		num14 = from.x;
		num15 = from.z;
		goto IL_09f0;
	}

	private unsafe static Vector3 Clearest(Vector3 at)
	{
		//IL_01bf: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00d1: Expected F8, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I
		//IL_011d: Expected VT, but got I4
		//IL_011d: Expected VT, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_0038: Expected VT, but got I8
		//IL_0038: Expected VT, but got Ref
		//IL_003c: Expected VT, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0277: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+A0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+18]");
		double num = 0.0 * 1.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+1C]");
		double num2 = 0.0 * 1.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+20]");
		double num3 = 0.0 * 1.5;
		object obj4 = default;
		double num4 = (double)obj4 + num;
		object obj5 = default;
		double num5 = (double)obj5 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+48]");
		double num6 = 0.0;
		object obj7 = 0;
		double num7 = -1.0;
		double num8 = num4;
		Vector3 euler = default;
		Vector3 vector2;
		object obj13 = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		double num12 = default;
		bool flag3;
		do
		{
			object obj8 = obj7 * 1110704128;
			double num9 = (double)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC0]");
			double num10 = num9 * 0.0;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v11+A0]");
			object obj10 = 0;
			Vector3 vector = (Quaternion)0 * (Vector3)0;
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj12 = !flag;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			vector2 = (Vector3)Physics.Raycast((Vector3)(&obj13), (Vector3)4294951163L, out *(RaycastHit*)1, (float)num4, 0, queryTriggerInteraction);
			object obj14 = vector2 & 1;
			bool flag2 = obj14 == null;
			object obj15 = !flag2;
			object obj16 = ~obj15;
			double num11 = ((obj16 != null) ? 30.0 : num12);
			if (num11 > num7)
			{
				num7 = num11;
			}
			obj7++;
			flag3 = (nint)obj7 != 8;
			euler = (Vector3)0;
			num6 = 30.0;
			num8 = num10;
			num2 = num5;
		}
		while (flag3);
		return vector2;
	}

	private static Vector3 Flat(Vector3 v)
	{
		//IL_00ce: Expected Obj, but got I
		//IL_00d6: Expected VT, but got Obj
		//IL_00f8: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 * obj2;
		object obj4 = default;
		object obj3 = obj4 * obj4;
		object obj5 = obj + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
		Vector3 result = default;
		if ((nint)obj5 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
			object obj6 = 0;
			result = (Vector3)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v1 (UnityEngine.Vector3)+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF08]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF7C]");
			if (num > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			}
		}
		return result;
	}

	private void GoIn(GillaModeRound round, bool hunter, int number)
	{
		//IL_0015: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I4
		//IL_1225: Expected Obj, but got I4
		//IL_1453: Expected Obj, but got I4
		//IL_0620: Expected Obj, but got I
		//IL_064a: Expected Obj, but got I4
		//IL_0688: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected I4, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_07f6: Expected Obj, but got I
		//IL_0816: Expected Obj, but got I
		//IL_0838: Expected Obj, but got I4
		//IL_120e: Expected Obj, but got I4
		//IL_0873: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I
		//IL_05e5: Expected Obj, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected Obj, but got Unknown
		//IL_08a8: Expected Obj, but got I
		//IL_1295: Expected Obj, but got I4
		//IL_1479: Expected Obj, but got I
		//IL_149b: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got I4
		//IL_0192: Expected Obj, but got I4
		//IL_08e6: Expected Obj, but got I4
		//IL_072f: Expected Obj, but got I
		//IL_0747: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I4
		//IL_035a: Expected Obj, but got I4
		//IL_0ab1: Expected Obj, but got I
		//IL_0adb: Expected Obj, but got I4
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_01b0: Expected Obj, but got I
		//IL_0b06: Expected VT, but got I4
		//IL_0788: Expected Obj, but got I4
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I4
		//IL_0b46: Expected VT, but got I4
		//IL_0989: Expected Obj, but got I4
		//IL_1243: Expected Obj, but got I4
		//IL_0b59: Expected VT, but got I4
		//IL_0b7d: Expected Obj, but got I
		//IL_0baa: Expected Obj, but got I4
		//IL_09a2: Expected Obj, but got I
		//IL_09cc: Expected Obj, but got I4
		//IL_12cd: Expected Obj, but got I4
		//IL_04f7: Expected Obj, but got I4
		//IL_0bed: Expected Obj, but got I4
		//IL_09ff: Expected Obj, but got I4
		//IL_0a18: Expected VT, but got I4
		//IL_14b9: Expected Obj, but got I
		//IL_1251: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Expected Obj, but got Unknown
		//IL_1192: Expected Obj, but got I4
		//IL_119b: Expected Obj, but got I4
		//IL_10c8: Expected Obj, but got I
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Expected Obj, but got Unknown
		//IL_10f5: Expected Obj, but got I
		//IL_1108: Expected Obj, but got I4
		//IL_0c18: Expected Obj, but got I
		//IL_0c32: Expected Obj, but got I4
		//IL_0c3b: Expected Obj, but got I4
		//IL_07d8: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected Obj, but got Unknown
		//IL_04a3: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I4
		//IL_0e2b: Expected Obj, but got I4
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_13b2: Expected Obj, but got I
		//IL_112f: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I4
		//IL_1322: Expected Obj, but got I4
		//IL_13f1: Expected Obj, but got I
		//IL_141b: Expected Obj, but got I4
		//IL_14ee: Expected Obj, but got I
		//IL_1510: Expected Obj, but got I4
		//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc5: Expected Obj, but got Unknown
		//IL_0c9c: Expected Obj, but got I4
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected Obj, but got Unknown
		//IL_0f67: Expected Obj, but got I
		//IL_0f72: Expected Obj, but got I4
		//IL_0cc4: Expected Obj, but got I4
		//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce8: Expected Obj, but got Unknown
		//IL_0d0a: Expected Obj, but got I4
		//IL_0eef: Expected Obj, but got I4
		//IL_0d45: Expected Obj, but got I
		//IL_0d5f: Expected Obj, but got I4
		//IL_0d68: Expected Obj, but got I4
		//IL_0d78: Expected Obj, but got I
		//IL_0d81: Expected Obj, but got I4
		//IL_0fab: Expected Obj, but got I
		//IL_0fbb: Expected Obj, but got I
		//IL_1008: Expected Obj, but got I4
		//IL_1016: Expected Obj, but got I4
		//IL_1036: Unknown result type (might be due to invalid IL or missing references)
		//IL_103b: Expected Obj, but got Unknown
		//IL_115e: Expected Obj, but got I
		//IL_135a: Expected Obj, but got I4
		//IL_152e: Expected Obj, but got I
		//IL_1085: Expected Obj, but got I
		//IL_1095: Expected Obj, but got I
		MapEntry[] array = maps;
		object obj;
		object obj2;
		UnityEngine.Object obj3;
		MapEntry mapEntry;
		object obj14;
		bool flag10;
		GillaModeRound gillaModeRound2;
		GillaModeRound gillaModeRound;
		bool flag9;
		if (maps != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			obj = 0;
			if (array.Length == 0)
			{
				obj2 = 1;
				obj3 = null;
				gillaModeRound = round;
				mapEntry = null;
				goto IL_121c;
			}
			if ((object)round != null)
			{
				byte map = round.Map;
				MapEntry[] array2 = maps;
				if (maps != null)
				{
					int num = map & 0xFF;
					int num2 = array2.Length - 1;
					object obj4 = num - num2;
					bool flag = (nint)obj4 < 0;
					int num3 = num ^ num2;
					int num4 = num ^ obj4;
					int num5 = num3 & num4;
					bool flag2 = num5 < 0;
					bool flag3 = flag == flag2;
					object obj5 = !flag3;
					object obj6 = ~obj5;
					if (obj6 == null)
					{
						num2 = num;
					}
					bool flag4 = num2 < array.Length;
					object obj7 = !flag4;
					if (obj7 != null)
					{
						goto IL_11c3;
					}
					object obj8 = maps + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v97+20]");
					mapEntry = (MapEntry)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v97+20]");
					if ((nint)0 != 0)
					{
						bool flag5 = !hunter;
						object obj9 = !flag5;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2410]");
							object obj10 = 0;
							if (mapEntry.label == (string)obj10)
							{
								Transform[] apeSpawns = mapEntry.apeSpawns;
								if (mapEntry.apeSpawns == null)
								{
									goto IL_11b5;
								}
								if (apeSpawns.Length != 0)
								{
									object obj11 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v165+E4]");
									bool flag6 = (nint)0 == 0;
									object obj12 = !flag6;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag7 = apeSpawns[0] != null;
									obj2 = (flag7 ? 1 : 0) ^ 1;
									bool flag8 = !hunter;
									object obj13 = !flag8;
									flag9 = false;
									gillaModeRound = null;
									if (obj13 != null)
									{
										goto IL_0375;
									}
									obj14 = obj2;
									flag10 = false;
									gillaModeRound2 = null;
									goto IL_03e4;
								}
							}
							bool flag11 = !hunter;
							object obj15 = !flag11;
							obj2 = 1;
							flag9 = false;
							gillaModeRound = (GillaModeRound)obj10;
							obj14 = 1;
							flag10 = false;
							gillaModeRound2 = (GillaModeRound)obj10;
							if (obj15 != null)
							{
								goto IL_0375;
							}
							goto IL_03e4;
						}
					}
					if (mapEntry != null)
					{
						bool flag12 = !hunter;
						obj2 = 1;
						flag9 = hunter;
						gillaModeRound = null;
						obj14 = 1;
						flag10 = hunter;
						gillaModeRound2 = null;
						if (!flag12)
						{
							goto IL_0375;
						}
						goto IL_03e4;
					}
					obj2 = 1;
					obj3 = null;
					gillaModeRound = null;
					goto IL_121c;
				}
			}
		}
		goto IL_11b5;
		IL_1429:
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X0_v7+E4]");
		bool flag13 = (nint)0 == 0;
		object obj17 = !flag13;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte b = default;
		object obj39;
		object obj44;
		Vector3 facing;
		object obj51;
		object obj52;
		int apes;
		int num7;
		if (obj3 == null)
		{
			if ((object)round != null)
			{
				byte map2 = round.Map;
				string text = b.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2418]");
				object obj18 = 0;
				string message = (string)obj18 + text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj19 = 0;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v91+E4]");
				bool flag14 = (nint)0 == 0;
				object obj21 = !flag14;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj22 = 0;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v12+E4]");
			bool flag15 = (nint)0 == 0;
			object obj24 = !flag15;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isMonster = MonsterPlayer.IsMonster;
			bool flag16 = !isMonster;
			object obj25 = 0;
			int num6 = 0;
			if (!flag16)
			{
				object obj26 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v117+E4]");
				bool flag17 = (nint)0 == 0;
				object obj27 = !flag17;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj28 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X0_v121+E4]");
				bool flag18 = (nint)0 == 0;
				object obj29 = !flag18;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj28 = obj22;
				}
				object obj30 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X0_v121+A0]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v78+E4]");
				bool flag19 = (nint)0 == 0;
				object obj32 = !flag19;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag20 = (UnityEngine.Object)obj31 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				object obj33 = 0;
				bool flag21 = !flag20;
				obj25 = 0;
				num6 = 0;
				if (!flag21)
				{
					object obj34 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X0_v125+E4]");
					bool flag22 = (nint)0 == 0;
					object obj35 = !flag22;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj36 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X0_v129+E4]");
					bool flag23 = (nint)0 == 0;
					object obj37 = !flag23;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj36 = obj33;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X0_v129+A0]");
					object obj38 = 0;
					if (obj38 == null)
					{
						goto IL_11b5;
					}
					((MonsterPlayer)obj38).Become(0);
					obj25 = 0;
					num6 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
			obj39 = 0;
			object obj40 = obj;
			object obj41 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v11+A0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X0_v17+E4]");
			bool flag24 = (nint)0 == 0;
			object obj43 = !flag24;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag25 = (UnityEngine.Object)obj42 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			obj44 = 0;
			if (flag25)
			{
				object obj45 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v71+A0]");
				object obj46 = 0;
				KillCam killCam = (KillCam)obj46;
				if (obj46 == null)
				{
					goto IL_11b5;
				}
				bool flag26 = (byte)(~(killCam.Busy__BackingField ? 1u : 0u)) != 0;
				object obj47 = !flag26;
				if (obj47 == null)
				{
					((KillCam)obj46).Heal();
				}
			}
			if (number >= 1 && hunter)
			{
				if ((object)round != null)
				{
					byte startApes = round.StartApes;
					apes = startApes & 0xFF;
					Pose pose = ((GillaMapVote)startApes).MonsterStart(mapEntry, number, apes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23E8]");
					object obj48 = 0;
					object obj49 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v110+E4]");
					bool flag27 = (nint)0 == 0;
					object obj50 = !flag27;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Pose pose2 = default;
					Vector3 forward = pose2.forward;
					obj51 = 0;
					object obj53 = default;
					obj52 = obj53;
					num7 = number;
					facing = (Vector3)0;
					goto IL_0b4b;
				}
			}
			else
			{
				object obj54 = obj2 & 1;
				if (obj54 != null)
				{
					if ((object)obj3 != null)
					{
						Vector3 position = ((Transform)obj3).position;
						goto IL_0b0f;
					}
				}
				else if ((object)obj3 != null)
				{
					Vector3 position2 = ((Transform)obj3).position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
					object obj55 = 0;
					object obj56 = obj55;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X0_v100+E4]");
					bool flag28 = (nint)0 == 0;
					object obj57 = !flag28;
					if (obj57 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Vector3 vector = Beside((Vector3)number, 0);
					goto IL_0b0f;
				}
			}
		}
		goto IL_11b5;
		IL_13c8:
		string text2;
		string text3;
		string text4;
		string text5;
		string message2 = text2 + text3 + text4 + text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj58 = 0;
		object obj59 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v21+E4]");
		bool flag29 = (nint)0 == 0;
		object obj60 = !flag29;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message2);
		return;
		IL_03e4:
		Transform[] array3 = mapEntry.apeSpawns;
		object obj61 = obj14 & 1;
		object obj62;
		if (obj61 != null)
		{
			if (mapEntry.apeSpawns == null)
			{
				goto IL_11b5;
			}
			if (array3.Length == 0)
			{
				obj62 = 0;
				obj2 = 1;
				obj3 = null;
				flag9 = flag10;
				gillaModeRound = gillaModeRound2;
				goto IL_1429;
			}
			int num8 = number / array3.Length;
			object obj63 = num8 * array3.Length;
			object obj64 = number - obj63;
			bool flag30 = (nint)obj64 < array3.Length;
			object obj65 = !flag30;
			if (obj65 != null)
			{
				goto IL_11c3;
			}
			array3 = (Transform[])(object)((object)array3 + obj64);
			obj2 = 1;
		}
		else
		{
			if (mapEntry.apeSpawns == null)
			{
				goto IL_11b5;
			}
			obj2 = 0;
		}
		object obj66 = array3 + 32;
		flag9 = flag10;
		gillaModeRound = gillaModeRound2;
		goto IL_1232;
		IL_0b0f:
		Vector3 forward2 = ((Transform)obj3).forward;
		object obj67 = default;
		obj51 = obj67;
		object obj68 = default;
		obj52 = obj68;
		apes = number;
		num7 = 0;
		facing = (Vector3)0;
		goto IL_0b4b;
		IL_0b4b:
		bool flag31 = GillaTeleport.To((Vector3)0, facing);
		object obj69 = obj39;
		object obj70 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X8_v15+A0]");
		object obj71 = 0;
		inHunt = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v25+E4]");
		bool flag32 = (nint)0 == 0;
		object obj72 = !flag32;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag33 = (UnityEngine.Object)obj71 != null;
		bool flag34 = !flag33;
		object obj73 = 0;
		UnityEngine.Object obj74 = null;
		if (flag34)
		{
			goto IL_0de4;
		}
		object obj75 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v57+A0]");
		object obj76 = 0;
		bool flag35 = !hunter;
		object obj77 = !flag35;
		object obj78 = 0;
		object obj81;
		object obj84;
		if (obj77 == null)
		{
			if ((object)round == null)
			{
				goto IL_11b5;
			}
			byte mode = round.Mode;
			int num9 = mode & 0xFF;
			bool flag36 = num9 != 1;
			obj78 = 0;
			if (!flag36)
			{
				bool flag37 = obj62 == null;
				object obj79 = !flag37;
				if (obj79 != null)
				{
					goto IL_11b5;
				}
				object obj80 = obj;
				obj81 = mapEntry + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X0_v89+E4]");
				bool flag38 = (nint)0 == 0;
				object obj82 = !flag38;
				if (obj82 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag39 = (UnityEngine.Object)obj81 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				obj44 = 0;
				bool flag40 = !flag39;
				object obj83 = !flag40;
				obj78 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
				obj84 = 0;
				obj73 = 0;
				if (obj83 != null)
				{
					goto IL_12db;
				}
			}
		}
		obj81 = this + 72;
		obj84 = obj44;
		obj73 = obj78;
		goto IL_12db;
		IL_11b5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_11c3;
		IL_12db:
		if (obj76 != null)
		{
			obj74 = (UnityEngine.Object)obj81;
			object obj85 = obj76 + 176;
			obj85 = obj81;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj44 = obj84;
			goto IL_0de4;
		}
		goto IL_11b5;
		IL_0de4:
		int num12 = default;
		string text8;
		if (hunter)
		{
			object obj86 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X0_v42+E4]");
			bool flag41 = (nint)0 == 0;
			object obj87 = !flag41;
			if (obj87 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj88 = obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v46+E4]");
			bool flag42 = (nint)0 == 0;
			object obj89 = !flag42;
			if (obj89 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj88 = obj44;
			}
			object obj90 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X0_v46+A0]");
			object obj91 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v36+E4]");
			bool flag43 = (nint)0 == 0;
			object obj92 = !flag43;
			if (obj92 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj91 != null)
			{
				int num10 = MonsterNumber();
				if (num10 >= 1)
				{
					object obj93 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X0_v63+E4]");
					bool flag44 = (nint)0 == 0;
					object obj94 = !flag44;
					if (obj94 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj95 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1147 @ X0_v67+E4]");
					bool flag45 = (nint)0 == 0;
					object obj96 = !flag45;
					if (obj96 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj95 = obj44;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1147 @ X0_v67+A0]");
					object obj97 = 0;
					if (obj97 == null)
					{
						goto IL_11b5;
					}
					((MonsterPlayer)obj97).Become(num10);
				}
			}
			object obj98 = mapEntry + 16;
			bool flag46 = obj62 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4F8]");
			object obj99 = 0;
			object obj100 = !flag46;
			object obj101 = ~obj100;
			if (obj101 != null)
			{
				obj99 = obj98;
			}
			if ((object)round == null)
			{
				goto IL_11b5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23F0]");
			object obj102 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2400]");
			object obj103 = 0;
			text3 = (string)obj99;
			text2 = (string)obj102;
			text4 = (string)obj103;
			byte startMonsters = round.StartMonsters;
			int num11 = startMonsters & 0xFF;
			bool flag47 = num11 < 1;
			object obj104 = !flag47;
			object obj105 = num11 - 1;
			bool flag48 = obj105 == null;
			object obj106 = ~obj104;
			object obj107 = obj106 | flag48;
			if (obj107 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB7C8]");
				object obj108 = 0;
				text5 = (string)obj108;
				goto IL_13c8;
			}
			string text6 = num12.ToString();
			byte startMonsters2 = round.StartMonsters;
			string text7 = b.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23F8]");
			object obj109 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA1D0]");
			object obj110 = 0;
			text8 = (string)obj109 + text6 + (string)obj110 + text7;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23F0]");
			object obj111 = 0;
			object obj112 = mapEntry + 16;
			bool flag49 = obj62 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2400]");
			object obj113 = 0;
			text2 = (string)obj111;
			object obj114 = !flag49;
			object obj115 = ~obj114;
			object obj116;
			if (obj115 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4F8]");
				obj116 = 0;
			}
			else
			{
				obj116 = obj112;
			}
			text3 = (string)obj116;
			text4 = (string)obj113;
			string text9 = num12.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2408]");
			object obj117 = 0;
			text8 = (string)obj117 + text9;
		}
		text5 = text8;
		goto IL_13c8;
		IL_11c3:
		throw new IndexOutOfRangeException();
		IL_0375:
		obj66 = mapEntry + 48;
		goto IL_1232;
		IL_1232:
		obj3 = (UnityEngine.Object)obj66;
		obj62 = 0;
		goto IL_1429;
		IL_121c:
		obj62 = 1;
		flag9 = hunter;
		goto IL_1429;
	}

	private void ComeBack()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0627: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_065f: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I4
		//IL_06f5: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I
		//IL_0437: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_036a: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_06cf: Expected Obj, but got I4
		//IL_0697: Expected Obj, but got I4
		//IL_0752: Expected Obj, but got I
		//IL_0762: Expected Obj, but got I
		//IL_0784: Expected Obj, but got I4
		//IL_0735: Expected Obj, but got I
		//IL_0491: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I4
		//IL_04dd: Expected Obj, but got I4
		//IL_05f3: Expected VT, but got I4
		//IL_05f3: Expected VT, but got I4
		//IL_050c: Expected Obj, but got I
		//IL_053f: Expected Obj, but got I
		//IL_0553: Expected Obj, but got I
		//IL_057d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj4 = 0;
		bool isMonster = MonsterPlayer.IsMonster;
		bool flag2 = !isMonster;
		IntPtr intPtr = default;
		int num = (int)(nint)intPtr;
		if (!flag2)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v67+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v71+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj;
			}
			object obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v71+A0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v45+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag6 = (UnityEngine.Object)obj10 != null;
			bool flag7 = !flag6;
			object obj12 = 0;
			num = 0;
			if (!flag7)
			{
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v75+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v79+E4]");
				bool flag9 = (nint)0 == 0;
				object obj16 = !flag9;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj15 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v79+A0]");
				object obj17 = 0;
				((MonsterPlayer)obj17).Become(0);
				obj12 = 0;
				num = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj18 = 0;
		object obj19 = obj4;
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v6+A0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = (UnityEngine.Object)obj21 != null;
		object obj23 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v8+A0]");
		object obj24 = 0;
		UnityEngine.Object obj25 = (UnityEngine.Object)obj24;
		if (flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X20_v5 (UnityEngine.Object)+A9]");
			bool flag12 = (nint)0 == 0;
			object obj26 = !flag12;
			if (obj26 != null)
			{
				return;
			}
		}
		object obj27 = obj4;
		inHunt = false;
		infected = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v14+E4]");
		bool flag13 = (nint)0 == 0;
		object obj28 = !flag13;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = obj25 != null;
		bool flag15 = !flag14;
		UnityEngine.Object obj29 = null;
		if (!flag15)
		{
			object obj30 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v36+A0]");
			object obj31 = 0;
			((KillCam)obj31).Heal();
			object obj32 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v38+A0]");
			object obj33 = 0;
			object obj34 = obj33 + 176;
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj29 = null;
		}
		object obj35 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v19+E4]");
		bool flag16 = (nint)0 == 0;
		object obj36 = !flag16;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = lobby == null;
		bool flag18 = !flag17;
		object obj37 = !flag18;
		if (obj37 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj38 = 0;
		object obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v23+E4]");
		bool flag19 = (nint)0 == 0;
		object obj40 = !flag19;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj41 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v27+E4]");
		bool flag20 = (nint)0 == 0;
		object obj42 = !flag20;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj41 = obj38;
		}
		object obj43 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v27+A0]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v5+8]");
		UnityEngine.Object obj45 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v19+E4]");
		bool flag21 = (nint)0 == 0;
		object obj46 = !flag21;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v5+8]");
		if ((UnityEngine.Object)0 != null)
		{
			object obj47 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v40+E4]");
			bool flag22 = (nint)0 == 0;
			object obj48 = !flag22;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X20_v11 (UnityEngine.Object)+B0]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X20_v11 (UnityEngine.Object)+B0]");
				PlayerRef localPlayer = ((NetworkRunner)0).LocalPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj49 = 0;
				object obj50 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v25+E4]");
				bool flag23 = (nint)0 == 0;
				object obj51 = !flag23;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRef playerRef = default;
				int playerId = playerRef.PlayerId;
			}
		}
		Vector3 position = lobby.position;
		Vector3 right = lobby.right;
		Vector3 forward = lobby.forward;
		bool flag24 = GillaTeleport.To((Vector3)0, (Vector3)0);
	}

	private unsafe void OnDying()
	{
		//IL_0010: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_036a: Expected Obj, but got I4
		//IL_0549: Expected VT, but got Ref
		//IL_03dc: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		if (~(inHunt ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag2 = (byte)(~(outOfIt ? 1u : 0u)) != 0;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			return;
		}
		bool flag3 = (byte)(~(infected ? 1u : 0u)) != 0;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj6 = 0;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)current == (UnityEngine.Object)null;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 != null || !current.Live)
		{
			return;
		}
		byte phase = current.Phase;
		int num = phase & 0xFF;
		if (num != 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = Hunts(current);
		bool flag9 = !flag8;
		object obj13 = !flag9;
		if (obj13 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v21+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F0765C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj17 = 0;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v19+E4]");
		bool flag11 = (nint)0 == 0;
		object obj19 = !flag11;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC04B8");
		object obj20 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v20+E4]");
		bool flag12 = (nint)0 == 0;
		object obj21 = !flag12;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj22 = default;
		if (obj22 != null)
		{
			object obj23 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v35+E4]");
			bool flag13 = (nint)0 == 0;
			object obj24 = !flag13;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj25 = default;
			if (obj25 != null)
			{
				object obj26 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v39+E4]");
				bool flag14 = (nint)0 == 0;
				object obj27 = !flag14;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v27 (UnityEngine.Object)+68]");
				if ((UnityEngine.Object)0 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v27 (UnityEngine.Object)+68]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v27+20]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v27+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v28+18]");
						if ((nint)0 != 0)
						{
							((NetworkApe)obj22).LeaveBody();
						}
					}
				}
			}
		}
		byte mode = current.Mode;
		int num2 = mode & 0xFF;
		if (num2 == 1)
		{
			infected = (byte)num2 != 0;
		}
		else
		{
			outOfIt = true;
		}
		object obj30 = default;
		current.RPC_Out((RpcInfo)(&obj30));
	}

	private unsafe void OnDied()
	{
		//IL_0010: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I4
		//IL_02b1: Expected VT, but got Ref
		//IL_0190: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0284: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GillaModeRound current = GillaModeRound.Current;
		if (~(inHunt ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag2 = (byte)(~(outOfIt ? 1u : 0u)) != 0;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = (UnityEngine.Object)current == (UnityEngine.Object)null;
		bool flag5 = !flag4;
		object obj8 = !flag5;
		if (obj8 != null || !current.Live)
		{
			return;
		}
		byte phase = current.Phase;
		int num = phase & 0xFF;
		if (num != 1)
		{
			return;
		}
		bool flag6 = (byte)(~(infected ? 1u : 0u)) != 0;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
			object obj10 = 0;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v23+E4]");
			bool flag7 = (nint)0 == 0;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag8 = Hunts(current);
			bool flag9 = !flag8;
			object obj13 = !flag9;
			if (obj13 != null)
			{
				return;
			}
		}
		byte mode = current.Mode;
		int num2 = mode & 0xFF;
		if (num2 == 1)
		{
			bool flag10 = (byte)(~(infected ? 1u : 0u)) != 0;
			object obj14 = !flag10;
			if (obj14 == null)
			{
				infected = true;
				object obj15 = default;
				current.RPC_Out((RpcInfo)(&obj15));
			}
			Infect(current);
		}
		else
		{
			outOfIt = true;
			object obj16 = default;
			current.RPC_Out((RpcInfo)(&obj16));
		}
	}

	private void Infect(GillaModeRound round)
	{
		//IL_0156: Expected Obj, but got I4
		//IL_07a2: Expected Obj, but got I
		//IL_07b2: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I
		//IL_07f4: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0228: Expected VT, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_069c: Expected Obj, but got I
		//IL_06ac: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got I
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected I4, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I4
		//IL_02b4: Expected VT, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0784: Expected Obj, but got I4
		//IL_08a7: Expected Obj, but got I
		//IL_08e6: Expected Obj, but got I4
		//IL_0851: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I
		//IL_090c: Expected Obj, but got I
		//IL_092e: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0641: Expected Obj, but got I4
		//IL_045c: Expected VT, but got I4
		//IL_0889: Expected Obj, but got I4
		//IL_094c: Expected Obj, but got I
		//IL_0472: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I4
		//IL_03fc: Expected Obj, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected VT, but got Unknown
		//IL_0515: Expected Obj, but got I
		//IL_0528: Expected VT, but got I4
		//IL_0528: Expected VT, but got I4
		//IL_0535: Expected Obj, but got I4
		//IL_053e: Expected VT, but got I4
		MapEntry[] array = maps;
		infected = false;
		becameMonster = false;
		object obj;
		if (maps != null)
		{
			if (array.Length == 0)
			{
				obj = 0;
				GillaModeRound gillaModeRound = round;
				goto IL_0792;
			}
			if ((object)round != null)
			{
				byte map = round.Map;
				MapEntry[] array2 = maps;
				if (maps != null)
				{
					int num = map & 0xFF;
					int num2 = array2.Length - 1;
					object obj2 = num - num2;
					bool flag = (nint)obj2 < 0;
					int num3 = num ^ num2;
					int num4 = num ^ obj2;
					int num5 = num3 & num4;
					bool flag2 = num5 < 0;
					bool flag3 = flag == flag2;
					object obj3 = !flag3;
					object obj4 = ~obj3;
					if (obj4 == null)
					{
						num2 = num;
					}
					bool flag4 = num2 < array.Length;
					object obj5 = !flag4;
					if (obj5 != null)
					{
						goto IL_0723;
					}
					object obj6 = maps + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v48+20]");
					obj = 0;
					GillaModeRound gillaModeRound = null;
					goto IL_0792;
				}
			}
		}
		goto IL_0715;
		IL_0792:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj8 = 0;
		object obj9 = obj7;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v7+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = (UnityEngine.Object)obj11 != null;
		bool flag7 = !flag6;
		UnityEngine.Object obj13 = null;
		if (!flag7)
		{
			object obj14 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v42+A0]");
			object obj15 = 0;
			if (obj15 == null)
			{
				goto IL_0715;
			}
			obj13 = lobby;
			object obj16 = obj15 + 176;
			obj16 = lobby;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		bool flag8 = obj == null;
		object obj17 = 0;
		Vector3 vector = (Vector3)obj13;
		if (!flag8)
		{
			object obj18 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v50+E4]");
			bool flag9 = (nint)0 == 0;
			object obj19 = !flag9;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+30]");
			bool flag10 = (UnityEngine.Object)0 != null;
			bool flag11 = !flag10;
			obj17 = 0;
			vector = (Vector3)0;
			if (!flag11)
			{
				if ((object)round != null)
				{
					object obj20 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v54+E4]");
					bool flag12 = (nint)0 == 0;
					object obj21 = !flag12;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Vector3 spawn;
					if ((UnityEngine.Object)((SimulationBehaviour)round)._runner != (UnityEngine.Object)null)
					{
						if ((object)((SimulationBehaviour)round)._runner == null)
						{
							goto IL_0715;
						}
						PlayerRef localPlayer = ((SimulationBehaviour)round)._runner.LocalPlayer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
						object obj22 = 0;
						object obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v35+E4]");
						bool flag13 = (nint)0 == 0;
						object obj24 = !flag13;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						PlayerRef playerRef = default;
						int playerId = playerRef.PlayerId;
						object obj25 = playerId * 715827883;
						object obj26 = obj25 >> 63;
						object obj27 = obj25 >> 33;
						object obj28 = obj27 + obj26;
						object obj29 = obj28 * 12;
						object obj30 = playerId - obj29;
						spawn = (Vector3)(obj30 + 1);
					}
					else
					{
						spawn = (Vector3)1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+30]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+30]");
						Vector3 position = ((Transform)0).position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
						object obj31 = 0;
						object obj32 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v61+E4]");
						bool flag14 = (nint)0 == 0;
						object obj33 = !flag14;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Vector3 vector2 = Beside(spawn, 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+30]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X22_v3+30]");
							Vector3 forward = ((Transform)0).forward;
							bool flag15 = GillaTeleport.To((Vector3)0, (Vector3)0);
							obj17 = 0;
							vector = (Vector3)0;
							goto IL_0543;
						}
					}
				}
				goto IL_0715;
			}
		}
		goto IL_0543;
		IL_0715:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0723;
		IL_0543:
		int num6 = MonsterNumber();
		if (num6 >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F68]");
			object obj34 = 0;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v22+E4]");
			bool flag16 = (nint)0 == 0;
			object obj36 = !flag16;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj37 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v26+E4]");
			bool flag17 = (nint)0 == 0;
			object obj38 = !flag17;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj37 = obj34;
			}
			object obj39 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v26+A0]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v19+E4]");
			bool flag18 = (nint)0 == 0;
			object obj41 = !flag18;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj40 != null)
			{
				object obj42 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v30+E4]");
				bool flag19 = (nint)0 == 0;
				object obj43 = !flag19;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj44 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v34+E4]");
				bool flag20 = (nint)0 == 0;
				object obj45 = !flag20;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj44 = obj34;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v34+A0]");
				object obj46 = 0;
				if (obj46 == null)
				{
					goto IL_0715;
				}
				((MonsterPlayer)obj46).Become(num6);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2438]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF4F8]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2440]");
		object obj49 = 0;
		object obj50 = obj + 16;
		if (obj != null)
		{
			obj48 = obj50;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj51 = 0;
		string message = (string)obj47 + (string)obj48 + (string)obj49;
		object obj52 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v14+E4]");
		bool flag21 = (nint)0 == 0;
		object obj53 = !flag21;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		return;
		IL_0723:
		throw new IndexOutOfRangeException();
	}

	private static bool Hunts(GillaModeRound round)
	{
		//IL_00a2: Expected I4, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected I4, but got Unknown
		if ((object)round != null)
		{
			NetworkDictionary<PlayerRef, byte> players = round.Players;
			if ((object)((SimulationBehaviour)round)._runner != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
				object obj = 0;
				PlayerRef localPlayer = ((SimulationBehaviour)round)._runner.LocalPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
				object obj3 = default;
				object obj2 = obj3 - 3;
				bool flag = obj2 == null;
				object obj4 = default;
				return (byte)((obj4 & flag) ? 1 : 0) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Announce(GillaModeRound round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_05a6: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_012f: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_020d: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I4
		//IL_03fd: Expected Obj, but got I4
		//IL_026e: Expected VT, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_05ee: Expected Obj, but got I
		//IL_0618: Expected Obj, but got I4
		//IL_055c: Expected VT, but got I4
		//IL_0435: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		Camera main = Camera.main;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Component component;
		if (main != null)
		{
			Camera main2 = Camera.main;
			bool flag2 = (object)main2 == null;
			object obj4 = !flag2;
			component = main2;
			if (obj4 == null)
			{
				goto IL_055e;
			}
		}
		else
		{
			component = this;
		}
		Transform transform = component.transform;
		AudioClip[] array2 = default;
		float pitchMax;
		float pitchMin;
		float volume;
		if ((object)transform != null)
		{
			Vector3 position = transform.position;
			if ((object)round != null)
			{
				byte phase = round.Phase;
				int num = phase & 0xFF;
				bool flag3 = num != 1;
				object obj5 = 0;
				float num2 = default;
				float num3 = default;
				float num4 = default;
				if (!flag3)
				{
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v41+E4]");
					bool flag4 = (nint)0 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag5 = startSound != null;
					bool flag6 = !flag5;
					obj5 = 0;
					if (!flag6)
					{
						bool flag7 = (byte)(~(inHunt ? 1u : 0u)) != 0;
						obj5 = 0;
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							AudioClip[] array = default;
							if (array == null)
							{
								goto IL_055e;
							}
							object obj9 = array + 32;
							obj9 = startSound;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
							object obj10 = 0;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v50+E4]");
							bool flag8 = (nint)0 == 0;
							object obj12 = !flag8;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Sfx.Play(array, (Vector3)0, num2, num3, num4);
							obj5 = 0;
						}
					}
				}
				byte phase2 = round.Phase;
				int num5 = phase2 & 0xFF;
				if (num5 != 2)
				{
					return;
				}
				byte winner = round.Winner;
				int num6 = winner & 0xFF;
				if (num6 == 1)
				{
					return;
				}
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v18+E4]");
				bool flag9 = (nint)0 == 0;
				object obj14 = !flag9;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!(apesWinSound != null))
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4340]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				if (array2 != null)
				{
					UnityEngine.Object obj16 = apesWinSound;
					object obj17 = array2 + 32;
					obj17 = apesWinSound;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag10 = (byte)(~(inHunt ? 1u : 0u)) != 0;
					object obj18 = !flag10;
					pitchMax = num4;
					pitchMin = num3;
					volume = num2;
					object obj19 = 0;
					if (obj18 == null)
					{
						object obj20 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v32+E4]");
						bool flag11 = (nint)0 == 0;
						object obj21 = !flag11;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag12 = board == null;
						bool flag13 = !flag12;
						object obj22 = !flag13;
						pitchMax = num4;
						pitchMin = num3;
						volume = num2;
						obj19 = 0;
						obj16 = null;
						if (obj22 == null)
						{
							if ((object)board != null)
							{
								Transform transform2 = board.transform;
								if ((object)transform2 != null)
								{
									Vector3 position2 = transform2.position;
									pitchMax = num4;
									pitchMin = num3;
									volume = num2;
									obj19 = 0;
									obj16 = null;
									goto IL_05de;
								}
							}
							goto IL_055e;
						}
					}
					goto IL_05de;
				}
			}
		}
		goto IL_055e;
		IL_055e:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_05de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D40]");
		object obj23 = 0;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v28+E4]");
		bool flag14 = (nint)0 == 0;
		object obj25 = !flag14;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sfx.Play(array2, (Vector3)0, volume, pitchMin, pitchMax);
	}

	private static int MonsterIndex(GillaModeRound round, PlayerRef me)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0467: Expected I4, but got Obj
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_0167: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I4
		//IL_04ac: Expected Obj, but got I
		//IL_04bc: Expected Obj, but got I
		//IL_04de: Expected Obj, but got I4
		//IL_04e7: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I4
		//IL_0586: Expected Obj, but got I
		//IL_0596: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I4
		//IL_020e: Expected Obj, but got I4
		//IL_031a: Expected Obj, but got I
		//IL_033b: Expected Obj, but got I
		//IL_0505: Expected Obj, but got I
		//IL_051f: Expected Obj, but got I
		//IL_0530: Expected I, but got Obj
		//IL_054e: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_0377: Expected Obj, but got I4
		//IL_02d5: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I
		//IL_05d6: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0601: Expected I, but got Obj
		//IL_061f: Expected Obj, but got I
		//IL_063a: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = round;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj4 = 0;
				PlayerRef monster = ((GillaModeRound)obj3).Monster;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (monster == me)
				{
					return 0;
				}
				if (obj3 != null)
				{
					NetworkDictionary<PlayerRef, byte> players = ((GillaModeRound)obj3).Players;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23E0]");
					object obj9 = 0;
					Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
					func._002Ector(obj2, (IntPtr)obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8360]");
					object obj10 = 0;
					IEnumerable<KeyValuePair<PlayerRef, byte>> source2 = default;
					IEnumerable<KeyValuePair<PlayerRef, byte>> source = Enumerable.Where(source2, func);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2240]");
					object obj11 = 0;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v17+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v17+A0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X9_v13+20]");
					Func<KeyValuePair<PlayerRef, byte>, int> selector = (Func<KeyValuePair<PlayerRef, byte>, int>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X9_v13+20]");
					bool flag3 = (nint)0 == 0;
					object obj15 = !flag3;
					object obj16 = 0;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v17+E4]");
						bool flag4 = (nint)0 == 0;
						object obj17 = !flag4;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj18 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v46+A0]");
							obj14 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8368]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23D0]");
						object obj20 = 0;
						Func<KeyValuePair<PlayerRef, byte>, int> func2 = default;
						func2._002Ector(obj14, (IntPtr)obj20);
						object obj21 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v45+A0]");
						object obj22 = (nint)0 + (nint)32;
						obj22 = func2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj16 = 0;
						selector = func2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8358]");
					object obj23 = 0;
					IEnumerable<int> source3 = Enumerable.Select(source, selector);
					object obj24 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v22+E4]");
					bool flag5 = (nint)0 == 0;
					object obj25 = !flag5;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj24 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v22+A0]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X9_v11+28]");
					Func<int, int> keySelector = (Func<int, int>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X9_v11+28]");
					bool flag6 = (nint)0 == 0;
					object obj27 = !flag6;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v22+E4]");
						bool flag7 = (nint)0 == 0;
						object obj28 = !flag7;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object obj29 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v38+A0]");
							obj26 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8370]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23D8]");
						object obj31 = 0;
						Func<int, int> func3 = default;
						func3._002Ector(obj26, (IntPtr)obj31);
						object obj32 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v37+A0]");
						object obj33 = (nint)0 + (nint)40;
						obj33 = func3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						obj16 = 0;
						keySelector = func3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8350]");
					object obj34 = 0;
					IOrderedEnumerable<int> source4 = Enumerable.OrderBy(source3, keySelector);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E20]");
					object obj35 = 0;
					List<int> list = Enumerable.ToList((IEnumerable<int>)source4);
					object obj36 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v28+E4]");
					bool flag8 = (nint)0 == 0;
					object obj37 = !flag8;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef playerRef = default;
					int playerId = playerRef.PlayerId;
					if (list != null)
					{
						int num = list.IndexOf(playerId);
						bool flag9 = num < 0;
						int num2 = num ^ num;
						int num3 = num & num2;
						bool flag10 = num3 < 0;
						bool flag11 = flag9 == flag10;
						object obj38 = !flag11;
						object obj39 = ~obj38;
						if (obj39 == null)
						{
							return 1;
						}
						return num + 1;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private static int ApeNumber(GillaModeRound round, PlayerRef me)
	{
		//IL_0324: Expected I4, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I
		//IL_0361: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I
		//IL_0442: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_03dc: Expected I, but got Obj
		//IL_03fa: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_0533: Expected Obj, but got I
		//IL_0543: Expected Obj, but got I
		//IL_0553: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I
		//IL_04bd: Expected I, but got Obj
		//IL_04db: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I4
		//IL_02a2: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I
		//IL_0593: Expected Obj, but got I
		//IL_05ad: Expected Obj, but got I
		//IL_05be: Expected I, but got Obj
		//IL_05dc: Expected Obj, but got I
		//IL_05f7: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I
		if ((object)round != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2240]");
			object obj2 = 0;
			NetworkDictionary<PlayerRef, byte> players = round.Players;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+A0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v16+30]");
			Func<KeyValuePair<PlayerRef, byte>, bool> predicate = (Func<KeyValuePair<PlayerRef, byte>, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8360]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X9_v16+30]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v39+A0]");
					obj5 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7D78]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23B0]");
				object obj11 = 0;
				Func<KeyValuePair<PlayerRef, byte>, bool> func = default;
				func._002Ector(obj5, (IntPtr)obj11);
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v38+A0]");
				object obj13 = (nint)0 + (nint)48;
				obj13 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj14 = 0;
				predicate = func;
			}
			IEnumerable<KeyValuePair<PlayerRef, byte>> source2 = default;
			IEnumerable<KeyValuePair<PlayerRef, byte>> source = Enumerable.Where(source2, predicate);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v9+A0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v14+38]");
			Func<KeyValuePair<PlayerRef, byte>, int> selector = (Func<KeyValuePair<PlayerRef, byte>, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8358]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v14+38]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj21 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v31+A0]");
					obj17 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8368]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23B8]");
				object obj23 = 0;
				Func<KeyValuePair<PlayerRef, byte>, int> func2 = default;
				func2._002Ector(obj17, (IntPtr)obj23);
				object obj24 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v30+A0]");
				object obj25 = (nint)0 + (nint)56;
				obj25 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj14 = 0;
				selector = func2;
			}
			IEnumerable<int> source3 = Enumerable.Select(source, selector);
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj27 = !flag7;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v12+A0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8350]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7E20]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+40]");
			Func<int, int> keySelector = (Func<int, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X9_v12+40]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v12+E4]");
				bool flag9 = (nint)0 == 0;
				object obj33 = !flag9;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj34 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+A0]");
					obj28 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8370]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D23C0]");
				object obj36 = 0;
				Func<int, int> func3 = default;
				func3._002Ector(obj28, (IntPtr)obj36);
				object obj37 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22+A0]");
				object obj38 = (nint)0 + (nint)64;
				obj38 = func3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj14 = 0;
				keySelector = func3;
			}
			IOrderedEnumerable<int> source4 = Enumerable.OrderBy(source3, keySelector);
			List<int> list = Enumerable.ToList((IEnumerable<int>)source4);
			object obj39 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v14+E4]");
			bool flag10 = (nint)0 == 0;
			object obj40 = !flag10;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef playerRef = default;
			int playerId = playerRef.PlayerId;
			if (list != null)
			{
				int num = list.IndexOf(playerId);
				int num2 = ~num;
				return num & num2;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private int MonsterNumber()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return MonsterChoice.NumberOr(monsterName);
	}

	private unsafe void Draw(GillaModeRound round)
	{
		//IL_0010: Expected Obj, but got I
		//IL_67cd: Expected Obj, but got I4
		//IL_6815: Expected Obj, but got I4
		//IL_7dbd: Expected Obj, but got I
		//IL_7dcd: Expected Obj, but got I
		//IL_7df0: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I4
		//IL_00c2: Expected F4, but got I4
		//IL_00d4: Expected F4, but got I4
		//IL_00dd: Expected VT, but got I4
		//IL_0230: Expected Obj, but got I4
		//IL_4c71: Expected VT, but got I4
		//IL_4c79: Expected I4, but got VT
		//IL_0145: Expected F4, but got I4
		//IL_0157: Expected F4, but got I4
		//IL_0160: Expected VT, but got I4
		//IL_0390: Expected F4, but got I4
		//IL_03a2: Expected F4, but got I4
		//IL_03ab: Expected VT, but got I4
		//IL_7e2d: Expected Obj, but got I4
		//IL_02c0: Expected F4, but got I4
		//IL_02d2: Expected F4, but got I4
		//IL_02db: Expected VT, but got I4
		//IL_04f8: Expected VT, but got I4
		//IL_0313: Expected Obj, but got I
		//IL_031b: Expected I4, but got Obj
		//IL_7e6a: Expected Obj, but got I4
		//IL_043d: Expected VT, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0352: Expected Obj, but got I4
		//IL_035b: Expected I4, but got Obj
		//IL_0662: Expected Obj, but got I
		//IL_06af: Expected Obj, but got I
		//IL_06b8: Expected VT, but got I4
		//IL_06c1: Expected Obj, but got I4
		//IL_0475: Expected Obj, but got I
		//IL_047d: Expected I4, but got Obj
		//IL_6833: Expected F4, but got VT
		//IL_684b: Expected VT, but got Ref
		//IL_6853: Expected Obj, but got VT
		//IL_0574: Expected Obj, but got I4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04b4: Expected Obj, but got I4
		//IL_04bd: Expected I4, but got Obj
		//IL_05a3: Expected Obj, but got I
		//IL_05b7: Expected Obj, but got I
		//IL_074e: Expected Obj, but got I
		//IL_0757: Expected VT, but got I4
		//IL_075f: Expected Obj, but got Ref
		//IL_6878: Expected VT, but got Ref
		//IL_6880: Expected Obj, but got VT
		//IL_6895: Expected Obj, but got I
		//IL_68a5: Expected Obj, but got I
		//IL_68c7: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I
		//IL_0630: Expected VT, but got I4
		//IL_078c: Expected Obj, but got Ref
		//IL_25b5: Expected Obj, but got I4
		//IL_080c: Expected VT, but got I4
		//IL_25e4: Expected Obj, but got I
		//IL_07a2: Expected I, but got Obj
		//IL_07b2: Expected Obj, but got I
		//IL_07d4: Expected VT, but got I4
		//IL_07e4: Expected Obj, but got I
		//IL_26c2: Expected Obj, but got I
		//IL_26da: Expected Obj, but got I
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected Obj, but got Unknown
		//IL_6a0c: Expected Obj, but got I4
		//IL_264f: Expected Obj, but got I
		//IL_2658: Expected VT, but got I4
		//IL_086d: Expected Obj, but got Ref
		//IL_271c: Expected VT, but got I4
		//IL_2725: Expected VT, but got I4
		//IL_08e7: Expected Obj, but got I8
		//IL_08ff: Expected VT, but got I4
		//IL_6a49: Expected Obj, but got I4
		//IL_2684: Expected Obj, but got I
		//IL_0883: Expected I, but got Obj
		//IL_0893: Expected Obj, but got I
		//IL_08b5: Expected VT, but got I4
		//IL_08c5: Expected Obj, but got I
		//IL_277a: Expected Obj, but got I
		//IL_278c: Expected VT, but got I4
		//IL_26a5: Expected Obj, but got I
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected Obj, but got Unknown
		//IL_0953: Expected Obj, but got Ref
		//IL_6a67: Expected Obj, but got I
		//IL_6abb: Expected Obj, but got I
		//IL_6acd: Expected VT, but got I4
		//IL_6ad6: Expected Obj, but got I4
		//IL_2954: Expected Obj, but got I
		//IL_2966: Expected VT, but got I4
		//IL_27cc: Expected VT, but got I4
		//IL_27d5: Expected VT, but got I4
		//IL_09d5: Expected Obj, but got I4
		//IL_09e5: Expected Obj, but got I4
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Expected Obj, but got Unknown
		//IL_0a13: Expected VT, but got I4
		//IL_0969: Expected I, but got Obj
		//IL_0979: Expected Obj, but got I
		//IL_099b: Expected VT, but got I4
		//IL_09ab: Expected Obj, but got I
		//IL_2a51: Expected VT, but got I4
		//IL_2a5a: Expected Obj, but got I4
		//IL_299c: Expected Obj, but got I4
		//IL_29d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d5: Expected I4, but got Unknown
		//IL_2a0a: Expected Obj, but got I4
		//IL_2a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a17: Expected Obj, but got Unknown
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected Obj, but got Unknown
		//IL_2865: Expected Obj, but got I
		//IL_288f: Expected Obj, but got I4
		//IL_0a79: Expected Obj, but got Ref
		//IL_2a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a76: Expected Obj, but got Unknown
		//IL_2aa2: Expected Obj, but got I8
		//IL_2ac3: Expected VT, but got I4
		//IL_28c3: Expected VT, but got I4
		//IL_2826: Expected Obj, but got I
		//IL_2837: Expected VT, but got I4
		//IL_0af3: Expected Obj, but got I8
		//IL_0b0b: Expected VT, but got I4
		//IL_0a8f: Expected I, but got Obj
		//IL_0a9f: Expected Obj, but got I
		//IL_0ac1: Expected VT, but got I4
		//IL_0ad1: Expected Obj, but got I
		//IL_2ae9: Expected Obj, but got I
		//IL_2af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af7: Expected Obj, but got Unknown
		//IL_2b38: Expected Obj, but got I4
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected Obj, but got Unknown
		//IL_0b71: Expected Obj, but got Ref
		//IL_0bf3: Expected Obj, but got I4
		//IL_0c03: Expected Obj, but got I4
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected Obj, but got Unknown
		//IL_0c31: Expected VT, but got I4
		//IL_6b15: Expected Obj, but got I4
		//IL_6b25: Expected Obj, but got I4
		//IL_6b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b4a: Expected Obj, but got Unknown
		//IL_6b5c: Expected VT, but got I4
		//IL_2bd2: Expected Obj, but got I
		//IL_2be4: Expected VT, but got I4
		//IL_0b87: Expected I, but got Obj
		//IL_0b97: Expected Obj, but got I
		//IL_0bb9: Expected VT, but got I4
		//IL_0bc9: Expected Obj, but got I
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Expected Obj, but got Unknown
		//IL_2c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c25: Expected Obj, but got Unknown
		//IL_2c51: Expected Obj, but got I8
		//IL_2c72: Expected VT, but got I4
		//IL_0c97: Expected Obj, but got Ref
		//IL_0d19: Expected Obj, but got I4
		//IL_0d29: Expected Obj, but got I4
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4e: Expected Obj, but got Unknown
		//IL_0d57: Expected VT, but got I4
		//IL_2c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9e: Expected Obj, but got Unknown
		//IL_2cd2: Expected Obj, but got I4
		//IL_2ce8: Expected Obj, but got I
		//IL_2d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d0d: Expected Obj, but got Unknown
		//IL_2d1f: Expected VT, but got I4
		//IL_0cad: Expected I, but got Obj
		//IL_0cbd: Expected Obj, but got I
		//IL_0cdf: Expected VT, but got I4
		//IL_0cef: Expected Obj, but got I
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected Obj, but got Unknown
		//IL_2d3d: Expected Obj, but got I
		//IL_68e5: Expected Obj, but got I
		//IL_690f: Expected Obj, but got I4
		//IL_6b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b7d: Expected Obj, but got Unknown
		//IL_6ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ba7: Expected Obj, but got Unknown
		//IL_0de3: Expected Obj, but got Ref
		//IL_2d91: Expected Obj, but got I4
		//IL_0e6d: Expected Obj, but got I4
		//IL_0e7d: Expected Obj, but got I4
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Expected Obj, but got Unknown
		//IL_0eb3: Expected VT, but got I4
		//IL_0df9: Expected I, but got Obj
		//IL_0e09: Expected Obj, but got I
		//IL_0e33: Expected VT, but got I4
		//IL_0e43: Expected Obj, but got I
		//IL_2e18: Expected Obj, but got I
		//IL_2e2a: Expected VT, but got I4
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected Obj, but got Unknown
		//IL_0ef1: Expected Obj, but got I
		//IL_2e66: Expected VT, but got I4
		//IL_2ee2: Expected VT, but got I4
		//IL_7254: Expected VT, but got I4
		//IL_7274: Expected Obj, but got I
		//IL_7294: Expected I4, but got VT
		//IL_6948: Expected Obj, but got I4
		//IL_0fbc: Expected Obj, but got I
		//IL_0fcd: Expected VT, but got I4
		//IL_0fd5: Expected Obj, but got Ref
		//IL_2f7c: Expected Obj, but got I
		//IL_4cd2: Expected Obj, but got I4
		//IL_1002: Expected Obj, but got Ref
		//IL_72ca: Expected Obj, but got I
		//IL_72ed: Expected VT, but got I
		//IL_72ed: Expected VT, but got I
		//IL_730a: Expected Obj, but got I
		//IL_731a: Expected Obj, but got I
		//IL_7333: Expected VT, but got I8
		//IL_7333: Expected VT, but got I4
		//IL_7340: Expected VT, but got I8
		//IL_7349: Expected VT, but got I4
		//IL_7352: Expected Obj, but got I4
		//IL_2fc4: Expected Obj, but got I4
		//IL_3029: Expected VT, but got I4
		//IL_3049: Expected Obj, but got I
		//IL_3069: Expected I4, but got VT
		//IL_1092: Expected VT, but got I4
		//IL_741c: Expected Obj, but got I4
		//IL_1018: Expected I, but got Obj
		//IL_1028: Expected Obj, but got I
		//IL_1052: Expected VT, but got I4
		//IL_1062: Expected Obj, but got I
		//IL_7367: Expected Obj, but got I
		//IL_7374: Unknown result type (might be due to invalid IL or missing references)
		//IL_7379: Expected VT, but got Unknown
		//IL_7389: Expected Obj, but got I
		//IL_73a1: Expected VT, but got I8
		//IL_73aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_73af: Expected Obj, but got Unknown
		//IL_73c9: Expected Obj, but got I4
		//IL_73df: Expected VT, but got I8
		//IL_30aa: Expected Obj, but got I4
		//IL_10a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ae: Expected Obj, but got Unknown
		//IL_4d47: Expected Obj, but got I4
		//IL_30f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f5: Expected Obj, but got Unknown
		//IL_3105: Expected Obj, but got I
		//IL_6981: Expected Obj, but got I4
		//IL_743a: Expected Obj, but got I
		//IL_744a: Expected Obj, but got I
		//IL_7487: Expected Obj, but got I
		//IL_74b6: Expected Obj, but got I4
		//IL_4bb9: Expected Obj, but got I4
		//IL_4c1b: Expected Obj, but got I
		//IL_111e: Expected Obj, but got Ref
		//IL_3159: Expected Obj, but got I4
		//IL_11a0: Expected Obj, but got I8
		//IL_11c0: Expected VT, but got I4
		//IL_6bcd: Expected Obj, but got I
		//IL_6bee: Expected VT, but got I
		//IL_6bee: Expected VT, but got I
		//IL_6c1d: Expected Obj, but got I4
		//IL_1134: Expected I, but got Obj
		//IL_1144: Expected Obj, but got I
		//IL_116e: Expected VT, but got I4
		//IL_117e: Expected Obj, but got I
		//IL_74f3: Expected Obj, but got I4
		//IL_4ddc: Expected Obj, but got I
		//IL_4de4: Expected I4, but got VT
		//IL_4df5: Expected VT, but got I4
		//IL_4dfe: Expected VT, but got I4
		//IL_11d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dc: Expected Obj, but got Unknown
		//IL_3319: Expected Obj, but got I4
		//IL_1210: Expected Obj, but got I
		//IL_1231: Expected Obj, but got Ref
		//IL_50c0: Expected Obj, but got I
		//IL_50c8: Expected I4, but got VT
		//IL_50d9: Expected VT, but got I4
		//IL_50e2: Expected VT, but got I4
		//IL_3233: Expected Obj, but got I
		//IL_3254: Expected VT, but got I4
		//IL_12bb: Expected Obj, but got I4
		//IL_12cb: Expected Obj, but got I4
		//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f0: Expected Obj, but got Unknown
		//IL_1301: Expected VT, but got I4
		//IL_4ea4: Expected Obj, but got I4
		//IL_1247: Expected I, but got Obj
		//IL_1257: Expected Obj, but got I
		//IL_1281: Expected VT, but got I4
		//IL_1291: Expected Obj, but got I
		//IL_4edf: Expected Obj, but got I
		//IL_6dbf: Expected Obj, but got I4
		//IL_33d7: Expected Obj, but got I
		//IL_33f8: Expected VT, but got I4
		//IL_1318: Unknown result type (might be due to invalid IL or missing references)
		//IL_131d: Expected Obj, but got Unknown
		//IL_5558: Invalid comparison between F4 and I4
		//IL_751e: Expected Obj, but got I
		//IL_7550: Expected Obj, but got I4
		//IL_1362: Expected Obj, but got Ref
		//IL_817f: Expected Obj, but got I
		//IL_818f: Expected Obj, but got I
		//IL_819f: Expected Obj, but got I
		//IL_81c1: Expected Obj, but got I4
		//IL_4f35: Expected Obj, but got I
		//IL_4f3d: Expected I4, but got VT
		//IL_4f4e: Expected VT, but got I4
		//IL_4f57: Expected VT, but got I4
		//IL_32cd: Expected Obj, but got I4
		//IL_32d5: Expected I4, but got Obj
		//IL_32dd: Expected VT, but got I4
		//IL_13e4: Expected Obj, but got I8
		//IL_1404: Expected VT, but got I4
		//IL_5bdc: Expected Obj, but got I
		//IL_5c06: Expected Obj, but got I4
		//IL_557f: Expected Obj, but got I
		//IL_6c5a: Expected Obj, but got I4
		//IL_350a: Expected Obj, but got I
		//IL_352b: Expected VT, but got I4
		//IL_3818: Unknown result type (might be due to invalid IL or missing references)
		//IL_381d: Expected Obj, but got Unknown
		//IL_3839: Expected Obj, but got I4
		//IL_1378: Expected I, but got Obj
		//IL_1388: Expected Obj, but got I
		//IL_13b2: Expected VT, but got I4
		//IL_13c2: Expected Obj, but got I
		//IL_78c7: Expected Obj, but got I
		//IL_78d7: Expected Obj, but got I
		//IL_78f1: Expected Obj, but got I
		//IL_7923: Expected VT, but got I4
		//IL_5ad2: Expected Obj, but got I
		//IL_5ae3: Expected VT, but got I4
		//IL_5178: Expected Obj, but got I
		//IL_5469: Expected Obj, but got I
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1420: Expected Obj, but got Unknown
		//IL_780d: Expected Obj, but got I
		//IL_7837: Expected Obj, but got I4
		//IL_7678: Expected Obj, but got I
		//IL_76a2: Expected Obj, but got I4
		//IL_7597: Expected Obj, but got I
		//IL_759f: Expected I4, but got VT
		//IL_75b0: Expected VT, but got I4
		//IL_75b9: Expected VT, but got I4
		//IL_503b: Expected Obj, but got I
		//IL_5043: Expected I4, but got VT
		//IL_5054: Expected VT, but got I4
		//IL_505d: Expected VT, but got I4
		//IL_4fa7: Expected Obj, but got I
		//IL_1465: Expected Obj, but got Ref
		//IL_81df: Expected Obj, but got I
		//IL_81ef: Expected F4, but got I
		//IL_55cd: Expected Obj, but got F4
		//IL_55d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_55da: Expected I4, but got Unknown
		//IL_55e3: Expected VT, but got I4
		//IL_5e81: Expected Obj, but got I
		//IL_588e: Expected I4, but got VT
		//IL_589e: Expected Obj, but got I
		//IL_75d8: Expected Obj, but got I
		//IL_7602: Expected Obj, but got I4
		//IL_367c: Expected Obj, but got I
		//IL_369d: Expected VT, but got I4
		//IL_14ef: Expected Obj, but got I4
		//IL_14ff: Expected Obj, but got I4
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected Obj, but got Unknown
		//IL_1535: Expected VT, but got I4
		//IL_76df: Expected Obj, but got I4
		//IL_568c: Expected VT, but got I4
		//IL_51d3: Expected Obj, but got F4
		//IL_51db: Unknown result type (might be due to invalid IL or missing references)
		//IL_51e0: Expected I4, but got Unknown
		//IL_5202: Expected Obj, but got I4
		//IL_548b: Expected Obj, but got I
		//IL_5504: Expected Obj, but got I4
		//IL_550c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5511: Expected Obj, but got Unknown
		//IL_551a: Expected I4, but got Obj
		//IL_359d: Expected Obj, but got I4
		//IL_147b: Expected I, but got Obj
		//IL_148b: Expected Obj, but got I
		//IL_14b5: Expected VT, but got I4
		//IL_14c5: Expected Obj, but got I
		//IL_5c74: Invalid comparison between F4 and I4
		//IL_5fb5: Expected I4, but got Obj
		//IL_5fd7: Expected Obj, but got I4
		//IL_5f5b: Expected Obj, but got I
		//IL_5f66: Expected Obj, but got I4
		//IL_5f6f: Expected I4, but got Obj
		//IL_5906: Expected I4, but got Obj
		//IL_5928: Expected Obj, but got I4
		//IL_56a5: Expected Obj, but got I
		//IL_5249: Expected Obj, but got I
		//IL_5259: Expected Obj, but got I
		//IL_3860: Expected Obj, but got I4
		//IL_3745: Expected Obj, but got I4
		//IL_36ed: Expected Obj, but got I4
		//IL_154c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1551: Expected Obj, but got Unknown
		//IL_5cf9: Expected Obj, but got I4
		//IL_601e: Expected Obj, but got I
		//IL_602e: Expected Obj, but got I
		//IL_603e: Expected Obj, but got I
		//IL_604e: Expected I4, but got VT
		//IL_605e: Expected VT, but got I4
		//IL_5bc7: Expected Obj, but got I
		//IL_596f: Expected Obj, but got I
		//IL_597f: Expected Obj, but got I
		//IL_5708: Expected I4, but got Obj
		//IL_572a: Expected Obj, but got I4
		//IL_52b0: Expected Obj, but got I
		//IL_52b8: Expected I4, but got VT
		//IL_52d1: Expected VT, but got I4
		//IL_52da: Expected VT, but got I4
		//IL_765a: Expected I4, but got VT
		//IL_7662: Expected VT, but got I4
		//IL_6ddd: Expected Obj, but got I
		//IL_6df4: Expected VT, but got I8
		//IL_6df4: Expected VT, but got I4
		//IL_6e23: Expected Obj, but got I4
		//IL_37ca: Expected Obj, but got I4
		//IL_6ca2: Expected Obj, but got I
		//IL_6cb9: Expected VT, but got I8
		//IL_6cb9: Expected VT, but got I4
		//IL_6ce8: Expected Obj, but got I4
		//IL_1596: Expected Obj, but got Ref
		//IL_7961: Expected Obj, but got I
		//IL_5cad: Expected Obj, but got I4
		//IL_777e: Expected Obj, but got I
		//IL_7799: Unknown result type (might be due to invalid IL or missing references)
		//IL_779e: Expected Obj, but got Unknown
		//IL_77cd: Expected Obj, but got I
		//IL_77ef: Expected Obj, but got I4
		//IL_5f8d: Expected Obj, but got I
		//IL_599f: Expected VT, but got I4
		//IL_5771: Expected Obj, but got I
		//IL_5781: Expected Obj, but got I
		//IL_6e47: Expected Obj, but got I
		//IL_6d21: Expected Obj, but got I
		//IL_6d38: Expected VT, but got I8
		//IL_6d38: Expected VT, but got I4
		//IL_6d67: Expected Obj, but got I4
		//IL_6d0c: Expected Obj, but got I
		//IL_1620: Expected Obj, but got I4
		//IL_1630: Expected Obj, but got I4
		//IL_1650: Unknown result type (might be due to invalid IL or missing references)
		//IL_1655: Expected Obj, but got Unknown
		//IL_1666: Expected VT, but got I4
		//IL_823a: Expected Obj, but got I
		//IL_8245: Expected Obj, but got I4
		//IL_824e: Expected I4, but got Obj
		//IL_7946: Expected Obj, but got I
		//IL_7e80: Expected I4, but got Obj
		//IL_7e9b: Expected VT, but got I8
		//IL_7e9b: Expected VT, but got I8
		//IL_7f10: Expected Obj, but got I
		//IL_7f2d: Expected VT, but got I8
		//IL_7f3a: Expected Obj, but got I8
		//IL_6d8b: Expected Obj, but got I
		//IL_15ac: Expected I, but got Obj
		//IL_15bc: Expected Obj, but got I
		//IL_15e6: Expected VT, but got I4
		//IL_15f6: Expected Obj, but got I
		//IL_5d38: Expected Obj, but got I
		//IL_61d0: Expected Obj, but got I4
		//IL_5afd: Expected Obj, but got I
		//IL_167d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected Obj, but got Unknown
		//IL_7976: Expected I4, but got VT
		//IL_7986: Expected VT, but got I4
		//IL_7a5f: Expected Obj, but got I
		//IL_60db: Expected Obj, but got I
		//IL_60f5: Expected VT, but got I4
		//IL_5d8d: Expected Obj, but got I
		//IL_59e2: Expected Obj, but got I
		//IL_59f2: Expected Obj, but got I
		//IL_5a02: Expected Obj, but got I
		//IL_5a12: Expected Obj, but got I
		//IL_5a3a: Expected Obj, but got I4
		//IL_5a43: Expected I4, but got Obj
		//IL_5ec8: Expected Obj, but got I
		//IL_5ee2: Expected Obj, but got I
		//IL_5ef2: Expected Obj, but got I
		//IL_5f02: Expected Obj, but got I
		//IL_762d: Expected Obj, but got I
		//IL_5336: Expected Obj, but got I4
		//IL_5345: Expected Obj, but got I4
		//IL_5365: Unknown result type (might be due to invalid IL or missing references)
		//IL_536a: Expected Obj, but got Unknown
		//IL_538c: Expected Obj, but got I
		//IL_539e: Expected VT, but got I4
		//IL_38c1: Expected Obj, but got I4
		//IL_38f6: Expected VT, but got I8
		//IL_3903: Expected Obj, but got I8
		//IL_16bb: Expected Obj, but got Ref
		//IL_82e3: Expected Obj, but got I4
		//IL_5db6: Expected Obj, but got I
		//IL_5de5: Expected Obj, but got I4
		//IL_5a66: Expected Obj, but got I
		//IL_7d89: Invalid comparison between VT and I4
		//IL_5b27: Expected Obj, but got I
		//IL_1745: Expected Obj, but got I4
		//IL_1755: Expected Obj, but got I4
		//IL_1775: Unknown result type (might be due to invalid IL or missing references)
		//IL_177a: Expected Obj, but got Unknown
		//IL_178b: Expected VT, but got I4
		//IL_7a74: Expected Obj, but got I
		//IL_7aa9: Expected Obj, but got I
		//IL_7ac6: Expected Obj, but got I
		//IL_6602: Expected Obj, but got I
		//IL_663f: Expected Obj, but got I4
		//IL_7731: Expected Obj, but got I
		//IL_7769: Expected VT, but got I4
		//IL_66e4: Expected Obj, but got I
		//IL_66fe: Expected Obj, but got I
		//IL_670e: Expected Obj, but got I
		//IL_671e: Expected Obj, but got I
		//IL_57d9: Expected Obj, but got I
		//IL_57f3: Expected Obj, but got I
		//IL_5803: Expected Obj, but got I
		//IL_580c: Invalid comparison between VT and I4
		//IL_7872: Expected VT, but got I4
		//IL_5b12: Expected Obj, but got I
		//IL_53bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_53c0: Expected Obj, but got Unknown
		//IL_5401: Expected Obj, but got I
		//IL_5409: Expected I4, but got VT
		//IL_5422: Expected VT, but got I4
		//IL_542b: Expected VT, but got I4
		//IL_391b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3920: Expected Obj, but got Unknown
		//IL_3930: Expected Obj, but got I
		//IL_39a1: Expected Obj, but got I
		//IL_39be: Expected VT, but got I8
		//IL_39cb: Expected Obj, but got I8
		//IL_16d1: Expected I, but got Obj
		//IL_16e1: Expected Obj, but got I
		//IL_170b: Expected VT, but got I4
		//IL_171b: Expected Obj, but got I
		//IL_79c4: Expected Obj, but got I4
		//IL_79cc: Expected VT, but got I4
		//IL_673b: Expected Obj, but got I
		//IL_674c: Expected Obj, but got I4
		//IL_5a83: Expected I4, but got VT
		//IL_79e1: Expected Obj, but got I
		//IL_7a29: Expected VT, but got I4
		//IL_5b34: Expected I4, but got VT
		//IL_17a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7: Expected Obj, but got Unknown
		//IL_6301: Expected Obj, but got I4
		//IL_6177: Expected Obj, but got I4
		//IL_7d42: Expected Obj, but got I
		//IL_7d66: Expected Obj, but got I
		//IL_5833: Expected Obj, but got I
		//IL_5454: Expected Obj, but got I
		//IL_17e0: Expected Obj, but got Ref
		//IL_7b0a: Expected Obj, but got I
		//IL_7b3f: Expected Obj, but got I
		//IL_7b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b4a: Expected Obj, but got Unknown
		//IL_7b74: Expected Obj, but got I
		//IL_7b8e: Expected Obj, but got I4
		//IL_7a44: Expected Obj, but got I
		//IL_5e2c: Expected Obj, but got I
		//IL_5e46: Expected Obj, but got I
		//IL_6772: Expected VT, but got I4
		//IL_3a7f: Expected Obj, but got I4
		//IL_1862: Expected Obj, but got I8
		//IL_1882: Expected VT, but got I4
		//IL_6686: Expected Obj, but got I
		//IL_66a0: Expected Obj, but got I
		//IL_6e7d: Expected Obj, but got I
		//IL_3a33: Expected Obj, but got I4
		//IL_17f6: Expected I, but got Obj
		//IL_1806: Expected Obj, but got I
		//IL_1830: Expected VT, but got I4
		//IL_1840: Expected Obj, but got I
		//IL_6262: Expected Obj, but got I
		//IL_6272: Expected Obj, but got I
		//IL_66cf: Expected Obj, but got I4
		//IL_7f89: Expected Obj, but got I
		//IL_7fcf: Expected Obj, but got I
		//IL_7fef: Expected Obj, but got I
		//IL_8000: Expected Obj, but got I
		//IL_8022: Expected VT, but got I4
		//IL_6e62: Expected Obj, but got I
		//IL_1899: Unknown result type (might be due to invalid IL or missing references)
		//IL_189e: Expected Obj, but got Unknown
		//IL_633b: Expected Obj, but got I
		//IL_18d7: Expected Obj, but got Ref
		//IL_6370: Expected Obj, but got I
		//IL_1961: Expected Obj, but got I4
		//IL_1971: Expected Obj, but got I4
		//IL_1991: Unknown result type (might be due to invalid IL or missing references)
		//IL_1996: Expected Obj, but got Unknown
		//IL_19a7: Expected VT, but got I4
		//IL_7bdf: Expected VT, but got I4
		//IL_6385: Expected Obj, but got I
		//IL_18ed: Expected I, but got Obj
		//IL_18fd: Expected Obj, but got I
		//IL_1927: Expected VT, but got I4
		//IL_1937: Expected Obj, but got I
		//IL_7c2d: Expected Obj, but got I
		//IL_7aed: Expected VT, but got I4
		//IL_62cd: Expected Obj, but got I
		//IL_6ec8: Expected Obj, but got I
		//IL_6ef1: Expected Obj, but got I
		//IL_6f13: Expected VT, but got I4
		//IL_3ae5: Expected Obj, but got I4
		//IL_3b07: Expected Obj, but got I
		//IL_3b21: Expected VT, but got I4
		//IL_19be: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c3: Expected Obj, but got Unknown
		//IL_1a08: Expected Obj, but got Ref
		//IL_63c4: Expected Obj, but got I
		//IL_3b80: Expected Obj, but got I4
		//IL_3ba2: Expected Obj, but got I
		//IL_3bbc: Expected VT, but got I4
		//IL_3b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b46: Expected Obj, but got Unknown
		//IL_3b56: Expected Obj, but got I
		//IL_1a92: Expected Obj, but got I4
		//IL_1aa2: Expected Obj, but got I4
		//IL_1ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac7: Expected Obj, but got Unknown
		//IL_1ad8: Expected VT, but got I4
		//IL_7cb5: Expected Obj, but got I
		//IL_7cd6: Expected VT, but got Obj
		//IL_1a1e: Expected I, but got Obj
		//IL_1a2e: Expected Obj, but got I
		//IL_1a58: Expected VT, but got I4
		//IL_1a68: Expected Obj, but got I
		//IL_3bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be1: Expected Obj, but got Unknown
		//IL_3bf1: Expected Obj, but got I
		//IL_3c33: Expected Obj, but got I
		//IL_3c5c: Expected Obj, but got I
		//IL_3c7e: Expected VT, but got I4
		//IL_1aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af4: Expected Obj, but got Unknown
		//IL_1b16: Expected Obj, but got I
		//IL_644d: Expected Obj, but got I4
		//IL_6468: Expected Obj, but got I4
		//IL_64b9: Expected Obj, but got I4
		//IL_64c2: Expected I4, but got Obj
		//IL_6422: Expected Obj, but got I
		//IL_3cc8: Expected Obj, but got I
		//IL_3cd3: Expected Obj, but got I4
		//IL_3cdc: Expected I4, but got Obj
		//IL_1bbe: Expected Obj, but got I
		//IL_1bd7: Expected VT, but got I4
		//IL_1bdf: Expected Obj, but got Ref
		//IL_7d02: Expected I4, but got Obj
		//IL_7d24: Expected Obj, but got I4
		//IL_3d0c: Expected F8, but got I
		//IL_8301: Expected Obj, but got I
		//IL_8335: Expected Obj, but got I
		//IL_8381: Expected Obj, but got I
		//IL_8392: Expected Obj, but got I4
		//IL_83b6: Expected VT, but got I4
		//IL_6f53: Expected Obj, but got I4
		//IL_1c0c: Expected Obj, but got Ref
		//IL_3d5f: Expected Obj, but got I4
		//IL_3d78: Expected Obj, but got I
		//IL_1c9c: Expected VT, but got I4
		//IL_6540: Expected Obj, but got I
		//IL_6550: Expected Obj, but got I
		//IL_6584: Expected Obj, but got I
		//IL_45e4: Expected Obj, but got I4
		//IL_1c22: Expected I, but got Obj
		//IL_1c32: Expected Obj, but got I
		//IL_1c5c: Expected VT, but got I4
		//IL_1c6c: Expected Obj, but got I
		//IL_65a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_65a9: Expected Obj, but got Unknown
		//IL_3dee: Expected Obj, but got I
		//IL_3e1f: Expected Obj, but got I
		//IL_3e39: Expected VT, but got I4
		//IL_1cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb8: Expected Obj, but got Unknown
		//IL_47cf: Expected VT, but got I4
		//IL_1cf0: Expected Obj, but got Ref
		//IL_467e: Expected Obj, but got I
		//IL_4687: Expected VT, but got I4
		//IL_3e83: Expected Obj, but got I
		//IL_1d72: Expected Obj, but got I8
		//IL_1d92: Expected VT, but got I4
		//IL_4834: Expected Obj, but got I
		//IL_483d: Expected VT, but got I4
		//IL_1d06: Expected I, but got Obj
		//IL_1d16: Expected Obj, but got I
		//IL_1d40: Expected VT, but got I4
		//IL_1d50: Expected Obj, but got I
		//IL_3ece: Expected Obj, but got I4
		//IL_3ef0: Expected Obj, but got I
		//IL_3f0a: Expected VT, but got I4
		//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dae: Expected Obj, but got Unknown
		//IL_4890: Expected Obj, but got I
		//IL_1df8: Expected Obj, but got Ref
		//IL_48c5: Expected Obj, but got I
		//IL_4919: Expected Obj, but got I
		//IL_46f4: Expected Obj, but got I4
		//IL_3f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f2f: Expected Obj, but got Unknown
		//IL_3f3f: Expected Obj, but got I
		//IL_3f6f: Expected Obj, but got I
		//IL_1e82: Expected Obj, but got I4
		//IL_1e92: Expected Obj, but got I4
		//IL_1eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb7: Expected Obj, but got Unknown
		//IL_1ec8: Expected VT, but got I4
		//IL_6f83: Expected Obj, but got I4
		//IL_494e: Expected Obj, but got I
		//IL_1e0e: Expected I, but got Obj
		//IL_1e1e: Expected Obj, but got I
		//IL_1e48: Expected VT, but got I4
		//IL_1e58: Expected Obj, but got I
		//IL_8050: Expected Obj, but got I
		//IL_8060: Expected Obj, but got I
		//IL_475c: Expected VT, but got I4
		//IL_3fe5: Expected Obj, but got I
		//IL_4005: Expected Obj, but got I
		//IL_401e: Expected Obj, but got I
		//IL_4038: Expected VT, but got I4
		//IL_1edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee4: Expected Obj, but got Unknown
		//IL_6fea: Expected VT, but got I4
		//IL_1f2e: Expected Obj, but got Ref
		//IL_4071: Expected Obj, but got I4
		//IL_4093: Expected Obj, but got I
		//IL_40ad: Expected VT, but got I4
		//IL_1fb0: Expected Obj, but got I8
		//IL_1fd0: Expected VT, but got I4
		//IL_4a17: Expected Obj, but got I4
		//IL_1f44: Expected I, but got Obj
		//IL_1f54: Expected Obj, but got I
		//IL_1f7e: Expected VT, but got I4
		//IL_1f8e: Expected Obj, but got I
		//IL_708d: Expected Obj, but got I
		//IL_49cb: Expected Obj, but got I4
		//IL_40cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_40d2: Expected Obj, but got Unknown
		//IL_40e2: Expected Obj, but got I
		//IL_4124: Expected Obj, but got I
		//IL_4144: Expected Obj, but got I
		//IL_415d: Expected Obj, but got I
		//IL_4177: Expected VT, but got I4
		//IL_1fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fec: Expected Obj, but got Unknown
		//IL_810b: Expected VT, but got I4
		//IL_8115: Expected VT, but got Obj
		//IL_7072: Expected Obj, but got I
		//IL_2036: Expected Obj, but got Ref
		//IL_4a9b: Expected Obj, but got I
		//IL_41a5: Expected Obj, but got I
		//IL_41e7: Expected Obj, but got I
		//IL_4207: Expected Obj, but got I
		//IL_4220: Expected Obj, but got I
		//IL_423a: Expected VT, but got I4
		//IL_20c0: Expected Obj, but got I4
		//IL_20d0: Expected Obj, but got I4
		//IL_20f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f5: Expected Obj, but got Unknown
		//IL_2106: Expected VT, but got I4
		//IL_4ada: Expected Obj, but got I
		//IL_4a4a: Expected Obj, but got I4
		//IL_204c: Expected I, but got Obj
		//IL_205c: Expected Obj, but got I
		//IL_2086: Expected VT, but got I4
		//IL_2096: Expected Obj, but got I
		//IL_7186: Expected Obj, but got I4
		//IL_4270: Expected Obj, but got I
		//IL_42c0: Expected Obj, but got I
		//IL_42e0: Expected Obj, but got I
		//IL_42f9: Expected Obj, but got I
		//IL_4313: Expected VT, but got I4
		//IL_211d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2122: Expected Obj, but got Unknown
		//IL_4b4d: Expected Obj, but got I4
		//IL_70a2: Expected Obj, but got I
		//IL_70bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_70c4: Expected Obj, but got Unknown
		//IL_70d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_70d6: Expected VT, but got Unknown
		//IL_70ec: Expected VT, but got I8
		//IL_7104: Unknown result type (might be due to invalid IL or missing references)
		//IL_7109: Expected Obj, but got Unknown
		//IL_7124: Expected VT, but got I8
		//IL_7141: Expected I4, but got I8
		//IL_7149: Expected Obj, but got VT
		//IL_71e2: Expected Obj, but got I
		//IL_4b01: Expected Obj, but got I4
		//IL_4344: Expected Obj, but got I4
		//IL_4366: Expected Obj, but got I
		//IL_4380: Expected VT, but got I4
		//IL_4390: Expected Obj, but got I
		//IL_69ba: Expected Obj, but got I4
		//IL_71c7: Expected Obj, but got I
		//IL_21a2: Expected Obj, but got Ref
		//IL_43a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ad: Expected Obj, but got Unknown
		//IL_43bd: Expected Obj, but got I
		//IL_43ff: Expected Obj, but got I
		//IL_441f: Expected Obj, but got I
		//IL_4438: Expected Obj, but got I
		//IL_4452: Expected VT, but got I4
		//IL_2224: Expected Obj, but got I4
		//IL_2234: Expected Obj, but got I4
		//IL_2254: Unknown result type (might be due to invalid IL or missing references)
		//IL_2259: Expected Obj, but got Unknown
		//IL_2262: Expected VT, but got I4
		//IL_21b8: Expected I, but got Obj
		//IL_21c8: Expected Obj, but got I
		//IL_21ea: Expected VT, but got I4
		//IL_21fa: Expected Obj, but got I
		//IL_4478: Expected Obj, but got I
		//IL_44ba: Expected Obj, but got I
		//IL_44da: Expected Obj, but got I
		//IL_44f3: Expected Obj, but got I
		//IL_450d: Expected VT, but got I4
		//IL_2279: Unknown result type (might be due to invalid IL or missing references)
		//IL_227e: Expected Obj, but got Unknown
		//IL_229e: Expected VT, but got I4
		//IL_22c8: Expected Obj, but got Ref
		//IL_4565: Expected I4, but got Obj
		//IL_4565: Expected Obj, but got I
		//IL_4577: Expected Obj, but got I4
		//IL_4580: Expected Obj, but got I4
		//IL_45a0: Expected I4, but got Obj
		//IL_45b0: Expected Obj, but got I
		//IL_234a: Expected Obj, but got I4
		//IL_235a: Expected Obj, but got I4
		//IL_237a: Unknown result type (might be due to invalid IL or missing references)
		//IL_237f: Expected Obj, but got Unknown
		//IL_2388: Expected VT, but got I4
		//IL_22de: Expected I, but got Obj
		//IL_22ee: Expected Obj, but got I
		//IL_2310: Expected VT, but got I4
		//IL_2320: Expected Obj, but got I
		//IL_239f: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a4: Expected Obj, but got Unknown
		//IL_23c6: Expected Obj, but got I
		//IL_23f0: Expected Obj, but got I4
		//IL_2440: Expected Obj, but got Ref
		//IL_24ba: Expected Obj, but got I8
		//IL_24d2: Expected VT, but got I4
		//IL_2456: Expected I, but got Obj
		//IL_2466: Expected Obj, but got I
		//IL_2488: Expected VT, but got I4
		//IL_2498: Expected Obj, but got I
		//IL_24e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ee: Expected Obj, but got Unknown
		//IL_2510: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4918]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		bool flag2 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		bool value = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v6+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7 (System.Boolean)+E4]");
		MapEntry[] array = (MapEntry[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7 (System.Boolean)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte b;
		bool flag7;
		PlayerRef playerRef;
		UnityEngine.Object obj9;
		bool flag6 = default;
		int num;
		int num3;
		UnityEngine.Object obj8;
		int num2;
		float num5;
		Color32 color;
		GillaModeRound gillaModeRound;
		if ((UnityEngine.Object)round != (UnityEngine.Object)null)
		{
			bool flag5 = (object)round == null;
			num = 0;
			flag6 = false;
			num2 = 0;
			num3 = 0;
			b = 0;
			float num4 = 0f;
			flag7 = false;
			num5 = 0f;
			color = (Color32)0;
			obj8 = null;
			gillaModeRound = round;
			if (!flag5)
			{
				bool flag8 = (object)((SimulationBehaviour)round)._runner == null;
				num = 0;
				flag6 = false;
				num2 = 0;
				num3 = 0;
				b = 0;
				num4 = 0f;
				flag7 = false;
				num5 = 0f;
				color = (Color32)0;
				obj8 = null;
				gillaModeRound = round;
				if (!flag8)
				{
					playerRef = ((SimulationBehaviour)round)._runner.LocalPlayer;
					obj9 = null;
					goto IL_0201;
				}
			}
			goto IL_4c69;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v835+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		playerRef = PlayerRef.None;
		obj9 = null;
		goto IL_0201;
		IL_2695:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
		UnityEngine.Object obj13 = (UnityEngine.Object)0;
		string text2;
		string text = text2;
		goto IL_69c8;
		IL_4c69:
		int num6 = default;
		(int, int) tuple = ((int, int))num6;
		(int, int) tuple2 = default;
		int num7 = (int)tuple2;
		throw new NullReferenceException();
		IL_0201:
		bool value2 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X0_v310 (System.Boolean)+E4]");
		bool flag10 = (nint)0 == 0;
		object obj14 = !flag10;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num10 = default;
		float num12 = default;
		float num13 = default;
		bool flag13;
		int num8;
		if ((UnityEngine.Object)round != (UnityEngine.Object)null)
		{
			bool flag11 = (object)round == null;
			num = 0;
			flag6 = false;
			num2 = 0;
			num3 = 0;
			b = 0;
			float num4 = 0f;
			flag7 = false;
			num5 = 0f;
			color = (Color32)0;
			obj8 = null;
			gillaModeRound = round;
			if (flag11)
			{
				goto IL_4c69;
			}
			NetworkDictionary<PlayerRef, byte> votes = round.Votes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj15 = 0;
			num8 = (int)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj17 = default;
			object obj16 = obj17 & 1;
			bool flag12 = obj16 == null;
			object obj18 = !flag12;
			flag13 = (((int)(~obj18) != 0) ? true : flag7);
			float num9 = num10;
			num4 = (float)tuple2;
			float num11 = num12;
			num5 = num13;
			Color32 color2 = (Color32)(&flag7);
			UnityEngine.Object obj19 = (UnityEngine.Object)playerRef;
		}
		else
		{
			float num4 = 0f;
			flag7 = false;
			num5 = 0f;
			Color32 color2 = (Color32)0;
			UnityEngine.Object obj19 = null;
			flag13 = true;
		}
		bool value3 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ X0_v315 (System.Boolean)+E4]");
		bool flag14 = (nint)0 == 0;
		object obj20 = !flag14;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte b2;
		if ((UnityEngine.Object)round != (UnityEngine.Object)null)
		{
			bool flag15 = (object)round == null;
			num = 0;
			flag6 = false;
			num2 = 0;
			num3 = 0;
			b = 0;
			color = (Color32)0;
			obj8 = null;
			gillaModeRound = round;
			if (flag15)
			{
				goto IL_4c69;
			}
			NetworkDictionary<PlayerRef, byte> modeVotes = round.ModeVotes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7780]");
			object obj21 = 0;
			num8 = (int)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F9BA8C");
			object obj23 = default;
			object obj22 = obj23 & 1;
			bool flag16 = obj22 == null;
			object obj24 = !flag16;
			b2 = (byte)(((int)(~obj24) != 0) ? 4294967295u : b);
			float num9 = num10;
			float num11 = num12;
			num5 = num13;
			Color32 color3 = (Color32)(&b);
			UnityEngine.Object obj25 = (UnityEngine.Object)playerRef;
		}
		else
		{
			b = 0;
			Color32 color3 = (Color32)0;
			UnityEngine.Object obj25 = null;
			b2 = 255;
		}
		bool value4 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X0_v320 (System.Boolean)+E4]");
		bool flag17 = (nint)0 == 0;
		object obj26 = !flag17;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3;
		string text5;
		UnityEngine.Object obj36;
		string text6;
		Color32 color4;
		ScreenFont screenFont;
		UnityEngine.Object obj29;
		IndexOutOfRangeException ex = default;
		UnityEngine.Object obj37;
		if ((UnityEngine.Object)round == (UnityEngine.Object)null)
		{
			bool value5 = ((bool*)(flag2 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ X0_v807 (System.Boolean)+E4]");
			bool flag18 = (nint)0 == 0;
			object obj27 = !flag18;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
			bool flag19 = (UnityEngine.Object)0 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4698]");
			object obj28 = 0;
			text3 = (string)obj28;
			if (flag19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
				bool flag20 = (nint)0 == 0;
				num = 0;
				flag6 = false;
				num2 = 0;
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
				obj29 = (UnityEngine.Object)0;
				color = (Color32)0;
				obj8 = null;
				gillaModeRound = round;
				if (flag20)
				{
					goto IL_4c69;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X9_v95+30]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ X0_v811+E4]");
			bool flag21 = (nint)0 == 0;
			object obj32 = !flag21;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text4 = flag6.ToString();
			bool value6 = ((bool*)(flag2 ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ X8_v491 (System.Boolean)+E4]");
			bool flag22 = (nint)0 == 0;
			object obj33 = !flag22;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
			if (!((UnityEngine.Object)0 != null))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj34 = 0;
				text = (string)obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
				obj13 = (UnityEngine.Object)0;
				text5 = text4;
				goto IL_69c8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
			bool flag23 = (nint)0 == 0;
			num = 0;
			num2 = 0;
			num3 = 0;
			text6 = text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
			obj29 = (UnityEngine.Object)0;
			color = (Color32)0;
			obj8 = null;
			gillaModeRound = round;
			if (!flag23)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
				text2 = ((NetworkBootstrap)0).OfflineWhy;
				text5 = text4;
				goto IL_2695;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
			screenFont = (ScreenFont)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			bool flag24 = (object)round == null;
			num = 0;
			flag6 = false;
			num2 = 0;
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
			obj29 = (UnityEngine.Object)0;
			color = (Color32)0;
			obj8 = (UnityEngine.Object)7;
			gillaModeRound = round;
			if (!flag24)
			{
				byte phase = round.Phase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
				bool flag25 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
				object[] array2 = default;
				bool flag26 = array2 == null;
				num = 0;
				flag6 = false;
				num2 = 0;
				num3 = 0;
				byte b3 = phase;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
				obj29 = (UnityEngine.Object)0;
				color = (Color32)0;
				obj8 = (UnityEngine.Object)(&b3);
				gillaModeRound = round;
				if (!flag26)
				{
					object obj35 = default;
					bool flag27 = obj35 == null;
					obj36 = (UnityEngine.Object)(&b3);
					if (!flag27)
					{
						nint num14 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X8_v486 (Il2CppClass<System.Object[]>)+40]");
						obj36 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
						bool flag28 = ex == null;
						color4 = (Color32)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1673 @ X8_v486 (Il2CppClass<System.Object[]>)+40]");
						obj37 = (UnityEngine.Object)0;
						if (flag28)
						{
							goto IL_678d;
						}
					}
					bool flag29 = array2.Length == 0;
					color4 = (Color32)0;
					if (!flag29)
					{
						object obj38 = array2 + 32;
						obj38 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						byte map = round.Map;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
						object obj39 = default;
						bool flag30 = obj39 == null;
						byte b4 = default;
						obj36 = (UnityEngine.Object)(&b4);
						if (!flag30)
						{
							nint num15 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2201 @ X8_v485 (Il2CppClass<System.Object[]>)+40]");
							obj36 = (UnityEngine.Object)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag31 = ex == null;
							color4 = (Color32)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2201 @ X8_v485 (Il2CppClass<System.Object[]>)+40]");
							obj37 = (UnityEngine.Object)0;
							if (flag31)
							{
								goto IL_678d;
							}
						}
						object obj40 = array2.Length & 0xFFFFFFFEL;
						bool flag32 = obj40 == null;
						color4 = (Color32)0;
						if (!flag32)
						{
							object obj41 = array2 + 40;
							obj41 = obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
							object obj42 = default;
							bool flag33 = obj42 == null;
							bool flag34 = default;
							obj36 = (UnityEngine.Object)(&flag34);
							if (!flag33)
							{
								nint num16 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2202 @ X8_v484 (Il2CppClass<System.Object[]>)+40]");
								obj36 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag35 = ex == null;
								color4 = (Color32)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2202 @ X8_v484 (Il2CppClass<System.Object[]>)+40]");
								obj37 = (UnityEngine.Object)0;
								if (flag35)
								{
									goto IL_678d;
								}
							}
							bool flag36 = array2.Length < 2;
							object obj43 = !flag36;
							object obj44 = array2.Length - 2;
							bool flag37 = obj44 == null;
							object obj45 = ~obj43;
							object obj46 = obj45 | flag37;
							color4 = (Color32)0;
							if (obj46 == null)
							{
								object obj47 = array2 + 48;
								obj47 = obj42;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								int num17 = round.VotesFor(0);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								object obj48 = default;
								bool flag38 = obj48 == null;
								obj36 = (UnityEngine.Object)(&num6);
								if (!flag38)
								{
									nint num18 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ X8_v483 (Il2CppClass<System.Object[]>)+40]");
									obj36 = (UnityEngine.Object)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag39 = ex == null;
									color4 = (Color32)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ X8_v483 (Il2CppClass<System.Object[]>)+40]");
									obj37 = (UnityEngine.Object)0;
									if (flag39)
									{
										goto IL_678d;
									}
								}
								object obj49 = array2.Length & 0xFFFFFFFCL;
								bool flag40 = obj49 == null;
								color4 = (Color32)0;
								if (!flag40)
								{
									object obj50 = array2 + 56;
									obj50 = obj48;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									int num19 = round.VotesFor(1);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj51 = default;
									bool flag41 = obj51 == null;
									int num20 = default;
									obj36 = (UnityEngine.Object)(&num20);
									if (!flag41)
									{
										nint num21 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v482 (Il2CppClass<System.Object[]>)+40]");
										obj36 = (UnityEngine.Object)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag42 = ex == null;
										color4 = (Color32)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2204 @ X8_v482 (Il2CppClass<System.Object[]>)+40]");
										obj37 = (UnityEngine.Object)0;
										if (flag42)
										{
											goto IL_678d;
										}
									}
									bool flag43 = array2.Length < 4;
									object obj52 = !flag43;
									object obj53 = array2.Length - 4;
									bool flag44 = obj53 == null;
									object obj54 = ~obj52;
									object obj55 = obj54 | flag44;
									color4 = (Color32)0;
									if (obj55 == null)
									{
										object obj56 = array2 + 64;
										obj56 = obj51;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										int num22 = round.VotesFor(2);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										object obj57 = default;
										bool flag45 = obj57 == null;
										int num23 = default;
										obj36 = (UnityEngine.Object)(&num23);
										if (!flag45)
										{
											nint num24 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2205 @ X8_v481 (Il2CppClass<System.Object[]>)+40]");
											obj36 = (UnityEngine.Object)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag46 = ex == null;
											color4 = (Color32)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2205 @ X8_v481 (Il2CppClass<System.Object[]>)+40]");
											obj37 = (UnityEngine.Object)0;
											if (flag46)
											{
												goto IL_678d;
											}
										}
										bool flag47 = array2.Length < 5;
										object obj58 = !flag47;
										object obj59 = array2.Length - 5;
										bool flag48 = obj59 == null;
										object obj60 = ~obj58;
										object obj61 = obj60 | flag48;
										color4 = (Color32)0;
										if (obj61 == null)
										{
											object obj62 = array2 + 72;
											obj62 = obj57;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											float voteEnds = round.VoteEnds;
											float now = round.Now;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
											object obj63 = 0;
											object obj64 = obj63;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3729 @ X0_v575+E4]");
											bool flag49 = (nint)0 == 0;
											object obj65 = !flag49;
											if (obj65 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
											object obj66 = default;
											bool flag50 = obj66 == null;
											float num25 = default;
											obj36 = (UnityEngine.Object)(&num25);
											if (!flag50)
											{
												nint num26 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2206 @ X8_v479 (Il2CppClass<System.Object[]>)+40]");
												obj36 = (UnityEngine.Object)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
												bool flag51 = ex == null;
												num5 = now;
												color4 = (Color32)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2206 @ X8_v479 (Il2CppClass<System.Object[]>)+40]");
												obj37 = (UnityEngine.Object)0;
												if (flag51)
												{
													goto IL_678d;
												}
											}
											bool flag52 = array2.Length < 6;
											object obj67 = !flag52;
											object obj68 = array2.Length - 6;
											bool flag53 = obj68 == null;
											object obj69 = ~obj67;
											object obj70 = obj69 | flag53;
											num5 = now;
											color4 = (Color32)0;
											if (obj70 == null)
											{
												object obj71 = array2 + 80;
												obj71 = obj66;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82D0]");
												object format = 0;
												string text7 = string.Format((string)format, array2);
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
												float huntEnds = round.HuntEnds;
												float now2 = round.Now;
												object obj72 = obj63;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3886 @ X0_v590+E4]");
												bool flag54 = (nint)0 == 0;
												object obj73 = !flag54;
												if (obj73 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
												object[] array3 = default;
												bool flag55 = array3 == null;
												num = 0;
												flag6 = false;
												num2 = 0;
												num3 = 0;
												float num27 = now2;
												flag2 = false;
												num6 = num17;
												text6 = (string)(object)array3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
												obj29 = (UnityEngine.Object)0;
												num5 = now2;
												color = (Color32)0;
												obj8 = (UnityEngine.Object)(&num27);
												gillaModeRound = round;
												if (flag55)
												{
													goto IL_4c69;
												}
												object obj74 = default;
												bool flag56 = obj74 == null;
												obj36 = (UnityEngine.Object)(&num27);
												if (!flag56)
												{
													nint num28 = (nint)array3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v477 (Il2CppClass<System.Object[]>)+40]");
													obj36 = (UnityEngine.Object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
													bool flag57 = ex == null;
													num5 = now2;
													color4 = (Color32)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2207 @ X8_v477 (Il2CppClass<System.Object[]>)+40]");
													obj37 = (UnityEngine.Object)0;
													if (flag57)
													{
														goto IL_678d;
													}
												}
												bool flag58 = array3.Length == 0;
												num5 = now2;
												color4 = (Color32)0;
												if (!flag58)
												{
													object obj75 = array3 + 32;
													obj75 = obj74;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													float overEnds = round.OverEnds;
													float now3 = round.Now;
													object obj76 = obj63;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4019 @ X0_v601+E4]");
													bool flag59 = (nint)0 == 0;
													object obj77 = !flag59;
													if (obj77 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													object obj78 = default;
													bool flag60 = obj78 == null;
													float num29 = default;
													obj36 = (UnityEngine.Object)(&num29);
													if (!flag60)
													{
														nint num30 = (nint)array3;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2208 @ X8_v475 (Il2CppClass<System.Object[]>)+40]");
														obj36 = (UnityEngine.Object)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
														bool flag61 = ex == null;
														num5 = now3;
														color4 = (Color32)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2208 @ X8_v475 (Il2CppClass<System.Object[]>)+40]");
														obj37 = (UnityEngine.Object)0;
														if (flag61)
														{
															goto IL_678d;
														}
													}
													object obj79 = array3.Length & 0xFFFFFFFEL;
													bool flag62 = obj79 == null;
													num5 = now3;
													color4 = (Color32)0;
													if (!flag62)
													{
														object obj80 = array3 + 40;
														obj80 = obj78;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														(int, int) tuple3 = round.Apes();
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2250]");
														object obj81 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														object obj82 = default;
														bool flag63 = obj82 == null;
														obj36 = (UnityEngine.Object)(&tuple2);
														if (!flag63)
														{
															nint num31 = (nint)array3;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2209 @ X8_v474 (Il2CppClass<System.Object[]>)+40]");
															obj36 = (UnityEngine.Object)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
															bool flag64 = ex == null;
															num5 = now3;
															color4 = (Color32)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2209 @ X8_v474 (Il2CppClass<System.Object[]>)+40]");
															obj37 = (UnityEngine.Object)0;
															if (flag64)
															{
																goto IL_678d;
															}
														}
														bool flag65 = array3.Length < 2;
														object obj83 = !flag65;
														object obj84 = array3.Length - 2;
														bool flag66 = obj84 == null;
														object obj85 = ~obj83;
														object obj86 = obj85 | flag66;
														num5 = now3;
														color4 = (Color32)0;
														if (obj86 == null)
														{
															object obj87 = array3 + 48;
															obj87 = obj82;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															byte winner = round.Winner;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
															object obj88 = default;
															bool flag67 = obj88 == null;
															byte b5 = default;
															obj36 = (UnityEngine.Object)(&b5);
															if (!flag67)
															{
																nint num32 = (nint)array3;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ X8_v473 (Il2CppClass<System.Object[]>)+40]");
																obj36 = (UnityEngine.Object)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																bool flag68 = ex == null;
																num5 = now3;
																color4 = (Color32)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2210 @ X8_v473 (Il2CppClass<System.Object[]>)+40]");
																obj37 = (UnityEngine.Object)0;
																if (flag68)
																{
																	goto IL_678d;
																}
															}
															object obj89 = array3.Length & 0xFFFFFFFCL;
															bool flag69 = obj89 == null;
															num5 = now3;
															color4 = (Color32)0;
															if (!flag69)
															{
																object obj90 = array3 + 56;
																obj90 = obj88;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																byte startMonsters = round.StartMonsters;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																object obj91 = default;
																bool flag70 = obj91 == null;
																byte b6 = default;
																obj36 = (UnityEngine.Object)(&b6);
																if (!flag70)
																{
																	nint num33 = (nint)array3;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v472 (Il2CppClass<System.Object[]>)+40]");
																	obj36 = (UnityEngine.Object)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																	bool flag71 = ex == null;
																	num5 = now3;
																	color4 = (Color32)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2211 @ X8_v472 (Il2CppClass<System.Object[]>)+40]");
																	obj37 = (UnityEngine.Object)0;
																	if (flag71)
																	{
																		goto IL_678d;
																	}
																}
																bool flag72 = array3.Length < 4;
																object obj92 = !flag72;
																object obj93 = array3.Length - 4;
																bool flag73 = obj93 == null;
																object obj94 = ~obj92;
																object obj95 = obj94 | flag73;
																num5 = now3;
																color4 = (Color32)0;
																if (obj95 == null)
																{
																	object obj96 = array3 + 64;
																	obj96 = obj91;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	int monstersNext = round.MonstersNext;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																	object obj97 = default;
																	bool flag74 = obj97 == null;
																	int num34 = default;
																	obj36 = (UnityEngine.Object)(&num34);
																	if (!flag74)
																	{
																		nint num35 = (nint)array3;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2212 @ X8_v471 (Il2CppClass<System.Object[]>)+40]");
																		obj36 = (UnityEngine.Object)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																		bool flag75 = ex == null;
																		num5 = now3;
																		color4 = (Color32)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2212 @ X8_v471 (Il2CppClass<System.Object[]>)+40]");
																		obj37 = (UnityEngine.Object)0;
																		if (flag75)
																		{
																			goto IL_678d;
																		}
																	}
																	bool flag76 = array3.Length < 5;
																	object obj98 = !flag76;
																	object obj99 = array3.Length - 5;
																	bool flag77 = obj99 == null;
																	object obj100 = ~obj98;
																	object obj101 = obj100 | flag77;
																	num5 = now3;
																	color4 = (Color32)0;
																	if (obj101 == null)
																	{
																		object obj102 = array3 + 72;
																		obj102 = obj97;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																		object obj103 = default;
																		bool flag78 = obj103 == null;
																		bool flag79 = default;
																		obj36 = (UnityEngine.Object)(&flag79);
																		if (!flag78)
																		{
																			nint num36 = (nint)array3;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2213 @ X8_v470 (Il2CppClass<System.Object[]>)+40]");
																			obj36 = (UnityEngine.Object)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																			bool flag80 = ex == null;
																			num5 = now3;
																			color4 = (Color32)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2213 @ X8_v470 (Il2CppClass<System.Object[]>)+40]");
																			obj37 = (UnityEngine.Object)0;
																			if (flag80)
																			{
																				goto IL_678d;
																			}
																		}
																		bool flag81 = array3.Length < 6;
																		object obj104 = !flag81;
																		object obj105 = array3.Length - 6;
																		bool flag82 = obj105 == null;
																		object obj106 = ~obj104;
																		object obj107 = obj106 | flag82;
																		num5 = now3;
																		color4 = (Color32)0;
																		if (obj107 == null)
																		{
																			object obj108 = array3 + 80;
																			obj108 = obj103;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																			object obj109 = default;
																			bool flag83 = obj109 == null;
																			bool flag84 = default;
																			obj36 = (UnityEngine.Object)(&flag84);
																			if (!flag83)
																			{
																				nint num37 = (nint)array3;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2214 @ X8_v469 (Il2CppClass<System.Object[]>)+40]");
																				obj36 = (UnityEngine.Object)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																				bool flag85 = ex == null;
																				num5 = now3;
																				color4 = (Color32)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2214 @ X8_v469 (Il2CppClass<System.Object[]>)+40]");
																				obj37 = (UnityEngine.Object)0;
																				if (flag85)
																				{
																					goto IL_678d;
																				}
																			}
																			object obj110 = array3.Length & 0xFFFFFFF8L;
																			bool flag86 = obj110 == null;
																			num5 = now3;
																			color4 = (Color32)0;
																			if (!flag86)
																			{
																				object obj111 = array3 + 88;
																				obj111 = obj109;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																				object obj112 = default;
																				bool flag87 = obj112 == null;
																				bool flag88 = default;
																				obj36 = (UnityEngine.Object)(&flag88);
																				if (!flag87)
																				{
																					nint num38 = (nint)array3;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2215 @ X8_v468 (Il2CppClass<System.Object[]>)+40]");
																					obj36 = (UnityEngine.Object)0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																					bool flag89 = ex == null;
																					num5 = now3;
																					color4 = (Color32)0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2215 @ X8_v468 (Il2CppClass<System.Object[]>)+40]");
																					obj37 = (UnityEngine.Object)0;
																					if (flag89)
																					{
																						goto IL_678d;
																					}
																				}
																				bool flag90 = array3.Length < 8;
																				object obj113 = !flag90;
																				object obj114 = array3.Length - 8;
																				bool flag91 = obj114 == null;
																				object obj115 = ~obj113;
																				object obj116 = obj115 | flag91;
																				num5 = now3;
																				color4 = (Color32)0;
																				if (obj116 == null)
																				{
																					object obj117 = array3 + 96;
																					obj117 = obj112;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																					bool enough = round.Enough;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																					object obj118 = default;
																					bool flag92 = obj118 == null;
																					object obj119 = default;
																					obj36 = (UnityEngine.Object)(&obj119);
																					if (!flag92)
																					{
																						nint num39 = (nint)array3;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2216 @ X8_v467 (Il2CppClass<System.Object[]>)+40]");
																						obj36 = (UnityEngine.Object)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																						bool flag93 = ex == null;
																						num5 = now3;
																						color4 = (Color32)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2216 @ X8_v467 (Il2CppClass<System.Object[]>)+40]");
																						obj37 = (UnityEngine.Object)0;
																						if (flag93)
																						{
																							goto IL_678d;
																						}
																					}
																					bool flag94 = array3.Length < 9;
																					object obj120 = !flag94;
																					object obj121 = array3.Length - 9;
																					bool flag95 = obj121 == null;
																					object obj122 = ~obj120;
																					object obj123 = obj122 | flag95;
																					num5 = now3;
																					color4 = (Color32)0;
																					if (obj123 == null)
																					{
																						object obj124 = array3 + 104;
																						obj124 = obj118;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2280]");
																						object format2 = 0;
																						string text8 = string.Format((string)format2, array3);
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																						byte mode = round.Mode;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																						object[] array4 = default;
																						bool flag96 = array4 == null;
																						num = 0;
																						flag6 = false;
																						num2 = 0;
																						num3 = 0;
																						byte b7 = mode;
																						object[] array5 = array4;
																						flag2 = false;
																						num6 = num17;
																						text6 = text8;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
																						obj29 = (UnityEngine.Object)0;
																						num5 = now3;
																						tuple2 = tuple3;
																						color = (Color32)0;
																						obj8 = (UnityEngine.Object)(&b7);
																						gillaModeRound = round;
																						if (flag96)
																						{
																							goto IL_4c69;
																						}
																						object obj125 = default;
																						bool flag97 = obj125 == null;
																						obj36 = (UnityEngine.Object)(&b7);
																						if (!flag97)
																						{
																							nint num40 = (nint)array4;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2217 @ X8_v466 (Il2CppClass<System.Object[]>)+40]");
																							obj36 = (UnityEngine.Object)0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																							bool flag98 = ex == null;
																							num5 = now3;
																							color4 = (Color32)0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2217 @ X8_v466 (Il2CppClass<System.Object[]>)+40]");
																							obj37 = (UnityEngine.Object)0;
																							if (flag98)
																							{
																								goto IL_678d;
																							}
																						}
																						bool flag99 = array4.Length == 0;
																						num5 = now3;
																						color4 = (Color32)0;
																						if (!flag99)
																						{
																							object obj126 = array4 + 32;
																							obj126 = obj125;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																							object obj127 = default;
																							bool flag100 = obj127 == null;
																							byte b8 = default;
																							obj36 = (UnityEngine.Object)(&b8);
																							if (!flag100)
																							{
																								nint num41 = (nint)array4;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2218 @ X8_v465 (Il2CppClass<System.Object[]>)+40]");
																								obj36 = (UnityEngine.Object)0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																								bool flag101 = ex == null;
																								num5 = now3;
																								color4 = (Color32)0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2218 @ X8_v465 (Il2CppClass<System.Object[]>)+40]");
																								obj37 = (UnityEngine.Object)0;
																								if (flag101)
																								{
																									goto IL_678d;
																								}
																							}
																							object obj128 = array4.Length & 0xFFFFFFFEL;
																							bool flag102 = obj128 == null;
																							num5 = now3;
																							color4 = (Color32)0;
																							if (!flag102)
																							{
																								object obj129 = array4 + 40;
																								obj129 = obj127;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																								int num42 = round.ModeVotesFor(0);
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																								object obj130 = default;
																								bool flag103 = obj130 == null;
																								int num43 = default;
																								obj36 = (UnityEngine.Object)(&num43);
																								if (!flag103)
																								{
																									nint num44 = (nint)array4;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ X8_v464 (Il2CppClass<System.Object[]>)+40]");
																									obj36 = (UnityEngine.Object)0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																									bool flag104 = ex == null;
																									num5 = now3;
																									color4 = (Color32)0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ X8_v464 (Il2CppClass<System.Object[]>)+40]");
																									obj37 = (UnityEngine.Object)0;
																									if (flag104)
																									{
																										goto IL_678d;
																									}
																								}
																								bool flag105 = array4.Length < 2;
																								object obj131 = !flag105;
																								object obj132 = array4.Length - 2;
																								bool flag106 = obj132 == null;
																								object obj133 = ~obj131;
																								object obj134 = obj133 | flag106;
																								num5 = now3;
																								color4 = (Color32)0;
																								if (obj134 == null)
																								{
																									object obj135 = array4 + 48;
																									obj135 = obj130;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																									int num45 = round.ModeVotesFor(1);
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																									object obj136 = default;
																									bool flag107 = obj136 == null;
																									int num46 = default;
																									obj36 = (UnityEngine.Object)(&num46);
																									if (!flag107)
																									{
																										nint num47 = (nint)array4;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2220 @ X8_v463 (Il2CppClass<System.Object[]>)+40]");
																										obj36 = (UnityEngine.Object)0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																										bool flag108 = ex == null;
																										num5 = now3;
																										color4 = (Color32)0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2220 @ X8_v463 (Il2CppClass<System.Object[]>)+40]");
																										obj37 = (UnityEngine.Object)0;
																										if (flag108)
																										{
																											goto IL_678d;
																										}
																									}
																									object obj137 = array4.Length & 0xFFFFFFFCL;
																									bool flag109 = obj137 == null;
																									num5 = now3;
																									color4 = (Color32)0;
																									if (!flag109)
																									{
																										object obj138 = array4 + 56;
																										obj138 = obj136;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																										int num48 = round.ModeVotesFor(2);
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																										object obj139 = default;
																										bool flag110 = obj139 == null;
																										int num49 = default;
																										obj36 = (UnityEngine.Object)(&num49);
																										if (!flag110)
																										{
																											nint num50 = (nint)array4;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2221 @ X8_v462 (Il2CppClass<System.Object[]>)+40]");
																											obj36 = (UnityEngine.Object)0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																											bool flag111 = ex == null;
																											num5 = now3;
																											color4 = (Color32)0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2221 @ X8_v462 (Il2CppClass<System.Object[]>)+40]");
																											obj37 = (UnityEngine.Object)0;
																											if (flag111)
																											{
																												goto IL_678d;
																											}
																										}
																										bool flag112 = array4.Length < 4;
																										object obj140 = !flag112;
																										object obj141 = array4.Length - 4;
																										bool flag113 = obj141 == null;
																										object obj142 = ~obj140;
																										object obj143 = obj142 | flag113;
																										num5 = now3;
																										color4 = (Color32)0;
																										if (obj143 == null)
																										{
																											object obj144 = array4 + 64;
																											obj144 = obj139;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																											float modeEnds = round.ModeEnds;
																											num5 = round.Now;
																											object obj145 = obj63;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4822 @ X0_v712+E4]");
																											bool flag114 = (nint)0 == 0;
																											object obj146 = !flag114;
																											if (obj146 == null)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
																											flag2 = false;
																											object obj147 = default;
																											bool flag115 = obj147 == null;
																											float num51 = default;
																											obj36 = (UnityEngine.Object)(&num51);
																											if (!flag115)
																											{
																												nint num52 = (nint)array4;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2222 @ X8_v460 (Il2CppClass<System.Object[]>)+40]");
																												obj36 = (UnityEngine.Object)0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																												bool flag116 = ex == null;
																												color4 = (Color32)0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2222 @ X8_v460 (Il2CppClass<System.Object[]>)+40]");
																												obj37 = (UnityEngine.Object)0;
																												if (flag116)
																												{
																													goto IL_678d;
																												}
																											}
																											bool flag117 = array4.Length < 5;
																											object obj148 = !flag117;
																											object obj149 = array4.Length - 5;
																											bool flag118 = obj149 == null;
																											object obj150 = ~obj148;
																											object obj151 = obj150 | flag118;
																											color4 = (Color32)0;
																											if (obj151 == null)
																											{
																												object obj152 = array4 + 72;
																												obj152 = obj147;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																												int num53 = round.HuntersIn((PlayerRef)0);
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																												object obj153 = default;
																												bool flag119 = obj153 == null;
																												int num54 = default;
																												obj36 = (UnityEngine.Object)(&num54);
																												if (!flag119)
																												{
																													nint num55 = (nint)array4;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2223 @ X8_v459 (Il2CppClass<System.Object[]>)+40]");
																													obj36 = (UnityEngine.Object)0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																													bool flag120 = ex == null;
																													color4 = (Color32)0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2223 @ X8_v459 (Il2CppClass<System.Object[]>)+40]");
																													obj37 = (UnityEngine.Object)0;
																													if (flag120)
																													{
																														goto IL_678d;
																													}
																												}
																												bool flag121 = array4.Length < 6;
																												object obj154 = !flag121;
																												object obj155 = array4.Length - 6;
																												bool flag122 = obj155 == null;
																												object obj156 = ~obj154;
																												object obj157 = obj156 | flag122;
																												color4 = (Color32)0;
																												if (obj157 == null)
																												{
																													object obj158 = array4 + 80;
																													obj158 = obj153;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
																													object obj159 = 0;
																													object obj160 = obj159;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4860 @ X0_v728+E4]");
																													bool flag123 = (nint)0 == 0;
																													object obj161 = !flag123;
																													if (obj161 == null)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																													}
																													bool flag124 = Hunts(round);
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
																													ScreenFont screenFont2 = default;
																													bool flag125 = screenFont2 == null;
																													object obj162 = default;
																													obj36 = (UnityEngine.Object)(&obj162);
																													if (!flag125)
																													{
																														nint num56 = (nint)array4;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2224 @ X8_v458 (Il2CppClass<System.Object[]>)+40]");
																														obj36 = (UnityEngine.Object)0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
																														bool flag126 = ex == null;
																														color4 = (Color32)0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2224 @ X8_v458 (Il2CppClass<System.Object[]>)+40]");
																														obj37 = (UnityEngine.Object)0;
																														if (flag126)
																														{
																															goto IL_678d;
																														}
																													}
																													object obj163 = array4.Length & 0xFFFFFFF8L;
																													bool flag127 = obj163 == null;
																													color4 = (Color32)0;
																													if (!flag127)
																													{
																														object obj164 = array4 + 88;
																														obj164 = screenFont2;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2310]");
																														object format3 = 0;
																														text2 = string.Format((string)format3, array4);
																														flag6 = false;
																														array5 = array4;
																														num6 = num17;
																														text5 = text8;
																														screenFont = screenFont2;
																														tuple2 = tuple3;
																														text3 = text7;
																														goto IL_2695;
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
											}
										}
									}
								}
							}
						}
					}
					goto IL_6777;
				}
			}
		}
		goto IL_4c69;
		IL_678d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_69c8:
		string text9 = text3 + text5 + text;
		bool value7 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ X0_v327 (System.Boolean)+E4]");
		bool flag128 = (nint)0 == 0;
		object obj165 = !flag128;
		if (obj165 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag129 = (UnityEngine.Object)round != (UnityEngine.Object)null;
		bool flag130 = !flag129;
		Color32 color5 = (Color32)0;
		PlayerRef playerRef2 = (PlayerRef)0;
		string text10 = null;
		if (!flag130)
		{
			bool flag131 = (object)round == null;
			num = 0;
			num2 = 0;
			num3 = 0;
			text6 = text9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
			obj29 = (UnityEngine.Object)0;
			num8 = 0;
			color = (Color32)0;
			obj8 = null;
			gillaModeRound = round;
			if (flag131)
			{
				goto IL_4c69;
			}
			bool enough2 = round.Enough;
			bool flag132 = !enough2;
			color5 = (Color32)0;
			playerRef2 = (PlayerRef)0;
			text10 = null;
			if (!flag132)
			{
				if (round.OthersTurn(playerRef))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2288]");
					object obj166 = 0;
					text10 = (string)obj166;
					color5 = (Color32)0;
					playerRef2 = playerRef;
				}
				else
				{
					num5 = round.MonsterChance(playerRef);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
					object obj167 = 0;
					object obj168 = obj167;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3062 @ X0_v519+E4]");
					bool flag133 = (nint)0 == 0;
					object obj169 = !flag133;
					if (obj169 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text11 = ChanceText(num5);
					color5 = (Color32)0;
					playerRef2 = playerRef;
					text10 = text11;
				}
			}
		}
		bool value8 = ((bool*)(flag2 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2582 @ X0_v332 (System.Boolean)+E4]");
		bool flag134 = (nint)0 == 0;
		object obj170 = !flag134;
		if (obj170 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenFont screenFont4;
		if ((UnityEngine.Object)round != (UnityEngine.Object)null)
		{
			bool flag135 = (object)round == null;
			num = 0;
			num2 = 0;
			num3 = 0;
			text6 = text9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
			obj29 = (UnityEngine.Object)0;
			num8 = 0;
			color = (Color32)0;
			obj8 = null;
			gillaModeRound = round;
			if (flag135)
			{
				goto IL_4c69;
			}
			int monstersNext2 = round.MonstersNext;
			object obj171 = monstersNext2 - 1;
			bool flag136 = (nint)obj171 < 0;
			bool flag137 = obj171 == null;
			int num57 = monstersNext2 ^ 1;
			int num58 = monstersNext2 ^ obj171;
			int num59 = num57 & num58;
			bool flag138 = num59 < 0;
			bool flag139 = flag136 == flag138;
			object obj172 = !flag137;
			ScreenFont screenFont3 = (ScreenFont)(flag139 & obj172);
			screenFont4 = screenFont3;
		}
		else
		{
			screenFont4 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj173 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		string[] array6 = default;
		bool flag140 = array6 == null;
		num = 0;
		num2 = 0;
		num3 = 0;
		text6 = text9;
		screenFont = screenFont4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
		obj29 = (UnityEngine.Object)0;
		num8 = 0;
		color = (Color32)0;
		obj8 = (UnityEngine.Object)5;
		gillaModeRound = round;
		if (flag140)
		{
			goto IL_4c69;
		}
		bool flag141 = array6.Length == 0;
		num8 = 0;
		color4 = (Color32)0;
		obj36 = (UnityEngine.Object)5;
		if (!flag141)
		{
			object[] array5 = (object[])(array6 + 32);
			array5 = (object[])(object)text9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2315 @ X26_v35 (System.Object[])-8]");
			object obj174 = 0 & 0xFFFFFFFEL;
			bool flag142 = obj174 == null;
			num8 = 0;
			color4 = (Color32)0;
			obj36 = (UnityEngine.Object)(object)text9;
			if (!flag142)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61F0]");
				object obj175 = 0;
				object obj176 = array6 + 40;
				obj176 = obj175;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				bool value9 = ((bool*)(flag2 ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3174 @ X0_v344 (System.Boolean)+E4]");
				bool flag143 = (nint)0 == 0;
				object obj177 = !flag143;
				if (obj177 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (obj13 != null)
				{
					bool flag144 = (object)obj13 == null;
					num = 0;
					num2 = 0;
					num3 = 0;
					text6 = text9;
					bool flag25 = flag13;
					screenFont = screenFont4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
					obj29 = (UnityEngine.Object)0;
					num8 = 0;
					color = (Color32)0;
					obj8 = null;
					gillaModeRound = round;
					if (flag144)
					{
						goto IL_4c69;
					}
					int playerCount = ((NetworkBootstrap)obj13).PlayerCount;
				}
				string text12 = num.ToString();
				bool flag145 = array6.Length < 2;
				object obj178 = !flag145;
				object obj179 = array6.Length - 2;
				bool flag146 = obj179 == null;
				object obj180 = ~obj178;
				object obj181 = obj180 | flag146;
				num8 = 0;
				color4 = (Color32)0;
				obj36 = null;
				if (obj181 == null)
				{
					object obj182 = array6 + 48;
					obj182 = text12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1777 @ X25_v28-18]");
					object obj183 = 0 & 0xFFFFFFFCL;
					bool flag147 = obj183 == null;
					num8 = 0;
					color4 = (Color32)0;
					obj36 = (UnityEngine.Object)(object)text12;
					if (!flag147)
					{
						obj36 = (UnityEngine.Object)obj175;
						object obj184 = array6 + 56;
						obj184 = obj175;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X25_v30-20]");
						bool flag148 = (nint)0 < (nint)4;
						object obj185 = !flag148;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X25_v30-20]");
						object obj186 = -4;
						bool flag149 = obj186 == null;
						object obj187 = ~obj185;
						object obj188 = obj187 | flag149;
						num8 = 0;
						color4 = (Color32)0;
						if (obj188 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6960]");
							object obj189 = 0;
							bool flag150 = text10 != null;
							string text13 = (string)(flag150 ? text10 : obj189);
							object obj190 = array6 + 64;
							obj190 = text13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							string text14 = string.Concat(array6);
							object obj191 = this + 232;
							bool flag151 = text14 == (string)obj191;
							bool flag152 = !flag151;
							object obj192 = !flag152;
							if (obj192 != null)
							{
								return;
							}
							drawn = text14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Canvas[] array7 = panelCanvas;
							bool flag153 = panelCanvas == null;
							num2 = 0;
							num3 = 0;
							string text15 = text10;
							ScreenFont screenFont5 = screenFont4;
							text6 = text14;
							bool flag25 = flag13;
							screenFont = screenFont4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
							obj29 = (UnityEngine.Object)0;
							num8 = 0;
							color = (Color32)0;
							obj8 = (UnityEngine.Object)(object)text14;
							gillaModeRound = round;
							if (!flag153)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
								flag25 = false;
								(int, int) tuple4 = ((int, int))((flag13 ? 1 : 0) & 0xFF);
								bool flag155 = default;
								bool flag154 = flag155;
								num3 = 0;
								int num61 = default;
								int num60 = num61;
								Color32[] array9 = default;
								Color32[] array8 = array9;
								string text17 = default;
								string text16 = text17;
								MapEntry[] array10 = array;
								object[] array11 = array5;
								bool flag156 = flag2;
								string text18 = text14;
								ScreenFont screenFont6 = screenFont4;
								bool flag157 = flag150;
								int num62 = 0;
								float num63 = num5;
								int num64 = 0;
								color4 = (Color32)0;
								obj36 = (UnityEngine.Object)(object)text14;
								string text19 = text10;
								object obj243 = default;
								object arg2 = default;
								object obj252 = default;
								object arg5 = default;
								object arg6 = default;
								object arg7 = default;
								object arg8 = default;
								object arg9 = default;
								object arg10 = default;
								object arg11 = default;
								object arg12 = default;
								object obj272 = default;
								object obj288 = default;
								int num85 = default;
								object obj339;
								Texture2D texture2D2 = default;
								int num107 = default;
								object arg13 = default;
								object arg14 = default;
								do
								{
									bool flag158 = num64 >= array7.Length;
									num2 = 0;
									flag155 = flag154;
									num61 = num60;
									array9 = array8;
									text17 = text16;
									array = array10;
									text15 = text10;
									screenFont5 = screenFont4;
									array5 = array11;
									flag2 = flag156;
									tuple = ((int, int))num6;
									text6 = text18;
									screenFont = screenFont6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
									obj29 = (UnityEngine.Object)0;
									flag150 = flag157;
									num8 = num62;
									num5 = num63;
									num7 = (int)tuple2;
									color = color4;
									obj8 = obj36;
									gillaModeRound = round;
									if (!flag158)
									{
										array = maps;
										bool flag159 = maps == null;
										num2 = 0;
										flag155 = flag154;
										num61 = num60;
										array9 = array8;
										text17 = text16;
										text15 = text10;
										screenFont5 = screenFont4;
										array5 = array11;
										flag2 = flag156;
										text6 = text18;
										screenFont = screenFont6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										flag150 = flag157;
										num8 = num62;
										num5 = num63;
										color = color4;
										obj8 = obj36;
										gillaModeRound = round;
										if (flag159)
										{
											break;
										}
										array = (MapEntry[])array.Length;
										bool flag160 = num64 >= array.Length;
										num2 = 0;
										flag155 = flag154;
										num61 = num60;
										array9 = array8;
										text17 = text16;
										text15 = text10;
										screenFont5 = screenFont4;
										array5 = array11;
										flag2 = flag156;
										tuple = ((int, int))num6;
										text6 = text18;
										screenFont = screenFont6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										flag150 = flag157;
										num8 = num62;
										num5 = num63;
										num7 = (int)tuple2;
										color = color4;
										obj8 = obj36;
										gillaModeRound = round;
										if (!flag160)
										{
											bool flag161 = num64 < array7.Length;
											object obj193 = !flag161;
											flag155 = flag154;
											num61 = num60;
											array9 = array8;
											text17 = text16;
											num8 = num62;
											num5 = num63;
											if (obj193 != null)
											{
												goto IL_6777;
											}
											object obj194 = array7 + num64;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3899 @ X8_v258+20]");
											text6 = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3899 @ X8_v258+20]");
											if ((nint)0 == 0)
											{
												goto IL_4b85;
											}
											bool value10 = ((bool*)(flag25 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3946 @ X0_v366 (System.Boolean)+E4]");
											bool flag162 = (nint)0 == 0;
											object obj195 = !flag162;
											if (obj195 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												value10 = ((bool*)(flag25 ? 1 : 0))->m_value;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3946 @ X0_v366 (System.Boolean)+A0]");
											object obj196 = 0;
											string text20 = text6;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3948 @ X8_v262+C]");
											nint num65 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3948 @ X8_v262+10]");
											((Canvas)(object)text20).Clear((Color32)num65, (Color32)0);
											bool value11 = ((bool*)(flag156 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3955 @ X0_v368 (System.Boolean)+E4]");
											bool flag163 = (nint)0 == 0;
											object obj197 = !flag163;
											if (obj197 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag164 = (UnityEngine.Object)round != (UnityEngine.Object)null;
											bool flag165 = !flag164;
											UnityEngine.Object obj198 = null;
											if (!flag165)
											{
												bool flag166 = (object)round == null;
												num2 = 0;
												flag155 = flag154;
												num61 = num60;
												array9 = array8;
												text17 = text16;
												text15 = text10;
												screenFont5 = screenFont4;
												array5 = array11;
												flag2 = flag156;
												screenFont = screenFont6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
												obj29 = (UnityEngine.Object)0;
												flag150 = flag157;
												num8 = num62;
												num5 = num63;
												color = (Color32)0;
												obj8 = null;
												gillaModeRound = round;
												if (flag166)
												{
													break;
												}
												byte phase2 = round.Phase;
												int num66 = phase2 & 0xFF;
												bool flag167 = num66 != 3;
												obj198 = null;
												if (!flag167)
												{
													DrawModePanel((Canvas)(object)text6, num64, round, b2);
													text16 = (string)b2;
													num62 = (int)round;
													color4 = (Color32)num64;
													obj36 = (UnityEngine.Object)(object)text6;
													goto IL_4b77;
												}
											}
											bool value12 = ((bool*)(flag156 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4003 @ X0_v375 (System.Boolean)+E4]");
											bool flag168 = (nint)0 == 0;
											object obj199 = !flag168;
											if (obj199 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag169 = (UnityEngine.Object)round != (UnityEngine.Object)null;
											bool flag170 = !flag169;
											UnityEngine.Object obj200 = null;
											if (!flag170)
											{
												bool flag171 = (object)round == null;
												num2 = 0;
												flag155 = flag154;
												num61 = num60;
												array9 = array8;
												text17 = text16;
												text15 = text10;
												screenFont5 = screenFont4;
												array5 = array11;
												flag2 = flag156;
												screenFont = screenFont6;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
												obj29 = (UnityEngine.Object)0;
												flag150 = flag157;
												num8 = num62;
												num5 = num63;
												color = (Color32)0;
												obj8 = null;
												gillaModeRound = round;
												if (flag171)
												{
													break;
												}
												byte phase3 = round.Phase;
												int num67 = phase3 & 0xFF;
												bool flag172 = num67 == 0;
												obj200 = null;
												if (flag172)
												{
													object obj201 = num64 - tuple4;
													bool flag173 = obj201 == null;
													obj200 = null;
													text19 = (string)flag173;
													goto IL_6d90;
												}
											}
											text19 = null;
											goto IL_6d90;
										}
									}
									if (boardCanvas == null)
									{
										return;
									}
									bool value13 = ((bool*)(flag25 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1234 @ X0_v18 (System.Boolean)+E4]");
									bool flag174 = (nint)0 == 0;
									object obj202 = !flag174;
									if (obj202 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										value13 = ((bool*)(flag25 ? 1 : 0))->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1234 @ X0_v18 (System.Boolean)+A0]");
									object obj203 = 0;
									Canvas canvas = boardCanvas;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X8_v13+C]");
									nint num68 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X8_v13+10]");
									canvas.Clear((Color32)num68, (Color32)0);
									bool value14 = ((bool*)(flag25 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X8_v14 (System.Boolean)+A0]");
									object obj204 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X8_v15+18]");
									object obj205 = 0;
									boardCanvas.Outline((RectInt)0, (Color32)549755814400L);
									Color32 color6 = (Color32)549755814400L;
									RectInt rectInt = (RectInt)0;
									object obj206 = -6;
									object obj210;
									do
									{
										bool value15 = ((bool*)(flag25 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X0_v23 (System.Boolean)+E4]");
										bool flag175 = (nint)0 == 0;
										object obj207 = !flag175;
										if (obj207 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value15 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X0_v23 (System.Boolean)+A0]");
										object obj208 = 0;
										rectInt = (RectInt)(obj206 + 8589934606L);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1477 @ X8_v18+14]");
										obj205 = 0;
										boardCanvas.Fill(rectInt, (Color32)8589934600L);
										obj206 += 14;
										bool flag176 = (nint)obj206 < 490;
										object obj209 = !flag176;
										obj210 = ~obj209;
										color6 = (Color32)8589934600L;
									}
									while (obj210 != null);
									bool value16 = ((bool*)(flag25 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1553 @ X0_v26 (System.Boolean)+E4]");
									bool flag177 = (nint)0 == 0;
									object obj211 = !flag177;
									if (obj211 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										value16 = ((bool*)(flag25 ? 1 : 0))->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1553 @ X0_v26 (System.Boolean)+A0]");
									object obj212 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC518]");
									object obj213 = 0;
									text17 = (string)obj213;
									Canvas canvas2 = boardCanvas;
									ScreenFont font = title;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
									canvas2.Text(font, 256, 8, (string)obj213, (Color32[])0, 2, centred: true);
									bool value17 = ((bool*)(flag2 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1573 @ X0_v28 (System.Boolean)+E4]");
									bool flag178 = (nint)0 == 0;
									object obj214 = !flag178;
									if (obj214 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									int num69;
									if (obj29 != null)
									{
										bool flag179 = (object)obj29 == null;
										flag155 = true;
										num61 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
										array9 = (Color32[])0;
										num6 = (int)tuple;
										num8 = 8;
										tuple2 = ((int, int))num7;
										color = (Color32)0;
										obj8 = null;
										if (flag179)
										{
											break;
										}
										num69 = ((NetworkBootstrap)obj29).PlayerCount;
										UnityEngine.Object obj215 = null;
									}
									else
									{
										UnityEngine.Object obj215 = null;
										num69 = 0;
									}
									bool value18 = ((bool*)(flag2 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v22 (System.Boolean)+E4]");
									bool flag180 = (nint)0 == 0;
									object obj216 = !flag180;
									if (obj216 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									string text21;
									string text23;
									Color32[] array12;
									string text25;
									(int, int) tuple6;
									int num75;
									string text26;
									object arg3;
									object obj248;
									if ((UnityEngine.Object)gillaModeRound == (UnityEngine.Object)null)
									{
										bool value19 = ((bool*)(flag2 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1667 @ X0_v277 (System.Boolean)+E4]");
										bool flag181 = (nint)0 == 0;
										object obj217 = !flag181;
										if (obj217 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										bool flag182 = obj29 != null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82F8]");
										object obj218 = 0;
										if (flag182)
										{
											bool flag183 = (object)obj29 == null;
											num2 = num69;
											flag155 = true;
											num61 = 2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
											array9 = (Color32[])0;
											num6 = (int)tuple;
											num8 = 8;
											tuple2 = ((int, int))num7;
											color = (Color32)0;
											obj8 = null;
											if (flag183)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2783 @ stack_-190_v6 (UnityEngine.Object)+A4]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82D8]");
												obj218 = 0;
											}
										}
										bool value20 = ((bool*)(flag25 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8240]");
										object obj219 = 0;
										text21 = (string)obj218;
										text6 = (string)obj219;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2274 @ X0_v282 (System.Boolean)+E4]");
										bool flag184 = (nint)0 == 0;
										object obj220 = !flag184;
										if (obj220 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value20 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										bool value21 = ((bool*)(flag2 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2274 @ X0_v282 (System.Boolean)+A0]");
										object obj221 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v225 (System.Boolean)+E4]");
										array = (MapEntry[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X9_v60+40]");
										array5 = (object[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v225 (System.Boolean)+E4]");
										bool flag185 = (nint)0 == 0;
										object obj222 = !flag185;
										if (obj222 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										string text22;
										if (obj29 != null)
										{
											bool flag186 = (object)obj29 == null;
											num2 = num69;
											flag155 = true;
											num61 = 2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
											array9 = (Color32[])0;
											num6 = (int)tuple;
											num8 = 8;
											tuple2 = ((int, int))num7;
											color = (Color32)0;
											obj8 = null;
											if (flag186)
											{
												break;
											}
											text22 = ((NetworkBootstrap)obj29).OfflineWhy;
											obj8 = null;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
											object obj223 = 0;
											text22 = (string)obj223;
											obj8 = null;
										}
										bool flag187 = text22 == null;
										num2 = num69;
										flag155 = true;
										num61 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
										array9 = (Color32[])0;
										num6 = (int)tuple;
										num8 = 8;
										tuple2 = ((int, int))num7;
										color = (Color32)0;
										if (flag187)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2320]");
										object obj224 = 0;
										bool flag188 = text22._stringLength < 0;
										bool flag189 = text22._stringLength == 0;
										int num70 = text22._stringLength ^ text22._stringLength;
										int num71 = text22._stringLength & num70;
										bool flag190 = num71 < 0;
										bool flag191 = flag188 == flag190;
										object obj172 = !flag189;
										object obj225 = flag191 & obj172;
										text23 = (string)(((int)(~obj225) != 0) ? obj224 : text22);
										array12 = (Color32[])(object)array5;
										num6 = (int)tuple;
										tuple2 = ((int, int))num7;
									}
									else
									{
										bool flag192 = (object)gillaModeRound == null;
										num2 = num69;
										flag155 = true;
										num61 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
										array9 = (Color32[])0;
										num6 = (int)tuple;
										num8 = 8;
										tuple2 = ((int, int))num7;
										color = (Color32)0;
										obj8 = null;
										if (flag192)
										{
											break;
										}
										byte phase4 = gillaModeRound.Phase;
										if ((phase4 & 0xFF) != 0)
										{
											byte phase5 = gillaModeRound.Phase;
											int num72 = phase5 & 0xFF;
											if (num72 == 3)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2318]");
												object obj226 = 0;
												text21 = (string)obj226;
												float modeEnds2 = gillaModeRound.ModeEnds;
												num5 = gillaModeRound.Now;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
												object obj227 = 0;
												object obj228 = obj227;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ X0_v257+E4]");
												bool flag193 = (nint)0 == 0;
												object obj229 = !flag193;
												if (obj229 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
												bool value22 = ((bool*)(flag25 ? 1 : 0))->m_value;
												object obj230 = ~num5;
												int seconds = num5 & obj230;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2608 @ X0_v259 (System.Boolean)+E4]");
												bool flag194 = (nint)0 == 0;
												object obj231 = !flag194;
												if (obj231 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												string text24 = Clock(seconds);
												bool value23 = ((bool*)(flag25 ? 1 : 0))->m_value;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2707 @ X8_v204 (System.Boolean)+A0]");
												object obj232 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v205+30]");
												array5 = (object[])0;
												byte map2 = gillaModeRound.Map;
												MapEntry[] array13 = maps;
												bool flag195 = maps == null;
												num2 = num69;
												flag155 = true;
												num61 = 2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
												array9 = (Color32[])0;
												num6 = (int)tuple;
												text6 = text24;
												num8 = 8;
												tuple2 = ((int, int))num7;
												color = (Color32)0;
												obj8 = null;
												if (flag195)
												{
													break;
												}
												object obj238;
												if (array13.Length > map2)
												{
													byte map3 = gillaModeRound.Map;
													bool flag196 = array13.Length < map3;
													object obj233 = !flag196;
													object obj234 = array13.Length - map3;
													bool flag197 = obj234 == null;
													object obj235 = ~obj233;
													object obj236 = obj235 | flag197;
													flag155 = true;
													num61 = 2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
													array9 = (Color32[])0;
													num8 = 8;
													color4 = (Color32)0;
													obj36 = null;
													if (obj236 != null)
													{
														goto IL_6777;
													}
													object obj237 = maps + map3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3074 @ X8_v217+20]");
													bool flag198 = (nint)0 == 0;
													num2 = num69;
													flag155 = true;
													num61 = 2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
													array9 = (Color32[])0;
													num6 = (int)tuple;
													text6 = text24;
													num8 = 8;
													tuple2 = ((int, int))num7;
													color = (Color32)0;
													obj8 = null;
													if (flag198)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3074 @ X8_v217+20]");
													obj238 = (nint)0 + (nint)16;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
													obj238 = 0;
												}
												bool twoMonstersOpen = gillaModeRound.TwoMonstersOpen;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2308]");
												object obj239 = 0;
												object obj240;
												if (twoMonstersOpen)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2278]");
													obj240 = 0;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2270]");
													obj240 = 0;
												}
												text25 = (string)obj239 + (string)obj238 + (string)obj240;
												array12 = (Color32[])(object)array5;
												text6 = text24;
												tuple2 = ((int, int))num7;
												goto IL_5b2c;
											}
											byte phase6 = gillaModeRound.Phase;
											int num73 = phase6 & 0xFF;
											if (num73 == 1)
											{
												byte mode2 = gillaModeRound.Mode;
												int num74 = mode2 & 0xFF;
												if (num74 == 1)
												{
													(int, int) tuple5 = gillaModeRound.Apes();
													tuple6 = ((int, int))(tuple5 >> 32);
													num75 = gillaModeRound.HuntersIn((PlayerRef)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22F0]");
													object obj241 = 0;
													text21 = (string)obj241;
													float huntEnds2 = gillaModeRound.HuntEnds;
													float now4 = gillaModeRound.Now;
													num5 = huntEnds2 - now4;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E10774");
													bool value24 = ((bool*)(flag25 ? 1 : 0))->m_value;
													object obj242 = ~obj243;
													int seconds2 = obj243 & obj242;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2980 @ X0_v234 (System.Boolean)+E4]");
													bool flag199 = (nint)0 == 0;
													object obj244 = !flag199;
													if (obj244 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													text26 = Clock(seconds2);
													bool value25 = ((bool*)(flag25 ? 1 : 0))->m_value;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3081 @ X8_v172 (System.Boolean)+A0]");
													object obj245 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3084 @ X8_v173+28]");
													array12 = (Color32[])0;
													if (Hunts(gillaModeRound))
													{
														if (~(inHunt ? 1u : 0u) == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
															object obj246 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2350]");
															object arg = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2330]");
															array = (MapEntry[])0;
															if (tuple6 == ((int, int))(object)1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F98]");
																arg = 0;
															}
															text25 = string.Format((string)(object)array, arg2, arg);
															text6 = text26;
															tuple2 = tuple6;
															goto IL_5b2c;
														}
													}
													else if (~(inHunt ? 1u : 0u) == 0 && ~(outOfIt ? 1u : 0u) != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
														object obj247 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F98]");
														arg3 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2350]");
														obj248 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22F8]");
														array = (MapEntry[])0;
														tuple2 = tuple6;
														goto IL_7d80;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj249 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F98]");
													arg3 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2350]");
													obj248 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22D8]");
													array = (MapEntry[])0;
													tuple2 = tuple6;
													goto IL_7d80;
												}
											}
											byte phase7 = gillaModeRound.Phase;
											int num76 = phase7 & 0xFF;
											if (num76 == 1)
											{
												(int, int) tuple7 = gillaModeRound.Apes();
												byte b9 = (byte)(tuple7 >> 32);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2258]");
												object obj250 = 0;
												text21 = (string)obj250;
												float huntEnds3 = gillaModeRound.HuntEnds;
												float now5 = gillaModeRound.Now;
												num5 = huntEnds3 - now5;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E10774");
												bool value26 = ((bool*)(flag25 ? 1 : 0))->m_value;
												object obj251 = ~obj252;
												int seconds3 = obj252 & obj251;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2950 @ X0_v180 (System.Boolean)+E4]");
												bool flag200 = (nint)0 == 0;
												object obj253 = !flag200;
												if (obj253 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												string text27 = Clock(seconds3);
												bool value27 = ((bool*)(flag25 ? 1 : 0))->m_value;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3046 @ X8_v129 (System.Boolean)+A0]");
												object obj254 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3049 @ X8_v130+28]");
												array12 = (Color32[])0;
												byte startMonsters2 = gillaModeRound.StartMonsters;
												int num77 = gillaModeRound.HuntersIn((PlayerRef)0);
												string text28;
												(int, int) tuple8;
												if (Hunts(gillaModeRound))
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2300]");
													object format4 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D1D90]");
													MapEntry[] arg4 = (MapEntry[])0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22C8]");
													array = (MapEntry[])0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj255 = 0;
													int num78 = startMonsters2 & 0xFE;
													bool flag201 = num78 == 0;
													object obj256 = !flag201;
													if ((int)(~obj256) != 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22C8]");
														arg4 = (MapEntry[])0;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj257 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													text28 = string.Format((string)format4, arg4, arg5, arg6);
													text17 = null;
													tuple8 = tuple7;
													tuple2 = ((int, int))b9;
												}
												else
												{
													if (~(inHunt ? 1u : 0u) != 0 || ~(outOfIt ? 1u : 0u) == 0)
													{
														int num79 = startMonsters2 & 0xFF;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
														object obj258 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22E0]");
														object format5 = 0;
														string text29 = string.Format((string)format5, arg7, arg8);
														bool flag202 = num79 < 2;
														object obj259 = !flag202;
														object obj260 = ~obj259;
														int num80;
														string text31;
														if (obj260 == null && num77 > 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
															object obj261 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2328]");
															object format6 = 0;
															string text30 = string.Format((string)format6, arg9);
															num80 = num77;
															text31 = text30;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
															object obj262 = 0;
															text31 = (string)obj262;
															num80 = b9;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
														flag2 = false;
														text25 = text29 + text31;
														tuple = tuple7;
														text6 = text27;
														obj29 = (UnityEngine.Object)num79;
														tuple2 = ((int, int))num80;
														goto IL_5b2c;
													}
													int num81 = startMonsters2 & 0xFF;
													bool flag203 = num81 < 2;
													object obj263 = !flag203;
													object obj264 = ~obj263;
													string text33;
													if (obj264 == null && num77 > 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
														object obj265 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22E8]");
														object format7 = 0;
														string text32 = string.Format((string)format7, arg10);
														text33 = text32;
														num7 = num77;
														object obj266 = 0;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2340]");
														object obj267 = 0;
														text33 = (string)obj267;
														object obj266 = 0;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj268 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22E0]");
													object format8 = 0;
													string text34 = string.Format((string)format8, arg11, arg12);
													text28 = text33 + text34;
													tuple8 = tuple7;
													tuple2 = ((int, int))b9;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
												flag2 = false;
												num6 = (int)tuple8;
												text6 = text27;
												text23 = text28;
											}
											else
											{
												byte winner2 = gillaModeRound.Winner;
												int num82 = winner2 & 0xFF;
												object obj269;
												if (num82 == 1)
												{
													byte mode3 = gillaModeRound.Mode;
													int num83 = mode3 & 0xFF;
													if (num83 == 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2260]");
														obj269 = 0;
													}
													else
													{
														byte startMonsters3 = gillaModeRound.StartMonsters;
														int num84 = startMonsters3 & 0xFE;
														bool flag204 = num84 == 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22B8]");
														obj269 = 0;
														object obj270 = !flag204;
														if ((int)(~obj270) == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2298]");
															obj269 = 0;
														}
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2268]");
													obj269 = 0;
												}
												text21 = (string)obj269;
												float overEnds2 = gillaModeRound.OverEnds;
												float now6 = gillaModeRound.Now;
												num5 = overEnds2 - now6;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E10774");
												bool value28 = ((bool*)(flag25 ? 1 : 0))->m_value;
												object obj271 = ~obj272;
												int seconds4 = obj272 & obj271;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3052 @ X0_v166 (System.Boolean)+E4]");
												bool flag205 = (nint)0 == 0;
												object obj273 = !flag205;
												if (obj273 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												string text35 = Clock(seconds4);
												bool value29 = ((bool*)(flag25 ? 1 : 0))->m_value;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3143 @ X8_v115 (System.Boolean)+A0]");
												object obj274 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81C8]");
												object obj275 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2837 @ X8_v116+38]");
												array12 = (Color32[])0;
												text23 = (string)obj275;
												num6 = (int)tuple;
												text6 = text35;
												tuple2 = ((int, int))num7;
											}
										}
										else
										{
											float voteEnds2 = gillaModeRound.VoteEnds;
											int seconds5;
											if (voteEnds2 > 0f)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8280]");
												object obj276 = 0;
												text21 = (string)obj276;
												float voteEnds3 = gillaModeRound.VoteEnds;
												num5 = gillaModeRound.Now;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
												object obj277 = 0;
												object obj278 = obj277;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ X0_v145+E4]");
												bool flag206 = (nint)0 == 0;
												object obj279 = !flag206;
												if (obj279 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
												object obj280 = ~num5;
												seconds5 = num5 & obj280;
												Color32 color7 = (Color32)0;
												object obj281 = null;
											}
											else
											{
												if (gillaModeRound.Enough)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81E8]");
													object obj282 = 0;
													text21 = (string)obj282;
													Color32 color7 = (Color32)0;
													object obj281 = null;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
													object obj283 = 0;
													object obj284 = obj283;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2551 @ X0_v135+E4]");
													bool flag207 = (nint)0 == 0;
													object obj285 = !flag207;
													if (obj285 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														obj284 = obj283;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2551 @ X0_v135+A0]");
													object obj286 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
													object obj287 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2338]");
													object format9 = 0;
													string text36 = string.Format((string)format9, obj288);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2554 @ X8_v91+1C]");
													num7 = 0;
													text21 = text36;
													Color32 color7 = (Color32)0;
													object obj281 = obj288;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
												object obj289 = 0;
												object obj290 = obj289;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2628 @ X0_v129+E4]");
												bool flag208 = (nint)0 == 0;
												object obj291 = !flag208;
												if (obj291 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj290 = obj289;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2628 @ X0_v129+A0]");
												object obj292 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2630 @ X8_v89+4]");
												num5 = 0f;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E10774");
												seconds5 = num85;
											}
											bool value30 = ((bool*)(flag25 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2692 @ X0_v111 (System.Boolean)+E4]");
											bool flag209 = (nint)0 == 0;
											object obj293 = !flag209;
											if (obj293 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											string text37 = Clock(seconds5);
											bool value31 = ((bool*)(flag25 ? 1 : 0))->m_value;
											object obj295;
											if (voteEnds2 > 0f)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3005 @ X8_v79 (System.Boolean)+E4]");
												bool flag210 = (nint)0 == 0;
												object obj294 = !flag210;
												if (obj294 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value31 = ((bool*)(flag25 ? 1 : 0))->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3005 @ X8_v79 (System.Boolean)+A0]");
												obj295 = (nint)0 + (nint)48;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3005 @ X8_v79 (System.Boolean)+E4]");
												bool flag211 = (nint)0 == 0;
												object obj296 = !flag211;
												if (obj296 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value31 = ((bool*)(flag25 ? 1 : 0))->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3005 @ X8_v79 (System.Boolean)+A0]");
												obj295 = (nint)0 + (nint)64;
											}
											array12 = (Color32[])obj295;
											bool enough3 = gillaModeRound.Enough;
											bool flag212 = !enough3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2358]");
											object obj297 = 0;
											object obj298 = !flag212;
											if ((int)(~obj298) != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2348]");
												obj297 = 0;
											}
											text23 = (string)obj297;
											num6 = (int)tuple;
											text6 = text37;
											tuple2 = ((int, int))num7;
										}
									}
									goto IL_776e;
									IL_825c:
									object colours;
									boardCanvas.Text(screenFont, 256, 28, text21, (Color32[])colours, 2, centred: true);
									boardCanvas.Text(this.text, 256, 46, text6, array12, 6, centred: true);
									bool value32 = ((bool*)(flag25 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3413 @ X0_v49 (System.Boolean)+E4]");
									bool flag213 = (nint)0 == 0;
									object obj299 = !flag213;
									if (obj299 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										value32 = ((bool*)(flag25 ? 1 : 0))->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3413 @ X0_v49 (System.Boolean)+A0]");
									object obj300 = 0;
									Canvas canvas3 = boardCanvas;
									ScreenFont font2 = this.text;
									string s = text23;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3415 @ X8_v29+28]");
									canvas3.Text(font2, 256, 96, s, (Color32[])0, 1, centred: true);
									string text38 = num2.ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81D8]");
									object obj301 = 0;
									string text39 = (string)obj301 + text38;
									if (text15 != null && this.text != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2290]");
										object obj302 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2288]");
										object obj303 = 0;
										string text40;
										if (text15 == (string)obj303)
										{
											object obj304;
											if (screenFont5 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22B0]");
												obj304 = 0;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22A8]");
												obj304 = 0;
											}
											text40 = (string)obj304;
											color = (Color32)0;
											obj8 = (UnityEngine.Object)obj303;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22A0]");
											object obj305 = 0;
											if (screenFont5 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22D0]");
												obj305 = 0;
											}
											string text41 = text15 + (string)obj305;
											array = (MapEntry[])(object)screenFont5;
											color = (Color32)0;
											obj8 = (UnityEngine.Object)obj305;
											text40 = text41;
										}
										bool flag214 = (object)gillaModeRound == null;
										num2 = num69;
										flag155 = true;
										num61 = 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3415 @ X8_v29+28]");
										array9 = (Color32[])0;
										text17 = text23;
										array5 = (object[])(object)array12;
										num8 = 96;
										if (flag214)
										{
											break;
										}
										byte phase8 = gillaModeRound.Phase;
										int num86 = phase8 & 0xFF;
										bool flag215 = num86 == 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
										text6 = (string)0;
										if (!flag215)
										{
											byte phase9 = gillaModeRound.Phase;
											int num87 = phase9 & 0xFF;
											if (num87 != 3)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D22C0]");
												text6 = (string)0;
											}
										}
										string text42 = text40 + text6;
										string text43 = text39 + (string)obj302 + text42;
										bool flag216 = this.text == null;
										num2 = num69;
										flag155 = true;
										num61 = 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3415 @ X8_v29+28]");
										array9 = (Color32[])0;
										text17 = text23;
										array5 = (object[])(object)array12;
										num8 = 0;
										color = (Color32)text42;
										obj8 = (UnityEngine.Object)obj302;
										gillaModeRound = (GillaModeRound)(object)text42;
										if (flag216)
										{
											break;
										}
										int num88 = this.text.Measure(text43, 1);
										object obj306 = 512 - num88;
										bool value33 = ((bool*)(flag25 ? 1 : 0))->m_value;
										object obj307 = 513 - num88;
										bool flag217 = (nint)obj306 < 0;
										object obj308 = obj306 ^ obj306;
										object obj309 = obj306 & obj308;
										bool flag218 = (nint)obj309 < 0;
										bool flag219 = flag217 == flag218;
										object obj310 = !flag219;
										if ((int)(~obj310) != 0)
										{
											obj307 = obj306;
										}
										int num89 = obj307 >> 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3902 @ X0_v77 (System.Boolean)+E4]");
										bool flag220 = (nint)0 == 0;
										object obj311 = !flag220;
										if (obj311 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value33 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3902 @ X0_v77 (System.Boolean)+A0]");
										object obj312 = 0;
										Canvas canvas4 = boardCanvas;
										ScreenFont font3 = this.text;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v44+40]");
										canvas4.Text(font3, num89, 110, text39, (Color32[])0, 1, centred: false);
										string text44 = text39 + (string)obj302;
										bool flag221 = this.text == null;
										num2 = num69;
										flag155 = false;
										num61 = 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v44+40]");
										array9 = (Color32[])0;
										text17 = text39;
										array = (MapEntry[])513;
										array5 = (object[])(object)array12;
										text6 = (string)(object)this.text;
										num8 = 110;
										color = (Color32)0;
										obj8 = (UnityEngine.Object)obj302;
										gillaModeRound = (GillaModeRound)(object)text42;
										if (flag221)
										{
											break;
										}
										int num90 = this.text.Measure(text44, 1);
										bool value34 = ((bool*)(flag25 ? 1 : 0))->m_value;
										int x = num90 + num89;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3973 @ X8_v45 (System.Boolean)+A0]");
										object obj313 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3718 @ X8_v46+28]");
										Color32[] array14 = (Color32[])0;
										Canvas canvas5 = boardCanvas;
										ScreenFont font4 = this.text;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3718 @ X8_v46+28]");
										canvas5.Text(font4, x, 110, text42, (Color32[])0, 1, centred: false);
										string text45 = text39 + (string)obj302 + text42;
										object obj314 = this + 136;
										obj314 = text45;
										bool flag222 = false;
										int num91 = 1;
										string text46 = text42;
										int num92 = 0;
										string text47 = text42;
										string text48 = text45;
										object obj315 = obj314;
									}
									else
									{
										bool value35 = ((bool*)(flag25 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3654 @ X0_v59 (System.Boolean)+E4]");
										bool flag223 = (nint)0 == 0;
										object obj316 = !flag223;
										if (obj316 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value35 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3654 @ X0_v59 (System.Boolean)+A0]");
										object obj317 = 0;
										Canvas canvas6 = boardCanvas;
										ScreenFont font5 = this.text;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3656 @ X8_v36+40]");
										canvas6.Text(font5, 256, 110, text39, (Color32[])0, 1, centred: true);
										object obj318 = this + 136;
										obj318 = text39;
										bool flag222 = true;
										int num91 = 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3656 @ X8_v36+40]");
										Color32[] array14 = (Color32[])0;
										string text46 = text39;
										int num92 = 110;
										string text47 = (string)256;
										string text48 = text39;
										object obj315 = obj318;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									boardCanvas.Show();
									return;
									IL_6c2b:
									bool value36 = ((bool*)(flag156 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4158 @ X0_v385 (System.Boolean)+E4]");
									bool flag224 = (nint)0 == 0;
									object obj319 = !flag224;
									if (obj319 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag225 = (UnityEngine.Object)round != (UnityEngine.Object)null;
									bool flag226 = !flag225;
									UnityEngine.Object obj320 = null;
									UnityEngine.Object obj322;
									if (!flag226)
									{
										bool flag227 = (object)round == null;
										num2 = 0;
										flag155 = flag154;
										num61 = num60;
										array9 = array8;
										text17 = text16;
										text15 = text10;
										screenFont5 = screenFont4;
										array5 = array11;
										flag2 = flag156;
										screenFont = screenFont6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										flag150 = flag157;
										num8 = num62;
										num5 = num63;
										color = (Color32)0;
										obj8 = null;
										gillaModeRound = round;
										if (flag227)
										{
											break;
										}
										byte phase10 = round.Phase;
										int num93 = phase10 & 0xFF;
										bool flag228 = num93 == 0;
										object obj321 = !flag228;
										obj320 = null;
										flag2 = flag13;
										obj322 = null;
										if (obj321 != null)
										{
											goto IL_6c68;
										}
									}
									flag2 = true;
									obj322 = obj320;
									goto IL_6c68;
									IL_4858:
									byte phase11 = round.Phase;
									bool value37 = ((bool*)(flag25 ? 1 : 0))->m_value;
									int num94 = phase11 & 0xFF;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82C8]");
									object obj323 = 0;
									flag157 = num94 != 1;
									if (flag157)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C81F0]");
										obj323 = 0;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4540 @ X0_v410 (System.Boolean)+E4]");
									bool flag229 = (nint)0 == 0;
									object obj324 = !flag229;
									if (obj324 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										value37 = ((bool*)(flag25 ? 1 : 0))->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4540 @ X0_v410 (System.Boolean)+A0]");
									object obj325 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4542 @ X8_v290+28]");
									Color32[] array15 = (Color32[])0;
									text16 = (string)obj323;
									array11 = (object[])(object)this.text;
									screenFont6 = (ScreenFont)obj323;
									num62 = 186;
									int num95 = 128;
									ScreenFont screenFont7 = this.text;
									Canvas canvas7 = (Canvas)(object)text6;
									goto IL_6f91;
									IL_45b5:
									bool value38 = ((bool*)(flag2 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4425 @ X0_v401 (System.Boolean)+E4]");
									bool flag230 = (nint)0 == 0;
									object obj326 = !flag230;
									if (obj326 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Renderer renderer;
									Texture2D texture2D;
									if ((UnityEngine.Object)round != (UnityEngine.Object)null)
									{
										bool flag231 = (object)round == null;
										num2 = 0;
										flag155 = false;
										text15 = text10;
										screenFont5 = screenFont4;
										array5 = (object[])(object)renderer;
										screenFont = (ScreenFont)(object)texture2D;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										color = (Color32)0;
										obj8 = null;
										gillaModeRound = round;
										if (flag231)
										{
											break;
										}
										byte phase12 = round.Phase;
										if ((phase12 & 0xFF) == 0)
										{
											int num96 = round.VotesFor(num64);
											string text49 = num3.ToString();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8210]");
											object obj327 = 0;
											if (num3 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8258]");
												obj327 = 0;
											}
											string text50 = (string)obj327;
											string text51 = text49 + (string)obj327;
											int num98;
											if (this.text != null)
											{
												int num97 = this.text.Measure(text51, 1);
												num98 = num97;
												num8 = 0;
												int num99 = 1;
												text50 = text51;
											}
											else
											{
												num98 = 40;
												int num99 = 0;
											}
											bool value39 = ((bool*)(flag25 ? 1 : 0))->m_value;
											object colours2;
											if (num3 > 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4634 @ X0_v441 (System.Boolean)+E4]");
												bool flag232 = (nint)0 == 0;
												object obj328 = !flag232;
												if (obj328 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value39 = ((bool*)(flag25 ? 1 : 0))->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4634 @ X0_v441 (System.Boolean)+A0]");
												colours2 = (nint)0 + (nint)48;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4634 @ X0_v441 (System.Boolean)+E4]");
												bool flag233 = (nint)0 == 0;
												object obj329 = !flag233;
												if (obj329 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value39 = ((bool*)(flag25 ? 1 : 0))->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4634 @ X0_v441 (System.Boolean)+A0]");
												colours2 = (nint)0 + (nint)64;
											}
											int num100 = 246 - num98;
											((Canvas)(object)text6).Text(this.text, num100, 10, text51, (Color32[])colours2, 1, false);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
											flag2 = false;
											bool flag234 = num3 < 1;
											int num101 = 10;
											Color32 color8 = (Color32)num100;
											RectInt rectInt2 = (RectInt)this.text;
											if (!flag234)
											{
												object obj330 = 12;
												int num102 = 10;
												ScreenFont screenFont8 = this.text;
												bool flag236;
												do
												{
													bool value40 = ((bool*)(flag25 ? 1 : 0))->m_value;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4738 @ X0_v437 (System.Boolean)+E4]");
													bool flag235 = (nint)0 == 0;
													object obj331 = !flag235;
													if (obj331 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
														value40 = ((bool*)(flag25 ? 1 : 0))->m_value;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4738 @ X0_v437 (System.Boolean)+A0]");
													object obj332 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4740 @ X8_v315+14]");
													num101 = 0;
													object obj333 = obj330 & 0xFFFFFFFEL;
													rectInt2 = (RectInt)(obj333 | 0xA600000000L);
													((Canvas)(object)text6).Fill(rectInt2, (Color32)30064771079L);
													flag13 = true;
													obj330 += 10;
													flag236 = (flag13 ? 1 : 0) < num3;
													color8 = (Color32)30064771079L;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4740 @ X8_v315+14]");
													num102 = 0;
													num100 = 7;
													screenFont8 = (ScreenFont)rectInt2;
												}
												while (flag236);
											}
											bool value41 = ((bool*)(flag25 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8228]");
											object obj334 = 0;
											screenFont6 = this.text;
											flag157 = text19 != null;
											if (flag157)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82C0]");
												obj334 = 0;
											}
											object obj336;
											if (text19 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4762 @ X0_v429 (System.Boolean)+E4]");
												bool flag237 = (nint)0 == 0;
												object obj335 = !flag237;
												if (obj335 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value41 = ((bool*)(flag25 ? 1 : 0))->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4762 @ X0_v429 (System.Boolean)+A0]");
												obj336 = (nint)0 + (nint)56;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4762 @ X0_v429 (System.Boolean)+E4]");
												bool flag238 = (nint)0 == 0;
												object obj337 = !flag238;
												if (obj337 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													value41 = ((bool*)(flag25 ? 1 : 0))->m_value;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4762 @ X0_v429 (System.Boolean)+A0]");
												obj336 = (nint)0 + (nint)48;
											}
											array15 = (Color32[])obj336;
											text16 = (string)obj334;
											array11 = (object[])obj334;
											num62 = 186;
											num95 = 128;
											screenFont7 = screenFont6;
											canvas7 = (Canvas)(object)text6;
											goto IL_6f91;
										}
										bool flag239 = !flag13;
										object obj338 = !flag239;
										if (obj338 != null)
										{
											goto IL_4858;
										}
										flag154 = false;
										num60 = num61;
										array8 = array9;
										text16 = text17;
										array11 = (object[])(object)renderer;
										flag156 = flag2;
										screenFont6 = (ScreenFont)(object)texture2D;
										flag157 = flag150;
										num62 = num8;
										num63 = num5;
										color4 = (Color32)0;
										obj36 = null;
									}
									else
									{
										bool flag240 = !flag13;
										flag154 = false;
										num60 = num61;
										array8 = array9;
										text16 = text17;
										array11 = (object[])(object)renderer;
										flag156 = flag2;
										screenFont6 = (ScreenFont)(object)texture2D;
										flag157 = flag150;
										num62 = num8;
										num63 = num5;
										color4 = (Color32)0;
										obj36 = null;
										if (!flag240)
										{
											bool flag241 = (object)round == null;
											num2 = 0;
											flag155 = false;
											text15 = text10;
											screenFont5 = screenFont4;
											array5 = (object[])(object)renderer;
											screenFont = (ScreenFont)(object)texture2D;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
											obj29 = (UnityEngine.Object)0;
											color = (Color32)0;
											obj8 = null;
											gillaModeRound = round;
											if (flag241)
											{
												break;
											}
											goto IL_4858;
										}
									}
									goto IL_4b77;
									IL_4b85:
									array7 = panelCanvas;
									num64++;
									bool flag242 = panelCanvas == null;
									obj339 = !flag242;
									num2 = 0;
									flag155 = flag154;
									num61 = num60;
									array9 = array8;
									text17 = text16;
									text15 = text10;
									screenFont5 = screenFont4;
									array5 = array11;
									flag2 = flag156;
									screenFont = screenFont6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
									obj29 = (UnityEngine.Object)0;
									flag150 = flag157;
									num8 = num62;
									num5 = num63;
									color = color4;
									obj8 = obj36;
									gillaModeRound = round;
									array10 = array;
									text18 = text6;
									continue;
									IL_6d90:
									bool value42 = ((bool*)(flag156 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4068 @ X0_v380 (System.Boolean)+E4]");
									bool flag243 = (nint)0 == 0;
									object obj340 = !flag243;
									if (obj340 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag244 = (UnityEngine.Object)round != (UnityEngine.Object)null;
									bool flag245 = !flag244;
									UnityEngine.Object obj341 = null;
									if (!flag245)
									{
										bool flag246 = (object)round == null;
										num2 = 0;
										flag155 = flag154;
										num61 = num60;
										array9 = array8;
										text17 = text16;
										text15 = text10;
										screenFont5 = screenFont4;
										array5 = array11;
										flag2 = flag156;
										screenFont = screenFont6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										flag150 = flag157;
										num8 = num62;
										num5 = num63;
										color = (Color32)0;
										obj8 = null;
										gillaModeRound = round;
										if (flag246)
										{
											break;
										}
										byte phase13 = round.Phase;
										int num103 = phase13 & 0xFF;
										bool flag247 = num103 == 0;
										obj341 = null;
										if (!flag247)
										{
											byte map4 = round.Map;
											object obj342 = num64 - map4;
											bool flag248 = obj342 == null;
											obj341 = null;
											flag13 = flag248;
											goto IL_6c2b;
										}
									}
									flag13 = false;
									goto IL_6c2b;
									IL_776e:
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6128]");
									object obj343 = 0;
									string text52 = text21 + (string)obj343 + text23;
									object obj344 = this + 144;
									obj344 = text52;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool value43 = ((bool*)(flag2 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2930 @ X27_v8+28]");
									screenFont = (ScreenFont)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2973 @ X0_v41 (System.Boolean)+E4]");
									bool flag249 = (nint)0 == 0;
									object obj345 = !flag249;
									if (obj345 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag250 = (UnityEngine.Object)gillaModeRound != (UnityEngine.Object)null;
									bool flag251 = !flag250;
									UnityEngine.Object obj346 = null;
									if (!flag251)
									{
										bool flag252 = (object)gillaModeRound == null;
										num2 = num69;
										flag155 = true;
										num61 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v20+28]");
										array9 = (Color32[])0;
										array5 = (object[])(object)array12;
										num8 = 0;
										color = (Color32)0;
										obj8 = null;
										if (flag252)
										{
											break;
										}
										byte phase14 = gillaModeRound.Phase;
										int num104 = phase14 & 0xFF;
										bool flag253 = num104 != 2;
										obj346 = null;
										if (!flag253)
										{
											bool value44 = ((bool*)(flag25 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3192 @ X0_v103 (System.Boolean)+E4]");
											bool flag254 = (nint)0 == 0;
											object obj347 = !flag254;
											if (obj347 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												value44 = ((bool*)(flag25 ? 1 : 0))->m_value;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3192 @ X0_v103 (System.Boolean)+A0]");
											colours = (nint)0 + (nint)56;
											goto IL_825c;
										}
									}
									bool value45 = ((bool*)(flag25 ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3161 @ X0_v97 (System.Boolean)+E4]");
									bool flag255 = (nint)0 == 0;
									object obj348 = !flag255;
									if (obj348 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										value45 = ((bool*)(flag25 ? 1 : 0))->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3161 @ X0_v97 (System.Boolean)+A0]");
									colours = (nint)0 + (nint)48;
									goto IL_825c;
									IL_6c68:
									bool value46 = ((bool*)(flag25 ? 1 : 0))->m_value;
									object obj352;
									if (text19 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4245 @ X0_v462 (System.Boolean)+E4]");
										bool flag256 = (nint)0 == 0;
										object obj349 = !flag256;
										if (obj349 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value46 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4245 @ X0_v462 (System.Boolean)+A0]");
										object obj350 = 0;
										((Canvas)(object)text6).Outline((RectInt)0, (Color32)893353197824L);
										bool value47 = ((bool*)(flag25 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4258 @ X0_v481 (System.Boolean)+E4]");
										bool flag257 = (nint)0 == 0;
										object obj351 = !flag257;
										if (obj351 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value47 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4258 @ X0_v481 (System.Boolean)+A0]");
										obj352 = (nint)0 + (nint)32;
									}
									else if (flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4245 @ X0_v462 (System.Boolean)+E4]");
										bool flag258 = (nint)0 == 0;
										object obj353 = !flag258;
										if (obj353 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value46 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4245 @ X0_v462 (System.Boolean)+A0]");
										object obj354 = 0;
										((Canvas)(object)text6).Outline((RectInt)0, (Color32)893353197824L);
										bool value48 = ((bool*)(flag25 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4278 @ X0_v473 (System.Boolean)+E4]");
										bool flag259 = (nint)0 == 0;
										object obj355 = !flag259;
										if (obj355 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value48 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4278 @ X0_v473 (System.Boolean)+A0]");
										obj352 = (nint)0 + (nint)20;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4245 @ X0_v462 (System.Boolean)+E4]");
										bool flag260 = (nint)0 == 0;
										object obj356 = !flag260;
										if (obj356 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value46 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4245 @ X0_v462 (System.Boolean)+A0]");
										object obj357 = 0;
										((Canvas)(object)text6).Outline((RectInt)0, (Color32)893353197824L);
										bool value49 = ((bool*)(flag25 ? 1 : 0))->m_value;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4277 @ X0_v465 (System.Boolean)+E4]");
										bool flag261 = (nint)0 == 0;
										object obj358 = !flag261;
										if (obj358 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											value49 = ((bool*)(flag25 ? 1 : 0))->m_value;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4277 @ X0_v465 (System.Boolean)+A0]");
										obj352 = (nint)0 + (nint)28;
									}
									num8 = (int)obj352;
									((Canvas)(object)text6).Outline((RectInt)4294967297L, (Color32)884763263230L);
									MapEntry[] array16 = maps;
									bool flag262 = maps == null;
									num2 = 0;
									flag155 = flag154;
									num61 = num60;
									array9 = array8;
									text17 = text16;
									text15 = text10;
									screenFont5 = screenFont4;
									array5 = array11;
									screenFont = screenFont6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
									obj29 = (UnityEngine.Object)0;
									flag150 = flag157;
									num5 = num63;
									color = (Color32)884763263230L;
									obj8 = (UnityEngine.Object)4294967297L;
									gillaModeRound = round;
									if (flag262)
									{
										break;
									}
									bool flag263 = num64 < array16.Length;
									object obj359 = !flag263;
									flag155 = flag154;
									num61 = num60;
									array9 = array8;
									text17 = text16;
									num5 = num63;
									color4 = (Color32)884763263230L;
									obj36 = (UnityEngine.Object)4294967297L;
									if (obj359 == null)
									{
										object obj360 = maps + num64;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4300 @ X8_v273+20]");
										object obj361 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4300 @ X8_v273+20]");
										bool flag264 = (nint)0 == 0;
										num2 = 0;
										flag155 = flag154;
										num61 = num60;
										array9 = array8;
										text17 = text16;
										text15 = text10;
										screenFont5 = screenFont4;
										array5 = array11;
										screenFont = screenFont6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										flag150 = flag157;
										num5 = num63;
										color = (Color32)884763263230L;
										obj8 = (UnityEngine.Object)4294967297L;
										gillaModeRound = round;
										if (flag264)
										{
											break;
										}
										bool value50 = ((bool*)(flag25 ? 1 : 0))->m_value;
										screenFont = title;
										object obj363;
										if (flag2)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4325 @ X0_v456 (System.Boolean)+E4]");
											bool flag265 = (nint)0 == 0;
											object obj362 = !flag265;
											if (obj362 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												value50 = ((bool*)(flag25 ? 1 : 0))->m_value;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4325 @ X0_v456 (System.Boolean)+A0]");
											obj363 = (nint)0 + (nint)40;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4325 @ X0_v456 (System.Boolean)+E4]");
											bool flag266 = (nint)0 == 0;
											object obj364 = !flag266;
											if (obj364 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												value50 = ((bool*)(flag25 ? 1 : 0))->m_value;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4325 @ X0_v456 (System.Boolean)+A0]");
											obj363 = (nint)0 + (nint)64;
										}
										array9 = (Color32[])obj363;
										string text53 = text6;
										ScreenFont font6 = screenFont;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
										((Canvas)(object)text53).Text(font6, 10, 6, (string)0, (Color32[])obj363, 2, false);
										Renderer[] array17 = panelCovers;
										bool flag267 = panelCovers == null;
										num2 = 0;
										flag155 = false;
										num61 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
										text17 = (string)0;
										text15 = text10;
										screenFont5 = screenFont4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
										array5 = (object[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										flag150 = flag157;
										num8 = 6;
										num5 = num63;
										color = (Color32)10;
										obj8 = (UnityEngine.Object)(object)screenFont;
										gillaModeRound = round;
										if (flag267)
										{
											break;
										}
										if (num64 < array17.Length)
										{
											bool flag268 = num64 < array17.Length;
											object obj365 = !flag268;
											flag155 = false;
											num61 = 2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
											text17 = (string)0;
											num8 = 6;
											num5 = num63;
											color4 = (Color32)10;
											obj36 = (UnityEngine.Object)(object)screenFont;
											if (obj365 != null)
											{
												goto IL_6777;
											}
											object obj366 = panelCovers + num64;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4357 @ X8_v334+20]");
											renderer = (Renderer)0;
										}
										else
										{
											renderer = null;
										}
										MapEntry[] array18 = maps;
										bool flag269 = maps == null;
										num2 = 0;
										flag155 = false;
										num61 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
										text17 = (string)0;
										text15 = text10;
										screenFont5 = screenFont4;
										array5 = (object[])(object)renderer;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
										obj29 = (UnityEngine.Object)0;
										flag150 = flag157;
										num8 = 6;
										num5 = num63;
										color = (Color32)10;
										obj8 = (UnityEngine.Object)(object)screenFont;
										gillaModeRound = round;
										if (flag269)
										{
											break;
										}
										bool flag270 = num64 < array18.Length;
										object obj367 = !flag270;
										flag155 = false;
										num61 = 2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
										text17 = (string)0;
										num8 = 6;
										num5 = num63;
										color4 = (Color32)10;
										obj36 = (UnityEngine.Object)(object)screenFont;
										if (obj367 == null)
										{
											object obj368 = maps + num64;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4369 @ X8_v280+20]");
											object obj369 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4369 @ X8_v280+20]");
											bool flag271 = (nint)0 == 0;
											num2 = 0;
											flag155 = false;
											num61 = 2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
											text17 = (string)0;
											text15 = text10;
											screenFont5 = screenFont4;
											array5 = (object[])(object)renderer;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
											obj29 = (UnityEngine.Object)0;
											flag150 = flag157;
											num8 = 6;
											num5 = num63;
											color = (Color32)10;
											obj8 = (UnityEngine.Object)(object)screenFont;
											gillaModeRound = round;
											if (flag271)
											{
												break;
											}
											bool flag272 = !flag2;
											bool value51 = ((bool*)(flag25 ? 1 : 0))->m_value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v281+20]");
											texture2D = (Texture2D)0;
											object obj370 = !flag272;
											flag150 = (byte)(int)(~obj370) != 0;
											double num105;
											if (!flag150)
											{
												num105 = 1.0;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
												num105 = 0.0;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4375 @ X0_v396 (System.Boolean)+E4]");
											bool flag273 = (nint)0 == 0;
											object obj371 = !flag273;
											if (obj371 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											bool flag274 = ShowCover(renderer, texture2D, (float)num105);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
											flag2 = false;
											bool flag275 = !flag274;
											object obj372 = !flag275;
											num61 = 2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
											text17 = (string)0;
											num8 = 6;
											num5 = (float)num105;
											int num106 = 10;
											Color32[] array19 = (Color32[])(object)texture2D;
											if (obj372 == null)
											{
												Color32[][] array20 = pictures;
												bool flag276 = pictures == null;
												num2 = 0;
												flag155 = false;
												num61 = 2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
												text17 = (string)0;
												text15 = text10;
												screenFont5 = screenFont4;
												array5 = (object[])(object)renderer;
												screenFont = (ScreenFont)(object)texture2D;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
												obj29 = (UnityEngine.Object)0;
												num8 = 6;
												num5 = (float)num105;
												color = (Color32)10;
												obj8 = texture2D;
												gillaModeRound = round;
												if (flag276)
												{
													break;
												}
												bool flag277 = num64 >= array20.Length;
												num61 = 2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
												text17 = (string)0;
												num8 = 6;
												num5 = (float)num105;
												num106 = 10;
												array19 = (Color32[])(object)texture2D;
												if (!flag277)
												{
													bool flag278 = num64 < array20.Length;
													object obj373 = !flag278;
													flag155 = false;
													num61 = 2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
													text17 = (string)0;
													num8 = 6;
													num5 = (float)num105;
													color4 = (Color32)10;
													obj36 = texture2D;
													if (obj373 == null)
													{
														object obj374 = pictures + num64;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
														renderer = (Renderer)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
														bool flag279 = (nint)0 == 0;
														num61 = 2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
														text17 = (string)0;
														num8 = 6;
														num5 = (float)num105;
														num106 = 10;
														array19 = (Color32[])(object)texture2D;
														if (flag279)
														{
															goto IL_45b5;
														}
														MapEntry[] array21 = maps;
														bool flag280 = maps == null;
														num2 = 0;
														flag155 = false;
														num61 = 2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
														text17 = (string)0;
														text15 = text10;
														screenFont5 = screenFont4;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
														array5 = (object[])0;
														screenFont = (ScreenFont)(object)texture2D;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
														obj29 = (UnityEngine.Object)0;
														num8 = 6;
														num5 = (float)num105;
														color = (Color32)10;
														obj8 = texture2D;
														gillaModeRound = round;
														if (flag280)
														{
															break;
														}
														bool flag281 = num64 < array21.Length;
														object obj375 = !flag281;
														flag155 = false;
														num61 = 2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
														text17 = (string)0;
														num8 = 6;
														num5 = (float)num105;
														color4 = (Color32)10;
														obj36 = texture2D;
														if (obj375 == null)
														{
															object obj376 = maps + num64;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4470 @ X8_v327+20]");
															object obj377 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4470 @ X8_v327+20]");
															bool flag282 = (nint)0 == 0;
															num2 = 0;
															flag155 = false;
															num61 = 2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
															text17 = (string)0;
															text15 = text10;
															screenFont5 = screenFont4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
															array5 = (object[])0;
															screenFont = (ScreenFont)(object)texture2D;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
															obj29 = (UnityEngine.Object)0;
															num8 = 6;
															num5 = (float)num105;
															color = (Color32)10;
															obj8 = texture2D;
															gillaModeRound = round;
															if (flag282)
															{
																break;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v328+18]");
															object obj378 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X8_v328+18]");
															bool flag283 = (nint)0 == 0;
															num2 = 0;
															flag155 = false;
															num61 = 2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
															text17 = (string)0;
															text15 = text10;
															screenFont5 = screenFont4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
															array5 = (object[])0;
															screenFont = (ScreenFont)(object)texture2D;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
															obj29 = (UnityEngine.Object)0;
															num8 = 6;
															num5 = (float)num105;
															color = (Color32)10;
															obj8 = texture2D;
															gillaModeRound = round;
															if (flag283)
															{
																break;
															}
															object obj379 = obj378;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4510 @ X8_v329+190]");
															obj8 = (UnityEngine.Object)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4510 @ X8_v329+188] (should have been resolved before IL gen)");
															MapEntry[] array22 = maps;
															bool flag284 = maps == null;
															num2 = 0;
															flag155 = false;
															num61 = 2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
															text17 = (string)0;
															text15 = text10;
															screenFont5 = screenFont4;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
															array5 = (object[])0;
															screenFont = (ScreenFont)(object)texture2D;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
															obj29 = (UnityEngine.Object)0;
															num8 = 6;
															num5 = (float)num105;
															color = (Color32)10;
															gillaModeRound = round;
															if (flag284)
															{
																break;
															}
															bool flag285 = num64 < array22.Length;
															object obj380 = !flag285;
															flag155 = false;
															num61 = 2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
															text17 = (string)0;
															num8 = 6;
															num5 = (float)num105;
															color4 = (Color32)10;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4510 @ X8_v329+190]");
															obj36 = (UnityEngine.Object)0;
															if (obj380 == null)
															{
																object obj381 = maps + num64;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4552 @ X8_v331+20]");
																object obj382 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4552 @ X8_v331+20]");
																bool flag286 = (nint)0 == 0;
																num2 = 0;
																flag155 = false;
																num61 = 2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
																text17 = (string)0;
																text15 = text10;
																screenFont5 = screenFont4;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
																array5 = (object[])0;
																screenFont = (ScreenFont)(object)texture2D;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
																obj29 = (UnityEngine.Object)0;
																num8 = 6;
																num5 = (float)num105;
																color = (Color32)10;
																gillaModeRound = round;
																if (flag286)
																{
																	break;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v332+18]");
																object obj383 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ X8_v332+18]");
																bool flag287 = (nint)0 == 0;
																num2 = 0;
																flag155 = false;
																num61 = 2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v274+10]");
																text17 = (string)0;
																text15 = text10;
																screenFont5 = screenFont4;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
																array5 = (object[])0;
																screenFont = (ScreenFont)(object)texture2D2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v1+8]");
																obj29 = (UnityEngine.Object)0;
																num8 = 6;
																num5 = (float)num105;
																color = (Color32)10;
																gillaModeRound = round;
																if (flag287)
																{
																	break;
																}
																object obj384 = obj383;
																Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4423 @ X8_v333+1A8] (should have been resolved before IL gen)");
																string text54 = text6;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
																((Canvas)(object)text54).Picture((Color32[])0, (int)texture2D2, num107, 8, 30, 2, (float)num105);
																num61 = 2;
																array9 = (Color32[])30;
																text17 = (string)8;
																texture2D = texture2D2;
																num8 = num107;
																num5 = (float)num105;
																num106 = (int)texture2D2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4424 @ X8_v325+20]");
																array19 = (Color32[])0;
																goto IL_45b5;
															}
														}
													}
													goto IL_6777;
												}
											}
											goto IL_45b5;
										}
									}
									goto IL_6777;
									IL_6f91:
									canvas7.Text(screenFont7, num95, num62, text16, array15, 2, centred: true);
									flag154 = true;
									num60 = 2;
									array8 = array15;
									flag156 = flag2;
									num63 = num5;
									color4 = (Color32)num95;
									obj36 = (UnityEngine.Object)(object)screenFont7;
									goto IL_4b77;
									IL_4b77:
									((Canvas)(object)text6).Show();
									goto IL_4b85;
									IL_5b2c:
									num6 = (int)tuple;
									text23 = text25;
									goto IL_776e;
									IL_7d80:
									if (tuple6 != ((int, int))(object)1)
									{
										arg3 = obj248;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
									object obj385 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
									flag2 = false;
									text25 = string.Format((string)(object)array, arg13, arg3, arg14);
									text17 = null;
									text6 = text26;
									tuple2 = ((int, int))num75;
									goto IL_5b2c;
								}
								while (obj339 != null);
							}
							goto IL_4c69;
						}
					}
				}
			}
		}
		goto IL_6777;
		IL_6777:
		ex = new IndexOutOfRangeException();
		obj37 = obj36;
		goto IL_678d;
	}

	private static string Clock(int seconds)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6160]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6120]");
		object obj2 = 0;
		int num = default;
		string text = num.ToString();
		string text2 = num.ToString((string)obj);
		return text + (string)obj2 + text2;
	}

	private static void Figure(Canvas c, string[] rows, int x, int y, int scale, Color32 colour, Color32 face)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I4, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_0302: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_02c4: Expected Obj, but got I
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected VT, but got Unknown
		//IL_01d2: Expected VT, but got I4
		//IL_018f: Expected Obj, but got I4
		if (rows == null)
		{
			goto IL_025e;
		}
		object obj = rows.Length;
		if (rows.Length < 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
		object obj2 = 0;
		int num = scale | scale;
		int num2 = (int)(colour & 0xFFFFFFFFL);
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			object obj5 = obj3 * scale;
			object obj6 = y + obj5;
			object obj7 = (object)rows + obj3;
			object obj8 = obj6 << 32;
			int num3 = x;
			int num4 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X20_v7+20]");
				string text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X20_v7+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				if (num4 < text._stringLength)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X20_v7+20]");
					char c2 = ((string)0).get_Chars(num4);
					switch (c2 & 0xFFFF)
					{
					default:
					{
						object obj9 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v15+E4]");
						bool flag2 = (nint)0 == 0;
						object obj10 = !flag2;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj9 = obj2;
						}
						goto case 35;
					}
					case 46:
						goto IL_01d7;
					case 35:
					case 102:
					{
						if (c == null)
						{
							break;
						}
						RectInt r = (RectInt)(obj8 | num3);
						c.Fill(r, (Color32)num);
						goto IL_01d7;
					}
					}
					break;
				}
				goto IL_0233;
				IL_01d7:
				obj = rows.Length;
				num4++;
				num3 += scale;
				bool flag3 = (nint)obj3 < rows.Length;
				object obj11 = !flag3;
				object obj12 = ~obj11;
				if (obj12 == null)
				{
					goto end_IL_02e9;
				}
			}
			goto IL_025e;
			IL_0233:
			obj3++;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				return;
			}
			continue;
			end_IL_02e9:
			break;
		}
		goto IL_026c;
		IL_025e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_026c;
		IL_026c:
		throw new IndexOutOfRangeException();
	}

	private void DrawModePanel(Canvas c, int i, GillaModeRound round, byte myMode)
	{
		//IL_0015: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_11fa: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_0193: Expected Obj, but got I4
		//IL_1232: Expected Obj, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_024d: Expected I4, but got I8
		//IL_0267: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I
		//IL_0401: Expected VT, but got I8
		//IL_0401: Expected VT, but got I4
		//IL_02a2: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got I4
		//IL_1250: Expected Obj, but got I
		//IL_127a: Expected Obj, but got I4
		//IL_0442: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_035d: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I4
		//IL_04b3: Expected Obj, but got I4
		//IL_12d6: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_12bb: Expected Obj, but got I
		//IL_04e8: Expected Obj, but got I
		//IL_04f8: Expected Obj, but got I
		//IL_050f: Expected VT, but got I8
		//IL_050f: Expected VT, but got I4
		//IL_051c: Expected VT, but got I8
		//IL_0525: Expected VT, but got I4
		//IL_05f4: Expected VT, but got I8
		//IL_05f4: Expected VT, but got I4
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_061e: Expected VT, but got I8
		//IL_0627: Expected VT, but got I4
		//IL_065f: Expected Obj, but got I4
		//IL_06ae: Expected Obj, but got I4
		//IL_12f1: Expected Obj, but got I
		//IL_130c: Expected Obj, but got I
		//IL_190e: Expected VT, but got I8
		//IL_190e: Expected VT, but got I8
		//IL_1938: Expected Obj, but got I4
		//IL_0806: Expected Obj, but got I4
		//IL_083b: Expected Obj, but got I
		//IL_086e: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I
		//IL_0736: Expected Obj, but got I4
		//IL_1321: Expected Obj, but got I
		//IL_1354: Expected Obj, but got I
		//IL_0b11: Expected Obj, but got I4
		//IL_14a7: Expected Obj, but got I
		//IL_14bc: Expected VT, but got I
		//IL_14d5: Expected VT, but got I
		//IL_1505: Expected Obj, but got I
		//IL_09a6: Expected I4, but got Obj
		//IL_07a0: Expected Obj, but got I
		//IL_0b4e: Expected Obj, but got I
		//IL_0b63: Expected VT, but got I
		//IL_0b7c: Expected VT, but got I
		//IL_0a79: Expected Obj, but got I4
		//IL_078b: Expected Obj, but got I
		//IL_0bb1: Expected Obj, but got I
		//IL_0bd3: Expected Obj, but got I4
		//IL_0bf5: Expected Obj, but got I
		//IL_141d: Expected Obj, but got I
		//IL_1432: Expected VT, but got I
		//IL_144b: Expected VT, but got I
		//IL_147b: Expected Obj, but got I
		//IL_09de: Expected Obj, but got I4
		//IL_0ac0: Expected Obj, but got I4
		//IL_0ae2: Expected Obj, but got I
		//IL_0a41: Expected Obj, but got I4
		//IL_0942: Expected Obj, but got I4
		//IL_1408: Expected Obj, but got I
		//IL_08fb: Expected Obj, but got I4
		//IL_152c: Expected Obj, but got I4
		//IL_0c08: Expected Obj, but got I4
		//IL_13ed: Expected Obj, but got I
		//IL_19c8: Expected Obj, but got I
		//IL_19e2: Expected Obj, but got I4
		//IL_0cd4: Expected Obj, but got I4
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Expected Obj, but got Unknown
		//IL_0c7d: Expected Obj, but got I4
		//IL_1a1b: Expected Obj, but got I4
		//IL_0d04: Expected Obj, but got I
		//IL_155c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Expected Obj, but got Unknown
		//IL_0d25: Expected VT, but got Obj
		//IL_0cad: Expected Obj, but got I
		//IL_0db3: Expected Obj, but got I4
		//IL_15aa: Expected Obj, but got I
		//IL_0d6c: Expected Obj, but got I4
		//IL_1a4b: Expected Obj, but got I4
		//IL_158f: Expected Obj, but got I
		//IL_0df4: Expected VT, but got Obj
		//IL_0e23: Expected Obj, but got I
		//IL_0e90: Expected Obj, but got I
		//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected Obj, but got Unknown
		//IL_0ece: Expected Obj, but got I4
		//IL_0f45: Expected Obj, but got I4
		//IL_160d: Expected Obj, but got I
		//IL_0efe: Expected Obj, but got I4
		//IL_1a78: Expected Obj, but got I
		//IL_1a83: Expected Obj, but got I4
		//IL_15ed: Expected Obj, but got I
		//IL_0f7f: Expected Obj, but got I
		//IL_0fbe: Expected Obj, but got I
		//IL_0f94: Expected Obj, but got I
		//IL_16d0: Expected Obj, but got I
		//IL_16f2: Expected VT, but got I4
		//IL_16ff: Expected VT, but got Obj
		//IL_0fa9: Expected Obj, but got I
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected Obj, but got Unknown
		//IL_102b: Expected Obj, but got I4
		//IL_10a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ad: Expected Obj, but got Unknown
		//IL_0fde: Expected Obj, but got I4
		//IL_0fe7: Expected Obj, but got I4
		//IL_1139: Expected Obj, but got I
		//IL_1163: Expected Obj, but got I4
		//IL_1063: Expected Obj, but got I4
		//IL_17fc: Expected Obj, but got I4
		//IL_18d1: Expected Obj, but got I
		//IL_10da: Expected Obj, but got I
		//IL_1104: Expected Obj, but got I4
		//IL_181a: Expected Obj, but got I
		//IL_1834: Expected Obj, but got I
		//IL_186f: Expected Obj, but got I4
		//IL_171d: Expected Obj, but got I
		//IL_173a: Unknown result type (might be due to invalid IL or missing references)
		//IL_173f: Expected Obj, but got Unknown
		//IL_174c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1751: Expected VT, but got Unknown
		//IL_1767: Expected VT, but got I8
		//IL_1770: Unknown result type (might be due to invalid IL or missing references)
		//IL_1775: Expected Obj, but got Unknown
		//IL_177e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1783: Expected Obj, but got Unknown
		//IL_179f: Expected VT, but got I8
		//IL_17bc: Expected I4, but got I8
		//IL_17c4: Expected Obj, but got VT
		//IL_18b6: Expected Obj, but got I
		//IL_1893: Expected Obj, but got I
		PressKey[] array = panels;
		if (panels == null)
		{
			goto IL_1188;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			if (i != 0)
			{
				goto IL_005f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = i == 0;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_005f;
			}
		}
		int num = 0;
		goto IL_11c6;
		IL_1480:
		int num2 = 119;
		int num3 = 92;
		object obj8;
		GillaMeta._003C_003Ec__DisplayClass118_0 obj15 = default;
		bool flag11;
		Color32 color3;
		Color32 color4;
		int num5;
		int num6;
		int num7;
		string[] array2;
		do
		{
			object obj4 = obj;
			bool flag2;
			if (num == 1)
			{
				object obj5 = num3 - 196;
				flag2 = obj5 == null;
			}
			else
			{
				flag2 = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v37+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v37+A0]");
			object obj7 = 0;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			object obj10 = ~obj9;
			int num4 = ((obj10 != null) ? num2 : num3);
			object obj12;
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v37+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v37+A0]");
					obj7 = 0;
				}
				obj12 = obj7 + 104;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v37+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v37+A0]");
					obj7 = 0;
				}
				obj12 = obj7 + 112;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v37+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Color32 color = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)obj12, ref obj15);
			object obj16 = obj;
			object obj18;
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v30+E4]");
				bool flag8 = (nint)0 == 0;
				object obj17 = !flag8;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v30+A0]");
				obj18 = (nint)0 + (nint)108;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v30+E4]");
				bool flag9 = (nint)0 == 0;
				object obj19 = !flag9;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v30+A0]");
				obj18 = (nint)0 + (nint)116;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v30+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Color32 color2 = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)obj18, ref obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v67+58]");
			Figure(c, (string[])0, num4, 82, 3, color, color2);
			num3 += 52;
			num2 += 43;
			flag11 = num3 != 248;
			color3 = color;
			color4 = color2;
			num5 = 3;
			num6 = 82;
			num7 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X8_v67+58]");
			array2 = (string[])0;
		}
		while (flag11);
		object obj21 = obj;
		object obj22 = obj15 & 1;
		bool flag12 = obj22 == null;
		object obj23 = !flag12;
		object colours;
		GillaMapVote gillaMapVote;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v77+E4]");
			bool flag13 = (nint)0 == 0;
			object obj24 = !flag13;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v77+A0]");
			colours = (nint)0 + (nint)64;
			gillaMapVote = this;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v77+E4]");
			bool flag14 = (nint)0 == 0;
			object obj25 = !flag14;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X0_v77+A0]");
			colours = (nint)0 + (nint)48;
			gillaMapVote = this;
		}
		bool flag15 = obj8 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2470]");
		object s = 0;
		object obj26 = !flag15;
		object obj27 = ~obj26;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2458]");
			s = 0;
		}
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2460]");
			s = 0;
		}
		object s2;
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2450]");
			s2 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2468]");
			s2 = 0;
		}
		c.Text(gillaMapVote.text, 128, 128, (string)s, (Color32[])colours, 1, centred: true);
		ScreenFont screenFont = gillaMapVote.text;
		c.Text(gillaMapVote.text, 128, 140, (string)s2, (Color32[])colours, 1, centred: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
		object obj28 = 0;
		bool flag16 = 0 < 1;
		int num8 = 140;
		Color32 color5 = (Color32)128;
		RectInt rectInt = (RectInt)gillaMapVote.text;
		if (!flag16)
		{
			int num9 = 140;
			int num10 = 128;
			object obj29 = 12;
			object obj30 = 0;
			bool flag18;
			do
			{
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v73+E4]");
				bool flag17 = (nint)0 == 0;
				object obj32 = !flag17;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj31 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X0_v73+A0]");
				object obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v56+14]");
				num8 = 0;
				object obj34 = obj29 & 0xFFFFFFFEL;
				rectInt = (RectInt)(obj34 | 0xA600000000L);
				c.Fill(rectInt, (Color32)30064771079L);
				obj30++;
				obj29 += 10;
				flag18 = (nint)obj30 < 0;
				color5 = (Color32)30064771079L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ X8_v56+14]");
				num9 = 0;
				num10 = 7;
				screenFont = (ScreenFont)rectInt;
			}
			while (flag18);
		}
		object obj35 = obj15 & 1;
		bool flag19 = obj35 == null;
		object obj36 = !flag19;
		object colours2;
		string s3;
		object obj44;
		if (obj36 == null)
		{
			object obj37 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ X0_v60+E4]");
			bool flag20 = (nint)0 == 0;
			object obj38 = !flag20;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2338]");
			object format = 0;
			object arg = default;
			string text = string.Format((string)format, arg);
			object obj40 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v50+E4]");
			bool flag21 = (nint)0 == 0;
			object obj41 = !flag21;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj40 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ X8_v50+A0]");
			colours2 = (nint)0 + (nint)64;
			s3 = text;
		}
		else
		{
			object obj42 = obj;
			object obj43 = obj44 & 1;
			if (obj43 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C82C0]");
				object obj45 = 0;
				s3 = (string)obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X0_v54+E4]");
				bool flag22 = (nint)0 == 0;
				object obj46 = !flag22;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj42 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X0_v54+A0]");
				colours2 = (nint)0 + (nint)56;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8228]");
				object obj47 = 0;
				s3 = (string)obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X0_v54+E4]");
				bool flag23 = (nint)0 == 0;
				object obj48 = !flag23;
				if (obj48 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj42 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X0_v54+A0]");
				colours2 = (nint)0 + (nint)48;
			}
		}
		c.Text(gillaMapVote.text, 128, 186, s3, (Color32[])colours2, 2, centred: true);
		return;
		IL_1188:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1196;
		IL_0635:
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v158+E4]");
		bool flag24 = (nint)0 == 0;
		object obj50 = !flag24;
		if (obj50 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj49 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X0_v158+A0]");
		object obj51 = (nint)0 + (nint)32;
		goto IL_18f3;
		IL_0ae7:
		object obj52 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v102+E4]");
		bool flag25 = (nint)0 == 0;
		object obj53 = !flag25;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj52 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v102+A0]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X20_v19+60]");
		Color32 colour = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)0, ref obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X20_v19+64]");
		Color32 face = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)0, ref obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X20_v19+58]");
		Figure(c, (string[])0, 9, 71, 4, colour, face);
		object obj55 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v76+A0]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X20_v20+60]");
		Color32 color6 = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)0, ref obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X20_v20+64]");
		Color32 color7 = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)0, ref obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X20_v20+58]");
		Figure(c, (string[])0, 61, 71, 4, color6, color7);
		color3 = color6;
		color4 = color7;
		num5 = 4;
		obj8 = 0;
		num6 = 71;
		num7 = 61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X20_v20+58]");
		array2 = (string[])0;
		goto IL_1480;
		IL_005f:
		if (array.Length >= 2)
		{
			object obj57 = array.Length - 1;
			if ((nint)obj57 == i)
			{
				num = 1;
				goto IL_11c6;
			}
		}
		bool flag26;
		if (array.Length == 3)
		{
			object obj58 = i - 1;
			flag26 = obj58 == null;
		}
		else
		{
			flag26 = false;
		}
		object obj59 = !flag26;
		num = ((obj59 != null) ? (-1) : 2);
		goto IL_11c6;
		IL_11c6:
		Renderer[] array3 = panelCovers;
		int num13;
		object obj73;
		bool flag34;
		if (panelCovers != null)
		{
			bool flag27 = array3.Length < i;
			object obj60 = !flag27;
			object obj61 = array3.Length - i;
			bool flag28 = obj61 == null;
			Renderer quad;
			if (array3.Length > i)
			{
				object obj62 = ~obj60;
				object obj63 = obj62 | flag28;
				if (obj63 != null)
				{
					goto IL_1196;
				}
				object obj64 = panelCovers + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v113+20]");
				quad = (Renderer)0;
			}
			else
			{
				quad = null;
			}
			object obj65 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v8+E4]");
			bool flag29 = (nint)0 == 0;
			object obj66 = !flag29;
			if (obj66 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag30 = ShowCover(quad, null, 1f);
			int num11 = (int)(num & 0x80000000L);
			bool flag31 = num11 == 0;
			object obj67 = !flag31;
			if (obj67 == null)
			{
				if ((object)round != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj68 = 0;
					object obj69 = obj68;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v16+E4]");
					bool flag32 = (nint)0 == 0;
					object obj70 = !flag32;
					if (obj70 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if ((UnityEngine.Object)((SimulationBehaviour)round)._runner != (UnityEngine.Object)null)
					{
						if ((object)((SimulationBehaviour)round)._runner == null)
						{
							goto IL_1188;
						}
						IEnumerable<PlayerRef> activePlayers = ((SimulationBehaviour)round)._runner.ActivePlayers;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2398]");
						object obj71 = 0;
						UnityEngine.Object obj72 = (UnityEngine.Object)obj71;
						int num12 = Enumerable.Count(activePlayers);
						num13 = num12;
					}
					else
					{
						UnityEngine.Object obj72 = null;
						num13 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C61B0]");
					obj73 = 0;
					object obj74 = obj73;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v21+E4]");
					bool flag33 = (nint)0 == 0;
					object obj75 = !flag33;
					if (obj75 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					flag34 = GillaModeRound.ModeAllowed(num, num13);
					object obj76 = num - myMode;
					bool flag35 = obj76 == null;
					object obj77 = obj;
					obj44 = flag34 & flag35;
					object obj78 = obj44 & 1;
					if (obj78 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v167+E4]");
						bool flag36 = (nint)0 == 0;
						object obj79 = !flag36;
						if (obj79 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj77 = obj;
						}
						if (c != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v167+A0]");
							object obj80 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v110+20]");
							object obj81 = 0;
							c.Outline((RectInt)0, (Color32)893353197824L);
							Color32 color8 = (Color32)893353197824L;
							RectInt rectInt2 = (RectInt)0;
							goto IL_0635;
						}
					}
					else
					{
						object obj83;
						if (flag34)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v167+E4]");
							bool flag37 = (nint)0 == 0;
							object obj82 = !flag37;
							if (obj82 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj77 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v167+A0]");
							obj83 = (nint)0 + (nint)24;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v167+E4]");
							bool flag38 = (nint)0 == 0;
							object obj84 = !flag38;
							if (obj84 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj77 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v167+A0]");
							obj83 = (nint)0 + (nint)28;
						}
						if (c != null)
						{
							object obj81 = obj83;
							c.Outline((RectInt)0, (Color32)893353197824L);
							object obj85 = obj44 & 1;
							bool flag39 = obj85 == null;
							Color32 color8 = (Color32)893353197824L;
							RectInt rectInt2 = (RectInt)0;
							if (!flag39)
							{
								goto IL_0635;
							}
							object obj86 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v164+E4]");
							bool flag40 = (nint)0 == 0;
							object obj87 = !flag40;
							if (obj87 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj86 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v164+A0]");
							obj51 = (nint)0 + (nint)28;
							goto IL_18f3;
						}
					}
				}
			}
			else
			{
				object obj88 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v12+E4]");
				bool flag41 = (nint)0 == 0;
				object obj89 = !flag41;
				if (obj89 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (c != null)
				{
					c.Outline((RectInt)0, (Color32)893353197824L);
					return;
				}
			}
		}
		goto IL_1188;
		IL_1196:
		throw new IndexOutOfRangeException();
		IL_18f3:
		c.Outline((RectInt)4294967297L, (Color32)884763263230L);
		object obj90 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v28+E4]");
		bool flag42 = (nint)0 == 0;
		object obj91 = !flag42;
		if (obj91 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = ModeLabel(num);
		object obj92 = obj;
		int num20;
		ScreenFont screenFont2;
		if (flag34)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v84+E4]");
			bool flag43 = (nint)0 == 0;
			object obj93 = !flag43;
			if (obj93 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj92 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v84+A0]");
			object obj94 = 0;
			ScreenFont font = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v85+28]");
			c.Text(font, 10, 6, text2, (Color32[])0, 2, centred: false);
			int num14 = round.ModeVotesFor(num);
			int num15 = default;
			string text3 = num15.ToString();
			object obj95;
			if (num15 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8210]");
				obj95 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8258]");
				obj95 = 0;
			}
			string text4 = (string)obj95;
			string text5 = text3 + (string)obj95;
			int num18;
			if (this.text != null)
			{
				int num16 = this.text.Measure(text5, 1);
				int num17 = 0;
				num18 = num16;
				int num19 = 1;
				text4 = text5;
			}
			else
			{
				int num17 = 6;
				num18 = 40;
				int num19 = 0;
			}
			object obj96 = obj;
			object obj98;
			if (num15 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v145+E4]");
				bool flag44 = (nint)0 == 0;
				object obj97 = !flag44;
				if (obj97 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj96 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v145+A0]");
				obj98 = (nint)0 + (nint)48;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v145+E4]");
				bool flag45 = (nint)0 == 0;
				object obj99 = !flag45;
				if (obj99 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj96 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v145+A0]");
				obj98 = (nint)0 + (nint)64;
			}
			Color32[] array4 = (Color32[])obj98;
			num20 = 246 - num18;
			c.Text(this.text, num20, 10, text5, (Color32[])obj98, 1, centred: false);
			bool flag46 = false;
			int num21 = 1;
			string text6 = text5;
			int num22 = 10;
			screenFont2 = this.text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v84+E4]");
			bool flag47 = (nint)0 == 0;
			object obj100 = !flag47;
			if (obj100 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj101 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v82+A0]");
			object obj102 = 0;
			ScreenFont font2 = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v83+40]");
			c.Text(font2, 10, 6, text2, (Color32[])0, 2, centred: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v83+40]");
			Color32[] array4 = (Color32[])0;
			bool flag46 = false;
			int num21 = 2;
			string text6 = text2;
			int num22 = 6;
			num20 = 10;
			screenFont2 = title;
		}
		if (num == 2)
		{
			goto IL_0ae7;
		}
		bool flag48 = num != 1;
		int num23 = num20;
		int num24 = (int)screenFont2;
		if (!flag48)
		{
			object obj103 = obj73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X0_v125+E4]");
			bool flag49 = (nint)0 == 0;
			object obj104 = !flag49;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int num25 = GillaModeRound.MonstersFor(1, num13);
			bool flag50 = num25 >= 2;
			num23 = 0;
			num24 = num13;
			num20 = 0;
			screenFont2 = (ScreenFont)num13;
			if (flag50)
			{
				goto IL_0ae7;
			}
		}
		object obj105 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v117+E4]");
		bool flag51 = (nint)0 == 0;
		object obj106 = !flag51;
		if (obj106 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj105 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v117+A0]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X20_v21+60]");
		Color32 color9 = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)0, ref obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X20_v21+64]");
		Color32 color10 = _003CDrawModePanel_003Eg__Shade_007C118_0((Color32)0, ref obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X20_v21+58]");
		Figure(c, (string[])0, 12, 60, 5, color9, color10);
		color3 = color9;
		color4 = color10;
		num5 = 5;
		obj8 = 1;
		num6 = 60;
		num7 = 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X20_v21+58]");
		array2 = (string[])0;
		goto IL_1480;
	}

	public static string ChanceText(float share)
	{
		//IL_038a: Invalid comparison between F4 and I4
		//IL_039b: Expected Obj, but got I4
		//IL_03a4: Invalid comparison between F4 and I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0039: Invalid comparison between F4 and I
		//IL_0430: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I4
		//IL_0073: Invalid comparison between F4 and I4
		//IL_0129: Invalid comparison between F4 and I4
		//IL_04db: Expected Obj, but got I
		//IL_04f3: Invalid comparison between F4 and I
		//IL_051a: Expected Obj, but got I
		//IL_053b: Invalid comparison between F4 and I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected Obj, but got Unknown
		//IL_055c: Expected Obj, but got F4
		//IL_0591: Expected Obj, but got I4
		//IL_05ca: Expected Obj, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0405: Expected Obj, but got I4
		//IL_0336: Expected F4, but got I4
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_049f: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I
		//IL_02a4: Expected F4, but got I
		//IL_05f6: Invalid comparison between F4 and I4
		//IL_0605: Invalid comparison between F4 and I4
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected Obj, but got Unknown
		//IL_0626: Expected Obj, but got F4
		//IL_065b: Expected Obj, but got I4
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_0349: Expected F4, but got I4
		//IL_06a1: Expected Obj, but got I4
		bool flag = share < 0f;
		object obj = !flag;
		bool flag2 = share == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		double num2;
		float num3;
		double num6;
		float num7;
		object result;
		double num8;
		if (obj3 == null)
		{
			if ((double)share < 1.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF28]");
				float num4 = default;
				if (share < 0f)
				{
					float num = share * 1.1488461E+09f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
					if (num < 0f)
					{
						if ((double)num == -0.5)
						{
							num2 = -1.0;
							num3 = num4;
							goto IL_03ce;
						}
						num3 = num + -0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					}
					else
					{
						if ((double)num == 0.5)
						{
							num2 = 1.0;
							num3 = num4;
							goto IL_03ce;
						}
						num3 = num + 0.5f;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					}
					goto IL_04b7;
				}
				float num5 = share * 1.1204035E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
				object obj4 = 0;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D010");
				if (num5 < 0f)
				{
					if ((double)num5 == -0.5)
					{
						num6 = -1.0;
						num7 = num4;
						goto IL_0468;
					}
					num7 = num5 + -0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					num8 = -0.5;
				}
				else
				{
					if ((double)num5 == 0.5)
					{
						num6 = 1.0;
						num7 = num4;
						goto IL_0468;
					}
					num7 = num5 + 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					num8 = 0.5;
				}
				goto IL_050a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2448]");
			result = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6200]");
			result = 0;
		}
		return (string)result;
		IL_03ce:
		double num9 = (double)num3 + num2;
		object obj7 = num3 & 1;
		bool flag4 = obj7 == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			num3 = (float)num9;
		}
		goto IL_04b7;
		IL_0468:
		num8 = (double)num7 + num6;
		object obj9 = num7 & 1;
		bool flag5 = obj9 == null;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			num7 = (float)num8;
		}
		goto IL_050a;
		IL_050a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB160]");
		object obj11 = 0;
		object obj12 = obj11;
		float num10 = num7 - 99f;
		bool flag6 = num10 < 0f;
		object obj13 = num7 ^ 0x63;
		object obj14 = num7 ^ num10;
		object obj15 = obj13 & obj14;
		bool flag7 = (nint)obj15 < 0;
		bool flag8 = flag6 == flag7;
		object obj16 = !flag8;
		object obj17 = ~obj16;
		float num11 = ((obj17 != null) ? 99f : num7);
		float num12 = num11 - 10f;
		bool flag9 = num12 < 0f;
		bool flag10 = num12 == 0f;
		object obj18 = num11 ^ 0xA;
		object obj19 = num11 ^ num12;
		object obj20 = obj18 & obj19;
		bool flag11 = (nint)obj20 < 0;
		bool flag12 = flag9 == flag11;
		object obj21 = !flag10;
		object obj22 = flag12 & obj21;
		object obj23 = ~obj22;
		if (obj23 != null)
		{
			num11 = 10f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v9+E4]");
		bool flag13 = (nint)0 == 0;
		object obj24 = !flag13;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		int num13 = default;
		return num13.ToString((IFormatProvider)invariantCulture);
		IL_04b7:
		float num14 = num3 / 10f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CB160]");
		object obj25 = 0;
		object obj26 = obj25;
		float num15 = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
		if (num15 < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
			num14 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v22+E4]");
		bool flag14 = (nint)0 == 0;
		object obj27 = !flag14;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CED80]");
		object obj28 = 0;
		float num16 = default;
		return num16.ToString((string)obj28, (IFormatProvider)invariantCulture2);
	}

	internal static bool ShowCover(Renderer quad, Texture2D cover, float bright)
	{
		//IL_0010: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I4
		//IL_02d2: Expected I4, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I4
		//IL_0415: Expected Obj, but got I4
		//IL_03a1: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		//IL_036a: Expected Obj, but got I
		//IL_0284: Expected VT, but got I4
		//IL_0284: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = quad == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = cover != null;
			if ((object)quad != null)
			{
				quad.enabled = flag5;
				if (cover == null)
				{
					goto IL_0109;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v21+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v9+78]");
				bool flag7 = (nint)0 == 0;
				object obj11 = !flag7;
				UnityEngine.Object obj12 = null;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C42D8]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					MaterialPropertyBlock materialPropertyBlock = default;
					materialPropertyBlock._002Ector();
					object obj14 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v32+E4]");
					bool flag8 = (nint)0 == 0;
					object obj15 = !flag8;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj14 = obj7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v32+A0]");
					object obj16 = (nint)0 + (nint)120;
					obj16 = materialPropertyBlock;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					obj8 = obj7;
					obj12 = (UnityEngine.Object)(object)materialPropertyBlock;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v21+E4]");
				bool flag9 = (nint)0 == 0;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v21+A0]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v13+78]");
				quad.GetPropertyBlock((MaterialPropertyBlock)0);
				object obj19 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v14+A0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v15+78]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v15+78]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v15+8]");
					((MaterialPropertyBlock)num).SetTexture(0, cover);
					object obj21 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v16+A0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v17+78]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v17+78]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v17+80]");
						((MaterialPropertyBlock)num2).SetColor(0, (Color)0);
						object obj23 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v18+A0]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v19+78]");
						quad.SetPropertyBlock((MaterialPropertyBlock)0);
						return true;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0109;
		IL_0109:
		return false;
	}

	public GillaMapVote()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0163: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2478]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6188]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8408]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF348]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8418]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8420]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj7 = this + 32;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj9 = this + 40;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj11 = this + 48;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj13 = this + 56;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj15 = this + 104;
		obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj16 = this + 160;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj18 = this + 168;
		object obj19 = default;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		paidRound = -1;
		seenPhase = 255;
		seenRound = -1;
		base._002Ector();
	}

	static GillaMapVote()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_08c3: Expected Obj, but got I
		//IL_08e8: Expected Obj, but got I
		//IL_0902: Expected Obj, but got I
		//IL_093b: Expected Obj, but got I4
		//IL_0959: Expected Obj, but got I
		//IL_0969: Expected Obj, but got I
		//IL_0986: Expected Obj, but got I
		//IL_09a0: Expected Obj, but got I
		//IL_09ba: Expected Obj, but got I
		//IL_09d4: Expected Obj, but got I
		//IL_09ee: Expected Obj, but got I
		//IL_0a04: Expected Obj, but got I
		//IL_0a36: Expected Obj, but got I
		//IL_0a4c: Expected Obj, but got I
		//IL_0a5c: Expected Obj, but got I
		//IL_0a86: Expected Obj, but got I
		//IL_0a9c: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_009a: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_0acd: Expected Obj, but got I8
		//IL_013c: Expected Obj, but got I
		//IL_0b0c: Expected Obj, but got I4
		//IL_0b22: Expected Obj, but got I
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I
		//IL_0b6f: Expected Obj, but got I8
		//IL_01aa: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I8
		//IL_02af: Expected Obj, but got I
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02f1: Expected Obj, but got I4
		//IL_0307: Expected Obj, but got I
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_034a: Expected Obj, but got I
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got I8
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected Obj, but got Unknown
		//IL_03e3: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected Obj, but got Unknown
		//IL_046e: Expected Obj, but got I4
		//IL_0484: Expected Obj, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04c7: Expected Obj, but got I
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_0509: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected Obj, but got Unknown
		//IL_0562: Expected Obj, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got I8
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05fb: Expected Obj, but got I4
		//IL_0611: Expected Obj, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_0686: Expected Obj, but got I4
		//IL_069c: Expected Obj, but got I
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_06df: Expected Obj, but got I
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_0721: Expected Obj, but got I4
		//IL_0737: Expected Obj, but got I
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected Obj, but got Unknown
		//IL_077a: Expected Obj, but got I
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_07b8: Expected Obj, but got I
		//IL_07e7: Expected Obj, but got I
		//IL_0801: Expected Obj, but got I
		//IL_081b: Expected Obj, but got I
		//IL_0835: Expected Obj, but got I
		//IL_084f: Expected Obj, but got I
		//IL_0869: Expected Obj, but got I
		//IL_0898: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4468]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7778]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
		object obj4 = 0;
		int num = Shader.PropertyToID((string)obj);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj6 = 0;
		_ = 4278584838L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj7 = 0;
		object obj8 = obj3;
		_ = 4279045389L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
			obj5 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+A0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v5+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj12 = 0;
		_ = 4284506208L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj13 = 0;
		_ = 4280821800L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj14 = 0;
		_ = 4294967295L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj15 = 0;
		_ = 4284111450L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+A0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+A0]");
		object obj17 = (nint)0 + (nint)40;
		obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj18 = obj3;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5+A0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X9_v12+A0]");
		object obj21 = (nint)0 + (nint)48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6+8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj22 = obj3;
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+A0]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v13+A0]");
		object obj25 = (nint)0 + (nint)56;
		obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj26 = obj3;
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v9+A0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v14+A0]");
		object obj29 = (nint)0 + (nint)64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v10+10]");
		obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v19+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
			object obj30 = 0;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X9_v17+A0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v18+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X9_v18+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v19+18]");
			object obj33 = 0 & 0xFFFFFFFEL;
			if (obj33 != null)
			{
				object obj34 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X9_v20+A0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X9_v21+54]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X9_v21+5C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v19+18]");
				bool flag2 = (nint)0 < (nint)2;
				object obj36 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v19+18]");
				object obj37 = -2;
				bool flag3 = obj37 == null;
				object obj38 = ~obj36;
				object obj39 = obj38 | flag3;
				if (obj39 == null)
				{
					object obj40 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X9_v23+A0]");
					object obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X9_v24+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X9_v24+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v19+18]");
					object obj42 = 0 & 0xFFFFFFFCL;
					if (obj42 != null)
					{
						object obj43 = obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v19+A0]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v20+3C]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v20+44]");
						_ = 0;
						object obj45 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
						object obj46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v21+A0]");
						object obj47 = (nint)0 + (nint)80;
						object obj48 = default;
						obj47 = obj48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v32+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2498]");
							object obj49 = 0;
							object obj51 = default;
							object obj50 = obj51 + 32;
							obj50 = obj49;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X20_v12-8]");
							object obj52 = 0 & 0xFFFFFFFEL;
							if (obj52 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2480]");
								object obj53 = 0;
								object obj54 = obj51 + 40;
								obj54 = obj53;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X20_v14-10]");
								bool flag4 = (nint)0 < (nint)2;
								object obj55 = !flag4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X20_v14-10]");
								object obj56 = -2;
								bool flag5 = obj56 == null;
								object obj57 = ~obj55;
								object obj58 = obj57 | flag5;
								if (obj58 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2490]");
									object obj59 = 0;
									object obj60 = obj51 + 48;
									obj60 = obj59;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X20_v16-18]");
									object obj61 = 0 & 0xFFFFFFFCL;
									if (obj61 != null)
									{
										object obj62 = obj51 + 56;
										obj62 = obj53;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X20_v18-20]");
										bool flag6 = (nint)0 < (nint)4;
										object obj63 = !flag6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X20_v18-20]");
										object obj64 = -4;
										bool flag7 = obj64 == null;
										object obj65 = ~obj63;
										object obj66 = obj65 | flag7;
										if (obj66 == null)
										{
											object obj67 = obj51 + 64;
											obj67 = obj49;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X20_v20-28]");
											bool flag8 = (nint)0 < (nint)5;
											object obj68 = !flag8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X20_v20-28]");
											object obj69 = -5;
											bool flag9 = obj69 == null;
											object obj70 = ~obj68;
											object obj71 = obj70 | flag9;
											if (obj71 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24A8]");
												object obj72 = 0;
												object obj73 = obj51 + 72;
												obj73 = obj72;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X20_v22-30]");
												bool flag10 = (nint)0 < (nint)6;
												object obj74 = !flag10;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X20_v22-30]");
												object obj75 = -6;
												bool flag11 = obj75 == null;
												object obj76 = ~obj74;
												object obj77 = obj76 | flag11;
												if (obj77 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2488]");
													object obj78 = 0;
													object obj79 = obj51 + 80;
													obj79 = obj78;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X20_v24-38]");
													object obj80 = 0 & 0xFFFFFFF8L;
													if (obj80 != null)
													{
														object obj81 = obj51 + 88;
														obj81 = obj78;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X20_v26-40]");
														bool flag12 = (nint)0 < (nint)8;
														object obj82 = !flag12;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X20_v26-40]");
														object obj83 = -8;
														bool flag13 = obj83 == null;
														object obj84 = ~obj82;
														object obj85 = obj84 | flag13;
														if (obj85 == null)
														{
															object obj86 = obj51 + 96;
															obj86 = obj78;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X20_v28-48]");
															bool flag14 = (nint)0 < (nint)9;
															object obj87 = !flag14;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X20_v28-48]");
															object obj88 = -9;
															bool flag15 = obj88 == null;
															object obj89 = ~obj87;
															object obj90 = obj89 | flag15;
															if (obj90 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D24A0]");
																object obj91 = 0;
																object obj92 = obj51 + 104;
																obj92 = obj91;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X20_v30-50]");
																bool flag16 = (nint)0 < (nint)10;
																object obj93 = !flag16;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X20_v30-50]");
																object obj94 = -10;
																bool flag17 = obj94 == null;
																object obj95 = ~obj93;
																object obj96 = obj95 | flag17;
																if (obj96 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6590]");
																	object obj97 = 0;
																	object obj98 = obj51 + 112;
																	obj98 = obj91;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	object obj99 = obj2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v37+A0]");
																	object obj100 = (nint)0 + (nint)88;
																	obj100 = obj51;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	object obj101 = obj2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v38+A0]");
																	object obj102 = 0;
																	_ = 4280166113L;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v38+A0]");
																	object obj103 = 0;
																	_ = 4279243901L;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v38+A0]");
																	object obj104 = 0;
																	_ = 4293322470L;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v38+A0]");
																	object obj105 = 0;
																	_ = 4286085240L;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v38+A0]");
																	object obj106 = 0;
																	_ = 4280428714L;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v38+A0]");
																	object obj107 = 0;
																	_ = 4279112287L;
																	int num2 = Shader.PropertyToID((string)obj97);
																	object obj108 = obj2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X8_v40+A0]");
																	object obj109 = 0;
																	return;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	internal static Color32 _003CDrawModePanel_003Eg__Shade_007C118_0(Color32 c32, ref GillaMeta._003C_003Ec__DisplayClass118_0 P_1)
	{
		//IL_000e: Invalid comparison between VT and I4
		//IL_003e: Expected Obj, but got I4
		//IL_0051: Expected VT, but got Obj
		//IL_0030: Expected Obj, but got VT
		object obj = ((P_1 == (GillaMeta._003C_003Ec__DisplayClass118_0)(object)0) ? ((object)255) : ((object)(c32 >> 24)));
		Color32 result = (Color32)(obj << 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFI not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BFXIL not yet implemented.\"");
		return result;
	}
}
