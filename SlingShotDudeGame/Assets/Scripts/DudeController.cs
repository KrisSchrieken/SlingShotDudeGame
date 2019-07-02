using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeController : Physics
{

    private const float JUMP_VELOCITY = 7f;
    private const float MAX_VELOCITY = 7f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void ComputeUserVelocity() {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump")) {

            velocity.y = JUMP_VELOCITY;
        }

        targetVelocity = move * MAX_VELOCITY; 
    }
}
