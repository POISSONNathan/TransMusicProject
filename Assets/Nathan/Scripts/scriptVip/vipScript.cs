using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class vipScript : MonoBehaviour
    {
        public GameObject myGuest;
        
        public float speed;

        List<int> guestList = new List<int>();
        
        // Start is called before the first frame update
        void Start()
        {
            //remplir la liste
            for (int i = 0; i < 10; i++)
            {
                guestList.Add(i);
            }
            int baseCount = guestList.Count;
            Debug.Log($"Il reste {guestList.Count} personne dans la liste");

            for (int i = 0; i < baseCount; i++)
            {

                int rand = Random.Range(0, guestList.Count);
                int rdType = guestList[rand];

                Debug.Log($"On supprime le {rand}e de la liste");
                guestList.RemoveAt(rand);
                
                Debug.Log($"Il reste {guestList.Count} personne dans la liste");

                Debug.Log($"Generation d'un guest de type {rdType} ");
                Generate(rdType,i*4);
            }
            
            
        }

        // Update is called once per frame
        void Update()
        {

        }
        void Generate(int type,int move)
        {
            GameObject ceMec = Instantiate(myGuest, new Vector2(transform.position.x+move, transform.position.y) , Quaternion.identity);
            
            guestScript gs = ceMec.GetComponent<guestScript>();
            gs.type = type;

            Rigidbody2D rb = ceMec.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(-speed, 0.0f);
        }
    }
}