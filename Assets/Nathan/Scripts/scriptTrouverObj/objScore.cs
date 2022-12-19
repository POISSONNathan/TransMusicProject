using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class objScore : TouchableObject
    {
        private LevelManager lm;

        private bool canTouch = false;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        public void Update()
        {
            if (Input.touchCount == 0)
            {
                canTouch = true;
            }
            else
            {
                canTouch = false;
            }
        }
        public override void OnTouch(Touch touchinfo)
        {
            if (canTouch == true)
            {
                lm.scoreScene++;
                Destroy(this.gameObject);
            }
        }
    }
}
