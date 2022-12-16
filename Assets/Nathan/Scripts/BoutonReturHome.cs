using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan {
    public class BoutonReturHome : TouchableObject
    {
        private LevelManager lm;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public override void OnTouch(Touch touchinfo)
        {
            lm.resetTimer();
            Debug.Log("fr");
            SceneManager.LoadScene("1Start", LoadSceneMode.Single);
        }
    }
}
