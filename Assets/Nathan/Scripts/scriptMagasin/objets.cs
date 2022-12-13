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

            //if (dc.goodObj == dc.client.Count)
            //{
            //    dc.goodObj = 0;
            //    dc.changeCmd = true;
            //    stayOnObj = false;
            //}

        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (!drag && collision.gameObject.tag == "client" )
            {
                for (int i = 0; i < dc.client.Count; i++)
                {
                    if (dc.client[i] == this.gameObject.name)
                    {
                        stayOnObj = true;
                        dragPossible = false;
                    }
                }
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
            drag = false;
            dc.objSelected = null;
        }
    }
}
