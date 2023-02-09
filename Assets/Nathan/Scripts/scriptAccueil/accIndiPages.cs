using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{


    public class accIndiPages : MonoBehaviour
    {
        public List<GameObject> bouttons;

        public GameObject bouttonRose;

        public accueil ac;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            bouttonRose.transform.position = bouttons[ac.levelSelect].transform.position;
        }
    }
}
