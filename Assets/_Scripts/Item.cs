using UnityEngine;
using System.Collections;

public class Item {
	//extends List<Item>
	public int weight = 0;
	public int amount = 0;
	public string name = "default";
	public string description = "default description";

	public Item(){
	}

	public Item(string nm, string desc, int wgt){
		name = nm;
		amount = 1;
		description = desc;
		weight = wgt;
	}

	public Item(string nm, string desc, int wgt, int amt){
		name = nm;
		amount = amt;
		weight = wgt;
		description = desc;
	}

	public string getName(){
		return name;
	}

	public string getDescription(){
		return description;
	}
}
