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
        public int scoreScene;
        public int scoreSceneNeed;
        public bool gameFinish = false;
        public bool goNexwtGame = false;

        public GameObject animWinEndGame;
        public bool createAnim = false;

        public GameObject animStartGame;
        public bool createAnim2 = false;

        public GameObject animStartGameReal;
        public bool createAnim3 = false;

        public string nextScene;

        public bool switchMiniGame = false;

        void Start()
        {
            if (createAnim3 == false)
            {
                Instantiate(animStartGameReal, new Vector3(0, 0, 0), Quaternion.identity);
                createAnim3 = true;
            }

            if (createAnim2 == false )
            {
                StartCoroutine(AnimText());
            }

            switchMiniGame = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (scoreScene == scoreSceneNeed || gameFinish == true) 
            {

                if (createAnim == false)
                {
                    Instantiate(animWinEndGame, new Vector3(0, 0, 0), Quaternion.identity);
                    createAnim = true;
                }
                StartCoroutine(EndGame());
            }
            if (goNexwtGame == true)
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

        IEnumerator EndGame()
        {
            yield return new WaitForSeconds(0.7f);
            goNexwtGame = true;
        }

        IEnumerator AnimText()
        {
            yield return new WaitForSeconds(0.7f);
            Instantiate(animStartGame, new Vector3(0, 0, 0), Quaternion.identity);
            createAnim2 = true;
        }
    }
}

