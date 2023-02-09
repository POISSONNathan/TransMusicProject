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

        public List<GameObject> dialoguesFinLvl1;

        public List<GameObject> dialoguesFinLvl2;

        public List<GameObject> dialoguesFinLvl3;

        public List<GameObject> Expression;

        public GameObject chefBenevole;
        public GameObject bulle;

        public ManagerManager gm;

        public float timer;

        private bool StartD = false;

        public bool game1End = false;
        public bool game2End = false;
        public bool game3End = false;

        // Start is called before the first frame update
        void Start()
        {
            gm = FindObjectOfType<ManagerManager>().GetComponent<ManagerManager>();

        }

        // Update is called once per frame
        void Update()
        {
            if (game1End == true)
            {
                dialogues = dialoguesFinLvl1;
            }
            if (game2End == true)
            {
                //dialogues = dialoguesFinLvl2;
                this.gameObject.SetActive(false);
                gm.introGame = false;
            }
            if (game3End == true)
            {
                dialogues = dialoguesFinLvl3;
            }

            if (gm.introGame == false)
            {
                this.gameObject.SetActive(false);
            }

            if (gm.introGame == true)
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
                        timer += Time.deltaTime;

                        if (timer >=1)
                        {
                            gm.introGame = false;
                            timer = 0;
                        }
                        this.GetComponent<Animator>().Play("DialogueEnd");

                    }
                }

                if (dialogues.Count > 0 && StartD == true)
                {
                    dialogues[0].SetActive(true);
                }
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
