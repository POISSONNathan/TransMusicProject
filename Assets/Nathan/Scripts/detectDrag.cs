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
        public List<GameObject> lights;
        public int lightUseCount = 0;

        /// //////////////////////////////
        public List<GameObject> objPressed;

        /// //////////////////////////////
        public int scoreScene;
        public int scoreSceneNeed;
        public string nextScene;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (scoreScene == scoreSceneNeed)
            {
                SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
            }

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

