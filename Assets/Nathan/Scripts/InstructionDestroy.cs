using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    Destroy(this.gameObject);
                    break;
            }
        }
    }
}
