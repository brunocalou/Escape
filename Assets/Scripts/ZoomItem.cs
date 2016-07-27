using UnityEngine;

public class ZoomItem : MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler
{

    public ZoomedItem zoomed_item;
    public BackButton back_button;

    public void hideZoomedItemAndBackButton()
    {
        zoomed_item.hide();
        back_button.hide();
    }

    public void showZoomedItemAndBackButton()
    {
        zoomed_item.show();
        back_button.show();
    }

    // Use this for initialization
    void Start () {
        hideZoomedItemAndBackButton();
    }
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        showZoomedItemAndBackButton();
    }

    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        showZoomedItemAndBackButton();
    }
}
