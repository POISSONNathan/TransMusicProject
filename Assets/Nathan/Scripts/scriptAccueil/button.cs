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

            if (ac.moveCamera == false )
            {
                if((gm.lm.bestTimeLevel1 != 1000000 && gm.currentLevel==1)){
                    buttonOn.SetActive(true);
                }

                if(gm.currentLevel==0){
                    buttonOn.SetActive(true);
                }

                if((gm.lm.bestTimeLevel2 != 1000000 && gm.currentLevel==2)){
                    buttonOn.SetActive(true);
                } 
            }

            if (ac.moveCamera == true )
            {
                buttonOn.SetActive(false);
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (gm.introGame == false && gm.lm.infoOpen == false)
            {
                if (ac.moveCamera == false)
                {
                    this.GetComponent<Animator>().SetTrigger("Boing");
                    //this.GetComponent<Animator>().Play("ButtonPlayAcceuil");
                }
            }
        }
        public override void TouchUp()
        {
            if (gm.introGame == false && gm.lm.infoOpen == false)
            {
                if (ac.moveCamera == false && touchOneTime == false)
                {
                    if (gm.currentLevel == 0)
                    {
                        gm.accueilScene = false;
                        touchOneTime = true;
                        ManagerManager.GetManagerManager.lm.GoToNextScene();
                        gm.lm.currentLevelForDisque = 0;
                    }
                    if (gm.currentLevel == 1 && gm.lm.bestTimeLevel1 < 100000)
                    {
                        gm.accueilScene = false;
                        touchOneTime = true;
                        ManagerManager.GetManagerManager.lm.GoToNextScene();
                        gm.lm.currentLevelForDisque = 1;
                    }
                    if (gm.currentLevel == 2 && gm.lm.bestTimeLevel2 < 100000)
                    {
                        gm.accueilScene = false;
                        touchOneTime = true;
                        ManagerManager.GetManagerManager.lm.GoToNextScene();
                        gm.lm.currentLevelForDisque = 2;
                    }
                }
                this.GetComponent<Animator>().SetTrigger("Boing");
            }
        }

    }
}
