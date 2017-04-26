using UnityEngine;
using System.Collections;

public class Player : Character {
	int level = 1;
	int exp = 0;

	public static void stokeFire(){
		Light fire = GameObject.Find ("FireLight").GetComponent<Light>() as Light;
		fire.intensity += 0.5f;
		if (fire.intensity <= 0.6) {
			Display.logText ("The fire spulters back to life, the room is still cold");
		} else if (fire.intensity <= 1.1) {
			Display.logText ("The fire grows and you feel a gentle warm eminate from it");
		} else if (fire.intensity <= 1.6) {
			Display.logText ("The fire burns bright and warms you up");
		} else {
			fire.intensity = 2.0f;
			Display.logText ("The fire roars and the whole hut is filled with light and warmth");
		}
	}
}
