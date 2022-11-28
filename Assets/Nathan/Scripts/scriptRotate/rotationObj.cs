using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class rotationObj : MonoBehaviour
    {
       public activeRotation ar;
       public float getRotation;
       public float lastRotation;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (ar.isActive){
                faceTouch();
            }
        }

        void faceTouch()
        {
            Vector3 touchPos = Input.mousePosition;
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);

            Vector2 direction = new Vector2 (touchPos.x - transform.position.x, touchPos.y - transform.position.y);

            transform.up = direction; 

            float currentPosition = transform.rotation.z;

            if(currentPosition > lastRotation){getRotation ++; }
            if(currentPosition < lastRotation){ getRotation --;}
 
            lastRotation = currentPosition;
        }
    }
}
