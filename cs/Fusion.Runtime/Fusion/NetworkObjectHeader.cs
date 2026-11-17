using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using PlayFab.ClientModels;
using Unity.Collections.LowLevel.Unsafe;

namespace Fusion;

[StructLayout((LayoutKind)2, Size = 80)]
public struct NetworkObjectHeader(NetworkId id, short wordCount, short behaviourCount, NetworkObjectTypeId type, NetworkId nestingRoot = default(NetworkId), NetworkObjectNestingKey nestingKey = default(NetworkObjectNestingKey), NetworkObjectHeaderFlags flags = default(NetworkObjectHeaderFlags)) : _0021_00210, Action<RestoreIOSPurchasesResult>
{
	public const int WORDS = default(int);

	public const int PLAYER_FLAGS_WORD = default(int);

	public const int STATE_AUTHORITY_WORD = default(int);

	[FieldOffset(0)]
	public NetworkId Id = id;

	[FieldOffset(4)]
	public readonly short WordCount = wordCount;

	[FieldOffset(6)]
	public readonly short BehaviourCount = behaviourCount;

	[FieldOffset(8)]
	public readonly NetworkObjectTypeId Type = type;

	[FieldOffset(16)]
	public readonly NetworkId NestingRoot = nestingRoot;

	[FieldOffset(20)]
	public readonly NetworkObjectNestingKey NestingKey = nestingKey;

	[FieldOffset(24)]
	public readonly NetworkObjectHeaderFlags Flags = flags;

	internal const int READ_ONLY_WORD_COUNT = default(int);

	[FieldOffset(28)]
	public PlayerRef InputAuthority = (PlayerRef)0;

	[FieldOffset(32)]
	public PlayerRef StateAuthority;

	[FieldOffset(36)]
	internal NetworkObjectHeaderPlayerDataFlags PlayerFlags = (NetworkObjectHeaderPlayerDataFlags)0;

	public const int PLUGIN_VERSION_WORD = default(int);

	[FieldOffset(40)]
	internal uint PluginVersion;

	[FieldOffset(44)]
	private NetworkObjectMeta.AreaOfInterestList._003C_padding_003Ee__FixedBuffer _padding;

	public const int SIZE = default(int);

	public const int WORD_COUNT = default(int);

	internal const int BYTE_OF_ID = default(int);

	internal const int BYTE_COUNT_OF_ID = default(int);

	internal const int BYTE_OF_WORD_COUNT = default(int);

	internal const int BYTE_COUNT_OF_WORD_COUNT = default(int);

	internal const int BYTE_OF_BEHAVIOUR_COUNT = default(int);

	internal const int BYTE_COUNT_OF_BEHAVIOUR_COUNT = default(int);

	internal const int BYTE_OF_TYPE = default(int);

	internal const int BYTE_COUNT_OF_TYPE = default(int);

	internal const int BYTE_OF_NESTING_ROOT = default(int);

	internal const int BYTE_COUNT_OF_NESTING_ROOT = default(int);

	internal const int BYTE_OF_NESTING_KEY = default(int);

	internal const int BYTE_COUNT_OF_NESTING_KEY = default(int);

	internal const int BYTE_OF_FLAGS = default(int);

	internal const int BYTE_COUNT_OF_FLAGS = default(int);

	internal const int BYTE_OF_INPUT_AUTHORITY = default(int);

	internal const int BYTE_COUNT_OF_INPUT_AUTHORITY = default(int);

	internal const int BYTE_OF_STATE_AUTHORITY = default(int);

	internal const int BYTE_COUNT_OF_STATE_AUTHORITY = default(int);

	internal const int BYTE_OF_PLAYER_FLAGS = default(int);

	internal const int BYTE_COUNT_OF_PLAYER_FLAGS = default(int);

	internal const int BYTE_OF_PLUGIN_VERSION = default(int);

	internal const int BYTE_COUNT_OF_PLUGIN_VERSION = default(int);

	internal const int BYTE_OF__PADDING = default(int);

	internal const int BYTE_COUNT_OF__PADDING = default(int);

