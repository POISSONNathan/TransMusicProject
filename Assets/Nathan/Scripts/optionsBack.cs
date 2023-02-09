using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class optionsBack : TouchableObject
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

        public override void TouchUp()
        {
            
            OptionMenu.GetComponent<Animator>().Play("OptionGoingUp");
            optionsManager.dansOptions = false;

            
        
        }
    }
}


