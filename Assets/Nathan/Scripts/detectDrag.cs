using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{

    public class detectDrag : MonoBehaviour
    {
        /// ////////////////////////////// 
        public TouchableObject currentTouchedObject;
        /// //////////////////////////////
        
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
                    var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);
                    var tempRay = Camera.main.ScreenPointToRay(tempVector);
                    var tempObject = Physics2D.Raycast(tempRay.origin, tempRay.direction);
                    if(tempObject.collider.GetComponent<TouchableObject>() == currentTouchedObject)
                    {
                        currentTouchedObject.TouchUp();
                        currentTouchedObject = null;
                    }
                }

            }
        }

       
    }
}

