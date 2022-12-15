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

        /// <summary>
        /// /////////////////
        /// </summary>
        /// 

        public bool timer1Start = false;
        private float timerLevel1 = 0;
        public float secondLevel1 = 0;
        public float bestTimeLevel1 = 100000;


        public bool timer2Start = false;
        private float timerLevel2 = 0;
        public float secondLevel2 = 0;
        public float bestTimeLevel2 = 100000;

        public bool timer3Start = false;
        private float timerLevel3 = 0;
        public float secondLevel3 = 0;
        public float bestTimeLevel3 = 100000;

        public bool inMiniGame = false;

        public ManagerManager gm;

        public void ResetComponent()
        {
            scoreScene = 0;
            //timerGame = 0;
            //seconds = 0;
            goNexwtGame = false;
        }

        void Update()
        {
            if (scoreScene == scoreSceneNeed)
            {
                GoToNextScene();
            }

            //if ((SceneManager.GetActiveScene().name) != "accueil" && (SceneManager.GetActiveScene().name) != "1start" && inMiniGame == true)
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

            if (timer1Start == true)
            {
                timerLevel1 += Time.deltaTime;
                secondLevel1 = timerLevel1 % 60;
            }
            if (timer2Start == true)
            {
                timerLevel2 += Time.deltaTime;
                secondLevel2 = timerLevel2 % 60;
            }
            if (timer3Start == true)
            {
                timerLevel3 += Time.deltaTime;
                secondLevel3 = timerLevel3 % 60;
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

            if (nextScene == "Accueil")
            {
                Debug.Log(nextScene);
                if (gm.currentLevel == 0)
                {
                    endTimer1();
                }
                if (gm.currentLevel == 1)
                {
                    endTimer2();
                }
                if (gm.currentLevel == 2)
                {
                    endTimer3();
                }
            }

            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }

        public void resetTimer()
        {
            secondLevel1 = 0;
            timerLevel1 = 0;
            secondLevel2 = 0;
            timerLevel2 = 0;
            secondLevel3 = 0;
            timerLevel3 = 0;

            timer1Start = false;
            timer2Start = false;
            timer3Start = false;
        }

        public void startTimer1()
        {
            timer1Start = true;
        }
        public void endTimer1()
        {
            if (secondLevel1 < bestTimeLevel1)
            {
                bestTimeLevel1 = secondLevel1;
            }
            resetTimer();
        }

        public void startTimer2()
        {
            timer2Start = true;
        }
        public void endTimer2()
        {
            if (secondLevel2 < bestTimeLevel2)
            {
                bestTimeLevel2 = secondLevel2;
            }
            resetTimer();
        }

        public void startTimer3()
        {
            timer3Start = true;
        }
        public void endTimer3()
        {
            if (secondLevel3 < bestTimeLevel3)
            {
                bestTimeLevel3 = secondLevel3;
            }
            resetTimer();
        }
    } 
}
