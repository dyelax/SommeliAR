using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {
	public string levelName;
	// Use this for initialization
	void Start () {
	
	}


	void OnCollisionEnter(Collision collision) {
		//Debug.Log (collision.gameObject.name);
		if (collision.gameObject.name.Contains("bone")) {
			SceneManager.LoadScene (levelName);
		}

	}

	// Update is called once per frame
	void Update () {
	
	}
}
