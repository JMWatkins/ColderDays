using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collections{

	public static List<Item> items = getItems();
	public static List<Weapon> weapons = new List<Weapon> ();
	public static List<Item> enemies = new List<Item> ();

	private static List<Item> getItems(){
		List<Item> ret = new List<Item> ();
		ret.Add (new Item ("Wood", "Branches and logs, a useful fuel", 2));
		return ret;
	}



}
