using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{

    public class objActive : TouchableObject
    {
        public bool isActive;
        public reactionTime rt;

        public GameObject colorButton;

        public override void OnTouch(Touch touchInfo)
        {
            if (isActive == true)
            {
                rt.score++;
                rt.activePossible = true;
                isActive = false;
                rt.counterChangeColor = 0;
                this.GetComponent<Animator>().Play("ButtonPushLevel");
                MusicManagerSingleton.Instance.PlaySound2("Buzz");
            }
        }

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (isActive == true)
            {
                colorButton.SetActive(true);
            }
            else{
                GetComponent<SpriteRenderer>().color = new Color(1,1, 1);
                colorButton.SetActive(false);
            }
        }
    }

}