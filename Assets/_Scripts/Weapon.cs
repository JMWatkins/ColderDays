using UnityEngine;
using System.Collections;

public class Weapon : Item {
	int damage = 0;
	int speed = 0;
	int accuracy = 0;

	public Weapon(string nm, string desc, int wgt): base(nm, desc, wgt){
		name = nm;
		amount = 1;
		description = desc;
		weight = wgt;
	}

	public Weapon(string nm, string desc, int wgt, int dmg, int spd, int acc){
		name = nm;
		description = desc;
		weight = wgt;
		damage = dmg;
		speed = spd;
		accuracy = acc;
	}
}
