using System.Collections;
using UnityEngine;
using Vuforia;

public class StartGame : ItemBase {

    Timer timer;
    GameObject bomb;
    ArrayList objects;

    // Use this for initialization
    void Start() {
        BackButton back = GameObject.FindObjectOfType<BackButton>();

        if (back != null)
        {
            back.gameObject.SetActive(false);
        }
        timer = GameObject.FindObjectOfType<Timer>();
        timer.gameObject.SetActive(false);

        bomb = GameObject.Find("Bomb");
        bomb.SetActive(false);
        
        this.show();
	}

    void startGame()
    {
        bomb.SetActive(true);
        timer.gameObject.SetActive(true);
        timer.startTimer();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("Game started");
            startGame();
        }
    }

    void OnMouseDown()
    {
        startGame();
        this.hide();
    }
}
