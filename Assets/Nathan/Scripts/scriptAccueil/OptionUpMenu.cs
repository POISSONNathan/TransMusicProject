using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class OptionUpMenu : TouchableObject
    {
        public GameObject OptionMenu;
        public optionsManager optionsManager;

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
