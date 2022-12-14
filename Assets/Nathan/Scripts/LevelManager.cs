using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class LevelManager : MonoBehaviour
    {

        //public animator startcurtain, endcurtain;
        public int scoreScene;
        public int scoreSceneNeed;
        public bool goNexwtGame = false;

        public string nextScene;
        public bool switchMiniGame = false;
        public bool switchOneTime = false;

        public ParticleSystem WinParticule;
        public Animator animator;

        private string oldLevel;

        public bool playAnimOneTime = false;

        private float timerGame = 0;
        public float seconds = 0;

        public int secondMiniGame;

        public bool inMiniGame = false;
        public void ResetComponent()
        {
            scoreScene = 0;
            //timerGame = 0;
            //seconds = 0;
            goNexwtGame = false;
        }

        void Update()
        {
            if (scoreScene == scoreSceneNeed    )
            {
                GoToNextScene();
            }

            //if ((SceneManager.GetActiveScene().name) != "Accueil" && (SceneManager.GetActiveScene().name) != "1Start" && inMiniGame == true)
            //{
            //    timerGame += Time.deltaTime;
            //    seconds = timerGame % 60;

            //    if (seconds >= secondMiniGame)
            //    {
            //        GoToNextScene();
            //    }
            //}

            if (oldLevel != SceneManager.GetActiveScene().name)
            {
                oldLevel = SceneManager.GetActiveScene().name;
                ResetComponent();
            }
        }

        public void GoToNextScene()
        {
            inMiniGame = false;
            if ((SceneManager.GetActiveScene().name) != "Accueil" && (SceneManager.GetActiveScene().name) != "1Start" && playAnimOneTime == false)
            {
                Instantiate(WinParticule, transform.position, Quaternion.identity);
                playAnimOneTime = true;
            }

            if (switchOneTime == false)
            {
                switchMiniGame = true;
                switchOneTime = true;
                animator.SetTrigger("End");
            }

        }

        private void LaunchEndOfScene()
        {
            switchOneTime = false;
            playAnimOneTime = false;
            inMiniGame = true;
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    } 
}
