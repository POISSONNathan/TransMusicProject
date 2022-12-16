using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class ticketDrag : TouchableObject
    {
        public bool drag;
        public vipScript vs;
        
        public Vector3 targetPosition;
        public Vector3 posStart;

        public bool shouldGoToTarget = false;
        
        public float delta;
        public float speed;

        // Start is called before the first frame update
        void Start()
        {
            posStart = transform.position;

        }

        // Update is called once per frame
        void Update()
        {
            if (drag && !vs.pause && !shouldGoToTarget)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }
            if (!vs.drag)
            {
                resetPos();
            }

            if (shouldGoToTarget)
            {
                delta += Time.deltaTime * speed;
                transform.position = Vector2.Lerp(posStart, targetPosition, delta);
            }
            if (delta >= 1)
            {
                shouldGoToTarget = false;
                delta = 0;
                posStart = transform.position;
                
            }
        }
        public override void OnTouch(Touch touchInfo)
        {
            if (!drag && !vs.drag)
            {

                drag = true;
                vs.drag = true;
            }
        }
        public override void TouchUp()
        {
            vs.drag = false;
            drag = false;
        }
        private void resetPos()
        {
            if (!shouldGoToTarget)
            {

                targetPosition = posStart;
                posStart = transform.position;
                delta = 0;
                shouldGoToTarget = true;
            }
            //transform.position = posStart;
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.tag == "client")
            {
                if (!drag && collision.GetComponent<guestScript>().vip && !vs.vipSelected.Contains(collision.GetComponent<guestScript>().type))
                {
                    vs.vipSelected.Add(collision.GetComponent<guestScript>().type);
                    shouldGoToTarget = false;
                    delta = 0;
                    posStart = transform.position;

                    vs.drag = false;
                    Destroy(gameObject);
                    Debug.Log("trouvé");
                
                }

            }
            //Debug.Log(collision.GetComponent<guestScript>().vip);
        }
    }
}
