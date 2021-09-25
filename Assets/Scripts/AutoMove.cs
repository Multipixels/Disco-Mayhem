using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour {

    public float xMove;
    public float yMove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;
        pos.x += xMove * Time.deltaTime;
        pos.y += yMove * Time.deltaTime;
        transform.position = pos;

	}
}
