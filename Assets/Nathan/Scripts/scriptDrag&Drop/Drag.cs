using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{
    public class Drag : TouchableObject
    {
        private bool drag;

        //public float randomColor;
        //public SpriteRenderer sr;
        //public string colorObj;

        public Vector3 posStart;

        public bool trigger;

        public detectDrag dd;

        public listObj lo;

        public void Start()
        {
            dd.scoreSceneNeed = lo.objARecycler.Count;
            dd.nextScene = "Essuyer";

            //randomColor = Random.Range(0f, 1f);
            //if (randomColor >= 0.5)
            //{
            //    sr.color = new Color(1, 0, 0);
            //    colorObj = "red";
            //}
            //else
            //{
            //    sr.color = new Color(0, 1, 0);
            //    colorObj = "green";
            //}

            posStart = transform.position;
        }

        private void Update()
        {
            if (drag)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }

            else
            {
                if (trigger == false)
                {
                    transform.position = posStart;
                }
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (gameObject.tag == "objPoubelleverte" && collision.gameObject.name == "poubelleRecyclable")
            {
                if (!drag)
                {
                    transform.position = collision.transform.position;
                    dd.scoreScene++;
                    Destroy(this);
                }
            }

            if (gameObject.tag == "objPoubelleJaune" && collision.gameObject.name == "poubelleNonRecyclable")
            {
                if (!drag)
                {
                    transform.position = collision.transform.position;
                    dd.scoreScene++;
                    Destroy(this);
                }
            }
            trigger = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            trigger = false;
        }

        public override void OnTouch(Touch touchinfo)
        {
            drag = true;

        }

        public override void TouchUp()
        {
            drag = false;
        }

    }
}

