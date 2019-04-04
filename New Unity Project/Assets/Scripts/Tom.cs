using System.Collections;
using UnityEngine;
public class Tom : MonoBehaviour {
	public float speed;
	public Vector3 target = new Vector3(-1.92f,3.52f,0f);
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
		if (transform.position == target && target.y != -3.30f)
			target.y = -3.30f;
		else if (transform.position == target && target.y == -3.30f)
		target.y = 3.52f;

	}
}
