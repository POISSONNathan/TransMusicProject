using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listObj : MonoBehaviour
{
    /// //////////////////////////////
    public List<GameObject> objARecycler;

    public int objPoubelleVerte = -1;
    public int objPoubelleJaune = -1;

    public List<GameObject> dechetsVert;
    public List<GameObject> dechetsJaune;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objPoubelleVerte >= 0)
        {
            dechetsVert[objPoubelleVerte].SetActive(true);
        }

        if (objPoubelleJaune >= 0)
        {
            dechetsJaune[objPoubelleJaune].SetActive(true);
        }
    }
}
