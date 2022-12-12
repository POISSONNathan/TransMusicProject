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

        public detectDrag dd;

        public ManagerManager gm;

        public int randomMiniGames;

        void Start()
        {
            dd.scoreSceneNeed = 1;
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();

            randomMiniGames = Random.Range(0,4);
        }

        // Update is called once per frame
        void Update()
        {
            dd.nextScene = gm.myMiniGames1[randomMiniGames];


            if (ac.moveCamera == false)
            {
                sr.color = Color.green;
            }

            if (ac.moveCamera == true)
            {
                sr.color = Color.grey;
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (ac.levelSelect == 0 && ac.moveCamera == false)
            {
                dd.gameFinish = true;
            }
        }
    }
}
