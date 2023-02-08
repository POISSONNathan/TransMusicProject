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

        public List<GameObject> destroyList;

        public List<GameObject> cases;

        public int order = 0;

        public bool canEnd = false;

        public bool startTimer = false;

        public List<GameObject> orderText;

        public float pourcent = -0.01f;

        public Color alphaGood;
        public Color alphaNotGood;

        public int indexOrderText = 0;

        public GameObject caseCoche;
        public Transform posX;

        public bool createCaseCoche = false;

        public void CreateText()
        {
            if (gm.lm.miniGame1End == true)
            {
                for (int i = 0; i < miniGames1.Count; i++)
                {
                    miniGames1[i].SetActive(true);
                    miniGames1[i].GetComponent<SpriteRenderer>().color = alphaNotGood;
                }
            }

            if (gm.lm.miniGame2End == true)
            {
                for (int i = 0; i < miniGames2.Count; i++)
                {
                    miniGames2[i].SetActive(true);
                    miniGames2[i].GetComponent<SpriteRenderer>().color = alphaNotGood;
                }
            }

            if (gm.lm.miniGame3End == true)
            {
                for (int i = 0; i < miniGames3.Count; i++)
                {
                    miniGames3[i].SetActive(true);
                    miniGames3[i].GetComponent<SpriteRenderer>().color = alphaNotGood;
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

            startTimer = true;
            createCaseCoche = true;
        }

        public void Update()
        {
            if (startTimer == true)
            {
                pourcent += Time.deltaTime / 1f ;

                orderText[indexOrderText].GetComponent<SpriteRenderer>().color = Color.Lerp(alphaNotGood, alphaGood, pourcent);

                if (pourcent >= 1)
                {
                    indexOrderText++;
                    pourcent = 0;

                    if (indexOrderText <= order)
                    {
                        createCaseCoche = true;
                    }
                }

                if (indexOrderText == orderText.Count)
                {
                    startTimer = false;
                    canEnd = true;
                    indexOrderText = 0;
                    pourcent = 0;
                }
            }

            if (createCaseCoche == true)
            {
                var newCaseCoche = Instantiate(caseCoche, new Vector2(cases[indexOrderText].transform.position.x +0.2f, cases[indexOrderText].transform.position.y - 0.2f), Quaternion.identity);
                destroyList.Add(newCaseCoche);
                createCaseCoche = false;
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (!touchOneTime && canEnd == true)
            {
                touchOneTime = true;
            }
        }
        public override void TouchUp()
        {
            if (touchOneTime)
            {
                gm.lm.placeDisque = true;

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

                for (int i = 0; i < destroyList.Count; i++)
                {
                    Destroy(destroyList[i].gameObject);
                }

                this.gameObject.SetActive(false);

                orderText.Clear();

                order = 0;
                canEnd = false;
                gm.lm.infoOpen = false;
            }
        }
    }
}
