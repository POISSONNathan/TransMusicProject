using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class dechetMove : MonoBehaviour
    {
        public Rigidbody2D rb;
        public float speed = 4.0f;
        void Awake() => rb = GetComponent<Rigidbody2D>();

        public GameObject testC;

        public balaiControl bc;

        public GameObject tertfe;

        // Start is called before the first frame update
        void Start()
        {
            rb.velocity = new Vector2(0.0f, -speed);

            tertfe = GameObject.Find("spawner");
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Balai")
            {
                rb.velocity = new Vector2(-6.0f, 0.0f);

            }

            if (collision.gameObject.tag == "trash")
            {
                tertfe.GetComponent<SpawnerBehavior>().createdObjects.Remove(gameObject);
                Destroy(this.gameObject);
                tertfe.GetComponent<SpawnerBehavior>().CheckForRespawn();
            }

            if (collision.gameObject.tag == "collider")
            {

                tertfe.GetComponent<SpawnerBehavior>().createdObjects.Remove(gameObject);
                tertfe.GetComponent<SpawnerBehavior>().CheckForRespawn();
                rb.velocity = new Vector2(0.0f, -speed);
                Destroy(this.gameObject);
            }

        }

      

    }

}
    

