using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan { 
public class objMagasin : MonoBehaviour
{
    public List<GameObject> listObjets;
    public int test;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < listObjets.Count; i++)
        {
            if (listObjets[i].GetComponent<objets>().stayOnObj == true)
            {
                test++;
            }
        }
    }
}
}
