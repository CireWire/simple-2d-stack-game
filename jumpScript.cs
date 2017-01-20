using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {

    public float jumpForce = 500f;
    public float jumpMovement = 500f;

    private Rigidbody2D rb2d;
    private bool jump = false;

	// Use this for initialization
	void Awake () {

        rb2d = GetComponent<Rigidbody2D>();
        jump = false;

	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
	    if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2 (0f, jumpForce));
            jump = true;
        }
            

        }
	}
