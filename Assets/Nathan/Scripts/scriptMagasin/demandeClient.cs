using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {
    public class demandeClient : MonoBehaviour
    {
        public List<string> objPossible = new List<string>();

        public int randomObj;

        public List<string> client = new List<string>();

        public int nbrObj = 2;

        public int goodObj = 0;

        public detectDrag dd;

        public GameObject objSelected;

        public bool changeCmd = false;

        public bool objOn = false;

        void Start()
        {
            dd.scoreSceneNeed = 2;

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
                goodObj = 0;
                dd.scoreScene++;
            }


        }

        //public void demandeClient1()
        //{
        //    for (int i = 0; i < nbrObj; i++)
        //    {
        //        randomObj = Random.Range(0, objPossible.Count);
        //        client[i] = objPossible[randomObj];
        //    }
        //}
    }
}
