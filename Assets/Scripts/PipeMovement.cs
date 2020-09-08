using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public Rigidbody2D pipeBody;

    public float speed = 5000f;

    private int boundX;

    // Start is called before the first frame update
    void Start()
    {
        pipeBody = this.GetComponent<Rigidbody2D>();

        boundX = -13000;
        pipeBody.velocity = new Vector2(-speed, 0);
        Debug.Log("This pipe Velocity is now 5000");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x < boundX)
            Destroy(this.gameObject);
    }
}
