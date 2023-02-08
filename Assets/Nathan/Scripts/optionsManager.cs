using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
        public class optionsManager : MonoBehaviour
    {
        public bool dansOptions = false;
        public SpriteRenderer sr;
        
        //public soundManager SndMng;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            sr.enabled = dansOptions;


        }
        public void Mute(string config,bool state)
        {
            if (config == "sfx") {
                Debug.Log($"les sfx passe en {state}"); 
            }

            if (config == "musique") { 
                Debug.Log($"la musique passe en {state}"); 
            }

            if (config == "aides")
            {
                Debug.Log($"les aides sont {state}");
            }
        }

    }
}
