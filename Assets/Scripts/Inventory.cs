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
        new_item.transform.SetAsFirstSibling();

        Destroy(new_item.GetComponent<Transform>());

        new_item.AddComponent<RectTransform>();
        RectTransform inventory_rect_transform = this.GetComponent<RectTransform>();
        RectTransform new_item_rect_transform = new_item.GetComponent<RectTransform>();
        //new_item.transform.localPosition = new Vector3(this.transform.position.x, this.transform.position.y, -10);
        new_item_rect_transform.anchoredPosition = new Vector2(1, 1);
        new_item_rect_transform.anchorMin = new Vector2(1, 1);
        new_item_rect_transform.anchorMax = new Vector2(1, 1);



        Debug.Log(item);
    }
}
