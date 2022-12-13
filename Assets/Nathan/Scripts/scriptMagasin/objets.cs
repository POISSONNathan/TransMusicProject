using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {
    public class objets : TouchableObject
    {
        public detectDrag dd;


        public Vector3 posStart;

        public bool drag = false;
        public bool dragPossible = true;
        public bool trigger = false;

        public bool stayOnObj = false;

        public demandeClient dc;

        private bool isOnShop;

        void Start()
        {
            posStart = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            
            if (drag && dragPossible)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }

            if (!drag && !trigger && !stayOnObj)
            {
                resetPos();
            }

            if (dc.changeCmd == true)
            {
                stayOnObj = false;
                dragPossible = true;
                resetPos();
            }

        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "client" )
            {
                isOnShop = true;
                
            }
            else
            {
                isOnShop = false;
            }

            for (int i = 0; i < dc.client.Count; i++)
            {
                if (dc.client[i] == this.gameObject.name)
                {
                    trigger = true;
                }
            }
        }

        private void resetPos()
        {
            transform.position = posStart;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            trigger = false;
            if (collision.gameObject.tag == "client")
            {
                isOnShop = false;
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (dc.objSelected == null)
            {
                drag = true;
                dc.objSelected = this.gameObject;
            }
        }

        public override void TouchUp()
        {
            Debug.Log(gameObject.name);
            drag = false;
            dc.objSelected = null;

            if(isOnShop == true)
            {
                for (int i = 0; i < dc.client.Count; i++)
                {
                    if (dc.client[i] == this.gameObject.name)
                    {
                        stayOnObj = true;
                        dragPossible = false;
                        dc.client.Remove(this.gameObject.name);
                        dc.goodObj ++;
                    }
                }
            }
        }
    }
}
