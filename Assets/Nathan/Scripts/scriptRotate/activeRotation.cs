using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeRotation : TouchableObject
{
    public bool isActive;

    public override void OnTouch(Touch touchinfo)
    {
        isActive = true;
    }

    public override void TouchUp()
    {
        isActive = false;
    }

}
