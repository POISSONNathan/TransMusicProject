using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationObj : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPos;
    private Quaternion rotationY;
    private float roationSpeedModifier;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("ehaeha");
                rotationY = Quaternion.Euler(0f, 0f, -touch.deltaPosition.x * roationSpeedModifier);
                transform.rotation = rotationY * transform.rotation;
            }
        }
    }
}
