using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Vertical");
        transform.Translate(input * moveSpeed * Time.deltaTime * Vector2.up);
    }
}
