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

        public float randomRotateSpawn; 

        public override void OnTouch(Touch touchInfo)
        {
            rotate = true;
        }

        public override void TouchUp()
        {
            rotate = false;
        }

        void Start()
        {
            dd.scoreSceneNeed = 1;
            dd.nextScene = "ReactionTime";

            for (int i = 0; i < 4; i++)
            {
                var currentObj = ll.lights[i].gameObject;
                if (i == 0)
                {
                    randomRotateSpawn = Random.Range(-45, 10);
                    currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                }
                if (i == 1)
                {
                    float leftOrRight;
                    leftOrRight = Random.Range(0f, 1f);

                    if (leftOrRight < 0.5)
                    {
                        randomRotateSpawn = Random.Range(-45, -10);
                        currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                    }
                    else
                    {
                        randomRotateSpawn = Random.Range(45, 10);
                        currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                    }
                }
                if (i == 2)
                {
                    randomRotateSpawn = Random.Range(-10, 45);
                    currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                }

            }
        }

        // Update is called once per frame
        void Update()
        {

            if (rotate == true)
            {
                transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, 90) - 45);
                addLightCountBool = true;
            }

            if (addLightCountBool == true && rotate == false)
            {
                addLightCountBool = false;
                addOnObj = true;
                ll.lightUseCount++;
            }

            var currentLight = ll.lights[ll.lightUseCount];
            currentLight.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);

            if (ll.lightUseCount > 0)
            {
                var lastLight = ll.lights[ll.lightUseCount - 1];
                lastLight.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            }

            if (onObj == true)
            {
                dd.scoreScene++;
                Destroy(this);
            }
        }

    }
}
