using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Nathan
{
    public class guestScript : MonoBehaviour
    {
        public SpriteRenderer sr;
        public Sprite Sprite_0;
        public Sprite Sprite_1;
        public Sprite Sprite_2;
        public Sprite Sprite_3;
        public Sprite Sprite_4;
        public Sprite Sprite_5;
        public Sprite Sprite_6;
        public Sprite Sprite_7;
        public Sprite Sprite_8;
        public Sprite Sprite_9;

        public int type;


        // Start is called before the first frame update
        void Start()
        {
            sr = gameObject.GetComponent<SpriteRenderer>();

            switch (type)
            {
                case  0:
                    sr.sprite = Sprite_0;
                    break;
                case 1:
                    sr.sprite = Sprite_1;
                    break;
                case 2:
                    sr.sprite = Sprite_2;
                    break;
                case 3:
                    sr.sprite = Sprite_3;
                    break;
                case 4:
                    sr.sprite = Sprite_4;
                    break;
                case 5:
                    sr.sprite = Sprite_5;
                    break;
                case 6:
                    sr.sprite = Sprite_6;
                    break;
                case 7:
                    sr.sprite = Sprite_7;
                    break;
                case 8:
                    sr.sprite = Sprite_8;
                    break;
                case 9:
                    sr.sprite = Sprite_9;
                    break;
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        
    }
}
