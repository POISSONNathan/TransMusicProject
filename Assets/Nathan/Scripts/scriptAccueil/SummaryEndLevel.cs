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

        public List<GameObject> spawn;

        public int order = 0;

        public bool addOrder1;

        public List<GameObject> orderText;

        public void CreateText()
        {
            if (gm.lm.miniGame1End == true)
            {
                for (int i = 0; i < miniGames1.Count; i++)
                {
                    miniGames1[i].SetActive(true);
                    miniGames1[i].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
                }
            }

            if (gm.lm.miniGame2End == true)
            {
                for (int i = 0; i < miniGames2.Count; i++)
                {
                    miniGames2[i].SetActive(true);
                    miniGames2[i].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
                }
            }

            if (gm.lm.miniGame3End == true)
            {
                for (int i = 0; i < miniGames3.Count; i++)
                {
                    miniGames3[i].SetActive(true);
                    miniGames3[i].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
                }
            }

            TextAppear();

            gm.lm.infoOpen = true;
        }

        void TextAppear()
        {
            if (gm.lm.miniGame1End == true)
            {
                if (gm.dragGameGood == false)
                {
                    miniGames1[0].transform.position = spawn[order].transform.position;
                    order++;
                }
                if (gm.essuyerGameGood == false)
                {
                    miniGames1[1].transform.position = spawn[order].transform.position;
                    order++;
                }
                if (gm.filsGameGood == false)
                {
                    miniGames1[2].transform.position = spawn[order].transform.position;
                    order++;
                }
                if (gm.monterCaisseGameGood == false)
                {
                    miniGames1[3].transform.position = spawn[order].transform.position;
                    order++;
                }
            }


            ////////////////////

            if (gm.lm.miniGame2End == true)
            {
                if (gm.trouverMerchGameGood == false)
                {
                    miniGames2[0].transform.position = spawn[order].transform.position;
                    order++; 
                }
                if (gm.magasinGameGood == false)
                { 
                    miniGames2[1].transform.position = spawn[order].transform.position;
                    order++; 
                }
                if (gm.balaiGameGood == false)
                { 
                    miniGames2[2].transform.position = spawn[order].transform.position;
                    order++; 
                }
                if (gm.trouverObjGameGood == false)
                { 
                    miniGames2[3].transform.position = spawn[order].transform.position;
                    order++; 
                }
            }

            ////////////////////

            if (gm.lm.miniGame3End == true)
            { 
                if (gm.rotateGameGood == false)
                { 
                    miniGames3[0].transform.position = spawn[order].transform.position;
                    order++; 
                }
                if (gm.reactionTimeGameGood == false)
                { 
                    miniGames3[1].transform.position = spawn[order].transform.position;
                    order++; 
                }
                if (gm.lumiereGameGood == false)
                { 
                    miniGames3[2].transform.position = spawn[order].transform.position;
                    order++; 
                }
                if (gm.vipGameGood == false)
                { 
                    miniGames3[3].transform.position = spawn[order].transform.position;
                    order++; 
                }
            }

            /////////////////////

            for (int i = 0; i < orderText.Count; i++)
            {
                orderText[i].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            }
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

                orderText.Clear();

                order = 0;
                gm.lm.infoOpen = false;
            }
        }
    }
}
