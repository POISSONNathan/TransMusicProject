using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan 
{ 
    public class lightOn : MonoBehaviour
    {
        public List<GameObject> lights;

        private LevelManager lm;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {
            lights[lm.scoreScene - 1].SetActive(true);
        }
    }
}
