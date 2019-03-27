using System.Collections;
using UnityEngine;

public class SpawnFish : MonoBehaviour {
	public GameObject fish,fish1,fish2,trash,trash1;
	void Start() {
		StartCoroutine (Spawn ());
			}
	IEnumerator Spawn(){
		while(true){
			Instantiate (fish,new Vector2 (Random.Range (-2.5f, 2.5f), 5.9f), Quaternion.identity);
			yield return new WaitForSeconds(1f);
			Instantiate (fish1,new Vector2 (Random.Range (-2.5f, 2.5f), 5.9f), Quaternion.identity);
			yield return new WaitForSeconds(1f);
			Instantiate (fish2,new Vector2 (Random.Range (-2.5f, 2.5f), 5.9f), Quaternion.identity);
			yield return new WaitForSeconds(1f);
			Instantiate (trash,new Vector2 (Random.Range (-2.5f, 2.5f), 5.9f), Quaternion.identity);
			yield return new WaitForSeconds(1f);
			Instantiate (trash1,new Vector2 (Random.Range (-2.5f, 2.5f), 5.9f), Quaternion.identity);
			yield return new WaitForSeconds(1f);
			}
	}
}
