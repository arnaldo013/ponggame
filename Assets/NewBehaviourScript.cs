﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 20;

    public Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(-1, -1) * speed;
        StartCoroutine (Pause()) ;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "DindingKanan" || other.collider.name == "DindingKiri")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
        }
    }
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1);
        ball.velocity = new Vector2(-1, -1) * speed;
        yield return new WaitForSeconds(1);
    }


}
