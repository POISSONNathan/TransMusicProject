using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan 
{
    public class BoutonReturHome : TouchableObject
    {
        private LevelManager lm;

        public ManagerManager gm;
        public optionsManager optionsManager;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            gm = ManagerManager.GetManagerManager;
        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Collider2D>().enabled = !optionsManager.dansOptions;
        }
        public override void TouchUp()
        {
            if (gm.introGame == false && lm.infoOpen == false && lm.isScrolling == false)
            {
                gm.lm.resetGameEnd();

                lm.resetTimer();
                lm.inMiniGame = false;
                lm.switchOneTime = false;
                lm.gamePause = false;
                SceneManager.LoadScene("1Start", LoadSceneMode.Single);
            }
        }
    }
}
