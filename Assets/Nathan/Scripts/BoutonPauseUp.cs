using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{
    public class BoutonPauseUp : TouchableObject
    {
        public GameObject menu2;
        public GameObject Bouton;

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
            menu2.GetComponent<Animator>().Play("MenuClosingVersion2");
            Bouton.GetComponent<Animator>().Play("ButtonPauseDown");
        }
    }
}

