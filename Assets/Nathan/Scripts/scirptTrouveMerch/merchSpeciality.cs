using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{

    public class merchSpeciality : TouchableObject
    {
        public string color;
        public string forme;
        public string nombreForme;

        public merchDemande md;

        public detectDrag dd;

        public bool dragPossible = false;
        public bool drag = false;
        public bool trigger = false;

        public Vector3 posStart;


        void Start()
        {
            posStart = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (md.colorSelected == color && md.formeSelected == forme && md.nombreFormeSelected == nombreForme && dragPossible == false)
            {
                dragPossible = true;
            }
            else
            {
                dragPossible = false;
            }

            if (drag)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }

            if (!drag && trigger == false)
            {
                transform.position = posStart;
            }
        }

        public override void OnTouch(Touch touchinfo)
        {

            if (dragPossible == true)
            {
                drag = true;
            }
        }

        public override void TouchUp()
        {
            if (dragPossible == true)
            {
                drag = false;
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            trigger = true;
            if (!drag && collision.gameObject.tag == "client")
            {
                Debug.Log("fer");
                md.goodObj = true;
                dragPossible = false;
                dd.scoreScene++;
                transform.position = posStart;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            trigger = false;

        }
    }
}
