using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Nathan
{
    public class LevelManager : MonoBehaviour
    {
        
        //public animator startcurtain, endcurtain;
        public int scoreScene;
        public int scoreSceneNeed;
        public bool goNexwtGame = false;
        public timeBar TB;
        public string nextScene;
        public bool switchMiniGame = false;
        public bool switchOneTime = false;

        public ParticleSystem WinParticule;
        public Animator animator;
        
        public GameObject ArgentDisque;
        public GameObject OrDisque;  

        public SummaryEndLevel se;  

        private string oldLevel;

        public bool playAnimOneTime = false;

        //private float timerGame = 0;
        //public float seconds = 0;
        public int secondMiniGame;

        //////////////////

        private bool timer1Start = false;
        public float secondLevel1 = 0;
        //////
        public float maxTimeLevel1;
        //////
        public float twoStarTimeLevel1;
        public float threeStarTimeLevel1;
        //////
        public float bestTimeLevel1 = 1000000;

        //////////////////

        private bool timer2Start = false;
        public float secondLevel2 = 0;
        //////
        public float maxTimeLevel2;
        //////
        public float twoStarTimeLevel2;
        public float threeStarTimeLevel2;
        //////
        public float bestTimeLevel2 = 1000000;

        //////////////////

        private bool timer3Start = false;
        public float secondLevel3 = 0;
        //////
        public float maxTimeLevel3;
        //////
        public float twoStarTimeLevel3;
        public float threeStarTimeLevel3;
        //////
        public float bestTimeLevel3 = 1000000;

        //////////////////

        public bool inMiniGame = false;

        public ManagerManager gm;

        public bool skipThisMiniGame = false;
        public bool skipMiniGames = false;
        public bool allMinigames3Disques = false;

        public bool miniGame1End = false;
        public bool miniGame2End = false;
        public bool miniGame3End = false;

        public bool oneInfoSelected = false;
        public bool infoOpen = false;

        public bool gamePause = false;

        public bool doOnceEndTimer = false;

        public bool isScrolling = false;

        public void ResetComponent()
        {
            scoreScene = 0;
            //timerGame = 0;
            //seconds = 0;
            goNexwtGame = false;
        }

        public void resetGameEnd()
        {
            gm.dragGameGood = false;
            gm.essuyerGameGood = false;
            gm.filsGameGood = false;
            gm.monterCaisseGameGood = false;

            gm.trouverMerchGameGood = false;
            gm.magasinGameGood = false;
            gm.balaiGameGood = false;
            gm.trouverObjGameGood = false;

            gm.rotateGameGood = false;
            gm.reactionTimeGameGood = false;
            gm.lumiereGameGood = false;
            gm.vipGameGood = false;

            se.order = 0;
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

            if (timer1Start == true && gamePause == false)
            {
                secondLevel1 += Time.deltaTime;

                if (secondLevel1 > maxTimeLevel1)
                {
                    gm.backgroundSummary.SetActive(true);
                    resetTimer();
                    inMiniGame = false;
                    miniGame1End = true;
                    SceneManager.LoadScene("Accueil", LoadSceneMode.Single);
                    se.CreateText();
                }

                if(secondLevel1 >= twoStarTimeLevel1){
                    ArgentDisque.GetComponent<Image>().color = new Color (0.35f,0.35f,0.35f);
                }

                if(secondLevel1 >= threeStarTimeLevel1){
                    OrDisque.GetComponent<Image>().color = new Color (0.35f,0.35f,0.35f);
                }
            }
            if (timer2Start == true && gamePause == false)
            {
                secondLevel2 += Time.deltaTime;
                if (secondLevel2 > maxTimeLevel2)
                {
                    gm.backgroundSummary.SetActive(true);
                    resetTimer();
                    miniGame2End = true;
                    se.CreateText();
                    inMiniGame = false;
                    SceneManager.LoadScene("Accueil", LoadSceneMode.Single);
                }

                if(secondLevel2 >= twoStarTimeLevel2){
                    ArgentDisque.GetComponent<Image>().color = new Color (0.35f,0.35f,0.35f);
                }

                if(secondLevel2 >= threeStarTimeLevel2){
                    OrDisque.GetComponent<Image>().color = new Color (0.35f,0.35f,0.35f);
                }
            }
            if (timer3Start == true && gamePause == false)
            {
                secondLevel3 += Time.deltaTime;
                if (secondLevel3 > maxTimeLevel3)
                {
                    gm.backgroundSummary.SetActive(true);
                    miniGame3End = true;
                    se.CreateText();
                    resetTimer();
                    inMiniGame = false;
                    SceneManager.LoadScene("Accueil", LoadSceneMode.Single);
                }

                if(secondLevel3 >= twoStarTimeLevel3){
                    ArgentDisque.GetComponent<Image>().color = new Color (0.35f,0.35f,0.35f);
                }

                if(secondLevel3 >= threeStarTimeLevel3){
                    OrDisque.GetComponent<Image>().color = new Color (0.35f,0.35f,0.35f);
                }
            }

            if (skipThisMiniGame == true)
            {
                GoToNextScene();
            }
            if (skipMiniGames == true)
            {
                nextScene = "Accueil";
            }
            if (allMinigames3Disques == true)
            {
                bestTimeLevel1 = 1;
                bestTimeLevel2 = 1;
                bestTimeLevel3 = 1;
                gm.ac.fullDisqueLvl1 = true;
                gm.ac.fullDisqueLvl2 = true;
                gm.ac.fullDisqueLvl3 = true;
            }
        }

        public void GoToNextScene()
        {
            ResetComponent();
            inMiniGame = false;
            if ((SceneManager.GetActiveScene().name) != "Accueil" && (SceneManager.GetActiveScene().name) != "1Start" && (SceneManager.GetActiveScene().name) != "CreditScene" && playAnimOneTime == false)
            {
                Instantiate(WinParticule, transform.position, Quaternion.identity);
                playAnimOneTime = true;
            }
            if ((SceneManager.GetActiveScene().name) == "Accueil")
            {
                resetTimer();
            }
            

            if (switchOneTime == false)
            {
                switchMiniGame = true;
                switchOneTime = true;
                animator.SetTrigger("End");
            }
        }

        public void placeImageGame1(int currentGame,int order)
        {
            se.miniGames1[currentGame].transform.position = se.spawn[order].transform.position;
            se.orderText.Add(se.miniGames1[currentGame]);
        }
        public void placeImageGame2(int currentGame, int order)
        {
            se.miniGames2[currentGame].transform.position = se.spawn[order].transform.position;
            se.orderText.Add(se.miniGames2[currentGame]);
        }
        public void placeImageGame3(int currentGame, int order)
        {
            se.miniGames3[currentGame].transform.position = se.spawn[order].transform.position;
            se.orderText.Add(se.miniGames3[currentGame]);
        }

        private void LaunchEndOfScene()
        {
            doOnceEndTimer = false;
            switchOneTime = false;
            playAnimOneTime = false;
            inMiniGame = true;


            if ((SceneManager.GetActiveScene().name) == "Drage&Drop")
            {gm.dragGameGood = true;
                placeImageGame1(0,se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "Essuyer")
            { gm.essuyerGameGood = true;
                placeImageGame1(1, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "Fils")
            { gm.filsGameGood = true;
                placeImageGame1(2, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "MonterCaisse")
            { gm.monterCaisseGameGood = true;
                placeImageGame1(3, se.order);
            }

            if ((SceneManager.GetActiveScene().name) == "TrouveMerch")
            { gm.trouverMerchGameGood = true;
                placeImageGame2(0, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "Magasin")
            { gm.magasinGameGood = true;
                placeImageGame2(1, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "balai")
            { gm.balaiGameGood = true;
                placeImageGame2(2, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "trouverObj")
            { gm.trouverObjGameGood = true;
                placeImageGame2(3, se.order);
            }

            if ((SceneManager.GetActiveScene().name) == "Rotate")
            { gm.rotateGameGood = true;
                placeImageGame3(0, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "ReactionTime")
            { gm.reactionTimeGameGood = true;
                placeImageGame3(1, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "Lumière")
            { gm.lumiereGameGood = true;
                placeImageGame3(2, se.order);
            }
            if ((SceneManager.GetActiveScene().name) == "Vip")
            { gm.vipGameGood = true;
                placeImageGame3(3, se.order);
            }

            skipMiniGames = false;
            
            if ((SceneManager.GetActiveScene().name) != "Accueil" && nextScene == "Accueil")
            {
                inMiniGame = false;

                gm.backgroundSummary.SetActive(true);

                if (gm.currentLevel == 0)
                {
                    miniGame1End = true;
                }
                if (gm.currentLevel == 1)
                {
                    miniGame2End = true;
                }
                if (gm.currentLevel == 2)
                {
                    miniGame3End = true;
                }

                se.CreateText();
            }

            if ((SceneManager.GetActiveScene().name) != "Accueil" && nextScene != "Accueil")
            {
                se.order++;
            }

            if (nextScene == "Accueil")
            {
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
            nextScene = "";
        }

        public void resetTimer()
        {
            secondLevel1 = 0;
            secondLevel2 = 0;
            secondLevel3 = 0;

            timer1Start = false;
            timer2Start = false;
            timer3Start = false;

            ArgentDisque.GetComponent<Image>().color = new Color(1, 1, 1);
            OrDisque.GetComponent<Image>().color = new Color(1, 1, 1);
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
