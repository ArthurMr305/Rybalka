using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {
	public Sprite layer_blue,layer_green;
	public string action;
	void OnMouseDown(){
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}
	void OnMouseUp(){
		GetComponent <SpriteRenderer> ().sprite = layer_green;
	}
	void OnMouseUpAsButton(){

	switch (action){
	case"Run":
			Application.LoadLevel("Play");
			break;
		case"Comment":
			Application.OpenURL ("www.zntu.edu.ua");
			break;
		case"Back":
			Application.LoadLevel ("Main");
			break;
		}


}
}