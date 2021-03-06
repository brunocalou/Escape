﻿using UnityEngine;
using System.Collections;

public class InteractableItem : ItemBase
{

    public InventoryItem inventory_item_to_interact_with;
    public CollactableItem item_to_be_collacted;
    public bool remove_inventory_item_after_interaction = true;
    protected bool mouse_was_down = false;

    protected Inventory inventory;
	// Use this for initialization
	public void Start () {
        inventory = GameObject.FindWithTag("Inventory").GetComponent<Inventory>();
        if (item_to_be_collacted != null)
        {
            item_to_be_collacted.transform.position = new Vector3(999, 999, 999);
        }
    }

    void OnMouseDown()
    {
        mouse_was_down = true;
    }

    public void OnMouseUp()
    {
        if (mouse_was_down)
        {
            Debug.Log("Clicked on an interactable item");
            if (inventory.isSelected(inventory_item_to_interact_with))
            {
                // The item on the inventory is selected. The interactable item must hide
                // and the collactable item must show (if any)
                Debug.Log("Item is selected");
                if (item_to_be_collacted != null)
                {
                    item_to_be_collacted.transform.position = this.transform.position;
                    item_to_be_collacted.show();

                    if (remove_inventory_item_after_interaction)
                    {
                        inventory.removeItem(inventory_item_to_interact_with);
                    }
                }
                this.hide();

            }
            else
            {
                Debug.Log("Item is not selected");
            }
        }
    }
}
