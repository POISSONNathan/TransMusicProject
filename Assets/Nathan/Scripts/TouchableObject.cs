using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan 
{
    public class TouchableObject : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public virtual void OnTouch(Touch touchInfo)
        {
            Debug.Log("Touched " + gameObject.name);
        }

        public virtual void TouchUp()
        {
            Debug.Log("Touched Ended with " + gameObject.name);

        }
    }
}
