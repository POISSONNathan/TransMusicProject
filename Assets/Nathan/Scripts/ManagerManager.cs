using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class ManagerManager : MonoBehaviour
    {
        public List<string> myMiniGames1 = new List<string>();

        public detectDrag dd;

        public int randomMiniGames;

        void Awake()

        {
            DontDestroyOnLoad(gameObject);

            myMiniGames1.Add("Drage&Drop");
            myMiniGames1.Add("Fils");
            myMiniGames1.Add("balai");

            dd = FindObjectOfType<detectDrag>().GetComponent<detectDrag>();
            dd.switchMiniGame = true;
        }

        // Update is called once per frame
        void Update()
        {
            dd = FindObjectOfType<detectDrag>().GetComponent<detectDrag>();

            if (dd.switchMiniGame == true)
            {
                changeMiniGame();
                dd.switchMiniGame = false;
            }   

            if (myMiniGames1.Count > 0)
            {
                dd.nextScene = myMiniGames1[randomMiniGames];
            }
            if (myMiniGames1.Count == 0)
            {
                dd.nextScene = "Accueil";
            }


            // POUR RECUPERER LE GAMEOBEJCT DANS LE SCIRPY
            //public ManagerManager gm;

            //gm = FindObjectOfType<ManagerManager>();
            //gm.scoreSceneNeed = 1;
        }

        void changeMiniGame()
        {
            if (myMiniGames1.Count > 0)
            {
                randomMiniGames = Random.Range(0, myMiniGames1.Count);
                myMiniGames1.Remove(myMiniGames1[randomMiniGames]);
            }
        }
    }
}
