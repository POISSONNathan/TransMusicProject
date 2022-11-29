using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class ObjSale : MonoBehaviour
    {
        public SpriteRenderer sr;

        public Essuyer objEssuie;

        public float pourcent = 1f;

        public bool essuieOrNot = false;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(essuieOrNot);

            if (essuieOrNot == true )
            {
                sr.color = Color.Lerp(Color.white, Color.black, pourcent);

                if (pourcent >= 0)
                {
                    pourcent -= objEssuie.speedObj/100;
                }

            }

        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "serviette" && objEssuie.drag == true)
            {
                essuieOrNot = true;
            }
            if (collision.gameObject.tag == "serviette" && objEssuie.drag == false)
            {
                essuieOrNot = false;
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "serviette")
            {
                essuieOrNot = false;
            }
        }


    }
}
