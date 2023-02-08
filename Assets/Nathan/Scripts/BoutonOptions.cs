using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
        public class BoutonOptions : TouchableObject
    {
        public GameObject OptionMenu;
        public optionsManager optionsManager;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnTouch(Touch touchinfo)
        {
            if (!optionsManager.dansOptions) {
                OptionMenu.GetComponent<Animator>().Play("OptionGoingDown");
                optionsManager.dansOptions = true;

            }
                
                
            
        }

    }
}
