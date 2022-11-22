using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectRotate : MonoBehaviour
{

    private rotateLight currentRotateObject;

    public List<GameObject> lights;

    public int lightUseCount = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);
            var tempRay = Camera.main.ScreenPointToRay(tempVector);
            var tempObject = Physics2D.Raycast(tempRay.origin, tempRay.direction);
            if (tempObject.collider != null)
            {
                currentRotateObject = tempObject.collider.GetComponent<rotateLight>();
                if (currentRotateObject.gameObject == lights[lightUseCount])
                {
                    currentRotateObject.rotate = true;
                }
            }
        }
        else
        {
            if (currentRotateObject != null)
            {
                currentRotateObject.rotate = false;
            }
        }
    }
}
