using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Scrolling : MonoBehaviour
    {
        private float _speed = 1f;
        private Vector3 _fingerStart;
        private Vector3 _fingerEnd;
        private float _minY = 2.017774f;
        private float _maxY = 4.72166f;

        public accueil ac;

        void Update()
        {
            if (Input.touchCount > 0 && ac.levelSelect == 3)
            {
                Touch touch = Input.GetTouch(0);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        _fingerStart = touch.position;
                        break;
                    case TouchPhase.Stationary:
                    case TouchPhase.Moved:
                        Vector3 pos = transform.position;
                        pos.y -= touch.deltaPosition.y * _speed * Time.deltaTime;
                        pos.y = Mathf.Clamp(pos.y, _minY, _maxY);
                        transform.position = pos;
                        break;
                }
            }
        }
    }
}