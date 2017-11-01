using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController0 : MonoBehaviour {

	public float moveSpeed = 5f;
	bool isBegin = false;
	Vector3 bar;

	void Start() {
		bar = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			isBegin = !isBegin;
		}
		if (isBegin) {
			transform.Translate (new Vector3 (0, 0, 1) * moveSpeed * Time.deltaTime);
			if (transform.position.z < -68) {
				transform.position = new Vector3 (-3, 4, -4);
			}
		} else {
			transform.position = bar;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("food")) {
			Debug.Log ("Collider!");
			other.gameObject.SetActive (false);

			GetComponent<ChuckInstance> ().RunCode( string.Format(@"
				SndBuf catBuf => dac;
				me.dir() + ""cat0.wav"" => catBuf.read;

				catBuf.length() => now;
			"));
		}
	}
}
