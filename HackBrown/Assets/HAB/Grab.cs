using UnityEngine;
using System.Collections;

public class Grab : MonoBehaviour {

	public Mesh mesh;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.name);
		if (collision.gameObject.name.Contains("bone")) {
//			this.transform.parent = collision.gameObject.transform.parent.parent.FindChild ("palm");
//			this.transform.localPosition = new Vector3 (0f, -0.06f, 0f);
//			//this.transform.localEulerAngles = new Vector3 (90f, 90f, 0f);
//			Destroy (this.GetComponent<Rigidbody>());
			if (collision.gameObject.transform.parent.parent.name.Contains ("_L")) 
			{
				Transform hand = collision.gameObject.transform.parent.parent.parent.FindChild ("LoPoly_Rigged_Hand_Left").FindChild ("LoPoly_Hand_Mesh_Left");
				hand.GetComponent<SkinnedMeshRenderer> ().enabled = false;
				Transform tracked = hand.parent.parent.FindChild ("RigidRoundHand_L").FindChild ("index").FindChild ("bone3");
				GameObject tracker = GameObject.Find ("LeftHandShotGlass");
				tracker.transform.position = tracked.position;
				tracker.transform.rotation = tracked.rotation;
				tracker.GetComponent<MeshRenderer> ().enabled = true;
				tracker.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;

				//hand.GetComponent<SkinnedMeshRenderer> ().sharedMesh = mesh;
				//hand.parent.localEulerAngles = new Vector3 (0, -90f, 0);
			}
			else if (collision.gameObject.transform.parent.parent.name.Contains ("_R")) 
			{
				Transform hand = collision.gameObject.transform.parent.parent.parent.FindChild ("LoPoly_Rigged_Hand_Right").FindChild ("LoPoly_Hand_Mesh_Right");
				hand.GetComponent<SkinnedMeshRenderer> ().enabled = false;
				Transform tracked = hand.parent.parent.FindChild ("RigidRoundHand_R").FindChild ("index").FindChild ("bone3");
				GameObject tracker = GameObject.Find ("RightHandShotGlass");
				tracker.transform.position = tracked.position;
				tracker.transform.rotation = tracked.rotation;
				tracker.GetComponent<MeshRenderer> ().enabled = true;
				tracker.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;


			}
			Destroy (this.gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
