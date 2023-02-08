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

        public float timer;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            if (lm.placeDisque == true)
            {
                if (level == 1)
                {
                    if (lm.bestTimeLevel1 < lm.maxTimeLevel1)
                    {
                        if (lm.cdb1 == true)
                        {
                            listDisques[0].SetActive(true);
                            listDisquesTableauRecap[0].SetActive(true);
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[0].SetActive(true);
                            lm.cdb1 = true;
                            lm.placeDisque = false;
                            listAnimDisques[0].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel1 < lm.twoStarTimeLevel1)
                    {

                        if (lm.cda1 == true)
                        {
                            listDisques[1].SetActive(true);
                            listDisquesTableauRecap[1].SetActive(true);
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[1].SetActive(true);
                            lm.cda1 = true;
                            lm.placeDisque = false;
                            listAnimDisques[1].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel1 < lm.threeStarTimeLevel1)
                    {
                        if (lm.cdo1 == true)
                        {
                            listDisques[2].SetActive(true);
                            listDisquesTableauRecap[2].SetActive(true);
                            ac.fullDisqueLvl1 = true;
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[2].SetActive(true);
                            lm.cdb1 = true;
                            ac.fullDisqueLvl1 = true;
                            lm.placeDisque = false;
                            listAnimDisques[2].SetActive(true);
                        }
                    }
                }

                if (level == 2)
                {
                    if (lm.bestTimeLevel2 < lm.maxTimeLevel2)
                    {
                        if (lm.cdb2 == true)
                        {
                            listDisques[0].SetActive(true);
                            listDisquesTableauRecap[0].SetActive(true);
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[0].SetActive(true);
                            lm.cdb1 = true;
                            lm.placeDisque = false;
                            listAnimDisques[0].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel2 < lm.twoStarTimeLevel2)
                    {
                        if (lm.cda2 == true)
                        {
                            listDisques[1].SetActive(true);
                            listDisquesTableauRecap[1].SetActive(true);
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[1].SetActive(true);
                            lm.cdb1 = true;
                            lm.placeDisque = false;
                            listAnimDisques[1].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel2 < lm.threeStarTimeLevel2)
                    {
                        if (lm.cdo2 == true)
                        {
                            listDisques[2].SetActive(true);
                            listDisquesTableauRecap[2].SetActive(true);
                            ac.fullDisqueLvl1 = true;
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[2].SetActive(true);
                            lm.cdb1 = true;
                            ac.fullDisqueLvl2 = true;
                            lm.placeDisque = false;
                            listAnimDisques[2].SetActive(true);
                        }
                    }
                }

                if (level == 3)
                {
                    if (lm.bestTimeLevel3 < lm.maxTimeLevel3)
                    {
                        if (lm.cdb3 == true)
                        {
                            listDisques[0].SetActive(true);
                            listDisquesTableauRecap[0].SetActive(true);
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[0].SetActive(true);
                            lm.cdb1 = true;
                            lm.placeDisque = false;
                            listAnimDisques[0].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel3 < lm.twoStarTimeLevel3)
                    {
                        if (lm.cda3 == true)
                        {
                            listDisques[1].SetActive(true);
                            listDisquesTableauRecap[1].SetActive(true);
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[1].SetActive(true);
                            lm.cdb1 = true;
                            lm.placeDisque = false;
                            listAnimDisques[1].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel3 < lm.threeStarTimeLevel3)
                    {
                        if (lm.cdo3 == true)
                        {
                            listDisques[2].SetActive(true);
                            listDisquesTableauRecap[2].SetActive(true);
                            ac.fullDisqueLvl1 = true;
                            lm.placeDisque = false;
                        }
                        else
                        {
                            listDisquesTableauRecap[2].SetActive(true);
                            lm.cdb1 = true;
                            ac.fullDisqueLvl3 = true;
                            lm.placeDisque = false;
                            listAnimDisques[2].SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
