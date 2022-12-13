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
            if (ac.moveCamera == false)
            {
                gm.accueilScene = false;
                ManagerManager.GetManagerManager.lm.GoToNextScene();
            }
        }
    }
}
