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
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public override void OnTouch(Touch touchInfo)
        {
            Debug.Log(vs.pause);
            if (!vs.pause)
            {
                transform.position = target.position;
                
            }
            else
            {
                transform.position = start;
            }
            vs.pause = !vs.pause;
        }
    }
}
