using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEnergy : MonoBehaviour
{

    public DrawLine drawLine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("I GOT HIT");
        if (collision.gameObject.tag == "Reset")
        {
            drawLine.lineIsActive = true;
            drawLine.totalCount = 0;
        }
    }
}
