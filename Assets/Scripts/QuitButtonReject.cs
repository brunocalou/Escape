using UnityEngine;
using System.Collections;

public class QuitButtonReject : MonoBehaviour {

    QuitButtonAccept quitButtonAccept;

    // Use this for initialization
    void Start () {
        //this.gameObject.SetActive(false);
        quitButtonAccept = FindObjectOfType<QuitButtonAccept>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CancelQuitApp()
    {
        this.gameObject.SetActive(false);
        quitButtonAccept.gameObject.SetActive(false);
    }
}
