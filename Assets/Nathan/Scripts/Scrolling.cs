using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Scrolling : MonoBehaviour
    {
        private LevelManager lm;
        public optionsManager optionsManager;

        private float _speed = 1f;
        private float _minY = -2.082973f;
        private float _maxY = 4.72166f;

        public accueil ac;

        public GameObject Trail;

        private void Start()
        {
            lm = ManagerManager.GetManagerManager.lm;
        }
        void Update()
        {
            Debug.Log(transform.position.x);
            if(transform.position.y >= 4.3 && transform.position.x <= -4.9){
                Trail.GetComponent<TrailRenderer>().enabled=true;
            }else{
                Trail.GetComponent<TrailRenderer>().enabled=false;   
            }
            if (Input.touchCount > 0 && ac.levelSelect == 3 && lm.infoOpen == false)
            {
                Touch touch = Input.GetTouch(0);

                switch (touch.phase)
                {
                    case TouchPhase.Moved:
                        lm.isScrolling = true;
                        Vector3 pos = transform.position;
                        pos.y -= touch.deltaPosition.y * -_speed * Time.deltaTime;
                        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);
                        transform.position = pos;
                        break;
                }
            }

            if (Input.touchCount == 0)
            {
                lm.isScrolling = false;
            }
        }
    }
}