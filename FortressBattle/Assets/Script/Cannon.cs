using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    public Rigidbody2D structure;
    float knockback = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown("l"))
       // {
       //     shoot();
       //     structure.AddForce(new Vector2 (-knockback, 0));
       // }
    }

    void shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown("space") )
        {
            shoot();
            structure.AddForce(new Vector2(-knockback, 0));
        }
    }
    
}

