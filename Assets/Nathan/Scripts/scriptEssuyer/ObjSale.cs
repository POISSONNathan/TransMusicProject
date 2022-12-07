using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class ObjSale : MonoBehaviour
    {
        public SpriteRenderer sr;

        public detectDrag dd;

        public Essuyer objEssuie;

        public float pourcent = 1f;

        public bool essuieOrNot = false;

        public int tempsEssuie;

        void Start()
        {
            dd.scoreSceneNeed = 5;
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(pourcent);

            if (pourcent < 0)
            {
                dd.scoreScene++; ;
                dd.nextScene = "Fils";
                Destroy(this);
            }

            if (essuieOrNot == true )
            {
                float newAlpha = Mathf.Lerp(0, 1, pourcent);
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, newAlpha);

                if (pourcent >= 0)
                {
                    pourcent -= objEssuie.speedObj/ tempsEssuie;
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
