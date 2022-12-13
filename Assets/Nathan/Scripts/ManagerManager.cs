using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class ManagerManager : MonoBehaviour
    {
        public List<string> myMiniGames1 = new List<string>();

        public List<string> myMiniGames2 = new List<string>();

        public List<string> myMiniGames3 = new List<string>();

        public detectDrag dd;
        public LevelManager lm;

        public accueil ac;

        public int randomMiniGames;

        public int currentLevel;

        public bool accueilScene = false;

        //Pas ouf mais pas d�geu quand meme
        public static ManagerManager GetManagerManager => FindObjectOfType<ManagerManager>();

        void Awake()

        {
            DontDestroyOnLoad(gameObject);

            dd = FindObjectOfType<detectDrag>().GetComponent<detectDrag>();

            ac = FindObjectOfType<accueil>().GetComponent<accueil>();
            
        }

        // Update is called once per frame
        void Update()
        {
            if (accueilScene == true)
            {
                currentLevel = ac.levelSelect;
            }

            dd = FindObjectOfType<detectDrag>().GetComponent<detectDrag>();

            if (lm.switchMiniGame == true)
            {
                changeMiniGame();
                lm.switchMiniGame = false;
            }
        }

        void changeMiniGame()
        {
            if (currentLevel == 0)
            {
                if (myMiniGames1.Count == 0)
                {
                    lm.nextScene = "Accueil";
                }

                if (myMiniGames1.Count > 0)
                {
                    randomMiniGames = Random.Range(0, myMiniGames1.Count);
                    lm.nextScene = myMiniGames1[randomMiniGames];
                    myMiniGames1.Remove(myMiniGames1[randomMiniGames]);
                }
            }
            //////
            if (currentLevel == 1)
            {
                if (myMiniGames2.Count == 0)
                {
                    lm.nextScene = "Accueil";
                }

                if (myMiniGames2.Count > 0)
                {
                    randomMiniGames = Random.Range(0, myMiniGames2.Count);
                    lm.nextScene = myMiniGames2[randomMiniGames];
                    myMiniGames2.Remove(myMiniGames2[randomMiniGames]);
                }
            }
            //////
            if (currentLevel == 2)
            {
                if (myMiniGames3.Count == 0)
                {
                    lm.nextScene = "Accueil";
                }
                
                if (myMiniGames3.Count > 0)
                {
                    randomMiniGames = Random.Range(0, myMiniGames3.Count);
                    lm.nextScene = myMiniGames3[randomMiniGames];
                    myMiniGames3.Remove(myMiniGames3[randomMiniGames]);
                }
            }
            //////
        }
    }
}
