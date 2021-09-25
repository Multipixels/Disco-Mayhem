using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMove : MonoBehaviour {

    public float restriction;
    public float back;

    public float speed;

	void Update () {
        Vector3 pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x <= restriction)
        {
            pos.x = back;
            transform.position = pos;
        }
	}
}
