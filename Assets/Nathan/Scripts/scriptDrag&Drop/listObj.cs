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
        private LevelManager lm;

        void Start()
        {

            lm = ManagerManager.GetManagerManager.lm;
            lm.scoreSceneNeed = dechetsVert.Count + dechetsJaune.Count;

            lm.secondMiniGame = 10;
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

            lm.scoreScene = objPoubelleVerte + objPoubelleJaune + 2;
        }
    }
}