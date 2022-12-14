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

        public void ResetComponent()
        {
            scoreScene = 0;
            goNexwtGame = false;
        }

        void Update()
        {
            if (scoreScene == scoreSceneNeed)
            {
                GoToNextScene();
            }
        }

        public void GoToNextScene()
        {
            ResetComponent();
            if((SceneManager.GetActiveScene().name) != "Accueil")
            {
                Instantiate(WinParticule, transform.position, Quaternion.identity);
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
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    } 
}
