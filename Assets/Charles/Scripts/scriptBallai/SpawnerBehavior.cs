using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spaceCharles
{
    public class SpawnerBehavior : MonoBehaviour
    {
        // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
        public GameObject myPrefab;
        // Start is called before the first frame update
        void Start()
        {
            Instantiate(myPrefab, transform.position, Quaternion.identity);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
