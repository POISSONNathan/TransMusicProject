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

        public SpriteRenderer sr;

        public void Start()
        {
            posStart = transform.position;

            sr = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            if (drag )
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            trigger = true;

            if (gameObject.tag == "objPoubelleVerte" && collision.gameObject.name == "poubelleVerte")
            {
                if (!drag)
                {
                    transform.position = collision.transform.position;
                    lo.objPoubelleVerte++;
                    Destroy(this.gameObject);
                }
            }

            if (gameObject.tag == "objPoubelleJaune" && collision.gameObject.name == "poubelleJaune")
            {
                if (!drag)
                {
                    transform.position = collision.transform.position;
                    lo.objPoubelleJaune++;
                    Destroy(this.gameObject);
                }
            }

            ///////////////// INVERSE ///////////////////////
            if (gameObject.tag == "objPoubelleVerte" && collision.gameObject.name == "poubelleJaune")
            {
                if (!drag)
                {
                    transform.position = posStart;
                }
            }

            if (gameObject.tag == "objPoubelleJaune" && collision.gameObject.name == "poubelleVerte")
            {
                if (!drag)
                {
                    transform.position = posStart;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            trigger = false;
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (lo.objSelected == null)
            {
                drag = true;
                lo.objSelected = gameObject;
                sr.sortingOrder = 10;
            }

        }

        public override void TouchUp()
        {
            drag = false;
            lo.objSelected = null; 
            sr.sortingOrder = 6;
        }



    }
}

