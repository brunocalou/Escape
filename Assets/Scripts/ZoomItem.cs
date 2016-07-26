using UnityEngine;
using System.Collections;

public class ZoomItem : MonoBehaviour {

    public ZoomedItem zoomed_item;
    public BackButton back_button;

	// Use this for initialization
	void Start () {
        zoomed_item.hide();
        back_button.hide();
    }
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        zoomed_item.show();
        back_button.show();
    }
}
