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

    public void addItem(CollactableItem item)
    {
        Debug.Log("Added item");
        items.Add(item);

        //Place item on the inventory
        GameObject new_item = Instantiate(item.gameObject);
        UnityEngine.Canvas canvas = FindObjectOfType<Canvas>();
        Destroy(new_item.GetComponent<CollactableItem>());

        new_item.transform.SetParent(canvas.transform, false);
        new_item.transform.localPosition = new Vector3(512, 200 - (items.Count - 1) * 100, -10);
        new_item.transform.SetAsFirstSibling();
        
        
        Debug.Log(item);
    }
}
