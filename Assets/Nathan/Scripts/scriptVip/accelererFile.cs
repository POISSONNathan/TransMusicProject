using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class accelererFile : TouchableObject
    {
        public vipScript vs;

        public Vector2 posStart;

        public bool drag;

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
        }

        public override void OnTouch(Touch touchInfo)
        {
            if (!vs.pause)
            {
                drag = true;
                vs.accelererFile = true;
            }
        }
        public override void TouchUp()
        {
            if (!vs.pause)
            {
                drag = false;
                vs.accelererFile = false;
                transform.position = posStart;
            }
        }
    }
}
