using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class respawnTop : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            collision.transform.position = new Vector3(0, 5, 0);
        }
    }
}
