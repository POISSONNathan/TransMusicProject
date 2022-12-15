using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class ticketDrag : TouchableObject
    {
        public bool drag;
        public vipScript vs;
        public Vector3 posStart;
        // Start is called before the first frame update
        void Start()
        {
            posStart = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (drag && !vs.pause)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }
            if (!drag)
            {
                transform.position = posStart;
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
            transform.position = posStart;
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (!drag && collision.GetComponent<guestScript>().vip == true && !vs.vipSelected.Contains(collision.GetComponent<guestScript>().type))
            {
                vs.vipSelected.Add(collision.GetComponent<guestScript>().type);
                Destroy(gameObject);
            }
        }
    }
}
