using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneRotate : MonoBehaviour
{
    public float rotation = 10f;
    public KeyCode RTLFT;
    public KeyCode RTRHT;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(RTLFT))
        {
            rb.AddTorque(rotation * Time.deltaTime);
        }

        if (Input.GetKey(RTRHT))
        {
            rb.AddTorque(-rotation * Time.deltaTime); 
        }
    }
}
