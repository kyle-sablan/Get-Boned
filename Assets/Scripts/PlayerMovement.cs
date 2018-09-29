using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //Public Variables
    public float moveSpeed;

    //Private Variables
    private Rigidbody2D myRB;

    void Start()
    {
        myRB = gameObject.GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update ()
    { 
        //Movement on x-axis
        //With input
		if(Input.GetAxisRaw("Horizontal") < -0.5f || Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            myRB.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), myRB.velocity.y);
        }

        //Without input
        if (Input.GetAxisRaw("Horizontal") > -0.5f && Input.GetAxisRaw("Horizontal") < 0.5f)
        {
            myRB.velocity = new Vector2(0f, myRB.velocity.y);
        }

    }
}
