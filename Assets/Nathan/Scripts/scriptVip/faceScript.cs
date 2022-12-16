using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{
    public class faceScript : MonoBehaviour
    {

        public SpriteRenderer sr;
        public Sprite[] sprites;
        public vipScript vs;

        public int type;
        // Start is called before the first frame update
        void Start()
        {
            if (type >= 0) {sr.sprite = sprites[type]; }
            sr.color = new Color(255, 255, 255, 1);
        }

        // Update is called once per frame
        void Update()
        {
            
            if (vs.pause)
            {
                sr.color = new Color(255, 255, 255, 1);
            }
            else
            {
                sr.color = new Color(0,0,0,0);
            }
        }
    }
}
