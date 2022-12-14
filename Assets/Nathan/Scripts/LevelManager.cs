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


        private float currentTimer = 0;
        public float currentSecond = 0;

        public bool startTimerMiniGame1 = false;

        public float lastTimerMiniGame1;
        public float bestTimerMiniGame1;


        public int secondMiniGame;

        public void ResetComponent()
        {
            scoreScene = 0;
            timerGame = 0;
            seconds = 0;
            goNexwtGame = false;
        }

        void Update()
        {
            if (scoreScene == scoreSceneNeed)
            {
                GoToNextScene();
            }

            if ((SceneManager.GetActiveScene().name) != "Accueil" && (SceneManager.GetActiveScene().name) != "1Start" )
            {
                timerGame += Time.deltaTime;
                seconds = timerGame % 60;

                if (seconds == secondMiniGame)
                {
                    GoToNextScene();
                }
            }

            if (startTimerMiniGame1 == true)
            {
                currentTimer += Time.deltaTime;
                currentTimer = currentTimer % 60;
                lastTimerMiniGame1 = currentSecond;
            }
            if (startTimerMiniGame1 == false)
            {
                if (lastTimerMiniGame1 > bestTimerMiniGame1)
                {
                    bestTimerMiniGame1 = lastTimerMiniGame1;
                }
            }

            if (startTimerMiniGame1 == true)
            {
                currentTimer = 0;
                currentSecond = 0;
            }



            if (oldLevel != SceneManager.GetActiveScene().name)
            {
                oldLevel = SceneManager.GetActiveScene().name;
                ResetComponent();
            }
        }

        public void GoToNextScene()
        {
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
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    } 
}
