using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Fusion.LagCompensation;
using Fusion.Statistics;
using PlayFab.GroupsModels;
using PlayFab.MultiplayerModels;
using UnityEngine;

namespace Fusion;

public sealed class HitboxManager : SimulationBehaviour, _0021_00210, Action<InviteToGroupResponse>, _0021_00210, Action<JoinLobbyAsServerResult>
{
	public int BVHDepth;

	public int BVHNodes;

	public int TotalHitboxes;

	public LagCompensationDraw DrawInfo;

	private readonly List<LagCompensatedHit> _raycastHits;

	private RaycastQuery _raycastQuery;

	private RaycastAllQuery _raycastAllQuery;

	private SphereOverlapQuery _sphereOverlapQuery;

	private BoxOverlapQuery _boxOverlapQuery;

	private LagCompensationSettings _settings;

	private HitboxBuffer _hitboxBuffer;

	private readonly List<HitboxHit> _lagCompensatedHits;

	private LagCompensationStatisticsManager _lagCompStatManager;

	internal LagCompensationStatisticsSnapshot LagCompensationSnapshot
	{
		get
		{
			LagCompensationStatisticsManager lagCompStatManager = _lagCompStatManager;
			if (_lagCompStatManager != null)
			{
				return lagCompStatManager._previousUpdateSnapshot;
			}
			return (LagCompensationStatisticsSnapshot)(object)new NullReferenceException();
		}
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe bool Raycast(Vector3 origin, Vector3 direction, float length, PlayerRef player, out LagCompensatedHit hit, int layerMask = default(int), HitOptions options = default(HitOptions), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_02ed: Expected I4, but got Obj
		//IL_0048: Expected VT, but got F4
		//IL_00d6: Expected VT, but got I4
		//IL_010d: Expected VT, but got I4
		//IL_0144: Expected VT, but got I4
		//IL_0157: Expected I4, but got VT
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_0211: Expected Obj, but got I
		//IL_02b7: Expected native int or pointer, but got VT
		//IL_0263: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected I4, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		object obj = origin & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
		RaycastQuery raycastQuery = _raycastQuery;
		if (_raycastQuery != null)
		{
			raycastQuery.Player = (PlayerRef)origin;
			RaycastQuery raycastQuery2 = _raycastQuery;
			if (_raycastQuery != null)
			{
				raycastQuery2.Origin = (Vector3)length;
				RaycastQuery raycastQuery3 = _raycastQuery;
				if (_raycastQuery != null)
				{
					Vector3 direction2 = default;
					raycastQuery3.Direction = direction2;
					RaycastQuery raycastQuery4 = _raycastQuery;
					if (_raycastQuery != null)
					{
						float length2 = default;
						raycastQuery4.Length = length2;
						raycastQuery4.Tick = (int?)(object)0;
						RaycastQuery raycastQuery5 = _raycastQuery;
						if (_raycastQuery != null)
						{
							raycastQuery5.TickTo = (int?)(object)0;
							RaycastQuery raycastQuery6 = _raycastQuery;
							if (_raycastQuery != null)
							{
								raycastQuery6.Alpha = (float?)(object)0;
								RaycastQuery raycastQuery7 = _raycastQuery;
								LayerMask layerMask2 = (int)player;
								if (_raycastQuery != null)
								{
									raycastQuery7.LayerMask = layerMask2;
									if (_raycastQuery != null)
									{
										object obj2 = _raycastQuery + 64;
										obj2 = options;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										List<LagCompensatedHit> raycastHits = _raycastHits;
										if (_raycastHits != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
											object obj3 = (nint)0 + (nint)1;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
											if ((nint)0 >= (nint)1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
												nint num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
												Array.Clear((Array)num, 0, 0);
												raycastHits = _raycastHits;
											}
											int num2 = QueryInternal(_raycastQuery, raycastHits, clearHits: false);
											if (num2 > 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5F54");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
												object obj4 = direction + 8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											}
											else
											{
												_ = 0;
												((Vector3*)(nint)direction)->x = 0f;
												_ = 0;
												_ = 0;
												_ = 0;
												_ = 0;
												_ = 0;
											}
											bool flag = num2 < 0;
											bool flag2 = num2 == 0;
											int num3 = num2 ^ num2;
											int num4 = num2 & num3;
											bool flag3 = num4 < 0;
											bool flag4 = flag == flag3;
											object obj5 = !flag2;
											return (byte)((flag4 & obj5) ? 1 : 0) != 0;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public bool Raycast(Vector3 origin, Vector3 direction, float length, int tick, int? tickTo, float? alpha, out LagCompensatedHit hit, int layerMask = default(int), HitOptions options = default(HitOptions), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_0304: Expected I4, but got Obj
		//IL_0013: Expected VT, but got I4
		//IL_0049: Expected VT, but got F4
		//IL_00cc: Expected Obj, but got I
		//IL_00e6: Expected I4, but got VT
		//IL_00f4: Expected VT, but got I4
		//IL_0160: Expected VT, but got I4
		//IL_0173: Expected I4, but got VT
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_022d: Expected Obj, but got I
		//IL_02d3: Expected VT, but got I4
		//IL_027f: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I4
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected I4, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		RaycastQuery raycastQuery = _raycastQuery;
		if (_raycastQuery != null)
		{
			raycastQuery.Player = (PlayerRef)0;
			RaycastQuery raycastQuery2 = _raycastQuery;
			if (_raycastQuery != null)
			{
				raycastQuery2.Origin = (Vector3)length;
				RaycastQuery raycastQuery3 = _raycastQuery;
				if (_raycastQuery != null)
				{
					Vector3 direction2 = default;
					raycastQuery3.Direction = direction2;
					RaycastQuery raycastQuery4 = _raycastQuery;
					if (_raycastQuery != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
						object obj = 0;
						float length2 = default;
						raycastQuery4.Length = length2;
						int? num = (int)origin;
						raycastQuery4.Tick = (int?)(object)0;
						RaycastQuery raycastQuery5 = _raycastQuery;
						if (_raycastQuery != null)
						{
							raycastQuery5.TickTo = (int?)direction;
							RaycastQuery raycastQuery6 = _raycastQuery;
							if (_raycastQuery != null)
							{
								raycastQuery6.Alpha = (float?)(object)tick;
								RaycastQuery raycastQuery7 = _raycastQuery;
								LayerMask layerMask2 = (int)alpha;
								if (_raycastQuery != null)
								{
									raycastQuery7.LayerMask = layerMask2;
									if (_raycastQuery != null)
									{
										object obj2 = _raycastQuery + 64;
										obj2 = options;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										List<LagCompensatedHit> raycastHits = _raycastHits;
										if (_raycastHits != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
											object obj3 = (nint)0 + (nint)1;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
											if ((nint)0 >= (nint)1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
												nint num2 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X2_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
												Array.Clear((Array)num2, 0, 0);
												raycastHits = _raycastHits;
											}
											int num3 = QueryInternal(_raycastQuery, raycastHits, clearHits: false);
											if (num3 > 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5F54");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
												object obj4 = (_003F?)tickTo + 8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											}
											else
											{
												_ = 0;
												int? num4 = (int?)(object)0;
												_ = 0;
												_ = 0;
												_ = 0;
												_ = 0;
												_ = 0;
											}
											bool flag = num3 < 0;
											bool flag2 = num3 == 0;
											int num5 = num3 ^ num3;
											int num6 = num3 & num5;
											bool flag3 = num6 < 0;
											bool flag4 = flag == flag3;
											object obj5 = !flag2;
											return (byte)((flag4 & obj5) ? 1 : 0) != 0;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int RaycastAll(Vector3 origin, Vector3 direction, float length, PlayerRef player, List<LagCompensatedHit> hits, int layerMask = default(int), bool clearHits = default(bool), HitOptions options = default(HitOptions), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0250: Expected I4, but got Obj
		//IL_0088: Expected VT, but got F4
		//IL_0116: Expected VT, but got I4
		//IL_014d: Expected VT, but got I4
		//IL_0184: Expected VT, but got I4
		//IL_0197: Expected I4, but got VT
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected I4, but got Unknown
		//IL_0234: Expected Obj, but got VT
		object obj = origin & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
		RaycastAllQuery raycastAllQuery = _raycastAllQuery;
		if (_raycastAllQuery != null)
		{
			raycastAllQuery.Player = (PlayerRef)origin;
			RaycastAllQuery raycastAllQuery2 = _raycastAllQuery;
			if (_raycastAllQuery != null)
			{
				raycastAllQuery2.Origin = (Vector3)length;
				RaycastAllQuery raycastAllQuery3 = _raycastAllQuery;
				if (_raycastAllQuery != null)
				{
					Vector3 direction2 = default;
					raycastAllQuery3.Direction = direction2;
					RaycastAllQuery raycastAllQuery4 = _raycastAllQuery;
					if (_raycastAllQuery != null)
					{
						float length2 = default;
						raycastAllQuery4.Length = length2;
						raycastAllQuery4.Tick = (int?)(object)0;
						RaycastAllQuery raycastAllQuery5 = _raycastAllQuery;
						if (_raycastAllQuery != null)
						{
							raycastAllQuery5.TickTo = (int?)(object)0;
							RaycastAllQuery raycastAllQuery6 = _raycastAllQuery;
							if (_raycastAllQuery != null)
							{
								raycastAllQuery6.Alpha = (float?)(object)0;
								RaycastAllQuery raycastAllQuery7 = _raycastAllQuery;
								LayerMask layerMask2 = (int)player;
								if (_raycastAllQuery != null)
								{
									raycastAllQuery7.LayerMask = layerMask2;
									if (_raycastAllQuery != null)
									{
										object obj2 = _raycastAllQuery + 64;
										obj2 = options;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool clearHits2 = (byte)(hits & 1) != 0;
										return QueryInternal(_raycastAllQuery, (List<LagCompensatedHit>)direction, clearHits2);
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int RaycastAll(Vector3 origin, Vector3 direction, float length, int tick, int? tickTo, float? alpha, List<LagCompensatedHit> hits, int layerMask = default(int), bool clearHits = default(bool), HitOptions options = default(HitOptions), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_022c: Expected I4, but got Obj
		//IL_0013: Expected VT, but got I4
		//IL_0049: Expected VT, but got F4
		//IL_00cc: Expected Obj, but got I
		//IL_00e6: Expected I4, but got VT
		//IL_00f4: Expected VT, but got I4
		//IL_0160: Expected VT, but got I4
		//IL_0173: Expected I4, but got VT
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected I4, but got Unknown
		//IL_0210: Expected Obj, but got VT
		RaycastAllQuery raycastAllQuery = _raycastAllQuery;
		if (_raycastAllQuery != null)
		{
			raycastAllQuery.Player = (PlayerRef)0;
			RaycastAllQuery raycastAllQuery2 = _raycastAllQuery;
			if (_raycastAllQuery != null)
			{
				raycastAllQuery2.Origin = (Vector3)length;
				RaycastAllQuery raycastAllQuery3 = _raycastAllQuery;
				if (_raycastAllQuery != null)
				{
					Vector3 direction2 = default;
					raycastAllQuery3.Direction = direction2;
					RaycastAllQuery raycastAllQuery4 = _raycastAllQuery;
					if (_raycastAllQuery != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
						object obj = 0;
						float length2 = default;
						raycastAllQuery4.Length = length2;
						int? num = (int)origin;
						raycastAllQuery4.Tick = (int?)(object)0;
						RaycastAllQuery raycastAllQuery5 = _raycastAllQuery;
						if (_raycastAllQuery != null)
						{
							raycastAllQuery5.TickTo = (int?)direction;
							RaycastAllQuery raycastAllQuery6 = _raycastAllQuery;
							if (_raycastAllQuery != null)
							{
								raycastAllQuery6.Alpha = (float?)(object)tick;
								RaycastAllQuery raycastAllQuery7 = _raycastAllQuery;
								LayerMask layerMask2 = (int)alpha;
								if (_raycastAllQuery != null)
								{
									raycastAllQuery7.LayerMask = layerMask2;
									if (_raycastAllQuery != null)
									{
										object obj2 = _raycastAllQuery + 64;
										obj2 = options;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										bool clearHits2 = (byte)(hits & 1) != 0;
										return QueryInternal(_raycastAllQuery, (List<LagCompensatedHit>)tickTo, clearHits2);
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int OverlapSphere(Vector3 origin, float radius, PlayerRef player, List<LagCompensatedHit> hits, int layerMask = default(int), HitOptions options = default(HitOptions), bool clearHits = default(bool), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_020f: Expected I4, but got Obj
		//IL_0088: Expected VT, but got F4
		//IL_010c: Expected VT, but got I4
		//IL_0143: Expected VT, but got I4
		//IL_0156: Expected I4, but got Obj
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_01f3: Expected Obj, but got VT
		object obj = origin & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
		SphereOverlapQuery sphereOverlapQuery = _sphereOverlapQuery;
		if (_sphereOverlapQuery != null)
		{
			sphereOverlapQuery.Player = (PlayerRef)origin;
			SphereOverlapQuery sphereOverlapQuery2 = _sphereOverlapQuery;
			if (_sphereOverlapQuery != null)
			{
				sphereOverlapQuery2.Center = (Vector3)radius;
				SphereOverlapQuery sphereOverlapQuery3 = _sphereOverlapQuery;
				if (_sphereOverlapQuery != null)
				{
					float radius2 = default;
					sphereOverlapQuery3.Radius = radius2;
					int? tick = default;
					sphereOverlapQuery3.Tick = tick;
					SphereOverlapQuery sphereOverlapQuery4 = _sphereOverlapQuery;
					if (_sphereOverlapQuery != null)
					{
						sphereOverlapQuery4.TickTo = (int?)(object)0;
						SphereOverlapQuery sphereOverlapQuery5 = _sphereOverlapQuery;
						if (_sphereOverlapQuery != null)
						{
							sphereOverlapQuery5.Alpha = (float?)(object)0;
							SphereOverlapQuery sphereOverlapQuery6 = _sphereOverlapQuery;
							LayerMask layerMask2 = (int)hits;
							if (_sphereOverlapQuery != null)
							{
								sphereOverlapQuery6.LayerMask = layerMask2;
								if (_sphereOverlapQuery != null)
								{
									object obj2 = _sphereOverlapQuery + 64;
									obj2 = queryTriggerInteraction;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									bool clearHits2 = (byte)(options & (HitOptions)1) != 0;
									return QueryInternal(_sphereOverlapQuery, (List<LagCompensatedHit>)player, clearHits2);
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int OverlapSphere(Vector3 origin, float radius, int tick, int? tickTo, float? alpha, List<LagCompensatedHit> hits, int layerMask = default(int), HitOptions options = default(HitOptions), bool clearHits = default(bool), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_01ac: Expected I4, but got Obj
		//IL_0013: Expected VT, but got I4
		//IL_004c: Expected Obj, but got I
		//IL_0066: Expected I4, but got VT
		//IL_0074: Expected VT, but got I4
		//IL_00aa: Expected VT, but got I4
		//IL_00f3: Expected I4, but got Obj
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015a: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got VT
		SphereOverlapQuery sphereOverlapQuery = _sphereOverlapQuery;
		if (_sphereOverlapQuery != null)
		{
			sphereOverlapQuery.Player = (PlayerRef)0;
			SphereOverlapQuery sphereOverlapQuery2 = _sphereOverlapQuery;
			if (_sphereOverlapQuery != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
				object obj = 0;
				float radius2 = default;
				sphereOverlapQuery2.Radius = radius2;
				int? num = (int)origin;
				sphereOverlapQuery2.Tick = (int?)(object)0;
				SphereOverlapQuery sphereOverlapQuery3 = _sphereOverlapQuery;
				if (_sphereOverlapQuery != null)
				{
					sphereOverlapQuery3.TickTo = (int?)(object)tick;
					SphereOverlapQuery sphereOverlapQuery4 = _sphereOverlapQuery;
					if (_sphereOverlapQuery != null)
					{
						sphereOverlapQuery4.Alpha = tickTo;
						SphereOverlapQuery sphereOverlapQuery5 = _sphereOverlapQuery;
						LayerMask layerMask2 = (int)hits;
						if (_sphereOverlapQuery != null)
						{
							sphereOverlapQuery5.LayerMask = layerMask2;
							if (_sphereOverlapQuery != null)
							{
								object obj2 = _sphereOverlapQuery + 64;
								obj2 = queryTriggerInteraction;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								bool clearHits2 = (byte)(options & (HitOptions)1) != 0;
								return QueryInternal(_sphereOverlapQuery, (List<LagCompensatedHit>)alpha, clearHits2);
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int OverlapBox(Vector3 center, Vector3 extents, Quaternion orientation, PlayerRef player, List<LagCompensatedHit> hits, int layerMask = default(int), HitOptions options = default(HitOptions), bool clearHits = default(bool), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0287: Expected I4, but got Obj
		//IL_0108: Expected VT, but got I4
		//IL_0184: Expected VT, but got I4
		//IL_01bb: Expected VT, but got I4
		//IL_01ce: Expected I4, but got VT
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected I4, but got Unknown
		//IL_026b: Expected Obj, but got VT
		object obj = center & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
		BoxOverlapQuery boxOverlapQuery = _boxOverlapQuery;
		if (_boxOverlapQuery != null)
		{
			boxOverlapQuery.Player = (PlayerRef)center;
			BoxOverlapQuery boxOverlapQuery2 = _boxOverlapQuery;
			if (_boxOverlapQuery != null)
			{
				Vector3 center2 = default;
				boxOverlapQuery2.Center = center2;
				BoxOverlapQuery boxOverlapQuery3 = _boxOverlapQuery;
				if (_boxOverlapQuery != null)
				{
					Vector3 extents2 = default;
					boxOverlapQuery3.Extents = extents2;
					BoxOverlapQuery boxOverlapQuery4 = _boxOverlapQuery;
					if (_boxOverlapQuery != null)
					{
						boxOverlapQuery4.Rotation = (Quaternion)clearHits;
						BoxOverlapQuery boxOverlapQuery5 = _boxOverlapQuery;
						if (_boxOverlapQuery != null)
						{
							int? tick = default;
							boxOverlapQuery5.Tick = tick;
							BoxOverlapQuery boxOverlapQuery6 = _boxOverlapQuery;
							if (_boxOverlapQuery != null)
							{
								boxOverlapQuery6.TickTo = (int?)(object)0;
								BoxOverlapQuery boxOverlapQuery7 = _boxOverlapQuery;
								if (_boxOverlapQuery != null)
								{
									boxOverlapQuery7.Alpha = (float?)(object)0;
									BoxOverlapQuery boxOverlapQuery8 = _boxOverlapQuery;
									LayerMask layerMask2 = (int)orientation;
									if (_boxOverlapQuery != null)
									{
										boxOverlapQuery8.LayerMask = layerMask2;
										if (_boxOverlapQuery != null)
										{
											object obj2 = _boxOverlapQuery + 64;
											obj2 = options;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool clearHits2 = (byte)(hits & 1) != 0;
											return QueryInternal(_boxOverlapQuery, (List<LagCompensatedHit>)extents, clearHits2);
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int OverlapBox(Vector3 center, Vector3 extents, Quaternion orientation, int tick, int? tickTo, float? alpha, List<LagCompensatedHit> hits, int layerMask = default(int), HitOptions options = default(HitOptions), bool clearHits = default(bool), QueryTriggerInteraction queryTriggerInteraction = default(QueryTriggerInteraction), PreProcessingDelegate preProcessRoots = null)
	{
		//IL_0264: Expected I4, but got Obj
		//IL_0013: Expected VT, but got I4
		//IL_00c9: Expected VT, but got I4
		//IL_00de: Expected Obj, but got I
		//IL_00ff: Expected I4, but got VT
		//IL_012c: Expected VT, but got I4
		//IL_01ab: Expected I4, but got VT
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected I4, but got Unknown
		//IL_0248: Expected Obj, but got I4
		BoxOverlapQuery boxOverlapQuery = _boxOverlapQuery;
		if (_boxOverlapQuery != null)
		{
			boxOverlapQuery.Player = (PlayerRef)0;
			BoxOverlapQuery boxOverlapQuery2 = _boxOverlapQuery;
			if (_boxOverlapQuery != null)
			{
				Vector3 center2 = default;
				boxOverlapQuery2.Center = center2;
				BoxOverlapQuery boxOverlapQuery3 = _boxOverlapQuery;
				if (_boxOverlapQuery != null)
				{
					Vector3 extents2 = default;
					boxOverlapQuery3.Extents = extents2;
					BoxOverlapQuery boxOverlapQuery4 = _boxOverlapQuery;
					if (_boxOverlapQuery != null)
					{
						boxOverlapQuery4.Rotation = (Quaternion)layerMask;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CE3F8]");
						object obj = 0;
						BoxOverlapQuery boxOverlapQuery5 = _boxOverlapQuery;
						int? num = (int)center;
						if (_boxOverlapQuery != null)
						{
							boxOverlapQuery5.Tick = (int?)(object)0;
							BoxOverlapQuery boxOverlapQuery6 = _boxOverlapQuery;
							if (_boxOverlapQuery != null)
							{
								boxOverlapQuery6.TickTo = (int?)extents;
								BoxOverlapQuery boxOverlapQuery7 = _boxOverlapQuery;
								if (_boxOverlapQuery != null)
								{
									boxOverlapQuery7.Alpha = (float?)orientation;
									BoxOverlapQuery boxOverlapQuery8 = _boxOverlapQuery;
									LayerMask layerMask2 = (int)tickTo;
									if (_boxOverlapQuery != null)
									{
										boxOverlapQuery8.LayerMask = layerMask2;
										if (_boxOverlapQuery != null)
										{
											object obj2 = _boxOverlapQuery + 64;
											obj2 = queryTriggerInteraction;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											bool clearHits2 = (byte)(hits & 1) != 0;
											return QueryInternal(_boxOverlapQuery, (List<LagCompensatedHit>)tick, clearHits2);
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void PositionRotation(Hitbox hitbox, int tick, out Vector3 position, out Quaternion rotation, bool subtickAccuracy = default(bool), int? tickTo = null, float? alpha = null)
	{
		//IL_001d: Expected Obj, but got Ref
		//IL_0028: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got Ref
		bool flag = !subtickAccuracy;
		object obj2 = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 56));
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PositionRotationQueryParams param = default;
		PositionRotationInternal(ref param, out position, out rotation);
	}

	public unsafe void PositionRotation(Hitbox hitbox, PlayerRef player, out Vector3 position, out Quaternion rotation, bool subTickAccuracy = default(bool))
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got Ref
		//IL_009e: Expected Obj, but got Ref
		object obj = player & 0xFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
		bool flag = !subTickAccuracy;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
		}
		int? num = default;
		int value = num.Value;
		PositionRotationQueryParams positionRotationQueryParams = default;
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref positionRotationQueryParams, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref positionRotationQueryParams, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		PositionRotationQueryParams param = default;
		PositionRotationInternal(ref param, out position, out rotation);
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe static LagCompensatedHit GetClosestHit(List<LagCompensatedHit> hits)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0018: Expected Obj, but got Ref
		//IL_0190: Expected VT, but got Obj
		//IL_00a7: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		//IL_0100: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69B0]");
		object error = 0;
		object obj2 = default;
		object obj = (object)(&obj2);
		bool flag = hits == null;
		bool condition = !flag;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Assert.Check(condition, (string)error);
		if (hits != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			bool flag2 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			int num2 = (int)(num ^ 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			int num3 = (int)((nint)0 & (nint)num2);
			bool flag4 = num3 < 0;
			bool flag5 = flag2 == flag4;
			object obj3 = !flag3;
			bool flag6 = (byte)((flag5 & obj3) ? 1 : 0) != 0;
			bool condition2 = flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			Assert.Check(condition2, 0);
			LagCompensatedHit lagCompensatedHit = hits.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
			bool flag7 = (nint)0 < (nint)2;
			object obj4 = 0;
			int index = 0;
			if (!flag7)
			{
				object obj6 = default;
				object obj5 = obj6;
				int num4 = 1;
				int num5 = 0;
				bool flag8;
				do
				{
					LagCompensatedHit lagCompensatedHit2 = hits.get_Item(num4);
					object obj7 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5)) ? obj5 : obj6);
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
					{
						num5 = num4;
					}
					num4++;
					int num6 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X0 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
					flag8 = (nint)num6 < (nint)0;
					obj4 = obj6;
					index = num5;
					obj5 = obj7;
				}
				while (flag8);
			}
			LagCompensatedHit lagCompensatedHit3 = hits.get_Item(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
			LagCompensatedHit result = default;
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (LagCompensatedHit)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe bool Raycast(RaycastQuery query, out LagCompensatedHit hit)
	{
		//IL_017c: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected I4, but got Unknown
		//IL_012d: Expected Obj, but got Ref
		if (query != null)
		{
			object obj = query + 32;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = query + 56;
				object obj4 = query + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
			}
			List<LagCompensatedHit> raycastHits = _raycastHits;
			if (_raycastHits != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X2_v5 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
				object obj5 = (nint)0 + (nint)1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X2_v5 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X2_v5 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X2_v5 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
					Array.Clear((Array)num, 0, 0);
					raycastHits = _raycastHits;
				}
				int num2 = QueryInternal(query, raycastHits, clearHits: false);
				if (num2 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5F54");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
					object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref hit, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
				}
				else
				{
					_ = 0;
					ref LagCompensatedHit reference = ref *(LagCompensatedHit*)null;
					_ = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					_ = 0;
				}
				bool flag2 = num2 < 0;
				bool flag3 = num2 == 0;
				int num3 = num2 ^ num2;
				int num4 = num2 & num3;
				bool flag4 = num4 < 0;
				bool flag5 = flag2 == flag4;
				object obj7 = !flag3;
				return (byte)((flag5 & obj7) ? 1 : 0) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int RaycastAll(RaycastAllQuery query, List<LagCompensatedHit> hits, bool clearHits = default(bool))
	{
		//IL_008f: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I, but got Unknown
		if (query != null)
		{
			object obj = query + 32;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = query + 56;
				nint num = (nint)(query + 48);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
			}
			return QueryInternal(query, hits, clearHits);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int OverlapSphere(SphereOverlapQuery query, List<LagCompensatedHit> hits, bool clearHits = default(bool))
	{
		//IL_008f: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I, but got Unknown
		if (query != null)
		{
			object obj = query + 32;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = query + 56;
				nint num = (nint)(query + 48);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
			}
			return QueryInternal(query, hits, clearHits);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public int OverlapBox(BoxOverlapQuery query, List<LagCompensatedHit> hits, bool clearHits = default(bool))
	{
		//IL_008f: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected I, but got Unknown
		if (query != null)
		{
			object obj = query + 32;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = query + 56;
				nint num = (nint)(query + 48);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30C5D7C");
			}
			return QueryInternal(query, hits, clearHits);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	[MethodImpl((MethodImplOptions)256)]
	public unsafe void GetPlayerTickAndAlpha(PlayerRef player, out int? tickFrom, out int? tickTo, out float? alpha)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected VT, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_01d3: Expected I4, but got Obj
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0096: Expected I4, but got VT
		//IL_01e9: Expected Obj, but got I
		//IL_01fb: Expected I4, but got VT
		//IL_0159: Expected F4, but got I
		NetworkRunner runner = base._runner;
		PlayerRef player2 = (PlayerRef)(player & 0xFFFFFFFFL);
		SimulationInput inputForPlayer = runner._simulation.GetInputForPlayer(player2);
		int value;
		int? num;
		ref int? reference;
		ref int? reference2;
		ref float? reference3;
		if (inputForPlayer != null)
		{
			bool isClient = base._runner.IsClient;
			ref SimulationInputHeader header = ref inputForPlayer.Header;
			if (!isClient)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v16 (Fusion.SimulationInputHeader&)+8]");
				num = 0;
				reference = ref *(int?*)null;
				ref SimulationInputHeader header2 = ref inputForPlayer.Header;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v19 (Fusion.SimulationInputHeader&)+C]");
				int? num2 = 0;
				reference2 = ref *(int?*)null;
				ref SimulationInputHeader header3 = ref inputForPlayer.Header;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v22 (Fusion.SimulationInputHeader&)+4]");
				float? num3 = 0f;
				reference3 = ref *(float?*)null;
				goto IL_01d9;
			}
			value = (int)header;
		}
		else
		{
			object obj;
			if (_hitboxBuffer != null)
			{
				_003CPrivateImplementationDetails_003E.HitboxSnapshot current = _hitboxBuffer.Current;
				obj = current + 48;
			}
			else
			{
				NetworkRunner runner2 = base._runner;
				obj = runner2._simulation + 80;
			}
			value = (int)obj;
		}
		num = value;
		reference = ref *(int?*)null;
		reference2 = ref *(int?*)null;
		reference3 = ref *(float?*)null;
		goto IL_01d9;
		IL_01d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6980]");
		object error = 0;
		Assert.Check((byte)(int)tickFrom != 0, (string)error);
	}

	private unsafe int QueryInternal(Query query, List<LagCompensatedHit> hits, bool clearHits)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0eb8: Expected Obj, but got I4
		//IL_079b: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		//IL_0f65: Expected Obj, but got I
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f82: Expected Obj, but got Unknown
		//IL_0f92: Expected Obj, but got I
		//IL_0fa2: Expected Obj, but got I
		//IL_101b: Expected I4, but got Obj
		//IL_07c0: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_024e: Expected Obj, but got I
		//IL_0268: Expected I4, but got VT
		//IL_02ae: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_0819: Expected Obj, but got I
		//IL_0826: Expected I4, but got Obj
		//IL_085a: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I4
		//IL_01e1: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_0fd7: Expected Obj, but got I
		//IL_1000: Expected Obj, but got Ref
		//IL_033d: Expected Obj, but got I
		//IL_08a4: Expected Obj, but got VT
		//IL_03fc: Expected Obj, but got I4
		//IL_08c0: Expected Obj, but got Ref
		//IL_045d: Expected Obj, but got I4
		//IL_08d6: Expected I, but got Obj
		//IL_08e6: Expected Obj, but got I
		//IL_090f: Expected Obj, but got I
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected Obj, but got Unknown
		//IL_047c: Expected Obj, but got I
		//IL_048c: Expected Obj, but got I
		//IL_04c0: Expected Obj, but got I4
		//IL_0e65: Expected I4, but got Obj
		//IL_0ee5: Expected Obj, but got I
		//IL_09b3: Expected Obj, but got I
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected Obj, but got Unknown
		//IL_0502: Expected Obj, but got I
		//IL_0520: Expected Obj, but got I
		//IL_054e: Expected Obj, but got I4
		//IL_0556: Expected Obj, but got Ref
		//IL_09e2: Expected I, but got Obj
		//IL_09f2: Expected Obj, but got I
		//IL_0a1b: Expected Obj, but got I
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected Obj, but got Unknown
		//IL_0a8d: Expected Obj, but got I
		//IL_0599: Expected Obj, but got I
		//IL_05a9: Expected Obj, but got I
		//IL_05d2: Expected Obj, but got I4
		//IL_05ef: Expected Obj, but got I
		//IL_0abd: Expected Obj, but got Ref
		//IL_069e: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I
		//IL_06c5: Expected VT, but got Ref
		//IL_06d5: Expected Obj, but got I
		//IL_06dd: Expected Obj, but got Ref
		//IL_06ed: Expected Obj, but got I
		//IL_0b39: Expected Obj, but got I4
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected Obj, but got Unknown
		//IL_0726: Expected Obj, but got I4
		//IL_0616: Expected Obj, but got I
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0641: Expected Obj, but got I
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_0ad3: Expected I, but got Obj
		//IL_0ae3: Expected Obj, but got I
		//IL_0b0c: Expected Obj, but got I
		//IL_0684: Expected Obj, but got I4
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected Obj, but got Unknown
		//IL_0bcf: Expected Obj, but got Ref
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_0be5: Expected I, but got Obj
		//IL_0bf5: Expected Obj, but got I
		//IL_0c1e: Expected Obj, but got I
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected Obj, but got Unknown
		//IL_0c90: Expected Obj, but got I
		//IL_0cb6: Expected Obj, but got Ref
		//IL_0d32: Expected Obj, but got I4
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected Obj, but got Unknown
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected I4, but got Unknown
		//IL_0ccc: Expected I, but got Obj
		//IL_0cdc: Expected Obj, but got I
		//IL_0d05: Expected Obj, but got I
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected Obj, but got Unknown
		//IL_0dab: Expected Obj, but got I
		//IL_0dd1: Expected Obj, but got I
		HitboxHit hitboxHit = default;
		object obj = (object)(&hitboxHit);
		_ = 0;
		_ = 0;
		bool flag = (object)base._runner == null;
		List<LagCompensatedHit> list = hits;
		string text = (string)(object)query;
		HitboxManager hitboxManager = this;
		Query query2 = query;
		List<LagCompensatedHit> list2 = hits;
		bool flag2 = clearHits;
		string text2 = (string)109895680;
		object obj12 = default;
		Simulation simulation = default;
		object obj27 = default;
		if (!flag)
		{
			Topologies topology = base._runner.Topology;
			object obj2 = topology - 2;
			if (topology == (Topologies)2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
				object obj3 = 0;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v59+A0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v60+18]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v60+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69A8]");
					object obj7 = 0;
					object obj8 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v329 @ X9_v20+198] (should have been resolved before IL gen)");
				}
				list2 = null;
				goto IL_1016;
			}
			bool flag3 = !clearHits;
			list = hits;
			text = null;
			if (!flag3)
			{
				bool flag4 = hits == null;
				list = hits;
				text = null;
				hitboxManager = this;
				query2 = query;
				list2 = hits;
				flag2 = clearHits;
				text2 = (string)109895680;
				if (flag4)
				{
					goto IL_077a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
				object obj9 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
				obj2 = -1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
				bool flag5 = (nint)0 < (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
				list = (List<LagCompensatedHit>)0;
				text = null;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
					Array.Clear((Array)num, 0, 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
					list = (List<LagCompensatedHit>)0;
					text = null;
				}
			}
			bool flag6 = query == null;
			hitboxManager = this;
			query2 = query;
			list2 = hits;
			flag2 = clearHits;
			text2 = (string)109895680;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69A0]");
				object obj10 = 0;
				text = (string)obj10;
				Assert.Check((byte)(int)query.Tick != 0, (string)obj10);
				List<HitboxHit> lagCompensatedHits = _lagCompensatedHits;
				bool flag7 = _lagCompensatedHits == null;
				list = null;
				hitboxManager = this;
				query2 = query;
				list2 = hits;
				flag2 = clearHits;
				text2 = (string)109895680;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v45 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+1C]");
					object obj11 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v45 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					obj2 = -1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v45 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v45 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+10]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v45 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
						Array.Clear((Array)num2, 0, 0);
						text = null;
					}
					bool flag8 = _hitboxBuffer == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v45 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
					list = (List<LagCompensatedHit>)0;
					hitboxManager = this;
					query2 = query;
					list2 = hits;
					flag2 = clearHits;
					text2 = (string)109895680;
					if (!flag8)
					{
						bool flag9 = _hitboxBuffer.PerformQuery(query, _lagCompensatedHits);
						bool flag10 = hits == null;
						list = (List<LagCompensatedHit>)(object)_lagCompensatedHits;
						text = (string)(object)query;
						hitboxManager = this;
						query2 = query;
						list2 = hits;
						flag2 = clearHits;
						text2 = (string)109895680;
						if (!flag10)
						{
							List<HitboxHit> lagCompensatedHits2 = _lagCompensatedHits;
							bool flag11 = _lagCompensatedHits == null;
							list = (List<LagCompensatedHit>)(object)_lagCompensatedHits;
							text = (string)(object)query;
							hitboxManager = this;
							query2 = query;
							list2 = hits;
							flag2 = clearHits;
							text2 = (string)109895680;
							if (!flag11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
								obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66A8]");
								object obj13 = 0;
								object obj15 = default;
								object obj14 = obj15;
								object obj17 = default;
								object obj16 = obj17;
								List<LagCompensatedHit> list3 = (List<LagCompensatedHit>)(object)_lagCompensatedHits;
								string text3 = (string)(object)query;
								bool flag12 = false;
								string text4 = (string)109895680;
								while (true)
								{
									bool flag13 = flag12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v70 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
									obj2 = (nint)(flag13 ? 1 : 0) - (nint)0;
									bool flag14 = flag12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v70 (System.Collections.Generic.List`1<Fusion.LagCompensation.HitboxHit>)+18]");
									bool flag5 = (nint)(flag14 ? 1 : 0) >= (nint)0;
									obj15 = obj14;
									obj17 = obj16;
									list = list3;
									text = text3;
									hitboxManager = this;
									query2 = query;
									list2 = hits;
									flag2 = flag12;
									text2 = text4;
									if (flag5)
									{
										break;
									}
									HitboxHit hitboxHit2 = lagCompensatedHits2.get_Item(flag12 ? 1 : 0);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
									LagCompensatedHit lagCompensatedHit = LagCompensatedHit.FromHitboxHit(ref hitboxHit);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
									object obj18 = 0;
									object obj19 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+1C]");
									obj17 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
									bool flag15 = (nint)0 == 0;
									obj15 = obj14;
									list = (List<LagCompensatedHit>)80;
									text = (string)(&simulation);
									hitboxManager = this;
									query2 = query;
									list2 = hits;
									flag2 = flag12;
									text2 = text4;
									if (!flag15)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
										obj17 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v50+18]");
										obj15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
										nint num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v50+18]");
										bool flag16 = num3 < 0;
										object obj20 = !flag16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
										nint num4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v50+18]");
										obj2 = num4 - 0;
										if (obj20 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
											object obj21 = (nint)0 * (nint)104;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+10]");
											text2 = (string)(0 + obj21);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [hits @ X2 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
											object obj22 = (nint)0 + (nint)1;
											object obj23 = text2 + 32;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
											object obj24 = text2 + 40;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											list = (List<LagCompensatedHit>)104;
											text = null;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X9_v18+20]");
											object obj25 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v52+A8]");
											object obj26 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @610D090");
											hits.AddWithResize((LagCompensatedHit)(&obj27));
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v53+70]");
											list = (List<LagCompensatedHit>)0;
											text = (string)(&obj27);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v53+70]");
											text2 = (string)0;
										}
										lagCompensatedHits2 = _lagCompensatedHits;
										flag2 = (byte)((flag12 ? 1u : 0u) + 1u) != 0;
										bool flag17 = _lagCompensatedHits == null;
										object obj28 = !flag17;
										hitboxManager = this;
										query2 = query;
										list2 = hits;
										obj14 = obj15;
										obj16 = obj17;
										list3 = list;
										text3 = text;
										flag12 = flag2;
										text4 = text2;
										if (obj28 != null)
										{
											continue;
										}
									}
									goto IL_077a;
								}
								goto IL_0788;
							}
						}
					}
				}
			}
		}
		goto IL_077a;
		IL_077a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0788;
		IL_0788:
		object obj29 = query2.Options & (HitOptions)3;
		if (obj29 != null)
		{
			nint num5 = (nint)query2;
			int hashCode = query2.GetHashCode();
			list = list2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj30 = 0;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X21_v4 (System.Collections.Generic.List`1<Fusion.LagCompensatedHit>)+18]");
		list2 = (List<LagCompensatedHit>)(0 - obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v8+A0]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v9+D8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v9+D8]");
		if ((nint)0 != 0)
		{
			NetworkRunner runner = ((SimulationBehaviour)hitboxManager)._runner;
			if ((object)((SimulationBehaviour)hitboxManager)._runner != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C41D8]");
				object obj34 = 0;
				flag2 = (byte)(int)runner._simulation != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
				NetworkRunner runner2 = ((SimulationBehaviour)hitboxManager)._runner;
				bool flag18 = (object)((SimulationBehaviour)hitboxManager)._runner == null;
				text = (string)5;
				if (!flag18)
				{
					Simulation simulation2 = runner2._simulation;
					if ((object)runner2._simulation != null)
					{
						simulation2 = (Simulation)simulation2._tick;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6430]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
					HitboxManager hitboxManager2 = default;
					bool flag19 = (object)hitboxManager2 == null;
					simulation = simulation2;
					text = (string)(&simulation);
					hitboxManager = hitboxManager2;
					if (!flag19)
					{
						string text5 = default;
						bool flag20 = text5 == null;
						string text6 = (string)(&simulation);
						IndexOutOfRangeException ex2 = default;
						string text7;
						if (!flag20)
						{
							nint num6 = (nint)hitboxManager2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v38 (Il2CppClass<Fusion.HitboxManager>)+40]");
							text6 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
							bool flag21 = ex2 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v38 (Il2CppClass<Fusion.HitboxManager>)+40]");
							text7 = (string)0;
							if (flag21)
							{
								goto IL_0e48;
							}
						}
						if (((MonoBehaviour)hitboxManager2).m_CancellationTokenSource != null)
						{
							object obj36 = hitboxManager2 + 32;
							obj36 = text5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64CA8");
							object obj37 = default;
							bool flag22 = obj37 == null;
							simulation = simulation2;
							hitboxManager = hitboxManager2;
							if (flag22)
							{
								goto IL_077a;
							}
							object obj38 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v18+1C0]");
							text6 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v608 @ X8_v18+1B8] (should have been resolved before IL gen)");
							object obj39 = default;
							if (obj39 != null)
							{
								nint num7 = (nint)hitboxManager2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v37 (Il2CppClass<Fusion.HitboxManager>)+40]");
								text6 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
								bool flag23 = ex2 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v37 (Il2CppClass<Fusion.HitboxManager>)+40]");
								text7 = (string)0;
								if (flag23)
								{
									goto IL_0e48;
								}
							}
							object obj40 = ((MonoBehaviour)hitboxManager2).m_CancellationTokenSource & 0xFFFFFFFEL;
							if (obj40 != null)
							{
								object obj41 = hitboxManager2 + 40;
								obj41 = obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D5500]");
								obj12 = 0;
								_ = query2.Tick;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
								string text8 = default;
								bool flag24 = text8 == null;
								text6 = (string)(&obj27);
								if (!flag24)
								{
									nint num8 = (nint)hitboxManager2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v36 (Il2CppClass<Fusion.HitboxManager>)+40]");
									text6 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
									bool flag25 = ex2 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v36 (Il2CppClass<Fusion.HitboxManager>)+40]");
									text7 = (string)0;
									if (flag25)
									{
										goto IL_0e48;
									}
								}
								bool flag26 = (nint)((MonoBehaviour)hitboxManager2).m_CancellationTokenSource < 2;
								object obj42 = !flag26;
								object obj43 = ((MonoBehaviour)hitboxManager2).m_CancellationTokenSource - 2;
								bool flag27 = obj43 == null;
								object obj44 = ~obj42;
								object obj45 = obj44 | flag27;
								if (obj45 == null)
								{
									object obj46 = hitboxManager2 + 48;
									obj46 = text8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
									_ = query2.TickTo;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
									object obj47 = default;
									bool flag28 = obj47 == null;
									object obj48 = default;
									text6 = (string)(&obj48);
									if (!flag28)
									{
										nint num9 = (nint)hitboxManager2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v35 (Il2CppClass<Fusion.HitboxManager>)+40]");
										text6 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
										bool flag29 = ex2 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v35 (Il2CppClass<Fusion.HitboxManager>)+40]");
										text7 = (string)0;
										if (flag29)
										{
											goto IL_0e48;
										}
									}
									object obj49 = ((MonoBehaviour)hitboxManager2).m_CancellationTokenSource & 0xFFFFFFFCL;
									if (obj49 != null)
									{
										object obj50 = hitboxManager2 + 56;
										obj50 = obj47;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
										object obj51 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F90");
										Query query3 = default;
										bool flag30 = query3 == null;
										List<LagCompensatedHit> list4 = default;
										text6 = (string)(&list4);
										if (!flag30)
										{
											nint num10 = (nint)hitboxManager2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v34 (Il2CppClass<Fusion.HitboxManager>)+40]");
											text6 = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64F8C");
											bool flag31 = ex2 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v34 (Il2CppClass<Fusion.HitboxManager>)+40]");
											text7 = (string)0;
											if (flag31)
											{
												goto IL_0e48;
											}
										}
										bool flag32 = (nint)((MonoBehaviour)hitboxManager2).m_CancellationTokenSource < 4;
										object obj52 = !flag32;
										object obj2 = ((MonoBehaviour)hitboxManager2).m_CancellationTokenSource - 4;
										bool flag33 = obj2 == null;
										object obj53 = ~obj52;
										if (((obj53 | flag33) ? 1 : 0) == 0)
										{
											object obj54 = hitboxManager2 + 64;
											obj54 = query3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6998]");
											object format = 0;
											string text9 = string.Format((string)format, (object[])(object)hitboxManager2);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X25_v4+10]");
											object obj55 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X25_v4+10]");
											bool flag34 = (nint)0 == 0;
											simulation = simulation2;
											list4 = list2;
											list = null;
											hitboxManager = hitboxManager2;
											query2 = query3;
											if (flag34)
											{
												goto IL_077a;
											}
											object obj56 = obj55;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v370 @ X9_v12+188] (should have been resolved before IL gen)");
											goto IL_1016;
										}
									}
								}
							}
						}
						ex2 = new IndexOutOfRangeException();
						text7 = text6;
						goto IL_0e48;
					}
				}
			}
			goto IL_077a;
		}
		goto IL_1016;
		IL_1016:
		return (int)list2;
		IL_0e48:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65394");
		ArgumentNullException ex3 = new ArgumentNullException();
		return (int)ex3;
	}

	private unsafe void PositionRotationInternal(ref PositionRotationQueryParams param, out Vector3 position, out Quaternion rotation)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_008b: Expected VT, but got Ref
		//IL_0094: Invalid comparison between VT and I4
		//IL_00b2: Expected Ref, but got VT
		//IL_00f0: Expected Obj, but got I
		if (base._runner.IsClient)
		{
			_ = 0;
			_ = 0;
		}
		else
		{
			object obj = param & 4;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				float? num = (float?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref param, 28));
				if (num != (object)0)
				{
					float value = ((float?*)num)->Value;
					if ((double)value > 0.5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [param @ X1 (Fusion.LagCompensation.PositionRotationQueryParams&)+10]");
						object obj3 = (nint)0 + (nint)1;
					}
				}
			}
		}
		_hitboxBuffer.PositionQueryInternal(ref param, out position, out rotation);
	}

	private void Init()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		NetworkRunner runner = base._runner;
		NetworkProjectConfig config = runner._config;
		object obj = this + 136;
		obj = config.LagCompensation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69B8]");
			object obj3 = 0;
			List<HitboxRoot> objects = GetObjects(base._runner);
			Init(objects);
			InitQueries();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
			LagCompensationDraw lagCompensationDraw = default;
			lagCompensationDraw._002Ector(_hitboxBuffer);
			object obj4 = this + 88;
			obj4 = lagCompensationDraw;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D4230]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v10+A0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69C0]");
			object obj9 = 0;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ X9_v3+188] (should have been resolved before IL gen)");
		}
		base._runner.RemoveGlobal(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4138]");
		object obj11 = 0;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy(this);
	}

	private void InitQueries()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		LagCompensationSettings settings = _settings;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A08]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64CFCD0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D66D0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A00]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4470]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6690]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69F8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RaycastQuery raycastQuery = default;
		RaycastQueryParams raycastQueryParams = default;
		raycastQuery._002Ector(ref raycastQueryParams);
		object obj9 = this + 104;
		obj9 = raycastQuery;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		RaycastAllQuery raycastAllQuery = default;
		RaycastHit[] physXRaycastHitsCache = default;
		RaycastHit2D[] box2DRaycastHitCache = default;
		raycastAllQuery._002Ector(ref raycastQueryParams, physXRaycastHitsCache, box2DRaycastHitCache);
		object obj10 = this + 112;
		obj10 = raycastAllQuery;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		SphereOverlapQuery sphereOverlapQuery = default;
		SphereOverlapQueryParams sphereOverlapParams = default;
		Collider[] physXOverlapHitsCache = default;
		Collider2D[] box2DOverlapHitsCache = default;
		sphereOverlapQuery._002Ector(ref sphereOverlapParams, physXOverlapHitsCache, box2DOverlapHitsCache);
		object obj11 = this + 120;
		obj11 = sphereOverlapQuery;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64EF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		BoxOverlapQuery boxOverlapQuery = default;
		BoxOverlapQueryParams boxOverlapParams = default;
		Collider[] physXOverlapHitsCache2 = default;
		Collider2D[] box2DOverlapHitsCache2 = default;
		boxOverlapQuery._002Ector(ref boxOverlapParams, physXOverlapHitsCache2, box2DOverlapHitsCache2);
		object obj12 = this + 128;
		obj12 = boxOverlapQuery;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private void Init(List<HitboxRoot> initialObjects)
	{
		//IL_0158: Expected Obj, but got I
		//IL_0182: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I4, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected I4, but got Unknown
		//IL_020c: Expected Obj, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected I4, but got Unknown
		//IL_029c: Expected F4, but got I
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		LagCompensationSettings settings = _settings;
		NetworkRunner runner = base._runner;
		ref SimulationRuntimeConfig runtimeConfigRef = ref runner._simulation.RuntimeConfigRef;
		LagCompensationSettings settings2 = _settings;
		int num = settings2.HitboxDefaultCapacity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4150]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = settings.HitboxBufferLengthInMs - 30;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = obj4 == null;
		int num2 = settings.HitboxBufferLengthInMs ^ 0x1E;
		int num3 = settings.HitboxBufferLengthInMs ^ obj4;
		int num4 = num2 & num3;
		bool flag4 = num4 < 0;
		bool flag5 = flag2 == flag4;
		object obj5 = !flag3;
		object obj6 = flag5 & obj5;
		object obj7 = ~obj6;
		int num5 = ((obj7 != null) ? 30 : settings.HitboxBufferLengthInMs);
		object obj8 = num - 16;
		bool flag6 = (nint)obj8 < 0;
		bool flag7 = obj8 == null;
		int num6 = num ^ 0x10;
		int num7 = num ^ obj8;
		int num8 = num6 & num7;
		bool flag8 = num8 < 0;
		bool flag9 = flag6 == flag8;
		object obj9 = !flag7;
		object obj10 = flag9 & obj9;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			num = 16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69F0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107AFC4]");
		object obj13 = (nint)num5 * (nint)0;
		int bufferSize = obj13 * runtimeConfigRef;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		int hitboxCapacity = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107ABB4]");
		HitboxBuffer hitboxBuffer = default;
		hitboxBuffer._002Ector(initialObjects, bufferSize, hitboxCapacity, 0f);
		object obj14 = this + 144;
		obj14 = hitboxBuffer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
	}

	private List<HitboxRoot> GetObjects(NetworkRunner runner)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I
		//IL_04aa: Expected Obj, but got I
		//IL_04cc: Expected Obj, but got I4
		//IL_004d: Expected VT, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I8
		//IL_00c8: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_04f3: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I4
		//IL_01a6: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0261: Expected I4, but got Obj
		//IL_029d: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I
		//IL_034e: Expected Obj, but got I
		//IL_035e: Expected Obj, but got I
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69C8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69D0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69D8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<System.__Canon> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj3);
		SimulationBehaviour[] allBehaviours = runner.GetAllBehaviours(typeFromHandle);
		if (allBehaviours.Length >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69E0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69E8]");
			object obj8 = 0;
			object obj9 = allBehaviours.Length & 0xFFFFFFFFL;
			object obj10 = 0;
			Type type = typeFromHandle;
			SimulationBehaviour[] array = allBehaviours;
			object obj11 = 0;
			object obj15 = default;
			int num2 = default;
			int num4 = default;
			bool flag8;
			do
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
				object obj12 = !flag2;
				object obj14;
				int num;
				int num3;
				object obj16;
				Type type3;
				SimulationBehaviour[] array2;
				if (obj12 == null)
				{
					object obj13 = (object)allBehaviours + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v13+20]");
					Type type2 = (Type)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v13+20]");
					bool flag3 = (nint)0 == 0;
					obj14 = obj15;
					num = num2;
					num3 = num4;
					obj16 = obj10;
					type3 = type;
					array2 = array;
					if (flag3)
					{
						goto IL_03f0;
					}
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X22_v12 (System.Type)+30]");
						object obj17 = (nint)0 & (nint)0x1C;
						bool flag4 = obj17 == null;
						object obj18 = !flag4;
						if (obj18 == null)
						{
							object obj19 = obj7;
							nint num5 = (nint)type2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v19 (Il2CppClass<System.Type>)+130]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v12+130]");
							bool flag5 = num6 < 0;
							object obj20 = !flag5;
							object obj21 = ~obj20;
							if (obj21 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v19 (Il2CppClass<System.Type>)+B0]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v12+130]");
							object obj22 = num7 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v21-8]");
							if (0 != (nint)obj19)
							{
								break;
							}
							object obj23 = type2 + 152;
							obj23 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
							System.__Canon[] items = list._items;
							num2 = (int)obj8;
							int version = list._version + 1;
							list._version = version;
							num4 = list._size;
							obj15 = items.Length;
							bool flag6 = list._size < items.Length;
							object obj24 = !flag6;
							if (obj24 == null)
							{
								object obj25 = items + list._size;
								num2 = ++list._size;
								object obj26 = obj25 + 32;
								obj26 = type2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
								type = type2;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X9_v8 (System.Int32)+20]");
								object obj27 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v24+A8]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v25+70]");
								obj10 = 0;
								list.AddWithResize((System.__Canon)(object)type2);
								type = type2;
								array = (SimulationBehaviour[])(object)list;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X22_v12 (System.Type)+28]");
						type2 = (Type)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X22_v12 (System.Type)+28]");
						bool flag7 = (nint)0 == 0;
						object obj29 = !flag7;
						obj14 = obj15;
						num = num2;
						num3 = num4;
						obj16 = obj10;
						type3 = type;
						array2 = array;
						if (obj29 != null)
						{
							continue;
						}
						goto IL_03f0;
					}
					InvalidCastException ex = new InvalidCastException();
				}
				return (List<HitboxRoot>)(object)new IndexOutOfRangeException();
				IL_03f0:
				obj9 = allBehaviours.Length;
				obj11++;
				flag8 = (nint)obj11 < allBehaviours.Length;
				obj15 = obj14;
				num2 = num;
				num4 = num3;
				obj10 = obj16;
				type = type3;
				array = array2;
			}
			while (flag8);
		}
		return (List<HitboxRoot>)(object)list;
	}

	private void RegisterHitboxSnapshot(int tick, int dataTick)
	{
		//IL_0058: Expected Obj, but got I4
		//IL_025b: Expected Obj, but got I
		//IL_00d0: Expected I4, but got VT
		if (base._runner.IsShutdown)
		{
			return;
		}
		HitboxBuffer hitboxBuffer = _hitboxBuffer;
		bool flag = _hitboxBuffer == null;
		object obj = !flag;
		if (obj == null)
		{
			Init();
			hitboxBuffer = _hitboxBuffer;
		}
		bool flag2 = hitboxBuffer == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A18]");
		object error = 0;
		bool condition = !flag2;
		Assert.Check(condition, (string)error);
		bool isServer = base._runner.IsServer;
		NetworkRunner runner = base._runner;
		int dataTick2;
		if (isServer)
		{
			Simulation simulation = runner._simulation;
			dataTick2 = (int)simulation._tick;
		}
		else
		{
			SimulationStages stage = base._runner.Stage;
			bool flag3 = stage == (SimulationStages)4;
			dataTick2 = dataTick;
			if (flag3)
			{
				return;
			}
		}
		AdvanceAndRegister(tick, dataTick2);
		BVH bVH = _hitboxBuffer.BVH;
		if ((object)bVH != null)
		{
			BVH bVH2 = _hitboxBuffer.BVH;
			BVHDepth = bVH2.maxDepth;
			BVH bVH3 = _hitboxBuffer.BVH;
			BVHNodes = bVH3._usedNodesCount;
		}
		_003CPrivateImplementationDetails_003E.HitboxSnapshot current = _hitboxBuffer.Current;
		int collidersCount = current.CollidersCount;
		LagCompensationStatisticsManager lagCompStatManager = _lagCompStatManager;
		TotalHitboxes = collidersCount;
		lagCompStatManager._currentUpdateSnapshot.SetBVHMaxDeep(BVHDepth, overrideValue: true);
		LagCompensationStatisticsManager lagCompStatManager2 = _lagCompStatManager;
		lagCompStatManager2._currentUpdateSnapshot.SetBVHNodeCount(BVHNodes, overrideValue: true);
		LagCompensationStatisticsManager lagCompStatManager3 = _lagCompStatManager;
		lagCompStatManager3._currentUpdateSnapshot.SetHitboxesCount(TotalHitboxes, overrideValue: true);
	}

	private void AdvanceAndRegister(int tick, int dataTick)
	{
		//IL_084c: Expected Obj, but got I
		//IL_0876: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_08cd: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I4
		//IL_01d0: Expected VT, but got Obj
		//IL_023d: Expected Obj, but got I4
		//IL_0264: Expected Obj, but got I8
		//IL_0274: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I4
		//IL_08f4: Expected Obj, but got I4
		//IL_0930: Expected Obj, but got I4
		//IL_02bd: Expected Obj, but got I
		//IL_0697: Expected Obj, but got I4
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_033f: Expected Obj, but got I4
		//IL_0968: Expected Obj, but got I4
		//IL_064f: Expected Obj, but got I4
		//IL_035d: Expected I, but got Obj
		//IL_036d: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got I4
		//IL_07a5: Expected Obj, but got I
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected Obj, but got Unknown
		//IL_03da: Expected Obj, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_044e: Expected Obj, but got I
		//IL_0468: Expected Obj, but got I4
		//IL_060c: Expected Obj, but got I4
		//IL_049a: Expected Obj, but got I4
		//IL_0517: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I4
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I4
		object obj;
		object obj5 = default;
		object obj11 = default;
		if ((object)base._runner != null)
		{
			base._runner.InvokeOnBeforeHitboxRegistration();
			Timer timer = Timer.StartNew();
			if (_hitboxBuffer != null)
			{
				_hitboxBuffer.Advance(tick, dataTick);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C6948]");
				obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				long timestamp = Stopwatch.GetTimestamp();
				object obj6 = default;
				object obj4 = obj5 - obj6;
				object obj7 = obj4 + timestamp;
				object obj8 = ~obj7;
				object obj9 = obj7 & obj8;
				LagCompensationStatisticsManager lagCompStatManager = _lagCompStatManager;
				object obj10 = (((nint)obj11 != 1) ? obj5 : obj9);
				if (_lagCompStatManager != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68CECDD]");
					int num = 0;
					object obj12 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v17+E4]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj12 = obj;
					}
					if (lagCompStatManager._currentUpdateSnapshot != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v17+A0]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69D8]");
						object obj15 = 0;
						object obj16 = obj10 / obj14;
						double num2 = (double)obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C438]");
						double value = num2 * 0.0;
						lagCompStatManager._currentUpdateSnapshot.SetAdvanceBufferTime(value, overrideValue: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C4200]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v17+E8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v19+E4]");
						bool flag3 = (nint)0 == 0;
						object obj19 = !flag3;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj15);
						if ((object)base._runner != null)
						{
							SimulationBehaviour[] allBehaviours = base._runner.GetAllBehaviours(typeFromHandle);
							if (allBehaviours != null)
							{
								bool flag4 = allBehaviours.Length < 1;
								object obj20 = 0;
								LagCompensationStatisticsManager lagCompensationStatisticsManager = null;
								if (flag4)
								{
									goto IL_06f3;
								}
								object obj21 = allBehaviours.Length & 0xFFFFFFFFL;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D69E0]");
								object obj22 = 0;
								object obj23 = 0;
								LagCompensationStatisticsManager lagCompensationStatisticsManager2 = null;
								object obj24 = 0;
								Type type = typeFromHandle;
								SimulationBehaviour[] array = allBehaviours;
								object obj28 = default;
								while (true)
								{
									bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
									object obj25 = !flag5;
									if (obj25 != null)
									{
										break;
									}
									object obj26 = (object)allBehaviours + obj24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v38+20]");
									HitboxRoot hitboxRoot = (HitboxRoot)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v38+20]");
									bool flag6 = (nint)0 == 0;
									object obj27 = obj28;
									int num3 = num;
									obj20 = obj23;
									lagCompensationStatisticsManager = lagCompensationStatisticsManager2;
									Type type2 = type;
									SimulationBehaviour[] array2 = array;
									if (flag6)
									{
										goto IL_068d;
									}
									while (true)
									{
										object obj29 = hitboxRoot.Flags & (SimulationBehaviourRuntimeFlags)0x1C;
										bool flag7 = obj29 == null;
										object obj30 = !flag7;
										if (obj30 == null)
										{
											type = (Type)obj22;
											nint num4 = (nint)hitboxRoot;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v44 (Il2CppClass<Fusion.HitboxRoot>)+130]");
											obj28 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X1_v14 (System.Type)+130]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v44 (Il2CppClass<Fusion.HitboxRoot>)+130]");
											nint num5 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X1_v14 (System.Type)+130]");
											bool flag8 = num5 < 0;
											object obj31 = !flag8;
											object obj32 = ~obj31;
											if (obj32 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v44 (Il2CppClass<Fusion.HitboxRoot>)+B0]");
												nint num6 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X1_v14 (System.Type)+130]");
												object obj33 = num6 + 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X8_v47-8]");
												if (0 == (nint)type)
												{
													object obj34 = hitboxRoot + 152;
													object obj35 = obj34;
													if (obj34 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v49+30]");
														object obj36 = (nint)0 & (nint)8;
														bool flag9 = obj36 == null;
														object obj37 = !flag9;
														if (obj37 == null)
														{
															bool inInterest = hitboxRoot.InInterest;
															bool flag10 = !inInterest;
															array = (SimulationBehaviour[])inInterest;
															if (!flag10)
															{
																HitboxBuffer hitboxBuffer = _hitboxBuffer;
																if (_hitboxBuffer == null)
																{
																	break;
																}
																_003CPrivateImplementationDetails_003E.HitboxSnapshot[] buffer = hitboxBuffer._buffer;
																if (hitboxBuffer._buffer == null)
																{
																	break;
																}
																num = hitboxBuffer._head;
																obj28 = buffer.Length;
																bool flag11 = hitboxBuffer._head < buffer.Length;
																object obj38 = !flag11;
																if (obj38 != null)
																{
																	goto end_IL_08db;
																}
																object obj39 = hitboxBuffer._buffer + hitboxBuffer._head;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v53+20]");
																if ((nint)0 == 0)
																{
																	break;
																}
																lagCompensationStatisticsManager2 = _lagCompStatManager;
																ArgumentNullException ex = new ArgumentNullException();
																obj23 = 0;
																type = (Type)(object)hitboxRoot;
																array = (SimulationBehaviour[])(object)ex;
															}
															goto IL_0623;
														}
													}
													obj34 = this;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
													if (_hitboxBuffer == null)
													{
														break;
													}
													lagCompensationStatisticsManager2 = _lagCompStatManager;
													_hitboxBuffer.Add(hitboxRoot, _lagCompStatManager);
													obj23 = 0;
													type = (Type)(object)hitboxRoot;
													array = (SimulationBehaviour[])(object)_hitboxBuffer;
													goto IL_0623;
												}
											}
											InvalidCastException ex2 = new InvalidCastException();
											break;
										}
										goto IL_0623;
										IL_0623:
										hitboxRoot = (HitboxRoot)hitboxRoot.Next;
										bool flag12 = (object)hitboxRoot.Next == null;
										object obj40 = !flag12;
										obj27 = obj28;
										num3 = num;
										obj20 = obj23;
										lagCompensationStatisticsManager = lagCompensationStatisticsManager2;
										type2 = type;
										array2 = array;
										if (obj40 != null)
										{
											continue;
										}
										goto IL_068d;
									}
									goto IL_0808;
									IL_068d:
									obj21 = allBehaviours.Length;
									obj24++;
									bool flag13 = (nint)obj24 < allBehaviours.Length;
									obj28 = obj27;
									num = num3;
									obj23 = obj20;
									lagCompensationStatisticsManager2 = lagCompensationStatisticsManager;
									type = type2;
									array = array2;
									if (flag13)
									{
										continue;
									}
									goto IL_06f3;
									continue;
									end_IL_08db:
									break;
								}
								goto IL_0816;
							}
						}
					}
				}
			}
		}
		goto IL_0808;
		IL_0808:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0816;
		IL_0816:
		throw new IndexOutOfRangeException();
		IL_06f3:
		Timer timer2 = Timer.StartNew();
		if (_hitboxBuffer != null)
		{
			_hitboxBuffer.PosUpdateRefit();
			object obj41 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v30+E4]");
			bool flag14 = (nint)0 == 0;
			object obj42 = !flag14;
			if (obj42 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long timestamp2 = Stopwatch.GetTimestamp();
			LagCompensationStatisticsManager lagCompStatManager2 = _lagCompStatManager;
			if (_lagCompStatManager != null)
			{
				object obj43 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v36+E4]");
				bool flag15 = (nint)0 == 0;
				object obj44 = !flag15;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj43 = obj;
				}
				if (lagCompStatManager2._currentUpdateSnapshot != null)
				{
					object obj46 = default;
					object obj45 = obj5 - obj46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v36+A0]");
					object obj47 = 0;
					object obj48 = obj45 + timestamp2;
					object obj49 = ~obj48;
					object obj50 = obj48 & obj49;
					if ((nint)obj11 != 1)
					{
						obj50 = obj5;
					}
					object obj51 = obj50 / obj47;
					double num7 = (double)obj51;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [107C438]");
					double value2 = num7 * 0.0;
					lagCompStatManager2._currentUpdateSnapshot.SetRefitBVHTime(value2, overrideValue: false);
					return;
				}
			}
		}
		goto IL_0808;
	}

	internal bool Remove(HitboxRoot root)
	{
		//IL_0045: Expected I4, but got Obj
		if (_hitboxBuffer != null)
		{
			return _hitboxBuffer.Remove(root);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Fusion_002EIAfterTick_002EAfterTick()
	{
		//IL_0065: Expected I4, but got VT
		//IL_0065: Expected I4, but got VT
		if (base._runner.IsServer)
		{
			NetworkRunner runner = base._runner;
			Simulation simulation = runner._simulation;
			RegisterHitboxSnapshot((int)simulation._tick, (int)simulation._interpFrom);
			_lagCompStatManager.FinishPendingSnapshot();
		}
	}

	private void Fusion_002EIBeforeSimulation_002EBeforeSimulation(int forwardTickCount)
	{
		//IL_01d1: Expected Obj, but got I
		//IL_01d9: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected I4, but got Unknown
		//IL_010d: Expected I4, but got VT
		//IL_013f: Expected I4, but got VT
		//IL_016e: Expected I4, but got VT
		if (!base._runner.IsClient)
		{
			return;
		}
		NetworkRunner runner = base._runner;
		Simulation simulation = runner._simulation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64C5478]");
		object obj = 0;
		nint num = (nint)simulation;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v8+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		int num4;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v3 (Il2CppClass<Fusion.Simulation>)+B0]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v8+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X9_v7-8]");
			if (0 == (nint)obj2)
			{
				SimulationRuntimeConfig runtimeConfigRef = simulation.RuntimeConfigRef;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v21 (Fusion.SimulationRuntimeConfig&)+8]");
				num4 = runtimeConfigRef / 0;
				goto IL_00b4;
			}
		}
		ref SimulationRuntimeConfig runtimeConfigRef2 = ref simulation.RuntimeConfigRef;
		num4 = 1;
		goto IL_00b4;
		IL_00b4:
		int increment = num4 * forwardTickCount;
		Tick tick2 = default;
		Tick tick = tick2.Next(increment);
		Tick tick3 = tick2.Next(num4);
		if (tick3 <= tick)
		{
			int tick4 = (int)tick3;
			Tick tick5 = tick3;
			bool flag2;
			do
			{
				NetworkRunner runner2 = base._runner;
				Simulation simulation2 = runner2._simulation;
				RegisterHitboxSnapshot(tick4, (int)simulation2._interpFrom);
				Tick tick6 = tick5.Next(num4);
				flag2 = tick6 <= tick;
				tick4 = (int)tick6;
				tick5 = tick6;
			}
			while (flag2);
		}
		_lagCompStatManager.FinishPendingSnapshot();
	}

	private void Fusion_002EISpawned_002ESpawned()
	{
		Init();
	}

	public HitboxManager()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64D6A40]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<LagCompensatedHit> list = default;
		list._002Ector();
		object obj4 = this + 96;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		List<HitboxHit> list2 = default;
		list2._002Ector();
		object obj5 = this + 152;
		obj5 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C65354");
		LagCompensationStatisticsManager lagCompensationStatisticsManager = default;
		lagCompensationStatisticsManager._002Ector();
		object obj6 = this + 160;
		obj6 = lagCompensationStatisticsManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C64E08");
		base._002Ector();
	}
}
