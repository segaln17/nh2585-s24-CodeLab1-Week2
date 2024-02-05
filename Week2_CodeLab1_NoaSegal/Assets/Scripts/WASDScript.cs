using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDScript : MonoBehaviour
{
    public static WASDScript Instance; //creating a singleton so there is only one instance of this at a time

    Rigidbody2D rb2d; //declaring Rigidbody2d variable rb2d

    //setting the amount the player will move:
    public float forceAmount = 20; //declaring and initializing public variable forceAmount that can be modified in the Inspector

    void Awake()
    {
        if (Instance == null) //if there is no other instance of this script
        {
            DontDestroyOnLoad(gameObject); //keep the gameObject this script is on when the scene loads in
            Instance = this; //this becomes the only Instance
        }

        else
        {
            Destroy(gameObject); //if there is another one, destroy this one
        }
    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //get access to the rigidbody of this gameObject
    }

    // Update is called once per frame
    void Update()
    {
        //if W is pressed, go up
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddForce(Vector2.up * forceAmount);
        }

        //if A is pressed, go left
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * forceAmount);
        }
        
        //if S is pressed, go down
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddForce((Vector2.down * forceAmount));
        }
        
        //if D is pressed, go right
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce((Vector2.right * forceAmount));
        }
        
        //to add an effect like sliding on ice, have the velocity change by an amount less than 1:
       // rb2d.velocity *= 0.999f;
    }
}
