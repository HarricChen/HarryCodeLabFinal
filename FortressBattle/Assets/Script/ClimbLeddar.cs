using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbLeddar : MonoBehaviour
{
    public float distance =5f;
    
    Rigidbody2D rb;
    public LayerMask WhatIsLadder;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, WhatIsLadder);
        if (hitInfo.collider != null)
        {
            if (Input.GetKey("q") )
            {
                rb.velocity = hitInfo.collider.transform.up * 2f;
                rb.gravityScale = 0;
            }

            if (Input.GetKey("z"))
            {
                rb.velocity = -hitInfo.collider.transform.up * 2f;
                rb.gravityScale = 0;
            }
        }
        rb.gravityScale = 3f;
    }
    
}
