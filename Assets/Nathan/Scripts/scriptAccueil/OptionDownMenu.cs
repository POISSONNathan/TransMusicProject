using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class OptionDownMenu : TouchableObject
    {
        public GameObject OptionMenu;
        public optionsManager optionsManager;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Collider2D>().enabled = !optionsManager.dansOptions;
        }

        public override void OnTouch(Touch touchinfo)
        { 
            OptionMenu.GetComponent<Animator>().Play("OptionGoingDown");
            optionsManager.dansOptions = true;
        }

    }
}
