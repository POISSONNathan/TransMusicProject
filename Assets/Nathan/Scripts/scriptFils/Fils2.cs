using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Fils2 : TouchableObject
    {
        public LineRenderer line;
        public Vector3 posStart;

        public bool drag = false;

        public string color;

        public GameObject lightOn;

        public detectDrag dd;

        public wireManager wm;
        void Start()
        {
            posStart = transform.position;
            dd.nextScene = "Lumière";
            dd.scoreSceneNeed = 3;
        }

        // Update is called once per frame
        void Update()
        {
            line.SetPosition(1, transform.localPosition);


            if (drag == true)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }
            if (drag == false)
            {
                transform.position = posStart;
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (wm.currentWire == null)
            {
                drag = true;
                wm.currentWire = gameObject;
            }

        }

        public override void TouchUp()
        {
            drag = false;
            wm.currentWire = null;
        }

        public void Connected()
        {
            lightOn.SetActive(true);
            dd.scoreScene++;
            Destroy(this);
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (color == "red" && collision.gameObject.name == "redWireEnd" )
            {
                Vector3 lastPos = collision.transform.position;
                lastPos.x -= 0.4f;
                transform.position = lastPos;
                line.SetPosition(1, transform.localPosition);

                Connected();
            }
            if (color == "blue" && collision.gameObject.name == "blueWireEnd")
            {
                Vector3 lastPos = collision.transform.position;
                lastPos.x -= 0.4f;
                transform.position = lastPos;
                line.SetPosition(1, transform.localPosition);

                Connected();
            }
            if (color == "green" && collision.gameObject.name == "greenWireEnd")
            {
                Vector3 lastPos = collision.transform.position;
                lastPos.x -= 0.4f;
                transform.position = lastPos;
                line.SetPosition(1, transform.localPosition);

                Connected();
            }
        }
    }
}
