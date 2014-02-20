using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	if(!GameControl.dead)
		guiText.text = "Time: " + Time.time;
	}
}
