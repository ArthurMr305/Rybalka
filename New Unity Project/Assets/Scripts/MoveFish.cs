using System.Collections;
using UnityEngine;

public class MoveFish : MonoBehaviour {
	public Transform EndPoint;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position,EndPoint.position,Time.deltaTime);
	}
}
