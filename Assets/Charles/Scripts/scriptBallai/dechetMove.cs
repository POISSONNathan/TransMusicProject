using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spaceCharles
{
    public class dechetMove : MonoBehaviour
    {
        public Rigidbody2D rb;
        public float speed = 2.0f;
        void Awake() => rb = GetComponent<Rigidbody2D>();

        public GameObject testC;

        public balaiControl bc;

        // Start is called before the first frame update
        void Start()
        {
            rb.velocity = new Vector2(0.0f, -speed);

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(testC);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Balai")
            {
                rb.velocity = new Vector2(-6.0f, 0.0f);

            }

            if (collision.gameObject.tag == "trash")
                Destroy(this.gameObject);

            }

        }
    }

