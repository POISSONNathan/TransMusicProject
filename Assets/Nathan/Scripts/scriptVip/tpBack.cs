using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {
    public class tpBack : MonoBehaviour

    {
        public vipScript vs;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

    

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (vs.vipSelected.Contains(collision.GetComponent<guestScript>().type))
            {
                Destroy(collision.gameObject);
            }

            collision.gameObject.GetComponent<Transform>().transform.position = new Vector2(26, collision.gameObject.GetComponent<Transform>().transform.position.y);
        }
    }
}
