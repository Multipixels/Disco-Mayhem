using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {

    public Rigidbody2D player;
    public SpriteRenderer playerSprite;

    public float health = 3;

    public Image heart1;
    public Image heart2;
    public Image heart3;

    public float speed = 7;

    public Animator invin;

    float invul = 3f;
    float invulnCounter;

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.tag == "Disco")
        {
            health--;
            invulnCounter = invul;
            invin.SetInteger("Invinc", 1);
            gameObject.layer = 8;

        }
    }

    void Update()
    {
        invulnCounter -= Time.deltaTime;

        if (invulnCounter > 0)
        {
            invulnCounter -= Time.deltaTime;
        }

        if (invulnCounter <= 0)
        {
            gameObject.layer = 0;
            invin.SetInteger("Invinc", 0);
        }

        if (health >= 3)
        {
            heart3.enabled = true;
        }
        else
        {
            heart3.enabled = false;
        }

        if (health >= 2)
        {
            heart2.enabled = true;
        }
        else
        {
            heart2.enabled = false;
        }

        if (health >= 1)
        {
            heart1.enabled = true;
        }
        else
        {
            heart1.enabled = false;
        }

        if(health <= 0)
        {
            SceneManager.LoadScene("Die");
        }
    }

	// Update is called once per frame
	void FixedUpdate () {

        speed += 0.003f;

        Vector3 pos = transform.position;

        if (Input.GetAxis("D") >= 0.01)
        {
            pos.x += speed * Time.deltaTime;
            playerSprite.flipX = false;
        }
        if (Input.GetAxis("DControl") >= 0.01)
        {
            pos.x += speed * Time.deltaTime;
            playerSprite.flipX = false;
        }
        if (Input.GetAxis("A") >= 0.01)
        {
            pos.x += -speed * Time.deltaTime;
            playerSprite.flipX = true;
        }
        if (Input.GetAxis("AControl") >= 0.01)
        {
            pos.x += -speed * Time.deltaTime;
            playerSprite.flipX = true;
        }
        if (Input.GetAxis("W") >= 0.01)
        {
            pos.y += 9f * Time.deltaTime;
        }
        if (Input.GetAxis("WControl") >= 0.01)
        {
            pos.y += 9f * Time.deltaTime;
        }

        if (pos.x <= -8.0)
        {
            pos.x = -8.0f;
        }
        if (pos.x >= 8.0)
        {
            pos.x = 8.0f;
        }
        transform.position = pos;
    }
}
