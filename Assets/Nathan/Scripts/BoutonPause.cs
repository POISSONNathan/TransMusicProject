using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{
        public class BoutonPause : TouchableObject
    {
        public GameObject menu;
        public GameObject FondPause;

        public ManagerManager gm;
        // Start is called before the first frame update
        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();
            this.GetComponent<Animator>().Play("");
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public override void OnTouch(Touch touchinfo)
        {
            menu.GetComponent<Animator>().Play("MenuOpening");
            this.GetComponent<Animator>().Play("ButtonPause");
            FondPause.GetComponent<Animator>().Play("FondShadeIn");
            gm.lm.gamePause = true;
        }

    }
}

