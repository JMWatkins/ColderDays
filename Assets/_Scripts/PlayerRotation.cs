using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

	// Use this for initialization
	Transform tr;

	void Start () {
		tr = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (turnCam ());
	}

	IEnumerator turnCam(){
		float ydelta = 0f;
		float xdelta = 0f;

		Vector3 rot = tr.rotation.eulerAngles;

		if (Input.GetKey (KeyCode.W)) {
			ydelta += 1;
		}
		if (Input.GetKey (KeyCode.S)) {
			ydelta -= 1;
		}
		if (Input.GetKey (KeyCode.A)) {
			xdelta -= 1;
		}
		if (Input.GetKey (KeyCode.D)) {
			xdelta += 1;
		}
		tr.rotation = Quaternion.AngleAxis (xdelta, Vector3.up) * tr.rotation;
		//Debug.Log ("xAngle: " + tr.eulerAngles.x);
		if (tr.eulerAngles.x <= 60 || tr.eulerAngles.x >= (300) || (Mathf.Abs(tr.localEulerAngles.x)>60 && (tr.localEulerAngles.x<180)?ydelta>0:ydelta<0))
			tr.rotation = tr.rotation * Quaternion.AngleAxis (ydelta, Vector3.left);
		yield return 0;
	}
}
