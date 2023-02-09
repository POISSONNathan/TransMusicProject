using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class OptionDownMenu : TouchableObject
    {
        public GameObject OptionMenu;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public override void OnTouch(Touch touchinfo)
        { 
            OptionMenu.GetComponent<Animator>().Play("OptionGoingDown");
        }

    }
}
