using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFood : MonoBehaviour {

	Vector3 bar;
	public GameObject food;
	bool isSet = false;
	GameObject created;

	void Start() {
		bar = transform.position;
		food.SetActive (true);
//		food.localScale += new Vector3(2, 2, 2);
	}

	void OnMouseDown() {
		Debug.Log (Input.mousePosition);
		if (!isSet) {
			created = Instantiate (food, new Vector3 (bar.x - 3, bar.y + 2, bar.z - 6), Quaternion.identity);
			created.tag = "food";
			isSet = true;
		} else {
			Destroy (created);
			isSet = false;
		}

	}

}
