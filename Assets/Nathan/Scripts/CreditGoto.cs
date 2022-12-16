using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class CreditGoto : TouchableObject
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void OnTouch(Touch touchinfo)
        {
            SceneManager.LoadScene("CreditScene", LoadSceneMode.Single);
        }
    }
}