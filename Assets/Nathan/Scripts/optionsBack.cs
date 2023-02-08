using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class optionsBack : TouchableObject
    {
        public optionsManager optionsManager;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public override void TouchUp()
        {
            if (optionsManager.dansOptions)
            {
                Debug.Log("animation du panneaux qui remonte");
                optionsManager.dansOptions = false;

            }
        
        }
    }
}


