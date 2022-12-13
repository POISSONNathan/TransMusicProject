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

        public accueil ac;

        public int randomMiniGames;

        public int currentLevel;

        void Awake()

        {
            DontDestroyOnLoad(gameObject);

            dd = FindObjectOfType<detectDrag>().GetComponent<detectDrag>();

            ac = FindObjectOfType<accueil>().GetComponent<accueil>();
        }

        // Update is called once per frame
        void Update()
        {
            currentLevel = ac.levelSelect;

            Debug.Log(ac.levelSelect);

            dd = FindObjectOfType<detectDrag>().GetComponent<detectDrag>();

            if (dd.switchMiniGame == true)
            {
                changeMiniGame();
                dd.switchMiniGame = false;
            }
        }

        void changeMiniGame()
        {
            if (currentLevel == 0)
            {
                if (myMiniGames1.Count == 0)
                {
                    dd.nextScene = "Accueil";
                }

                if (myMiniGames1.Count > 0)
                {
                    randomMiniGames = Random.Range(0, myMiniGames1.Count);
                    dd.nextScene = myMiniGames1[randomMiniGames];
                    myMiniGames1.Remove(myMiniGames1[randomMiniGames]);
                }
            }
            //////
            if (currentLevel == 1)
            {
                if (myMiniGames2.Count == 0)
                {
                    dd.nextScene = "Accueil";
                }

                if (myMiniGames2.Count > 0)
                {
                    randomMiniGames = Random.Range(0, myMiniGames2.Count);
                    dd.nextScene = myMiniGames2[randomMiniGames];
                    myMiniGames2.Remove(myMiniGames2[randomMiniGames]);
                }
            }
            //////
            if (currentLevel == 2)
            {
                if (myMiniGames3.Count == 0)
                {
                    dd.nextScene = "Accueil";
                }
                
                if (myMiniGames3.Count > 0)
                {
                    randomMiniGames = Random.Range(0, myMiniGames3.Count);
                    dd.nextScene = myMiniGames3[randomMiniGames];
                    myMiniGames3.Remove(myMiniGames3[randomMiniGames]);
                }
            }
            //////
        }
    }
}
