using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objActive : MonoBehaviour
{
    public bool isActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
        }
        else{
            GetComponent<SpriteRenderer>().color = new Color(1,1, 1);
        }
    }
}
