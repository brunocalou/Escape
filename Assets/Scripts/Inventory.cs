using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    ArrayList items;
    const int MAX_NUMBER_OF_ITEMS = 5;

	// Use this for initialization
	void Start () {
        items = new ArrayList(MAX_NUMBER_OF_ITEMS);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addItem(InventoryItem item)
    {
        Debug.Log("Added item");
        items.Add(item);

        RectTransform rect_transform = item.GetComponent<RectTransform>();
        Vector2 pivot = rect_transform.pivot;//.y = this.GetComponent<RectTransform>().rect.height / 2;

        rect_transform.pivot = new Vector2(pivot.x, 1 - items.IndexOf(item) / (float)(MAX_NUMBER_OF_ITEMS - 1));

        item.show();
        
        Debug.Log(item);
    }
}
