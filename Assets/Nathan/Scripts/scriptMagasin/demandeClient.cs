using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {
    public class demandeClient : MonoBehaviour
    {
        private List<string> objPossible = new List<string>();

        public int randomObj;

        public List<string> client = new List<string>();

        public int nbrObj = 2;

        public int goodObj = 0;

        public detectDrag dd;

        public GameObject objSelected;

        public bool changeCmd = false;

        void Start()
        {
            dd.scoreSceneNeed = 3;

            objPossible.Add("cable");
            objPossible.Add("boite");
            objPossible.Add("outil");
            objPossible.Add("bois");
            objPossible.Add("proj");
            objPossible.Add("micro");

            for (int i = 0; i < nbrObj; i++)
            {
                randomObj = Random.Range(0, objPossible.Count - 1);
                client.Add(objPossible[randomObj]);
            }


        }

        // Update is called once per frame
        void Update()
        {
            if (changeCmd == true)
            {
                demandeClient1();
                changeCmd = false;
            }
        }

        public void demandeClient1()
        {
            for (int i = 0; i < nbrObj; i++)
            {
                randomObj = Random.Range(0, objPossible.Count - 1);
                client[i] = objPossible[randomObj];
            }
        }
    }
}
