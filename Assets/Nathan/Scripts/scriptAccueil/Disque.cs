using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Disque : MonoBehaviour
    {
        public List<GameObject> listDisques;

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
                    listDisques[0].SetActive(true);
                }
                if (lm.bestTimeLevel1 < 50)
                {
                    listDisques[1].SetActive(true);
                }
                if (lm.bestTimeLevel1 < 40)
                {
                    listDisques[2].SetActive(true);
                }
            }
            if (level == 2)
            {
                if (lm.bestTimeLevel2 < 100000)
                {
                    listDisques[0].SetActive(true);
                }
                if (lm.bestTimeLevel2 < 50)
                {
                    listDisques[1].SetActive(true);
                }
                if (lm.bestTimeLevel2 < 40)
                {
                    listDisques[2].SetActive(true);
                }
            }
            if (level == 3)
            {
                if (lm.bestTimeLevel3 < 100000)
                {
                    listDisques[0].SetActive(true);
                }
                if (lm.bestTimeLevel3 < 50)
                {
                    listDisques[1].SetActive(true);
                }
                if (lm.bestTimeLevel3 < 40)
                {
                    listDisques[2].SetActive(true);
                }
            }
        }
    }
}
