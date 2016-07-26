using UnityEngine;
using System.Collections;

public class InteractableItem : ItemBase
{

    public InventoryItem inventory_item;
    public CollactableItem collactable_item;
    public bool remove_inventory_item_after_interaction = true;

    Inventory inventory;
	// Use this for initialization
	void Start () {
        inventory = GameObject.FindWithTag("Inventory").GetComponent<Inventory>();
        collactable_item.hide();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("Clicked on an interactable item");
        if (inventory.isSelected(inventory_item))
        {
            // The item on the inventory is selected. The interactable item must hide
            // and the collactable item must show (if any)
            Debug.Log("Item is selected");
            if (collactable_item != null)
            {
                collactable_item.show();
                collactable_item.transform.position = this.transform.position;

                if(remove_inventory_item_after_interaction)
                {
                    inventory.removeItem(inventory_item);
                }
            }
            this.hide();

        } else
        {
            Debug.Log("Item is not selected");
        }
    }
}
