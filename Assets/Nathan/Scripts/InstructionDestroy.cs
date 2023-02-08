using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 || !MusicManagerSingleton.Instance.aides)
        {
            Destroy(this.gameObject);
        }
    }
}
