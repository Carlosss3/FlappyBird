using UnityEngine;
using System.Collections;

public class inmortalScript : MonoBehaviour {

	public float time = 4;

	void OnTriggerEnter2D(Collider2D col) {

		GameControl.inmortal = true;
		GameControl.inmortalTime = Time.time + time;
		//Debug.Log (GameControl.inmortal);
		Destroy(gameObject);
		
	}
}
