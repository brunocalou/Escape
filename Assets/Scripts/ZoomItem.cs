using UnityEngine;

public class ZoomItem : MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler
{

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

    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        zoomed_item.show();
        back_button.show();
    }
}
