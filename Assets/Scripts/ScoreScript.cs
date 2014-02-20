using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public   GameObject  win;
	public AudioClip winSound;

	private bool winner = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + GameControl.score;

		/*if (GameControl.score > 20 && !winner) {
			winner = true;
			//AudioSource.PlayClipAtPoint(winSound, transform.position);
			var buu = (GameObject)Instantiate(win, transform.position, transform.rotation);
		}*/
	}
}
