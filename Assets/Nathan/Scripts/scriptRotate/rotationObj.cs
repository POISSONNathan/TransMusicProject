using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class rotationObj : MonoBehaviour
    {
        private Touch touch;
        public activeRotation ar;

        public float getRotation;

        public Vector3 lastRotation;

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (ar.isActive == true)
            {
                faceMouse();
            }



        }

        void faceMouse()
        {
            Vector3 touchPos = Input.mousePosition;
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);
 
            Vector2 direction = new Vector2(
                touchPos.x - transform.position.x,
                touchPos.y - transform.position.y
            );
 
            transform.up = direction;
        }
    }
}
