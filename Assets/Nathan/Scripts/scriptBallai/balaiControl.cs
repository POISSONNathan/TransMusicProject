using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class balaiControl : TouchableObject 
    {

        public Vector2 initialPosition;
        public Vector2 targetPosition;
        public Transform target;
        public bool shouldGoToTarget = false;
        public bool goBack = false;
        public float delta;
        public float speed;

        public bool touched = false;

        

        public LevelManager lm;

        private Vector2 mousePos;

        // Start is called before the first frame update
        void Start()
        {   
            initialPosition = transform.position;
            
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            if (shouldGoToTarget)
            {
                delta += Time.deltaTime * speed;
                transform.position = Vector2.Lerp(initialPosition, targetPosition, delta);
            }
            if (delta >= 1)
            {
                shouldGoToTarget = false;
                delta = 0;
                
                goBack = !goBack;
            }
            
            if (goBack == true && shouldGoToTarget == false)
            {
                targetPosition = initialPosition;
                initialPosition = transform.position;
                shouldGoToTarget = true;
            }

            if (Input.touchCount > 0 && !lm.gamePause )
            {

                Touch touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    //When a touch has first been detected,change the message and record the starting position
                    case TouchPhase.Began:
                        if (!lm.gamePause)
                        {
                            touched = true;
                            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                            Debug.Log(mousePos);
                        }

                        

                        break;
                    case TouchPhase.Moved:
                        if (touched)
                        {
                            if (!shouldGoToTarget && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < mousePos.x)
                            {
                                targetPosition = target.position;
                                initialPosition = transform.position;
                                delta = 0;
                                shouldGoToTarget = true;
                                Debug.Log("bouge");
                            }
                        }
                        break;

                    case TouchPhase.Ended:
                        touched = false;

                        break;
                }
            }


        }

        

        private void OnCollisionEnter2D(Collision2D collision)
        {
            lm.scoreScene++;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}