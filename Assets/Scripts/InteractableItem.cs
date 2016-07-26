using UnityEngine;
using System.Collections;

public class InteractableItem : ItemBase
{

    public InventoryItem inventory_item_to_interact_with;
    public CollactableItem item_to_be_collacted;
    public bool remove_inventory_item_after_interaction = true;

    Inventory inventory;
	// Use this for initialization
	void Start () {
        inventory = GameObject.FindWithTag("Inventory").GetComponent<Inventory>();
        item_to_be_collacted.hide();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("Clicked on an interactable item");
        if (inventory.isSelected(inventory_item_to_interact_with))
        {
            // The item on the inventory is selected. The interactable item must hide
            // and the collactable item must show (if any)
            Debug.Log("Item is selected");
            if (item_to_be_collacted != null)
            {
                item_to_be_collacted.show();
                item_to_be_collacted.transform.position = this.transform.position;

                if(remove_inventory_item_after_interaction)
                {
                    inventory.removeItem(inventory_item_to_interact_with);
                }
            }
            this.hide();

        } else
        {
            Debug.Log("Item is not selected");
        }
    }
}
