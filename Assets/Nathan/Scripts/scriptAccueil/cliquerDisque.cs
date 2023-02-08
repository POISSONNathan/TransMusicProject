using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Nathan
{
    public class CliquerDisque : TouchableObject
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

        public GameObject fond;
        public Color startColor;
        public Color endColor;

        void Start()
        {
            gm = ManagerManager.GetManagerManager;
            lm = ManagerManager.GetManagerManager.lm;

            originScale = text.transform.localScale;

            fond.GetComponent<SpriteRenderer>().color = startColor;

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

                fond.GetComponent<SpriteRenderer>().color = startColor;

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

                    fond.GetComponent<SpriteRenderer>().color = Color.Lerp(startColor, endColor, pourcent);

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
            touchOneTime = false;
        }

        public override void TouchUp()
        {
            if (isOpen == false && touchOneTime == false && gm.introGame == false && lm.oneInfoSelected == false && lm.isScrolling == false)
            {
                text.SetActive(true);
                lm.infoOpen = true;
                touchOneTime = true;
                lm.oneInfoSelected = true;

                originPos = text.transform.position;

                Debug.Log(text.transform.position);

                if (text.transform.position.y >= 1.27f)
                {
                    zoomPos.position = new Vector3(zoomPos.position.x, originPos.y - 1.4f, zoomPos.position.z);
                }
                if (text.transform.position.y < 1.27f)
                {
                    zoomPos.position = new Vector3(zoomPos.position.x, originPos.y + 2.4f, zoomPos.position.z);
                }

                shouldZoom = true;
                zoom = true;

            }
        }
    }
}
