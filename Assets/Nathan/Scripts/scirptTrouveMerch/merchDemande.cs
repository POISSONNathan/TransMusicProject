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

        void Start()
        {
            dd.scoreSceneNeed = 3;

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

            if (goodObj == true)
            {
                selectSpecialite();
                goodObj = false;
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
