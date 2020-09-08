using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public Rigidbody2D pipeBody;

    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        pipeBody.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }
}
