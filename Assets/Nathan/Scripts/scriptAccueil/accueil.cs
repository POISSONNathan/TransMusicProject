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
        public bool MovingLeft;
        public bool MovingRight;

        public bool selectPossible = true;
        public int levelSelect = 0;

        public ManagerManager gm;

        public bool stopReloadString = false;

        public GameObject FondLV1;
        public GameObject FondLV2;

        public float Fade;

        public GameObject mapObj;

        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();
            gm.ac = this;
            gm.accueilScene = true;
            Fade = 1;
            MovingLeft = false;
            MovingRight = false;
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
                if (levelSelect == 1)
                {
                    if (MovingRight == true)
                    {
                        StartCoroutine(SpriteFade(FondLV1.GetComponent<SpriteRenderer>(), 0, 0.5f));
                    }
                    if (MovingLeft == true)
                    {
                        StartCoroutine(SpriteFade(FondLV2.GetComponent<SpriteRenderer>(), 1, 0.5f));
                    }
                }
                if (levelSelect == 2)
                {
                    if (MovingRight == true)
                    {
                        StartCoroutine(SpriteFade(FondLV2.GetComponent<SpriteRenderer>(), 0, 0.5f));
                    }
                    if (MovingLeft == true)
                    {
                        StartCoroutine(SpriteFade(FondLV1.GetComponent<SpriteRenderer>(), 1, 0.5f));
                    }
                }
                if(levelSelect == 0)
                {
                    if (MovingLeft == true)
                    {
                        StartCoroutine(SpriteFade(FondLV1.GetComponent<SpriteRenderer>(), 1, 0.5f));
                    }
                }
            }

            mapObj.transform.position = Vector3.Lerp(mapObj.transform.position, nextPos, pourcentMove);

            if (mapObj.transform.position == nextPos)
            {
                pourcentMove = 0;
                moveCamera = false;
                MovingLeft = false;
                MovingRight = false;
            }   
        }

        private void moveLeft()
        {   
            levelSelect--; 
            moveCamera = true;
            nextPos = new Vector3(mapObj.transform.position.x + 6.51f, mapObj.transform.position.y, mapObj.transform.position.z);
            MovingLeft = true;
        }

        private void moveRight()
        {
            levelSelect++;
            moveCamera = true;
            nextPos = new Vector3(mapObj.transform.position.x - 6.51f, mapObj.transform.position.y, mapObj.transform.position.z);
            MovingRight = true;
        }

        public IEnumerator SpriteFade(
            SpriteRenderer sr,
            float endValue,
            float duration)
        {
            float elapsedTime = 0;
            float startValue = sr.color.a;
            while (elapsedTime < duration)
            {
                elapsedTime += Time.deltaTime;
                float newAlpha = Mathf.Lerp(startValue, endValue, elapsedTime / duration);
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, newAlpha);
                yield return null;
            }
        }

    }
}
