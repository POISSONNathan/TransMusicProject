using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Corde : MonoBehaviour
    {
        public rotationObj ro;
        public Vector2 posStart;
        void Start()
        {
             posStart = transform.position;
        } 

        void Update()
        {
            transform.position = new Vector2(posStart.x, posStart.y + ro.getRotation/60  ); 

            Debug.Log(ro.getRotation);
        }
    }
}