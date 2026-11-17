using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.XR;

public class RobotSaw : MonoBehaviour
{
	private sealed class _003CPrepare_003Ed__87 : _0021_00211, _0021_00210, _0021_00211
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonsterWounds _003C_003E4__this;

		public MonsterGore baked;

		private MonsterWounds._003C_003Ec__DisplayClass87_0 _003C_003E8__1;

		private Mesh _003Cimported_003E5__2;

		private Mesh _003Cm_003E5__3;

		private Vector3[] _003Cfaces_003E5__4;

		private BoneWeight[] _003Cweights_003E5__5;

		private Material[] _003Cmats_003E5__6;

		private Task _003Csums_003E5__7;

		private int _003Cs_003E5__8;

		private GillaHands.Piece[] _003C_003E7__wrap8;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent => _003C_003E2__current;

		private object System_002ECollections_002EIEnumerator_002ECurrent => _003C_003E2__current;

		public _003CPrepare_003Ed__87(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_2f55: Expected Obj, but got I
			//IL_0245: Expected I4, but got I8
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected Obj, but got Unknown
			//IL_02d6: Expected Obj, but got I4
			//IL_09d4: Expected I4, but got I8
			//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b7: Expected I4, but got I8
			//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected Obj, but got I
			//IL_0058: Expected Obj, but got I
			//IL_031b: Expected Obj, but got I4
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1255: Unknown result type (might be due to invalid IL or missing references)
			//IL_1259: Unknown result type (might be due to invalid IL or missing references)
			//IL_1264: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e6: Expected I4, but got I8
			//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0806: Unknown result type (might be due to invalid IL or missing references)
			//IL_080f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a29: Expected Obj, but got Unknown
			//IL_2f81: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f8f: Expected I4, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_034f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Expected I, but got Obj
			//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4b: Expected Obj, but got Unknown
			//IL_0a54: Expected Obj, but got I4
			//IL_0a67: Expected Obj, but got I4
			//IL_011d: Expected I4, but got I8
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected I4, but got I8
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0838: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0847: Unknown result type (might be due to invalid IL or missing references)
			//IL_0850: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_13bb: Expected Obj, but got Unknown
			//IL_13c4: Expected Obj, but got I4
			//IL_13d7: Expected Obj, but got I4
			//IL_2fad: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fb2: Expected Obj, but got Unknown
			//IL_2fba: Expected I4, but got Obj
			//IL_2fc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fcd: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected I4, but got I8
			//IL_03ae: Expected Obj, but got I4
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected Obj, but got Unknown
			//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_12cb: Expected I, but got Obj
			//IL_0873: Expected Obj, but got I
			//IL_087d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0882: Expected Obj, but got Unknown
			//IL_03dd: Expected Obj, but got I
			//IL_03fb: Expected Obj, but got I4
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			//IL_019d: Expected Obj, but got I4
			//IL_01b0: Expected Obj, but got I4
			//IL_16c4: Expected Obj, but got I4
			//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d4: Expected I, but got Obj
			//IL_3005: Unknown result type (might be due to invalid IL or missing references)
			//IL_3009: Unknown result type (might be due to invalid IL or missing references)
			//IL_3014: Unknown result type (might be due to invalid IL or missing references)
			//IL_301d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a70: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a75: Expected Obj, but got Unknown
			//IL_1a7e: Expected Obj, but got I4
			//IL_0421: Expected Obj, but got I
			//IL_0443: Expected Obj, but got I4
			//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_13f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_13fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1405: Expected I, but got Obj
			//IL_1a93: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a98: Expected Obj, but got Unknown
			//IL_1aa1: Expected Obj, but got I4
			//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ab6: Expected Obj, but got Unknown
			//IL_1abf: Expected Obj, but got I4
			//IL_16eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_16fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f3: Expected Obj, but got I
			//IL_0907: Expected Obj, but got I
			//IL_0a98: Expected I4, but got Obj
			//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Expected Obj, but got I4
			//IL_1316: Unknown result type (might be due to invalid IL or missing references)
			//IL_131a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1325: Unknown result type (might be due to invalid IL or missing references)
			//IL_132e: Expected I, but got Obj
			//IL_1ad4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ad9: Expected Obj, but got Unknown
			//IL_1ae2: Expected Obj, but got I4
			//IL_1af2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1af7: Expected Obj, but got Unknown
			//IL_1b00: Expected Obj, but got I4
			//IL_092d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_093c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0945: Unknown result type (might be due to invalid IL or missing references)
			//IL_143d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1441: Unknown result type (might be due to invalid IL or missing references)
			//IL_144c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1455: Expected I, but got Obj
			//IL_1b15: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b1a: Expected Obj, but got Unknown
			//IL_1b23: Expected Obj, but got I4
			//IL_1b5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b60: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b68: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b84: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bd0: Expected I, but got Obj
			//IL_1714: Unknown result type (might be due to invalid IL or missing references)
			//IL_1719: Expected Obj, but got Unknown
			//IL_1739: Expected Obj, but got I
			//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Expected I, but got Obj
			//IL_135b: Expected Obj, but got I
			//IL_1385: Expected Obj, but got I4
			//IL_1768: Unknown result type (might be due to invalid IL or missing references)
			//IL_176c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1777: Unknown result type (might be due to invalid IL or missing references)
			//IL_1780: Expected I, but got Obj
			//IL_0975: Expected Obj, but got I
			//IL_097d: Expected Obj, but got I
			//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fee: Expected Obj, but got Unknown
			//IL_0ff7: Expected Obj, but got I4
			//IL_1012: Unknown result type (might be due to invalid IL or missing references)
			//IL_1016: Unknown result type (might be due to invalid IL or missing references)
			//IL_1021: Unknown result type (might be due to invalid IL or missing references)
			//IL_102a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1033: Expected I, but got Obj
			//IL_1480: Expected Obj, but got I
			//IL_148d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1491: Unknown result type (might be due to invalid IL or missing references)
			//IL_1495: Unknown result type (might be due to invalid IL or missing references)
			//IL_149a: Expected Obj, but got Unknown
			//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_14d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1507: Expected Obj, but got I4
			//IL_1bfb: Expected Obj, but got I
			//IL_1c0b: Expected Obj, but got I
			//IL_1c45: Expected Obj, but got I4
			//IL_0b17: Expected I4, but got Obj
			//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f2: Expected Obj, but got I
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0501: Expected Obj, but got Unknown
			//IL_309f: Expected VT, but got Ref
			//IL_30af: Unknown result type (might be due to invalid IL or missing references)
			//IL_30b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_30cc: Expected VT, but got Ref
			//IL_30cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_30d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_30db: Unknown result type (might be due to invalid IL or missing references)
			//IL_30f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_30fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_3103: Unknown result type (might be due to invalid IL or missing references)
			//IL_312b: Expected I, but got Obj
			//IL_1c81: Expected Obj, but got I
			//IL_1c8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c93: Expected Obj, but got Unknown
			//IL_17c0: Expected Obj, but got I4
			//IL_104c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1051: Expected Obj, but got Unknown
			//IL_105a: Expected Obj, but got I4
			//IL_1073: Unknown result type (might be due to invalid IL or missing references)
			//IL_1077: Unknown result type (might be due to invalid IL or missing references)
			//IL_1082: Unknown result type (might be due to invalid IL or missing references)
			//IL_108b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1094: Expected I, but got Obj
			//IL_0528: Expected Obj, but got I
			//IL_0552: Expected Obj, but got I4
			//IL_1cba: Expected Obj, but got I
			//IL_1ce1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cf0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d01: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d19: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d33: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d37: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d53: Expected I, but got Obj
			//IL_17ef: Expected Obj, but got I
			//IL_0b83: Expected Obj, but got I4
			//IL_0596: Expected Obj, but got I4
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1534: Expected Obj, but got I
			//IL_154c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1550: Unknown result type (might be due to invalid IL or missing references)
			//IL_1569: Expected VT, but got Ref
			//IL_1569: Unknown result type (might be due to invalid IL or missing references)
			//IL_156d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1578: Unknown result type (might be due to invalid IL or missing references)
			//IL_1593: Unknown result type (might be due to invalid IL or missing references)
			//IL_1597: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c8: Expected I, but got Obj
			//IL_1a33: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a38: Expected Obj, but got Unknown
			//IL_1a41: Expected Obj, but got I4
			//IL_1a54: Expected Obj, but got I4
			//IL_10b2: Expected Obj, but got I
			//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ea: Expected I, but got Obj
			//IL_1d98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1db8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dee: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e0a: Expected I, but got Obj
			//IL_1830: Unknown result type (might be due to invalid IL or missing references)
			//IL_1834: Unknown result type (might be due to invalid IL or missing references)
			//IL_183f: Unknown result type (might be due to invalid IL or missing references)
			//IL_184d: Expected I, but got Obj
			//IL_303e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3042: Unknown result type (might be due to invalid IL or missing references)
			//IL_304d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0622: Expected Obj, but got I
			//IL_15f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_15fb: Expected Obj, but got Unknown
			//IL_160b: Expected Obj, but got I
			//IL_161c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1620: Unknown result type (might be due to invalid IL or missing references)
			//IL_1639: Expected VT, but got Ref
			//IL_1650: Unknown result type (might be due to invalid IL or missing references)
			//IL_1654: Unknown result type (might be due to invalid IL or missing references)
			//IL_165d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1113: Unknown result type (might be due to invalid IL or missing references)
			//IL_1117: Unknown result type (might be due to invalid IL or missing references)
			//IL_1122: Unknown result type (might be due to invalid IL or missing references)
			//IL_112b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1134: Expected I, but got Obj
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0645: Expected Obj, but got Unknown
			//IL_066e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0672: Unknown result type (might be due to invalid IL or missing references)
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0686: Unknown result type (might be due to invalid IL or missing references)
			//IL_0697: Expected I, but got Obj
			//IL_1e48: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e58: Expected I4, but got Obj
			//IL_1e70: Expected I, but got Obj
			//IL_1873: Expected Obj, but got I
			//IL_189d: Expected Obj, but got I4
			//IL_0deb: Expected Obj, but got I4
			//IL_0df8: Expected I, but got Obj
			//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0beb: Expected Obj, but got Unknown
			//IL_0c0b: Expected Obj, but got I
			//IL_0c2d: Expected Obj, but got I4
			//IL_247e: Expected Obj, but got I
			//IL_24a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_24a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_24b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_24c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_24c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_24dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_24e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_24f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_24fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2507: Expected Obj, but got I4
			//IL_18c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_18c8: Expected Ref, but got Unknown
			//IL_18d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d6: Expected Ref, but got Unknown
			//IL_18df: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e4: Expected Ref, but got Unknown
			//IL_18ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f2: Expected Ref, but got Unknown
			//IL_1913: Expected Obj, but got I
			//IL_1933: Expected Obj, but got Ref
			//IL_115e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1189: Expected Obj, but got I
			//IL_119c: Expected I, but got Obj
			//IL_0c71: Expected I, but got Obj
			//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c8: Expected Obj, but got Unknown
			//IL_06d8: Expected Obj, but got I
			//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0700: Unknown result type (might be due to invalid IL or missing references)
			//IL_0709: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ea5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ea9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ec5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ec9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1edd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ee1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ef7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1efb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f0f: Expected I, but got Obj
			//IL_11b1: Expected Obj, but got I
			//IL_11db: Expected Obj, but got I4
			//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e25: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4a: Expected I, but got Obj
			//IL_1952: Unknown result type (might be due to invalid IL or missing references)
			//IL_1957: Expected Obj, but got Unknown
			//IL_1967: Expected Obj, but got I
			//IL_1981: Expected Obj, but got I
			//IL_120b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1210: Expected Obj, but got Unknown
			//IL_1237: Expected I, but got Obj
			//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc0: Expected I, but got Obj
			//IL_0730: Expected Obj, but got I
			//IL_074c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0750: Unknown result type (might be due to invalid IL or missing references)
			//IL_075b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0764: Unknown result type (might be due to invalid IL or missing references)
			//IL_0772: Expected I, but got Obj
			//IL_28d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_28db: Unknown result type (might be due to invalid IL or missing references)
			//IL_28e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_28f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_28fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_290f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2913: Unknown result type (might be due to invalid IL or missing references)
			//IL_2929: Unknown result type (might be due to invalid IL or missing references)
			//IL_292d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2939: Expected Obj, but got I4
			//IL_1f2d: Expected Obj, but got I
			//IL_1f54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f58: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f63: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f74: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f78: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f90: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fa6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1faa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fbe: Expected I, but got Obj
			//IL_19a0: Expected Obj, but got I
			//IL_19a8: Expected I, but got Obj
			//IL_19b9: Expected I, but got Obj
			//IL_19c9: Expected Obj, but got I
			//IL_19f3: Expected Obj, but got I4
			//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e92: Expected I, but got Obj
			//IL_2590: Expected Obj, but got I
			//IL_25a3: Expected Obj, but got I4
			//IL_25a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_25a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_25ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_25af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cff: Expected Obj, but got I4
			//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d25: Expected I, but got Obj
			//IL_0789: Unknown result type (might be due to invalid IL or missing references)
			//IL_078e: Expected Obj, but got Unknown
			//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ab: Expected Obj, but got Unknown
			//IL_07b4: Expected Obj, but got I4
			//IL_2961: Expected Obj, but got I
			//IL_295c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2961: Unknown result type (might be due to invalid IL or missing references)
			//IL_2966: Unknown result type (might be due to invalid IL or missing references)
			//IL_296a: Unknown result type (might be due to invalid IL or missing references)
			//IL_296e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2972: Unknown result type (might be due to invalid IL or missing references)
			//IL_332d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3331: Unknown result type (might be due to invalid IL or missing references)
			//IL_333c: Unknown result type (might be due to invalid IL or missing references)
			//IL_335d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3361: Unknown result type (might be due to invalid IL or missing references)
			//IL_338f: Expected Obj, but got I4
			//IL_0ed6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0b: Expected Obj, but got I4
			//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_3162: Unknown result type (might be due to invalid IL or missing references)
			//IL_3166: Unknown result type (might be due to invalid IL or missing references)
			//IL_3171: Unknown result type (might be due to invalid IL or missing references)
			//IL_3182: Unknown result type (might be due to invalid IL or missing references)
			//IL_3186: Unknown result type (might be due to invalid IL or missing references)
			//IL_319a: Unknown result type (might be due to invalid IL or missing references)
			//IL_319e: Unknown result type (might be due to invalid IL or missing references)
			//IL_31b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_31b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_31cc: Expected I, but got Obj
			//IL_31d5: Expected Obj, but got I4
			//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d44: Expected Obj, but got Unknown
			//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d81: Expected I, but got Obj
			//IL_3471: Expected Obj, but got I
			//IL_3479: Expected I, but got Obj
			//IL_3497: Unknown result type (might be due to invalid IL or missing references)
			//IL_349b: Unknown result type (might be due to invalid IL or missing references)
			//IL_349f: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ac: Expected Obj, but got I4
			//IL_34b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_34bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_34dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_34f3: Expected Obj, but got I4
			//IL_25c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_25cd: Expected Obj, but got Unknown
			//IL_25dd: Expected Obj, but got I
			//IL_2604: Unknown result type (might be due to invalid IL or missing references)
			//IL_2608: Unknown result type (might be due to invalid IL or missing references)
			//IL_2613: Unknown result type (might be due to invalid IL or missing references)
			//IL_262c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2630: Unknown result type (might be due to invalid IL or missing references)
			//IL_265e: Expected Obj, but got I4
			//IL_0f36: Expected Obj, but got I4
			//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f6b: Expected Obj, but got I4
			//IL_2984: Unknown result type (might be due to invalid IL or missing references)
			//IL_2989: Expected VT, but got Unknown
			//IL_29aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_29ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_29b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_29b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ff1: Expected Obj, but got I
			//IL_1ff9: Expected I, but got Obj
			//IL_2009: Expected Obj, but got I
			//IL_2015: Unknown result type (might be due to invalid IL or missing references)
			//IL_2029: Expected F4, but got I
			//IL_2035: Unknown result type (might be due to invalid IL or missing references)
			//IL_2053: Expected VT, but got I4
			//IL_2053: Expected Obj, but got I
			//IL_2067: Expected Obj, but got I
			//IL_208e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2092: Unknown result type (might be due to invalid IL or missing references)
			//IL_209d: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_20b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da0: Expected Obj, but got I
			//IL_0dae: Expected I, but got Obj
			//IL_269b: Unknown result type (might be due to invalid IL or missing references)
			//IL_269f: Unknown result type (might be due to invalid IL or missing references)
			//IL_26aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_26c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_26c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_26f5: Expected Obj, but got I4
			//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8d: Expected Obj, but got Unknown
			//IL_0f96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f9b: Expected Obj, but got Unknown
			//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb8: Expected Obj, but got Unknown
			//IL_0fc1: Expected Obj, but got I4
			//IL_2103: Expected Obj, but got I
			//IL_212a: Unknown result type (might be due to invalid IL or missing references)
			//IL_212e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2139: Unknown result type (might be due to invalid IL or missing references)
			//IL_214a: Unknown result type (might be due to invalid IL or missing references)
			//IL_214e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd9: Expected Obj, but got I4
			//IL_2721: Expected Obj, but got I
			//IL_273b: Expected Obj, but got I4
			//IL_275c: Expected Obj, but got I4
			//IL_276c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2770: Unknown result type (might be due to invalid IL or missing references)
			//IL_277b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2794: Unknown result type (might be due to invalid IL or missing references)
			//IL_2798: Unknown result type (might be due to invalid IL or missing references)
			//IL_27c6: Expected Obj, but got I4
			//IL_21c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_21ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_21d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_21e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_21ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ead: Unknown result type (might be due to invalid IL or missing references)
			//IL_27e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2802: Expected Obj, but got I
			//IL_281c: Expected Obj, but got I4
			//IL_2825: Unknown result type (might be due to invalid IL or missing references)
			//IL_282a: Expected Obj, but got Unknown
			//IL_2843: Unknown result type (might be due to invalid IL or missing references)
			//IL_2857: Unknown result type (might be due to invalid IL or missing references)
			//IL_285c: Expected Obj, but got Unknown
			//IL_285c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2890: Unknown result type (might be due to invalid IL or missing references)
			//IL_2894: Unknown result type (might be due to invalid IL or missing references)
			//IL_2898: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f07: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f18: Expected Obj, but got I4
			//IL_223b: Expected Obj, but got I
			//IL_2262: Unknown result type (might be due to invalid IL or missing references)
			//IL_2266: Unknown result type (might be due to invalid IL or missing references)
			//IL_2271: Unknown result type (might be due to invalid IL or missing references)
			//IL_2282: Unknown result type (might be due to invalid IL or missing references)
			//IL_2286: Unknown result type (might be due to invalid IL or missing references)
			//IL_3420: Expected Obj, but got I
			//IL_3428: Expected I, but got Obj
			//IL_3428: Unknown result type (might be due to invalid IL or missing references)
			//IL_3431: Expected Ref, but got Unknown
			//IL_344b: Expected Obj, but got I4
			//IL_344b: Unknown result type (might be due to invalid IL or missing references)
			//IL_344f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cee: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cf7: Invalid comparison between Unknown and I4
			//IL_2d08: Expected Obj, but got I4
			//IL_2d08: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d10: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d18: Expected Obj, but got Unknown
			//IL_320a: Unknown result type (might be due to invalid IL or missing references)
			//IL_320e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3219: Unknown result type (might be due to invalid IL or missing references)
			//IL_322a: Unknown result type (might be due to invalid IL or missing references)
			//IL_322e: Unknown result type (might be due to invalid IL or missing references)
			//IL_326a: Expected Obj, but got I4
			//IL_22e4: Expected I, but got Obj
			//IL_22f4: Expected Obj, but got I
			//IL_2304: Expected F4, but got I
			//IL_2326: Expected VT, but got I4
			//IL_2326: Expected Obj, but got I
			//IL_2326: Expected Obj, but got I
			//IL_2d83: Expected Obj, but got I
			//IL_2d9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3288: Unknown result type (might be due to invalid IL or missing references)
			//IL_328d: Expected Obj, but got Unknown
			//IL_32a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ba: Expected Obj, but got I
			//IL_32d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_3301: Expected Obj, but got I4
			//IL_2d5d: Expected Obj, but got I4
			//IL_2d5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d61: Unknown result type (might be due to invalid IL or missing references)
			//IL_234b: Unknown result type (might be due to invalid IL or missing references)
			//IL_234f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2353: Unknown result type (might be due to invalid IL or missing references)
			//IL_2358: Expected Obj, but got Unknown
			//IL_2368: Expected Obj, but got I
			//IL_2375: Unknown result type (might be due to invalid IL or missing references)
			//IL_2379: Unknown result type (might be due to invalid IL or missing references)
			//IL_237d: Unknown result type (might be due to invalid IL or missing references)
			//IL_237e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2382: Unknown result type (might be due to invalid IL or missing references)
			//IL_238a: Unknown result type (might be due to invalid IL or missing references)
			//IL_238b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2399: Unknown result type (might be due to invalid IL or missing references)
			//IL_23e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_23ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_23f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2408: Unknown result type (might be due to invalid IL or missing references)
			//IL_240c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2420: Unknown result type (might be due to invalid IL or missing references)
			//IL_2424: Unknown result type (might be due to invalid IL or missing references)
			//IL_243a: Unknown result type (might be due to invalid IL or missing references)
			//IL_243e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2460: Expected Obj, but got I4
			//IL_2dc6: Expected Obj, but got I
			//IL_2e18: Expected Obj, but got I
			int num = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj = 0;
			Component component = _003C_003E4__this;
			Enumerator<, > val2 = default;
			Enumerator<, > val3;
			int num3;
			Enumerator<, > val5;
			int num4;
			UnityEngine.Object obj2;
			Vector3[] array;
			Enumerator<, > val4;
			nint num2;
			Enumerator<, > val;
			if (_003C_003E1__state > 2)
			{
				if (_003C_003E1__state <= 4)
				{
					bool flag = _003C_003E1__state == 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46E0]");
					obj2 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4280]");
					array = (Vector3[])0;
					if (flag)
					{
						_003C_003E1__state = -1;
						bool flag2 = (object)_003C_003E4__this == null;
						val = val2;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						if (!flag2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+60]");
							bool flag3 = (nint)0 == 0;
							val = val2;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							if (!flag3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+60]");
								Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
								object obj3 = this + 88;
								obj3 = sharedMaterials;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X21_v38-18]");
								bool flag4 = (nint)0 == 0;
								val = val2;
								val3 = (Enumerator<, >)0;
								val4 = (Enumerator<, >)0;
								num2 = (nint)sharedMaterials;
								if (!flag4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X21_v38-18]");
									int subMeshCount = ((Mesh)0).subMeshCount;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67A0]");
									object obj4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X21_v38-28]");
									bool flag5 = (nint)0 == 0;
									val = val2;
									val3 = (Enumerator<, >)0;
									val4 = (Enumerator<, >)0;
									num2 = subMeshCount;
									if (!flag5)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X21_v38-28]");
										UnityEngine.Object obj5 = (UnityEngine.Object)((nint)0 + (nint)32);
										IntPtr intPtr = default;
										obj5 = (UnityEngine.Object)(nint)intPtr;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										_003Cs_003E5__8 = 0;
										num2 = intPtr;
										num3 = 0;
										goto IL_2fea;
									}
								}
							}
						}
						goto IL_2e2b;
					}
					bool flag6 = _003C_003E1__state != 4;
					val5 = (Enumerator<, >)0;
					if (!flag6)
					{
						_003C_003E1__state = -1;
						goto IL_0a6c;
					}
				}
				else
				{
					if (_003C_003E1__state == 5)
					{
						_003C_003E1__state = -1;
						val4 = (Enumerator<, >)0;
						goto IL_1244;
					}
					bool flag7 = _003C_003E1__state != 6;
					val5 = (Enumerator<, >)0;
					if (!flag7)
					{
						_003C_003E1__state = -1;
						num4 = ++_003Cs_003E5__8;
						val4 = (Enumerator<, >)0;
						goto IL_2fa7;
					}
				}
				goto IL_2f81;
			}
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag8 = _003C_003E1__state != 2;
					val5 = (Enumerator<, >)0;
					if (flag8)
					{
						goto IL_2f81;
					}
					_003C_003E1__state = -1;
					bool flag9 = (object)_003Cm_003E5__3 == null;
					val = val2;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					if (flag9)
					{
						goto IL_2e2b;
					}
					BoneWeight[] boneWeights = _003Cm_003E5__3.boneWeights;
					object obj6 = this + 80;
					obj6 = boneWeights;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj7 = this + 24;
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj8 = 3;
				}
				else
				{
					_003C_003E1__state = -1;
					bool flag10 = (object)_003Cm_003E5__3 == null;
					val = val2;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					if (flag10)
					{
						goto IL_2e2b;
					}
					Vector3[] normals = _003Cm_003E5__3.normals;
					object obj9 = this + 72;
					obj9 = normals;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj7 = this + 24;
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj8 = 2;
				}
				goto IL_2f94;
			}
			_003C_003E1__state = -1;
			bool flag11 = (object)_003C_003E4__this == null;
			val = val2;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			int[] array3;
			Bounds bounds;
			int[] array4;
			Enumerator<, > val7 = default;
			Enumerator<, > val8;
			object obj26;
			float num5;
			Enumerator<, > val10;
			object obj28;
			Enumerator<, > val12;
			int num6;
			int num7 = default;
			Enumerator<, > val11 = default;
			int[] tris = default;
			Bounds bounds2 = default;
			int[] points = default;
			BoneWeight[] array6 = default;
			Enumerator<, > val9 = default;
			object obj27 = default;
			float units = default;
			object obj29 = default;
			Vector3[] array8 = default;
			Vector3[] array2 = default;
			if (!flag11)
			{
				object obj10 = _003C_003E4__this + 112;
				obj10 = baked;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj11 = obj;
				obj2 = (UnityEngine.Object)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X0_v78+E4]");
				bool flag12 = (nint)0 == 0;
				object obj12 = !flag12;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag13 = obj2 == null;
				bool flag14 = !flag13;
				object obj13 = !flag14;
				if (obj13 == null)
				{
					object obj14 = obj10;
					bool flag15 = obj10 == null;
					val = val2;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					array2 = null;
					num2 = unchecked((nint)null);
					if (flag15)
					{
						goto IL_2e2b;
					}
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ X0_v82+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ X0_v82+E4]");
					bool flag16 = (nint)0 == 0;
					object obj16 = !flag16;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v65+18]");
					bool flag17 = (UnityEngine.Object)0 == null;
					bool flag18 = !flag17;
					object obj17 = !flag18;
					if (obj17 == null)
					{
						object obj18 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+60]");
						obj2 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1611 @ X0_v86+E4]");
						bool flag19 = (nint)0 == 0;
						object obj19 = !flag19;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag20 = obj2 == null;
						bool flag21 = !flag20;
						object obj20 = !flag21;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+60]");
							bool flag22 = (nint)0 == 0;
							val = val2;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							array2 = null;
							num2 = unchecked((nint)null);
							if (!flag22)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+60]");
								Mesh sharedMesh = ((SkinnedMeshRenderer)0).sharedMesh;
								object obj21 = this + 56;
								obj21 = sharedMesh;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
								object obj22 = 0;
								object obj23 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1806 @ X0_v94+E4]");
								bool flag23 = (nint)0 == 0;
								object obj24 = !flag23;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag24 = GillaWounds.Knows((Mesh)obj21);
								bool flag25 = !flag24;
								object obj25 = !flag25;
								array3 = tris;
								bounds = bounds2;
								array4 = points;
								BoneWeight[] array5 = array6;
								Enumerator<, > val6 = val7;
								val8 = val9;
								obj26 = obj27;
								num5 = units;
								val10 = val11;
								obj28 = obj29;
								Vector3[] array7 = array8;
								val12 = (Enumerator<, >)0;
								num6 = num7;
								Vector3[] array9 = null;
								if (obj25 != null)
								{
									goto IL_1bde;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD00]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								object obj31 = default;
								obj31._002Ector();
								object obj32 = this + 48;
								obj32 = obj31;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								object obj33 = obj10;
								bool flag26 = obj10 == null;
								val = val2;
								val3 = (Enumerator<, >)0;
								val4 = (Enumerator<, >)0;
								array2 = null;
								num2 = (nint)obj31;
								component = (Component)obj31;
								if (!flag26)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v72+18]");
									num2 = 0;
									component = (Component)(this + 64);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v72+18]");
									component = (Component)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool flag27 = (object)component == null;
									val = val2;
									val3 = (Enumerator<, >)0;
									val4 = (Enumerator<, >)0;
									array2 = null;
									if (!flag27)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)-10]");
										component = (Component)0;
										Vector3[] vertices = ((Mesh)(object)component).vertices;
										bool flag28 = (object)component == null;
										val = val2;
										val3 = (Enumerator<, >)0;
										val4 = (Enumerator<, >)0;
										array2 = null;
										num2 = unchecked((nint)null);
										if (!flag28)
										{
											object obj34 = component + 16;
											obj34 = vertices;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											object obj35 = this + 24;
											obj35 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											_ = 1;
											val5 = (Enumerator<, >)1;
											goto IL_2f81;
										}
									}
								}
							}
							goto IL_2e2b;
						}
					}
				}
				goto IL_2e1d;
			}
			goto IL_2e2b;
			IL_1244:
			bool flag29 = _003Csums_003E5__7 == null;
			val = val2;
			val3 = (Enumerator<, >)0;
			if (!flag29)
			{
				if (!_003Csums_003E5__7.IsCompleted)
				{
					object obj7 = this + 24;
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj8 = 5;
					goto IL_2f94;
				}
				bool flag30 = _003Csums_003E5__7 == null;
				val = val2;
				val3 = (Enumerator<, >)0;
				num2 = unchecked((nint)null);
				if (!flag30)
				{
					if (_003Csums_003E5__7.IsFaulted)
					{
						bool flag31 = _003Csums_003E5__7 == null;
						val = val2;
						val3 = (Enumerator<, >)0;
						num2 = unchecked((nint)null);
						if (!flag31)
						{
							AggregateException exception = _003Csums_003E5__7.Exception;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41B0]");
							object obj36 = 0;
							object obj37 = obj36;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ X8_v103+E4]");
							bool flag32 = (nint)0 == 0;
							object obj38 = !flag32;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Debug.LogException(exception);
							goto IL_2e1d;
						}
					}
					else
					{
						bool flag33 = (object)_003Cm_003E5__3 == null;
						val = val2;
						val3 = (Enumerator<, >)0;
						num2 = unchecked((nint)null);
						if (!flag33)
						{
							Bounds bounds3 = _003Cm_003E5__3.bounds;
							MonsterWounds._003C_003Ec__DisplayClass87_0 obj39 = _003C_003E8__1;
							bool flag34 = _003C_003E8__1 == null;
							val = val2;
							val3 = (Enumerator<, >)0;
							num2 = unchecked((nint)null);
							if (!flag34)
							{
								units = obj39.units;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
								object obj40 = 0;
								array = obj39.at;
								object obj41 = val2 + val2;
								object obj42 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ X0_v185+E4]");
								num = 0;
								object obj43 = default;
								obj27 = obj41 * obj43;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction ZIP1 not yet implemented.\"");
								val7 = (Enumerator<, >)(obj27 * 63);
								Enumerator<, > val13 = default;
								val4 = (Enumerator<, >)(val13 * 63);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ X0_v185+E4]");
								bool flag35 = (nint)0 == 0;
								object obj44 = !flag35;
								if (obj44 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Enumerator<, > val14 = default;
								GillaWounds.Know(_003Cimported_003E5__2, _003Cm_003E5__3, array, _003Cfaces_003E5__4, _003Cweights_003E5__5, obj39.points, obj39.tris, (Bounds)(&val14));
								bool flag36 = (object)component == null;
								val14 = val4;
								tris = obj39.tris;
								bounds2 = (Bounds)(&val14);
								val = val2;
								val3 = (Enumerator<, >)0;
								points = obj39.points;
								array6 = _003Cweights_003E5__5;
								val9 = val13;
								val11 = (Enumerator<, >)63;
								object obj45 = default;
								obj29 = obj45;
								array8 = _003Cfaces_003E5__4;
								array2 = array;
								num2 = (nint)_003Cm_003E5__3;
								obj2 = _003Cm_003E5__3;
								if (!flag36)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
									object obj46 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
									bool flag37 = (nint)0 == 0;
									val14 = val4;
									tris = obj39.tris;
									bounds2 = (Bounds)(&val14);
									val = val2;
									val3 = (Enumerator<, >)0;
									points = obj39.points;
									array6 = _003Cweights_003E5__5;
									val9 = val13;
									val11 = (Enumerator<, >)63;
									obj29 = obj45;
									array8 = _003Cfaces_003E5__4;
									array2 = array;
									num2 = (nint)_003Cm_003E5__3;
									obj2 = _003Cm_003E5__3;
									if (!flag37)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v99+40]");
										num2 = 0;
										object obj47 = this + 112;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v99+40]");
										obj47 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										_ = 0;
										val14 = val4;
										tris = obj39.tris;
										bounds2 = (Bounds)(&val14);
										points = obj39.points;
										array6 = _003Cweights_003E5__5;
										val9 = val13;
										val11 = (Enumerator<, >)63;
										obj29 = obj45;
										array8 = _003Cfaces_003E5__4;
										array2 = array;
										obj2 = _003Cm_003E5__3;
										num4 = 0;
										goto IL_2fa7;
									}
								}
							}
						}
					}
				}
			}
			goto IL_2e2b;
			IL_2fea:
			MonsterWounds._003C_003Ec__DisplayClass87_0 obj48 = _003C_003E8__1;
			bool flag38 = _003C_003E8__1 == null;
			val = val2;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			string text;
			if (!flag38)
			{
				num = (int)obj48.lists;
				bool flag39 = obj48.lists == null;
				val = val2;
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				if (!flag39)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
					num = 0;
					int num8 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
					if ((nint)num8 < (nint)0)
					{
						num = (int)_003Cmats_003E5__6;
						bool flag40 = _003Cmats_003E5__6 == null;
						val = val2;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						if (!flag40)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
							num7 = 0;
							int num9 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
							bool flag41 = (nint)num9 < (nint)0;
							object obj49 = !flag41;
							int num10 = num3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
							if ((nint)num10 < (nint)0)
							{
								val = val2;
								val3 = (Enumerator<, >)0;
								val4 = (Enumerator<, >)0;
								if (obj49 != null)
								{
									goto IL_2e39;
								}
								object obj50 = obj;
								object obj51 = _003Cmats_003E5__6 + num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1624 @ X0_v225+E4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1597 @ X8_v119+20]");
								UnityEngine.Object obj5 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1624 @ X0_v225+E4]");
								bool flag42 = (nint)0 == 0;
								object obj52 = !flag42;
								if (obj52 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag43 = obj5 != null;
								bool flag44 = !flag43;
								array2 = null;
								num2 = unchecked((nint)null);
								if (!flag44)
								{
									Material[] array10 = _003Cmats_003E5__6;
									bool flag45 = _003Cmats_003E5__6 == null;
									val = val2;
									val3 = (Enumerator<, >)0;
									val4 = (Enumerator<, >)0;
									array2 = null;
									num2 = unchecked((nint)null);
									if (!flag45)
									{
										num = _003Cs_003E5__8;
										num7 = array10.Length;
										bool flag46 = _003Cs_003E5__8 < array10.Length;
										object obj53 = !flag46;
										val = val2;
										val3 = (Enumerator<, >)0;
										val4 = (Enumerator<, >)0;
										array2 = null;
										num2 = unchecked((nint)null);
										if (obj53 != null)
										{
											goto IL_2e39;
										}
										object obj54 = _003Cmats_003E5__6 + _003Cs_003E5__8;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v121+20]");
										bool flag47 = (nint)0 == 0;
										val = val2;
										val3 = (Enumerator<, >)0;
										val4 = (Enumerator<, >)0;
										array2 = null;
										num2 = unchecked((nint)null);
										if (!flag47)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v121+20]");
											text = ((UnityEngine.Object)0).name;
											array2 = null;
											num2 = unchecked((nint)null);
											goto IL_302f;
										}
									}
									goto IL_2e2b;
								}
							}
							text = (string)(object)obj2;
							goto IL_302f;
						}
					}
					else
					{
						object obj55 = _003C_003E8__1 + 48;
						obj55 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						bool flag48 = _003C_003E8__1 == null;
						val = val2;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						num2 = unchecked((nint)null);
						if (!flag48)
						{
							object obj56 = _003C_003E8__1 + 40;
							obj56 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							bool flag49 = (object)component == null;
							val = val2;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							num2 = unchecked((nint)null);
							if (!flag49)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
								object obj57 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
								bool flag50 = (nint)0 == 0;
								val = val2;
								val3 = (Enumerator<, >)0;
								val4 = (Enumerator<, >)0;
								num2 = unchecked((nint)null);
								if (!flag50)
								{
									object obj58 = _003C_003E8__1;
									bool flag51 = _003C_003E8__1 == null;
									val = val2;
									val3 = (Enumerator<, >)0;
									val4 = (Enumerator<, >)0;
									num2 = unchecked((nint)null);
									if (!flag51)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C46B8]");
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v108+20]");
										val4 = (Enumerator<, >)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v108+20]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDCF8]");
										object obj59 = 0;
										Action action = default;
										action._002Ector(_003C_003E8__1, (IntPtr)obj59);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
										object obj60 = 0;
										object obj61 = obj60;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1793 @ X0_v206+E4]");
										bool flag52 = (nint)0 == 0;
										object obj62 = !flag52;
										if (obj62 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Task task = Task.Run(action);
										object obj63 = this + 96;
										obj63 = task;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										array8 = null;
										array2 = (Vector3[])obj59;
										num2 = (nint)task;
										obj2 = (UnityEngine.Object)(object)action;
										goto IL_1244;
									}
								}
							}
						}
					}
				}
			}
			goto IL_2e2b;
			IL_2fa7:
			object obj64 = this + 112;
			num = (int)obj64;
			bool flag53 = obj64 == null;
			val = val2;
			val3 = (Enumerator<, >)0;
			if (!flag53)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
				num7 = 0;
				int num11 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
				bool flag54 = (nint)num11 < (nint)0;
				object obj65 = !flag54;
				int num12 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
				if ((nint)num12 < (nint)0)
				{
					val = val2;
					val3 = (Enumerator<, >)0;
					if (obj65 != null)
					{
						goto IL_2e39;
					}
					object obj66 = obj64 + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD10]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v79+20]");
					obj2 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					object obj67 = default;
					obj67._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v79+20]");
					bool flag55 = (nint)0 == 0;
					val = val2;
					val3 = (Enumerator<, >)0;
					num2 = unchecked((nint)null);
					component = (Component)obj67;
					if (!flag55)
					{
						object obj68 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1601 @ X0_v153+E4]");
						bool flag56 = (nint)0 == 0;
						object obj69 = !flag56;
						if (obj69 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X22_v1 (UnityEngine.Object)+20]");
						bool flag57 = (UnityEngine.Object)0 != null;
						bool flag58 = !flag57;
						ref Bounds reference = ref *(Bounds*)array6;
						nint num13 = 0;
						if (!flag58)
						{
							bool flag59 = obj67 == null;
							val = val2;
							val3 = (Enumerator<, >)0;
							array2 = null;
							num2 = unchecked((nint)null);
							component = (Component)obj67;
							if (flag59)
							{
								goto IL_2e2b;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
							object obj70 = 0;
							object obj71 = obj70;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1742 @ X0_v160+E4]");
							bool flag60 = (nint)0 == 0;
							object obj72 = !flag60;
							if (obj72 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							ref Vector3[] at = ref *(Vector3[]*)(obj67 + 16);
							ref Vector3[] reference2 = ref *(Vector3[]*)(obj67 + 24);
							ref int[] reference3 = ref *(int[]*)(obj67 + 32);
							reference = ref *(Bounds*)(obj67 + 40);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X22_v1 (UnityEngine.Object)+20]");
							bool flag61 = GillaWounds.WillShape((Mesh)0, out at, out reference2, out reference3, out reference);
							bool flag62 = !flag61;
							points = null;
							array8 = (Vector3[])System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
							num13 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							if (!flag62)
							{
								object obj73 = obj67 + 64;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X22_v1 (UnityEngine.Object)+20]");
								obj73 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C67F8]");
								object obj74 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD08]");
								object obj75 = 0;
								num13 = (nint)obj75;
								Func<System.__Canon> func = default;
								func._002Ector(obj67, (IntPtr)obj75);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6D00]");
								object obj76 = 0;
								object obj77 = obj76;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1864 @ X0_v169+E4]");
								bool flag63 = (nint)0 == 0;
								object obj78 = !flag63;
								if (obj78 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Task<System.__Canon> task2 = Task.Run(func);
								points = null;
								array8 = null;
							}
						}
						object obj7 = this + 24;
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj8 = 6;
						goto IL_2f94;
					}
				}
				else
				{
					_003C_003E7__wrap8 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj79 = this + 48;
					obj79 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj80 = this + 64;
					obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj81 = this + 72;
					obj81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj82 = this + 80;
					obj82 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj83 = this + 88;
					obj83 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj84 = this + 96;
					obj84 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					bool flag64 = (object)component == null;
					array3 = tris;
					bounds = bounds2;
					array4 = points;
					BoneWeight[] array5 = array6;
					Enumerator<, > val6 = val7;
					val8 = val9;
					obj26 = obj27;
					num5 = units;
					val10 = val11;
					obj28 = obj29;
					Vector3[] array7 = array8;
					val12 = val4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
					num6 = 0;
					Vector3[] array9 = array2;
					val = val2;
					val3 = (Enumerator<, >)0;
					num2 = unchecked((nint)null);
					if (!flag64)
					{
						goto IL_1bde;
					}
				}
			}
			goto IL_2e2b;
			IL_246e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1877 @ X8_v26+38]");
			object obj85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1877 @ X8_v26+38]");
			bool flag65 = (nint)0 == 0;
			tris = array3;
			bounds2 = bounds;
			val = val2;
			val3 = (Enumerator<, >)0;
			points = array4;
			array6 = null;
			val9 = val8;
			obj27 = obj26;
			units = num5;
			val11 = val10;
			obj29 = obj28;
			array8 = (Vector3[])(object)_003Cimported_003E5__2;
			val4 = val12;
			bool flag66;
			array2 = (Vector3[])flag66;
			int num14;
			num = num14;
			nint num15;
			num2 = num15;
			if (flag65)
			{
				goto IL_2e2b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v27+18]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v27+18]");
			if ((nint)0 < (nint)1)
			{
				goto IL_28aa;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v27+18]");
			int num16 = (int)(~(nint)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v27+18]");
			num7 = (int)((nint)0 & (nint)num16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+168]");
			object obj86 = 0;
			object obj88 = default;
			object obj87 = obj88;
			object obj89 = 0;
			val11 = val10;
			val4 = val12;
			while (true)
			{
				bool flag67 = num == (nint)obj89;
				tris = array3;
				bounds2 = bounds;
				val = val2;
				val3 = (Enumerator<, >)0;
				obj88 = obj87;
				object obj90 = obj89;
				points = array4;
				array6 = null;
				val9 = val8;
				obj27 = obj26;
				units = num5;
				obj29 = obj28;
				array8 = (Vector3[])(object)_003Cimported_003E5__2;
				array2 = (Vector3[])flag66;
				num2 = num15;
				if (flag67)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1877 @ X8_v26+38]");
				object obj91 = 0 + obj89;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1937 @ X13_v11+20]");
				obj88 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1937 @ X13_v11+20]");
				bool flag68 = (nint)0 == 0;
				tris = array3;
				bounds2 = bounds;
				val = val2;
				val3 = (Enumerator<, >)0;
				obj90 = obj89;
				points = array4;
				array6 = null;
				val9 = val8;
				obj27 = obj26;
				units = num5;
				obj29 = obj28;
				array8 = (Vector3[])(object)_003Cimported_003E5__2;
				array2 = (Vector3[])flag66;
				num2 = num15;
				if (!flag68)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+168]");
					bool flag69 = (nint)0 == 0;
					tris = array3;
					bounds2 = bounds;
					val = val2;
					val3 = (Enumerator<, >)0;
					obj90 = obj89;
					points = array4;
					array6 = null;
					val9 = val8;
					obj27 = obj26;
					units = num5;
					obj29 = obj28;
					array8 = (Vector3[])(object)_003Cimported_003E5__2;
					array2 = (Vector3[])flag66;
					num2 = num15;
					if (!flag69)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X13_v9+10]");
						object obj92 = -2;
						bool flag70 = obj92 == null;
						object obj93 = !flag70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X11_v9+18]");
						bool flag71 = (nint)obj93 < 0;
						object obj94 = !flag71;
						tris = array3;
						bounds2 = bounds;
						val = val2;
						val3 = (Enumerator<, >)0;
						obj90 = obj89;
						points = array4;
						array6 = null;
						val9 = val8;
						obj27 = obj26;
						units = num5;
						obj29 = obj28;
						array8 = (Vector3[])(object)_003Cimported_003E5__2;
						array2 = (Vector3[])flag66;
						num2 = num15;
						if (obj94 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+8C]");
						val10 = (Enumerator<, >)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X13_v9+10]");
						object obj95 = -2;
						bool flag72 = obj95 == null;
						object obj96 = !flag72;
						obj90 = obj89 + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X13_v9+4C]");
						nint num17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+8C]");
						val12 = (Enumerator<, >)(num17 * 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+168]");
						obj88 = 0 + obj96;
						bool flag73 = num7 != (nint)obj90;
						obj87 = obj88;
						obj89 = obj90;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+8C]");
						val11 = (Enumerator<, >)0;
						val4 = val12;
						if (flag73)
						{
							continue;
						}
						goto IL_28aa;
					}
				}
				goto IL_2e2b;
			}
			goto IL_2e39;
			IL_1bde:
			GameObject gameObject = component.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4D50]");
			object obj97 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+60]");
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)0;
			object obj98 = obj97;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X8_v24+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ X8_v24+E4]");
			bool flag74 = (nint)0 == 0;
			object obj99 = !flag74;
			if (obj99 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
			GillaWounds gillaWounds = GillaWounds.On(gameObject, (MonsterGore)0, skinnedMeshRenderer, _003Cimported_003E5__2);
			object obj100 = component + 120;
			obj100 = gillaWounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X20_v18-8]");
			object obj101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X20_v18-8]");
			bool flag75 = (nint)0 == 0;
			tris = array3;
			bounds2 = bounds;
			val = val2;
			val3 = (Enumerator<, >)0;
			points = array4;
			array6 = null;
			val9 = val8;
			obj27 = obj26;
			units = num5;
			val11 = val10;
			obj29 = obj28;
			array8 = (Vector3[])(object)_003Cimported_003E5__2;
			val4 = val12;
			num7 = num6;
			array2 = (Vector3[])(object)skinnedMeshRenderer;
			num2 = (nint)gillaWounds;
			if (!flag75)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1877 @ X8_v26+30]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1877 @ X8_v26+30]");
				bool flag76 = (nint)0 == 0;
				tris = array3;
				bounds2 = bounds;
				val = val2;
				val3 = (Enumerator<, >)0;
				points = array4;
				array6 = null;
				val9 = val8;
				obj27 = obj26;
				units = num5;
				val11 = val10;
				obj29 = obj28;
				array8 = (Vector3[])(object)_003Cimported_003E5__2;
				val4 = val12;
				num7 = num6;
				array2 = (Vector3[])(object)skinnedMeshRenderer;
				num2 = (nint)gillaWounds;
				if (!flag76)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
					num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
					bool flag77 = (nint)0 == 0;
					object obj103 = default;
					object obj102 = obj103;
					Enumerator<, > val16 = default;
					Enumerator<, > val15 = val16;
					flag66 = (byte)(int)skinnedMeshRenderer != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1877 @ X8_v26+30]");
					num14 = 0;
					num15 = (nint)gillaWounds;
					if (flag77)
					{
						goto IL_246e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+18]");
					bool flag78 = (nint)0 == 0;
					tris = array3;
					bounds2 = bounds;
					val = val2;
					val3 = (Enumerator<, >)0;
					points = array4;
					array6 = null;
					val9 = val8;
					obj27 = obj26;
					units = num5;
					val11 = val10;
					obj29 = obj28;
					array8 = (Vector3[])(object)_003Cimported_003E5__2;
					val4 = val12;
					array2 = (Vector3[])(object)skinnedMeshRenderer;
					num2 = (nint)gillaWounds;
					if (flag78)
					{
						goto IL_2e39;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+20]");
					object obj104 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X9_v21 (System.Int32)+20]");
					bool flag79 = (nint)0 == 0;
					tris = array3;
					bounds2 = bounds;
					val = val2;
					val3 = (Enumerator<, >)0;
					points = array4;
					array6 = null;
					val9 = val8;
					obj27 = obj26;
					units = num5;
					val11 = val10;
					obj29 = obj28;
					array8 = (Vector3[])(object)_003Cimported_003E5__2;
					val4 = val12;
					array2 = (Vector3[])(object)skinnedMeshRenderer;
					num2 = (nint)gillaWounds;
					if (!flag79)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CDA35]");
						num = 0;
						bool flag80 = obj100 == null;
						tris = array3;
						bounds2 = bounds;
						val = val2;
						val3 = (Enumerator<, >)0;
						points = array4;
						array6 = null;
						val9 = val8;
						obj27 = obj26;
						units = num5;
						val11 = val10;
						obj29 = obj28;
						array8 = (Vector3[])(object)_003Cimported_003E5__2;
						val4 = val12;
						array2 = (Vector3[])(object)skinnedMeshRenderer;
						num2 = (nint)gillaWounds;
						obj2 = (UnityEngine.Object)109891584;
						if (!flag80)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
							skinnedMeshRenderer = (SkinnedMeshRenderer)0;
							nint num18 = (nint)skinnedMeshRenderer;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1935 @ X8_v46 (Il2CppClass<UnityEngine.SkinnedMeshRenderer>)+A0]");
							object obj105 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1936 @ X8_v47+40]");
							val11 = (Enumerator<, >)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1936 @ X8_v47+44]");
							units = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1936 @ X8_v47+3C]");
							val4 = (Enumerator<, >)0;
							object obj106 = obj100;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v44+18]");
							Vector3 vector = ((GillaWounds)obj106).World((string)0, (Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
							object obj107 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
							bool flag81 = (nint)0 == 0;
							tris = array3;
							bounds2 = bounds;
							val = val2;
							val3 = (Enumerator<, >)0;
							points = array4;
							array6 = null;
							val9 = val8;
							obj27 = obj26;
							obj29 = obj28;
							array8 = (Vector3[])(object)_003Cimported_003E5__2;
							array2 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v44+18]");
							num2 = 0;
							if (!flag81)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v48+30]");
								object obj108 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v48+30]");
								bool flag82 = (nint)0 == 0;
								tris = array3;
								bounds2 = bounds;
								val = val2;
								val3 = (Enumerator<, >)0;
								points = array4;
								array6 = null;
								val9 = val8;
								obj27 = obj26;
								obj29 = obj28;
								array8 = (Vector3[])(object)_003Cimported_003E5__2;
								array2 = null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v44+18]");
								num2 = 0;
								if (!flag82)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v49+18]");
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v49+18]");
									bool flag83 = (nint)0 == 0;
									tris = array3;
									bounds2 = bounds;
									val = val2;
									val3 = (Enumerator<, >)0;
									points = array4;
									array6 = null;
									val9 = val8;
									obj27 = obj26;
									obj29 = obj28;
									array8 = (Vector3[])(object)_003Cimported_003E5__2;
									array2 = null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v44+18]");
									num2 = 0;
									if (flag83)
									{
										goto IL_2e39;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v49+20]");
									object obj109 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v49+20]");
									bool flag84 = (nint)0 == 0;
									tris = array3;
									bounds2 = bounds;
									val = val2;
									val3 = (Enumerator<, >)0;
									points = array4;
									array6 = null;
									val9 = val8;
									obj27 = obj26;
									obj29 = obj28;
									array8 = (Vector3[])(object)_003Cimported_003E5__2;
									array2 = null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v44+18]");
									num2 = 0;
									if (!flag84)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CD99B]");
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+78]");
										bool flag85 = (nint)0 == 0;
										tris = array3;
										bounds2 = bounds;
										val = val2;
										val3 = (Enumerator<, >)0;
										points = array4;
										array6 = null;
										val9 = val8;
										obj27 = obj26;
										obj29 = obj28;
										array8 = (Vector3[])(object)_003Cimported_003E5__2;
										array2 = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v44+18]");
										num2 = 0;
										array = (Vector3[])109891584;
										if (!flag85)
										{
											nint num19 = (nint)skinnedMeshRenderer;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1999 @ X8_v52 (Il2CppClass<UnityEngine.SkinnedMeshRenderer>)+A0]");
											object obj110 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2001 @ X8_v53+8]");
											num5 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+78]");
											nint num20 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v50+18]");
											Vector3 vector2 = ((GillaWounds)num20).World((string)0, (Vector3)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1936 @ X8_v47+3C]");
											obj102 = 0 - obj110;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1936 @ X8_v47+40]");
											nint num21 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2001 @ X8_v53+4]");
											val15 = (Enumerator<, >)(num21 - 0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
											object obj111 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1936 @ X8_v47+44]");
											nint num22 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2001 @ X8_v53+8]");
											Enumerator<, > val6 = (Enumerator<, >)(num22 - 0);
											object obj112 = obj111;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2020 @ X0_v62+E4]");
											bool flag86 = (nint)0 == 0;
											object obj113 = !flag86;
											if (obj113 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj114 = obj102 * obj102;
											object obj115 = val15 * val15;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
											obj101 = 0;
											object obj116 = obj114 + obj115;
											val10 = (Enumerator<, >)(val6 * val6);
											val12 = (Enumerator<, >)(val10 + obj116);
											Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+70]");
											bool flag87 = (nint)0 == 0;
											flag66 = false;
											num14 = num;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v50+18]");
											num15 = 0;
											tris = array3;
											bounds2 = bounds;
											val = val2;
											val3 = (Enumerator<, >)0;
											points = array4;
											array6 = null;
											val9 = val8;
											obj27 = obj26;
											units = num5;
											val11 = val10;
											obj29 = obj28;
											array8 = (Vector3[])(object)_003Cimported_003E5__2;
											val4 = val12;
											array2 = null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v50+18]");
											num2 = 0;
											array = (Vector3[])109891584;
											if (!flag87)
											{
												goto IL_246e;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_2e2b;
			IL_2e1d:
			val5 = (Enumerator<, >)0;
			goto IL_2f81;
			IL_302f:
			bool flag88 = text == null;
			val = val2;
			val3 = (Enumerator<, >)0;
			val4 = (Enumerator<, >)0;
			if (!flag88)
			{
				bool flag89 = text.Contains((string)(object)array);
				bool flag90 = !flag89;
				object obj117 = !flag90;
				array2 = null;
				num2 = (nint)array;
				if (obj117 != null)
				{
					goto IL_0a6c;
				}
				MonsterWounds._003C_003Ec__DisplayClass87_0 obj118 = _003C_003E8__1;
				bool flag91 = _003C_003E8__1 == null;
				val = val2;
				val3 = (Enumerator<, >)0;
				val4 = (Enumerator<, >)0;
				array2 = null;
				num2 = (nint)array;
				if (!flag91)
				{
					bool flag92 = (object)_003Cm_003E5__3 == null;
					val = val2;
					val3 = (Enumerator<, >)0;
					val4 = (Enumerator<, >)0;
					array2 = null;
					num2 = (nint)array;
					if (!flag92)
					{
						int[][] lists = obj118.lists;
						int[] triangles = _003Cm_003E5__3.GetTriangles(_003Cs_003E5__8);
						bool flag93 = obj118.lists == null;
						val = val2;
						val3 = (Enumerator<, >)0;
						val4 = (Enumerator<, >)0;
						array2 = null;
						num2 = _003Cs_003E5__8;
						component = (Component)_003Cs_003E5__8;
						if (!flag93)
						{
							bool flag94 = _003Cs_003E5__8 < lists.Length;
							object obj119 = !flag94;
							val = val2;
							val3 = (Enumerator<, >)0;
							val4 = (Enumerator<, >)0;
							array2 = null;
							num2 = _003Cs_003E5__8;
							component = (Component)_003Cs_003E5__8;
							if (obj119 != null)
							{
								goto IL_2e39;
							}
							object obj120 = obj118.lists + _003Cs_003E5__8;
							object obj121 = obj120 + 32;
							obj121 = triangles;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj7 = this + 24;
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							object obj8 = 4;
							goto IL_2f94;
						}
					}
				}
			}
			goto IL_2e2b;
			IL_2e2b:
			NullReferenceException ex = new NullReferenceException();
			goto IL_2e39;
			IL_2f94:
			val5 = (Enumerator<, >)1;
			goto IL_2f81;
			IL_28aa:
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+A0]");
			bool flag95 = (nint)0 == 0;
			tris = array3;
			bounds2 = bounds;
			val = val2;
			val3 = (Enumerator<, >)0;
			points = array4;
			array6 = null;
			val9 = val8;
			obj27 = obj26;
			units = num5;
			val11 = val10;
			obj29 = obj28;
			array8 = (Vector3[])(object)_003Cimported_003E5__2;
			val4 = val12;
			array2 = (Vector3[])flag66;
			num2 = num15;
			if (!flag95)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+A0]");
				Enumerator<, > enumerator = ((List<(Vector4, bool)>)0).GetEnumerator();
				val11 = val2;
				Enumerator<, > val17 = default;
				val4 = val17;
				object obj122 = default;
				object obj123 = default;
				float num23 = default;
				Enumerator<, > val18 = default;
				while (val3.MoveNext())
				{
					Vector4 said = (Vector4)(obj122 & 1);
					((MonsterWounds)component).Take(said, flag66);
					obj26 = obj123;
					num5 = num23;
					val11 = val18;
					val4 = val2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDCA8]");
				object obj124 = 0;
				num2 = (nint)obj124;
				val3.Dispose();
				tris = array3;
				bounds2 = bounds;
				val = (Enumerator<, >)0;
				val3 = val17;
				object obj45 = 0;
				points = array4;
				array6 = null;
				val9 = val8;
				obj27 = obj26;
				units = num5;
				obj29 = obj28;
				Enumerator<, > val13 = (Enumerator<, >)(ref val3);
				array8 = (Vector3[])(object)_003Cimported_003E5__2;
				array2 = (Vector3[])flag66;
				num = (int)(&val3);
				bool result = default;
				object obj126 = default;
				Enumerator<, > val19;
				object obj127;
				while (true)
				{
					OutOfMemoryException ex2 = new OutOfMemoryException();
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9D3E0");
						object obj125;
						if (num2 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							val = (Enumerator<, >)1;
							obj125 = obj45;
						}
						else
						{
							if (num2 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289FFDC");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D5652C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD88");
								return result;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D020");
							obj125 = obj126;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D030");
							obj45 = obj126;
						}
						val19 = val13;
						obj127 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDCA0]");
						object obj128 = 0;
						num2 = (nint)obj128;
						((Enumerator<, >*)val19)->Dispose();
						bool flag96 = obj125 == null;
						object obj129 = !flag96;
						val13 = val19;
						if (obj129 != null)
						{
							break;
						}
						bool flag97 = (int)val == 0;
						object obj130 = !flag97;
						val13 = val19;
						ex2 = (OutOfMemoryException)val19;
						if (obj130 == null)
						{
							goto end_IL_2e52;
						}
					}
					continue;
					end_IL_2e52:
					break;
				}
				if ((nint)obj127 != 33)
				{
					bool flag98 = obj127 == null;
					object obj131 = !flag98;
					val5 = val;
					if (obj131 != null)
					{
						goto IL_2f81;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+A8]");
				object obj132 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X19_v3 (UnityEngine.Component)+A8]");
				bool flag99 = (nint)0 == 0;
				val13 = val19;
				if (!flag99)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v8+1C]");
					object obj133 = (nint)0 + (nint)1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v8+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v8+10]");
						nint num24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v8+18]");
						Array.Clear((Array)num24, 0, 0);
					}
					goto IL_2e1d;
				}
			}
			goto IL_2e2b;
			IL_2e39:
			IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
			throw new NullReferenceException();
			IL_2f81:
			return (byte)(val5 & 1) != 0;
			IL_0a6c:
			num3 = ++_003Cs_003E5__8;
			goto IL_2fea;
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

	public enum Phase
	{
		// error: enumerator has no value
		Rest,
		// error: enumerator has no value
		Deploy,
		// error: enumerator has no value
		Spin,
		// error: enumerator has no value
		Retract
	}

	[StructLayout((LayoutKind)3)]
	private struct _003C_003Ec__DisplayClass63_0
	{
		public Transform at;

		public RobotSaw _003C_003E4__this;

		public int made;
	}

	public AudioClip deploySound;

	public AudioClip retractSound;

	public AudioClip motorRun;

	public AudioClip motorCut;

	public float motorAt;

	public float spinUp;

	public float brakeSeconds;

	public float brakePitch;

	public float mechVolume;

	public float motorVolume;

	public float range;

	public float demoVolume;

	public float demoRange;

	private const float BiteHolds = default(float);

	private AudioSource[] mech;

	private AudioSource run;

	private AudioSource cut;

	private AudioLowPassFilter[] lows;

	private readonly float[] mechGain;

	private readonly float[] mechWant;

	private int mechNow;

	private int way;

	private float motorGain;

	private float brakeFrom;

	private float cutMix;

	private float bitUntil;

	private float nextHear;

	private float heard;

	private float heardTo;

	private float muffle;

	private float muffleTo;

	private bool motorOn;

	private bool braking;

	private bool voicesForDemo;

	private AudioClip mechLater;

	private float mechLaterFrom;

	private float mechLaterAt;

	private GillaSawHits hits;

	private static AnimationCurve fall;

	private static AnimationCurve wet;

	private static AudioListener ears;

	public const string LayerName = null;

	public const string TimeParam = null;

	public static readonly string[] States;

	public Animator animator;

	public float deploySeconds;

	public float spinSeconds;

	public float retractSeconds;

	public float foldBackSpeed;

	public float foldStarts;

	public float foldSeconds;

	public float foldFrom;

	public float deployFrames;

	public float takeOverAt;

	public bool demo;

	public float fingerCurl;

	public float thumbCurl;

	public float tipMore;

	public static float TestTrigger;

	private const float DemoRest = default(float);

	private const float DemoHeld = default(float);

	private const float DemoRound = default(float);

	private const float PressAt = default(float);

	private const float LetGoAt = default(float);

	private Phase phase;

	private float t;

	private bool held;

	private int layer;

	private int playing;

	private HandPoser hand;

	private Transform[] curled;

	private Vector3[] hinge;

	private Quaternion[] animated;

	private Quaternion[] wrote;

	private float grip;

	private float gripVel;

	private float thumb;

	private float thumbVel;

	private float atRest;

	private bool curlReady;

	private int startFrame;

	private static readonly int TimeId;

	private static readonly int[] StateIds;

	public AudioClip MechPlaying
	{
		get
		{
			//IL_0046: Expected Obj, but got I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I
			//IL_0102: Expected Obj, but got I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_018f: Expected Obj, but got I4
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I
			AudioSource[] array = mech;
			if (mech == null)
			{
				goto IL_01ed;
			}
			bool flag = mechNow < array.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = mech + mechNow;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+20]");
					if (!((AudioSource)0).isPlaying)
					{
						goto IL_01ed;
					}
					float[] array2 = mechWant;
					if (mechWant != null)
					{
						bool flag2 = mechNow < array2.Length;
						object obj3 = !flag2;
						if (obj3 != null)
						{
							goto IL_01fd;
						}
						object obj4 = mechWant + mechNow;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v6+20]");
						if ((nint)0 <= (nint)0)
						{
							goto IL_01ed;
						}
						AudioSource[] array3 = mech;
						if (mech != null)
						{
							bool flag3 = mechNow < array3.Length;
							object obj5 = !flag3;
							if (obj5 != null)
							{
								goto IL_01fd;
							}
							object obj6 = mech + mechNow;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v7+20]");
								return ((AudioSource)0).clip;
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
			}
			goto IL_01fd;
			IL_01fd:
			return (AudioClip)(object)new IndexOutOfRangeException();
			IL_01ed:
			return null;
		}
	}

	public float MechTime
	{
		get
		{
			//IL_008a: Expected F4, but got I4
			//IL_0046: Expected Obj, but got I4
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_007b: Expected Obj, but got I
			AudioSource[] array = mech;
			if (mech != null)
			{
				bool flag = mechNow < array.Length;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = mech + mechNow;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v3+20]");
					return ((AudioSource)0).time;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
				throw new NullReferenceException();
			}
			return 0f;
		}
	}

	public bool MotorRunning
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_00d0: Expected I4, but got Obj
			if (~(motorOn ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (run != null)
				{
					if ((object)run != null)
					{
						return run.isPlaying;
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			return false;
		}
	}

	public float MotorLevel => motorGain;

	public bool Braking
	{
		get
		{
			//IL_0015: Expected Obj, but got I
			//IL_003f: Expected Obj, but got I4
			//IL_00d0: Expected I4, but got Obj
			if (~(braking ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (run != null)
				{
					if ((object)run != null)
					{
						return run.isPlaying;
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
			}
			return false;
		}
	}

	public bool MotorHeard
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_01bc: Expected Obj, but got I4
			//IL_0192: Expected I4, but got Obj
			//IL_0099: Expected Obj, but got I4
			//IL_00fd: Invalid comparison between F4 and I4
			//IL_010e: Invalid comparison between F4 and I4
			//IL_0125: Expected Obj, but got F4
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_015c: Expected Obj, but got I4
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected I4, but got Unknown
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
			if (!(run != null))
			{
				goto IL_0176;
			}
			if ((object)run != null)
			{
				bool isPlaying = run.isPlaying;
				bool flag2 = !isPlaying;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					if ((object)cut == null)
					{
						goto IL_0184;
					}
					if (!cut.isPlaying)
					{
						goto IL_0176;
					}
				}
				bool flag3 = motorGain < 0f;
				bool flag4 = motorGain == 0f;
				object obj5 = motorGain ^ motorGain;
				object obj6 = motorGain & obj5;
				bool flag5 = (nint)obj6 < 0;
				bool flag6 = flag3 == flag5;
				object obj7 = !flag4;
				return (byte)((flag6 & obj7) ? 1 : 0) != 0;
			}
			goto IL_0184;
			IL_0184:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0176:
			return false;
		}
	}

	public float CutShare => cutMix;

	public Phase Now => phase;

	public float Into => t;

	public float FingersCurled => grip * atRest;

	public void Bit()
	{
		float time = Time.time;
		float num = time;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		float num2 = num + 0f;
		bitUntil = num2;
	}

	private void OnDisable()
	{
		Hush();
	}

	private void Sounds(Phase was, float dt)
	{
		//IL_0010: Expected Obj, but got I
		//IL_1440: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I4
		//IL_02ba: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Expected Obj, but got Unknown
		//IL_14ae: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_035e: Expected Obj, but got I8
		//IL_0201: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I4
		//IL_031a: Expected F4, but got I4
		//IL_0323: Expected F4, but got I4
		//IL_0336: Expected Obj, but got I4
		//IL_027f: Expected F4, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I8
		//IL_050c: Expected Obj, but got I4
		//IL_0225: Expected Obj, but got I8
		//IL_053a: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I4
		//IL_14c7: Expected Obj, but got I4
		//IL_052c: Expected Obj, but got I4
		//IL_055a: Expected F8, but got I4
		//IL_1519: Invalid comparison between F8 and I4
		//IL_152c: Expected Obj, but got F8
		//IL_1534: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Expected Obj, but got Unknown
		//IL_156a: Expected Obj, but got I4
		//IL_15b5: Expected Obj, but got I4
		//IL_15cd: Invalid comparison between F4 and I4
		//IL_15de: Expected Obj, but got I4
		//IL_1622: Expected Obj, but got I4
		//IL_165a: Expected Obj, but got I4
		//IL_059c: Invalid comparison between F8 and I4
		//IL_05ad: Expected Obj, but got I4
		//IL_05b6: Invalid comparison between F8 and I4
		//IL_05c7: Expected Obj, but got I4
		//IL_07c8: Expected F8, but got I4
		//IL_07e4: Expected F8, but got I4
		//IL_07ed: Expected Obj, but got I4
		//IL_1697: Invalid comparison between F8 and I4
		//IL_16aa: Expected Obj, but got F8
		//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b7: Expected Obj, but got Unknown
		//IL_1709: Expected Obj, but got I4
		//IL_1747: Invalid comparison between I and F4
		//IL_1758: Expected Obj, but got I4
		//IL_1778: Invalid comparison between F4 and I4
		//IL_17a1: Expected Obj, but got I4
		//IL_08d7: Expected F8, but got I4
		//IL_08e0: Expected Obj, but got I4
		//IL_062a: Expected Obj, but got I4
		//IL_0848: Expected Obj, but got I4
		//IL_17d8: Expected Obj, but got I4
		//IL_17e1: Expected Obj, but got I4
		//IL_088f: Expected Obj, but got I4
		//IL_08c1: Expected F8, but got I4
		//IL_1731: Expected Obj, but got I4
		//IL_093d: Expected Obj, but got I4
		//IL_098f: Expected Obj, but got I4
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected Obj, but got Unknown
		//IL_09f3: Invalid comparison between F4 and I4
		//IL_0a06: Expected Obj, but got F4
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a3b: Expected Obj, but got I4
		//IL_17f6: Invalid comparison between I and F4
		//IL_1807: Expected Obj, but got I4
		//IL_1827: Invalid comparison between F4 and I4
		//IL_1847: Expected Obj, but got I4
		//IL_0a81: Expected F4, but got I
		//IL_1874: Invalid comparison between F4 and I4
		//IL_1885: Expected Obj, but got I4
		//IL_188e: Invalid comparison between F4 and I4
		//IL_189c: Expected Obj, but got F4
		//IL_18a7: Expected Obj, but got I4
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected Obj, but got Unknown
		//IL_0c14: Expected Obj, but got I4
		//IL_0c1d: Expected Obj, but got I4
		//IL_0c26: Expected Obj, but got I4
		//IL_0ce0: Invalid comparison between F4 and I4
		//IL_0cf3: Expected Obj, but got F4
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Expected Obj, but got Unknown
		//IL_0d31: Expected Obj, but got I4
		//IL_0aca: Expected Obj, but got I4
		//IL_191f: Expected Obj, but got I4
		//IL_1937: Invalid comparison between F4 and I4
		//IL_1979: Expected Obj, but got I4
		//IL_19a6: Invalid comparison between F4 and I4
		//IL_19b9: Expected Obj, but got F4
		//IL_19c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c6: Expected Obj, but got Unknown
		//IL_19f8: Expected Obj, but got I4
		//IL_0b1d: Expected Obj, but got I
		//IL_1a2a: Expected Obj, but got I4
		//IL_1a44: Invalid comparison between F4 and I4
		//IL_1a70: Expected Obj, but got I4
		//IL_0b83: Expected Obj, but got I4
		//IL_1ac7: Invalid comparison between F4 and I4
		//IL_1ad6: Expected F8, but got I4
		//IL_0bd6: Expected Obj, but got I
		//IL_10c7: Invalid comparison between F4 and I4
		//IL_10d6: Expected F8, but got I4
		//IL_1159: Expected Obj, but got I4
		//IL_119c: Expected F4, but got I
		//IL_1203: Invalid comparison between F4 and I4
		//IL_1212: Expected F8, but got I4
		//IL_126c: Expected Obj, but got I4
		//IL_1296: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Expected Obj, but got Unknown
		//IL_12d2: Expected Obj, but got I4
		//IL_1be0: Expected Obj, but got I4
		//IL_131e: Invalid comparison between F4 and I4
		//IL_132d: Invalid comparison between F4 and I4
		//IL_1345: Unknown result type (might be due to invalid IL or missing references)
		//IL_134a: Expected Obj, but got Unknown
		//IL_1359: Expected Obj, but got F4
		//IL_138e: Expected Obj, but got I4
		//IL_1396: Unknown result type (might be due to invalid IL or missing references)
		//IL_139b: Expected I4, but got Unknown
		//IL_13b0: Expected Obj, but got I
		//IL_13c5: Expected Obj, but got I
		//IL_13d4: Expected Obj, but got I4
		//IL_13dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e2: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = deploySound == null;
		bool flag3 = !flag2;
		object obj4 = 0;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v76+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = retractSound == null;
			bool flag6 = !flag5;
			obj4 = 0;
			obj5 = null;
			if (!flag6)
			{
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v80+E4]");
				bool flag7 = (nint)0 == 0;
				object obj9 = !flag7;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag8 = motorRun == null;
				bool flag9 = !flag8;
				object obj10 = !flag9;
				obj4 = 0;
				obj5 = null;
				if (obj10 != null)
				{
					return;
				}
			}
		}
		bool flag10 = mech == null;
		object obj11 = !flag10;
		if (obj11 == null)
		{
			MakeVoices();
		}
		if (phase == (Phase)1)
		{
			if (was == (Phase)1)
			{
				bool flag11 = !held;
				object obj12 = !flag11;
				object obj13 = ~obj12;
				object obj14 = ((obj13 != null) ? ((object)4294967295L) : ((object)(-4294967295L)));
				bool flag12 = (nint)obj14 == way;
				float num = dt;
				if (flag12)
				{
					goto IL_1474;
				}
			}
			if (~(held ? 1u : 0u) == 0)
			{
				float num = t;
				Mech(deploySound, t, 0f);
				float num2 = 0f;
				obj5 = deploySound;
				object obj14 = 1;
			}
			else
			{
				float num = t;
				FoldingBack(t);
				object obj14 = 4294967295L;
			}
		}
		else
		{
			bool flag13 = was != (Phase)2;
			float num = dt;
			object obj14 = 0;
			if (!flag13)
			{
				bool flag14 = phase != (Phase)3;
				num = dt;
				obj14 = 0;
				if (!flag14)
				{
					Mech(retractSound, 0f, 0f);
					num = 0f;
					float num2 = 0f;
					obj5 = retractSound;
					obj14 = 0;
				}
			}
		}
		goto IL_1474;
		IL_140f:
		throw new IndexOutOfRangeException();
		IL_1474:
		object obj15 = obj;
		object obj16 = this + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v10+E4]");
		bool flag15 = (nint)0 == 0;
		object obj17 = !flag15;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag16 = (UnityEngine.Object)obj16 != null;
		bool flag17 = !flag16;
		AudioClip audioClip = null;
		if (!flag17)
		{
			float time = Time.time;
			bool flag18 = time < mechLaterAt;
			audioClip = null;
			if (!flag18)
			{
				mechLater = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Mech(mechLater, mechLaterFrom, 0f);
				audioClip = mechLater;
			}
		}
		if (~(held ? 1u : 0u) != 0 || (phase != (Phase)2 && (phase != (Phase)1 || t < motorAt)))
		{
			if (~(motorOn ? 1u : 0u) == 0)
			{
				motorOn = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				brakeFrom = motorGain;
			}
		}
		else
		{
			bool flag19 = (byte)(~(motorOn ? 1u : 0u)) != 0;
			object obj18 = !flag19;
			if (obj18 == null)
			{
				MotorOn();
			}
		}
		bool flag20 = !motorOn;
		object obj19 = !flag20;
		object obj20 = ~obj19;
		if (obj20 == null)
		{
			object obj21 = 68;
		}
		else
		{
			object obj21 = 72;
		}
		object obj22 = !flag20;
		object obj23 = ~obj22;
		double num3 = ((obj23 != null) ? 0.0 : 1.0);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num4 = num3 - (double)motorGain;
		float num5 = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RobotSaw)+v554 @ X9_v6]");
		float num6 = num5 / 0f;
		bool flag21 = num4 < 0.0;
		object obj24 = num4 ^ num4;
		object obj25 = num4 & obj24;
		bool flag22 = (nint)obj25 < 0;
		float num7 = 0f - num6;
		bool flag23 = flag21 == flag22;
		object obj26 = !flag23;
		object obj27 = ~obj26;
		float num8 = ((obj27 != null) ? num6 : num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num9 = motorGain + num8;
		bool flag24 = num7 < num6;
		object obj28 = !flag24;
		float num10 = num7 - num6;
		bool flag25 = num10 == 0f;
		object obj29 = !flag25;
		object obj30 = obj28 & obj29;
		object obj31 = ~obj30;
		double num11 = ((obj31 != null) ? num3 : ((double)num9));
		motorGain = (float)num11;
		bool flag26 = (byte)(~(motorOn ? 1u : 0u)) != 0;
		object obj32 = !flag26;
		if (obj32 == null)
		{
			bool flag27 = num11 < 0.0;
			object obj33 = !flag27;
			bool flag28 = num11 == 0.0;
			object obj34 = !flag28;
			object obj35 = obj33 & obj34;
			if (obj35 == null)
			{
				if ((object)run != null)
				{
					bool isPlaying = run.isPlaying;
					bool flag29 = !isPlaying;
					object obj36 = !flag29;
					if (obj36 == null)
					{
						if ((object)cut == null)
						{
							goto IL_1401;
						}
						bool isPlaying2 = cut.isPlaying;
						bool flag30 = !isPlaying2;
						audioClip = null;
						if (flag30)
						{
							goto IL_1630;
						}
					}
					if ((object)run != null)
					{
						run.Stop();
						if ((object)cut != null)
						{
							cut.Stop();
							braking = false;
							audioClip = null;
							goto IL_1630;
						}
					}
				}
				goto IL_1401;
			}
		}
		goto IL_1630;
		IL_1401:
		NullReferenceException ex = new NullReferenceException();
		goto IL_140f;
		IL_0805:
		double num12;
		float num13;
		float num14;
		bool flag34;
		object obj41;
		bool flag32;
		if (~(motorOn ? 1u : 0u) == 0)
		{
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X0_v48+E4]");
			bool flag31 = (nint)0 == 0;
			object obj38 = !flag31;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag32 = motorCut != null;
			bool flag33 = !flag32;
			object obj39 = !flag33;
			object obj40 = ~obj39;
			num12 = ((obj40 != null) ? 0.0 : 1.0);
			num13 = num14;
			obj41 = 0;
		}
		else
		{
			num13 = num14;
			num12 = 0.0;
			obj41 = 0;
			flag32 = flag34;
		}
		goto IL_1668;
		IL_1630:
		object obj42 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X0_v17+E4]");
		bool flag35 = (nint)0 == 0;
		object obj43 = !flag35;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		flag34 = hits != null;
		float num15;
		if (flag34)
		{
			GillaSawHits gillaSawHits = hits;
			if ((object)hits == null)
			{
				goto IL_1401;
			}
			if (gillaSawHits.Sawing__BackingField != null)
			{
				num14 = cutMix;
				num15 = (float)num11;
				goto IL_0805;
			}
		}
		num15 = Time.time;
		num14 = cutMix;
		num9 = bitUntil;
		bool flag36 = !(num15 < bitUntil);
		num3 = 0.0;
		flag34 = false;
		num13 = cutMix;
		num12 = 0.0;
		obj41 = 0;
		flag32 = false;
		if (!flag36)
		{
			goto IL_0805;
		}
		goto IL_1668;
		IL_1668:
		double num16 = num12 - (double)num13;
		float num17 = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD38]");
		float num18 = num17 / 0f;
		bool flag37 = num16 < 0.0;
		object obj44 = num16 ^ num16;
		object obj45 = num16 & obj44;
		bool flag38 = (nint)obj45 < 0;
		float num19 = dt;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		float num20 = num19 / 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num21 = 0f - num18;
		bool flag39 = flag37 == flag38;
		object obj46 = !flag39;
		object obj47 = ~obj46;
		float num22 = ((obj47 != null) ? num18 : num21);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		bool flag40 = 0f < num18;
		object obj48 = !flag40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
		float num23 = 0f - num18;
		bool flag41 = num23 == 0f;
		float num24 = num13 + num22;
		float num25 = 0f - num20;
		object obj49 = !flag41;
		object obj50 = obj48 & obj49;
		object obj51 = ~obj50;
		double num26 = ((obj51 != null) ? num12 : ((double)num24));
		cutMix = (float)num26;
		object obj52 = 1;
		object obj53 = 0;
		object obj92 = default;
		object obj93 = default;
		while (true)
		{
			float[] array = mechGain;
			if (mechGain == null)
			{
				break;
			}
			bool flag42 = (nint)obj53 < array.Length;
			object obj54 = !flag42;
			if (obj54 == null)
			{
				float[] array2 = mechWant;
				if (mechWant == null)
				{
					break;
				}
				bool flag43 = (nint)obj53 < array2.Length;
				object obj55 = !flag43;
				if (obj55 == null)
				{
					object obj56 = (object)mechGain + obj53;
					object obj57 = (object)mechWant + obj53;
					object obj58 = obj56 + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X9_v11+20]");
					float num27 = 0f - (float)obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					bool flag44 = num27 < 0f;
					object obj59 = num27 ^ num27;
					object obj60 = num27 & obj59;
					bool flag45 = (nint)obj60 < 0;
					bool flag46 = flag44 == flag45;
					object obj61 = !flag46;
					object obj62 = ~obj61;
					float num28 = ((obj62 != null) ? num20 : num25);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
					bool flag47 = 0f < num20;
					object obj63 = !flag47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
					float num29 = 0f - num20;
					bool flag48 = num29 == 0f;
					float num30 = (float)obj58 + num28;
					object obj64 = !flag48;
					object obj65 = obj63 & obj64;
					object obj66 = ~obj65;
					if (obj66 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X9_v11+20]");
						num30 = 0f;
					}
					bool flag49 = num30 < 0f;
					object obj67 = !flag49;
					bool flag50 = num30 == 0f;
					obj58 = num30;
					object obj68 = !flag50;
					object obj69 = obj67 & obj68;
					if (obj69 == null)
					{
						AudioSource[] array3 = mech;
						if (mech == null)
						{
							break;
						}
						bool flag51 = (nint)obj53 < array3.Length;
						object obj70 = !flag51;
						if (obj70 != null)
						{
							goto IL_140f;
						}
						object obj71 = (object)mech + obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v40+20]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v40+20]");
						if (((AudioSource)0).isPlaying)
						{
							AudioSource[] array4 = mech;
							if (mech == null)
							{
								break;
							}
							bool flag52 = (nint)obj53 < array4.Length;
							object obj72 = !flag52;
							if (obj72 != null)
							{
								goto IL_140f;
							}
							object obj73 = (object)mech + obj53;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v42+20]");
							if ((nint)0 == 0)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v42+20]");
							((AudioSource)0).Stop();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v42+20]");
							flag32 = false;
						}
					}
					object obj74 = obj52 & 1;
					bool flag53 = obj74 == null;
					object obj75 = !flag53;
					obj52 = 0;
					obj53 = 1;
					if (obj75 != null)
					{
						continue;
					}
					float time2 = Time.time;
					if (!(time2 < nextHear))
					{
						float time3 = Time.time;
						float num31 = time3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
						float num32 = num31 + 0f;
						nextHear = num32;
						Hear();
					}
					bool flag54 = voicesForDemo;
					float num33 = dt;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					float num34 = num33 / 0f;
					float num35 = heardTo - heard;
					float num36 = muffleTo - muffle;
					bool flag55 = num35 < 0f;
					object obj76 = num35 ^ num35;
					object obj77 = num35 & obj76;
					bool flag56 = (nint)obj77 < 0;
					float num37 = 0f - num34;
					bool flag57 = flag55 == flag56;
					object obj78 = !flag57;
					object obj79 = ~obj78;
					float num38 = ((obj79 != null) ? num34 : num37);
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					float num39 = heard + num38;
					bool flag58 = num37 < num34;
					object obj80 = !flag58;
					float num40 = num37 - num34;
					bool flag59 = num40 == 0f;
					float num41 = dt * 4f;
					float num42 = dt * 4f;
					float num43 = 0f - num42;
					object obj81 = !flag59;
					object obj82 = obj80 & obj81;
					object obj83 = ~obj82;
					float num44 = ((obj83 != null) ? heardTo : num39);
					bool flag60 = num36 < 0f;
					object obj84 = num36 ^ num36;
					object obj85 = num36 & obj84;
					bool flag61 = (nint)obj85 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
					bool flag62 = flag60 == flag61;
					object obj86 = !flag62;
					object obj87 = ~obj86;
					float num45 = ((obj87 != null) ? num41 : num43);
					bool flag63 = heardTo < num41;
					object obj88 = !flag63;
					float num46 = heardTo - num41;
					bool flag64 = num46 == 0f;
					heard = num44;
					float num47 = muffle + num45;
					object obj89 = !flag64;
					object obj90 = obj88 & obj89;
					object obj91 = ~obj90;
					float num48 = ((obj91 != null) ? muffleTo : num47);
					bool flag65 = flag54 == demo;
					muffle = num48;
					if (!flag65)
					{
						Reach();
						flag54 = demo;
						num44 = heard;
					}
					double num49 = ((!flag54) ? 1.0 : ((double)demoVolume));
					bool flag66 = muffle < 0f;
					double num50 = 0.0;
					if (!flag66)
					{
						bool flag67 = !((double)muffle > 1.0);
						num50 = muffle;
						if (!flag67)
						{
							num50 = 1.0;
						}
					}
					float num51 = cutMix;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE64]");
					float num52 = num51 * 0f;
					double num53 = (double)num52 * 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D0E0");
					AudioSource[] array5 = mech;
					if (mech == null)
					{
						break;
					}
					float[] array6 = mechGain;
					if (mechGain == null || (object)array5[0] == null)
					{
						break;
					}
					double num54 = num50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AB90]");
					double num55 = num54 * 0.0;
					double num56 = num55 + 1.0;
					float num57 = num44 * (float)num49;
					float num58 = num57 * (float)num56;
					float num59 = num58 * mechVolume;
					float volume = num59 * array6[0];
					array5[0].volume = volume;
					AudioSource[] array7 = mech;
					if (mech == null)
					{
						break;
					}
					float[] array8 = mechGain;
					if (mechGain == null || (object)array7[1] == null)
					{
						break;
					}
					float num60 = num58 * mechVolume;
					float volume2 = num60 * array8[1];
					array7[1].volume = volume2;
					if ((object)run == null)
					{
						break;
					}
					float num61 = num58 * motorVolume;
					float num62 = motorGain * num61;
					float volume3 = (float)obj92 * num62;
					run.volume = volume3;
					if ((object)cut == null)
					{
						break;
					}
					float num63 = num58 * motorVolume;
					float num64 = motorGain * num63;
					float volume4 = (float)obj93 * num64;
					cut.volume = volume4;
					double num69;
					if (~(braking ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
						float num65 = motorGain / brakeFrom;
						bool flag68 = num65 < 0f;
						double num66 = 0.0;
						if (!flag68)
						{
							bool flag69 = !((double)num65 > 1.0);
							num66 = num65;
							if (!flag69)
							{
								num66 = 1.0;
							}
						}
						double num67 = 1.0 - (double)brakePitch;
						double num68 = num67 * num66;
						num69 = (double)brakePitch + num68;
					}
					else
					{
						num69 = 1.0;
					}
					if ((object)run == null)
					{
						break;
					}
					run.pitch = (float)num69;
					bool flag70 = (byte)(~(braking ? 1u : 0u)) != 0;
					object obj94 = !flag70;
					if (obj94 == null)
					{
						float time4 = Time.time;
						float num70 = time4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A89C]");
						float x = num70 * 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA1C]");
						float num71 = Mathf.PerlinNoise(x, 0f);
						float num72 = num71 + -0.5f;
						float num73 = num72;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFD4]");
						float num74 = num73 * 0f;
						num69 = (double)num74 + 1.0;
					}
					if ((object)cut == null)
					{
						break;
					}
					cut.pitch = (float)num69;
					bool flag71 = muffle < 0f;
					double num75 = 0.0;
					if (!flag71)
					{
						bool flag72 = !((double)muffle > 1.0);
						num75 = muffle;
						if (!flag72)
						{
							num75 = 1.0;
						}
					}
					AudioLowPassFilter[] array9 = lows;
					if (lows == null)
					{
						break;
					}
					object obj95 = array9.Length;
					if (array9.Length < 1)
					{
						return;
					}
					object obj96 = lows + 32;
					double num76 = num75;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A934]");
					double num77 = num76 * 0.0;
					double num78 = num77;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA20]");
					double num79 = num78 + 0.0;
					object obj97 = 0;
					while (true)
					{
						bool flag73 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj97) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj95);
						object obj98 = !flag73;
						if (obj98 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X23_v3+v859 @ X22_v6*8]");
						if ((nint)0 == 0)
						{
							goto end_IL_18c2;
						}
						float num80 = muffle;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
						float num81 = num80 - 0f;
						bool flag74 = num81 < 0f;
						bool flag75 = num81 == 0f;
						float num82 = muffle;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AC34]");
						object obj99 = num82 ^ 0;
						object obj100 = muffle ^ num81;
						object obj101 = obj99 & obj100;
						bool flag76 = (nint)obj101 < 0;
						bool flag77 = flag74 == flag76;
						object obj102 = !flag75;
						bool flag78 = (byte)((flag77 & obj102) ? 1 : 0) != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X23_v3+v859 @ X22_v6*8]");
						((Behaviour)0).enabled = flag78;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X23_v3+v859 @ X22_v6*8]");
						((AudioLowPassFilter)0).cutoffFrequency = (float)num79;
						obj95 = array9.Length;
						obj97++;
						if ((nint)obj97 >= array9.Length)
						{
							return;
						}
					}
				}
			}
			goto IL_140f;
			continue;
			end_IL_18c2:
			break;
		}
		goto IL_1401;
	}

	private void FoldingBack(float from)
	{
		//IL_004d: Expected Obj, but got I4
		//IL_0067: Invalid comparison between F4 and I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num = from;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		float num2 = num / 0f;
		float num3 = deployFrames * num2;
		bool flag = num3 < foldFrom;
		object obj = !flag;
		float num4 = num3 - foldFrom;
		bool flag2 = num4 == 0f;
		object obj2 = ~obj;
		object obj3 = obj2 | flag2;
		if (obj3 == null)
		{
			float num5 = num3 - foldFrom;
			float num6 = num5 / deployFrames;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			float num7 = deploySeconds * num6;
			float delay = num7 / foldBackSpeed;
			Mech(retractSound, foldStarts, delay);
		}
		else
		{
			float num8 = num3 / foldFrom;
			double num9 = 1.0 - (double)num8;
			double num10 = num9 * (double)foldSeconds;
			float num11 = foldStarts + (float)num10;
			Mech(retractSound, num11, 0f);
		}
	}

	private void Mech(AudioClip clip, float from, float delay)
	{
		//IL_0022: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got I4
		//IL_014d: Invalid comparison between F4 and I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0180: Invalid comparison between F4 and I4
		//IL_023f: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0292: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02b5: Invalid comparison between F4 and I4
		//IL_03d8: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I4
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0359: Expected Obj, but got I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		float[] array = mechWant;
		if (mechWant != null)
		{
			bool flag = mechNow < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0391;
			}
			object obj2 = mechWant + mechNow;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
			object obj3 = 0;
			object obj4 = this + 200;
			obj4 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = clip == null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 != null)
			{
				return;
			}
			if ((object)clip != null)
			{
				float length = clip.length;
				float num = default;
				bool flag5 = length < num;
				object obj8 = !flag5;
				float num2 = length - num;
				bool flag6 = num2 == 0f;
				object obj9 = ~obj8;
				object obj10 = obj9 | flag6;
				if (obj10 != null)
				{
					return;
				}
				if (delay > 0f)
				{
					mechLater = clip;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					mechLaterFrom = num;
					float time = Time.time;
					float num3 = time + delay;
					mechLaterAt = num3;
					return;
				}
				AudioSource[] array2 = mech;
				int num4 = (mechNow = 1 - mechNow);
				if (mech != null)
				{
					bool flag7 = num4 < array2.Length;
					object obj11 = !flag7;
					if (obj11 != null)
					{
						goto IL_0391;
					}
					object obj12 = mech + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v10+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v10+20]");
						((AudioSource)0).Stop();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v10+20]");
						((AudioSource)0).clip = clip;
						if (num < 0f)
						{
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v10+20]");
						((AudioSource)0).time = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v10+20]");
						((AudioSource)0).Play();
						float[] array3 = mechWant;
						if (mechWant != null)
						{
							bool flag8 = mechNow < array3.Length;
							object obj13 = !flag8;
							if (obj13 == null)
							{
								float[] array4 = mechGain;
								object obj14 = mechWant + mechNow;
								_ = 1065353216;
								if (mechGain == null)
								{
									goto IL_0383;
								}
								bool flag9 = mechNow < array4.Length;
								object obj15 = !flag9;
								if (obj15 == null)
								{
									object obj16 = mechGain + mechNow;
									_ = 1065353216;
									return;
								}
							}
							goto IL_0391;
						}
					}
				}
			}
		}
		goto IL_0383;
		IL_0391:
		throw new IndexOutOfRangeException();
		IL_0383:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0391;
	}

	private void MotorOn()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0095: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = motorRun == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		motorOn = true;
		bool isPlaying = run.isPlaying;
		bool flag4 = !isPlaying;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			run.clip = motorRun;
			float length = motorRun.length;
			float num = length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA98]");
			float maxInclusive = num * 0f;
			float time = UnityEngine.Random.Range(0f, maxInclusive);
			run.time = time;
			run.Play();
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (!(motorCut == null))
			{
				cut.clip = motorCut;
				float length2 = motorCut.length;
				float num2 = length2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA98]");
				float maxInclusive2 = num2 * 0f;
				float time2 = UnityEngine.Random.Range(0f, maxInclusive2);
				cut.time = time2;
				cut.Play();
			}
		}
	}

	private void MotorOff()
	{
		motorOn = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		brakeFrom = motorGain;
	}

	private void Hush()
	{
		//IL_0033: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_01fe: Expected Obj, but got I4
		//IL_0162: Expected F4, but got I4
		//IL_00a6: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0194: Expected F4, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		AudioSource[] array = mech;
		if (mech == null)
		{
			return;
		}
		object obj = array.Length;
		if (array.Length < 1)
		{
			goto IL_00dc;
		}
		object obj2 = mech + 32;
		object obj3 = 0;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			object obj4 = !flag;
			if (obj4 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X22_v6+v140 @ X21_v7*8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X22_v6+v140 @ X21_v7*8]");
				((AudioSource)0).Stop();
				obj = array.Length;
				obj3++;
				if ((nint)obj3 < array.Length)
				{
					continue;
				}
				goto IL_00dc;
			}
			goto IL_01cf;
		}
		goto IL_01dd;
		IL_01cf:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01dd;
		IL_01dd:
		throw new IndexOutOfRangeException();
		IL_00dc:
		if ((object)run != null)
		{
			run.Stop();
			if ((object)cut != null)
			{
				cut.Stop();
				if (mechWant != null)
				{
					float[] array2 = default;
					array2[0] = 0f;
					if (mechGain != null)
					{
						float[] array3 = default;
						array3[0] = 0f;
						object obj5 = this + 200;
						obj5 = 0;
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						_ = 0;
						return;
					}
				}
			}
		}
		goto IL_01cf;
	}

	private unsafe void MakeVoices()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0a9c: Expected Obj, but got Ref
		//IL_0ad0: Expected Obj, but got I4
		//IL_0aee: Expected Obj, but got I
		//IL_0b08: Expected Obj, but got I4
		//IL_0c68: Expected Obj, but got I4
		//IL_0ba0: Expected Obj, but got I
		//IL_0bc2: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I
		//IL_05d7: Expected VT, but got Obj
		//IL_05e0: Expected Obj, but got I4
		//IL_00b1: Expected F4, but got I
		//IL_00c5: Expected Obj, but got I8
		//IL_07b0: Expected Obj, but got I
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected Obj, but got Unknown
		//IL_07e5: Expected Obj, but got I4
		//IL_0812: Expected Obj, but got I
		//IL_0822: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I
		//IL_05fe: Expected Obj, but got I
		//IL_060e: Expected Obj, but got I
		//IL_0617: Expected Obj, but got I4
		//IL_041b: Expected F4, but got I
		//IL_042f: Expected Obj, but got I8
		//IL_0115: Expected F4, but got I
		//IL_0115: Expected F4, but got I
		//IL_0131: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected Obj, but got Unknown
		//IL_0c38: Expected Obj, but got I4
		//IL_086d: Expected Obj, but got I
		//IL_047c: Expected F4, but got I
		//IL_0498: Expected Obj, but got I4
		//IL_04a8: Expected Obj, but got I4
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_01a7: Expected F4, but got I
		//IL_01a7: Expected F4, but got I
		//IL_01bb: Expected Obj, but got I8
		//IL_0647: Expected Obj, but got I
		//IL_04f1: Expected Obj, but got I
		//IL_020b: Expected F4, but got I
		//IL_020b: Expected F4, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_091c: Expected Obj, but got I
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_067b: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I4
		//IL_0977: Expected Obj, but got I8
		//IL_0782: Expected VT, but got I
		//IL_078b: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I
		//IL_0be6: Expected Obj, but got I
		//IL_0c01: Expected Obj, but got I4
		//IL_0c11: Expected F4, but got I
		//IL_0c1a: Expected Obj, but got I4
		//IL_02af: Expected Obj, but got I4
		//IL_02bf: Expected Obj, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_069a: Expected Obj, but got I
		//IL_09a4: Expected Obj, but got I
		//IL_09b4: Expected Obj, but got I
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected Obj, but got Unknown
		//IL_06cb: Expected VT, but got Obj
		//IL_0308: Expected Obj, but got I
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_0720: Expected Obj, but got I
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_074c: Expected Obj, but got VT
		//IL_035a: Expected Obj, but got I4
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected Obj, but got Unknown
		//IL_06fb: Expected VT, but got I
		//IL_070b: Expected Obj, but got I
		//IL_0b2b: Expected Obj, but got I
		//IL_0b56: Expected Obj, but got I4
		//IL_0b5f: Expected VT, but got I4
		//IL_0b68: Expected VT, but got I4
		//IL_0b71: Expected VT, but got I4
		//IL_0b7a: Expected F4, but got I4
		//IL_0b83: Expected Obj, but got I4
		//IL_0763: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
		object obj = 0;
		Transform transform = default;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref transform, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v7+A0]");
		object obj5 = 0;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		RobotSaw robotSaw = this;
		Keyframe keyframe2;
		Keyframe keyframe3;
		Keyframe keyframe;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
			keyframe = new Keyframe(0f, 1f);
			Keyframe[] array = default;
			if (array.Length != 0)
			{
				_ = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A8D4]");
				keyframe2 = new Keyframe(0f, 1f);
				object obj8 = array.Length & 0xFFFFFFFEL;
				if (obj8 != null)
				{
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEBC]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
					keyframe3 = new Keyframe(num, 0f);
					bool flag3 = array.Length < 2;
					object obj9 = !flag3;
					object obj10 = array.Length - 2;
					bool flag4 = obj10 == null;
					object obj11 = ~obj9;
					object obj12 = obj11 | flag4;
					if (obj12 == null)
					{
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AF0C]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA94]");
						Keyframe keyframe4 = new Keyframe(num2, 0f);
						object obj13 = array.Length & 0xFFFFFFFCL;
						if (obj13 != null)
						{
							_ = 0;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A83C]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107B008]");
							Keyframe keyframe5 = new Keyframe(num3, 0f);
							bool flag5 = array.Length < 4;
							object obj14 = !flag5;
							object obj15 = array.Length - 4;
							bool flag6 = obj15 == null;
							object obj16 = ~obj14;
							object obj17 = obj16 | flag6;
							if (obj17 == null)
							{
								_ = 0;
								_ = 0;
								_ = 0;
								Keyframe keyframe6 = new Keyframe(1f, 0f);
								bool flag7 = array.Length < 5;
								object obj18 = !flag7;
								object obj19 = array.Length - 5;
								bool flag8 = obj19 == null;
								object obj20 = ~obj18;
								object obj21 = obj20 | flag8;
								if (obj21 == null)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
									object obj22 = 0;
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
									AnimationCurve animationCurve = default;
									animationCurve._002Ector(array);
									object obj23 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X0_v99+E4]");
									bool flag9 = (nint)0 == 0;
									object obj24 = !flag9;
									if (obj24 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										obj23 = obj;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X0_v99+A0]");
									object obj25 = 0;
									obj25 = animationCurve;
									object obj26 = obj;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									obj3 = obj;
									object obj27 = 0;
									keyframe3 = (Keyframe)0;
									keyframe2 = (Keyframe)0;
									keyframe = (Keyframe)0;
									float num4 = 0f;
									object obj28 = 0;
									robotSaw = (RobotSaw)(object)animationCurve;
									goto IL_0c46;
								}
							}
						}
					}
				}
			}
			goto IL_0a79;
		}
		goto IL_0c46;
		IL_07a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj29 = 0;
		object obj30 = this + 216;
		object obj31 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X0_v16+E4]");
		bool flag10 = (nint)0 == 0;
		object obj32 = !flag10;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD28]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4348]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD48]");
		object obj35 = 0;
		if ((UnityEngine.Object)obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD30]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			GillaSawHits gillaSawHits = default;
			hits = gillaSawHits;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj37 = this + 128;
		object obj38 = default;
		obj37 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		_003C_003Ec__DisplayClass63_0 obj39;
		AudioSource audioSource = _003CMakeVoices_003Eg__Voice_007C63_0((string)obj35, false, 100, ref obj39);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X0_v27+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD38]");
			object obj40 = 0;
			object obj42 = default;
			object obj41 = obj42 + 32;
			obj41 = audioSource;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			AudioSource audioSource2 = _003CMakeVoices_003Eg__Voice_007C63_0((string)obj40, false, 100, ref obj39);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X21_v6-8]");
			object obj43 = 0 & 0xFFFFFFFEL;
			if (obj43 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD40]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD50]");
				object obj45 = 0;
				object obj46 = obj42 + 40;
				obj46 = audioSource2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				object obj47 = this + 104;
				obj47 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				AudioSource audioSource3 = _003CMakeVoices_003Eg__Voice_007C63_0((string)obj44, true, 64, ref obj39);
				object obj48 = this + 112;
				obj48 = audioSource3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				AudioSource audioSource4 = _003CMakeVoices_003Eg__Voice_007C63_0((string)obj45, true, 64, ref obj39);
				object obj49 = this + 120;
				obj49 = audioSource4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Reach();
				return;
			}
		}
		goto IL_0a79;
		IL_0768:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v23+20]");
		obj39 = (_003C_003Ec__DisplayClass63_0)0;
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v23+20]");
		UnityEngine.Object obj51 = (UnityEngine.Object)0;
		goto IL_07a0;
		IL_075a:
		obj50 = 0;
		goto IL_07a0;
		IL_0a79:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0568:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
		object obj52 = 0;
		Transform transform2 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		obj50 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v14+18]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v14+18]");
		bool flag11 = (nint)0 < (nint)1;
		obj39 = (_003C_003Ec__DisplayClass63_0)transform2;
		obj51 = (UnityEngine.Object)1;
		if (flag11)
		{
			goto IL_07a0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6DB0]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
		object obj55 = 0;
		object obj56 = 0;
		transform = transform2;
		object obj59 = default;
		while (true)
		{
			bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj56) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53);
			object obj57 = !flag12;
			if (obj57 != null)
			{
				break;
			}
			object obj58 = obj59 + obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v23+20]");
			string text = ((UnityEngine.Object)0).name;
			bool flag13 = text == (string)obj54;
			bool flag14 = !flag13;
			object obj60 = !flag14;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v23+20]");
				string text2 = ((UnityEngine.Object)0).name;
				bool flag15 = text2 == (string)obj55;
				bool flag16 = !flag15;
				obj39 = (_003C_003Ec__DisplayClass63_0)transform;
				obj51 = (UnityEngine.Object)obj55;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v23+20]");
					obj39 = (_003C_003Ec__DisplayClass63_0)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v23+20]");
					obj51 = (UnityEngine.Object)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v14+18]");
				obj53 = 0;
				obj56++;
				object obj61 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v14+18]");
				bool flag17 = (nint)obj61 < 0;
				transform = (Transform)obj39;
				if (flag17)
				{
					continue;
				}
				goto IL_075a;
			}
			goto IL_0768;
		}
		goto IL_0a79;
		IL_0c46:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v7+E4]");
		bool flag18 = (nint)0 == 0;
		object obj62 = !flag18;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v7+A0]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v9+8]");
		bool flag19 = (nint)0 == 0;
		object obj64 = !flag19;
		if (obj64 != null)
		{
			goto IL_0568;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4CA8]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		keyframe = new Keyframe(0f, 1f);
		Keyframe[] array2 = default;
		if (array2.Length != 0)
		{
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
			keyframe2 = new Keyframe(0.25f, 0f);
			object obj66 = array2.Length & 0xFFFFFFFEL;
			if (obj66 != null)
			{
				_ = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
				keyframe3 = new Keyframe(1f, 0f);
				bool flag20 = array2.Length < 2;
				object obj67 = !flag20;
				object obj68 = array2.Length - 2;
				bool flag21 = obj68 == null;
				object obj69 = ~obj67;
				object obj70 = obj69 | flag21;
				if (obj70 == null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4C98]");
					object obj71 = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
					AnimationCurve animationCurve2 = default;
					animationCurve2._002Ector(array2);
					object obj72 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v76+E4]");
					bool flag22 = (nint)0 == 0;
					object obj73 = !flag22;
					if (obj73 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj72 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v76+A0]");
					object obj74 = (nint)0 + (nint)8;
					obj74 = animationCurve2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA40]");
					float num4 = 0f;
					object obj28 = 0;
					goto IL_0568;
				}
			}
		}
		goto IL_0a79;
	}

	private void Reach()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I8
		//IL_00dd: Expected Obj, but got I8
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I8
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_02df: Expected F4, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4348]");
		object obj = 0;
		voicesForDemo = demo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		AudioSource[] array = mech;
		if (array.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
			if ((nint)0 != 0)
			{
				object obj3 = default;
				object obj2 = obj3 + 32;
				obj2 = array[0];
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				AudioSource[] array2 = mech;
				object obj4 = array2.Length & 0xFFFFFFFEL;
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
					object obj5 = 0 & 0xFFFFFFFEL;
					if (obj5 != null)
					{
						object obj6 = obj3 + 40;
						obj6 = array2[1];
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X21_v5-10]");
						bool flag = (nint)0 < (nint)2;
						object obj7 = !flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X21_v5-10]");
						object obj8 = -2;
						bool flag2 = obj8 == null;
						object obj9 = ~obj7;
						object obj10 = obj9 | flag2;
						if (obj10 == null)
						{
							object obj11 = obj3 + 48;
							obj11 = run;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X21_v7-18]");
							object obj12 = 0 & 0xFFFFFFFCL;
							if (obj12 != null)
							{
								object obj13 = obj3 + 56;
								obj13 = cut;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X21_v9-20]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X21_v9-20]");
								if ((nint)0 < (nint)1)
								{
									return;
								}
								object obj15 = obj3 + 32;
								object obj16 = 0;
								while (true)
								{
									bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
									object obj17 = !flag3;
									if (obj17 != null)
									{
										break;
									}
									if (!demo)
									{
										object obj18 = 88;
									}
									else
									{
										object obj18 = 96;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v5+v131 @ X21_v13*8]");
									nint num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RobotSaw)+v280 @ X8_v14]");
									((AudioSource)num).maxDistance = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
									obj14 = 0;
									obj16++;
									object obj19 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+18]");
									if ((nint)obj19 >= 0)
									{
										return;
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

	private unsafe void Hear()
	{
		//IL_0010: Expected Obj, but got I
		//IL_05db: Expected Obj, but got I
		//IL_05fd: Expected Obj, but got I4
		//IL_07b0: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_0636: Expected Obj, but got I
		//IL_061b: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I4
		//IL_0200: Expected VT, but got I4
		//IL_0250: Expected Obj, but got I4
		//IL_0665: Expected Obj, but got I
		//IL_0687: Expected Obj, but got I4
		//IL_0296: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I4
		//IL_06a6: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_0342: Expected VT, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_0383: Expected Obj, but got I
		//IL_03ad: Expected Obj, but got I4
		//IL_03d9: Expected VT, but got I4
		//IL_03d9: Expected VT, but got I4
		//IL_047f: Invalid comparison between Obj and F8
		//IL_06bb: Expected Obj, but got I
		//IL_06db: Expected Obj, but got I
		//IL_06f8: Expected Obj, but got I
		//IL_0715: Expected Obj, but got I
		//IL_0732: Expected Obj, but got I
		//IL_077b: Expected Obj, but got I4
		//IL_04e0: Expected VT, but got Obj
		//IL_04e0: Expected VT, but got Ref
		//IL_04fe: Expected Obj, but got I4
		//IL_0543: Expected Obj, but got I4
		//IL_056e: Expected VT, but got Obj
		//IL_056e: Expected VT, but got Ref
		//IL_058c: Expected Obj, but got I4
		//IL_05be: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+A0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v1+10]");
		bool flag3 = (UnityEngine.Object)0 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		UnityEngine.Object obj9 = null;
		if (obj8 == null)
		{
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v73+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v73+A0]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v33+10]");
			bool flag6 = ((Behaviour)0).isActiveAndEnabled;
			bool flag7 = !flag6;
			object obj13 = !flag7;
			obj9 = null;
			if (obj13 != null)
			{
				goto IL_01bf;
			}
		}
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C43B0]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v61+E4]");
		bool flag8 = (nint)0 == 0;
		object obj16 = !flag8;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36DD36C");
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v30+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v30+A0]");
		object obj19 = (nint)0 + (nint)16;
		object obj20 = default;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		goto IL_01bf;
		IL_01bf:
		Transform transform = run.transform;
		Vector3 position = transform.position;
		heardTo = 1f;
		muffleTo = 0f;
		if (GillaBackroomsSwitch.OnYourSide((Vector3)0))
		{
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v18+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj;
			}
			object obj23 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v18+A0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v11+E4]");
			bool flag11 = (nint)0 == 0;
			object obj25 = !flag11;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X9_v6+10]");
			bool flag12 = (UnityEngine.Object)0 == null;
			bool flag13 = !flag12;
			object obj26 = !flag13;
			if (obj26 != null)
			{
				return;
			}
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v23+E4]");
			bool flag14 = (nint)0 == 0;
			object obj28 = !flag14;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj27 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v23+A0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v13+10]");
			Transform transform2 = ((Component)0).transform;
			Vector3 position2 = transform2.position;
			bool flag15 = ShopRooms.Holds((Vector3)0);
			bool flag16 = !flag15;
			object obj30 = !flag16;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CC8E8]");
				object obj31 = 0;
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v29+E4]");
				bool flag17 = (nint)0 == 0;
				object obj33 = !flag17;
				if (obj33 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!MonsterDread.ShutOut((Vector3)0, (Vector3)0))
				{
					object obj35 = default;
					object obj34 = obj35 - obj35;
					object obj37 = default;
					object obj36 = obj37 - obj37;
					object obj39 = default;
					object obj38 = obj39 - obj39;
					object obj40 = obj34 * obj34;
					object obj41 = obj36 * obj36;
					object obj42 = obj40 + obj41;
					object obj43 = obj38 * obj38;
					object obj44 = obj43 + obj42;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1.0))
					{
						return;
					}
					Transform transform3 = base.transform;
					Transform root = transform3.root;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4148]");
					object obj45 = 0;
					object obj46 = obj;
					object obj47 = obj45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v21+A0]");
					object obj48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v22+18]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					object obj49 = num * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v22+1C]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					object obj50 = num2 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v22+20]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ADFC]");
					object obj51 = num3 * 0;
					object obj52 = obj35 + obj49;
					object obj53 = obj37 + obj50;
					object obj54 = obj39 + obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X0_v39+E4]");
					bool flag18 = (nint)0 == 0;
					object obj55 = !flag18;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Transform transform4 = default;
					bool flag19 = _003CHear_003Eg__Blocked_007C65_0((Vector3)(&transform4), (Vector3)root, ref *(NameTitles._003C_003Ec__DisplayClass65_0*)null);
					bool flag20 = !flag19;
					object obj56 = !flag20;
					double num4 = 1.0;
					if (obj56 == null)
					{
						object obj57 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v44+E4]");
						bool flag21 = (nint)0 == 0;
						object obj58 = !flag21;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag22 = _003CHear_003Eg__Blocked_007C65_0((Vector3)(&transform4), (Vector3)root, ref *(NameTitles._003C_003Ec__DisplayClass65_0*)null);
						bool flag23 = !flag22;
						object obj59 = !flag23;
						object obj60 = ~obj59;
						num4 = ((obj60 != null) ? 0.0 : 1.0);
					}
					muffleTo = (float)num4;
					return;
				}
			}
		}
		heardTo = 0f;
	}

	private static void ResetStatics()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0056: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
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
		_ = 3212836864L;
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_04fb: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_0519: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I
		//IL_015b: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I
		//IL_030f: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_0559: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I
		//IL_0424: Expected Obj, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0471: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = this + 224;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = (UnityEngine.Object)obj3 == null;
		bool flag3 = !flag2;
		UnityEngine.Object obj5 = null;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD68]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
			UnityEngine.Object obj7 = default;
			animator = (Animator)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			obj5 = obj7;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = (UnityEngine.Object)obj3 != null;
		bool flag6 = !flag5;
		object obj10 = 0;
		if (!flag6)
		{
			if (obj3 == null)
			{
				goto IL_04b1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD80]");
			object layerName = 0;
			int layerIndex = ((Animator)obj3).GetLayerIndex((string)layerName);
			layer = layerIndex;
			obj10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD70]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F73C");
		object obj12 = default;
		if (obj12 == null)
		{
			goto IL_04b1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v13+18]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v13+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0278;
		}
		object obj14 = 0;
		while (true)
		{
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
			object obj15 = !flag7;
			if (obj15 != null)
			{
				break;
			}
			object obj16 = obj12 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v20+20]");
			HandPoser handPoser = (HandPoser)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v20+20]");
			if ((nint)0 != 0)
			{
				if (handPoser.node == (XRNode)5)
				{
					object obj17 = this + 304;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v20+20]");
					hand = (HandPoser)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v13+18]");
				obj13 = 0;
				obj14++;
				object obj18 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v13+18]");
				if ((nint)obj18 < 0)
				{
					continue;
				}
				goto IL_0278;
			}
			goto IL_04b1;
		}
		goto IL_04bf;
		IL_04bf:
		throw new IndexOutOfRangeException();
		IL_0278:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F3AC");
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD30]");
		object obj22 = 0;
		UnityEngine.Object obj23 = default;
		bool flag9 = obj23 != null;
		bool flag10 = !flag9;
		object obj24 = 0;
		if (!flag10)
		{
			if ((object)obj23 == null)
			{
				goto IL_04b1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v16 (UnityEngine.Object)+60]");
			bool flag11 = (nint)0 == 0;
			obj24 = 0;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
				object obj25 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v16+E4]");
				bool flag12 = (nint)0 == 0;
				object obj26 = !flag12;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object obj27 = default;
				bool flag13 = obj27 == null;
				bool flag14 = !flag13;
				obj24 = 0;
				if (!flag14)
				{
					GameObject gameObject = base.gameObject;
					if ((object)gameObject != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD78]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
						object obj29 = default;
						if (obj29 != null)
						{
							object obj30 = obj29 + 32;
							obj30 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							obj24 = 0;
							goto IL_0476;
						}
					}
					goto IL_04b1;
				}
			}
		}
		goto IL_0476;
		IL_0476:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358EE20");
		object obj31 = this + 216;
		object obj32 = default;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		int frameCount = Time.frameCount;
		return;
		IL_04b1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04bf;
	}

	private void OnEnable()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		object obj = this + 284;
		playing = 0;
		held = false;
		obj = 0;
	}

	private float Trigger()
	{
		//IL_0010: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I4
		//IL_02c6: Expected Obj, but got I
		//IL_02d6: Expected F4, but got I
		//IL_0181: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_01c1: Expected F4, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I4
		//IL_0245: Expected F4, but got I4
		//IL_0098: Invalid comparison between F4 and I4
		//IL_00a7: Expected F4, but got I4
		//IL_0128: Invalid comparison between F4 and I
		//IL_015a: Expected F4, but got I4
		//IL_00f3: Invalid comparison between F4 and I
		//IL_010a: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
		float result = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
		if ((nint)0 < (nint)0)
		{
			if (~(demo ? 1u : 0u) == 0)
			{
				float time = Time.time;
				float num = time * 0.125f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
				float num2 = num * -8f;
				float num3 = time + num2;
				bool flag2 = num3 < 0f;
				result = 0f;
				if (!flag2)
				{
					bool flag3 = (double)num3 > 8.0;
					float num4 = 8f;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA48]");
						bool flag4 = num3 < 0f;
						num4 = num3;
						result = 0f;
						if (flag4)
						{
							goto IL_02ac;
						}
					}
					float num5 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA64]");
					result = ((!(num5 < 0f)) ? 0f : 1f);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag6 = hand != null;
				bool flag7 = !flag6;
				result = 0f;
				if (!flag7)
				{
					HandPoser handPoser = hand;
					result = handPoser.trigger;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag8 = (nint)0 == 0;
			object obj8 = !flag8;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v7+A0]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v8+20]");
				result = 0f;
			}
		}
		goto IL_02ac;
		IL_02ac:
		return result;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0070: Expected I4, but got I8
		//IL_008a: Expected Obj, but got I4
		//IL_0128: Invalid comparison between F4 and I4
		//IL_0137: Invalid comparison between F4 and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015f: Expected Obj, but got F4
		//IL_0194: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected I4, but got Unknown
		//IL_01c1: Invalid comparison between F4 and I4
		//IL_01d0: Invalid comparison between F4 and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got F4
		//IL_022d: Expected Obj, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected I4, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Obj, but got Unknown
		//IL_06c2: Expected Obj, but got I4
		//IL_0488: Invalid comparison between F4 and I4
		//IL_0497: Expected F4, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_05bc: Invalid comparison between F4 and I4
		//IL_05cb: Expected F8, but got I4
		//IL_02bf: Expected Obj, but got I4
		//IL_03e3: Expected F8, but got I4
		//IL_0532: Invalid comparison between F4 and I4
		//IL_0541: Expected F4, but got I4
		//IL_02fd: Invalid comparison between F4 and I4
		//IL_030e: Expected Obj, but got I4
		//IL_0317: Invalid comparison between F4 and I4
		//IL_0328: Expected Obj, but got I4
		//IL_0632: Expected Obj, but got I4
		//IL_064c: Invalid comparison between F8 and I4
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0357: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = animator == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		int num = (int)(layer & 0x80000000L);
		bool flag4 = num == 0;
		object obj5 = !flag4;
		if (obj5 != null || !animator.isActiveAndEnabled || !animator.isInitialized)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		float num2 = Trigger();
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		float num4 = num3 - 0f;
		bool flag5 = num4 < 0f;
		bool flag6 = num4 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
		object obj6 = num2 ^ 0;
		object obj7 = num2 ^ num4;
		object obj8 = obj6 & obj7;
		bool flag7 = (nint)obj8 < 0;
		bool flag8 = flag5 == flag7;
		object obj9 = !flag6;
		bool flag9 = (byte)((flag8 & obj9) ? 1 : 0) != 0;
		float num5 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		float num6 = num5 - 0f;
		bool flag10 = num6 < 0f;
		bool flag11 = num6 == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AD00]");
		object obj10 = num2 ^ 0;
		object obj11 = num2 ^ num6;
		object obj12 = obj10 & obj11;
		bool flag12 = (nint)obj12 < 0;
		bool flag13 = flag10 == flag12;
		object obj13 = !flag11;
		bool flag14 = (byte)((flag13 & obj13) ? 1 : 0) != 0;
		bool flag15 = (held = (held ? flag14 : flag9));
		float num14;
		object obj20;
		object obj19;
		if (phase <= (Phase)1)
		{
			if (phase != 0)
			{
				if (phase == (Phase)1)
				{
					bool flag16 = !flag15;
					object obj14 = !flag16;
					float num7 = deltaTime;
					if (obj14 == null)
					{
						float num8 = deltaTime * foldBackSpeed;
						num7 = 0f - num8;
					}
					float num9 = (t += num7);
					if (!(num9 < deploySeconds))
					{
						float num10 = num9 - deploySeconds;
						float num11 = num10 / spinSeconds;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
						float num12 = spinSeconds * num11;
						float num13 = num10 - num12;
						bool flag17 = num13 < 0f;
						num14 = 0f;
						if (!flag17)
						{
							bool flag18 = !(num13 > spinSeconds);
							num14 = num13;
							if (!flag18)
							{
								num14 = spinSeconds;
							}
						}
						phase = (Phase)2;
						goto IL_07dd;
					}
					bool flag19 = num9 < 0f;
					object obj15 = !flag19;
					bool flag20 = num9 == 0f;
					object obj16 = !flag20;
					object obj17 = obj15 & obj16;
					if (obj17 == null)
					{
						object obj18 = this + 284;
						obj18 = 0;
					}
				}
			}
			else if (flag15)
			{
				obj19 = this + 284;
				obj20 = 1;
				goto IL_07d0;
			}
		}
		else
		{
			if (phase == (Phase)2)
			{
				if (flag15)
				{
					float num15 = deltaTime + t;
					float num16 = num15 / spinSeconds;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					float num17 = spinSeconds * num16;
					float num18 = num15 - num17;
					bool flag21 = num18 < 0f;
					num14 = 0f;
					if (!flag21)
					{
						bool flag22 = !(num18 > spinSeconds);
						num14 = num18;
						if (!flag22)
						{
							num14 = spinSeconds;
						}
					}
					goto IL_07dd;
				}
				obj19 = this + 284;
				obj20 = 3;
				goto IL_07d0;
			}
			if (phase == (Phase)3)
			{
				float num19 = (t = deltaTime + t);
				double num20;
				if (foldStarts > num19)
				{
					num20 = 2139095039.0;
				}
				else
				{
					float num21 = num19 - foldStarts;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
					float num22 = num21 / foldSeconds;
					bool flag23 = num22 < 0f;
					double num23 = 0.0;
					if (!flag23)
					{
						bool flag24 = !((double)num22 > 1.0);
						num23 = num22;
						if (!flag24)
						{
							num23 = 1.0;
						}
					}
					double num24 = 1.0 - num23;
					num20 = (double)foldFrom * num24;
				}
				if (flag15)
				{
					bool flag25 = num20 < (double)takeOverAt;
					object obj21 = !flag25;
					double num25 = num20 - (double)takeOverAt;
					bool flag26 = num25 == 0.0;
					object obj22 = ~obj21;
					object obj23 = obj22 | flag26;
					if (obj23 != null)
					{
						phase = (Phase)1;
						double num26 = num20 / (double)deployFrames;
						double num27 = num26 * (double)deploySeconds;
						t = (float)num27;
						goto IL_0764;
					}
				}
				if (!(num19 < retractSeconds))
				{
					phase = (flag15 ? ((Phase)1) : ((Phase)0));
					t = 0f;
				}
			}
		}
		goto IL_0764;
		IL_07dd:
		t = num14;
		goto IL_0764;
		IL_0764:
		Show();
		Sounds(phase, deltaTime);
		return;
		IL_07d0:
		obj19 = obj20;
		goto IL_0764;
	}

	private float FoldFrame(float s)
	{
		//IL_005c: Invalid comparison between F4 and I4
		//IL_006b: Expected F8, but got I4
		//IL_0027: Expected F4, but got I4
		if (foldStarts > s)
		{
			return 2.139095E+09f;
		}
		float num = s - foldStarts;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		float num2 = num / foldSeconds;
		bool flag = num2 < 0f;
		double num3 = 0.0;
		if (!flag)
		{
			bool flag2 = !((double)num2 > 1.0);
			num3 = num2;
			if (!flag2)
			{
				num3 = 1.0;
			}
		}
		double num4 = 1.0 - num3;
		return foldFrom * (float)num4;
	}

	private void Go(Phase p, float at)
	{
		phase = p;
		t = at;
	}

	private void LateUpdate()
	{
		//IL_0010: Expected Obj, but got I
		//IL_1039: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_007f: Expected VT, but got I4
		//IL_014d: Expected Obj, but got I4
		//IL_0156: Expected VT, but got I4
		//IL_0167: Expected Obj, but got I4
		//IL_0170: Expected VT, but got I4
		//IL_0f1e: Expected Obj, but got I4
		//IL_0f45: Expected Obj, but got I4
		//IL_01eb: Expected F8, but got I4
		//IL_1092: Invalid comparison between F8 and I4
		//IL_10a5: Expected Obj, but got F8
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b2: Expected Obj, but got Unknown
		//IL_10da: Expected Obj, but got I4
		//IL_1125: Expected Obj, but got I4
		//IL_113d: Invalid comparison between F4 and I4
		//IL_114e: Expected Obj, but got I4
		//IL_119e: Expected Obj, but got I4
		//IL_024e: Expected F4, but got I4
		//IL_0257: Expected F8, but got I4
		//IL_11bc: Expected Obj, but got I
		//IL_11e6: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I4
		//IL_0284: Expected F4, but got I4
		//IL_028d: Expected F8, but got I4
		//IL_1366: Expected Obj, but got I4
		//IL_136f: Expected Obj, but got I4
		//IL_1378: Expected VT, but got I4
		//IL_033f: Expected Obj, but got I4
		//IL_0348: Expected VT, but got I4
		//IL_04e0: Expected Obj, but got I
		//IL_04f9: Expected VT, but got I4
		//IL_0502: Expected Obj, but got I4
		//IL_1441: Expected Obj, but got I4
		//IL_0522: Expected Obj, but got I4
		//IL_05bd: Expected Obj, but got I4
		//IL_05ce: Expected Obj, but got I4
		//IL_05fd: Expected Obj, but got I
		//IL_0685: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I4
		//IL_069f: Expected VT, but got I4
		//IL_06bf: Expected Obj, but got I4
		//IL_06da: Expected Obj, but got I4
		//IL_0735: Expected F4, but got I
		//IL_07a8: Invalid comparison between F8 and I4
		//IL_07b9: Expected Obj, but got I4
		//IL_07c1: Invalid comparison between F8 and Obj
		//IL_07d0: Expected VT, but got I4
		//IL_13a8: Expected Obj, but got I4
		//IL_13b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b6: Expected Obj, but got Unknown
		//IL_13d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected Obj, but got Unknown
		//IL_07f9: Expected Obj, but got I
		//IL_0867: Expected Obj, but got I4
		//IL_0870: Expected Obj, but got I4
		//IL_0879: Expected VT, but got I4
		//IL_1405: Unknown result type (might be due to invalid IL or missing references)
		//IL_140a: Expected Obj, but got Unknown
		//IL_14de: Expected Obj, but got I4
		//IL_14e7: Expected Obj, but got I4
		//IL_08aa: Expected Obj, but got I4
		//IL_094f: Expected Obj, but got I4
		//IL_08ee: Expected VT, but got I4
		//IL_09d9: Expected Obj, but got I4
		//IL_09e2: Expected Obj, but got I4
		//IL_0a02: Expected Obj, but got I4
		//IL_0a1d: Expected Obj, but got I4
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got Unknown
		//IL_0ad1: Expected Obj, but got I
		//IL_0b05: Expected Obj, but got I
		//IL_0b76: Expected Obj, but got I
		//IL_0b93: Expected Obj, but got I
		//IL_0bfc: Expected Obj, but got I
		//IL_0c19: Expected Obj, but got I
		//IL_0c45: Expected Obj, but got I
		//IL_0c62: Expected Obj, but got I
		//IL_0cf0: Expected VT, but got I4
		//IL_0cf0: Expected Obj, but got I
		//IL_0d20: Expected VT, but got I
		//IL_0d30: Expected VT, but got I
		//IL_0d49: Expected Obj, but got I4
		//IL_0d52: Expected Obj, but got I4
		//IL_0d5b: Expected VT, but got I4
		//IL_0d7b: Expected Obj, but got I4
		//IL_0d96: Expected Obj, but got I4
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Expected Obj, but got Unknown
		//IL_0dfb: Expected Obj, but got I4
		//IL_0e0b: Expected VT, but got I
		//IL_0e1b: Expected VT, but got I
		//IL_0e34: Expected Obj, but got I4
		//IL_0e3d: Expected Obj, but got I4
		//IL_0e46: Expected VT, but got I4
		//IL_0e86: Expected VT, but got I
		//IL_0e96: Expected VT, but got I
		//IL_0ea8: Expected Obj, but got I4
		//IL_0ee1: Expected VT, but got I4
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
		bool flag2 = animator == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		bool flag4 = (object)animator == null;
		object obj5 = 0;
		Quaternion quaternion = (Quaternion)0;
		if (!flag4)
		{
			if (!animator.isInitialized)
			{
				return;
			}
			bool flag5 = (byte)(~(curlReady ? 1u : 0u)) != 0;
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			object obj11 = default;
			object obj10 = obj11;
			double num2 = default;
			double num = num2;
			float num4 = default;
			float num3 = num4;
			double num6 = default;
			double num5 = num6;
			Vector3 vector2 = default;
			Vector3 vector = vector2;
			double num8 = default;
			double num7 = num8;
			object obj13 = default;
			object obj12 = obj13;
			Quaternion[] array2 = default;
			Quaternion[] array = array2;
			object obj15 = default;
			object obj14 = obj15;
			object obj17 = default;
			object obj16 = obj17;
			object obj19 = default;
			object obj18 = obj19;
			object obj21 = default;
			object obj20 = obj21;
			float num10 = default;
			float num9 = num10;
			Vector3[] array4 = default;
			Vector3[] array3 = array4;
			object obj22 = 0;
			Quaternion quaternion2 = (Quaternion)0;
			object obj23 = obj;
			obj5 = 0;
			quaternion = (Quaternion)0;
			if (flag5)
			{
				bool flag6 = phase == 0;
				object obj24 = !flag6;
				if (obj24 != null)
				{
					return;
				}
				int frameCount = Time.frameCount;
				object obj25 = startFrame + 3;
				if (frameCount < (nint)obj25)
				{
					return;
				}
				BuildCurl();
				obj6 = obj7;
				obj8 = obj9;
				obj10 = obj11;
				num = num2;
				num3 = num4;
				num5 = num6;
				vector = vector2;
				num7 = num8;
				obj12 = obj13;
				array = array2;
				obj14 = obj15;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				num9 = num10;
				array3 = array4;
				obj22 = obj5;
				quaternion2 = quaternion;
				obj23 = obj;
			}
			if (curled == null)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			object obj26 = obj23;
			double num11 = ((phase != 0) ? 0.0 : 1.0);
			float num12 = deltaTime * 12f;
			float num13 = deltaTime * 12f;
			float num14 = 0f - num13;
			double num15 = num11 - (double)atRest;
			bool flag7 = num15 < 0.0;
			object obj27 = num15 ^ num15;
			object obj28 = num15 & obj27;
			bool flag8 = (nint)obj28 < 0;
			bool flag9 = flag7 == flag8;
			object obj29 = !flag9;
			object obj30 = ~obj29;
			float num16 = ((obj30 != null) ? num12 : num14);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			float num17 = atRest + num16;
			bool flag10 = num14 < num12;
			object obj31 = !flag10;
			float num18 = num14 - num12;
			bool flag11 = num18 == 0f;
			object obj32 = !flag11;
			object obj33 = obj31 & obj32;
			object obj34 = ~obj33;
			if (obj34 == null)
			{
				num11 = num17;
			}
			atRest = (float)num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X0_v16+E4]");
			bool flag12 = (nint)0 == 0;
			object obj35 = !flag12;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag13 = hand != null;
			bool flag14 = !flag13;
			float num19 = 0f;
			double num20 = 0.0;
			if (!flag14)
			{
				bool flag15 = (byte)(~(demo ? 1u : 0u)) != 0;
				object obj36 = !flag15;
				num19 = 0f;
				num20 = 0.0;
				if (obj36 == null)
				{
					HandPoser handPoser = hand;
					bool flag16 = (object)hand == null;
					obj7 = obj6;
					obj9 = obj8;
					obj11 = obj10;
					num2 = num;
					num4 = num3;
					num6 = num5;
					vector2 = vector;
					num8 = num7;
					obj13 = obj12;
					array2 = array;
					obj15 = obj14;
					obj17 = obj16;
					obj19 = obj18;
					obj21 = obj20;
					num10 = num9;
					array4 = array3;
					obj5 = 0;
					quaternion = (Quaternion)0;
					obj = obj23;
					if (flag16)
					{
						goto IL_0ef7;
					}
					num19 = handPoser.grip;
					num20 = handPoser.thumbPress;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
			object obj37 = 0;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X0_v20+E4]");
			bool flag17 = (nint)0 == 0;
			object obj39 = !flag17;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num21 = num19 - grip;
			float num22 = gripVel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACE4]");
			float num23 = num22 * 0f;
			float num24 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA2C]");
			float num25 = num24 * 0f;
			float num26 = num25 + num23;
			float num27 = deltaTime * num26;
			float num28 = gripVel + num27;
			float num29 = deltaTime * num28;
			gripVel = num28;
			float num30 = grip + num29;
			bool flag18 = (double)num30 < -0.25;
			double num31 = -0.25;
			if (!flag18)
			{
				bool flag19 = !((double)num30 > 1.25);
				num31 = num30;
				if (!flag19)
				{
					num31 = 1.25;
				}
			}
			num6 = thumbVel;
			grip = (float)num31;
			num10 = (float)num20 - thumb;
			double num32 = thumbVel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACE4]");
			double num33 = num32 * 0.0;
			float num34 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA2C]");
			float num35 = num34 * 0f;
			float num36 = num35 + (float)num33;
			float num37 = deltaTime * num36;
			float num38 = thumbVel + num37;
			float num39 = deltaTime * num38;
			thumbVel = num38;
			float num40 = thumb + num39;
			bool flag20 = (double)num40 < -0.25;
			double num41 = -0.25;
			if (!flag20)
			{
				bool flag21 = !((double)num40 > 1.25);
				num41 = num40;
				if (!flag21)
				{
					num41 = 1.25;
				}
			}
			Transform[] array5 = curled;
			thumb = (float)num41;
			bool flag22 = curled == null;
			obj7 = obj6;
			obj9 = obj8;
			obj11 = obj10;
			num2 = num;
			num4 = num3;
			vector2 = vector;
			num8 = num7;
			obj13 = obj12;
			array2 = array;
			obj15 = obj14;
			obj17 = obj16;
			obj19 = obj18;
			obj21 = obj20;
			array4 = (Vector3[])17276928;
			obj5 = 0;
			quaternion = (Quaternion)0;
			obj = obj23;
			if (!flag22)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AE7C]");
				obj19 = 0;
				double num42 = num6;
				float num43 = num10;
				Quaternion quaternion3 = (Quaternion)0;
				object obj40 = 0;
				Vector3 axis = default;
				while (true)
				{
					array4 = (Vector3[])array5.Length;
					if ((nint)obj40 >= array5.Length)
					{
						return;
					}
					bool flag23 = (nint)obj40 < array5.Length;
					object obj41 = !flag23;
					if (obj41 == null)
					{
						object obj42 = (object)array5 + obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v22+20]");
						bool flag24 = (nint)0 == 0;
						obj7 = obj6;
						obj9 = obj8;
						obj11 = obj10;
						num2 = num;
						num4 = num3;
						num6 = num42;
						vector2 = vector;
						num8 = num7;
						obj13 = obj12;
						array2 = array;
						obj15 = obj14;
						obj17 = obj40;
						obj21 = 12;
						num10 = num43;
						obj5 = 0;
						quaternion = quaternion3;
						obj = obj40;
						if (flag24)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v22+20]");
						Quaternion localRotation = ((Transform)0).localRotation;
						Quaternion[] array6 = wrote;
						bool flag25 = wrote == null;
						obj7 = obj6;
						obj9 = obj8;
						obj11 = obj10;
						num2 = num;
						num4 = num3;
						num6 = num42;
						vector2 = vector;
						num8 = num7;
						obj13 = obj12;
						array2 = array;
						obj15 = obj14;
						obj17 = obj40;
						obj21 = 12;
						num10 = num43;
						obj5 = 0;
						quaternion = (Quaternion)0;
						obj = obj40;
						if (flag25)
						{
							break;
						}
						array4 = (Vector3[])array6.Length;
						bool flag26 = (nint)obj40 < array6.Length;
						object obj43 = !flag26;
						if (obj43 == null)
						{
							object obj44 = (object)wrote + obj40;
							double num44 = num41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v24+20]");
							double num45 = num44 * 0.0;
							float num46 = num40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v24+24]");
							float num47 = num46 * 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v24+2C]");
							num10 = 0f;
							double num48 = num45 + (double)num47;
							float num49 = num38;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v24+28]");
							float num50 = num49 * 0f;
							float num51 = num50 + (float)num48;
							double num52 = num31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v24+2C]");
							double num53 = num52 * 0.0;
							double num54 = num53 + (double)num51;
							double num55 = num54 - (double)obj19;
							bool flag27 = num55 == 0.0;
							obj15 = !flag27;
							bool flag28 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num54) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
							quaternion = (Quaternion)0;
							if (!flag28)
							{
								array2 = animated;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v22+20]");
								Quaternion localRotation2 = ((Transform)0).localRotation;
								bool flag29 = animated == null;
								obj7 = obj6;
								obj9 = obj8;
								obj11 = obj10;
								num2 = num;
								num4 = num3;
								num6 = num42;
								vector2 = vector;
								num8 = num7;
								obj13 = obj12;
								obj17 = obj40;
								obj21 = 12;
								obj5 = 0;
								quaternion = (Quaternion)0;
								obj = obj40;
								if (flag29)
								{
									break;
								}
								bool flag30 = (nint)obj40 < array2.Length;
								object obj45 = !flag30;
								if (obj45 != null)
								{
									goto IL_1008;
								}
								object obj46 = (object)animated + obj40;
								array = animated;
								quaternion = (Quaternion)0;
							}
							bool flag31 = (nint)obj40 < 3;
							object obj47 = !flag31;
							object obj48 = obj40 - 3;
							bool flag32 = obj48 == null;
							object obj49 = ~obj47;
							object obj50 = obj49 | flag32;
							float num56;
							float num57;
							if (obj50 == null)
							{
								num56 = thumb;
								num57 = thumbCurl;
							}
							else
							{
								num56 = grip;
								num57 = fingerCurl;
							}
							float num58 = num56 * num57;
							object obj51 = obj40 & 0x80000001L;
							bool flag33 = (nint)obj51 != 1;
							double num59 = 1.0;
							if (!flag33)
							{
								num59 = tipMore;
							}
							Quaternion[] array7 = animated;
							bool flag34 = animated == null;
							obj7 = obj6;
							obj9 = obj8;
							obj11 = obj10;
							num2 = num;
							num4 = num3;
							num6 = num42;
							vector2 = vector;
							num8 = num7;
							obj13 = obj12;
							array2 = array;
							obj17 = obj40;
							obj21 = 12;
							obj5 = 0;
							obj = obj40;
							if (flag34)
							{
								break;
							}
							bool flag35 = (nint)obj40 < array7.Length;
							object obj52 = !flag35;
							if (obj52 == null)
							{
								array4 = hinge;
								bool flag36 = hinge == null;
								obj7 = obj6;
								obj9 = obj8;
								obj11 = obj10;
								num2 = num;
								num4 = num3;
								num6 = num42;
								vector2 = vector;
								num8 = num7;
								obj13 = obj12;
								array2 = array;
								obj17 = obj40;
								obj21 = 12;
								obj5 = 0;
								obj = obj40;
								if (flag36)
								{
									break;
								}
								obj13 = array4.Length;
								bool flag37 = (nint)obj40 < array4.Length;
								object obj53 = !flag37;
								if (obj53 == null)
								{
									double num60 = (double)num58 * num59;
									object obj54 = obj40 * 12;
									array4 = (Vector3[])(object)((object)array4 + obj54);
									object obj55 = (object)animated + obj40;
									float num61 = (float)num60 * atRest;
									Quaternion quaternion4 = Quaternion.Internal_AngleAxis(num61, ref axis);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+2C]");
									float num62 = 0f * num61;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+20]");
									double num63 = 0.0 * num31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+2C]");
									nint num64 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+20]");
									object obj56 = num64 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+24]");
									double num65 = 0.0 * num31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+2C]");
									nint num66 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+28]");
									object obj57 = num66 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+28]");
									double num67 = 0.0 * num31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+2C]");
									double num68 = 0.0 * num31;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+20]");
									float num69 = 0f * num61;
									float num70 = num62 + (float)num63;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+24]");
									nint num71 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+28]");
									object obj58 = num71 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+20]");
									nint num72 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+28]");
									obj7 = num72 * 0;
									double num73 = (double)obj56 + num65;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+28]");
									num4 = 0f * num61;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+24]");
									float num74 = 0f * num61;
									num2 = (double)obj57 + num67;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+20]");
									nint num75 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+20]");
									obj11 = num75 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+28]");
									nint num76 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+28]");
									object obj59 = num76 * 0;
									double num77 = num68 - (double)num69;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+24]");
									nint num78 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+20]");
									obj9 = num78 * 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v28+28]");
									nint num79 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+20]");
									object obj60 = num79 * 0;
									float num80 = (float)obj58 + num70;
									num10 = num4 + (float)num73;
									num6 = (double)obj11 + num2;
									double num81 = num77 - (double)obj9;
									float num82 = num80 - (float)obj60;
									float num83 = num10 - (float)obj7;
									double num84 = num6 - (double)num74;
									num8 = num81 - (double)obj59;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v22+20]");
									((Transform)0).localRotation = (Quaternion)0;
									Quaternion[] array8 = wrote;
									bool flag38 = wrote == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+20]");
									axis = (Vector3)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+28]");
									vector2 = (Vector3)0;
									array2 = array;
									obj17 = obj40;
									obj21 = 12;
									obj5 = 0;
									quaternion = (Quaternion)0;
									obj = obj40;
									if (flag38)
									{
										break;
									}
									array4 = (Vector3[])array8.Length;
									bool flag39 = (nint)obj40 < array8.Length;
									object obj61 = !flag39;
									if (obj61 == null)
									{
										object obj62 = (object)wrote + obj40;
										obj = obj40 + 1;
										array5 = curled;
										bool flag40 = curled == null;
										object obj63 = !flag40;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+20]");
										axis = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+28]");
										vector2 = (Vector3)0;
										array2 = array;
										obj17 = obj40;
										obj21 = 12;
										obj5 = 0;
										quaternion = (Quaternion)0;
										obj6 = obj7;
										obj8 = obj9;
										obj10 = obj11;
										num = num2;
										num3 = num4;
										num42 = num6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+20]");
										axis = (Vector3)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v2 (UnityEngine.Vector3[])+28]");
										vector = (Vector3)0;
										num7 = num8;
										obj12 = array4.Length;
										obj14 = obj15;
										num43 = num10;
										num38 = (float)num84;
										num31 = num8;
										num40 = num83;
										num41 = num82;
										quaternion3 = (Quaternion)0;
										obj40 = obj;
										if (obj63 == null)
										{
											break;
										}
										continue;
									}
								}
							}
						}
					}
					goto IL_1008;
					IL_1008:
					throw new IndexOutOfRangeException();
				}
			}
		}
		goto IL_0ef7;
		IL_0ef7:
		throw new NullReferenceException();
	}

	private void BuildCurl()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_0271: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got I4
		//IL_036b: Expected Obj, but got I4
		//IL_03a3: Expected Obj, but got I4
		//IL_03e8: Expected Obj, but got I4
		//IL_0420: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I4
		//IL_049d: Expected Obj, but got I4
		//IL_04e2: Expected Obj, but got I4
		//IL_051a: Expected Obj, but got I4
		//IL_071d: Expected Obj, but got I
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected Obj, but got Unknown
		//IL_080e: Expected Obj, but got I
		//IL_0879: Expected Obj, but got I
		//IL_08ad: Expected Obj, but got I4
		//IL_093b: Expected Obj, but got I4
		//IL_0951: Expected Obj, but got I
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected Obj, but got Unknown
		//IL_0a04: Expected Obj, but got I4
		//IL_0a1a: Expected Obj, but got I
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a8f: Expected Obj, but got I4
		//IL_0aa5: Expected Obj, but got I
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected Obj, but got Unknown
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected Obj, but got Unknown
		//IL_0b77: Expected Obj, but got I
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected Obj, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got Unknown
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected Obj, but got Unknown
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected Obj, but got Unknown
		//IL_0db8: Expected Obj, but got I
		//IL_0dc1: Expected Obj, but got I4
		//IL_0de1: Expected Obj, but got I4
		//IL_0e10: Expected Obj, but got I4
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected Obj, but got Unknown
		//IL_0e7c: Expected Obj, but got I
		//IL_0ec8: Expected Obj, but got I4
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected Obj, but got Unknown
		//IL_0f07: Expected Obj, but got I4
		//IL_0f62: Expected Obj, but got I
		//IL_15ba: Invalid comparison between F8 and Obj
		//IL_1674: Expected VT, but got I4
		//IL_1674: Expected VT, but got I4
		//IL_10f8: Expected Obj, but got I4
		//IL_11b6: Expected Obj, but got I
		//IL_1239: Expected Obj, but got I
		//IL_1169: Invalid comparison between F8 and I4
		//IL_12d4: Expected Obj, but got I
		//IL_12dc: Expected F8, but got VT
		//IL_12fc: Expected Obj, but got I
		//IL_132d: Expected F8, but got VT
		//IL_1601: Expected VT, but got I4
		//IL_1601: Expected Obj, but got I
		//IL_1188: Expected F8, but got VT
		//IL_1365: Expected Obj, but got I4
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1381: Expected Obj, but got Unknown
		//IL_13c4: Expected Obj, but got I
		//IL_1402: Expected Obj, but got I4
		//IL_146d: Expected Obj, but got I4
		//IL_1493: Unknown result type (might be due to invalid IL or missing references)
		//IL_1498: Expected Obj, but got Unknown
		//IL_14d2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD88]");
		object n = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD90]");
		object n2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD98]");
		object n3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDA0]");
		object n4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDA8]");
		object n5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDB0]");
		object n6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDB8]");
		object n7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDC0]");
		object n8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C48E0]");
		object n9 = 0;
		curlReady = true;
		Transform transform = _003CBuildCurl_003Eg__Bone_007C121_0((string)n);
		Transform transform2 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n2);
		Transform transform3 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n3);
		Transform transform4 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n4);
		Transform transform5 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n5);
		Transform transform6 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n6);
		Transform transform7 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n7);
		Transform transform8 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n8);
		Transform transform9 = _003CBuildCurl_003Eg__Bone_007C121_0((string)n9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = transform == null;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = transform2 == null;
		bool flag6 = !flag5;
		object obj7 = !flag6;
		if (obj7 != null)
		{
			return;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v28+E4]");
		bool flag7 = (nint)0 == 0;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = transform3 == null;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		if (obj10 != null)
		{
			return;
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v32+E4]");
		bool flag10 = (nint)0 == 0;
		object obj12 = !flag10;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = transform4 == null;
		bool flag12 = !flag11;
		object obj13 = !flag12;
		if (obj13 != null)
		{
			return;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v36+E4]");
		bool flag13 = (nint)0 == 0;
		object obj15 = !flag13;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag14 = transform5 == null;
		bool flag15 = !flag14;
		object obj16 = !flag15;
		if (obj16 != null)
		{
			return;
		}
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v40+E4]");
		bool flag16 = (nint)0 == 0;
		object obj18 = !flag16;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag17 = transform6 == null;
		bool flag18 = !flag17;
		object obj19 = !flag18;
		if (obj19 != null)
		{
			return;
		}
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X0_v44+E4]");
		bool flag19 = (nint)0 == 0;
		object obj21 = !flag19;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag20 = transform7 == null;
		bool flag21 = !flag20;
		object obj22 = !flag21;
		if (obj22 != null)
		{
			return;
		}
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v48+E4]");
		bool flag22 = (nint)0 == 0;
		object obj24 = !flag22;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag23 = transform8 == null;
		bool flag24 = !flag23;
		object obj25 = !flag24;
		if (obj25 != null)
		{
			return;
		}
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X0_v52+E4]");
		bool flag25 = (nint)0 == 0;
		object obj27 = !flag25;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (transform9 == null)
		{
			return;
		}
		if ((object)transform7 != null)
		{
			Vector3 position = transform7.position;
			if ((object)transform8 != null)
			{
				Vector3 position2 = transform8.position;
				object obj29 = default;
				object obj28 = obj29 - obj29;
				object obj31 = default;
				object obj30 = obj31 - obj31;
				object obj32 = default;
				double num = (double)obj32 - (double)obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC0508");
				if ((object)transform != null)
				{
					Vector3 position3 = transform.position;
					if ((object)transform3 != null)
					{
						Vector3 position4 = transform3.position;
						Vector3 position5 = transform.position;
						Vector3 position6 = transform3.position;
						if ((object)transform9 != null)
						{
							double num2 = num + num;
							object obj33 = obj30 + obj30;
							object obj34 = obj28 + obj28;
							double num3 = num2 * 0.5;
							double num4 = (double)obj33 * 0.5;
							double num5 = (double)obj34 * 0.5;
							Vector3 position7 = transform9.position;
							Vector3 position8 = transform9.position;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F3FEE0");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F30]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
							Transform[] array = default;
							if (array != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD30");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @289CD64");
								object obj36 = this + 312;
								curled = array;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4290]");
								object obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
								if ((object)transform2 != null)
								{
									Vector3 position9 = transform2.position;
									object obj38 = default;
									if (obj38 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
										object obj39 = 0;
										object obj40 = obj39;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X0_v111+E4]");
										bool flag26 = (nint)0 == 0;
										object obj41 = !flag26;
										if (obj41 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Vector3 vector = _003CBuildCurl_003Eg__Past_007C121_1(transform, transform2);
										if ((object)transform4 != null)
										{
											Vector3 position10 = transform4.position;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v108+18]");
											bool flag27 = (nint)0 < (nint)2;
											object obj42 = !flag27;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v108+18]");
											object obj43 = -2;
											bool flag28 = obj43 == null;
											object obj44 = ~obj42;
											object obj45 = obj44 | flag28;
											if (obj45 == null)
											{
												Vector3 vector2 = _003CBuildCurl_003Eg__Past_007C121_1(transform3, transform4);
												if ((object)transform6 == null)
												{
													goto IL_1518;
												}
												Vector3 position11 = transform6.position;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v108+18]");
												bool flag29 = (nint)0 < (nint)4;
												object obj46 = !flag29;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v108+18]");
												object obj47 = -4;
												bool flag30 = obj47 == null;
												object obj48 = ~obj46;
												object obj49 = obj48 | flag30;
												if (obj49 == null)
												{
													Vector3 vector3 = _003CBuildCurl_003Eg__Past_007C121_1(transform5, transform6);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v108+18]");
													bool flag31 = (nint)0 < (nint)5;
													object obj50 = !flag31;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v108+18]");
													object obj51 = -5;
													bool flag32 = obj51 == null;
													object obj52 = ~obj50;
													object obj53 = obj52 | flag32;
													if (obj53 == null)
													{
														Transform[] array2 = curled;
														if (curled != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
															Vector3[] array3 = default;
															hinge = array3;
															object obj54 = this + 320;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
															Transform[] array4 = curled;
															if (curled != null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4F28]");
																object obj55 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																Quaternion[] array5 = default;
																animated = array5;
																object obj56 = this + 328;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																Transform[] array6 = curled;
																if (curled != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
																	Quaternion[] array7 = default;
																	wrote = array7;
																	object obj57 = this + 336;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
																	Transform[] array8 = curled;
																	if (curled != null)
																	{
																		double num6 = num5 - (double)obj34;
																		double num7 = num4 - (double)obj33;
																		double num8 = num3 - num2;
																		object obj58 = obj28 * obj34;
																		object obj59 = obj30 * obj34;
																		double num9 = num * (double)obj34;
																		double num10 = num6;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
																		double num11 = num10 * 0.0;
																		double num12 = num7;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
																		double num13 = num12 * 0.0;
																		double num14 = num8;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AEB4]");
																		double num15 = num14 * 0.0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
																		object obj60 = obj58 * 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
																		object obj61 = obj59 * 0;
																		double num16 = num9;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107A9D4]");
																		double num17 = num16 * 0.0;
																		double num18 = (double)obj34 + num11;
																		double num19 = (double)obj33 + num13;
																		double num20 = num2 + num15;
																		double num21 = (double)obj28 - (double)obj28;
																		double num22 = (double)obj30 - (double)obj30;
																		double num23 = num - num;
																		double num24 = num18 + (double)obj60;
																		double num25 = num19 + (double)obj61;
																		double num26 = num20 + num17;
																		double num27 = num;
																		double num28 = num24;
																		double num29 = num;
																		double num30 = num26;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
																		object obj62 = 0;
																		object obj63 = 0;
																		Vector3 axis = default;
																		Vector3 vector5 = default;
																		while (true)
																		{
																			if ((nint)obj63 >= array8.Length)
																			{
																				return;
																			}
																			bool flag33 = (nint)obj63 < array8.Length;
																			object obj64 = !flag33;
																			if (obj64 != null)
																			{
																				break;
																			}
																			object obj65 = obj63;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v108+18]");
																			bool flag34 = (nint)obj65 < 0;
																			object obj66 = !flag34;
																			if (obj66 != null)
																			{
																				break;
																			}
																			object obj67 = (object)array8 + obj63;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v32+20]");
																			if ((nint)0 == 0)
																			{
																				goto IL_1518;
																			}
																			object obj68 = obj63 * 12;
																			object obj69 = obj38 + obj68;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v32+20]");
																			Vector3 position12 = ((Transform)0).position;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v33+20]");
																			double num31 = 0.0 - num30;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v33+24]");
																			double num32 = 0.0 - num19;
																			bool flag35 = (nint)obj63 < 3;
																			object obj70 = !flag35;
																			object obj71 = obj63 - 3;
																			bool flag36 = obj71 == null;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v33+28]");
																			double num33 = 0.0 - num20;
																			object obj72 = !flag36;
																			object obj73 = obj70 & obj72;
																			double num35;
																			double num37;
																			double num36;
																			if (obj73 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECCDCC");
																				double num34 = num33;
																				num35 = num23;
																				num36 = num22;
																				num37 = num21;
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v32+20]");
																				Vector3 position13 = ((Transform)0).position;
																				double num38 = num25 - num19;
																				double num39 = num26 - num20;
																				double num40 = num24 - num30;
																				double num41 = num33 * num38;
																				num28 = num31 * num38;
																				double num42 = num32 * num39;
																				double num43 = num31 * num39;
																				double num34 = num33 * num40;
																				num27 = num32 * num40;
																				num37 = num42 - num41;
																				num36 = num34 - num43;
																				num35 = num28 - num27;
																			}
																			double num44 = num37 * num37;
																			double num45 = num36 * num36;
																			double num46 = num44 + num45;
																			double num47 = num35 * num35;
																			double num48 = num47 + num46;
																			bool flag37 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num48) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62);
																			double num49 = num35;
																			double num50 = num36;
																			if (!flag37)
																			{
																				double num51 = (double)obj28 * num33;
																				double num34 = (double)obj28 * num32;
																				double num52 = num * num32;
																				double num53 = (double)obj30 * num33;
																				num48 = num * num31;
																				num47 = (double)obj30 * num31;
																				num37 = num52 - num53;
																				num36 = num51 - num48;
																				num35 = num47 - num34;
																				num49 = num35;
																				num50 = num36;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DA98E0");
																			Quaternion quaternion = Quaternion.Internal_AngleAxis(30f, ref axis);
																			Vector3 vector4 = (Quaternion)0 * (Vector3)0;
																			double num54 = 30.0 - num31;
																			double num55 = num49 - num32;
																			bool flag38 = (nint)obj63 < 4;
																			object obj74 = !flag38;
																			double num56 = num35 - num33;
																			double num62;
																			double num64;
																			object obj75;
																			double num63;
																			if (obj74 == null)
																			{
																				double num57 = (double)obj28 * num54;
																				double num58 = (double)obj30 * num55;
																				double num59 = num57 + num58;
																				double num60 = num * num56;
																				double num61 = num60 + num59;
																				if (!(num61 > 0.0))
																				{
																					goto IL_130a;
																				}
																				num62 = (double)vector5;
																				num63 = num48;
																				num64 = num29;
																				obj75 = obj62;
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v32+20]");
																				Vector3 position14 = ((Transform)0).position;
																				double num65 = num31 + 30.0;
																				double num66 = num32 + num49;
																				double num67 = num33 + num35;
																				double num68 = num54 + num65;
																				double num69 = num55 + num66;
																				double num70 = num56 + num67;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F3FEE0");
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v32+20]");
																				Vector3 position15 = ((Transform)0).position;
																				double num71 = num31 + num68;
																				double num72 = num32 + num69;
																				double num73 = num33 + num70;
																				double num74 = num71 - num54;
																				double num75 = num72 - num55;
																				double num76 = num73 - num56;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F3FEE0");
																				bool flag39 = num68 < num74;
																				num48 = num24;
																				num29 = num68;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
																				obj62 = 0;
																				num62 = (double)vector5;
																				num63 = num24;
																				num64 = num68;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFFC]");
																				obj75 = 0;
																				if (!flag39)
																				{
																					goto IL_130a;
																				}
																			}
																			goto IL_15e1;
																			IL_15e1:
																			Vector3[] array9 = hinge;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v32+20]");
																			Vector3 vector6 = ((Transform)0).InverseTransformDirection((Vector3)0);
																			if (hinge != null)
																			{
																				bool flag40 = (nint)obj63 < array9.Length;
																				object obj76 = !flag40;
																				if (obj76 != null)
																				{
																					break;
																				}
																				object obj77 = obj63 * 12;
																				object obj78 = (object)hinge + obj77;
																				Quaternion[] array10 = animated;
																				Quaternion[] array11 = wrote;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v32+20]");
																				Quaternion localRotation = ((Transform)0).localRotation;
																				if (wrote != null)
																				{
																					bool flag41 = (nint)obj63 < array11.Length;
																					object obj79 = !flag41;
																					if (obj79 != null)
																					{
																						break;
																					}
																					object obj80 = (object)wrote + obj63;
																					if (animated != null)
																					{
																						bool flag42 = (nint)obj63 < array10.Length;
																						object obj81 = !flag42;
																						if (obj81 != null)
																						{
																							break;
																						}
																						object obj82 = (object)animated + obj63;
																						obj63++;
																						array8 = curled;
																						bool flag43 = curled == null;
																						object obj83 = !flag43;
																						axis = vector5;
																						num28 = num33;
																						num29 = num64;
																						num20 = num49;
																						num19 = num50;
																						num30 = num62;
																						obj62 = obj75;
																						if (obj83 != null)
																						{
																							continue;
																						}
																					}
																				}
																			}
																			goto IL_1518;
																			IL_130a:
																			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
																			double num77 = 0.0 - num49;
																			num49 = num77;
																			num62 = (double)vector5;
																			num63 = num48;
																			num64 = num29;
																			obj75 = obj62;
																			goto IL_15e1;
																		}
																		goto IL_1526;
																	}
																}
															}
														}
														goto IL_1518;
													}
												}
											}
											goto IL_1526;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_1518;
		IL_1518:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1526;
		IL_1526:
		throw new IndexOutOfRangeException();
	}

	private unsafe static void Spring(ref float v, ref float vel, float target, float dt)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_008e: Expected Ref, but got F4
		//IL_0116: Expected Ref, but got F8
		float num = target - v;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AA2C]");
		float num3 = num2 * 0f;
		float num4 = vel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ACE4]");
		object obj = num4 * 0;
		float num5 = num3 + (float)obj;
		float num6 = num5 * dt;
		float num7 = vel + num6;
		float num8 = num7 * dt;
		ref float reference = ref *(float*)num7;
		float num9 = v + num8;
		bool flag = (double)num9 < -0.25;
		double num10 = -0.25;
		if (!flag)
		{
			bool flag2 = !((double)num9 > 1.25);
			num10 = num9;
			if (!flag2)
			{
				num10 = 1.25;
			}
		}
		ref float reference2 = ref *(float*)num10;
	}

	private void Show()
	{
		//IL_0010: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I4
		//IL_0480: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_00ad: Expected F8, but got I4
		//IL_03d0: Invalid comparison between F8 and I4
		//IL_03df: Expected F8, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		//IL_01eb: Expected F8, but got I4
		//IL_0462: Expected Obj, but got I4
		//IL_0322: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+28]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+28]");
		if ((nint)0 == 0)
		{
			goto IL_033e;
		}
		Phase phase = this.phase;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v1+18]");
		bool flag2 = (nint)phase < (nint)0;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_034c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4+28]");
		object obj7 = (nint)0 + (nint)this.phase;
		double num;
		double num2;
		if (this.phase <= (Phase)1)
		{
			bool flag3 = this.phase == 0;
			num = 0.0;
			if (flag3)
			{
				goto IL_038b;
			}
			bool flag4 = this.phase != (Phase)1;
			num2 = 1.0;
			if (!flag4)
			{
				num2 = deploySeconds;
			}
		}
		else if (this.phase != (Phase)2)
		{
			bool flag5 = this.phase != (Phase)3;
			num2 = 1.0;
			if (!flag5)
			{
				num2 = retractSeconds;
			}
		}
		else
		{
			num2 = spinSeconds;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
		double num3 = (double)t / num2;
		bool flag6 = num3 < 0.0;
		num = 0.0;
		if (!flag6)
		{
			bool flag7 = !(num3 > 1.0);
			num = num3;
			if (!flag7)
			{
				num = 1.0;
			}
		}
		goto IL_038b;
		IL_038b:
		bool flag8;
		if (!(num < 1.0))
		{
			object obj8 = this.phase - 2;
			flag8 = obj8 == null;
		}
		else
		{
			flag8 = false;
		}
		object obj9 = !flag8;
		object obj10 = ~obj9;
		double num4 = ((obj10 != null) ? 0.0 : num);
		int num5 = playing;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X9_v4+20]");
		int num7;
		int num6;
		float num8;
		if ((nint)num5 == 0)
		{
			if ((object)this.animator == null)
			{
				goto IL_033e;
			}
			num6 = layer;
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(layer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X9_v4+20]");
			object obj11 = default;
			bool flag9 = obj11 == null;
			num7 = 0;
			num8 = (float)num;
			if (flag9)
			{
				goto IL_0438;
			}
		}
		if ((object)this.animator == null)
		{
			goto IL_033e;
		}
		num7 = layer;
		Animator animator = this.animator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X9_v4+20]");
		animator.Play(0, layer, (float)num4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X9_v4+20]");
		playing = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X9_v4+20]");
		num6 = 0;
		num8 = (float)num4;
		goto IL_0438;
		IL_034c:
		throw new IndexOutOfRangeException();
		IL_033e:
		NullReferenceException ex = new NullReferenceException();
		goto IL_034c;
		IL_0438:
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((object)this.animator != null)
		{
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v11+A0]");
			object obj15 = 0;
			Animator animator2 = this.animator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v12+24]");
			animator2.SetFloat(0, (float)num4);
			return;
		}
		goto IL_033e;
	}

	public RobotSaw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_00e2: Expected F4, but got I
		//IL_00f4: Expected F4, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_004f: Expected F4, but got I
		//IL_0069: Expected I4, but got I8
		//IL_0091: Expected F4, but got I
		//IL_00b9: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C53E8]");
		object obj = 0;
		demoRange = 8f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107F180]");
		motorAt = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ED60]");
		mechVolume = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj2 = this + 136;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		object obj4 = this + 144;
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		bitUntil = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C940]");
		deploySeconds = 0f;
		tipMore = 1.25f;
		layer = -1;
		takeOverAt = 46f;
		heard = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107CD60]");
		foldStarts = 0f;
		brakeFrom = 1f;
		atRest = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C1D8]");
		fingerCurl = 0f;
		base._002Ector();
	}

	static RobotSaw()
	{
		//IL_0010: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I8
		//IL_00b1: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0109: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0186: Expected Obj, but got I8
		//IL_01b3: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_02f6: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I
		//IL_0351: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I8
		//IL_039e: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I8
		//IL_03f6: Expected Obj, but got I
		//IL_0406: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I4
		//IL_0443: Expected Obj, but got I
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0487: Expected Obj, but got I
		//IL_04ad: Expected Obj, but got I4
		//IL_04c3: Expected Obj, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_0513: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_0542: Expected Obj, but got I8
		//IL_0570: Expected Obj, but got I
		//IL_058e: Expected Obj, but got I8
		//IL_05ce: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4480]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDD8]");
			object obj2 = 0;
			object obj4 = default;
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X20_v6-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDC8]");
				object obj6 = 0;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X20_v8-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C8C40]");
					object obj12 = 0;
					object obj13 = obj4 + 48;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X20_v10-18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDE0]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDDD0]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4E78]");
						object obj18 = 0;
						object obj19 = obj4 + 56;
						obj19 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj20 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v17+A0]");
						object obj21 = (nint)0 + (nint)24;
						obj21 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
						object obj22 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v18+A0]");
						object obj23 = 0;
						_ = 3212836864L;
						int num = Animator.StringToHash((string)obj17);
						object obj24 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v20+A0]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
						object obj26 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v22+A0]");
						object obj27 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v23+18]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v24+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v24+20]");
							int num2 = Animator.StringToHash((string)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v23+18]");
							if ((nint)0 != 0)
							{
								object obj29 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v26+A0]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v27+18]");
								object obj31 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v28+18]");
								object obj32 = 0 & 0xFFFFFFFEL;
								if (obj32 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v28+28]");
									int num3 = Animator.StringToHash((string)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v23+18]");
									object obj33 = 0 & 0xFFFFFFFEL;
									if (obj33 != null)
									{
										object obj34 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v30+A0]");
										object obj35 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v31+18]");
										object obj36 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v32+18]");
										bool flag3 = (nint)0 < (nint)2;
										object obj37 = !flag3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v32+18]");
										object obj38 = -2;
										bool flag4 = obj38 == null;
										object obj39 = ~obj37;
										object obj40 = obj39 | flag4;
										if (obj40 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v32+30]");
											int num4 = Animator.StringToHash((string)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v23+18]");
											bool flag5 = (nint)0 < (nint)2;
											object obj41 = !flag5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v23+18]");
											object obj42 = -2;
											bool flag6 = obj42 == null;
											object obj43 = ~obj41;
											object obj44 = obj43 | flag6;
											if (obj44 == null)
											{
												object obj45 = obj16;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v34+A0]");
												object obj46 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v35+18]");
												object obj47 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v36+18]");
												object obj48 = 0 & 0xFFFFFFFCL;
												if (obj48 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v36+38]");
													int num5 = Animator.StringToHash((string)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v23+18]");
													object obj49 = 0 & 0xFFFFFFFCL;
													if (obj49 != null)
													{
														object obj50 = obj16;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X9_v9+A0]");
														object obj51 = (nint)0 + (nint)40;
														object obj52 = default;
														obj51 = obj52;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private AudioSource _003CMakeVoices_003Eg__Voice_007C63_0(string name, bool loop, int priority, ref _003C_003Ec__DisplayClass63_0 P_3)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_0093: Expected Obj, but got VT
		//IL_00cf: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_02d2: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I
		//IL_0316: Expected Obj, but got I
		//IL_01e8: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD58]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4358]");
		object obj2 = 0;
		string text = (string)obj + name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		GameObject gameObject = default;
		gameObject._002Ector(text);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4350]");
				object obj3 = 0;
				transform.SetParent((Transform)P_3, worldPositionStays: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
				AudioSource audioSource = default;
				if ((object)audioSource != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CDD20]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C7B10]");
					object obj5 = 0;
					audioSource.playOnAwake = false;
					audioSource.loop = loop;
					audioSource.spatialBlend = 1f;
					audioSource.dopplerLevel = 0f;
					audioSource.priority = priority;
					audioSource.rolloffMode = (AudioRolloffMode)2;
					object obj6 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v20+E4]");
					bool flag = (nint)0 == 0;
					object obj7 = !flag;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = obj4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v20+A0]");
					object curve = 0;
					audioSource.SetCustomCurve((AudioSourceCurveType)0, (AnimationCurve)curve);
					object obj8 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v8+A0]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v9+8]");
					audioSource.SetCustomCurve((AudioSourceCurveType)2, (AnimationCurve)0);
					audioSource.volume = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3625EAC");
					Behaviour behaviour = default;
					if ((object)behaviour != null)
					{
						behaviour.enabled = false;
						AudioLowPassFilter[] array = lows;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X4 (<>c__DisplayClass63_0&)+10]");
						object obj10 = (nint)0 + (nint)1;
						if (lows != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X4 (<>c__DisplayClass63_0&)+10]");
							bool flag2 = (nint)0 < (nint)array.Length;
							object obj11 = !flag2;
							if (obj11 == null)
							{
								AudioLowPassFilter[] array2 = lows;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X4 (<>c__DisplayClass63_0&)+10]");
								object obj12 = array2 + 0;
								object obj13 = obj12 + 32;
								obj13 = behaviour;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								return audioSource;
							}
							goto IL_0287;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0287;
		IL_0287:
		return (AudioSource)(object)new IndexOutOfRangeException();
	}

	internal unsafe static bool _003CHear_003Eg__Blocked_007C65_0(Vector3 a, Vector3 b, ref NameTitles._003C_003Ec__DisplayClass65_0 P_2)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I4
		//IL_0044: Expected VT, but got I8
		//IL_0044: Expected VT, but got Ref
		//IL_00eb: Expected Obj, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected I4, but got Unknown
		//IL_00fe: Expected I4, but got Obj
		//IL_00cb: Expected Obj, but got F4
		//IL_00dd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4378]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RaycastHit raycastHit = default;
		QueryTriggerInteraction queryTriggerInteraction = default;
		object obj4;
		if (Physics.Linecast((Vector3)(&raycastHit), (Vector3)4294961403L, out *(RaycastHit*)1, 0, queryTriggerInteraction))
		{
			Collider collider = raycastHit.collider;
			if ((object)collider != null)
			{
				Transform transform = collider.transform;
				if ((object)transform != null)
				{
					bool flag2 = transform.IsChildOf((Transform)a.x);
					obj4 = (flag2 ? 1 : 0) ^ 1;
					goto IL_0136;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		obj4 = 0;
		goto IL_0136;
		IL_0136:
		return (byte)(obj4 & 1) != 0;
	}

	private Transform _003CBuildCurl_003Eg__Bone_007C121_0(string n)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C47E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @358F97C");
		object obj2 = default;
		if (obj2 == null)
		{
			goto IL_013a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 < (nint)1)
		{
			goto IL_0130;
		}
		object obj4 = obj2 + 32;
		object obj5 = 0;
		Transform result;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v6+v102 @ X22_v9*8]");
			if ((nint)0 == 0)
			{
				goto IL_013a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v6+v102 @ X22_v9*8]");
			string text = ((UnityEngine.Object)0).name;
			bool flag2 = text == n;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X23_v6+v102 @ X22_v9*8]");
			result = (Transform)0;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
				obj3 = 0;
				obj5++;
				object obj8 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
				if ((nint)obj8 < 0)
				{
					continue;
				}
				goto IL_0130;
			}
			goto IL_017d;
		}
		goto IL_0148;
		IL_013a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0148;
		IL_0148:
		return (Transform)(object)new IndexOutOfRangeException();
		IL_0130:
		result = null;
		goto IL_017d;
		IL_017d:
		return result;
	}

	internal static Vector3 _003CBuildCurl_003Eg__Past_007C121_1(Transform a, Transform b)
	{
		//IL_0079: Expected VT, but got Obj
		if ((object)b != null)
		{
			Vector3 position = b.position;
			Vector3 position2 = b.position;
			if ((object)a != null)
			{
				return a.position;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (Vector3)ex;
	}
}
