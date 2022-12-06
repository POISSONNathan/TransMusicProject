using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class reactionTime : TouchableObject
    {
        public detectDrag dd;

        public float counterChangeColor;

        public int score;

        public bool activePossible = true;

        public float timeBeetweenActivaction;

        public int randomChoice = -1;

        void Start()
        {
            dd.scoreSceneNeed = 5;
            dd.nextScene = "Rotate";
        }

        // Update is called once per frame
        void Update()
        {
        counterChangeColor += 1 * Time.deltaTime;

            dd.scoreScene = score;

            if (counterChangeColor >= timeBeetweenActivaction)
            {

                if (activePossible == true)
                {
                    randomChoice = Random.Range(0, dd.objPressed.Count);
                    var currentObjTouch = dd.objPressed[randomChoice];
                    currentObjTouch.GetComponent<objActive>().isActive = true;
                    activePossible = false;
                }
            

                if (counterChangeColor >= timeBeetweenActivaction * 2)
                {
                    activePossible = true;
                    var lastObjTouch = dd.objPressed[randomChoice];
                    lastObjTouch.GetComponent<objActive>().isActive = false;

                    counterChangeColor = 0;
                }

            }
        }

    }
}
