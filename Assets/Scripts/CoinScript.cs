using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {
	public int scoreCoin;
	public AudioClip coinAudio;
	public GameObject  pointAnim;

	jumpScript playerScript;
	void Start () {
		var player = GameObject.FindWithTag("Player");
		playerScript = player.GetComponent<jumpScript>();
	}

	void OnTriggerEnter2D(Collider2D col) {

			
			AudioSource.PlayClipAtPoint(coinAudio, transform.position);
			playerScript.inmortal = true;
			GameControl.score = GameControl.score + scoreCoin;
			var pointPos = transform.position;
			pointPos.y +=2;
			var points = (GameObject)Instantiate(pointAnim,pointPos, transform.rotation);
			Destroy(points,1);
			Destroy(gameObject);

	}
}
