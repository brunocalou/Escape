using UnityEngine;
using System.Collections;

public class InventoryItem : ItemBase, UnityEngine.EventSystems.IPointerClickHandler
{
    Inventory inventory;
    // Use this for initialization
    void Start () {
        hide();
        inventory = GameObject.FindWithTag("Inventory").GetComponent<Inventory>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        inventory.handleSelect(this);
    }
}
