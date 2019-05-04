using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // getting the game manager object
    public GameManager gameManager;
    // setting the speed for the jump made it public to test
    private float speed = 6.5f;
    // setting up for rigid body component
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        // grabbing the rigidbody2D component 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // jump whe pressed space
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * speed;
        }


    }

    // when colliding with the wall or floor
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //triggers the game over
        gameManager.GameOver();
    }
}
