using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // movement speeds 
    private const float UP_SPEED = 2.0F;
    private const float DOWN_SPEED = -1.5F;
    private const float RIGHT_SPEED = 5.0F;
    private const float LEFT_SPEED = -5.0F; 

    public Rigidbody dude; 
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Movement Started");
        dude.useGravity() = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey("w") ) {
            dude.AddForce(0, UP_SPEED * Time.deltaTime, 0);    
        }

        if (Input.GetKey("s")) {
            dude.AddForce(0, DOWN_SPEED * Time.deltaTime, 0);
        }

        if (Input.GetKey("a")) {
            dude.AddForce(0, LEFT_SPEED * Time.deltaTime, 0);
        }

        if (Input.GetKey("d")) {
            dude.AddFoce(0, RIGHT_SPEED * Time.deltaTime, 0);
        }

    }
}
