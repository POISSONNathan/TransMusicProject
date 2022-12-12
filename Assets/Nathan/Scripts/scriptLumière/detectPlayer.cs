using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{
    public class detectPlayer : MonoBehaviour
{
    public rotateLight rl;
    public BoxCollider2D bc;

    void Start()
    {
        bc.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (rl.addOnObj == true)
        {
            bc.enabled = true;
        }
            if (rl.addOnObj == false)
            {
                bc.enabled = false;
            }
        }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rl.onObj = true;
        }
    }
}
}