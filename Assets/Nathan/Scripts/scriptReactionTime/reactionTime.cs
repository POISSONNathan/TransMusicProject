using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class reactionTime : MonoBehaviour
    {
        public detectDrag dd;

        public float counterChangeColor;

        public int score;

        public bool activePossible = true;

        public float timeBeetweenActivaction;

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {


        counterChangeColor += 1 * Time.deltaTime;


        if (counterChangeColor >= timeBeetweenActivaction)
        {


            if (activePossible == true)
            {
                dd.randomChoice = Random.Range(0,6);
                var currentObjTouch = dd.objPressed[dd.randomChoice];
                currentObjTouch.GetComponent<objActive>().isActive = true;
                activePossible = false;
            }
            

            if (counterChangeColor >= timeBeetweenActivaction * 2)
            {
                activePossible = true;
                var lastObjTouch = dd.objPressed[dd.randomChoice];
                lastObjTouch.GetComponent<objActive>().isActive = false;

                counterChangeColor = 0;
            }

        }





       
        

    }
}
}
