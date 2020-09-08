using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{ 
    public Collider2D birdCollider;
    public Collider2D floorCollider;

    public Rigidbody2D birdBody;

    //For gravity
    public float speed;
    public int gravity;

    //For jumping
    public float force;
    public Vector2 jump;

    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        //For jumping purposes
        jump = Vector2.up;
        force = 10000;

        gravity = 1000;
        birdBody.gravityScale = gravity;

        //Set initial velocity and then never change it
        speed = 2500;
        birdBody.velocity = Vector2.down * speed;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z ));

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Prevents bird to go out of bounds vertically
        if (birdBody.position.y > screenBounds.y)
            transform.position = new Vector2(transform.position.x, screenBounds.y);

        if (birdBody.position.x < -screenBounds.y)
            transform.position = new Vector2(-11158, transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
            birdBody.AddForce(jump * force, ForceMode2D.Impulse);
            
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Add like a restart button or smth
        //Just restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
