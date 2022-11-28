using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{

    public class objActive : TouchableObject
    {
        public bool isActive;
        public reactionTime rt;

        public override void OnTouch(Touch touchInfo)
        {
            if (isActive == true)
            {
                rt.score++;
                rt.activePossible = true;
                isActive = false;
                rt.counterChangeColor = 0;
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
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
            }
            else{
                GetComponent<SpriteRenderer>().color = new Color(1,1, 1);
            }
        }
    }

}