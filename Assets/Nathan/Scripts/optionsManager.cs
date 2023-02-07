using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
        public class optionsManager : MonoBehaviour
    {

        public SpriteRenderer sr;
        public bool dansOptions = false;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            sr.enabled = dansOptions;
        }
    }
}
