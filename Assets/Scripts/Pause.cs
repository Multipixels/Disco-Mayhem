using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    bool paused = false;

    public GameObject background;

    public void Update()
    {
        if(Input.GetButtonDown("Pause") || Input.GetButtonDown("PauseControl") == true)
        {
            pauseGame();
        }

        if(paused == true)
        {
            background.SetActive(true);
        } else
        {
            background.SetActive(false);
        }
    }

	public void pauseGame()
    {
        if (paused == false)
        {
            paused = true;
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            Time.timeScale = 1;
        }
    }
	
    public void exit()
    {
        SceneManager.LoadScene("Die");
        Time.timeScale = 1;
    }
}
