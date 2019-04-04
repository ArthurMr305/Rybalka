using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {
	public GameObject trash, trash1, trash2,treasure;

	void Start(){
		StartCoroutine (Spawn ());
		}
	IEnumerator Spawn (){
		while(true){
			Instantiate (trash, new Vector2 (Random.Range (-1.06f, 2.51f), 5.7f), Quaternion.identity);
			yield return new WaitForSeconds (1.3f);
			Instantiate (trash1, new Vector2 (Random.Range (-1.06f, 2.51f), 5.7f), Quaternion.identity);
			yield return new WaitForSeconds (1.4f);
			Instantiate (trash2, new Vector2 (Random.Range (-1.06f, 2.51f), 5.7f), Quaternion.identity);
			yield return new WaitForSeconds (1.2f);

			}
	

	}

}
