using System.Collections;
using System.Collections.Generic;
using Nathan;
using UnityEngine;

namespace Nathan
{
    public class listObj : MonoBehaviour
    {
        /// //////////////////////////////
        public List<GameObject> objARecycler;

        public int objPoubelleVerte = -1;
        public int objPoubelleJaune = -1;

        public List<GameObject> dechetsVert;
        public List<GameObject> dechetsJaune;

        public detectDrag dd;

        public GameObject objSelected;

        void Start()
        {
            dd.scoreSceneNeed = dechetsVert.Count + dechetsJaune.Count;
        }

        // Update is called once per frame
        void Update()
        {
            if (objPoubelleVerte >= 0)
            {
                dechetsVert[objPoubelleVerte].SetActive(true);
            }

            if (objPoubelleJaune >= 0)
            {
                dechetsJaune[objPoubelleJaune].SetActive(true);
            }

            dd.scoreScene = objPoubelleVerte + objPoubelleJaune + 2;
        }
    }
}
