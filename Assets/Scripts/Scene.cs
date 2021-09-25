using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

    void Start()
    {
        DontDestroyOnLoad(this);
    }

	public void sceneChoose(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void reset()
    {
        WAves.timeSurvived = 0;
    }
}
