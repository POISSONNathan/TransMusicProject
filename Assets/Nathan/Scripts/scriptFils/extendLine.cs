using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class extendLine : MonoBehaviour
    {
        public Fils2 f2;
        public LineRenderer line;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (f2.drag == true)
            {
                line.SetPosition(2, transform.localPosition);
            }
        }
    }
}
