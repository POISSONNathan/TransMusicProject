using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class SpawnerBehavior : MonoBehaviour
    {
        // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
        public GameObject myPrefab1;
        public GameObject myPrefab2;
        public GameObject myPrefab3;
        // Start is called before the first frame update
        void Start()
        {
            Instantiate(myPrefab1, transform.position, Quaternion.identity);
            Instantiate(myPrefab2, new Vector3 (transform.position.x, transform.position.y + 3, transform.position.z), Quaternion.identity);
            Instantiate(myPrefab3, new Vector3(transform.position.x, transform.position.y + 6, transform.position.z), Quaternion.identity);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
