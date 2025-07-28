using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class OpponentController : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    public float yAmplitude = 3.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position =  new Vector2(transform.position.x, yAmplitude * Mathf.Sin(moveSpeed * Time.time));
    }
}
