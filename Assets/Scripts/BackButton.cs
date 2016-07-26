using UnityEngine;
using System.Collections;

public class BackButton : ItemBase {

    ZoomedItem [] zoomed_items;

	// Use this for initialization
	void Start () {
        this.hide();
        zoomed_items = GameObject.FindObjectsOfType<ZoomedItem>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void hideZoomedItems()
    {
        //Hides back button and the zoomed items
        foreach (ZoomedItem item in zoomed_items)
        {
            item.hide();
        }
    }
}
