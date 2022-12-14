using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class caisse : MonoBehaviour
    {
        public ManagerManager gm;

        public bool touchPossible = true;

        void Start()
        {
            gm = ManagerManager.GetManagerManager;
            gm.lm.scoreSceneNeed = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0 && touchPossible == true)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
                touchPossible = false;
            }
            if (Input.touchCount == 0)
            {
                touchPossible = true;
            }
        }
            
    }
}

