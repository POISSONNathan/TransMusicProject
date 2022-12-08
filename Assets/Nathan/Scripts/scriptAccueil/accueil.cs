using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace Nathan
{
    public class accueil : MonoBehaviour
    {
        private Vector2 startTouchPos;
        private Vector2 endTouchPos;
        private Vector3 nextPos;

        private float pourcentMove = 0;

        private bool moveCamera;

        public GameObject myButton;

        public bool selectPossible = true;
        public int levelSelect = 0;

        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startTouchPos = Input.GetTouch(0).position;
            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endTouchPos = Input.GetTouch(0).position;

                if (startTouchPos.x < endTouchPos.x && moveCamera == false && levelSelect > 0)
                {
                    moveLeft();
                }
                if (startTouchPos.x > endTouchPos.x && moveCamera == false && levelSelect < 2)
                {
                    moveRight();
                }
            }
            if (moveCamera == true)
            {
                pourcentMove += 0.001f;
            }

            transform.position = Vector3.Lerp(transform.position, nextPos, pourcentMove);

            if (transform.position == nextPos)
            {
                pourcentMove = 0;
                moveCamera = false;
            }

            if (moveCamera == false)
            {
                myButton.GetComponent<Image>().color = Color.green;
                selectPossible = true;
            }

            if (moveCamera == true)
            {
                myButton.GetComponent<Image>().color = Color.grey;
                selectPossible = false;
            }

            
        }

        private void moveLeft()
        {   
            levelSelect--;
            moveCamera = true;
            nextPos = new Vector3(transform.position.x - 6.51f, transform.position.y, transform.position.z);

        }

        private void moveRight()
        {
            levelSelect++;
            moveCamera = true;
            nextPos = new Vector3(transform.position.x + 6.51f, transform.position.y, transform.position.z);

        }

        public void StartGame()
        {
            if (levelSelect == 0)
            {
                SceneManager.LoadScene("Drage&Drop", LoadSceneMode.Single);
            }
        }
    }
}
