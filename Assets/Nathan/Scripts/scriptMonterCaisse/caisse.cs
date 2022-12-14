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

        void Start()
        {
            gm = ManagerManager.GetManagerManager;
            gm.lm.scoreSceneNeed = 2;

            posStart = transform.position;
            good = false;
        }

        // Update is called once per frame
        void Update()
        {
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
                    transform.position = new Vector2(transform.position.x, transform.position.y - 0.003f);
                }
            }
            if (good == true)
            {
                transform.position = new Vector2(transform.position.x + 0.01f, transform.position.y);

                if (transform.position.x > 3)
                {
                    gm.lm.scoreScene ++;
                    if (gm.lm.scoreScene < gm.lm.scoreSceneNeed)
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
            }
        }

    }
}

