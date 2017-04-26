using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Display : MonoBehaviour {

	// Use this for initialization
	Transform tr;
	RaycastHit rayHit;
	string lastObjectSeen = "";

	void Start () {
		tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (tr.position, tr.forward, out rayHit, 10)) {
			Transform trans = rayHit.transform;
			if (trans.name != lastObjectSeen) {
				if (trans == null)
					Debug.Log ("Could not find ray parent");
				//logText("Looking at: " + trans.name);
				EventManagement.setButton (trans.name);
			}
		} else {
			EventManagement.setButton (null);
		}
	}

	public static void logText(string input){
		Text txt = GameObject.Find ("ConsoleNew").GetComponent<Text>() as Text;
		Text oldTxt = GameObject.Find ("ConsoleLog").GetComponent<Text>() as Text;
		oldTxt.text = txt.text + "\n" + oldTxt.text;

		if (oldTxt.text.Length > 10000)
			oldTxt.text = oldTxt.text.Substring (0, 9000);
		txt.text = input;
	}

	
}