using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WAves : MonoBehaviour {

    Vector3 discoBallSpawn;

    public GameObject warning;
    public GameObject discoBall;
    public GameObject crater;

    public float discoTimerFallCountdown = 4;
    public float discoTimerFallTimer = 4;

    public float crateCountdown = 4;
    public float crateTimer = 4;

    public float randomSpawn;

    public static float timeSurvived;

	// Update is called once per frame
	void FixedUpdate () {

        timeSurvived += Time.deltaTime;

        if (discoTimerFallTimer >= 1)
        {
            discoTimerFallTimer -= 0.001f;
        }

            discoTimerFallCountdown -= Time.deltaTime;

        if(discoTimerFallCountdown <= 0)
        {
            randomSpawn = Random.Range(-7,7);
            Vector3 warningPosition = transform.position;
            warningPosition.x = randomSpawn;
            warningPosition.y = 3;
            Instantiate(warning, warningPosition, transform.rotation);

            Vector3 ballPosition = warningPosition;
            ballPosition.y += 116;
            Instantiate(discoBall, ballPosition, transform.rotation);

            discoTimerFallCountdown = discoTimerFallTimer;
        }

        if(discoTimerFallTimer <= 1.5f)
        {
            if (crateTimer >= 2)
            {
                crateTimer -= 0.001f;
            }
            Vector3 cratePosition = transform.position;
            cratePosition.x = 18;
            cratePosition.y = -1;

            crateCountdown -= Time.deltaTime;

            if(crateCountdown <= 0)
            {
                crateCountdown = crateTimer;
                Instantiate(crater, cratePosition, transform.rotation);
            }
        }
	}
}
