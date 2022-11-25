using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fils2 : MonoBehaviour
{
    public LineRenderer line;
    public bool drag = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(drag)
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 convertedMousePos = Camera.main.ScreenToWorldPoint(mousePos);
            convertedMousePos.z = 0;
            transform.position = convertedMousePos;

            Vector3 positionDiff = convertedMousePos - line.transform.position;
            line.SetPosition(2,positionDiff - new Vector3(.75f,0,0));
            line.SetPosition(3,positionDiff - new Vector3(.25f,0,0));
        }
    }

    void OnMouseDown()
    {
        drag = true;
    }

    void OnMouseUp()
    {
        drag = false;
    }
}
