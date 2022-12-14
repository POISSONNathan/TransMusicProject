using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickLoadScene : MonoBehaviour
{
    public bool debug = true;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        if(debug == false)
        {
            SceneManager.LoadScene(index);
        }
    }
}
