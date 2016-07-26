using UnityEngine;
using System.Collections;

public class CollactableItem : ItemBase {

    Inventory inventory;
    public InventoryItem inventory_item; //2D image associated with the item

	// Use this for initialization
	void Start () {
        inventory = GameObject.FindWithTag("Inventory").GetComponent<Inventory>();
	}

    // Update is called once per frame
    void Update()
    {
        //Reset the object, just to debug
        if (Input.GetKeyUp(KeyCode.R))
        {
            show();
        }
    }

    void OnMouseDownFromClickEventScript()
    {
        Debug.Log("OnMouseDownFromClickEventScript");
    }

    void OnMouseDown()
    {
        Debug.Log("MOUSE DOWN");
        if (inventory != null)
        {
            Debug.Log("Item will be added");
            inventory.addItem(this.inventory_item);
        }
        hide();
    }
}
