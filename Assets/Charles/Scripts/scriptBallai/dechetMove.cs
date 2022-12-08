using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spaceCharles
{
    public class dechetMove : MonoBehaviour
    {
        private Rigidbody2D rb;
        public float speed = 2.0f;
        void Awake()
        {
            rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
        // Start is called before the first frame update
        void Start()
        {
            rb.velocity = new Vector2(0.0f, -speed);

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Balai")
            {
                rb.velocity = new Vector2(-6.0f, 0.0f);

            }
            Debug.Log("z");

        }
    }
}
