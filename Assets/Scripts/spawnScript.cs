using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {

	public   GameObject[]  spawntube;
	public float spawnTime = 3 ;
	float timer = 0;
	public int randomPos = 0;
	// Use this for initialization
	
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time > timer && !GameControl.dead) {
		var spawn_pos = transform.position;
			spawn_pos.y = spawn_pos.y + Mathf.Round(Random.Range(0,randomPos)) ;
			//Debug.Log ("SpanPos: "+spawn_pos);
			var item_index = Random.Range(0,spawntube.Length);
			var stube = (GameObject)Instantiate(spawntube[item_index], spawn_pos, transform.rotation);
			Destroy(stube,6);
			timer = Time.time + spawnTime;
		}
	}
}
