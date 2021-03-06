﻿using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{

    Wire.Color[] color_order = { Wire.Color.RED, Wire.Color.BLUE, Wire.Color.YELLOW };
    int current_color_idx = 0;
    public GameObject game_win;
    public Timer timer;

    void Start()
    {
        game_win.SetActive(false);
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
        timer.stopTimer();
        Handheld.PlayFullScreenMovie("GameOver.mp4", Color.black, FullScreenMovieControlMode.Hidden);
    }

    void runGameWin()
    {
        Debug.Log("GAME WIN");
        timer.stopTimer();
        foreach (ZoomedItem item in GameObject.FindObjectsOfType<ZoomedItem>())
        {
            item.hide();
        }
        BackButton back = GameObject.FindObjectOfType<BackButton>();
        if (back != null)
        {
            back.hide();
        }
        game_win.SetActive(true);
    }
}
