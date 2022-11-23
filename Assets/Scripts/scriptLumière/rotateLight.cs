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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (rotate == true)     
        {
            parent.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, 90) - 45);
            addLightCountBool = true;
        }

        if (addLightCountBool == true && rotate == false){
            addLightCountBool = false;
            addOnObj = true;
            dd.lightUseCount++;
        }

        var currentLight = dd.lights[dd.lightUseCount];
        currentLight.GetComponent<SpriteRenderer>().color = new Color(1,0,0);

        if (dd.lightUseCount>0){
            var lastLight = dd.lights[dd.lightUseCount - 1];
            lastLight.GetComponent<SpriteRenderer>().color = new Color(1,1,1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && addOnObj == true)
        {
            onObj = true;
            addOnObj = false;
        }
    }
    // MARCHE PASSSSSSSSS

}
