using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {

    QuitButtonAccept quitButtonAccept;
    QuitButtonReject quitButtonReject;

    // Use this for initialization
    void Start () {
        quitButtonAccept = FindObjectOfType<QuitButtonAccept>();
        quitButtonReject = FindObjectOfType<QuitButtonReject>();

        quitButtonAccept.gameObject.SetActive(false);
        quitButtonReject.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!quitButtonAccept.gameObject.activeSelf)
            {
                quitButtonAccept.gameObject.SetActive(true);
                quitButtonReject.gameObject.SetActive(true);
            }
            else
            {
                quitButtonAccept.gameObject.SetActive(false);
                quitButtonReject.gameObject.SetActive(false);
            }
        }
    }
}
