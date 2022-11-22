using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectDrag : MonoBehaviour
{

    private Drag currentDraggedObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >0)
        {
            var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);
            var tempRay = Camera.main.ScreenPointToRay(tempVector);
            var tempObject = Physics2D.Raycast(tempRay.origin,tempRay.direction);
            if (tempObject.collider != null )
            {
                Debug.Log("Coucu");
                currentDraggedObject = tempObject.collider.GetComponent<Drag>();
                if (currentDraggedObject != null)
                {
                    Debug.Log(currentDraggedObject);

                    currentDraggedObject.drag = true;
                }
            }
        }
        else
        {
            if(currentDraggedObject != null)
            {
                currentDraggedObject.drag = false;
            }
        }
    }
}
