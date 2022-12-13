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
        }

        void changeMiniGame()
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
    }
}
