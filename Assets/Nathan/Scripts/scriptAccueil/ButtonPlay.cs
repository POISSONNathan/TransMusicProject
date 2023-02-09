using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{

    public class ButtonPlay : TouchableObject
    {
        public optionsManager optionsManager;

        public LevelManager lm;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Collider2D>().enabled = !optionsManager.dansOptions;
        }

        public override void OnTouch(Touch touchinfo)
        {
            lm.placeDisque = true; ;
            SceneManager.LoadScene("Accueil", LoadSceneMode.Single);
        }
    }
}
