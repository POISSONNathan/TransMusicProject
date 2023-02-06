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

        public void CreateText()
        {
            if (gm.lm.miniGame1End == true)
            {
                for (int i = 0; i < miniGames1.Count; i++)
                {
                    miniGames1[i].SetActive(true);
                }
            }

            if (gm.lm.miniGame2End == true)
            {
                for (int i = 0; i < miniGames2.Count; i++)
                {
                    miniGames2[i].SetActive(true);
                }
            }

            if (gm.lm.miniGame3End == true)
            {
                for (int i = 0; i < miniGames3.Count; i++)
                {
                    miniGames3[i].SetActive(true);
                }
            }

            gm.lm.infoOpen = true;
        }

        void Update()
        {
            if (gm.dragGameGood == true)
            { miniGames1[0].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames1[0].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.essuyerGameGood == true)
            { miniGames1[1].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames1[1].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.filsGameGood == true)
            { miniGames1[2].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames1[2].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.monterCaisseGameGood == true)
            { miniGames1[3].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames1[3].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }

            if (gm.trouverMerchGameGood == true)
            { miniGames2[0].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames2[0].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.magasinGameGood == true)
            { miniGames2[1].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames2[1].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.balaiGameGood == true)
            { miniGames2[2].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames2[2].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.trouverObjGameGood == true)
            { miniGames2[3].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames2[3].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }

            if (gm.rotateGameGood == true)
            { miniGames3[0].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames3[0].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.reactionTimeGameGood == true)
            { miniGames3[1].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames3[1].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.lumiereGameGood == true)
            { miniGames3[2].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames3[2].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
            if (gm.vipGameGood == true)
            { miniGames3[3].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
            else { miniGames3[3].GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.35f, 0.35f); }
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

                gm.lm.infoOpen = false;
            }
        }
    }
}
