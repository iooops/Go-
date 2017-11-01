using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController1 : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("food")) {
			Debug.Log ("Collider!");
			other.gameObject.SetActive (false);

			GetComponent<ChuckInstance> ().RunCode( string.Format(@"
				SndBuf dogBuf => dac;
				me.dir() + ""Dog.wav"" => dogBuf.read;

				dogBuf.length() => now;
			"));
		}
	}
}
