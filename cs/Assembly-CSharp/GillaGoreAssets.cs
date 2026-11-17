using UnityEngine;

public class GillaGoreAssets : ScriptableObject
{
	private struct Track
	{
		public Vector3 at;

		public Vector3 v;

		public float clear;
	}

	public Material wound;

	public Material bone;

	public GillaHands.Piece[] pieces;

	public Mesh chunk;

	public Material chunkMaterial;

	public Material chipMaterial;

	public Material lump;

	public Material spray;

	public Material strand;

	public Material splat;

	public Material stain;

	public AudioClip[] punchSounds;
}
