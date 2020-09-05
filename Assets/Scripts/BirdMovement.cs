using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    public Collider2D birdCollider;
    public Collider2D floorCollider;

    public Vector2 speed;
    public Vector2 gravity;

    // Start is called before the first frame update
    void Start()
    {
        speed = Vector2.down;
        gravity = new Vector2(0, -150);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.down * -gravity);
    }

    void OnTriggerEnter2D(Collider2D floorCollider)
    {
        if(birdCollider.IsTouching(floorCollider))
        {
            Debug.Log("You lost!");
            gravity = Vector2.zero;
            speed = Vector2.zero;
        }
        
    }
}
