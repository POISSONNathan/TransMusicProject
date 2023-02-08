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
            drag = true;
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
            if(Input.touchCount>0)
            {

                Touch touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    //When a touch has first been detected, change the message and record the starting position
                    case TouchPhase.Began:
                        MusicManagerSingleton.Instance.PlaySound3("Eponge");

                        break;
                    case TouchPhase.Moved:
                        if (drag)
                            {
                                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                                transform.Translate(MousePos);
                           
                            }

                        break;
                    case TouchPhase.Ended:
                        drag = false;
                        MusicManagerSingleton.Instance.PlaySound3("Silence");

                        break;
                }
            }
            

            Vector2 currentPosition = transform.position;

            speedObj = Vector2.Distance(currentPosition, lastPosition);

            lastPosition = currentPosition;


        }

    }
}


