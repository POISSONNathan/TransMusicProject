using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {
    public class tpBack : MonoBehaviour
    {
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
            collision.gameObject.GetComponent<Transform>().transform.position = new Vector2(28, collision.gameObject.GetComponent<Transform>().transform.position.y);

        }
    }
}
