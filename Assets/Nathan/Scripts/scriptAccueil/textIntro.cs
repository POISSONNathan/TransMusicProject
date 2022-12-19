using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class textIntro : MonoBehaviour
    {
        public accueil ac;

        public bool touchOneTime = true;

        public List<GameObject> dialogues;

        public GameObject chefBenevole;
        public GameObject bulle;

        public ManagerManager gm;

        private bool StartD = false;

        // Start is called before the first frame update
        void Start()
        {
            gm = ManagerManager.GetManagerManager;

            if (gm.introGame == false)
            {
                Destroy(this.gameObject);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0 && touchOneTime == true)
            {
                touchOneTime = false;
                Destroy(dialogues[0]);
                dialogues.Remove(dialogues[0]);
            }

            if (Input.touchCount == 0)
            {
                touchOneTime = true;

                if (dialogues.Count == 0)
                {
                    gm.introGame = false;
                    this.GetComponent<Animator>().Play("DialogueEnd");
                }
            }

            if (dialogues.Count > 0 && StartD == true)
            {
                dialogues[0].SetActive(true);
            }
            
        }

        public void DialogueStart()
        {
            StartD = true;
        }

        public void DialogueEnd()
        {
            Destroy(this.gameObject);
        }
    }
}
