using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class button : TouchableObject
    {
        public accueil ac;

        public SpriteRenderer sr;
        public ManagerManager gm;

        public int randomMiniGames;

        public GameObject buttonOn;

        public bool touchOneTime = false;

        void Start()
        {
            gm = ManagerManager.GetManagerManager;
            gm.lm.scoreSceneNeed = 1;
        }

        // Update is called once per frame
        void Update() 
        {


            if (ac.moveCamera == false)
            {
                buttonOn.SetActive(true);
            }

            if (ac.moveCamera == true)
            {
                buttonOn.SetActive(false);
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (ac.moveCamera == false && touchOneTime == false)
            {
                touchOneTime = true;
            }
        }
        public override void TouchUp()
        {
            if (ac.moveCamera == false)
            {
                if (gm.currentLevel == 0)
                {
                    gm.accueilScene = false;
                    ManagerManager.GetManagerManager.lm.GoToNextScene();
                }
                if (gm.currentLevel == 1 && gm.lm.bestTimeLevel1 < 100000)
                {
                    gm.accueilScene = false;
                    ManagerManager.GetManagerManager.lm.GoToNextScene();
                }
                if (gm.currentLevel == 2 && gm.lm.bestTimeLevel2 < 100000)
                {
                    gm.accueilScene = false;
                    ManagerManager.GetManagerManager.lm.GoToNextScene();
                }
            }
        }
    }
}
