using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMoving : MonoBehaviour
{
    public float rotation = 100f;
    public float playerOneSpeed = 10f;
    public KeyCode LFT;
    public KeyCode RHT;
    public Rigidbody2D structureRb;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(LFT))
        {
            rb.velocity = new Vector2(-playerOneSpeed, 0);
            rb.AddTorque(-rotation * Time.deltaTime);
            
        }

        if (Input.GetKey(RHT))
        {
            rb.velocity = new Vector2(playerOneSpeed, 0);
            rb.AddTorque(rotation * Time.deltaTime);
        }
    }
}
