using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class demandeClient : MonoBehaviour
    {
        public List<string> objPossible = new List<string>();

        public int randomObj;

        public List<string> client = new List<string>();

        public int nbrObj;

        public int goodObj = 0;


        public GameObject objSelected;

        public bool changeCmd = false;

        public bool objOn = false;
        public bool change = true;

        private LevelManager lm;

        public List<GameObject> inventaireClient;
        public List<GameObject> spawnObj;

        public GameObject neObj;
        public List<GameObject> newObj;

        public int spawnIndex = 0;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            lm.scoreSceneNeed = 2;

            objPossible.Add("cable");
            objPossible.Add("boite");
            objPossible.Add("outil");
            objPossible.Add("bois");
            objPossible.Add("proj");
            objPossible.Add("micro");
            GenerateList();
        }


        private void GenerateList()
        {
            var temp = objPossible;

            for (int i = 0; i < Mathf.Min(nbrObj, objPossible.Count); i++)
            {
                randomObj = Random.Range(0, temp.Count);
                client.Add(temp[randomObj]);
                temp.Remove(temp[randomObj]);
            }

        }
        // Update is called once per frame
        void Update()
        {
            if (changeCmd == true)
            {
                GenerateList();
                changeCmd = false;
            }

            if (goodObj == nbrObj)
            {
                changeCmd = true;
                change = true;
                spawnIndex = 0;
                goodObj = 0;
                for (int i = 0; i < newObj.Count; i++)
                {
                    newObj.Remove(newObj[i]);
                }
                lm.scoreScene++;
            }

            if (change == true && lm.scoreScene < lm.scoreSceneNeed)
            {

                for (int i = 0; i < client.Count; i++)
                {
                    if (client[i] == "cable")
                    {
                        neObj = Instantiate(inventaireClient[0], spawnObj[spawnIndex].transform.position, Quaternion.identity);
                        neObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        newObj.Add(neObj);
                        spawnIndex++;
                    }
                    if (client[i] == "boite")
                    {
                        neObj = Instantiate(inventaireClient[1], spawnObj[spawnIndex].transform.position, Quaternion.identity);
                        neObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        newObj.Add(neObj);
                        spawnIndex++;
                    }
                    if (client[i] == "outil")
                    {
                        neObj = Instantiate(inventaireClient[2], spawnObj[spawnIndex].transform.position, Quaternion.identity);
                        neObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        newObj.Add(neObj);
                        spawnIndex++;
                    }
                    if (client[i] == "bois")
                    {
                        neObj = Instantiate(inventaireClient[3], spawnObj[spawnIndex].transform.position, Quaternion.identity);
                        neObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        newObj.Add(neObj);
                        spawnIndex++;
                    }
                    if (client[i] == "proj")
                    {
                        neObj = Instantiate(inventaireClient[4], spawnObj[spawnIndex].transform.position, Quaternion.identity);
                        neObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        newObj.Add(neObj);
                        spawnIndex++;
                    }
                    if (client[i] == "micro")
                    {
                        neObj = Instantiate(inventaireClient[5], spawnObj[spawnIndex].transform.position, Quaternion.identity);
                        neObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        newObj.Add(neObj);
                        spawnIndex++;
                    }
                    change = false;
                }
            }
        }
    }
}
