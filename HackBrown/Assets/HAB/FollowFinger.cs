using UnityEngine;
using System.Collections;

public class FollowFinger : MonoBehaviour {

	public GameObject toFollow;
	public GameObject head;
	public GameObject wine;
	public float rotation; 
	Color m;
	Color w;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		this.transform.position = toFollow.transform.position;
		this.transform.rotation = toFollow.transform.rotation;
		this.transform.Rotate (0, 0, rotation);
		float dist = Vector3.Distance (this.transform.position, head.transform.position);
		//Debug.Log (Vector3.Distance (this.transform.position, head.transform.position));
		m = this.gameObject.GetComponent<Renderer> ().material.color;
		m.a = Mathf.Lerp(0, 1f, (Mathf.InverseLerp(0.3f, 0.6f, dist)));
		this.gameObject.GetComponent<Renderer> ().material.color = m;

		w = wine.GetComponent<Renderer> ().material.color;
		w.a = Mathf.Lerp(0, 1f, (Mathf.InverseLerp(0.3f, 0.6f, dist)));
		wine.GetComponent<Renderer> ().material.color = w;
	}
}
