using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nathan
{
    public class DiskAnimStop : TouchableObject
    {
        public GameObject Disk;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnTouch(Touch touchinfo)
        {
            Debug.Log("oui");
            this.GetComponent<Animator>().Play("DiskFirstAnim");
        }

    }
}
