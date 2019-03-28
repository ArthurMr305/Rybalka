
using UnityEngine;

public class FallDownTrash : MonoBehaviour {
	[SerializeField]
	private float fallSpeed = 2f;
	void Update(){
		transform.position -=new Vector3(0,fallSpeed *Time.deltaTime,0);
	}
}
