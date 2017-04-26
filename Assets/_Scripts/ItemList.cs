using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemList {
	List<Item> items = new List<Item> ();
	List<Weapon> weapons = new List<Weapon> ();
	int capacity = 0;
	public ItemList (int sz){
		capacity = sz;
	}

	public void expandCap(int sz){
		capacity += sz;
	}

	public void addItem (Item it, int amount){
		if (this.findItem (it) == null) {
			it.amount = amount;
			items.Add (it);
		} else {
			Item item = this.findItem (it);
			item.amount += amount;
		}
	}

	public Item findItem(Item it){
		Item ret = null;
		foreach (Item item in items) {
			if (item.getName() == it.getName())
				ret = item;
		}
		if (ret == null) {
			Debug.Log ("ItemList FindItem found no such Item");
		}
		return ret;
	}
}
