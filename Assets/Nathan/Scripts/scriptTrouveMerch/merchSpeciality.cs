using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{

    public class merchSpeciality : TouchableObject
    {
        public string color;
        public string logo;
        public string colorLogo;
    
        public GameObject Perso;

        public merchDemande md;

        public bool drag = false;

        public Vector3 posStart;
        private LevelManager lm;

        public bool goodTrigger = false;

        public SpriteRenderer sr;

        void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
            posStart = transform.position;

            sr = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {

            if (drag)
            {
                Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(MousePos);
            }

            if (!drag && !goodTrigger)
            {
                transform.position = posStart;
            }
        }

        public override void OnTouch(Touch touchinfo)
        {
            if (md.currentObjDrag == null)
            {
                md.currentObjDrag = this.gameObject;
                drag = true;
                sr.sortingOrder = 10;
            }
        }

        public override void TouchUp()
        {
            drag = false;
            md.currentObjDrag = null;
            sr.sortingOrder = 0;
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "client" && md.colorSelected == color && md.formeSelected == logo && md.nombreFormeSelected == colorLogo)
            {
                goodTrigger = true;
                if (!drag)
                {
                    Debug.Log("fer");
                    md.goodObj = true;
                    lm.scoreScene++;
                    Perso.GetComponent<Animator>().Play("CharaMerch");

                    if (lm.scoreScene == lm.scoreSceneNeed)
                    {
                        md.thisGameFish = true;
                    }
                    transform.position = posStart;
				}
            }
        }
		private void OnTriggerExit2D(Collider2D collision)
		{
            if (goodTrigger == true)
            {
                goodTrigger = false;
            }
        }
	}
}
