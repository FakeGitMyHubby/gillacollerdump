using System;
using Cpp2ILInjected;
using Fusion.Photon.Realtime;
using UnityEngine;

public static class GillaPhotonVersion
{
	private sealed class _003CStart_003Ed__5 : _0021_00210, _00210, _0021_00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CStart_003Ed__5(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_004f: Expected I4, but got I8
			//IL_0064: Expected Obj, but got I
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_0036: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					GillaPerformance.Apply();
				}
			}
			else
			{
				_003C_003E1__state = -1;
				GillaPerformance.Apply();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AC0]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				WaitForSeconds waitForSeconds = default;
				waitForSeconds._002Ector(2f);
				object obj2 = this + 24;
				obj2 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				_003C_003E1__state = 1;
			}
			return _003C_003E1__state == 0;
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

	private static string Current__BackingField;

	public static string Current
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I4
			//IL_0074: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AD0]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AD0]");
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

	private unsafe static void Apply()
	{
		//IL_0010: Expected Obj, but got I
		//IL_06e3: Expected Obj, but got I
		//IL_0705: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		//IL_072b: Expected Obj, but got I
		//IL_074d: Expected Obj, but got I4
		//IL_081d: Expected Obj, but got I
		//IL_0861: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		//IL_05fa: Expected Obj, but got I
		//IL_0624: Expected Obj, but got I4
		//IL_0651: Expected Obj, but got I
		//IL_0495: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I
		//IL_01a5: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected I4, but got Unknown
		//IL_01e1: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I
		//IL_044c: Expected Obj, but got I4
		//IL_0479: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I4
		//IL_0366: Expected Obj, but got I4
		//IL_0785: Expected Obj, but got I4
		//IL_087f: Expected Obj, but got I
		//IL_07bd: Expected Obj, but got I4
		//IL_08c3: Expected Obj, but got I4
		//IL_03bd: Expected Obj, but got I
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_07f5: Expected Obj, but got I4
		//IL_08e9: Expected Obj, but got I
		//IL_08f9: Expected Obj, but got I
		//IL_0909: Expected Obj, but got I
		//IL_092e: Expected Obj, but got I
		//IL_0958: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AD0]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = 109891584;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C49D8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+A0]");
		object obj9 = 0;
		obj9 = obj3;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (Application.isEditor)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AF8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AE0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @376B620");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object obj18 = default;
		bool flag5 = obj18 != null;
		bool flag6 = !flag5;
		object obj19 = 0;
		UnityEngine.Object obj20 = null;
		if (!flag6)
		{
			if ((object)obj18 == null)
			{
				NullReferenceException ex = new NullReferenceException();
				object obj21 = 0;
				UnityEngine.Object obj22 = null;
				NullReferenceException ex2 = ex;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
				return;
			}
			string text = ((TextAsset)obj18).text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AD8]");
			object obj23 = 0;
			obj20 = (UnityEngine.Object)obj23;
			System.__Canon _Canon = JsonUtility.FromJson<System.__Canon>(text);
			bool flag7 = _Canon == null;
			obj19 = 0;
			if (!flag7)
			{
				int num = _Canon + 16;
				bool flag8 = ((int*)num)->m_value <= 0;
				obj19 = 0;
				if (!flag8)
				{
					PhotonAppSettings global = PhotonAppSettings.Global;
					object obj24 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+E4]");
					bool flag9 = (nint)0 == 0;
					object obj25 = !flag9;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag10 = (UnityEngine.Object)(object)global == null;
					bool flag11 = !flag10;
					object obj26 = !flag11;
					if (obj26 == null)
					{
						bool flag12 = global == null;
						object obj27 = 0;
						UnityEngine.Object obj28 = null;
						PhotonAppSettings photonAppSettings = global;
						if (!flag12)
						{
							if (global.AppSettings == null)
							{
								goto IL_0412;
							}
							string text2 = ((int*)num)->ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AE8]");
							object obj29 = 0;
							string text3 = (string)obj29 + text2;
							object obj30 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v41+E4]");
							bool flag13 = (nint)0 == 0;
							object obj31 = !flag13;
							if (obj31 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X22_v1+B05]");
							bool flag14 = (nint)0 == 0;
							object obj32 = !flag14;
							if (obj32 == null)
							{
								_ = 1;
							}
							object obj33 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v74+E4]");
							bool flag15 = (nint)0 == 0;
							object obj34 = !flag15;
							if (obj34 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj33 = obj;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v74+A0]");
							object obj35 = 0;
							obj35 = text3;
							object obj36 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							photonAppSettings = (PhotonAppSettings)(object)global.AppSettings;
							object obj37 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v79+E4]");
							bool flag16 = (nint)0 == 0;
							object obj38 = !flag16;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								obj37 = obj;
							}
							bool flag17 = photonAppSettings == null;
							obj27 = 0;
							obj28 = (UnityEngine.Object)(object)text3;
							if (!flag17)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v79+A0]");
								object obj39 = 0;
								object obj40 = photonAppSettings + 64;
								obj40 = obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj41 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v84+E4]");
								bool flag18 = (nint)0 == 0;
								object obj42 = !flag18;
								if (obj42 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj41 = obj;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B10]");
								object obj43 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v84+A0]");
								object obj44 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B08]");
								object obj45 = 0;
								string message = (string)obj43 + (string)obj44 + (string)obj45;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
								object obj46 = 0;
								object obj47 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v58+E4]");
								bool flag19 = (nint)0 == 0;
								object obj48 = !flag19;
								if (obj48 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Debug.Log(message);
								return;
							}
						}
						throw new NullReferenceException();
					}
					goto IL_0412;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj49 = 0;
		object obj50 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v22+E4]");
		bool flag20 = (nint)0 == 0;
		object obj51 = !flag20;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AF0]");
		object message2 = 0;
		goto IL_0803;
		IL_0412:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
		object obj52 = 0;
		object obj53 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v64+E4]");
		bool flag21 = (nint)0 == 0;
		object obj54 = !flag21;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5B00]");
		message2 = 0;
		goto IL_0803;
		IL_0803:
		Debug.LogWarning(message2);
	}

	static GillaPhotonVersion()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5AD0]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+A0]");
		object obj4 = 0;
		obj4 = obj;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}
}
