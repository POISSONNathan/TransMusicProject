using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class listLight : MonoBehaviour
    {
        public List<GameObject> lights;
        public int lightUseCount = 0;

        public detectDrag dd;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (lightUseCount == 3)
            {
                dd.gameFinish = true;
            }
        }
    }
}
