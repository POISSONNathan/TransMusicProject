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

        private int randomMiniGames;

        public int currentLevel;

        public bool accueilScene = false;

        public bool introGame = true;

        //Pas ouf mais pas d�geu quand meme
        public static ManagerManager GetManagerManager => FindObjectOfType<ManagerManager>();

        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        // Update is called once per frame
        void Update()
        {                  
            if (accueilScene == true)
            {
                myMiniGames1 = new List<string> { "Drage&Drop", "Essuyer", "Fils", "MonterCaisse" };
                myMiniGames2 = new List<string> { "TrouveMerch", "Magasin", "balai", "trouverObj" };
                myMiniGames3 = new List<string> { "Rotate", "ReactionTime", "Lumière", "Vip" };

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
                if (myMiniGames1.Count > 0 && accueilScene == false)
                {
                    tempMiniGames = myMiniGames1;
                    ShuffleList(tempMiniGames);
                    lm.startTimer1();
                }
            }
            //////
            //////
            //////
            if (currentLevel == 1 && SceneManager.GetActiveScene().name == "Accueil" )
            {
                if (myMiniGames2.Count > 0 && accueilScene == false)
                {
                    tempMiniGames = myMiniGames2;
                    ShuffleList(tempMiniGames);
                    lm.startTimer2();
                }
            }
            //////
            //////
            //////
            if (currentLevel == 2 && SceneManager.GetActiveScene().name == "Accueil")
            {
                if (myMiniGames3.Count > 0 && accueilScene == false)
                {
                    tempMiniGames = myMiniGames3;
                    ShuffleList(tempMiniGames);
                    lm.startTimer3();
                }
            }

            if (tempMiniGames.Count == 0)
            {
                lm.nextScene = "Accueil";
            }
            else
            {
                lm.nextScene = tempMiniGames[0];
                tempMiniGames.Remove(tempMiniGames[0]);
            }
        }

        public void ShuffleList(List<string> listeGames)
        {
            for (int i = 0; i < listeGames.Count; i++)
            {
                string temp = listeGames[i];
                int randomIndex = Random.Range(i, listeGames.Count);
                listeGames[i] = listeGames[randomIndex];
                listeGames[randomIndex] = temp;
            }
        }
    }
}
