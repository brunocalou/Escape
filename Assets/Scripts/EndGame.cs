using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{

    Wire.Color[] color_order = { Wire.Color.RED, Wire.Color.BLUE, Wire.Color.YELLOW };
    int current_color_idx = 0;
    public GameObject game_win;
    Timer timer;

    void Start()
    {
        game_win.SetActive(false);
        timer = GameObject.FindObjectOfType<Timer>();
    }

    public void OnWireCut(Wire wire)
    {
        if (color_order[current_color_idx] == wire.color)
        {
            if (current_color_idx == color_order.Length - 1)
            {
                runGameWin();
            }
            else
            {
                current_color_idx += 1;
            }
        }
        else
        {
            runGameOver();
        }

    }

    public void runGameOver()
    {
        Debug.Log("GAME OVER");
    }

    void runGameWin()
    {
        Debug.Log("GAME WIN");
        foreach (ZoomItem item in GameObject.FindObjectsOfType<ZoomItem>())
        {
            item.hideZoomedItemAndBackButton();
        }
        game_win.SetActive(true);
        timer.stopTimer();
    }
}
