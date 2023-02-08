using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickLoadScene : MonoBehaviour
{
    public bool startThisScene = true;
    public int index;
    // Start is called before the first frame update
    void Start()
    {

        if(startThisScene == false)
        {
            SceneManager.LoadScene(index);
        }
    }
    
}
