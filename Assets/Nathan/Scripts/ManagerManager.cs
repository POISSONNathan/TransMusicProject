using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class ManagerManager : MonoBehaviour
    {
        public List<string> myMiniGames = new List<string>();

        public int scoreScene;
        public int scoreSceneNeed;
        public string nextScene;

        void Start()

        {
            DontDestroyOnLoad(gameObject);

            myMiniGames.Add("Essuyer");
            myMiniGames.Add("Fils");

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(myMiniGames[1]);

            if (scoreScene == scoreSceneNeed)
            {
                SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
            }

            // POUR RECUPERER LE GAMEOBEJCT DANS LE SCIRPY
            //public ManagerManager gm;

            //gm = FindObjectOfType<ManagerManager>();
            //gm.scoreSceneNeed = 1;
        }
    }
}
