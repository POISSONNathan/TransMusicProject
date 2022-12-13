using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {
    public class objets : TouchableObject
    {
        public detectDrag dd;

        public Vector3 posStart;

        public bool drag = false;
        public bool trigger = false;

        void Start()
        {
            posStart = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (drag)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }

            if (!drag)
            {
                transform.position = posStart;
            }
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
