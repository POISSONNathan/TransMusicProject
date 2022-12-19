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

        public GameObject buttonPlayOff;
        public GameObject buttonPlayOn;

        public bool fullDisqueLvl1;
        public bool fullDisqueLvl2;
        public bool fullDisqueLvl3;

        public GameObject disqueDiamant;

        public Vector3 posStart;

        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();
            gm.ac = this;
            gm.accueilScene = true;
            Fade = 1;
            MovingLeft = false;
            MovingRight = false;

            posStart = mapObj.transform.position;
        }

        void Update()
        {
            if (gm.introGame == false)
            {
                if (fullDisqueLvl1 == true && fullDisqueLvl2 == true && fullDisqueLvl3 == true)
                {
                    disqueDiamant.SetActive(true);
                }

                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    startTouchPos = Input.GetTouch(0).position;
                }
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    endTouchPos = Input.GetTouch(0).position;

                    if (startTouchPos.x < endTouchPos.x - 200 && moveCamera == false && levelSelect > 0)
                    {
                        moveLeft();
                    }
                    if (startTouchPos.x > endTouchPos.x + 200 && moveCamera == false && levelSelect < 3)
                    {
                        moveRight();
                    }
                }

                if (moveCamera == true)
                {
                    pourcentMove += 0.5f * Time.deltaTime;
                    if (levelSelect == 0)
                    {
                        if (MovingLeft == true)
                        {
                            StartCoroutine(SpriteFade(FondLV1.GetComponent<SpriteRenderer>(), 1, 0.5f));
                        }
                    }
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
                }

                mapObj.transform.position = Vector3.Lerp(mapObj.transform.position, nextPos, pourcentMove);

                if (mapObj.transform.position == nextPos)
                {
                    pourcentMove = 0;
                    moveCamera = false;
                    MovingLeft = false;
                    MovingRight = false;
                }

                if (levelSelect == 3)
                {
                    buttonPlayOff.SetActive(false);
                    buttonPlayOn.SetActive(false);
                }
                else
                {
                    buttonPlayOff.SetActive(true);
                }

                if (gm.lm.miniGame1End == true)
                {
                    mapObj.transform.position = new Vector3(posStart.x, posStart.y, posStart.z);
                    levelSelect = 0;
                    gm.lm.miniGame1End = false;
                }

                if (gm.lm.miniGame2End == true)
                {
                    mapObj.transform.position = new Vector3(posStart.x - 6.51f, posStart.y, posStart.z);
                    levelSelect = 1;
                    gm.lm.miniGame2End = false;
                }

                if (gm.lm.miniGame3End == true)
                {
                    mapObj.transform.position = new Vector3(posStart.x - 6.51f * 2, posStart.y, posStart.z);
                    levelSelect = 2;
                    gm.lm.miniGame3End = false;
                }
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
