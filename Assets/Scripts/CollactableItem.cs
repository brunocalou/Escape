using UnityEngine;
using System.Collections;

public class CollactableItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        //Reset the object, just to debug
        if (Input.GetKeyUp(KeyCode.R))
        {
            this.gameObject.GetComponent<Renderer>().enabled = true; //Show the object
        }
    }

    void OnMouseDown()
    {
        Debug.Log("MOUSE DOWN");
        this.gameObject.GetComponent<Renderer>().enabled = false; //Hide the object
    }
}
