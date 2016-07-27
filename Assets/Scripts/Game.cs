using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    Wire.Color [] color_order = { Wire.Color.RED, Wire.Color.BLUE, Wire.Color.YELLOW };
    int current_color_idx = 0;

    public void OnWireCut(Wire wire)
    {
        if (color_order[current_color_idx] == wire.color)
        {
            if (current_color_idx == color_order.Length - 1)
            {
                runGameWin();
            } else
            {
                current_color_idx += 1;
            }
        } else
        {
            runGameOver();
        }
        
    }

    void runGameOver()
    {
        Debug.Log("GAME OVER");
    }

    void runGameWin()
    {
        Debug.Log("GAME WIN");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
