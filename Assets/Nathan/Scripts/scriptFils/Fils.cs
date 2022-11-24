using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Fils : MonoBehaviour
    {
        Vector3 posStart;
        public SpriteRenderer filsFin;

        void Start()
        {
            posStart = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void OnMouseDrag()
        {
                Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                newPos.z = 0;

                transform.position = newPos;

                Vector3 direction = newPos - posStart;
                transform.right = direction * transform.lossyScale.x;

                float distance = Vector2.Distance(posStart,newPos);
                filsFin.size = new Vector2 (distance, filsFin.size.y);

                            Debug.Log(distance);

        }

    }
}
