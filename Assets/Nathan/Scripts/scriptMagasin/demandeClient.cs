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


        public GameObject objSelected;

        public bool changeCmd = false;

        public bool objOn = false;

        private LevelManager lm;

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
                goodObj = 0;
                lm.scoreScene++;
            }


        }
    }
}
