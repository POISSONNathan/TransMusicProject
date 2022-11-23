using UnityEngine;

namespace Nathan
{
    public class ObjSale : MonoBehaviour
    {
        public SpriteRenderer sr;

        public Essuyer objEssuie;

        public float pourcent = 1f;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (objEssuie.essuieOrNot == true && objEssuie.drag == true)
            {
                sr.color = Color.Lerp(Color.white, Color.black, pourcent);

                if (pourcent >= 0)
                {
                    pourcent -= 0.001f;
                }

            }





        }


    }
}
