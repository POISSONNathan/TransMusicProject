using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Essuyer : MonoBehaviour
    {

        public bool drag;

        public Vector3 posStart;

        public bool trigger;

        public float pourcent;

        public Rigidbody2D rb;

        public void Start()
        {
            posStart = transform.position;
        }

        private void Update()
        {
            if (drag)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }

     
        }

    }
}


