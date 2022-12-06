using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Essuyer : TouchableObject
    {

        public bool drag;

        public Vector3 posStart;

        public bool trigger;

        public float pourcent;

        public Vector2 lastPosition;

        public Rigidbody2D rb;

        public float speedObj;

        public override void OnTouch(Touch touchInfo)
        {
            if (touchInfo.phase == TouchPhase.Moved)
            {
                drag = true;
            }
            else
            {
                drag = false;
            }
        }


        public override void TouchUp()
        {
            drag = false;
        }
        public void Start()
        {
            posStart = transform.position;
        }

        private void Update()
        {
            if (drag)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }

            Vector2 currentPosition = transform.position;

            speedObj = Vector2.Distance(currentPosition, lastPosition);

            lastPosition = currentPosition;


        }

    }
}


