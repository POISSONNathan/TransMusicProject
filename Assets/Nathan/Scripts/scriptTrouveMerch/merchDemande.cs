using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan {

    public class merchDemande : MonoBehaviour
    {
        private List<string> listColor = new List<string>();
        private List<string> listForme = new List<string>();
        private List<string> listNombreForme = new List<string>();

        private int randomColor;
        private int randomForme;
        private int randomNombreForme;

        public string colorSelected;
        public string formeSelected;
        public string nombreFormeSelected;

        public bool selectObj = false;

        public bool goodObj = false;

        public detectDrag dd;

        public GameObject color1;
        public GameObject color2;

        public GameObject logo1;
        public GameObject logo2;

        public GameObject colorLogo1;
        public GameObject colorLogo2;

        public GameObject currentObjDrag;

        private LevelManager lm;

        public GameObject bulle;
        public GameObject client;


        void Start()
        {

            lm = ManagerManager.GetManagerManager.lm;
            lm.scoreSceneNeed = 2;

            listColor.Add("orange");
            listColor.Add("bleu");

            listForme.Add("lestrans");
            listForme.Add("transmusical");

            listNombreForme.Add("violet");
            listNombreForme.Add("jaune");

            randomColor = Random.Range(0, listColor.Count);
            colorSelected = listColor[randomColor];

            randomForme = Random.Range(0, listForme.Count);
            formeSelected = listForme[randomForme];

            randomNombreForme = Random.Range(0, listNombreForme.Count);
            nombreFormeSelected = listNombreForme[randomNombreForme];

            selectObj = true;
        } 

        // Update is called once per frame
        void Update()
        {
            if (lm.scoreScene < lm.scoreSceneNeed)
            {
                if (colorSelected == "orange")
                {
                    color1.SetActive(false);
                    color2.SetActive(true);
                }
                if (colorSelected == "bleu")
                {
                    color1.SetActive(true);
                    color2.SetActive(false);
                }

                if (formeSelected == "lestrans")
                {
                    logo1.SetActive(false);
                    logo2.SetActive(true);
                }
                if (formeSelected == "transmusical")
                {
                    logo1.SetActive(true);
                    logo2.SetActive(false);
                }

                if (nombreFormeSelected == "violet")
                {
                    colorLogo1.SetActive(true);
                    colorLogo2.SetActive(false);
                }
                if (nombreFormeSelected == "jaune")
                {
                    colorLogo1.SetActive(false);
                    colorLogo2.SetActive(true);
                }
            }
            else
            {
                color1.SetActive(false);
                color2.SetActive(false);
                logo1.SetActive(false);
                logo2.SetActive(false);
                colorLogo1.SetActive(false);
                colorLogo2.SetActive(false);
            }

            if (lm.scoreScene < lm.scoreSceneNeed)
            {
                if (goodObj == true)
                {
                    selectSpecialite();
                    goodObj = false;
                }
            }
            else
            {
                Destroy(bulle.gameObject);
                Destroy(client.gameObject);
            }
        }

        private void selectSpecialite()
        {
            randomColor = Random.Range(0, listColor.Count);
            colorSelected = listColor[randomColor];

            randomForme = Random.Range(0, listForme.Count);
            formeSelected = listForme[randomForme];

            randomNombreForme = Random.Range(0, listNombreForme.Count);
            nombreFormeSelected = listNombreForme[randomNombreForme];
        }
    }
}
