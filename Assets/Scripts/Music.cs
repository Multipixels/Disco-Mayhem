using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {

	void Start () {
        DontDestroyOnLoad(this);
	}

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Game")
        {
            Destroy(gameObject);
        }
    }
}
