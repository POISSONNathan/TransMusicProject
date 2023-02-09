using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Nathan { 
    [ExecuteInEditMode()]
    public class timeBar : MonoBehaviour
    {

        public ManagerManager gm;
        public LevelManager lm;

        public Image mask;

        public GameObject contourBar;
        public GameObject disque1;
        public GameObject disque2;
        public GameObject disque3;

        public GameObject logo;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }

        // Update is called once per frame
        void Update()
        {

            if (gm.currentLevel == 0)
            {
                float fillAmount = (float)lm.secondLevel1 / (float)lm.maxTimeLevel1;
                mask.fillAmount = fillAmount;
            }
            if (gm.currentLevel == 1)
            {
                float fillAmount = (float)lm.secondLevel2 / (float)lm.maxTimeLevel2;
                mask.fillAmount = fillAmount;
            }
            if (gm.currentLevel == 2)
            {
                float fillAmount = (float)lm.secondLevel3 / (float)lm.maxTimeLevel3;
                mask.fillAmount = fillAmount;
            }

            if (lm.inMiniGame == true)
            {
                contourBar.GetComponent<Image>().enabled = true;
                gameObject.GetComponent<Image>().enabled = true;
                mask.GetComponent<Image>().enabled = true;

                disque1.GetComponent<Image>().enabled = true;
                disque2.GetComponent<Image>().enabled = true;
                disque3.GetComponent<Image>().enabled = true;

                logo.GetComponent<Image>().enabled = true;
            }
            
            if (lm.inMiniGame == false)
            {
                contourBar.GetComponent<Image>().enabled = false;
                gameObject.GetComponent<Image>().enabled = false;
                mask.GetComponent<Image>().enabled = false;


                disque1.GetComponent<Image>().enabled = false;
                disque2.GetComponent<Image>().enabled = false;
                disque3.GetComponent<Image>().enabled = false;

                logo.GetComponent<Image>().enabled = false;
            }

        }
    }
}
