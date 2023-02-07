using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Nathan
{
    public class cliquerDisque : TouchableObject
    {
        private LevelManager lm;
        public ManagerManager gm;

        public bool isOpen = false;
        public bool touchOneTime = false;

        public GameObject backGround;
        public GameObject text;

        void Start()
        {
            gm = ManagerManager.GetManagerManager;
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0 && isOpen == true && touchOneTime == false)
            {
                backGround.SetActive(false);
                text.SetActive(false);
                isOpen = false;
                touchOneTime = true;
                lm.oneInfoSelected = false;
                lm.infoOpen = false;
            }

            if (Input.touchCount == 0)
            {
                touchOneTime = false;
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (isOpen == false && touchOneTime == false && gm.introGame == false && lm.oneInfoSelected == false)
            {
                backGround.SetActive(true);
                text.SetActive(true);
                isOpen = true;
                lm.infoOpen = true;
                touchOneTime = true;
                lm.oneInfoSelected = true;
            }
        }

        public override void TouchUp()
        {
            touchOneTime = false;
        }
    }
}
