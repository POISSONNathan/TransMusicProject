using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Disque : MonoBehaviour
    {
        public GameObject disqueBronze;
        public GameObject disqueArgent;
        public GameObject disqueOr;

        public int level;

        private LevelManager lm;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            if (level == 1)
            {
                if (lm.bestTimeLevel1 < 100000)
                {
                    disqueBronze.SetActive(true);
                }
                if (lm.bestTimeLevel1 < 50)
                {
                    disqueArgent.SetActive(true);
                }
                if (lm.bestTimeLevel1 < 40)
                {
                    disqueOr.SetActive(true);
                }
            }
            if (level == 2)
            {
                if (lm.bestTimeLevel2 < 100000)
                {
                    disqueBronze.SetActive(true);
                }
                if (lm.bestTimeLevel2 < 50)
                {
                    disqueArgent.SetActive(true);
                }
                if (lm.bestTimeLevel2 < 40)
                {
                    disqueOr.SetActive(true);
                }
            }
            if (level == 3)
            {
                if (lm.bestTimeLevel3 < 100000)
                {
                    disqueBronze.SetActive(true);
                }
                if (lm.bestTimeLevel3 < 50)
                {
                    disqueArgent.SetActive(true);
                }
                if (lm.bestTimeLevel3 < 40)
                {
                    disqueOr.SetActive(true);
                }
            }
        }
    }
}
