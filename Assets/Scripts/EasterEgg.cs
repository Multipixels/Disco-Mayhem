using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEgg : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d") == true)
        {
            if (Input.GetKey("i") == true)
            {
                if (Input.GetKey("s") == true)
                {
                    if (Input.GetKey("c") == true)
                    {
                        if (Input.GetKey("o") == true)
                        {
                            SecretEasterEgg();
                        }
                    }
                }
            }
        }
    }

    public void SecretEasterEgg()
    {
        SceneManager.LoadScene("EasterEgg");
    }
}
