using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameCanvas : MonoBehaviour
{
    public Canvas nameCanvas;
    public Text finalScore;
    public Transform ballPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameCanvas.transform.position = ballPos.position;
        finalScore.text = ballPos.position.x.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
