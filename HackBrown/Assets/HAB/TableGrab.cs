using UnityEngine;
using System.Collections;

public class TableGrab : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.name);
		if (collision.gameObject.name.Contains("palm")) {
			collision.transform.GetChild (0).parent = null;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
