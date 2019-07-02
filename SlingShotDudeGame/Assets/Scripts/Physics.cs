using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    protected Rigidbody2D dude;

    // gravity vars
    protected Vector2 velocity;
    public float gravityModifier = 1f;

    protected Vector2 targetVelocity;

    // to get user velocity from key inputs 
    protected virtual void ComputeUserVelocity() { }

    void OnEnable() {
        dude = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = Vector2.zero;
        ComputeUserVelocity();
    }


    // for rigid body movements 
    void FixedUpdate() {

        // gravity velocity
        velocity += Physics2D.gravity * Time.deltaTime * gravityModifier;

        velocity.x = targetVelocity.x; // left/right movement 

        Vector2 deltaPos = velocity * Time.deltaTime;
        Vector2 move = Vector2.right * deltaPos.x;
        Movement(move, false);

        move = Vector2.up * deltaPos.y;

        Movement(move, true); 
    }

    void Movement(Vector2 move, bool yMov) {
        dude.position += move; 
    }
}
