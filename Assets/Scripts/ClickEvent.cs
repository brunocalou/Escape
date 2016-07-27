using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        // Code for OnMouseDown in the iPhone. Unquote to test.
        RaycastHit hit = new RaycastHit();
        for (int i = 0; i < Input.touchCount; ++i)
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Ended) || Input.GetTouch(i).phase.Equals(TouchPhase.Began))
            {
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray, out hit))
                {
                    if (Input.GetTouch(i).phase.Equals(TouchPhase.Ended))
                    {
                        hit.transform.gameObject.SendMessage("OnMouseUp");
                    } else if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
                    {
                        hit.transform.gameObject.SendMessage("OnMouseDown");
                    }
                }
                    
            }
    }
}
