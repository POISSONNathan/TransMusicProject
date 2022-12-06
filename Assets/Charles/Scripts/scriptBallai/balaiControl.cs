using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spaceCharles
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
        // Start is called before the first frame update
        void Start()
        {
            initialPosition = transform.position;
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


        }

        public override void OnTouch(Touch touchInfo)
        {
            if (!shouldGoToTarget)
            {
                Debug.Log("dda");
                targetPosition = target.position;
                initialPosition = transform.position;
                delta = 0;
                shouldGoToTarget = true;
            }
            
        }
    }
}