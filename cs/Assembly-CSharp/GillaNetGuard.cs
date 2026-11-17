using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Fusion;
using PlayFab;
using PlayFab.ClientModels;
using Unity.IL2CPP.Metadata;
using UnityEngine;

public static class GillaNetGuard
{
	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public Action<string> done;

		public Action<string> failed;

		internal void _003CReadClosedFromPlayFab_003Eb__0(GetUserDataResult r)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0051: Expected Obj, but got I
			//IL_0061: Expected Obj, but got I
			//IL_00fa: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
			object obj = 0;
			Action<string> action = done;
			object obj3;
			if ((object)r.Data != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2AB0]");
				object key = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8E80]");
				object obj2 = 0;
				if (((Dictionary<System.__Canon, System.__Canon>)(object)r.Data).TryGetValue((System.__Canon)key, out System.__Canon value) && value != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ stack_-28_v5 (System.__Canon)+20]");
					if ((nint)0 == 0)
					{
						obj3 = obj;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ stack_-28_v5 (System.__Canon)+20]");
						obj3 = 0;
					}
					goto IL_010c;
				}
			}
			obj3 = obj;
			goto IL_010c;
			IL_010c:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ X19_v3 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
		}

		internal unsafe void _003CReadClosedFromPlayFab_003Eb__1(PlayFabError e)
		{
			//IL_003b: Expected Obj, but got I4
			//IL_0052: Expected Obj, but got Ref
			string errorMessage = e.ErrorMessage;
			Action<string> action = failed;
			bool flag = e.ErrorMessage == null;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = default;
				string text = ((Enum)(&obj2)).ToString();
				errorMessage = text;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ X20_v3 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
		}
	}

	public enum Kind
	{
		// error: enumerator has no value
		Pick,
		// error: enumerator has no value
		Scratch,
		// error: enumerator has no value
		Clang,
		// error: enumerator has no value
		Splash,
		// error: enumerator has no value
		Egg,
		// error: enumerator has no value
		Stood,
		// error: enumerator has no value
		Door,
		// error: enumerator has no value
		PutIn
	}

	public sealed class Holder
	{
		private const float HandedOnFor = default(float);

		private PlayerRef now;

		private PlayerRef was;

		private float wasTill;

		public unsafe void Watch(NetworkObject o)
		{
			//IL_0010: Expected Obj, but got I
			//IL_024f: Expected Obj, but got I4
			//IL_004c: Expected Obj, but got I4
			//IL_0288: Expected Obj, but got I4
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected Obj, but got Unknown
			//IL_0110: Expected Obj, but got I
			//IL_013a: Expected Obj, but got I4
			//IL_0169: Expected Obj, but got I4
			//IL_017e: Expected Obj, but got I
			//IL_01a8: Expected Obj, but got I4
			//IL_00fb: Expected Obj, but got I4
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
			NetworkObject networkObject = default;
			bool flag2 = (UnityEngine.Object)networkObject == (UnityEngine.Object)null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				return;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!networkObject._runner)
			{
				return;
			}
			ArgumentNullException ex = new ArgumentNullException();
			object obj7 = ex & 1;
			if (obj7 == null)
			{
				return;
			}
			int* ptr = networkObject.Ptr;
			PlayerRef none = default;
			if (networkObject.Ptr != null)
			{
				NetworkRunner runner = networkObject._runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
				object obj8 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v22+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				none = PlayerRef.None;
				object obj8 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj12 = 0;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v18+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (none != now)
			{
				was = now;
				float unscaledTime = Time.unscaledTime;
				now = none;
				float num = unscaledTime + 1.5f;
				wasTill = num;
			}
		}

		public bool Is(NetworkObject o, PlayerRef from)
		{
			//IL_0010: Expected Obj, but got I
			//IL_01a2: Expected Obj, but got I4
			//IL_0084: Expected Obj, but got I4
			//IL_00fa: Expected Obj, but got I4
			//IL_015b: Invalid comparison between F4 and I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			Watch(o);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRef none = PlayerRef.None;
			if (none != from)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (now == from)
				{
					return true;
				}
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (was == from)
				{
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime - wasTill;
					return num < 0f;
				}
			}
			return false;
		}

		public Holder()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj2 = !flag;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			now = PlayerRef.None;
			was = PlayerRef.None;
			base._002Ector();
		}
	}

	public const float Slack = default(float);

	public const float MovingSlack = default(float);

	private static readonly Dictionary<(PlayerRef, Kind), Vector2> budgets;

	private static PlayerRef master;

	private static int masterFrame;

	private static NetworkRunner masterRunner;

	private static float toldAt;

	public static bool Spend(PlayerRef from, Kind kind, float rate, float burst)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0220: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected VT, but got Unknown
		//IL_00d5: Expected Obj, but got I4
		//IL_023e: Expected Obj, but got I
		//IL_01f6: Expected I4, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_02c2: Invalid comparison between F4 and I4
		//IL_02d1: Invalid comparison between F4 and I4
		//IL_02e4: Expected Obj, but got F4
		//IL_02f1: Expected Obj, but got F4
		//IL_0326: Expected Obj, but got I4
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_017a: Expected F4, but got VT
		//IL_037b: Invalid comparison between F4 and I4
		//IL_0393: Expected Obj, but got F8
		//IL_03a0: Expected Obj, but got F4
		//IL_040d: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01d6: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		if (none == from)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D48]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj5 = 0;
		float unscaledTime = Time.unscaledTime;
		PlayerRef item = (PlayerRef)(from & 0xFFFFFFFFL);
		(PlayerRef, Unity.IL2CPP.Metadata.__Il2CppInt32Enum) key = (item, (Unity.IL2CPP.Metadata.__Il2CppInt32Enum)kind);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v11+A0]");
		object obj8 = 0;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D38]");
			object obj9 = 0;
			bool flag3 = ((Dictionary<(PlayerRef, Unity.IL2CPP.Metadata.__Il2CppInt32Enum), Vector2>)obj8).TryGetValue(key, out Vector2 value);
			bool flag4 = !flag3;
			object obj10 = obj5;
			object obj11 = !flag4;
			object obj12 = ~obj11;
			float num2 = default;
			float num = ((obj12 != null) ? unscaledTime : num2);
			object obj13 = !flag4;
			object obj14 = ~obj13;
			float num3 = ((obj14 != null) ? burst : ((float)value));
			float num4 = unscaledTime - num;
			float num5 = num4 * rate;
			float num6 = num3 + num5;
			float num7 = num6 - burst;
			bool flag5 = num7 < 0f;
			bool flag6 = num7 == 0f;
			object obj15 = num6 ^ burst;
			object obj16 = num6 ^ num7;
			object obj17 = obj15 & obj16;
			bool flag7 = (nint)obj17 < 0;
			bool flag8 = flag5 == flag7;
			object obj18 = !flag6;
			object obj19 = flag8 & obj18;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				num6 = burst;
			}
			float num8 = num6 + -1f;
			float num9 = num6 - 1f;
			bool flag9 = num9 < 0f;
			object obj21 = (double)num6 ^ 1.0;
			object obj22 = num6 ^ num9;
			object obj23 = obj21 & obj22;
			bool flag10 = (nint)obj23 < 0;
			bool result = flag9 == flag10;
			if (!((double)num6 < 1.0))
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v17+E4]");
			bool flag11 = (nint)0 == 0;
			object obj24 = !flag11;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v17+A0]");
			object obj25 = 0;
			if (obj25 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D40]");
				object obj26 = 0;
				((Dictionary<(PlayerRef, Unity.IL2CPP.Metadata.__Il2CppInt32Enum), Vector2>)obj25).set_Item(key, (Vector2)obj26);
				return result;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
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
		((Dictionary<(PlayerRef, Unity.IL2CPP.Metadata.__Il2CppInt32Enum), Vector2>)obj4).Clear();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v7+A0]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v8+A0]");
		object obj8 = 0;
		_ = 4294967295L;
		_ = 0;
	}

	public static PlayerRef Master(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_06a8: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I4
		//IL_04a0: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I4
		//IL_06c6: Expected Obj, but got I
		//IL_06f1: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I4
		//IL_0777: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I4
		//IL_071c: Expected Obj, but got I
		//IL_073e: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I4
		//IL_07c8: Expected Obj, but got I
		//IL_0846: Expected Obj, but got I4
		//IL_01e9: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_075c: Expected Obj, but got I
		//IL_03ae: Expected Obj, but got I
		//IL_0861: Expected VT, but got I
		//IL_07f7: Expected Obj, but got I4
		//IL_0871: Expected Obj, but got I
		//IL_03fd: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I4
		//IL_0815: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj4 = 0;
		bool flag2 = (UnityEngine.Object)runner == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		UnityEngine.Object obj6 = null;
		if (obj5 == null)
		{
			if ((object)runner == null)
			{
				NullReferenceException ex = new NullReferenceException();
				object obj7 = 0;
				UnityEngine.Object obj8 = null;
				NullReferenceException ex2 = ex;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				PlayerRef result = default;
				return result;
			}
			bool isRunning = runner.IsRunning;
			bool flag4 = !isRunning;
			obj6 = null;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v65+E4]");
				bool flag5 = (nint)0 == 0;
				object obj11 = !flag5;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v65+A0]");
				object obj12 = 0;
				int frameCount = Time.frameCount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v25+C]");
				bool flag6 = (nint)0 != frameCount;
				object obj13 = 0;
				UnityEngine.Object obj14 = null;
				object obj22;
				if (!flag6)
				{
					object obj15 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v89+E4]");
					bool flag7 = (nint)0 == 0;
					object obj16 = !flag7;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj15 = obj9;
					}
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v89+A0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v33+E4]");
					bool flag8 = (nint)0 == 0;
					object obj19 = !flag8;
					if (obj19 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X9_v11+10]");
					bool flag9 = (UnityEngine.Object)0 == runner;
					bool flag10 = !flag9;
					obj13 = 0;
					obj14 = runner;
					if (!flag10)
					{
						object obj20 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v94+E4]");
						bool flag11 = (nint)0 == 0;
						object obj21 = !flag11;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj20 = obj9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v94+A0]");
						obj22 = 0;
						goto IL_0854;
					}
				}
				int frameCount2 = Time.frameCount;
				object obj23 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v28+E4]");
				bool flag12 = (nint)0 == 0;
				object obj24 = !flag12;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj23 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v28+A0]");
				object obj25 = (nint)0 + (nint)16;
				obj25 = runner;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				PlayerRef playerRef;
				if (runner.IsSharedModeMasterClient)
				{
					playerRef = runner.LocalPlayer;
					object obj26 = 0;
				}
				else
				{
					playerRef = runner.GetMasterClient();
					object obj26 = 0;
				}
				object obj27 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v14+E4]");
				bool flag13 = (nint)0 == 0;
				object obj28 = !flag13;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj27 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v14+A0]");
				object obj29 = 0;
				PlayerRef playerRef2 = playerRef;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v14+E4]");
				bool flag14 = (nint)0 == 0;
				object obj30 = !flag14;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj31 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v16+E4]");
				bool flag15 = (nint)0 == 0;
				object obj32 = !flag15;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj33 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+A0]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X9_v3+8]");
				if ((nint)0 <= (nint)0)
				{
					object obj35 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v22+E4]");
					bool flag16 = (nint)0 == 0;
					object obj36 = !flag16;
					if (obj36 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					PlayerRef none = PlayerRef.None;
					obj33 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+E4]");
					bool flag17 = (nint)0 == 0;
					object obj37 = !flag17;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj33 = obj9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+A0]");
					object obj38 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+E4]");
				bool flag18 = (nint)0 == 0;
				object obj39 = !flag18;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj33 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+A0]");
				obj22 = 0;
				goto IL_0854;
			}
		}
		object obj40 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+E4]");
		bool flag19 = (nint)0 == 0;
		object obj41 = !flag19;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return PlayerRef.None;
		IL_0854:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v5+8]");
		return (PlayerRef)0;
	}

	public static bool IsMaster(NetworkRunner runner, PlayerRef p)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		if (none == p)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef = Master(runner);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = playerRef - p;
		return obj9 == null;
	}

	public static bool IsMasters(NetworkObject o)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_03ad: Expected I4, but got Obj
		//IL_040f: Expected Obj, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_023f: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)o == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			if ((object)o == null)
			{
				goto IL_039f;
			}
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((bool)o._runner)
			{
				if ((object)o._runner == null)
				{
					goto IL_039f;
				}
				ArgumentNullException ex = new ArgumentNullException();
				object obj7 = ex & 1;
				if (obj7 != null)
				{
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v18+E4]");
					bool flag5 = (nint)0 == 0;
					object obj9 = !flag5;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag6 = (UnityEngine.Object)o._runner == (UnityEngine.Object)null;
					bool flag7 = !flag6;
					object obj10 = !flag7;
					if (obj10 == null)
					{
						if ((object)o._runner == null)
						{
							goto IL_039f;
						}
						if (o._runner.IsRunning)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BA88");
							object obj12 = default;
							object obj11 = obj12 & 1;
							if (obj11 != null)
							{
								return o._runner.IsSharedModeMasterClient;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
							object obj13 = 0;
							object obj14 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v26+E4]");
							bool flag8 = (nint)0 == 0;
							object obj15 = !flag8;
							if (obj15 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							PlayerRef playerRef = Master(o._runner);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
							object obj16 = 0;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v14+E4]");
							bool flag9 = (nint)0 == 0;
							object obj18 = !flag9;
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							PlayerRef none = PlayerRef.None;
							if (playerRef != none)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3057B14");
								object obj19 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v15+E4]");
								bool flag10 = (nint)0 == 0;
								object obj20 = !flag10;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj22 = default;
								object obj21 = obj22 - playerRef;
								return obj21 == null;
							}
						}
					}
				}
			}
		}
		return false;
		IL_039f:
		NullReferenceException ex2 = new NullReferenceException();
		return (byte)(int)ex2 != 0;
	}

	public unsafe static int Owned<T>(IEnumerable<T> all, T self, PlayerRef owner, Func<T, bool> counts = null) where T : NetworkBehaviour
	{
		//IL_0b1a: Expected VT, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I4
		//IL_0d48: Expected I, but got Obj
		//IL_0d58: Expected Obj, but got I
		//IL_0ae3: Expected Obj, but got VT
		//IL_015a: Expected VT, but got I4
		//IL_0dcd: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_0d94: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		//IL_01d0: Expected VT, but got Obj
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_10df: Expected I, but got Obj
		//IL_10ef: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_02bf: Expected VT, but got I4
		//IL_0e57: Expected I, but got Obj
		//IL_0e67: Expected Obj, but got I
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected Obj, but got Unknown
		//IL_0e9c: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I
		//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected Obj, but got Unknown
		//IL_0c08: Expected Obj, but got I
		//IL_0c18: Expected Obj, but got I
		//IL_0c28: Expected Obj, but got I
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_0cb7: Expected VT, but got I4
		//IL_024a: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_10c8: Expected Obj, but got I
		//IL_0c63: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0370: Expected Obj, but got I4
		//IL_1086: Expected Obj, but got I4
		//IL_0eb2: Expected I, but got Obj
		//IL_0ec2: Expected Obj, but got I
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected Obj, but got Unknown
		//IL_0449: Expected VT, but got I4
		//IL_0cf6: Expected Obj, but got I4
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected Obj, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected Obj, but got Unknown
		//IL_0f6b: Expected Obj, but got I4
		//IL_03b1: Expected Obj, but got I
		//IL_04bb: Expected VT, but got I4
		//IL_0efe: Expected Obj, but got I
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_054e: Expected VT, but got I4
		//IL_0585: Expected Obj, but got VT
		//IL_058f: Expected VT, but got I4
		//IL_05d2: Expected VT, but got I4
		//IL_061f: Expected Obj, but got I4
		//IL_064e: Expected Obj, but got I
		//IL_0671: Expected VT, but got I
		//IL_067a: Expected VT, but got I4
		//IL_069d: Expected Obj, but got I
		//IL_06c8: Expected VT, but got I4
		//IL_06f3: Expected Obj, but got I
		//IL_1006: Expected Obj, but got I4
		//IL_072b: Expected VT, but got Obj
		//IL_0734: Expected VT, but got I4
		//IL_0b31: Expected VT, but got I4
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_079a: Expected VT, but got Obj
		//IL_07a3: Expected VT, but got I4
		//IL_07c9: Expected Obj, but got I
		//IL_07e9: Expected VT, but got I4
		//IL_0bf0: Expected Obj, but got I4
		//IL_0b9e: Expected Obj, but got I4
		//IL_1024: Expected Obj, but got I
		//IL_08b8: Expected Obj, but got I
		//IL_08e2: Expected Obj, but got I4
		//IL_0911: Expected VT, but got I4
		//IL_0814: Expected Obj, but got I
		//IL_0834: Expected VT, but got I4
		//IL_092e: Expected Obj, but got I
		//IL_0968: Expected Obj, but got I4
		//IL_0994: Expected Obj, but got VT
		//IL_086a: Expected VT, but got I4
		//IL_0890: Expected Obj, but got I
		//IL_08a3: Expected VT, but got I4
		//IL_0a24: Expected VT, but got I
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected Obj, but got Unknown
		//IL_0a6b: Expected VT, but got I
		nint num = 0;
		bool flag = all == null;
		UnityEngine.Object obj = null;
		if (flag)
		{
			goto IL_0b04;
		}
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		nint num2 = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
			IntPtr intPtr = default;
			num2 = intPtr;
		}
		nint num3 = (nint)all;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0147;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+98]");
		object obj6 = (nint)0 + (nint)8;
		bool flag4 = default;
		bool flag3 = flag4;
		object obj7 = default;
		bool flag5 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X10_v36-8]");
			obj7 = -num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X10_v36-8]");
			flag5 = 0 == num2;
			if (flag5)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
			obj5 = -1;
			obj7 = obj5 - 1;
			flag5 = obj7 == null;
			obj8 = obj6 + 16;
			flag4 = (nint)obj5 != 1;
			flag3 = flag4;
			obj6 = obj8;
			if (flag4)
			{
				continue;
			}
			goto IL_0147;
		}
		obj5 = obj6;
		object obj9 = num3 + obj6;
		object obj10 = obj9 + 312;
		PlayerRef playerRef2 = default;
		PlayerRef playerRef = playerRef2;
		flag4 = flag3;
		obj8 = obj6;
		goto IL_0dbd;
		IL_0dbd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v14+8]");
		T val = (T)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ X0_v14] (should have been resolved before IL gen)");
		UnityEngine.Object obj11 = default;
		flag = (object)obj11 == null;
		nint num4 = (nint)(&obj);
		obj = obj11;
		num = (nint)(&obj);
		T val2 = default;
		PlayerRef playerRef5;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj13 = 0;
			UnityEngine.Object obj15 = default;
			UnityEngine.Object obj14 = obj15;
			PlayerRef playerRef3 = (PlayerRef)val2;
			UnityEngine.Object obj16 = obj11;
			PlayerRef playerRef4 = playerRef;
			bool flag6 = flag4;
			bool flag7 = flag5;
			object obj17 = obj7;
			object obj18 = obj8;
			int num5 = 0;
			object obj21 = default;
			UnityEngine.Object obj24 = default;
			T val3 = default;
			PlayerRef none = default;
			object obj38 = default;
			IntPtr intPtr2 = default;
			NullReferenceException ex7 = default;
			int result = default;
			object obj54 = default;
			object obj59 = default;
			while (true)
			{
				nint num6 = (nint)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v17 (Il2CppClass<UnityEngine.Object>)+12E]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v17 (Il2CppClass<UnityEngine.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02ac;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v17 (Il2CppClass<UnityEngine.Object>)+98]");
				object obj19 = (nint)0 + (nint)8;
				bool flag8 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X10_v31-8]");
					obj17 = 0 - obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X10_v31-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v17 (Il2CppClass<UnityEngine.Object>)+12E]");
					obj5 = -1;
					obj17 = obj5 - 1;
					flag7 = obj17 == null;
					obj18 = obj19 + 16;
					flag6 = (nint)obj5 != 1;
					flag8 = flag6;
					obj19 = obj18;
					if (flag6)
					{
						continue;
					}
					goto IL_02ac;
				}
				obj5 = obj19;
				object obj20 = num6 + obj19;
				obj21 = obj20 + 312;
				flag6 = flag8;
				obj18 = obj19;
				goto IL_0e4f;
				IL_0f79:
				bool flag9 = (object)obj11 == null;
				flag = !flag9;
				num4 = (nint)(&obj);
				playerRef5 = playerRef3;
				obj = obj11;
				obj16 = obj11;
				playerRef4 = playerRef;
				if (flag)
				{
					continue;
				}
				goto IL_0ac4;
				IL_0436:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				playerRef4 = (PlayerRef)0;
				goto IL_0f27;
				IL_0f27:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v806 @ X0_v41] (should have been resolved before IL gen)");
				object obj22 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X0_v44+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X0_v44+E4]");
				bool flag10 = (nint)0 == 0;
				object obj23 = !flag10;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag11 = obj24 != null;
				bool flag12 = !flag11;
				playerRef = (PlayerRef)0;
				val = null;
				if (!flag12)
				{
					object obj25 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X0_v49+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X0_v49+E4]");
					bool flag13 = (nint)0 == 0;
					object obj26 = !flag13;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = obj24 != val3;
					bool flag15 = !flag14;
					playerRef = (PlayerRef)0;
					val = val3;
					if (!flag15)
					{
						flag = (object)obj24 == null;
						num4 = (nint)(&obj);
						val2 = (T)playerRef3;
						playerRef = (PlayerRef)0;
						val = val3;
						obj = obj11;
						if (flag)
						{
							goto IL_0ae8;
						}
						bool isActiveAndEnabled = ((UnityEngine.Behaviour)obj24).isActiveAndEnabled;
						bool flag16 = !isActiveAndEnabled;
						playerRef = (PlayerRef)0;
						val = null;
						if (!flag16)
						{
							object obj27 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v55+E4]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v55+E4]");
							bool flag17 = (nint)0 == 0;
							object obj28 = !flag17;
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v43 (UnityEngine.Object)+40]");
							bool flag18 = (UnityEngine.Object)0 != null;
							bool flag19 = !flag18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v43 (UnityEngine.Object)+40]");
							playerRef3 = (PlayerRef)0;
							playerRef = (PlayerRef)0;
							val = null;
							if (!flag19)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v43 (UnityEngine.Object)+40]");
								val2 = (T)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v43 (UnityEngine.Object)+40]");
								flag = (nint)0 == 0;
								num4 = (nint)(&obj);
								playerRef = (PlayerRef)0;
								val = null;
								obj = obj11;
								if (flag)
								{
									goto IL_0af6;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X27_v1 (T)+30]");
								obj14 = (UnityEngine.Object)0;
								object obj29 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v60+E4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X0_v60+E4]");
								bool flag20 = (nint)0 == 0;
								object obj30 = !flag20;
								if (obj30 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag21 = obj14;
								bool flag22 = !flag21;
								playerRef3 = (PlayerRef)val2;
								playerRef = (PlayerRef)0;
								val = null;
								if (!flag22)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X27_v1 (T)+30]");
									if ((nint)0 != 0)
									{
										ArgumentNullException ex = new ArgumentNullException();
										object obj31 = ex & 1;
										bool flag23 = obj31 == null;
										playerRef3 = (PlayerRef)val2;
										playerRef = (PlayerRef)0;
										val = val2;
										if (flag23)
										{
											goto IL_0f79;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v43 (UnityEngine.Object)+40]");
										object obj32 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v43 (UnityEngine.Object)+40]");
										bool flag24 = (nint)0 == 0;
										playerRef4 = (PlayerRef)0;
										val = val2;
										if (flag24)
										{
											goto IL_0b49;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X27_v16+20]");
										object obj33 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X27_v16+20]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
											object obj34 = 0;
											object obj35 = obj34;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v942 @ X0_v85+E4]");
											bool flag25 = (nint)0 == 0;
											object obj36 = !flag25;
											if (obj36 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											none = PlayerRef.None;
											playerRef = (PlayerRef)0;
											val = val2;
											goto IL_091e;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X27_v16+30]");
										obj5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X27_v16+30]");
										bool flag26 = (nint)0 == 0;
										playerRef4 = (PlayerRef)0;
										val = val2;
										if (!flag26)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X9_v27+58]");
											bool flag27 = (nint)0 == 0;
											playerRef4 = (PlayerRef)0;
											val = val2;
											if (!flag27)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v50+20]");
												val = (T)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
												playerRef = (PlayerRef)0;
												goto IL_091e;
											}
										}
									}
									else
									{
										NullReferenceException ex2 = new NullReferenceException();
										playerRef4 = (PlayerRef)0;
										val = null;
									}
									NullReferenceException ex3 = new NullReferenceException();
									goto IL_0b49;
								}
							}
						}
					}
				}
				goto IL_0f79;
				IL_02ac:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				playerRef4 = (PlayerRef)0;
				goto IL_0e4f;
				IL_0e4f:
				num = (nint)obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v18+8]");
				val = (T)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v500 @ X0_v18] (should have been resolved before IL gen)");
				object obj37 = obj38 & 1;
				bool flag28 = obj37 == null;
				OutOfMemoryException ex4 = null;
				object obj39 = 0;
				if (flag28)
				{
					goto IL_0bf5;
				}
				flag = (object)obj11 == null;
				num4 = (nint)(&obj);
				playerRef5 = playerRef3;
				playerRef = playerRef4;
				obj = obj11;
				if (flag)
				{
					break;
				}
				object obj40 = (nint)0 + (nint)309;
				object obj41 = obj40 & 1;
				bool flag29 = obj41 == null;
				object obj42 = !flag29;
				nint num7 = 0;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9E5E4");
					num7 = intPtr2;
				}
				nint num8 = (nint)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v33 (Il2CppClass<UnityEngine.Object>)+12E]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v33 (Il2CppClass<UnityEngine.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0436;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v33 (Il2CppClass<UnityEngine.Object>)+98]");
				object obj43 = (nint)0 + (nint)8;
				bool flag30 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v25-8]");
					obj17 = -num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v25-8]");
					if (0 == num7)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v33 (Il2CppClass<UnityEngine.Object>)+12E]");
					obj5 = -1;
					obj17 = obj5 - 1;
					flag7 = obj17 == null;
					obj18 = obj43 + 16;
					flag6 = (nint)obj5 != 1;
					flag30 = flag6;
					obj43 = obj18;
					if (flag6)
					{
						continue;
					}
					goto IL_0436;
				}
				obj5 = obj43;
				object obj44 = num8 + obj43;
				object obj45 = obj44 + 312;
				flag6 = flag30;
				obj18 = obj43;
				goto IL_0f27;
				IL_10b8:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v34+8]");
				val = (T)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v744 @ X0_v34] (should have been resolved before IL gen)");
				bool flag31 = ex4 == null;
				object obj46 = !flag31;
				if (obj46 == null)
				{
					bool flag32 = obj39 == null;
					object obj47 = !flag32;
					OutOfMemoryException ex5 = ex4;
					if (obj47 == null)
					{
						return num5;
					}
				}
				else
				{
					OutOfMemoryException ex5 = new OutOfMemoryException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
				NullReferenceException ex6 = ex7;
				goto IL_1049;
				IL_0bf5:
				nint num9 = 0;
				object obj48 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v26+12E]");
				object obj50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v26+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0ca4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v26+98]");
				object obj51 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v19-8]");
					if (0 == (nint)obj49)
					{
						break;
					}
					obj50--;
					obj51 += 16;
					if ((nint)obj50 != 1)
					{
						continue;
					}
					goto IL_0ca4;
				}
				object obj52 = obj48 + obj51;
				object obj53 = obj52 + 312;
				goto IL_10b8;
				IL_1049:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return result;
				IL_0b49:
				NullReferenceException ex8 = new NullReferenceException();
				if ((nint)val == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex4 = null;
					obj39 = 1;
				}
				else
				{
					bool flag33 = (nint)val != 1;
					ex6 = ex8;
					if (flag33)
					{
						goto IL_1049;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
					ex4 = (OutOfMemoryException)obj54;
					obj39 = 0;
				}
				goto IL_0bf5;
				IL_0ca4:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
				playerRef4 = (PlayerRef)0;
				goto IL_10b8;
				IL_091e:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
				object obj55 = 0;
				object obj56 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v79+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v79+E4]");
				bool flag34 = (nint)0 == 0;
				object obj57 = !flag34;
				if (obj57 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj17 = none - playerRef2;
				flag7 = obj17 == null;
				flag6 = none != playerRef2;
				playerRef3 = none;
				if (!flag6)
				{
					bool flag35 = counts == null;
					PlayerRef playerRef6 = playerRef;
					T val4 = val;
					nint num10 = num;
					if (!flag35)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [counts @ X3 (System.Func`2<T, System.Boolean>)+18]");
						num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [counts @ X3 (System.Func`2<T, System.Boolean>)+28]");
						playerRef6 = (PlayerRef)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [counts @ X3 (System.Func`2<T, System.Boolean>)+18] (should have been resolved before IL gen)");
						object obj58 = obj59 & 1;
						bool flag36 = obj58 == null;
						val4 = (T)obj24;
						playerRef3 = none;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [counts @ X3 (System.Func`2<T, System.Boolean>)+28]");
						playerRef = (PlayerRef)0;
						val = (T)obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [counts @ X3 (System.Func`2<T, System.Boolean>)+18]");
						num = 0;
						if (flag36)
						{
							goto IL_0f79;
						}
					}
					num5++;
					playerRef3 = none;
					playerRef = playerRef6;
					val = val4;
					num = num10;
				}
				goto IL_0f79;
			}
			goto IL_0ad2;
		}
		goto IL_0b12;
		IL_0b04:
		NullReferenceException ex9 = new NullReferenceException();
		goto IL_0b12;
		IL_0af6:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_0b04;
		IL_0ae8:
		NullReferenceException ex11 = new NullReferenceException();
		goto IL_0af6;
		IL_0ad2:
		NullReferenceException ex12 = new NullReferenceException();
		val2 = (T)playerRef5;
		goto IL_0ae8;
		IL_0ac4:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_0ad2;
		IL_0b12:
		playerRef5 = (PlayerRef)val2;
		goto IL_0ac4;
		IL_0147:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		playerRef = (PlayerRef)0;
		goto IL_0dbd;
	}

	public unsafe static void Ignore(NetworkBehaviour thing, string what, int most)
	{
		//IL_0010: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_04ad: Expected Obj, but got I
		//IL_04bd: Invalid comparison between F4 and I
		//IL_0122: Expected Obj, but got I4
		//IL_04e4: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_02c8: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_032d: Expected Obj, but got I
		//IL_0347: Expected Obj, but got I
		//IL_0371: Expected Obj, but got I4
		//IL_052c: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0261: Expected Obj, but got I4
		//IL_0564: Expected Obj, but got I4
		//IL_02b3: Expected Obj, but got I4
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
		bool flag2 = (UnityEngine.Object)thing == (UnityEngine.Object)null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj5 = 0;
		float unscaledTime = Time.unscaledTime;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v9+A0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6+18]");
		if (unscaledTime < 0f)
		{
			bool flag5 = (object)thing == null;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0438;
		}
		float unscaledTime2 = Time.unscaledTime;
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v17+A0]");
		object obj12 = 0;
		float num = unscaledTime2 + 5f;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = (UnityEngine.Object)((SimulationBehaviour)thing)._object != (UnityEngine.Object)null;
		bool flag9 = !flag8;
		object obj15 = 0;
		UnityEngine.Object obj16 = null;
		if (!flag9)
		{
			UnityEngine.Object obj17 = ((SimulationBehaviour)thing)._object;
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v45+E4]");
			bool flag10 = (nint)0 == 0;
			object obj19 = !flag10;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X22_v13 (UnityEngine.Object)+30]");
			bool flag11 = (UnityEngine.Object)0;
			bool flag12 = !flag11;
			obj15 = 0;
			obj16 = null;
			if (!flag12)
			{
				ArgumentNullException ex = new ArgumentNullException();
				object obj20 = ex & 1;
				bool flag13 = obj20 == null;
				obj15 = 0;
				obj16 = obj17;
				if (!flag13)
				{
					NetworkObject networkObject = ((SimulationBehaviour)thing)._object;
					int* ptr = networkObject.Ptr;
					bool flag14 = networkObject.Ptr == null;
					obj15 = 0;
					obj16 = obj17;
					if (!flag14)
					{
						NetworkRunner runner = networkObject._runner;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D8BD10");
						obj15 = 0;
						goto IL_031d;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj21 = 0;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v39+E4]");
		bool flag15 = (nint)0 == 0;
		object obj23 = !flag15;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef none = PlayerRef.None;
		goto IL_031d;
		IL_0438:
		GameObject gameObject = thing.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_031d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj25 = 0;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v15+E4]");
		bool flag16 = (nint)0 == 0;
		object obj27 = !flag16;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef playerRef = default;
		int playerId = playerRef.PlayerId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D58]");
		object format = 0;
		object arg = default;
		object arg2 = default;
		string message = string.Format((string)format, what, arg, arg2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj28 = 0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v22+E4]");
		bool flag17 = (nint)0 == 0;
		object obj30 = !flag17;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		goto IL_0438;
	}

	public static bool Near(PlayerRef from, Vector3 at, float reach, float slack)
	{
		//IL_0010: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected VT, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_02f6: Expected I4, but got Obj
		//IL_0107: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_02bf: Invalid comparison between F8 and I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5250]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRef player = (PlayerRef)(from & 0xFFFFFFFFL);
		NetworkApe networkApe = NetworkApe.Find(player);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag3 = (UnityEngine.Object)networkApe == (UnityEngine.Object)null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			if ((object)networkApe != null)
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (networkApe.head == null)
				{
					goto IL_0154;
				}
				float sizeNow = networkApe.SizeNow;
				bool flag6 = (double)sizeNow < 1.0;
				double num = 1.0;
				if (!flag6)
				{
					bool flag7 = !((double)sizeNow > 2.0);
					num = sizeNow;
					if (!flag7)
					{
						num = 2.0;
					}
				}
				if ((object)networkApe.head != null)
				{
					object obj10 = default;
					double num2 = num * (double)obj10;
					object obj11 = default;
					double num3 = num2 + (double)obj11;
					Vector3 position = networkApe.head.position;
					double num4 = num2 - (double)reach;
					double num5 = num - (double)slack;
					object obj13 = default;
					object obj12 = obj13 - obj13;
					double num6 = num4 * num4;
					double num7 = num5 * num5;
					double num8 = num6 + num7;
					object obj14 = obj12 * obj12;
					double num9 = (double)obj14 + num8;
					double num10 = num3 * num3;
					bool flag8 = num9 < num10;
					object obj15 = !flag8;
					double num11 = num9 - num10;
					bool flag9 = num11 == 0.0;
					object obj16 = ~obj15;
					return (byte)((obj16 | flag9) ? 1 : 0) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_0154;
		IL_0154:
		return false;
	}

	static GillaNetGuard()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_003e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D2D60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5310]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<(PlayerRef, Unity.IL2CPP.Metadata.__Il2CppInt32Enum), Vector2> dictionary = default;
		dictionary._002Ector();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = dictionary;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+A0]");
		object obj7 = 0;
		_ = 4294967295L;
	}
}
