using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class SummaryEndLevel : TouchableObject
    {
        public ManagerManager gm;

        public bool touchOneTime = false;

        public List<GameObject> miniGames1;

        public List<GameObject> miniGames2;

        public List<GameObject> miniGames3;


        void Start()
        {
        }

        void Update()
        {
            if (gm.dragGameGood == true)
            { miniGames1[0].SetActive(true); }
            if (gm.essuyerGameGood == true)
            { miniGames1[1].SetActive(true); }
            if (gm.filsGameGood == true)
            { miniGames1[2].SetActive(true); }
            if (gm.monterCaisseGameGood == true)
            { miniGames1[3].SetActive(true); }

            if (gm.trouverMerchGameGood == true)
            { miniGames2[0].SetActive(true); }
            if (gm.magasinGameGood == true)
            { miniGames2[1].SetActive(true); }
            if (gm.balaiGameGood == true)
            { miniGames2[2].SetActive(true); }
            if (gm.trouverObjGameGood == true)
            { miniGames2[3].SetActive(true); }

            if (gm.rotateGameGood == true)
            { miniGames3[0].SetActive(true); }
            if (gm.reactionTimeGameGood == true)
            { miniGames3[1].SetActive(true); }
            if (gm.lumiereGameGood == true)
            { miniGames3[2].SetActive(true); }
            if (gm.vipGameGood == true)
            { miniGames3[3].SetActive(true); }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (!touchOneTime)
            {
                touchOneTime = true;
            }
        }
        public override void TouchUp()
        {
            if (touchOneTime)
            {
                touchOneTime = false;

                gm.lm.resetGameEnd();

                for (int i = 0; i < miniGames1.Count; i++)
                {
                    miniGames1[i].SetActive(false);
                }
                for (int i = 0; i < miniGames2.Count; i++)
                {
                    miniGames2[i].SetActive(false);
                }
                for (int i = 0; i < miniGames3.Count; i++)
                {
                    miniGames3[i].SetActive(false);
                }

                this.gameObject.SetActive(false);
            }
        }
    }
}
