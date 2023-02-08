using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Disque : MonoBehaviour
    {
        public List<GameObject> listDisques;
        public List<GameObject> listAnimDisques;
        public List<GameObject> listDisquesTableauRecap;

        public int level;

        private LevelManager lm;

        public accueil ac;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            if (level == 1)
            {
                if (lm.bestTimeLevel1 < lm.maxTimeLevel1)
                {
                    if (lm.cdb1 == true)
                    {
                        listDisques[0].SetActive(true);
                        listDisquesTableauRecap[0].SetActive(true);
                    }
                    else
                    {
                        lm.cdb1 = true;
                    }
                }
                if (lm.bestTimeLevel1 < lm.twoStarTimeLevel1)
                {
                    
                    if (lm.cdb1 == true)
                    {
                        listDisques[1].SetActive(true);
                        listDisquesTableauRecap[1].SetActive(true);
                    }
                    else
                    {
                        lm.cda1 = true;
                    }
                }
                if (lm.bestTimeLevel1 < lm.threeStarTimeLevel1)
                {
                    if (lm.cdo1 == true)
                    {
                        listDisques[2].SetActive(true);
                        listDisquesTableauRecap[2].SetActive(true);
                        ac.fullDisqueLvl1 = true;
                    }
                    else
                    {
                        lm.cdb1 = true;
                        ac.fullDisqueLvl1 = true;
                    }
                }
            }
            if (level == 2)
            {
                if (lm.bestTimeLevel2 < lm.maxTimeLevel2)
                {
                    listDisques[0].SetActive(true);
                    listDisquesTableauRecap[0].SetActive(true);
                }
                if (lm.bestTimeLevel2 < lm.twoStarTimeLevel2)
                {
                    listDisques[1].SetActive(true);
                    listDisquesTableauRecap[1].SetActive(true);
                }
                if (lm.bestTimeLevel2 < lm.threeStarTimeLevel2)
                {
                    listDisques[2].SetActive(true);
                    listDisquesTableauRecap[2].SetActive(true);
                    ac.fullDisqueLvl2 = true;
                }
            }
            if (level == 3)
            {
                if (lm.bestTimeLevel3 < lm.maxTimeLevel3)
                {
                    listDisques[0].SetActive(true);
                    listDisquesTableauRecap[0].SetActive(true);
                }
                if (lm.bestTimeLevel3 < lm.twoStarTimeLevel3)
                {
                    listDisques[1].SetActive(true);
                    listDisquesTableauRecap[1].SetActive(true);
                }
                if (lm.bestTimeLevel3 < lm.threeStarTimeLevel3)
                {
                    listDisques[2].SetActive(true);
                    listDisquesTableauRecap[2].SetActive(true);
                    ac.fullDisqueLvl3 = true;
                }
            }
        }
    }
}
