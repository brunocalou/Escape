using UnityEngine;
using System.Collections;

public class CollactableItem : MonoBehaviour {

    Inventory inventory;
    public InventoryItem inventory_item; //2D image associated with the item

	// Use this for initialization
	void Start () {
        inventory = GameObject.FindWithTag("Inventory").GetComponent<Inventory>();
	}

    public void show()
    {
        this.gameObject.GetComponent<Renderer>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    public void hide()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
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
