using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Essuyer : MonoBehaviour
{

    public bool drag;

    public Vector3 posStart;

    public bool trigger;

    public float pourcent;

    public bool essuieOrNot;

    public Rigidbody2D rb;

    private void OnMouseDown()
    {
        drag = true;
    }

    private void OnMouseUp()
    {
        drag = false;
    }

    public void Start()
    {
    

        posStart = transform.position;
    }

    private void Update()
    {
        if (drag)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePos);
        }

        Debug.Log(rb.velocity);     

     
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "objSale")
        {
            essuieOrNot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "objSale")
        {
            essuieOrNot = false;
        }
    }
}


