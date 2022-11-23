using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLight : MonoBehaviour
{
    public bool rotate;
    public bool addLightCountBool = false;
    public bool isActive = false;

    public Transform parent;

    public detectDrag dd;

    public float rotateSpeed = 60f;

    public SpriteRenderer sr;

    public bool addOnObj;
    public bool onObj;

    public float randomRotateSpawn;

    void Start()
    {


        for (int i = 0; i < 4; i++)
        {
            var currentObj = dd.lights[i].gameObject;
            if (i == 0)
            {
                randomRotateSpawn = Random.Range(-45, 10);
                currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
            }
            if (i == 1)
            {
                float leftOrRight;
                leftOrRight = Random.Range(0f, 1f);

                if (leftOrRight<0.5)
                {
                    randomRotateSpawn = Random.Range(-45, -10);
                    currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                }
                else
                {
                    randomRotateSpawn = Random.Range(45, 10);
                    currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
                }
            }
            if (i == 2)
            {
                randomRotateSpawn = Random.Range(-10, 45);
                currentObj.transform.localEulerAngles = new Vector3(0, 0, randomRotateSpawn);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (rotate == true)
        {
            transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, 90) - 45);
            addLightCountBool = true;
        }

        if (addLightCountBool == true && rotate == false)
        {
            addLightCountBool = false;
            addOnObj = true;
            dd.lightUseCount++;
        }

        var currentLight = dd.lights[dd.lightUseCount];
        currentLight.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);

        if (dd.lightUseCount > 0)
        {
            var lastLight = dd.lights[dd.lightUseCount - 1];
            lastLight.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
    }

}
