using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Nathan
{
    public class guestScript : TouchableObject
    {
        public SpriteRenderer sr;
        public Sprite[] sprites;

        public int type;
        public bool vip;

        public vipScript vs;

        public bool touched = false;
       

        // Start is called before the first frame update
        void Start()
        {
            sr.sprite = sprites[type];
        }

        // Update is called once per frame
        void Update()
        {
            
            
        }
        public override void OnTouch(Touch touchInfo)
            {


            if (!vs.pointTouch)
            {
                Debug.Log($"type : {type}  vip : {vip}");
                        vs.pointTouch = true;
                    }
            
            }
        public override void TouchUp()
            {
                
                vs.pointTouch = false;
            }
        
    }
}
