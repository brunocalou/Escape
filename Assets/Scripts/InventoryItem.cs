using UnityEngine;
using System.Collections;

public class InventoryItem : MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler
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

    public void show()
    {
        this.gameObject.SetActive(true);
    }

    public void hide()
    {
        this.gameObject.SetActive(false);
    }

    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        inventory.handleSelect(this);
    }
}
