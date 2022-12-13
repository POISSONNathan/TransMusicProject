using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {
    public class demandeClient : MonoBehaviour
    {
        private List<string> objPossible = new List<string>();

        public int randomObj;

        public List<string> client = new List<string>();

        public int nbrObj = 3;

        public detectDrag dd;

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

        }

        void resetClient()
        {
            for (int i = 0; i < client.Count; i++)
            {
                client.Remove(client[i]);
            }
        }
    }
}
