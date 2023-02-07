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

        public int index = 0;

        public GameObject objSelected;

        public bool changeCmd = false;

        public bool objOn = false;
        public bool changeInventaire = true;

        private LevelManager lm;

        public List<GameObject> inventaireClient;

        public List<GameObject> spawnObj1;
        public List<GameObject> spawnObj2;
        public List<GameObject> spawnObj3;

        public GameObject neObj;
        public List<GameObject> newObj;

        public GameObject bulle;
        public GameObject clientSprite;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            lm.scoreSceneNeed = 2;

            GenerateList();
        }


        private void GenerateList()
        {
            objPossible = new List<string> { "cable", "boite", "outil", "bois", "proj", "micro" };

            var temp = objPossible;

            for (int i = 0; i < Mathf.Min(nbrObj, objPossible.Count); i++)
            {
                randomObj = Random.Range(0, temp.Count);
                client.Add(temp[randomObj]);
                temp.Remove(temp[randomObj]);
            }

            changeInventaire = true;

            objPossible = new List<string> { "cable", "boite", "outil", "bois", "proj", "micro" };

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
                goodObj = 0;
                for (int i = 0; i <= newObj.Count; i++)
                {
                    if(i==newObj.Count){
                    newObj.Clear();
                    }else{
                        Destroy(newObj[i]);
                    }
                }
                lm.scoreScene++;

                if (lm.scoreScene == lm.scoreSceneNeed)
                {
                    Destroy(bulle.gameObject);
                    Destroy(clientSprite.gameObject);
                }
            }

            if (changeInventaire == true && lm.scoreScene < lm.scoreSceneNeed)
            {
                for (int i = 0; i < client.Count; i++)
                {
                    if (objPossible.Contains(client[i]))
                    {
                        index = objPossible.IndexOf(client[i]);

                        if (nbrObj == 1)
                        {
                            neObj = Instantiate(inventaireClient[index], spawnObj1[i].transform.position, Quaternion.identity);
                            neObj.gameObject.GetComponent<objets>().enabled = false;
                            neObj.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                        }
                        if (nbrObj == 2)
                        {
                            neObj = Instantiate(inventaireClient[index], spawnObj2[i].transform.position, Quaternion.identity);
                            neObj.gameObject.GetComponent<objets>().enabled = false;
                            neObj.transform.localScale = new Vector3(0.26f, 0.26f, 0.26f);
                        }
                        if (nbrObj == 3)
                        {
                            neObj = Instantiate(inventaireClient[index], spawnObj3[i].transform.position, Quaternion.identity);
                            neObj.gameObject.GetComponent<objets>().enabled = false;
                            neObj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        }
                        newObj.Add(neObj);
                    }
                }
                changeInventaire = false;
            }
        }
    }
}
