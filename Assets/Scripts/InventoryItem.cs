using UnityEngine;
using System.Collections;

public class InventoryItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        hide();
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
}
