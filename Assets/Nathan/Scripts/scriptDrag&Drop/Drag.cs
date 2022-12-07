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

        public GameObject currentObj;

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
            if (drag && this.gameObject == currentObj)
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

            Debug.Log(currentObj);

        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (gameObject.tag == "objPoubelleVerte" && collision.gameObject.name == "poubelleVerte")
            {
                if (!drag)
                {
                    transform.position = collision.transform.position;
                    dd.scoreScene++;
                    lo.objPoubelleVerte++;
                    Destroy(this.gameObject);
                }
            }

            if (gameObject.tag == "objPoubelleJaune" && collision.gameObject.name == "poubelleJaune")
            {
                if (!drag)
                {
                    transform.position = collision.transform.position;
                    dd.scoreScene++;
                    lo.objPoubelleJaune++;
                    Destroy(this.gameObject);
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
            currentObj = this.gameObject;

        }

        public override void TouchUp()
        {
            drag = false;
        }

    }
}

