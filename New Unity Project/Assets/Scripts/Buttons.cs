using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {
	public GameObject m_on,m_off;

	public Sprite layer_blue,layer_green;
	public string action;
	void OnMouseDown(){
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
}
	void OnMouseUp(){
		GetComponent <SpriteRenderer> ().sprite = layer_green;
	}
	void OnMouseUpAsButton(){
		if (PlayerPrefs.GetString ("Music") != "no")
			GameObject.Find("ClickAudio").GetComponent <AudioSource> ().Play();
		
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
		case"Music":
			if (PlayerPrefs.GetString ("Music") != "no") {
				PlayerPrefs.SetString ("Music", "no");
				m_on.SetActive (false);
				m_off.SetActive (true);
			} else {
				PlayerPrefs.SetString ("Music", "yes");
				m_on.SetActive (true);
				m_off.SetActive (false);
				}
			break;

	}
		}


}
