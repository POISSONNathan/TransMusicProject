using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{
    public class BoutonPauseResume : TouchableObject
    {
        public GameObject menu2;
        public GameObject Bouton;
        public GameObject FondPause2;

        public ManagerManager gm;
        // Start is called before the first frame update
        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnTouch(Touch touchinfo)
        {
            menu2.GetComponent<Animator>().Play("MenuClosingVersion2");
            Bouton.GetComponent<Animator>().Play("ButtonPauseDown");
            FondPause2.GetComponent<Animator>().Play("FondShadeOut");
            gm.lm.gamePause = false;
        }
    }
}

