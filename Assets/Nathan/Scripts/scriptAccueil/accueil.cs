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

        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();

            gm.myMiniGames1.Add("TrouveMerch");
            gm.myMiniGames1.Add("Magasin");
            gm.myMiniGames1.Add("balai");

            gm.myMiniGames2.Add("Drage&Drop");
            gm.myMiniGames2.Add("Essuyer");
            gm.myMiniGames2.Add("Fils");

            gm.myMiniGames3.Add("Rotate");
            gm.myMiniGames3.Add("ReactionTime");
            gm.myMiniGames3.Add("Lumi�re");

            gm.accueilScene = true;

        }

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
