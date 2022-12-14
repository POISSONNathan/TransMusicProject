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

        public List<string> tempMiniGames = new List<string>();

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
            
        }

        // Update is called once per frame
        void Update()
        {                  
            if (accueilScene == true)
            {
                myMiniGames1 = new List<string> { "Drage&Drop", "Essuyer", "Fils", "MonterCaisse" };
                myMiniGames2 = new List<string> { "TrouveMerch", "Magasin", "balai" };
                myMiniGames3 = new List<string> { "Rotate", "ReactionTime", "Lumière" };

                tempMiniGames.Clear();

                currentLevel = ac.levelSelect;
            }

            if (lm.switchMiniGame == true)
            {
                changeMiniGame();
                lm.switchMiniGame = false;
            }
        }

        void changeMiniGame()
        {
            if (currentLevel == 0 && SceneManager.GetActiveScene().name == "Accueil" )
            {
                if (myMiniGames1.Count > 0)
                {
                    tempMiniGames = myMiniGames1;
                }
            }
            //////
            //////
            //////
            if (currentLevel == 1 && SceneManager.GetActiveScene().name == "Accueil" )
            {
                if (myMiniGames2.Count > 0)
                {
                    tempMiniGames = myMiniGames2;
                }
            }
            //////
            //////
            //////
            if (currentLevel == 2 && SceneManager.GetActiveScene().name == "Accueil")
            {
                if (myMiniGames3.Count > 0)
                {
                    tempMiniGames = myMiniGames3;
                }
            }

            if (tempMiniGames.Count == 0)
            {
                lm.nextScene = "Accueil";
            }

            randomMiniGames = Random.Range(0, tempMiniGames.Count);
            lm.nextScene = tempMiniGames[randomMiniGames];
            tempMiniGames.Remove(tempMiniGames[randomMiniGames]);
        }
    }
}
