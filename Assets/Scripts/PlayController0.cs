using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController0 : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("food")) {
			Debug.Log ("Collider!");
			other.gameObject.SetActive (false);

			GetComponent<ChuckInstance> ().RunCode( string.Format(@"
				SndBuf catBuf => dac;
				me.dir() + ""Cat0.wav"" => catBuf.read;

				catBuf.length() => now;
			"));
		}
	}
}
