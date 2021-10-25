using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPattern : MonoBehaviour
{

private List<CircleIdentifier> circles;


    // Start is called before the first frame update
    void Start()
    {
        circles = new List<CircleIdentifier>();
        for(int i=0; i<transform.childCount; i++)
        {
            var circle = transform.GetChild(i);
            var identifier = circle.GetComponent<CircleIdentifier>();
            identifier.id=i;


            circles.Add(identifier);
           

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseEnterCircle(CircleIdentifier idf)
    {
        Debug.Log(idf.id);
    }
    public void OnMouseExitCircle(CircleIdentifier idf)
    {
           Debug.Log(idf.id);
    }
    public void OnMouseDownCircle(CircleIdentifier idf)
    {
           Debug.Log(idf.id);
    }
    public void OnMouseUpCircle(CircleIdentifier idf)
    {
           Debug.Log(idf.id);
    }






}