	private const uint __STATIC_ASSERT_ENSURE_PERFECT_FIT = default(uint);

	public int ByteCount => WordCount << 2;

	public unsafe override string ToString()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I4
		//IL_02ff: Expected VT, but got Ref
		//IL_0308: Expected Ref, but got VT
		//IL_0324: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_0486: Expected Obj, but got I4
		//IL_04ae: Invalid comparison between VT and I4
		//IL_05ed: Expected VT, but got Ref
		//IL_06fb: Expected I4, but got Obj
		//IL_037a: Expected Obj, but got I
		//IL_07d7: Expected Obj, but got I4
		//IL_08e0: Expected Obj, but got I
		//IL_08eb: Expected VT, but got Ref
		//IL_0500: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I
		//IL_040b: Expected VT, but got Ref
		//IL_0414: Expected Ref, but got VT
		//IL_0a9e: Expected VT, but got Ref
		//IL_0937: Expected Obj, but got I4
		//IL_0569: Expected Obj, but got I4
		//IL_0823: Expected Obj, but got I
		//IL_0695: Expected Ref, but got VT
		//IL_0591: Expected VT, but got Ref
		//IL_059a: Expected Ref, but got VT
		//IL_044f: Expected Obj, but got I4
		//IL_0ae2: Expected Obj, but got I4
		//IL_0d16: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I
		//IL_0861: Expected Obj, but got I
		//IL_087b: Expected Obj, but got Ref
		//IL_05d5: Expected Obj, but got I4
		//IL_07b9: Expected Obj, but got I4
		//IL_06d5: Expected Obj, but got I4
		//IL_0b5f: Expected Obj, but got I
		//IL_0a1d: Expected Obj, but got I4
		//IL_0c82: Expected Obj, but got I
		//IL_0a43: Expected Ref, but got VT
		//IL_08c3: Expected Obj, but got I4
		//IL_0bc8: Expected Obj, but got I4
		//IL_0cca: Expected Obj, but got Ref
		//IL_0bee: Expected Ref, but got VT
		//IL_0a7e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C60C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object value3;
		object obj2;
		object value5;
		object value6;
		string text;
		if (stringBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF90]");
			object value = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8450]");
			object value2 = 0;
			StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
			StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
			if (stringBuilder3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5398]");
				value3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
				obj2 = 0;
				StringBuilder stringBuilder4 = stringBuilder3.Append((string)value3);
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string value4 = ((NetworkId)this).ToString();
				if (stringBuilder4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8F48]");
					value5 = 0;
					StringBuilder stringBuilder5 = stringBuilder4.Append(value4);
					StringBuilder stringBuilder6 = stringBuilder.Append((string)value5);
					if (stringBuilder6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8440]");
						value6 = 0;
						StringBuilder stringBuilder7 = stringBuilder6.Append((string)value6);
						if (stringBuilder7 != null)
						{
							StringBuilder stringBuilder8 = stringBuilder7.Append((string)value3);
							if (stringBuilder8 != null)
							{
								StringBuilder stringBuilder9 = stringBuilder8.Append(WordCount);
								StringBuilder stringBuilder10 = stringBuilder.Append((string)value5);
								if (stringBuilder10 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8418]");
									object value7 = 0;
									StringBuilder stringBuilder11 = stringBuilder10.Append((string)value7);
									if (stringBuilder11 != null)
									{
										StringBuilder stringBuilder12 = stringBuilder11.Append((string)value3);
										if (stringBuilder12 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
											object obj5 = 0;
											StringBuilder stringBuilder13 = stringBuilder12.Append(BehaviourCount);
											object obj6 = obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v26+E4]");
											bool flag2 = (nint)0 == 0;
											object obj7 = !flag2;
											if (obj7 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											NetworkObjectTypeId networkObjectTypeId = (NetworkObjectTypeId)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
											bool isValid = ((NetworkObjectTypeId*)networkObjectTypeId)->IsValid;
											bool flag3 = !isValid;
											object obj8 = 0;
											text = (string)BehaviourCount;
											if (flag3)
											{
												goto IL_045c;
											}
											StringBuilder stringBuilder14 = stringBuilder.Append((string)value5);
											if (stringBuilder14 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8448]");
												object value8 = 0;
												StringBuilder stringBuilder15 = stringBuilder14.Append((string)value8);
												if (stringBuilder15 != null)
												{
													StringBuilder stringBuilder16 = stringBuilder15.Append((string)value3);
													object obj9 = obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v47+E4]");
													bool flag4 = (nint)0 == 0;
													object obj10 = !flag4;
													if (obj10 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													NetworkObjectTypeId networkObjectTypeId2 = (NetworkObjectTypeId)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
													string text2 = ((NetworkObjectTypeId*)networkObjectTypeId2)->ToString();
													if (stringBuilder16 != null)
													{
														StringBuilder stringBuilder17 = stringBuilder16.Append(text2);
														obj8 = 0;
														text = text2;
														goto IL_045c;
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
		goto IL_0d37;
		IL_06e2:
		bool flag5 = WordCount == 0;
		short num = (short)(int)text;
		if (flag5)
		{
			goto IL_07be;
		}
		StringBuilder stringBuilder18 = stringBuilder.Append((string)value5);
		if (stringBuilder18 != null)
		{
			StringBuilder stringBuilder19 = stringBuilder18.Append((string)value6);
			if (stringBuilder19 != null)
			{
				StringBuilder stringBuilder20 = stringBuilder19.Append((string)value3);
				if (stringBuilder20 != null)
				{
					num = WordCount;
					StringBuilder stringBuilder21 = stringBuilder20.Append(WordCount);
					object obj8 = 0;
					goto IL_07be;
				}
			}
		}
		goto IL_0d37;
		IL_0d06:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFF98]");
		object value9 = 0;
		StringBuilder stringBuilder22 = stringBuilder.Append((string)value9);
		((SymmetricAlgorithm)(object)stringBuilder).BlockSize = 0;
		string result = default;
		return result;
		IL_0c25:
		if (PlayerFlags == 0)
		{
			goto IL_0d06;
		}
		StringBuilder stringBuilder23 = stringBuilder.Append((string)value5);
		object obj11 = default;
		if (stringBuilder23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8420]");
			object value10 = 0;
			StringBuilder stringBuilder24 = stringBuilder23.Append((string)value10);
			if (stringBuilder24 != null)
			{
				StringBuilder stringBuilder25 = stringBuilder24.Append((string)value3);
				string value11 = ((Enum)(&obj11)).ToString();
				if (stringBuilder25 != null)
				{
					StringBuilder stringBuilder26 = stringBuilder25.Append(value11);
					goto IL_0d06;
				}
			}
		}
		goto IL_0d37;
		IL_0b21:
		StringBuilder stringBuilder27 = stringBuilder.Append((string)value5);
		object obj13;
		PlayerRef playerRef;
		if (stringBuilder27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8460]");
			object value12 = 0;
			StringBuilder stringBuilder28 = stringBuilder27.Append((string)value12);
			if (stringBuilder28 != null)
			{
				StringBuilder stringBuilder29 = stringBuilder28.Append((string)value3);
				object obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v33+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string value13 = ((PlayerRef*)playerRef)->ToString();
				if (stringBuilder29 != null)
				{
					StringBuilder stringBuilder30 = stringBuilder29.Append(value13);
					goto IL_0c25;
				}
			}
		}
		goto IL_0d37;
		IL_08d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		obj13 = 0;
		PlayerRef playerRef2 = (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 28));
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v37+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = playerRef2.Raw == 0;
			object obj16 = !flag7;
			if (obj16 != null)
			{
				goto IL_0976;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (playerRef2.Raw != 0)
			{
				goto IL_0976;
			}
		}
		goto IL_0a8b;
		IL_05e2:
		NetworkObjectNestingKey networkObjectNestingKey = (NetworkObjectNestingKey)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 20));
		if (networkObjectNestingKey.Value < 1)
		{
			goto IL_06e2;
		}
		StringBuilder stringBuilder31 = stringBuilder.Append((string)value5);
		if (stringBuilder31 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8458]");
			object value14 = 0;
			StringBuilder stringBuilder32 = stringBuilder31.Append((string)value14);
			if (stringBuilder32 != null)
			{
				StringBuilder stringBuilder33 = stringBuilder32.Append((string)value3);
				string text3 = ((NetworkObjectNestingKey*)networkObjectNestingKey)->ToString();
				if (stringBuilder33 != null)
				{
					StringBuilder stringBuilder34 = stringBuilder33.Append(text3);
					object obj8 = 0;
					text = text3;
					goto IL_06e2;
				}
			}
		}
		goto IL_0d37;
		IL_0d37:
		return (string)(object)new NullReferenceException();
		IL_07be:
		bool flag8 = Flags == 0;
		string text4 = (string)num;
		if (flag8)
		{
			goto IL_08d0;
		}
		StringBuilder stringBuilder35 = stringBuilder.Append((string)value5);
		if (stringBuilder35 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8430]");
			object value15 = 0;
			StringBuilder stringBuilder36 = stringBuilder35.Append((string)value15);
			if (stringBuilder36 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8408]");
				object obj17 = 0;
				StringBuilder stringBuilder37 = stringBuilder36.Append((string)value3);
				string text5 = ((Enum)(&obj11)).ToString();
				if (stringBuilder37 != null)
				{
					StringBuilder stringBuilder38 = stringBuilder37.Append(text5);
					obj11 = obj17;
					object obj8 = 0;
					text4 = text5;
					goto IL_08d0;
				}
			}
		}
		goto IL_0d37;
		IL_045c:
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v31+E4]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (NestingRoot == (NetworkId)(object)0)
		{
			goto IL_05e2;
		}
		StringBuilder stringBuilder39 = stringBuilder.Append((string)value5);
		if (stringBuilder39 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8428]");
			object value16 = 0;
			StringBuilder stringBuilder40 = stringBuilder39.Append((string)value16);
			if (stringBuilder40 != null)
			{
				StringBuilder stringBuilder41 = stringBuilder40.Append((string)value3);
				object obj20 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v44+E4]");
				bool flag10 = (nint)0 == 0;
				object obj21 = !flag10;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				NetworkId networkId = (NetworkId)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
				string text6 = ((NetworkId*)networkId)->ToString();
				if (stringBuilder41 != null)
				{
					StringBuilder stringBuilder42 = stringBuilder41.Append(text6);
					object obj8 = 0;
					text = text6;
					goto IL_05e2;
				}
			}
		}
		goto IL_0d37;
		IL_0a8b:
		object obj22 = obj13;
		playerRef = (PlayerRef)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v39+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = playerRef.Raw == 0;
			object obj23 = !flag11;
			if (obj23 != null)
			{
				goto IL_0b21;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (playerRef.Raw != 0)
			{
				goto IL_0b21;
			}
		}
		goto IL_0c25;
		IL_0976:
		StringBuilder stringBuilder43 = stringBuilder.Append((string)value5);
		if (stringBuilder43 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D8438]");
			object value17 = 0;
			StringBuilder stringBuilder44 = stringBuilder43.Append((string)value17);
			if (stringBuilder44 != null)
			{
				StringBuilder stringBuilder45 = stringBuilder44.Append((string)value3);
				object obj24 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v36+E4]");
				bool flag12 = (nint)0 == 0;
				object obj25 = !flag12;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text7 = ((PlayerRef*)playerRef2)->ToString();
				if (stringBuilder45 != null)
				{
					StringBuilder stringBuilder46 = stringBuilder45.Append(text7);
					object obj8 = 0;
					text4 = text7;
					goto IL_0a8b;
				}
			}
		}
		goto IL_0d37;
	}

	public unsafe bool Equals(NetworkObjectHeader other)
	{
		//IL_0026: Expected VT, but got Ref
		//IL_0026: Expected VT, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
		object obj = default;
		object obj2 = default;
		bool result = (NetworkObjectHeader)(&obj) == (NetworkObjectHeader)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe override bool Equals(object obj)
	{
		//IL_0039: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_007b: Expected VT, but got Ref
		//IL_007b: Expected VT, but got Ref
		//IL_0087: Expected VT, but got Ref
		bool result;
		NetworkObjectHeader networkObjectHeader;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D73A0]");
			object obj2 = 0;
			if (obj == obj2)
			{
				object obj3 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
				object obj4 = default;
				object obj5 = default;
				result = (NetworkObjectHeader)(&obj4) == (NetworkObjectHeader)(&obj5);
				networkObjectHeader = (NetworkObjectHeader)(&obj5);
				goto IL_008c;
			}
		}
		networkObjectHeader = (NetworkObjectHeader)obj;
		result = false;
		goto IL_008c;
		IL_008c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ SYSREG+28]");
		if (num == 0)
		{
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0D0");
		bool result2 = default;
		return result2;
	}

	public unsafe override int GetHashCode()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I4
		//IL_0090: Expected VT, but got Ref
		//IL_0099: Expected Ref, but got VT
		//IL_00c7: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected I4, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected I4, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected I4, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5480]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D71F8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5198]");
		object obj5 = 0;
		int hashCode = ((NetworkId)this).GetHashCode();
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NetworkId networkId = (NetworkId)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		int hashCode2 = ((NetworkId*)networkId)->GetHashCode();
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = hashCode * 397;
		object obj11 = Type * 397;
		int num = obj10 ^ WordCount;
		object obj12 = num * 397;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Fusion.NetworkObjectHeader)+C]");
		object obj13 = 0 ^ obj11;
		int num2 = obj12 ^ BehaviourCount;
		object obj14 = num2 * 397;
		object obj15 = obj13 ^ obj14;
		object obj16 = obj15 * 397;
		int num3 = obj16 ^ hashCode2;
		object obj17 = num3 * 397;
		object obj18 = obj17 ^ NestingKey;
		object obj19 = obj18 * 397;
		object obj20 = obj19 ^ Flags;
		object obj21 = obj20 * 397;
		object obj22 = InputAuthority ^ obj21;
		object obj23 = obj22 * 397;
		object obj24 = obj23 ^ StateAuthority;
		int num4 = default;
		int hashCode3 = num4.GetHashCode();
		object obj25 = obj24 * 397;
		return obj25 ^ hashCode3;
	}

	public unsafe static bool operator ==(NetworkObjectHeader left, NetworkObjectHeader right)
	{
		//IL_0030: Invalid comparison between VT and I4
		//IL_0046: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_008f: Expected I8, but got I4
		//IL_008f: Expected I, but got VT
		//IL_008f: Expected I, but got VT
		//IL_000e: Invalid comparison between VT and I4
		bool flag = left == (NetworkObjectHeader)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40E0]");
		object obj = 0;
		object obj2 = !flag;
		object obj3 = ~obj2;
		bool flag2 = obj3 != null || right == (NetworkObjectHeader)(object)0;
		object obj4 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F6408");
		int num = UnsafeUtility.MemCmp((void*)(nint)left, (void*)(nint)right, 80L);
		return num == 0;
	}

	public unsafe static bool operator !=(NetworkObjectHeader left, NetworkObjectHeader right)
	{
		//IL_0030: Invalid comparison between VT and I4
		//IL_0046: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_008f: Expected I8, but got I4
		//IL_008f: Expected I, but got VT
		//IL_008f: Expected I, but got VT
		//IL_000e: Invalid comparison between VT and I4
		bool flag = left == (NetworkObjectHeader)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D40E0]");
		object obj = 0;
		object obj2 = !flag;
		object obj3 = ~obj2;
		bool flag2 = obj3 != null || right == (NetworkObjectHeader)(object)0;
		object obj4 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @34F6408");
		int num = UnsafeUtility.MemCmp((void*)(nint)left, (void*)(nint)right, 80L);
		bool flag3 = num == 0;
		return !flag3;
	}
}
