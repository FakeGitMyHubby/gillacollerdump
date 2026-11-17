using System;
using System.Collections;
using System.Threading;
using Cpp2ILInjected;
using Fusion;
using Photon.Realtime;
using Photon.Voice;
using Photon.Voice.Unity;
using UnityEngine;

public class GillaVoiceGate : MonoBehaviour
{
	private sealed class _003CFetching_003Ed__16 : _00210, _0021_00210, _00210
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GillaVoiceClient _003C_003E4__this;

		private GillaVoiceClient._003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CFetching_003Ed__16(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			//IL_018c: Expected Obj, but got I
			//IL_019b: Expected I4, but got I8
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected Obj, but got Unknown
			//IL_052e: Expected I4, but got Obj
			//IL_0036: Expected I4, but got I8
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected Obj, but got Unknown
			//IL_0229: Expected Obj, but got I4
			//IL_0243: Expected Obj, but got I
			//IL_0065: Expected Obj, but got I
			//IL_0095: Expected Obj, but got I4
			//IL_0262: Expected Obj, but got I
			//IL_0273: Expected I, but got Obj
			//IL_0283: Expected Obj, but got I
			//IL_02ad: Expected Obj, but got I4
			//IL_00dc: Expected Obj, but got I4
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected Obj, but got Unknown
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Expected Obj, but got Unknown
			//IL_037b: Expected Obj, but got I4
			//IL_03aa: Expected Obj, but got I
			//IL_0401: Expected Obj, but got I
			//IL_0432: Expected Obj, but got I
			//IL_0467: Expected Obj, but got I
			UnityEngine.Object obj = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0557;
				}
				_003C_003E1__state = -1;
				if ((object)_003C_003E4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
					object obj2 = 0;
					_ = 0;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v22+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag2 = _003C_003E4__this == null;
					bool flag3 = !flag2;
					object obj5 = !flag3;
					if (obj5 != null)
					{
						goto IL_0557;
					}
					GillaVoiceClient._003C_003Ec__DisplayClass16_0 obj6 = _003C_003E8__1;
					if (_003C_003E8__1 != null)
					{
						if (string.IsNullOrEmpty(obj6.got))
						{
							float unscaledTime = Time.unscaledTime;
							float num = unscaledTime;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v2 (UnityEngine.Object)+10C]");
							float num2 = num + 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
							_ = 1114636288;
							goto IL_0557;
						}
						GillaVoiceClient._003C_003Ec__DisplayClass16_0 obj7 = _003C_003E8__1;
						if (_003C_003E8__1 != null)
						{
							object obj8 = _003C_003E4__this + 256;
							_ = obj7.got;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj9 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v30+E4]");
							bool flag4 = (nint)0 == 0;
							object obj10 = !flag4;
							if (obj10 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v2 (UnityEngine.Object)+118]");
							if (!((UnityEngine.Object)0 != null))
							{
								goto IL_0557;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v2 (UnityEngine.Object)+118]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v2 (UnityEngine.Object)+118]");
								if (!((NetworkRunner)0).IsRunning)
								{
									goto IL_0557;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v2 (UnityEngine.Object)+118]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X19_v2 (UnityEngine.Object)+118]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v21+2F8]");
									object obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v21+2F8]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v22+30]");
										if ((nint)0 != 0)
										{
											if (_003C_003E4__this.ClientState != 0)
											{
												ClientState clientState = _003C_003E4__this.ClientState;
												if (clientState != (ClientState)14)
												{
													goto IL_0557;
												}
											}
											bool flag5 = _003C_003E4__this.ConnectAndJoinRoom();
										}
										goto IL_0557;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA280]");
				object obj13 = 0;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
				object obj14 = default;
				obj14._002Ector();
				object obj15 = this + 40;
				obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				if ((object)_003C_003E4__this != null)
				{
					_ = 1;
					if (obj15 != null)
					{
						object obj16 = obj15 + 16;
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA268]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA278]");
						object obj18 = 0;
						Action<bool, System.__Canon> action = default;
						action._002Ector(obj15, (IntPtr)obj18);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA270]");
						object obj19 = 0;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v15+E4]");
						bool flag6 = (nint)0 == 0;
						object obj21 = !flag6;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						IEnumerator enumerator = ShiftAuth.RefreshPhotonTicket((Action<bool, string>)action);
						object obj22 = this + 24;
						obj22 = enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 1;
						goto IL_0557;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0557:
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

	private static int dropped;

	private bool inVoice;

	public static int Dropped
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0032: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA290]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v3+A0]");
			object obj3 = 0;
			return (int)obj3;
		}
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA298]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		bool flag = (byte)(~(inVoice ? 1u : 0u)) != 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object obj6 = default;
			if (obj6 != null && ((Recorder)obj6).IsCurrentlyTransmitting)
			{
				bool flag3 = ((Recorder)obj6).RestartRecording();
			}
		}
	}

	private void PhotonVoiceCreated(PhotonVoiceCreatedParams p)
	{
		//IL_01dc: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_02be: Expected I, but got Obj
		//IL_02ce: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I
		//IL_041e: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_04b2: Expected Obj, but got I
		PhotonVoiceCreatedParams photonVoiceCreatedParams = default;
		IndexOutOfRangeException ex = default;
		if (photonVoiceCreatedParams != null)
		{
			PhotonVoiceCreatedParams photonVoiceCreatedParams2 = default;
			LocalVoiceFramed<float> localVoiceFramed = (LocalVoiceFramed<float>)photonVoiceCreatedParams2.Voice__BackingField;
			string text;
			string text2;
			if (photonVoiceCreatedParams2.Voice__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2E0]");
				object obj = 0;
				object obj2 = obj;
				nint num = (nint)localVoiceFramed;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v12 (Il2CppClass<Photon.Voice.LocalVoiceFramed`1<System.Single>>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v5+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v12 (Il2CppClass<Photon.Voice.LocalVoiceFramed`1<System.Single>>)+B0]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v5+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X11_v9-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2C0]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2B8]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2A0]");
						object obj8 = 0;
						photonVoiceCreatedParams = (PhotonVoiceCreatedParams)obj8;
						GillaWarmUp.Drop<float> drop = default;
						drop._002Ector();
						IProcessor<float>[] array = default;
						if (array == null)
						{
							goto IL_04cd;
						}
						bool flag2 = drop == null;
						photonVoiceCreatedParams2 = (PhotonVoiceCreatedParams)obj8;
						if (!flag2)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v45 (Il2CppClass<Photon.Voice.IProcessor`1<System.Single>[]>)+40]");
							photonVoiceCreatedParams2 = (PhotonVoiceCreatedParams)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag3 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v45 (Il2CppClass<Photon.Voice.IProcessor`1<System.Single>[]>)+40]");
							photonVoiceCreatedParams = (PhotonVoiceCreatedParams)0;
							if (flag3)
							{
								goto IL_04e9;
							}
						}
						bool flag4 = array.Length == 0;
						photonVoiceCreatedParams = photonVoiceCreatedParams2;
						if (!flag4)
						{
							object obj9 = array + 32;
							obj9 = drop;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							((LocalVoiceFramed<float>)photonVoiceCreatedParams2.Voice__BackingField).AddPostProcessor(array);
							goto IL_04c1;
						}
						goto IL_04db;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2E8]");
				object obj10 = 0;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v12 (Il2CppClass<Photon.Voice.LocalVoiceFramed`1<System.Single>>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v9+130]");
				bool flag5 = num5 < 0;
				object obj12 = !flag5;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v12 (Il2CppClass<Photon.Voice.LocalVoiceFramed`1<System.Single>>)+B0]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v9+130]");
					object obj14 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v20-8]");
					if (0 == (nint)obj11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2C8]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2B0]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2A8]");
						object obj17 = 0;
						photonVoiceCreatedParams = (PhotonVoiceCreatedParams)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A08F54");
						object obj18 = default;
						if (obj18 == null)
						{
							goto IL_04cd;
						}
						object obj19 = default;
						bool flag6 = obj19 == null;
						PhotonVoiceCreatedParams photonVoiceCreatedParams3 = (PhotonVoiceCreatedParams)obj17;
						if (!flag6)
						{
							object obj20 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v33+40]");
							photonVoiceCreatedParams3 = (PhotonVoiceCreatedParams)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag7 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v33+40]");
							photonVoiceCreatedParams = (PhotonVoiceCreatedParams)0;
							if (flag7)
							{
								goto IL_04e9;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v21+18]");
						bool flag8 = (nint)0 == 0;
						photonVoiceCreatedParams = photonVoiceCreatedParams3;
						if (!flag8)
						{
							object obj21 = obj18 + 32;
							obj21 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2D8]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DFE080");
							goto IL_04c1;
						}
						goto IL_04db;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F0]");
				object obj23 = 0;
				text = (string)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
				object obj24 = default;
				if (obj24 == null)
				{
					goto IL_04cd;
				}
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v227 @ X8_v18+1B8] (should have been resolved before IL gen)");
				string text3 = default;
				text2 = text3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA2F0]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4698]");
				object obj27 = 0;
				text = (string)obj26;
				text2 = (string)obj27;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
			object obj28 = 0;
			string message = text + text2;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v7+E4]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogWarning(message);
			return;
		}
		goto IL_04cd;
		IL_04c1:
		inVoice = true;
		return;
		IL_04cd:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_04db;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		throw new ArgumentNullException();
		IL_04db:
		ex = new IndexOutOfRangeException();
		goto IL_04e9;
	}

	private void PhotonVoiceRemoved()
	{
		inVoice = false;
	}

	public unsafe static T[] Through<T>(T[] frame)
	{
		//IL_0010: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C58F8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool silenced = GillaModeration.Silenced;
		bool flag2 = !silenced;
		T[] result = frame;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CA290]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7+A0]");
			int num = Interlocked.Increment(ref *(int*)null);
			result = null;
		}
		return result;
	}
}
