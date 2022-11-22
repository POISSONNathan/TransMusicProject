using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLight : MonoBehaviour
{
    public bool rotate;

    public Transform parent;

    public float rotateSpeed = 60f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (rotate == true)     
        {
            parent.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, 90) - 45);
        }
    }
}
