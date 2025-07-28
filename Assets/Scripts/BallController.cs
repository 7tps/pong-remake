using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{

    public float ballSpeed = 5f;
    private Rigidbody2D rb;

    public static BallController instance;
    
    // Start is called before the first frame update

    void Awake()
    {
        //create instance
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Start()
    {
        
        //initialize rigidbody
        rb = GetComponent<Rigidbody2D>();
        
        //start game
        StartGame();
    }

    public void StartGame()
    {
        //set ball at center
        transform.position = Vector3.zero;
        
        //calculate initial velocity
        float xVelocity = -1f;
        float yVelocity = Random.Range(-1f, 1f);
        
        //determine going right or left
        bool isRight = Random.value > 0.5f;
        if (isRight)
        {
            xVelocity = 1f;
        }
        
        //set rigidbody velocity
        rb.velocity = new Vector2(xVelocity, yVelocity) * ballSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
