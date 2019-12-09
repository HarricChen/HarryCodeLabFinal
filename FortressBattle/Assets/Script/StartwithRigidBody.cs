using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartwithRigidBody : MonoBehaviour
{
    Rigidbody2D rb;
    bool ballMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!ballMoving)
            {
                rb.simulated = true;
                ballMoving = true;
            }
        }
    }
}
