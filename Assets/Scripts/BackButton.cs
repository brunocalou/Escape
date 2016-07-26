using UnityEngine;

public class BackButton : ItemBase {

    ZoomedItem [] zoomed_items;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void hideZoomedItems()
    {
        zoomed_items = GameObject.FindObjectsOfType<ZoomedItem>();

        //Hides back button and the zoomed items
        foreach (ZoomedItem item in zoomed_items)
        {
            item.hide();
        }
    }
}
