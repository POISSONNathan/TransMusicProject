using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Nathan
{
    public class returnCredit : TouchableObject
    {
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
        public override void OnTouch(Touch touchinfo)
        {
            SceneManager.LoadScene("1Start", LoadSceneMode.Single);
        }
    }
}
