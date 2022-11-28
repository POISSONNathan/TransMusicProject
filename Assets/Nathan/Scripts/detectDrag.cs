using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{

    public class detectDrag : MonoBehaviour
    {
        private Touch touch;

        /// ////////////////////////////// 
        public Drag currentDraggedObject;
        public TouchableObject currentTouchedObject;

        /// //////////////////////////////
        public Essuyer currentEssuieObject;

        /// //////////////////////////////
        public rotateLight currentRotateObject;
        public List<GameObject> lights;
        public int lightUseCount = 0;

        /// //////////////////////////////
        public List<GameObject> objPressed;
        public objActive currentObjPress;
        public int randomChoice = -1;
        public reactionTime rt;

        /// //////////////////////////////
        public activeRotation currentActiveRotate;

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
                    /// //////////////////////////////
                    currentTouchedObject = tempObject.collider.GetComponent<TouchableObject>();
                    if (currentTouchedObject != null)
                    {
                        currentTouchedObject.OnTouch(Input.GetTouch(0));
                    }

                }

            }

            else
            {
                /// //////////////////////////////
                if (currentTouchedObject != null)
                {
                    currentTouchedObject.TouchUp();
                }

            }
        }
    }
}

