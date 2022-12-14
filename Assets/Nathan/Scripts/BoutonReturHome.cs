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

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            gm = ManagerManager.GetManagerManager;
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public override void OnTouch(Touch touchinfo)
        {
            if (gm.introGame == false && lm.infoOpen == false)
            {
                lm.resetTimer();
                lm.inMiniGame = false;
                SceneManager.LoadScene("1Start", LoadSceneMode.Single);
            }
        }
    }
}
