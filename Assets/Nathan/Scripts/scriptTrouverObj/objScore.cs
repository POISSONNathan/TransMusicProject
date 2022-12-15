using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class objScore : TouchableObject
    {
        private LevelManager lm;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnTouch(Touch touchinfo)
        {
            lm.scoreScene++;
            Destroy(this.gameObject);
        }
    }
}
