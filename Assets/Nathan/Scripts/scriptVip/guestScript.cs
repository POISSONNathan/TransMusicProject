using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Nathan
{
    public class guestScript : MonoBehaviour
    {
        public SpriteRenderer sr;
        public Rigidbody2D rb;
        public Sprite[] sprites;

        public int type;
        public bool vip;

        public vipScript vs;
        

        
        public float speed;


        // Start is called before the first frame update
        void Start()
        {
            sr.sprite = sprites[type];
            
        }

        // Update is called once per frame
        void Update()
        {
            if (vs.pause)
            {
                rb.velocity = new Vector2(0.0f, 0.0f);
            }
            else
            {

                

                if (vs.accelererFile == true)
                {
                    rb.velocity = new Vector2(-speed * 3, 0.0f);
                }
                else
                {
                    rb.velocity = new Vector2(-speed, 0.0f);
                }

            }
            
        }

        

        


    }
}
