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

        public detectDrag dd;

        void Start()
        {
            dd.nextScene = "balai";
            dd.scoreSceneNeed = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if (ar.isActive && getRotation >= -25 && getRotation <= 110)
            {
                faceTouch();
            }

            if (getRotation >= 110)
            {
                dd.gameFinish = true;
                Destroy(this);
            }

            if (getRotation <= -25)
            {
                getRotation = -25;
            }
        }

        void faceTouch()
        {
            Vector3 touchPos = Input.mousePosition;
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);

            Vector2 direction = new Vector2(touchPos.x - transform.position.x, touchPos.y - transform.position.y);

            transform.up = direction;

            float currentPosition = transform.eulerAngles.z;

            if (currentPosition < lastRotation) { getRotation++; }
            if (currentPosition > lastRotation) { getRotation--; }

            lastRotation = currentPosition;
            transform.Rotate(Vector3.forward, 1);
    }
}
}
