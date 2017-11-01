using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController2 : MonoBehaviour {

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
			Debug.Log ("isBegin!");
			transform.Translate (new Vector3 (0, 0, 1) * moveSpeed * Time.deltaTime);
			if (transform.position.z < -68) {
				transform.position = new Vector3 (13, 4, -4);
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
				SndBuf Buf => dac;
				me.dir() + ""Owl.wav"" => Buf.read;

				Buf.length() => now;
			"));
		}
	}
}
