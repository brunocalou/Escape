using UnityEngine;
using System.Collections;

public class Wire : InteractableItem {

    public enum Color { RED, YELLOW, BLUE };

    public Color color;

    EndGame game;

    // Use this for initialization
    new void Start () {
        base.Start();
        game = GameObject.FindObjectOfType<EndGame>();
	}

    new void OnMouseUp()
    {
        base.OnMouseUp();
        if (mouse_was_down)
        {
            if (inventory.isSelected(this.inventory_item_to_interact_with))
            {
                game.OnWireCut(this);
            }
            Debug.Log("Wire on mouse down");
        }
    }
}
