using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class ManagerManager : MonoBehaviour
    {
        public List<string> myMiniGames1 = new List<string>();

        public int scoreScene;
        public int scoreSceneNeed;
        public string nextScene;

        void Start()

        {
            DontDestroyOnLoad(gameObject);

            myMiniGames1.Add("Essuyer");
            myMiniGames1.Add("Fils");
            myMiniGames1.Add("Lumière");
            myMiniGames1.Add("balai");
            

        }

        // Update is called once per frame
        void Update()
        {


            // POUR RECUPERER LE GAMEOBEJCT DANS LE SCIRPY
            //public ManagerManager gm;

            //gm = FindObjectOfType<ManagerManager>();
            //gm.scoreSceneNeed = 1;
        }
    }
}
