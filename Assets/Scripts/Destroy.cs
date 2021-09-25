using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public float destroyTimer;
	
	// Update is called once per frame
	void Update () {
        destroyTimer -= Time.deltaTime;

        if(destroyTimer <= 0)
        {
            Destroy(gameObject);
        }
	}
}
