using UnityEngine;
using System.Collections;

public class levelUpScript : MonoBehaviour {
	public AudioClip levelup;
	public int points = 1;
	
	void OnTriggerEnter2D(Collider2D col) {
		if (!GameControl.dead) {
			AudioSource.PlayClipAtPoint(levelup, transform.position);
			GameControl.score = GameControl.score + points;
			Destroy (gameObject);
		}
	}
}
