using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Nathan
{
    public class guestScript : TouchableObject
    {
        public SpriteRenderer sr;
        public Rigidbody2D rb;
        public Sprite[] sprites;

        public int type;
        public bool vip;

        public vipScript vs;
        

        public bool touched = false;
        public float speed;


        // Start is called before the first frame update
        void Start()
        {
            sr.sprite = sprites[type];
            
        }

        // Update is called once per frame
        void Update()
        {
            if (!vs.pause)
            {
                rb.velocity = new Vector2(-speed, 0.0f);
            }
            else
            {
                rb.velocity = new Vector2(0.0f, 0.0f);
            }
            
        }

        

        //public override void OnTouch(Touch touchInfo)
        //    {

        //        if (!vs.pointTouch)
        //        {
        //            if (vip && !vs.vipSelected.Contains(type))
        //            {
        //                vs.vipSelected.Add(type); 

        //                //Ce qui se passe quand on touche un vip :

        //                rb.velocity = new Vector2(0.0f, 6.0f);
        //            }
        //            Debug.Log($"type : {type}  vip : {vip}");
        //            vs.pointTouch = true;
        //        }

        //    }
        //public override void TouchUp()
        //    {

        //        vs.pointTouch = false;
        //    }

    }
}
