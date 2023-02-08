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

        public float maxTime1;
        public float maxTime2;
        public float maxTime3;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            timer = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (lm.placeDisque == true)
            {
                timer += Time.deltaTime;

                if (level == 1)
                {
                    if (lm.bestTimeLevel1 < lm.twoStarTimeLevel1 && lm.currentLevelForDisque == 0)
                    {
                        maxTime1 = 0.51f;
                    }
                    if (lm.bestTimeLevel1 < lm.threeStarTimeLevel1 && lm.currentLevelForDisque == 0)
                    {
                        maxTime1 = 1.01f;
                    }

                        if (lm.bestTimeLevel1 < lm.maxTimeLevel1)
                    {
                        if (lm.cdb1 == true)
                        {
                            listDisques[0].SetActive(true);
                            listDisquesTableauRecap[0].SetActive(true);
                            if (timer >= maxTime1 && lm.currentLevelForDisque == 0)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[0].SetActive(true);
                            if (timer >= maxTime1 && lm.currentLevelForDisque == 0)
                            {
                                lm.cdb1 = true;
                                lm.placeDisque = false;
                            }
                            listAnimDisques[0].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel1 < lm.twoStarTimeLevel1)
                    {

                        if (lm.cda1 == true)
                        {
                            listDisques[1].SetActive(true);
                            listDisquesTableauRecap[1].SetActive(true);
                            if (timer >= maxTime1 && lm.currentLevelForDisque == 0)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[1].SetActive(true);
                            if (timer >= maxTime1 && lm.currentLevelForDisque == 0)
                            {
                                lm.cda1 = true;
                                lm.placeDisque = false;
                            }
                            if (timer >= 0.5f && lm.currentLevelForDisque == 0)
                            {
                                listAnimDisques[1].SetActive(true);
                            }
                        }
                    }
                    if (lm.bestTimeLevel1 < lm.threeStarTimeLevel1)
                    {
                        if (lm.cdo1 == true)
                        {
                            listDisques[2].SetActive(true);
                            listDisquesTableauRecap[2].SetActive(true);
                            ac.fullDisqueLvl1 = true;
                            if (timer >= maxTime1 && lm.currentLevelForDisque == 0)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[2].SetActive(true);
                            if (timer >= maxTime1 && lm.currentLevelForDisque == 0)
                            {
                                lm.cdo1 = true;
                                ac.fullDisqueLvl1 = true;
                                lm.placeDisque = false;
                            }
                            if (timer > 1f && lm.currentLevelForDisque == 0)
                            {
                                listAnimDisques[2].SetActive(true);
                            }
                        }
                    }
                }

                /////////////////

                if (level == 2)
                {
                    Debug.Log(maxTime2);
                    if (lm.bestTimeLevel2 < lm.twoStarTimeLevel2 && lm.currentLevelForDisque == 1)
                    {
                        maxTime2 = 0.51f;
                    }
                    if (lm.bestTimeLevel2 < lm.threeStarTimeLevel2 && lm.currentLevelForDisque == 1)
                    {
                        maxTime2 = 1.01f;
                    }

                    if (lm.bestTimeLevel2 < lm.maxTimeLevel2)
                    {
                        if (lm.cdb2 == true)
                        {
                            listDisques[0].SetActive(true);
                            listDisquesTableauRecap[0].SetActive(true);
                            if (timer >= maxTime2 && lm.currentLevelForDisque == 1)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[0].SetActive(true);
                            if (timer >= maxTime2 && lm.currentLevelForDisque == 1)
                            {
                                lm.cdb2 = true;
                                lm.placeDisque = false;
                            }
                            listAnimDisques[0].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel2 < lm.twoStarTimeLevel2)
                    {
                        if (lm.cda2 == true)
                        {
                            listDisques[1].SetActive(true);
                            listDisquesTableauRecap[1].SetActive(true);
                            if (timer >= maxTime2 && lm.currentLevelForDisque == 1)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[1].SetActive(true);
                            if (timer >= maxTime2 && lm.currentLevelForDisque == 1)
                            {
                                lm.cda2 = true;
                                lm.placeDisque = false;
                            }
                            if (timer >= 0.5f && lm.currentLevelForDisque == 1)
                            {
                                listAnimDisques[1].SetActive(true);
                            }
                        }
                    }
                    if (lm.bestTimeLevel2 < lm.threeStarTimeLevel2)
                    {
                        if (lm.cdo2 == true)
                        {
                            listDisques[2].SetActive(true);
                            listDisquesTableauRecap[2].SetActive(true);
                            ac.fullDisqueLvl2 = true;
                            if (timer >= maxTime2 && lm.currentLevelForDisque == 1)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[2].SetActive(true);
                            if (timer >= maxTime2 && lm.currentLevelForDisque == 1)
                            {
                                lm.cdo2 = true;
                                ac.fullDisqueLvl2 = true;
                                lm.placeDisque = false;
                            }
                            if (timer > 1f && lm.currentLevelForDisque == 1)
                            {
                                listAnimDisques[2].SetActive(true);
                            }
                        }
                    }
                }

                /////////////////

                if (level == 3)
                {
                    if (lm.bestTimeLevel3 < lm.twoStarTimeLevel3 && lm.currentLevelForDisque == 2)
                    {
                        maxTime3 = 0.51f;
                    }
                    if (lm.bestTimeLevel3 < lm.threeStarTimeLevel3 && lm.currentLevelForDisque == 2)
                    {
                        maxTime3 = 1.01f;
                    }

                    if (lm.bestTimeLevel3 < lm.maxTimeLevel3)
                    {
                        if (lm.cdb3 == true)
                        {
                            listDisques[0].SetActive(true);
                            listDisquesTableauRecap[0].SetActive(true);
                            if (timer >= maxTime3 && lm.currentLevelForDisque == 2)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[0].SetActive(true);
                            if (timer >= maxTime3 && lm.currentLevelForDisque == 2)
                            {
                                lm.cdb3 = true;
                                lm.placeDisque = false;
                            }
                            listAnimDisques[0].SetActive(true);
                        }
                    }
                    if (lm.bestTimeLevel3 < lm.twoStarTimeLevel3)
                    {
                        if (lm.cda3 == true)
                        {
                            listDisques[1].SetActive(true);
                            listDisquesTableauRecap[1].SetActive(true);
                            if (timer >= maxTime3 && lm.currentLevelForDisque == 2)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[1].SetActive(true);
                            if (timer >= maxTime3 && lm.currentLevelForDisque == 2)
                            {
                                lm.cda3 = true;
                                lm.placeDisque = false;
                            }
                            if (timer >= 0.5f && lm.currentLevelForDisque == 2)
                            {
                                listAnimDisques[1].SetActive(true);
                            }
                        }
                    }
                    if (lm.bestTimeLevel3 < lm.threeStarTimeLevel3)
                    {
                        if (lm.cdo3 == true)
                        {
                            listDisques[2].SetActive(true);
                            listDisquesTableauRecap[2].SetActive(true);
                            ac.fullDisqueLvl3 = true;
                            if (timer >= maxTime3 && lm.currentLevelForDisque == 2)
                            {
                                lm.placeDisque = false;
                            }
                        }
                        else
                        {
                            listDisquesTableauRecap[2].SetActive(true);
                            if (timer >= maxTime3 && lm.currentLevelForDisque == 2)
                            {
                                lm.cdo3 = true;
                                ac.fullDisqueLvl3 = true;
                                lm.placeDisque = false;
                            }
                            if (timer > 1f && lm.currentLevelForDisque == 2)
                            {
                                listAnimDisques[2].SetActive(true);
                            }
                        }
                    }
                }
            }
        }
    }
}
