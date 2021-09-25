using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    public Text time;
    public Text highTime;

    public float highestTime;

    void Start()
    {
        highestTime = PlayerPrefs.GetFloat("highTime");
    }

    // Update is called once per frame
    void Update() {
        time.text = "Time Survived: " + Mathf.Round(WAves.timeSurvived) + " Seconds";
        highTime.text = "Highest Time Survived: " + Mathf.Round(highestTime) + " Seconds";

        if (WAves.timeSurvived > highestTime)
        {
            highestTime = WAves.timeSurvived;
            PlayerPrefs.SetFloat("highTime", highestTime);
        }
	}
}
