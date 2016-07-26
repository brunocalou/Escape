using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    float max_time = 1 + 3 * 60;//3 minutes
    float time_left;
    bool has_started = false;
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

    public void startTimer()
    {
        time_left = max_time;
        timer_text = GetComponent<UnityEngine.UI.Text>();
        has_started = true;
    }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if(has_started)
        {
            time_left -= Time.deltaTime;

            if (time_left <= 0)
            {
                Debug.Log("Game Over");
            }
            else
            {
                timer_text.text = getTimeLeftString();
                //Debug.Log(time_left);
            }
        }
	}
}
