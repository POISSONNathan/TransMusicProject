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


        }
        public void Mute(string config,bool state)
        {
            if (config == "sfx") {
                MusicManagerSingleton.Instance.sfxAudioSource.volume = state ? 1f : 0f;
                MusicManagerSingleton.Instance.sfxAudioSource2.volume = state ? 1f : 0f;
                MusicManagerSingleton.Instance.sfxAudioSource3.volume = state ? 1f : 0f;
                Debug.Log($"sfx volume : {MusicManagerSingleton.Instance.sfxAudioSource.volume}");

            }

            if (config == "musique") { 
                MusicManagerSingleton.Instance.musicAudioSource.volume = state ? 1f : 0f;
                Debug.Log($"musique volume : {MusicManagerSingleton.Instance.musicAudioSource.volume}");

            }

            if (config == "aides")
            {
                MusicManagerSingleton.Instance.activeAides = state;
                Debug.Log($"les aides sont {MusicManagerSingleton.Instance.activeAides}");
            }
        }

    }
}
