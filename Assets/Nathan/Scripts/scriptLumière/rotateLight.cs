using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class rotateLight : TouchableObject
    {
        public bool rotate;
        public bool addLightCountBool = false;
        public bool isActive = false;

        public Transform parent;

        public detectDrag dd;

        public listLight ll;

        public float rotateSpeed = 60f;

        public SpriteRenderer sr;

        public bool addOnObj;
        public bool onObj;

        public GameObject rayonLumiere;

        public Color colorUnSellect;

        public override void OnTouch(Touch touchInfo)
        {
            rotate = true;
            addOnObj = false;
        }

        public override void TouchUp()
        {
            rotate = false;
            addOnObj = true;
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (rotate == true)
            {
                transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, 90) - 45);
                addLightCountBool = true;
            }


            if (onObj == true)
            {
                dd.scoreScene++;
                Destroy(this);
            }
        }

    }
}
