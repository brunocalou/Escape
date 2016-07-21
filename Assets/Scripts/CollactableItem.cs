using UnityEngine;
using System.Collections;

public class CollactableItem : MonoBehaviour {

    public Inventory inventory;
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
            this.gameObject.GetComponent<Renderer>().enabled = true; //Show the object
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }

    void OnMouseDown()
    {
        Debug.Log("MOUSE DOWN");
        if (inventory != null)
        {
            Debug.Log("Item will be added");
            inventory.addItem(this);
        }
        this.gameObject.GetComponent<Renderer>().enabled = false; //Hide the object
        this.gameObject.GetComponent<BoxCollider>().enabled = false;//Disable the body so the user can't click it
    }
}
