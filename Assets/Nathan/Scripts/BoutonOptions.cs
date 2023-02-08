using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
        public class BoutonOptions : TouchableObject
    {

        public optionsManager optionsManager;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            
                GetComponent<Collider2D>().enabled = !optionsManager.dansOptions ;
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (!optionsManager.dansOptions) {
                Debug.Log("animation du panneau qui descend");
                optionsManager.dansOptions = true;

            }
                
                
            
        }

    }
}
