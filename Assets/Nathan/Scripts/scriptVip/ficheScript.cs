using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{
    public class ficheScript : TouchableObject

    
    {
        public Vector3 start;
        public Transform target;
        public vipScript vs;
        // Start is called before the first frame update
        void Start()
        {
            start = transform.position;
            //Debug.Log(vs.pause);
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public override void OnTouch(Touch touchInfo)
        {
            
            if (!vs.pause)
            {
                
                transform.position = start;
                vs.pause = true;
                
            }
            else
            {
                transform.position = target.position;
                vs.pause = false;
            }
            //Debug.Log(vs.pause);

        }
    }
}
