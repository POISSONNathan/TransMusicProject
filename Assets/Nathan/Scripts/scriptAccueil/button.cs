using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class button : TouchableObject
    {
        public bool startGame;

        public accueil ac;

        public SpriteRenderer sr;

        public detectDrag dd;

        void Start()
        {
            dd.scoreSceneNeed = 1;
        }

        // Update is called once per frame
        void Update()
        {
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
                dd.nextScene = "Drage&Drop";
                dd.gameFinish = true;
                Debug.Log("eez");
            }
        }
    }
}
