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

        public bool moveCamera;

        public bool selectPossible = true;
        public int levelSelect = 0;

        public ManagerManager gm;

        public bool stopReloadString = false;

        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();
            gm.ac = this;
            gm.accueilScene = true;

        }

        void Update()
        {
            if (stopReloadString == false)
            {
                gm.myMiniGames1 = new List<string> { "Drage&Drop", "Essuyer", "Fils" };
                gm.myMiniGames2 = new List<string> { "TrouveMerch", "Magasin", "balai" };
                gm.myMiniGames3 = new List<string> { "Rotate", "ReactionTime", "Lumière" };
            }
            

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
    }
}
