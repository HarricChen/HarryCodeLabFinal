using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawLine : MonoBehaviour
{
    public GameObject linePrefab;     //Grab The LineObject
    public GameObject currentLine;

    public Image healthBar;
    public float healthBarPercentage;



    public bool lineIsActive = true;
    public bool cangetEnergy = true;
    public float totalInk = 100f;
    public float totalCount = 1f;

    public LineRenderer lineRenderer;  //LineRenderer of The linePrefab
    public EdgeCollider2D edgeCollider; //EdgeCollider of the LinePrefab
    public List<Vector2> fingerPostion; //A list of Mouse Position as Vector2 (X,Y)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            cangetEnergy = true;
        }

        if (cangetEnergy)
        {
            if (totalCount > 1)
            {
                totalCount--;
            }
        }

        healthBarPercentage = totalCount / totalInk;
        print(totalCount / totalInk);
        healthBar.fillAmount = healthBarPercentage;


        if (Input.GetMouseButtonDown(0))
        {
            CreateLine();
         //   StartCoroutine(removeLine());
        }

        //If it is far enough to add another line

        if (Input.GetMouseButton(0))
        {
                Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (Vector2.Distance(tempFingerPos, fingerPostion[fingerPostion.Count - 1]) > 0.1f)
                {
                    UpdateLine(tempFingerPos);
                } 
        }

        
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);   //Vector3.zero Object's origin, Quaternion.identity (No Rotation) //From the Beginning it's still one signle object, what changed is the sprite renderer and the collider
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>(); //Assign
        lineRenderer = currentLine.GetComponent<LineRenderer>();  //Assign
        fingerPostion.Clear();  //If you click the mouse again, clear the previous list and start a new list
        fingerPostion.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));  //Add to pos1
        fingerPostion.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));  //Add to pos2
        lineRenderer.SetPosition(0, fingerPostion[0]); 
        lineRenderer.SetPosition(1, fingerPostion[1]);
        edgeCollider.points = fingerPostion.ToArray();
       // lineIsActive = true;
    }

    void UpdateLine (Vector2 newFingerPos)
    {   
        if (totalCount < totalInk)
        {
            lineIsActive = true;
        }
        if (lineIsActive)
        {
            cangetEnergy = false;
            fingerPostion.Add(newFingerPos);
            lineRenderer.positionCount++;
            totalCount++;
            print(lineRenderer.positionCount);
            print(lineIsActive);
            print("Total Count = " + totalCount);
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
            edgeCollider.points = fingerPostion.ToArray();
            if (totalCount > totalInk)
            {
                lineIsActive = false;
                
            }
        }
    }
    IEnumerator removeLine()
    {
        yield return new WaitForSeconds(6);
        Destroy(currentLine);
    }


}
