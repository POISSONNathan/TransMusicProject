 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class Fils : TouchableObject
    {
        public Vector3 pointStart;
        public Vector3 startPos;
        public SpriteRenderer filsFin;

        public GameObject lightOn;

        public bool move;

        void Start()
        {
            pointStart = transform.parent.position;
            startPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (move == true)
            {
                Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                newPos.z = 0;

                Collider2D[] colliders = Physics2D.OverlapCircleAll(newPos, .2f);
                foreach (Collider2D collider in colliders)
                {
                    if (collider.gameObject != gameObject)
                    {
                        UpdateFils(collider.transform.position);
                        if (transform.parent.name.Equals(collider.transform.parent.name))
                        {
                            collider.GetComponent<Fils>()?.Connected();
                            Connected();
                        }
                    }
                }
                UpdateFils(newPos);
            }
        }

        

        public override void OnTouch(Touch touchInfo)
        {
            move = true;
        }

        public override void TouchUp()
        {
            UpdateFils(startPos);
            move = false;
        }

        void Connected()
        {
            lightOn.SetActive(true);
            Destroy(this);
        }

        void UpdateFils(Vector3 newPos)
        {
            transform.position = newPos;

            Vector3 direction = newPos - pointStart;
            transform.right = direction * transform.lossyScale.x;

            float dist = Vector2.Distance(pointStart,newPos);
            filsFin.size = new Vector2 (dist , filsFin.size.y);

            Debug.Log("pointStart" + pointStart);
            Debug.Log("dist" + dist);
        }

    }
}
