using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform structureDirection;
    public float bulletSpeed = 10f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
       // rb.AddForce(transform.right * bulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
      //  rb.velocity = Vector2.right * bulletSpeed;
    }
}
