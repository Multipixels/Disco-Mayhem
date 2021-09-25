using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBallFloor : MonoBehaviour {

    public AudioSource ball;
	
	void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        if(pos.y >= 7)
        {
            ball.mute = true;
        } else
        {
            ball.mute = false;
        }

    }
}
