﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{

    //Max height
    public int maxHeight = 5000;

    public Collider2D birdCollider;
    public Collider2D floorCollider;

    public Rigidbody2D birdBody;

    //For gravity
    public float speed;

    //For jumping
    public float force;
    public Vector2 jump;

    // Start is called before the first frame update
    void Start()
    {
        //For jumping purposes
        jump = Vector2.up;
        force = 10000;

        birdBody.gravityScale = 1000;

        //Set initial velocity and then never change it
        speed = 2500;
        birdBody.velocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Prevents bird to go out of bounds vertically
        if (birdBody.position.y > maxHeight)
            transform.position = new Vector2(transform.position.x, maxHeight);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You jumped!");
            birdBody.AddForce(jump * force, ForceMode2D.Impulse);
        }
            
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You lost!");

        //Just restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
