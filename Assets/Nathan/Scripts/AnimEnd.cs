using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEnd : MonoBehaviour
{

    void AlertObservers(string message)
    {
        if (message.Equals("EndAnim"))
        {
            Destroy(this.gameObject);
        }
    }

}
//zdzqF