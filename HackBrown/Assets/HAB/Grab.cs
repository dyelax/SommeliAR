using UnityEngine;
using System.Collections;

public class Grab : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision collision) {
		//Debug.Log (collision.gameObject.name);
		if (collision.gameObject.name.Contains("palm") || collision.gameObject.name.Contains("bone3")) {
			this.transform.parent = collision.gameObject.transform.parent.parent.FindChild ("palm");
			this.transform.localPosition = new Vector3 (0f, -0.06f, 0f);
			//this.transform.localEulerAngles = new Vector3 (90f, 90f, 0f);
			Destroy (this.GetComponent<Rigidbody>());
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
