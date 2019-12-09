using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject particle;
    public Transform ballPos;
    // Start is called before the first frame update
    void Start()
    {
        particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        particle.transform.position = ballPos.position;
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        print("i am hit");
        collision.attachedRigidbody.simulated = false;
        particle.SetActive(true);
    }


}
