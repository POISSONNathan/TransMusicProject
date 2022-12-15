using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class vipScript : MonoBehaviour
    {
        public guestScript myGuest;

        public faceScript myFace;

        public bool pointTouch = false;

        public bool drag = false;

        public bool pause;

        private bool vipOuPas;

        List<int> guestList = new List<int>();
        List<int> vipList = new List<int>();
        public List<int> vipSelected = new List<int>();

        public Transform[] target;

        public LevelManager lm;

        public bool accelererFile = false;

        // Start is called before the first frame update
        void Start()
        {

            pause = true;

            lm = ManagerManager.GetManagerManager.lm;
            lm.scoreSceneNeed = 1;


            //remplir la liste
            for (int i = 0; i < 10; i++)
            {
                guestList.Add(i);
            }
            int baseCount = guestList.Count;
                Debug.Log($"Il reste {guestList.Count} personne dans la liste");

            vipList = StaticInt.ReturnXRandom(3, 0, guestList.Count);
                Debug.Log($"les vip sont{vipList[0]} - {vipList[1]} - {vipList[2]}");

            for (int i = 0; i < 3; i++)
            {
                faceScript ceVisage = Instantiate(myFace, target[i].position, Quaternion.identity);
                ceVisage.type = vipList[i];
                ceVisage.GetComponent<SpriteRenderer>().sortingOrder = 100;
                ceVisage.vs = this;
            } 
            
            for (int i = 0; i < baseCount; i++)
            {
                int rand = Random.Range(0, guestList.Count);
                int rdType = guestList[rand];

                    //Debug.Log($"On supprime le {rand}e de la liste");
                guestList.RemoveAt(rand);

                    //Debug.Log($"Il reste {guestList.Count} personne dans la liste");

                    //Debug.Log($"Generation d'un guest de type {rdType} ");
                if (vipList.Contains(rdType)) {  vipOuPas = true; } 
                else {  vipOuPas = false; }

                Generate(rdType,i*3, vipOuPas);
            }
        }



        // Update is called once per frame
        void Update()
        {
            
            if (vipSelected.Count == 3)
            {
                Debug.Log("gagné");
                lm.GoToNextScene();
            }

     


        }
        void Generate(int type,int move,bool vip)
        {
            guestScript ceMec = Instantiate(myGuest, new Vector2(transform.position.x+move, transform.position.y) , Quaternion.identity);
            ceMec.type = type;
            ceMec.vip = vip;
            
            Rigidbody2D rb = ceMec.GetComponent<Rigidbody2D>();

            if (vip)
            {
                ceMec.GetComponent<BoxCollider2D>().enabled = true;
            }

            ceMec.vs = this;            
        }
    }
}