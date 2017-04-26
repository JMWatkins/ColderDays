using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EventManagement : MonoBehaviour {


	public static void setButton(string text){
		Button but = GameObject.Find ("ActionButton").GetComponent<Button>() as Button;
		if (text == "Log") {
			but.enabled = true;
			Text bTxt = GameObject.Find ("ActionButtonText").GetComponent<Text>() as Text;
			bTxt.text = "Stoke Fire";
			but.onClick.AddListener(() => Player.stokeFire()); 
		}
		else {
			but.enabled = false;
		}
			
	}
}
