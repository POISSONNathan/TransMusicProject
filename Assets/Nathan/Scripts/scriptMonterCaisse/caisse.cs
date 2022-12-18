using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class caisse : MonoBehaviour
    {
        public ManagerManager gm;

        public bool touchPossible = true;

        public Vector2 posStart;

        public bool good;

        public int nbrObj;
        public bool Up;
        public GameObject Boite;
        public GameObject MonteCharge;

        private LevelManager lm;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            lm.scoreSceneNeed = 2;

            lm.secondMiniGame = 10;

            posStart = transform.position;
            good = false;
            Up = false;
            MonteCharge.transform.SetParent(this.transform);
            MonteCharge.transform.position = new Vector2(0.469999999f, -6.76000023f);
        }

        // Update is called once per frame
        void Update()
        {
            //if (transform.position.y >= 0.56)
            //{
            //    MonteCharge.transform.parent = null;
            //    Up = true;
            //}

            //if (Up == true)
            //{
            //    if (MonteCharge.transform.position.y > -5.8)
            //    {
            //        MonteCharge.transform.position = new Vector2(MonteCharge.transform.position.x, MonteCharge.transform.position.y - 0.003f);
            //    }
            //}

            if (good == false)
            {
                if (Input.touchCount > 0 && touchPossible == true)
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y + 0.4f);
                    touchPossible = false;
                }
                if (Input.touchCount == 0)
                {
                    touchPossible = true;
                }


                if (transform.position.y > posStart.y - 0.5f)
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y - 1.2f * Time.deltaTime);
                }
            }
            if (good == true)
            {                
                transform.position = new Vector2(transform.position.x + 2.5f * Time.deltaTime, transform.position.y);

                if (transform.position.x > 3)
                {
                    lm.scoreScene ++;
                    if (lm.scoreScene < lm.scoreSceneNeed)
                    {
                        Instantiate(gameObject, posStart, Quaternion.identity);
                    }
                    Destroy(gameObject);
                }
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Finish"){
                transform.position = collision.transform.position;
                transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y + 0.9f);
                good = true;
                MonteCharge.transform.parent = null;
            }
        }

    }
}

