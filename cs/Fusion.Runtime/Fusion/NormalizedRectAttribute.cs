using UnityEngine;

namespace Fusion;

public class NormalizedRectAttribute : UnityEngine.PropertyAttribute
{
	public bool InvertY;

	public float AspectRatio;

	public NormalizedRectAttribute(bool invertY = default(bool), float aspectRatio = default(float))
	{
		InvertY = invertY;
		AspectRatio = aspectRatio;
	}
}
