using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    float max_time = 11 + 10 * 60;//10 minutes
    float time_left;
    UnityEngine.UI.Text timer_text;

    string getTimeLeftString()
    {
        int seconds = ((int)time_left) % 60;
        string seconds_str = "" + seconds;
        if (seconds < 10)
        {
            seconds_str = "0" + seconds_str;
        }
        
        return Mathf.Floor(time_left / 60) + ":" + seconds_str;
    }

	// Use this for initialization
	void Start () {
        time_left = max_time;
        timer_text = GetComponent<UnityEngine.UI.Text>();
	}
	
	// Update is called once per frame
	void Update () {

        time_left -= Time.deltaTime;

        if (time_left <= 0)
        {
            Debug.Log("Game Over");
        } else
        {    
            timer_text.text = getTimeLeftString();
            //Debug.Log(time_left);
        }
	}
}
