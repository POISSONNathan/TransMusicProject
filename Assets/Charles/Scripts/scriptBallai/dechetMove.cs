using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dechetMove : MonoBehaviour
{
    private Rigidbody2D rb;
    void Awake()
    {
        rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0.0f, -1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
