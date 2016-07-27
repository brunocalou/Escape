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

    new void OnMouseDown()
    {
        base.OnMouseDown();
        Debug.Log("Wire on mouse down");
        game.OnWireCut(this);
    }
	
}
