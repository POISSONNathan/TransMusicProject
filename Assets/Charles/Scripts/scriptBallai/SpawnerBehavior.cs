using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(0, 6, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
