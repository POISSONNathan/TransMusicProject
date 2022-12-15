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

        private float fade = 1;
        
        // Start is called before the first frame update
        void Start()
        {
            if (type >= 0) {sr.sprite = sprites[type]; }
            
        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(vs.pause);
            if (vs.pause)
            {
                sr.color = new Color(255, 255, 255, fade);
            }
            else
            {
                sr.color = new Color(255,255,255,0);
            }

            if (vs.vipSelected.Contains(type)) { fade = 0.3f; }
        }
    }
}
