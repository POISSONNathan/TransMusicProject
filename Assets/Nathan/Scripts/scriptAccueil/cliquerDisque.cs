using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Nathan
{
    public class cliquerDisque : TouchableObject
    {
        private LevelManager lm;
        public ManagerManager gm;

        public bool isOpen = false;
        public bool touchOneTime = false;


        public GameObject text;
        public Vector3 originPos;
        public Vector3 originScale;
        public Vector3 scalePos;

        public Transform zoomPos;

        public bool zoom = false;

        public bool shouldZoom = false;

        public float pourcent = 0f;

        void Start()
        {
            gm = ManagerManager.GetManagerManager;
            lm = ManagerManager.GetManagerManager.lm;

            originScale = text.transform.localScale;

            scalePos = new Vector3(1.17633915f, 1.17633915f, 1.17633915f);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0 && isOpen == true && touchOneTime == false)
            {
                text.transform.position = originPos;
                text.transform.localScale = originScale;
                text.SetActive(false);
                touchOneTime = true;

                isOpen = false;
                lm.oneInfoSelected = false;
                lm.infoOpen = false;
            }

            if (Input.touchCount == 0)
            {
                touchOneTime = false;
            }

            if (shouldZoom)
            {
                if (zoom)
                {
                    pourcent += Time.deltaTime * 3f;
                    text.transform.position = Vector3.Lerp(originPos, zoomPos.position, pourcent);
                    text.transform.localScale = Vector3.Lerp(originScale, scalePos, pourcent);

                    if (pourcent >= 1f)
                    {
                        isOpen = true;
                        pourcent = 0;
                        shouldZoom = false;
                    }
                }
            }

        }

        public override void OnTouch(Touch touchinfo)
        {
            if (isOpen == false && touchOneTime == false && gm.introGame == false && lm.oneInfoSelected == false)
            {
                text.SetActive(true);
                lm.infoOpen = true;
                touchOneTime = true;
                lm.oneInfoSelected = true;

                originPos = text.transform.position;
                zoomPos.position = new Vector3(zoomPos.position.x, originPos.y + 2.4f, zoomPos.position.z);

                shouldZoom = true;
                zoom = true;
            }
        }

        public override void TouchUp()
        {
            touchOneTime = false;
        }
    }
}
