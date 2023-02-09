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

        public List<GameObject> Expression;

        public GameObject chefBenevole;
        public GameObject bulle;

        public ManagerManager gm;

        private bool StartD = false;

        // Start is called before the first frame update
        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();
            if (gm.introGame == false)
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (gm.currentLevel == 0 && gm.introGame == true)
            {
                if (Input.touchCount > 0 && touchOneTime == true)
                {
                    touchOneTime = false;
                    Destroy(dialogues[0]);
                    dialogues.Remove(dialogues[0]);
                }

                if (dialogues.Count == 3 || dialogues.Count == 1)
                {
                    Expression[4].SetActive(true);
                    Expression[3].SetActive(false);
                }

                if (dialogues.Count == 2)
                {
                    Expression[4].SetActive(false);
                    Expression[3].SetActive(true);
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

            if (gm.currentLevel == 2 && (gm.lm.secondLevel1 > gm.lm.maxTimeLevel1))
            {
                Debug.Log("oui");
            }
        }

        public void DialogueStart()
        {
            StartD = true;
        }

        public void DialogueEnd()
        {

        }
    }
}
