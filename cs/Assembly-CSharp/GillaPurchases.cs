using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine;

public static class GillaPurchases
{
	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass47_0
	{
		public Transform theirs;
	}

	public enum Result
	{
		// error: enumerator has no value
		Bought,
		// error: enumerator has no value
		Cancelled,
		// error: enumerator has no value
		Failed
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Callback _003C_003E9__30_0;

		static _003C_003Ec()
		{
			//IL_0010: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF938]");
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

		internal unsafe void _003CRedeemOwned_003Eb__30_0(Message<PurchaseList> message)
		{
			//IL_0b15: Expected Obj, but got I4
			//IL_0b26: Expected Obj, but got I4
			//IL_002c: Expected Obj, but got I4
			//IL_00bc: Expected Obj, but got I
			//IL_018f: Expected Obj, but got I
			//IL_0b44: Expected Obj, but got I
			//IL_0b54: Expected Obj, but got I
			//IL_0b81: Expected Obj, but got I
			//IL_0ba3: Expected Obj, but got I4
			//IL_00ee: Expected I, but got Obj
			//IL_00fe: Expected Obj, but got I
			//IL_010e: Expected Obj, but got I
			//IL_0133: Expected Obj, but got I4
			//IL_01bd: Expected Obj, but got I4
			//IL_01c5: Expected I, but got Obj
			//IL_01ce: Expected Obj, but got I4
			//IL_006f: Expected Obj, but got I
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected Obj, but got Unknown
			//IL_0aa8: Expected Obj, but got I4
			//IL_0d9a: Expected Obj, but got I
			//IL_0daa: Expected Obj, but got I
			//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd3: Expected Obj, but got Unknown
			//IL_0ded: Expected Obj, but got I4
			//IL_0df6: Expected Obj, but got I4
			//IL_0159: Expected Obj, but got I
			//IL_016e: Expected Obj, but got I
			//IL_0661: Expected Obj, but got I4
			//IL_0af7: Expected Obj, but got I4
			//IL_071b: Expected Obj, but got I
			//IL_0745: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got I4
			//IL_0d39: Expected Obj, but got I4
			//IL_05a8: Expected Obj, but got I
			//IL_05b8: Expected Obj, but got I
			//IL_0219: Expected Obj, but got I
			//IL_023b: Expected Obj, but got I
			//IL_024b: Expected Obj, but got I
			//IL_025b: Expected Obj, but got I
			//IL_06b0: Expected Obj, but got I4
			//IL_0653: Expected I, but got Obj
			//IL_0cec: Expected Obj, but got I4
			//IL_0cf9: Expected Obj, but got Ref
			//IL_0d7b: Expected Obj, but got I
			//IL_05f3: Expected Obj, but got I
			//IL_07b7: Expected Obj, but got I
			//IL_07c7: Expected Obj, but got I
			//IL_07db: Expected Obj, but got I8
			//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e9: Expected Obj, but got Unknown
			//IL_07f2: Expected Obj, but got I4
			//IL_0e25: Expected Obj, but got I4
			//IL_0278: Expected Obj, but got I
			//IL_0684: Unknown result type (might be due to invalid IL or missing references)
			//IL_0689: Expected Obj, but got Unknown
			//IL_0347: Expected I, but got Obj
			//IL_06fd: Expected Obj, but got I4
			//IL_060e: Expected Obj, but got I
			//IL_0617: Unknown result type (might be due to invalid IL or missing references)
			//IL_061c: Expected Obj, but got Unknown
			//IL_0800: Unknown result type (might be due to invalid IL or missing references)
			//IL_0805: Expected Obj, but got Unknown
			//IL_081f: Expected Obj, but got I4
			//IL_0c02: Expected Obj, but got I
			//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1a: Expected Obj, but got Unknown
			//IL_02b3: Expected Obj, but got I
			//IL_08e2: Expected Obj, but got I4
			//IL_056d: Expected Obj, but got I4
			//IL_057a: Expected Obj, but got Ref
			//IL_0583: Expected Obj, but got I4
			//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc9: Expected Obj, but got Unknown
			//IL_0910: Expected Obj, but got I
			//IL_092e: Expected Obj, but got I4
			//IL_039c: Expected Obj, but got I4
			//IL_03a9: Expected Obj, but got Ref
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Expected Obj, but got Unknown
			//IL_09c0: Expected Obj, but got I4
			//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ce: Expected Obj, but got Unknown
			//IL_02d6: Expected Obj, but got I
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected Obj, but got Unknown
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Expected Obj, but got Unknown
			//IL_0976: Expected Obj, but got I4
			//IL_085a: Expected I, but got Obj
			//IL_086f: Expected Obj, but got I
			//IL_0892: Expected Obj, but got I
			//IL_089a: Expected I, but got Obj
			//IL_08aa: Expected Obj, but got I
			//IL_03df: Expected Obj, but got I
			//IL_09a4: Expected Obj, but got I
			//IL_04ae: Expected I, but got Obj
			//IL_0c87: Expected Obj, but got I
			//IL_0ca9: Expected Obj, but got I4
			//IL_0cb6: Expected Obj, but got Ref
			//IL_041a: Expected Obj, but got I
			//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4e: Expected Obj, but got Unknown
			//IL_0503: Expected Obj, but got I4
			//IL_0510: Expected Obj, but got Ref
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected Obj, but got Unknown
			//IL_043d: Expected Obj, but got I
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Expected Obj, but got Unknown
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Expected Obj, but got Unknown
			//IL_053e: Expected Obj, but got I
			//IL_0546: Expected I, but got Obj
			//IL_055b: Expected Obj, but got I
			bool flag = message == null;
			object obj = 0;
			Message<PurchaseList> message2 = message;
			HashSet<System.__Canon> hashSet = (HashSet<System.__Canon>)109895680;
			if (flag)
			{
				goto IL_0a3b;
			}
			bool isError = message.IsError;
			bool flag2 = !isError;
			object obj2 = !flag2;
			object obj7 = default;
			object obj4;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.PurchaseList>)+40]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF948]");
					object obj3 = 0;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47DCB5C");
					object obj6 = default;
					object obj5 = obj6 & 1;
					if (obj5 == null)
					{
						obj7 = 0;
						goto IL_0d8a;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF968]");
			object obj8 = 0;
			string text2;
			object obj9;
			if (message.IsError)
			{
				nint num = (nint)message;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v53 (Il2CppClass<Oculus.Platform.Message`1<Oculus.Platform.Models.PurchaseList>>)+528]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v53 (Il2CppClass<Oculus.Platform.Message`1<Oculus.Platform.Models.PurchaseList>>)+530]");
				message2 = (Message<PurchaseList>)0;
				NetSyncSetSessionPropertyResult netSyncSetSessionPropertyResult = ((Message<ChallengeList>)(object)message).GetNetSyncSetSessionPropertyResult();
				bool flag3 = netSyncSetSessionPropertyResult == null;
				obj = 0;
				hashSet = (HashSet<System.__Canon>)obj8;
				if (flag3)
				{
					goto IL_0a3b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v91 (Oculus.Platform.Models.NetSyncSetSessionPropertyResult)+18]");
				string text = (string)obj10 + (string)0;
				text2 = text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF958]");
				object obj11 = 0;
				text2 = (string)obj11;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF960]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj13 = 0;
			string message3 = (string)obj8 + text2 + (string)obj12;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v50+E4]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v50+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message3);
			obj7 = 1;
			nint num2 = (nint)obj12;
			obj4 = 0;
			goto IL_0d8a;
			IL_0d6b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v5+8]");
			message2 = (Message<PurchaseList>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v794 @ X0_v5] (should have been resolved before IL gen)");
			goto IL_0d1f;
			IL_0e56:
			object obj17 = default;
			object obj16 = obj17;
			if (obj17 == null)
			{
				goto IL_0d1f;
			}
			object obj18 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v7+12E]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v7+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0644;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v7+98]");
			object obj20 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X10_v9-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v7+12E]");
				obj9 = -1;
				obj19 = obj20 + 16;
				bool flag5 = (nint)obj9 != 1;
				obj20 = obj19;
				if (flag5)
				{
					continue;
				}
				goto IL_0644;
			}
			obj9 = obj20;
			object obj21 = obj18 + obj20;
			object obj22 = obj21 + 312;
			obj19 = obj20;
			goto IL_0d6b;
			IL_0a03:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0a11;
			IL_0a49:
			OutOfMemoryException ex2 = new OutOfMemoryException();
			goto IL_0a57;
			IL_0a1f:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0a2d;
			IL_070b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj23 = 0;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v40+E4]");
			bool flag6 = (nint)0 == 0;
			object obj25 = !flag6;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string[] array = Skus();
			if (array != null)
			{
				if (array.Length < 1)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46F8]");
				object obj27 = 0;
				object obj28 = array.Length & 0xFFFFFFFFL;
				object obj29 = array + 32;
				object obj30 = 0;
				while (true)
				{
					bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj30) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28);
					object obj31 = !flag7;
					if (obj31 != null)
					{
						break;
					}
					object obj32 = obj7 & 1;
					bool flag8 = obj32 == null;
					object obj33 = !flag8;
					System.__Canon _Canon = (System.__Canon)(object)message2;
					nint num3;
					if (obj33 == null)
					{
						if (hashSet == null)
						{
							goto IL_0a3b;
						}
						num2 = (nint)obj27;
						HashSet<System.__Canon> hashSet2 = hashSet;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v5+v245 @ X24_v1*8]");
						bool flag9 = hashSet2.Contains((System.__Canon)0);
						bool flag10 = !flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v5+v245 @ X24_v1*8]");
						_Canon = (System.__Canon)0;
						num3 = (nint)obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v5+v245 @ X24_v1*8]");
						message2 = (Message<PurchaseList>)0;
						if (flag10)
						{
							goto IL_09b6;
						}
					}
					object obj34 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X0_v46+E4]");
					bool flag11 = (nint)0 == 0;
					object obj35 = !flag11;
					if (obj35 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v5+v245 @ X24_v1*8]");
					bool flag12 = Have((string)0);
					bool flag13 = !flag12;
					object obj36 = !flag13;
					num3 = num2;
					message2 = (Message<PurchaseList>)(object)_Canon;
					if (obj36 == null)
					{
						object obj37 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v50+E4]");
						bool flag14 = (nint)0 == 0;
						object obj38 = !flag14;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X27_v5+v245 @ X24_v1*8]");
						GillaCloud.RedeemPurchases((string)0);
						num3 = num2;
						message2 = null;
					}
					goto IL_09b6;
					IL_09b6:
					obj28 = array.Length;
					obj30++;
					bool flag15 = (nint)obj30 < array.Length;
					num2 = num3;
					if (!flag15)
					{
						return;
					}
				}
				IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
				goto IL_0a03;
			}
			goto IL_0a3b;
			IL_0644:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
			num2 = unchecked((nint)null);
			goto IL_0d6b;
			IL_0564:
			object obj39 = 0;
			OutOfMemoryException ex5 = null;
			obj17 = (object)(&obj);
			object obj40 = 7;
			HashSet<System.__Canon> hashSet3 = default;
			hashSet = hashSet3;
			goto IL_0e56;
			IL_0a2d:
			NullReferenceException ex6 = new NullReferenceException();
			goto IL_0a3b;
			IL_0a3b:
			NullReferenceException ex7 = new NullReferenceException();
			goto IL_0a49;
			IL_0a11:
			NullReferenceException ex8 = new NullReferenceException();
			goto IL_0a1f;
			IL_0d8a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47D8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			message2 = (Message<PurchaseList>)obj42;
			hashSet3._002Ector();
			object obj43 = obj7 & 1;
			bool flag16 = obj43 == null;
			object obj44 = !flag16;
			obj = 0;
			hashSet = hashSet3;
			if (obj44 != null)
			{
				goto IL_070b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.PurchaseList>)+40]");
			bool flag17 = (nint)0 == 0;
			obj = 0;
			hashSet = hashSet3;
			if (!flag17)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF940]");
				object obj45 = 0;
				System.__Canon _Canon2 = (System.__Canon)obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47DC668");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF950]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46C0]");
				object obj30 = 0;
				object obj47 = default;
				bool flag20 = default;
				object obj54 = default;
				object obj59 = default;
				while (true)
				{
					bool flag18 = obj47 == null;
					obj39 = 0;
					ex5 = null;
					obj17 = (object)(&obj);
					obj = obj47;
					message2 = (Message<PurchaseList>)(object)_Canon2;
					hashSet = hashSet3;
					if (flag18)
					{
						break;
					}
					object obj48 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v38+12E]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v38+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0338;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v38+98]");
					object obj49 = (nint)0 + (nint)8;
					bool flag19 = flag20;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X10_v31-8]");
						object obj50 = 0 - obj46;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X10_v31-8]");
						if (0 == (nint)obj46)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v38+12E]");
						obj9 = -1;
						obj50 = obj9 - 1;
						bool flag21 = obj50 == null;
						obj19 = obj49 + 16;
						flag20 = (nint)obj9 != 1;
						flag19 = flag20;
						obj49 = obj19;
						if (flag20)
						{
							continue;
						}
						goto IL_0338;
					}
					obj9 = obj49;
					object obj51 = obj48 + obj49;
					object obj52 = obj51 + 312;
					flag20 = flag19;
					obj19 = obj49;
					goto IL_0bf2;
					IL_0338:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num2 = unchecked((nint)null);
					goto IL_0bf2;
					IL_0bf2:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X0_v66+8]");
					message2 = (Message<PurchaseList>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v934 @ X0_v66] (should have been resolved before IL gen)");
					object obj53 = obj54 & 1;
					if (obj53 == null)
					{
						goto IL_0564;
					}
					bool flag22 = obj47 == null;
					obj39 = 0;
					ex5 = null;
					obj17 = (object)(&obj);
					obj = obj47;
					hashSet = hashSet3;
					if (flag22)
					{
						goto IL_0a1f;
					}
					object obj55 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v41+12E]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v41+12E]");
					if ((nint)0 == 0)
					{
						goto IL_049f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v41+98]");
					object obj56 = (nint)0 + (nint)8;
					bool flag23 = flag20;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X10_v26-8]");
						object obj50 = 0 - obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X10_v26-8]");
						if (0 == (nint)obj23)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X8_v41+12E]");
						obj9 = -1;
						obj50 = obj9 - 1;
						bool flag21 = obj50 == null;
						obj19 = obj56 + 16;
						flag20 = (nint)obj9 != 1;
						flag23 = flag20;
						obj56 = obj19;
						if (flag20)
						{
							continue;
						}
						goto IL_049f;
					}
					obj9 = obj56;
					object obj57 = obj55 + obj56;
					object obj58 = obj57 + 312;
					flag20 = flag23;
					obj19 = obj56;
					goto IL_0c77;
					IL_0c77:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v69+8]");
					message2 = (Message<PurchaseList>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1030 @ X0_v69] (should have been resolved before IL gen)");
					bool flag24 = obj59 == null;
					obj39 = 0;
					ex5 = null;
					obj17 = (object)(&obj);
					obj = obj47;
					hashSet = hashSet3;
					if (!flag24)
					{
						bool flag25 = hashSet3 == null;
						obj39 = 0;
						ex5 = null;
						obj17 = (object)(&obj);
						obj = obj47;
						hashSet = hashSet3;
						if (!flag25)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v71+38]");
							_Canon2 = (System.__Canon)0;
							num2 = (nint)obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v71+38]");
							bool flag26 = hashSet3.Add((System.__Canon)0);
							continue;
						}
						goto IL_0a11;
					}
					goto IL_0a2d;
					IL_049f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
					num2 = unchecked((nint)null);
					goto IL_0c77;
				}
				goto IL_0a03;
			}
			goto IL_0a3b;
			IL_0a57:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
			if ((nint)message2 == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				obj39 = 1;
			}
			else
			{
				if ((nint)message2 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
				object obj60 = default;
				ex5 = (OutOfMemoryException)obj60;
			}
			obj40 = 0;
			goto IL_0e56;
			IL_0d1f:
			bool flag27 = ex5 == null;
			object obj61 = !flag27;
			if (obj61 != null)
			{
				goto IL_0a49;
			}
			bool flag28 = obj39 == null;
			object obj62 = !flag28;
			ex2 = ex5;
			if (obj62 == null)
			{
				if ((nint)obj40 != 7)
				{
					bool flag29 = obj40 == null;
					object obj63 = !flag29;
					if (obj63 != null)
					{
						return;
					}
				}
				goto IL_070b;
			}
			goto IL_0a57;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string[] skus;

		internal void _003CAskPrices_003Eb__0(Message<ProductList> message)
		{
			//IL_0010: Expected Obj, but got I
			//IL_005e: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TookPrices(skus, message);
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public string[] skus;

		internal void _003CTookPrices_003Eb__0(Message<ProductList> next)
		{
			//IL_0010: Expected Obj, but got I
			//IL_005e: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TookPrices(skus, next);
		}
	}

	public const string SizeSku = null;

	public const string OpSku = null;

	public const string PunchSku = null;

	private static string busySku;

	private static float busySince;

	private static float backAt;

	private const float AnswerWithin = default(float);

	private const float LongestCheckout = default(float);

	private static Action<string> m_CheckoutOpened;

	private const float RefetchEvery = default(float);

	private static readonly Dictionary<string, string> prices;

	private static int asking;

	private static bool oneByOne;

	private static float nextFetch;

	public static bool Busy
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_008a: Expected Obj, but got I4
			//IL_0041: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Unstick();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v4+A0]");
			object obj5 = 0;
			bool flag2 = obj5 == null;
			return !flag2;
		}
	}

	public static bool XpBoost
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_011d: Expected I4, but got Obj
			//IL_0069: Expected Obj, but got I4
			//IL_00b2: Expected Obj, but got I4
			int bundleCount = CosmeticCatalog.BundleCount;
			if (bundleCount >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
				object obj = 0;
				int num = 0;
				int bundleCount2;
				do
				{
					Coins.Bundle bundle = CosmeticCatalog.BundleAt(num);
					if (bundle != null)
					{
						if (~(bundle.xpBoost ? 1u : 0u) == 0)
						{
							object obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v8+E4]");
							bool flag = (nint)0 == 0;
							object obj3 = !flag;
							if (obj3 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							bool flag2 = Coins.OwnsName(bundle.sku);
							bool flag3 = !flag2;
							object obj4 = !flag3;
							if (obj4 != null)
							{
								return true;
							}
						}
						num++;
						bundleCount2 = CosmeticCatalog.BundleCount;
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				while (num < bundleCount2);
			}
			return false;
		}
	}

	public static event Action<string> CheckoutOpened
	{
		add
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			//IL_0176: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			object obj8 = default;
			Delegate obj15 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				if ((object)obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = obj8 == null;
					object obj9 = !flag2;
					object obj10 = obj8;
					Delegate obj11 = (Delegate)obj5;
					if (obj9 == null)
					{
						break;
					}
				}
				else
				{
					object obj10 = 0;
					Delegate obj11 = value;
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+A0]");
				object obj14 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj15 != obj6;
				obj6 = obj15;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_0010: Expected Obj, but got I
			//IL_00d2: Expected Obj, but got I4
			//IL_0156: Expected Obj, but got I
			//IL_0166: Expected Obj, but got I
			//IL_0176: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I4
			//IL_010a: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I4
			//IL_0191: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+A0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			object obj8 = default;
			Delegate obj15 = default;
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				if ((object)obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
					bool flag2 = obj8 == null;
					object obj9 = !flag2;
					object obj10 = obj8;
					Delegate obj11 = (Delegate)obj5;
					if (obj9 == null)
					{
						break;
					}
				}
				else
				{
					object obj10 = 0;
					Delegate obj11 = value;
				}
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj12 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+A0]");
				object obj14 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65CA4");
				bool flag4 = (object)obj15 != obj6;
				obj6 = obj15;
				if (!flag4)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	public static string[] Skus()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I
		//IL_02b9: Expected I4, but got Obj
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I4
		//IL_0392: Expected Obj, but got I
		//IL_03a2: Expected Obj, but got I
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_05ed: Expected Obj, but got I
		//IL_0605: Expected Obj, but got I
		//IL_0615: Expected Obj, but got I
		//IL_0637: Expected Obj, but got I4
		//IL_06a1: Expected Obj, but got I4
		//IL_092d: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I4
		//IL_0705: Expected Obj, but got I8
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_096b: Expected Obj, but got I4
		//IL_048d: Expected I4, but got Obj
		//IL_04ef: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I
		//IL_0579: Expected Obj, but got I
		//IL_0798: Expected Obj, but got I4
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0812: Expected Obj, but got I
		//IL_0822: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I
		//IL_0854: Expected Obj, but got I
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected Obj, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		object obj3;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC700]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
			obj3 = 0;
			System.__Canon[] items = list._items;
			object obj4 = obj3;
			int version = list._version + 1;
			list._version = version;
			if (list._items != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC708]");
				object obj5 = 0;
				bool flag = list._size < items.Length;
				object obj6 = !flag;
				System.__Canon _Canon = default;
				if (obj6 == null)
				{
					object obj7 = list._items + list._size;
					int size = list._size + 1;
					list._size = size;
					object obj8 = obj7 + 32;
					obj8 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X9_v5+20]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v37+A8]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v38+70]");
					_Canon = (System.__Canon)0;
					list.AddWithResize((System.__Canon)obj2);
				}
				System.__Canon[] items2 = list._items;
				object obj11 = obj3;
				int version2 = list._version + 1;
				list._version = version2;
				if (list._items != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC710]");
					object obj12 = 0;
					bool flag2 = list._size < items2.Length;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						object obj14 = list._items + list._size;
						int size2 = list._size + 1;
						list._size = size2;
						object obj15 = obj14 + 32;
						obj15 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X9_v7+20]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v35+A8]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v36+70]");
						_Canon = (System.__Canon)0;
						list.AddWithResize((System.__Canon)obj5);
					}
					System.__Canon[] items3 = list._items;
					System.__Canon _Canon2 = (System.__Canon)obj12;
					int num = (int)obj3;
					int version3 = list._version + 1;
					list._version = version3;
					if (list._items != null)
					{
						bool flag3 = list._size < items3.Length;
						object obj18 = !flag3;
						if (obj18 == null)
						{
							object obj19 = items3 + list._size;
							num = list._size + 1;
							list._size = num;
							object obj20 = obj19 + 32;
							obj20 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X9_v18 (System.Int32)+20]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v33+A8]");
							items3 = (System.__Canon[])0;
							_Canon = items3[10];
							list.AddWithResize((System.__Canon)obj12);
						}
						int bundleCount = CosmeticCatalog.BundleCount;
						if (bundleCount < 1)
						{
							goto IL_05dd;
						}
						System.__Canon _Canon3 = _Canon;
						int num2 = 0;
						while (true)
						{
							Coins.Bundle bundle = CosmeticCatalog.BundleAt(num2);
							if (bundle == null)
							{
								break;
							}
							bool flag4 = string.IsNullOrEmpty(bundle.sku);
							bool flag5 = !flag4;
							object obj22 = !flag5;
							_Canon2 = null;
							if (obj22 == null)
							{
								Coins.Bundle bundle2 = CosmeticCatalog.BundleAt(num2);
								if (bundle2 == null)
								{
									break;
								}
								items3 = list._items;
								_Canon2 = (System.__Canon)(object)bundle2.sku;
								num = (int)obj3;
								int version4 = list._version + 1;
								list._version = version4;
								if (list._items == null)
								{
									break;
								}
								bool flag6 = list._size < items3.Length;
								object obj23 = !flag6;
								if (obj23 == null)
								{
									object obj24 = items3 + list._size;
									num = list._size + 1;
									list._size = num;
									object obj25 = obj24 + 32;
									obj25 = bundle2.sku;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X9_v18 (System.Int32)+20]");
									object obj26 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v31+A8]");
									items3 = (System.__Canon[])0;
									_Canon3 = items3[10];
									list.AddWithResize((System.__Canon)(object)bundle2.sku);
								}
							}
							num2++;
							int bundleCount2 = CosmeticCatalog.BundleCount;
							bool flag7 = num2 < bundleCount2;
							_Canon = _Canon3;
							if (flag7)
							{
								continue;
							}
							goto IL_05dd;
						}
					}
				}
			}
		}
		goto IL_08a7;
		IL_05dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj27 = 0;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF718]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj31 = !flag8;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<string> allSkus = MonsterChoice.AllSkus;
		object obj32 = obj29;
		list.AddRange((IEnumerable<System.__Canon>)allSkus);
		object obj33 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj34 = !flag9;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v20+A0]");
		object obj35 = 0;
		object obj36 = obj35;
		if (obj35 == null)
		{
			goto IL_08a7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X20_v11+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0894;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X20_v11+18]");
		object obj37 = 0 & 0xFFFFFFFFL;
		object obj38 = obj35 + 32;
		object obj39 = 0;
		while (true)
		{
			bool flag10 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37);
			object obj40 = !flag10;
			if (obj40 != null)
			{
				break;
			}
			System.__Canon[] items4 = list._items;
			object obj41 = obj3;
			int version5 = list._version + 1;
			list._version = version5;
			if (list._items != null)
			{
				bool flag11 = list._size < items4.Length;
				object obj42 = !flag11;
				if (obj42 == null)
				{
					object obj43 = list._items + list._size;
					int size3 = list._size + 1;
					list._size = size3;
					object obj44 = obj43 + 32;
					obj44 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X9_v14+20]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v26+A8]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v27+70]");
					obj32 = 0;
					list.AddWithResize((System.__Canon)obj38);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X20_v11+18]");
				obj37 = 0;
				obj39++;
				obj38 += 24;
				object obj47 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X20_v11+18]");
				if ((nint)obj47 < 0)
				{
					continue;
				}
				goto IL_0894;
			}
			goto IL_08a7;
		}
		goto IL_08b5;
		IL_0894:
		return (string[])(object)list.ToArray();
		IL_08a7:
		NullReferenceException ex = new NullReferenceException();
		goto IL_08b5;
		IL_08b5:
		return (string[])(object)new IndexOutOfRangeException();
	}

	private static void Unstick()
	{
		//IL_0010: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I4
		//IL_0381: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_012d: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_02a3: Expected F8, but got I4
		//IL_00d6: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I4
		//IL_0304: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
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
		if (obj4 == null)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+C]");
		float num2;
		double num3;
		if ((nint)0 < (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+A0]");
				obj7 = 0;
			}
			float num = unscaledTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v23+8]");
			num2 = num - 0f;
			num3 = 1127481344.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+A0]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v22+C]");
				obj8 = 0;
			}
			num2 = unscaledTime - (float)obj8;
			num3 = 8.0;
		}
		if ((double)num2 > num3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v9+A0]");
			object obj13 = 0;
			obj13 = 0;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8B0]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8A8]");
			object obj16 = 0;
			string message = (string)obj15 + (string)obj13 + (string)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj17 = 0;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4670]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v16+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GillaCloud.RedeemPurchases((string)obj13);
		}
	}

	private static void OnFocus(bool focused)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+A0]");
		object obj4 = 0;
		if (obj4 != null)
		{
			bool flag2 = !focused;
			float num = -1f;
			if (!flag2)
			{
				float unscaledTime = Time.unscaledTime;
				obj2 = obj;
				num = unscaledTime;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+A0]");
			object obj6 = 0;
		}
	}

	private static void Forget()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I4
		//IL_018e: Expected Obj, but got I
		//IL_01b6: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_0099: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CAB78]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+A0]");
		object obj7 = 0;
		obj7 = 0;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+A0]");
		object obj10 = 0;
		_ = 3212836864L;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<bool> action = default;
		action._002Ector((object)null, (IntPtr)obj4);
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Application.focusChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Action<bool> action2 = default;
		action2._002Ector((object)null, (IntPtr)obj4);
		UnityEngine.Application.focusChanged += action2;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v9+A0]");
		object obj14 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v10+18]");
		((Dictionary<System.__Canon, System.__Canon>)0).Clear();
	}

	public static string PriceOf(string sku)
	{
		//IL_03fc: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I4
		//IL_0459: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I4
		//IL_00f8: Expected I4, but got I8
		//IL_0112: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
		//IL_02a3: Expected Obj, but got I
		//IL_02cd: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I4
		//IL_0424: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I
		//IL_037f: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I
		bool flag = string.IsNullOrEmpty(sku);
		bool flag2 = !flag;
		object obj = !flag2;
		string result = null;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
			object obj2 = 0;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (UnityEngine.Application.isEditor)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v23+E4]");
				bool flag4 = (nint)0 == 0;
				object obj7 = !flag4;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num = GillaAtm.PackOf(sku);
				int num2 = (int)(num & 0x80000000L);
				bool flag5 = num2 == 0;
				object obj8 = !flag5;
				if (obj8 == null)
				{
					object obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v41+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj9 = obj5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v41+A0]");
					object obj11 = 0;
					object obj12 = obj11;
					if (obj11 == null)
					{
						goto IL_03b9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v27+18]");
					bool flag7 = (nint)num < (nint)0;
					object obj13 = !flag7;
					if (obj13 != null)
					{
						goto IL_03c7;
					}
					object obj14 = num * 24;
					object obj15 = obj11 + obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v28+30]");
					result = (string)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
					object obj16 = 0;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v27+E4]");
					bool flag8 = (nint)0 == 0;
					object obj18 = !flag8;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text = MonsterChoice.ForSku(sku);
					object obj19;
					if (text != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5C8]");
						obj19 = 0;
					}
					else
					{
						Coins.Bundle bundle = CosmeticCatalog.BundleWithSku(sku);
						if (bundle != null)
						{
							bool flag9 = string.IsNullOrEmpty(bundle.usd);
							bool flag10 = !flag9;
							object obj20 = !flag10;
							result = null;
							if (obj20 == null)
							{
								result = bundle.usd;
							}
							goto IL_040f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5C0]");
						obj19 = 0;
					}
					result = (string)obj19;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
				object obj21 = 0;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v15+E4]");
				bool flag11 = (nint)0 == 0;
				object obj23 = !flag11;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj22 = obj21;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v15+A0]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v11+18]");
				if ((nint)0 == 0)
				{
					goto IL_03b9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v11+18]");
				bool flag12 = ((Dictionary<System.__Canon, System.__Canon>)0).TryGetValue((System.__Canon)(object)sku, out var value);
				bool flag13 = !flag12;
				object obj25 = !flag13;
				object obj26 = ~obj25;
				result = (string)(object)((obj26 != null) ? null : value);
			}
		}
		goto IL_040f;
		IL_040f:
		return result;
		IL_03b9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03c7;
		IL_03c7:
		return (string)(object)new IndexOutOfRangeException();
	}

	public static void FetchPrices()
	{
		//IL_0010: Expected Obj, but got I
		//IL_047e: Expected Obj, but got I4
		//IL_05cf: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_04b6: Expected Obj, but got I4
		//IL_0604: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I
		//IL_04e4: Invalid comparison between F4 and I
		//IL_01b2: Expected Obj, but got I4
		//IL_0508: Expected Obj, but got I
		//IL_053e: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I8
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_05b1: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I4
		//IL_02fd: Expected Obj, but got I
		//IL_03c9: Expected Obj, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0350: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
		if ((nint)0 > (nint)0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isEditor = UnityEngine.Application.isEditor;
		bool flag3 = !isEditor;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v9+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v13+A0]");
		object obj14 = 0;
		if (obj14 == null)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v16+A0]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v17+28]");
		if (unscaledTime < 0f)
		{
			return;
		}
		float unscaledTime2 = Time.unscaledTime;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v19+A0]");
		object obj20 = 0;
		float num = unscaledTime2 + 1.1146363E+09f;
		string[] array = Skus();
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v21+A0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X9_v2+24]");
		if ((nint)0 != 0)
		{
			if (array == null)
			{
				goto IL_043f;
			}
			if (array.Length < 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5B8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
			object obj24 = 0;
			object obj25 = array.Length & 0xFFFFFFFFL;
			object obj26 = array + 32;
			object obj27 = 0;
			string[] array2 = default;
			while (true)
			{
				bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25);
				object obj28 = !flag8;
				if (obj28 != null)
				{
					break;
				}
				object obj29 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v31+E4]");
				bool flag9 = (nint)0 == 0;
				object obj30 = !flag9;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj29 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v31+A0]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v28+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v28+18]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X26_v6+v301 @ X23_v7*8]");
					bool flag10 = ((Dictionary<System.__Canon, System.__Canon>)num2).ContainsKey((System.__Canon)0);
					bool flag11 = !flag10;
					object obj32 = !flag11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X26_v6+v301 @ X23_v7*8]");
					System.__Canon _Canon = (System.__Canon)0;
					if (obj32 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						if (array2 == null)
						{
							goto IL_043f;
						}
						object obj33 = array2 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X26_v6+v301 @ X23_v7*8]");
						obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj34 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v40+E4]");
						bool flag12 = (nint)0 == 0;
						object obj35 = !flag12;
						if (obj35 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AskPrices(array2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X26_v6+v301 @ X23_v7*8]");
						_Canon = (System.__Canon)0;
					}
					obj25 = array.Length;
					obj27++;
					if ((nint)obj27 >= array.Length)
					{
						return;
					}
					continue;
				}
				goto IL_043f;
			}
			goto IL_044d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v21+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AskPrices(array);
		return;
		IL_044d:
		throw new IndexOutOfRangeException();
		IL_043f:
		NullReferenceException ex = new NullReferenceException();
		goto IL_044d;
	}

	private static void AskPrices(string[] skus)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00ef: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8C0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8C8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8D8]");
		object obj5 = 0;
		object obj6 = obj2 + 16;
		obj6 = skus;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v10+A0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v5+20]");
		object obj10 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3 (System.Object)+10]");
		Request<ProductList> productsBySKU = IAP.GetProductsBySKU((string[])0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Callback val = default;
		val._002Ector(obj2, (IntPtr)obj5);
		Request<System.__Canon> request = ((Request<System.__Canon>)(object)productsBySKU).OnComplete(val);
	}

	private static void TookPrices(string[] skus, Message<ProductList> message)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1390: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Expected Obj, but got I4
		//IL_1268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_13d0: Expected Obj, but got I
		//IL_13e6: Expected Obj, but got I
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_140d: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_0a1d: Expected Obj, but got I
		//IL_0a37: Expected Obj, but got I
		//IL_00c6: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_0a55: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Expected Obj, but got I
		//IL_1453: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_1645: Expected Obj, but got I
		//IL_16fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1707: Expected Obj, but got I4
		//IL_0ab7: Expected Obj, but got I
		//IL_0ac7: Expected Obj, but got I
		//IL_0ae1: Expected Obj, but got I8
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected Obj, but got Unknown
		//IL_0b10: Expected Obj, but got I4
		//IL_02bc: Expected I, but got Obj
		//IL_1871: Expected Obj, but got I4
		//IL_1895: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Expected Obj, but got I
		//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14eb: Expected Obj, but got Unknown
		//IL_1516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got I4
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1483: Expected Obj, but got I
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected Obj, but got Unknown
		//IL_07f6: Expected Obj, but got I4
		//IL_0e84: Expected Obj, but got I
		//IL_0e9d: Expected I, but got Obj
		//IL_0eb1: Expected I, but got Obj
		//IL_0b45: Expected Obj, but got I
		//IL_0b67: Expected Obj, but got I4
		//IL_19db: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e3: Expected Obj, but got Unknown
		//IL_19e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ec: Invalid comparison between Unknown and I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_1735: Expected Obj, but got I
		//IL_1745: Expected Obj, but got I
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got I4
		//IL_17fb: Expected Obj, but got I
		//IL_1684: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_082b: Expected Obj, but got I
		//IL_0855: Expected Obj, but got I4
		//IL_0ee7: Expected Obj, but got I
		//IL_0ef7: Expected Obj, but got I
		//IL_0f0d: Expected Obj, but got I
		//IL_0f41: Expected Obj, but got I
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected Obj, but got Unknown
		//IL_0f8b: Expected Obj, but got I4
		//IL_0f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Expected Obj, but got Unknown
		//IL_0fa1: Expected I4, but got Obj
		//IL_0612: Expected Obj, but got I
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected Obj, but got I
		//IL_0786: Expected Obj, but got I
		//IL_0796: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I
		//IL_0fd4: Expected Obj, but got I
		//IL_0b94: Expected I, but got Obj
		//IL_0ba9: Expected Obj, but got I
		//IL_0bc7: Expected Obj, but got I4
		//IL_08c6: Expected Obj, but got I4
		//IL_06bd: Expected I, but got Obj
		//IL_0449: Expected I, but got Obj
		//IL_18e4: Expected Obj, but got I
		//IL_18fc: Expected Obj, but got I
		//IL_191e: Expected Obj, but got I4
		//IL_0fbf: Expected Obj, but got I
		//IL_0dc0: Expected Obj, but got I
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dce: Expected Obj, but got Unknown
		//IL_16d6: Expected Obj, but got I
		//IL_065d: Expected Obj, but got I
		//IL_1588: Expected Obj, but got I
		//IL_03b5: Expected Obj, but got I
		//IL_0ff9: Expected I, but got Obj
		//IL_1015: Expected I, but got Obj
		//IL_16a2: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I4
		//IL_1538: Expected Obj, but got I
		//IL_154a: Unknown result type (might be due to invalid IL or missing references)
		//IL_154f: Expected Obj, but got Unknown
		//IL_0929: Expected Obj, but got I
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected Obj, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_0497: Expected Obj, but got I
		//IL_04b5: Expected Obj, but got I4
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0c3a: Expected Obj, but got I
		//IL_0c58: Expected Obj, but got I
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Invalid comparison between Unknown and I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Invalid comparison between Unknown and I4
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_09ab: Expected Obj, but got I4
		//IL_04f2: Expected Obj, but got I4
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Expected Obj, but got I
		//IL_1093: Expected Obj, but got I
		//IL_0cb2: Expected Obj, but got I
		//IL_0cc2: Expected Obj, but got I
		//IL_0ceb: Expected Obj, but got I4
		//IL_15bf: Expected Obj, but got I
		//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Expected Obj, but got I
		//IL_0d7e: Expected Obj, but got I
		//IL_09e3: Expected Obj, but got I4
		//IL_1966: Expected Obj, but got I
		//IL_1977: Unknown result type (might be due to invalid IL or missing references)
		//IL_197b: Unknown result type (might be due to invalid IL or missing references)
		//IL_197f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1983: Unknown result type (might be due to invalid IL or missing references)
		//IL_1994: Expected I, but got Obj
		//IL_19a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Expected Obj, but got I
		//IL_0d2c: Expected Obj, but got I
		//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3f: Expected Obj, but got Unknown
		//IL_177e: Expected Obj, but got I
		//IL_178e: Expected Obj, but got I
		//IL_17a4: Expected Obj, but got I
		//IL_17c3: Expected Obj, but got I
		//IL_17d4: Expected I, but got Obj
		//IL_0527: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Expected I, but got Obj
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected Obj, but got I4
		//IL_1128: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1145: Expected I, but got Obj
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1168: Expected Obj, but got I4
		//IL_1313: Expected Obj, but got I4
		//IL_118f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Expected Obj, but got Unknown
		//IL_11d0: Expected Obj, but got I4
		//IL_1362: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8E0]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		object obj = default;
		obj._002Ector();
		bool flag = obj == null;
		Enumerator<, > val = (Enumerator<, >)0;
		object obj2 = 0;
		System.__Canon _Canon = null;
		Message<ProductList> message2 = message;
		object obj3 = obj;
		object obj4;
		string text2 = default;
		object obj8;
		object obj34;
		NullReferenceException ex;
		Enumerator<, > val3;
		object obj14;
		object obj15;
		nint num = default;
		object obj9 = default;
		object obj17 = default;
		string text6 = default;
		Enumerator<, > val2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			obj4 = 0;
			text = (string)(obj + 16);
			text = (string)(object)skus;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v99+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v99+A0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v72+20]");
			text2 = (string)(-1);
			bool flag3 = message == null;
			val = (Enumerator<, >)0;
			obj2 = 0;
			_Canon = (System.__Canon)(object)skus;
			message2 = message;
			obj3 = obj;
			if (!flag3)
			{
				if (!message.IsError)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.ProductList>)+40]");
					message2 = (Message<ProductList>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ X1 (Oculus.Platform.Message`1<Oculus.Platform.Models.ProductList>)+40]");
					bool flag4 = (nint)0 == 0;
					val = (Enumerator<, >)0;
					obj8 = obj9;
					obj2 = 0;
					object obj10 = 0;
					if (flag4)
					{
						goto IL_0a0d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8E8]");
					object obj11 = 0;
					_Canon = (System.__Canon)obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47DC668");
					object obj12 = default;
					bool flag5 = obj12 == null;
					val2 = (Enumerator<, >)text2;
					if (flag5)
					{
						goto IL_05bd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4638]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8F8]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5A30]");
					obj15 = 0;
					object obj16 = obj17;
					string text4 = default;
					string text3 = text4;
					IntPtr intPtr = num;
					string text5 = text6;
					object obj18 = obj12;
					bool flag7 = default;
					object obj24 = default;
					object obj28 = default;
					while (true)
					{
						object obj19 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v79+12E]");
						text2 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v79+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02ad;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v79+98]");
						string text7 = (string)((nint)0 + (nint)8);
						bool flag6 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v45 (System.String)-8]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v45 (System.String)-8]");
							object obj20 = 0 - obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X10_v45 (System.String)-8]");
							if (0 == (nint)obj13)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v79+12E]");
							text2 = (string)(-1);
							obj20 = text2 - 1;
							bool flag8 = obj20 == null;
							text5 = text7 + 16;
							flag7 = (nint)text2 != 1;
							flag6 = flag7;
							text7 = text5;
							if (flag7)
							{
								continue;
							}
							goto IL_02ad;
						}
						text2 = text7;
						object obj21 = obj19 + text7;
						object obj22 = obj21 + 312;
						num = intPtr;
						flag7 = flag6;
						text5 = text7;
						goto IL_14c3;
						IL_14c3:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v108+8]");
						_Canon = (System.__Canon)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1075 @ X0_v108] (should have been resolved before IL gen)");
						object obj23 = obj24 & 1;
						bool flag9 = obj23 == null;
						obj17 = obj16;
						text4 = text3;
						text6 = text5;
						val2 = (Enumerator<, >)text2;
						if (flag9)
						{
							break;
						}
						bool flag10 = obj12 == null;
						val = (Enumerator<, >)0;
						obj17 = obj16;
						text4 = text3;
						text6 = text5;
						obj9 = null;
						ex = null;
						val3 = (Enumerator<, >)(ref obj2);
						obj2 = obj12;
						obj3 = obj;
						if (flag10)
						{
							goto IL_125b;
						}
						object obj25 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v82+12E]");
						val2 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v82+12E]");
						if ((nint)0 == 0)
						{
							goto IL_043a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v82+98]");
						string text8 = (string)((nint)0 + (nint)8);
						bool flag11 = flag7;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X10_v40 (System.String)-8]");
							obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X10_v40 (System.String)-8]");
							object obj20 = 0 - obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1368 @ X10_v40 (System.String)-8]");
							if (0 == (nint)obj14)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v82+12E]");
							val2 = (Enumerator<, >)(-1);
							obj20 = val2 - 1;
							bool flag8 = obj20 == null;
							text5 = text8 + 16;
							flag7 = (int)val2 != 1;
							flag11 = flag7;
							text8 = text5;
							if (flag7)
							{
								continue;
							}
							goto IL_043a;
						}
						val2 = (Enumerator<, >)text8;
						object obj26 = obj25 + text8;
						object obj27 = obj26 + 312;
						flag7 = flag11;
						text5 = text8;
						goto IL_1578;
						IL_1578:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1418 @ X0_v111+8]");
						_Canon = (System.__Canon)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1418 @ X0_v111] (should have been resolved before IL gen)");
						if (obj28 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X0_v113+58]");
							bool flag12 = string.IsNullOrEmpty((string)0);
							bool flag13 = !flag12;
							object obj29 = !flag13;
							_Canon = null;
							if (obj29 == null)
							{
								object obj30 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1482 @ X0_v118+E4]");
								bool flag14 = (nint)0 == 0;
								object obj31 = !flag14;
								if (obj31 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj30 = obj4;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1482 @ X0_v118+A0]");
								object obj32 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v87+18]");
								bool flag15 = (nint)0 == 0;
								val = (Enumerator<, >)0;
								obj17 = obj16;
								text4 = text3;
								text6 = text5;
								obj9 = null;
								ex = null;
								val3 = (Enumerator<, >)(ref obj2);
								obj2 = obj12;
								_Canon = null;
								obj3 = obj;
								if (flag15)
								{
									goto IL_129b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X0_v113+58]");
								_Canon = (System.__Canon)0;
								text3 = (string)obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v87+18]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X0_v113+58]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X0_v113+30]");
								((Dictionary<System.__Canon, System.__Canon>)num2).set_Item((System.__Canon)num3, (System.__Canon)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1423 @ X0_v113+30]");
								num = 0;
							}
						}
						bool flag16 = obj12 == null;
						object obj33 = !flag16;
						obj17 = obj16;
						text4 = text3;
						text6 = text5;
						intPtr = num;
						obj18 = obj12;
						if (obj33 != null)
						{
							continue;
						}
						goto IL_05bd;
						IL_043a:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
						num = unchecked((nint)null);
						goto IL_1578;
						IL_02ad:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
						num = unchecked((nint)null);
						goto IL_14c3;
					}
					val = (Enumerator<, >)0;
					obj34 = 7;
					obj9 = null;
					ex = null;
					val3 = (Enumerator<, >)(ref obj2);
					obj3 = obj;
					goto IL_19db;
				}
				nint num4 = (nint)message;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v90 (Il2CppClass<Oculus.Platform.Message`1<Oculus.Platform.Models.ProductList>>)+530]");
				_Canon = (System.__Canon)0;
				NetSyncSetSessionPropertyResult netSyncSetSessionPropertyResult = ((Message<ChallengeList>)(object)message).GetNetSyncSetSessionPropertyResult();
				if (netSyncSetSessionPropertyResult != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v129 (Oculus.Platform.Models.NetSyncSetSessionPropertyResult)+18]");
					text2 = (string)0;
				}
				else
				{
					text2 = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				object obj35 = 0;
				text6 = (string)obj35;
				nint num5 = (nint)text;
				text = (string)((text2 != null) ? text2 : obj35);
				bool flag17 = text == null;
				val = (Enumerator<, >)0;
				obj2 = 0;
				message2 = message;
				obj3 = obj;
				if (!flag17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v93 (Il2CppClass<System.String>)+18]");
					val2 = (Enumerator<, >)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v93 (Il2CppClass<System.String>)+18]");
					string message3;
					if ((nint)0 < (nint)2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v93 (Il2CppClass<System.String>)+18]");
						bool flag18 = (nint)0 == 0;
						val = (Enumerator<, >)0;
						obj2 = 0;
						message2 = message;
						obj3 = obj;
						if (flag18)
						{
							goto IL_1271;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF908]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v93 (Il2CppClass<System.String>)+20]");
						string text9 = (string)0;
						string text10 = (string)obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v93 (Il2CppClass<System.String>)+20]");
						message3 = (string)obj36 + (string)0 + (string)obj37 + text;
						string text4 = text;
					}
					else
					{
						object obj38 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X0_v136+E4]");
						bool flag19 = (nint)0 == 0;
						object obj39 = !flag19;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj38 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF910]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X0_v136+A0]");
						object obj41 = 0;
						_ = 1;
						message3 = (string)obj40 + text;
						string text10 = null;
						string text9 = text;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
					object obj42 = 0;
					object obj43 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X8_v97+E4]");
					bool flag20 = (nint)0 == 0;
					object obj44 = !flag20;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogWarning(message3);
					return;
				}
			}
		}
		goto IL_124d;
		IL_19db:
		object obj45 = val3;
		if ((int)val3 == 0)
		{
			goto IL_166a;
		}
		object obj46 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4630]");
		text6 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v15+12E]");
		val2 = (Enumerator<, >)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06ae;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v15+98]");
		string text11 = (string)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X10_v11 (System.String)-8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ X10_v11 (System.String)-8]");
			if (0 == (nint)text6)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v15+12E]");
			val2 = (Enumerator<, >)(-1);
			text6 = text11 + 16;
			bool flag21 = (int)val2 != 1;
			text11 = text6;
			if (flag21)
			{
				continue;
			}
			goto IL_06ae;
		}
		val2 = (Enumerator<, >)text11;
		object obj47 = obj46 + text11;
		object obj48 = obj47 + 312;
		text6 = text11;
		goto IL_16c6;
		IL_127f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_128d;
		IL_0e22:
		List<System.__Canon> list = default;
		bool flag22 = list == null;
		obj9 = obj8;
		obj3 = list;
		if (!flag22)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+18]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
			object separator = 0;
			string text12 = string.Join((string)separator, (IEnumerable<string>)list);
			nint num6 = (nint)text;
			bool flag23 = text == null;
			num = unchecked((nint)null);
			obj9 = obj8;
			_Canon = list;
			obj3 = list;
			if (!flag23)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
				text6 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF908]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v42 (Il2CppClass<System.String>)+18]");
				object obj49 = -1;
				bool flag24 = (nint)obj49 < 0;
				bool flag25 = obj49 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v42 (Il2CppClass<System.String>)+18]");
				object obj50 = (nint)0 ^ (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v42 (Il2CppClass<System.String>)+18]");
				object obj51 = 0 ^ obj49;
				object obj52 = obj50 & obj51;
				bool flag26 = (nint)obj52 < 0;
				bool flag27 = flag24 == flag26;
				object obj53 = !flag25;
				object obj54 = flag27 & obj53;
				string text13;
				if ((int)(~obj54) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF918]");
					text13 = (string)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					text13 = (string)0;
				}
				string text14 = (string)obj17 + text12 + text13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
				object obj55 = 0;
				object obj56 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v47+E4]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1428 @ X8_v47+E4]");
				bool flag28 = (nint)0 == 0;
				object obj57 = !flag28;
				if (obj57 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(text14);
				nint num7 = (nint)text;
				bool flag29 = text == null;
				string text4 = null;
				num = (nint)text13;
				obj9 = obj8;
				_Canon = null;
				message2 = (Message<ProductList>)(object)text14;
				obj3 = list;
				if (!flag29)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v48 (Il2CppClass<System.String>)+18]");
					if ((nint)0 < (nint)2)
					{
						return;
					}
					Enumerator<, > enumerator = list.GetEnumerator();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4420]");
					message2 = (Message<ProductList>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
					object obj58 = 0;
					obj3 = list;
					string[] array = default;
					Enumerator<, > val4 = default;
					Enumerator<, > val5;
					while (val.MoveNext())
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						bool flag30 = array == null;
						val = val4;
						val5 = val4;
						text4 = null;
						num = (nint)text13;
						obj9 = null;
						ex = null;
						val3 = (Enumerator<, >)(ref val);
						val2 = (Enumerator<, >)(ref val);
						_Canon = (System.__Canon)1;
						text = (string)(object)array;
						obj3 = obj8;
						if (flag30)
						{
							goto IL_127f;
						}
						bool flag31 = array.Length == 0;
						val = val4;
						val5 = val4;
						text4 = null;
						num = (nint)text13;
						obj9 = null;
						ex = null;
						val3 = (Enumerator<, >)(ref val);
						val2 = (Enumerator<, >)(ref val);
						_Canon = (System.__Canon)1;
						text = (string)(object)array;
						obj3 = obj8;
						if (!flag31)
						{
							object obj59 = array + 32;
							obj59 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj60 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1524 @ X0_v78+E4]");
							bool flag32 = (nint)0 == 0;
							object obj61 = !flag32;
							if (obj61 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							AskPrices(array);
							obj3 = obj8;
							continue;
						}
						goto IL_128d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4418]");
					object obj62 = 0;
					_Canon = (System.__Canon)obj62;
					val.Dispose();
					val = val4;
					val5 = val4;
					text4 = null;
					num = (nint)text13;
					obj9 = null;
					ex = null;
					val3 = (Enumerator<, >)(ref val);
					val2 = (Enumerator<, >)(ref val);
					text = null;
					OutOfMemoryException ex3 = new OutOfMemoryException();
					if ((nint)_Canon == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						obj9 = 1;
					}
					else
					{
						if ((nint)_Canon != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CF74");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
						object obj63 = default;
						ex = (NullReferenceException)obj63;
					}
					obj34 = 0;
					goto IL_19db;
				}
			}
		}
		goto IL_124d;
		IL_05bd:
		throw new NullReferenceException();
		IL_128d:
		IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
		goto IL_129b;
		IL_1271:
		IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
		goto IL_127f;
		IL_0a0d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4458]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4460]");
		object obj65 = 0;
		_Canon = (System.__Canon)obj65;
		list._002Ector();
		nint num8 = (nint)text;
		bool flag33 = text == null;
		obj9 = obj8;
		obj3 = list;
		if (flag33)
		{
			goto IL_124d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X22_v17 (Il2CppClass<System.String>)+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0e22;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF5B8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4430]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X22_v17 (Il2CppClass<System.String>)+18]");
		object obj66 = 0 & 0xFFFFFFFFL;
		object obj67 = text + 32;
		object obj68 = obj17;
		nint num9 = num;
		string text15 = text6;
		object obj69 = 0;
		string text16 = text2;
		System.__Canon _Canon2 = (System.__Canon)obj65;
		Message<ProductList> message4 = message2;
		while (true)
		{
			bool flag34 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj69) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66);
			object obj70 = !flag34;
			obj17 = obj68;
			num = num9;
			text6 = text15;
			obj9 = obj8;
			val2 = (Enumerator<, >)text16;
			_Canon = _Canon2;
			message2 = message4;
			obj3 = list;
			if (obj70 != null)
			{
				break;
			}
			object obj71 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X27_v2+v192 @ X24_v17*8]");
			message2 = (Message<ProductList>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X0_v86+E4]");
			bool flag35 = (nint)0 == 0;
			object obj72 = !flag35;
			if (obj72 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj71 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X0_v86+A0]");
			object obj73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v65+18]");
			bool flag36 = (nint)0 == 0;
			obj17 = obj68;
			num = num9;
			text6 = text15;
			obj9 = obj8;
			text2 = text16;
			_Canon = _Canon2;
			obj3 = list;
			if (!flag36)
			{
				num = (nint)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v65+18]");
				bool flag37 = ((Dictionary<System.__Canon, System.__Canon>)0).ContainsKey((System.__Canon)(object)message2);
				bool flag38 = !flag37;
				object obj74 = !flag38;
				_Canon = (System.__Canon)(object)message2;
				if (obj74 != null)
				{
					goto IL_0db0;
				}
				bool flag39 = list == null;
				obj17 = obj68;
				text6 = text15;
				obj9 = obj8;
				text2 = text16;
				_Canon = (System.__Canon)(object)message2;
				obj3 = list;
				if (!flag39)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+10]");
					object obj75 = 0;
					text2 = (string)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+1C]");
					text6 = (string)((nint)0 + (nint)1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+10]");
					bool flag40 = (nint)0 == 0;
					obj17 = obj68;
					obj9 = obj8;
					_Canon = (System.__Canon)(object)message2;
					obj3 = list;
					if (!flag40)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+18]");
						text15 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v68+18]");
						obj68 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+18]");
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v68+18]");
						bool flag41 = num10 < 0;
						object obj76 = !flag41;
						if (obj76 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+10]");
							nint num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+18]");
							object obj77 = num11 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v59 (System.Collections.Generic.List`1<System.__Canon>)+18]");
							text16 = (string)((nint)0 + (nint)1);
							object obj78 = obj77 + 32;
							obj78 = message2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							_Canon = (System.__Canon)(object)message2;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X9_v22 (System.String)+20]");
							object obj79 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ X8_v69+A8]");
							object obj80 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1405 @ X8_v70+70]");
							num = 0;
							list.AddWithResize((System.__Canon)(object)message2);
							text16 = (string)obj15;
							_Canon = (System.__Canon)(object)message2;
						}
						goto IL_0db0;
					}
				}
			}
			goto IL_124d;
			IL_0db0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X22_v17 (Il2CppClass<System.String>)+18]");
			obj66 = 0;
			obj69++;
			object obj81 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X22_v17 (Il2CppClass<System.String>)+18]");
			bool flag42 = (nint)obj81 < 0;
			obj17 = obj68;
			text6 = text15;
			text2 = text16;
			num9 = num;
			_Canon2 = _Canon;
			message4 = message2;
			if (flag42)
			{
				continue;
			}
			goto IL_0e22;
		}
		goto IL_1271;
		IL_125b:
		NullReferenceException ex6 = new NullReferenceException();
		val2 = (Enumerator<, >)text2;
		goto IL_1271;
		IL_12a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
		goto IL_12b8;
		IL_124d:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_125b;
		IL_06ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9EC6C");
		num = unchecked((nint)null);
		goto IL_16c6;
		IL_12b8:
		throw new OutOfMemoryException();
		IL_16c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X0_v19+8]");
		_Canon = (System.__Canon)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1303 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_166a;
		IL_166a:
		bool flag43 = ex == null;
		object obj82 = !flag43;
		NullReferenceException ex8;
		if (obj82 == null)
		{
			bool flag44 = obj9 == null;
			object obj83 = !flag44;
			ex8 = ex;
			if (obj83 == null)
			{
				if (obj34 != null && (nint)obj34 != 7)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8F0]");
				object obj84 = 0;
				object obj10 = obj84;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @47DCB5C");
				object obj86 = default;
				object obj85 = obj86 & 1;
				bool flag45 = obj85 == null;
				obj8 = obj9;
				text2 = (string)val2;
				if (!flag45)
				{
					Request<ProductList> nextProductListPage = IAP.GetNextProductListPage((ProductList)(object)message2);
					bool flag46 = nextProductListPage == null;
					obj8 = obj9;
					text2 = (string)val2;
					obj10 = 0;
					if (!flag46)
					{
						object obj87 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ X0_v12+E4]");
						bool flag47 = (nint)0 == 0;
						object obj88 = !flag47;
						if (obj88 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj87 = obj4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ X0_v12+A0]");
						object obj89 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF8C8]");
						object obj90 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1457 @ X8_v10+20]");
						object obj91 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF900]");
						object obj92 = 0;
						Callback val6 = default;
						val6._002Ector(obj3, (IntPtr)obj92);
						Request<System.__Canon> request = ((Request<System.__Canon>)(object)nextProductListPage).OnComplete(val6);
						return;
					}
				}
				goto IL_0a0d;
			}
			goto IL_12a9;
		}
		goto IL_12b8;
		IL_129b:
		ex8 = new NullReferenceException();
		goto IL_12a9;
	}

	public static void Buy(string sku, Action<Result> done)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I
		//IL_0201: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I
		//IL_030b: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		//IL_034a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF600]");
		object obj = 0;
		object obj2 = default;
		object obj3;
		object obj4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			obj2._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
			obj3 = 0;
			obj4 = obj2 + 16;
			obj4 = sku;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj2 + 24;
			obj5 = done;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (Busy)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC8]");
			object obj8 = 0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v17+A0]");
			object obj13 = 0;
			if (obj13 == null)
			{
				object obj14 = obj5;
				if (obj5 == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v11+40]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v11+28]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v11+18]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v112 @ X3_v2 (should have been resolved before IL gen)");
				continue;
			}
			break;
		}
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v20+A0]");
		object obj20 = 0;
		obj20 = obj4;
		object obj21 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		float unscaledTime = Time.unscaledTime;
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v15+A0]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v2+10]");
		object obj24 = 0;
		_ = 3212836864L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v2+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X8_v16+18] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+10]");
		Request<Purchase> request = IAP.LaunchCheckoutFlow((string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF608]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF618]");
		object obj26 = 0;
		Callback val = default;
		val._002Ector(obj2, (IntPtr)obj26);
		Request<System.__Canon> request2 = ((Request<System.__Canon>)(object)request).OnComplete(val);
	}

	public static void RedeemOwned()
	{
		//IL_0010: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isEditor = UnityEngine.Application.isEditor;
		bool flag2 = !isEditor;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CEFC8]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v11+A0]");
		object obj10 = 0;
		if (obj10 == null)
		{
			return;
		}
		Request<PurchaseList> viewerPurchases = IAP.GetViewerPurchases();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF938]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v12+A0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X9_v4+8]");
		Callback val = (Callback)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X9_v4+8]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj17 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v22+A0]");
				obj14 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF920]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF930]");
			object obj19 = 0;
			Callback val2 = default;
			val2._002Ector(obj14, (IntPtr)obj19);
			object obj20 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v21+A0]");
			object obj21 = (nint)0 + (nint)8;
			obj21 = val2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			val = val2;
		}
		Request<System.__Canon> request = ((Request<System.__Canon>)(object)viewerPurchases).OnComplete(val);
	}

	private static bool Have(string sku)
	{
		//IL_0010: Expected Obj, but got I
		//IL_03ba: Expected Obj, but got I4
		//IL_0043: Expected I4, but got I8
		//IL_005d: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_016c: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I4
		//IL_01dd: Expected Obj, but got I4
		//IL_0236: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CF568]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = GillaAtm.PackOf(sku);
		int num2 = (int)(num & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			goto IL_006b;
		}
		Coins.Bundle bundle = CosmeticCatalog.BundleWithSku(sku);
		if (bundle != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B0]");
			object obj5 = 0;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v25+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!Coins.OwnsName(sku))
			{
				object obj8 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v29+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!Coins.OwnsAll(bundle))
				{
					goto IL_006b;
				}
				bool flag5 = string.IsNullOrEmpty(bundle.tag);
				bool flag6 = !flag5;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					object obj11 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v35+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return Coins.OwnsName(bundle.tag);
				}
			}
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC390]");
		object obj13 = 0;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v9+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = MonsterChoice.ForSku(sku);
		if (text != null)
		{
			object obj16 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return MonsterChoice.Given(text);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4700]");
		object obj18 = 0;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v13+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string item = ModMenuAccess.ItemOf(sku);
		return ModMenuAccess.Owns(item);
		IL_006b:
		return false;
	}

	static GillaPurchases()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC310]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C59F8]");
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+A0]");
		object obj4 = 0;
		_ = 3212836864L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		Dictionary<System.__Canon, System.__Canon> dictionary = default;
		dictionary._002Ector();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5+A0]");
		object obj6 = (nint)0 + (nint)24;
		obj6 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
