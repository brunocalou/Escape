using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    ArrayList items;
    const int MAX_NUMBER_OF_ITEMS = 5;
    public GameObject select;
    InventoryItem selectedItem;

	// Use this for initialization
	void Start () {
        items = new ArrayList(MAX_NUMBER_OF_ITEMS);
        select.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void adjustItemPivot(InventoryItem item)
    {
        RectTransform rect_transform = item.GetComponent<RectTransform>();
        Vector2 pivot = rect_transform.pivot;//.y = this.GetComponent<RectTransform>().rect.height / 2;

        rect_transform.pivot = new Vector2(pivot.x, 1 - items.IndexOf(item) / (float)(MAX_NUMBER_OF_ITEMS - 1));
    }

    void organizeItems()
    {
        foreach (InventoryItem item in items)
        {
            adjustItemPivot(item);
        }
    }

    public void handleSelect(InventoryItem item)
    {
        if (select.GetComponent<RectTransform>().pivot == item.GetComponent<RectTransform>().pivot && select.activeSelf)
        {
            //Clicked on the same item, must deselect it
            Debug.Log("Clicked on the same active item");
            deselectItem();
        } else
        {
            selectItem(item);
        }
    }

    public bool isSelected(InventoryItem item)
    {
        return item == selectedItem;
    }

    public void selectItem(InventoryItem item)
    {
        select.SetActive(true);
        select.GetComponent<RectTransform>().pivot = item.GetComponent<RectTransform>().pivot;
        selectedItem = item;
    }

    public void deselectItem()
    {
        select.SetActive(false);
        selectedItem = null;
    }

    public void addItem(InventoryItem item)
    {
        Debug.Log("Added item");
        items.Add(item);

        adjustItemPivot(item);

        item.show();
        
        Debug.Log(item);
    }

    public void removeItem(InventoryItem item)
    {
        item.hide();
        if (isSelected(item))
        {
            deselectItem();
        }
        items.Remove(item);
        organizeItems();
    }
}
