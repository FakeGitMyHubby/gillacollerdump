using UnityEngine;

public class Spin : MonoBehaviour
{
	public float degreesPerSecond = 35f;

	private void Update()
	{
		Transform transform = base.transform;
		float deltaTime = Time.deltaTime;
		float yAngle = degreesPerSecond * deltaTime;
		transform.Rotate(0f, yAngle, 0f, (Space)0);
	}
}
