using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class switchOptions : TouchableObject
    {

        public SpriteRenderer sr;
        public Sprite off;
        public Sprite on;
        public optionsManager OM;
        public string type;

        public bool state;

        public bool isTouched;
        // Start is called before the first frame update
        void Start()
        {
            sr.sprite = state ? on : off;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnTouch(Touch touchInfo)
        {
            if (!isTouched)
            {
                isTouched = true;
                Switch();
            }
        }

        public override void TouchUp()
        {
            isTouched = false;
        }

        public void Switch()
        {
            state = !state;
            sr.sprite = state ? on : off;
            OM.Mute(type,state);
            //si le state du switch est vrai alors son sprite passe en on et inversement
        }
    }
}
