using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public bool drag;

    public float randomColor;
    public SpriteRenderer sr;
    public string colorObj;

    public Vector3 posStart;

    public bool trigger;

  

    public void Start()
    {

        randomColor = Random.Range(0f, 1f);
        if (randomColor >= 0.5)
        {
            sr.color = new Color(1, 0, 0);
            colorObj = "red";
        }
        else
        {
            sr.color = new Color(0, 1, 0);
            colorObj = "green";
        }

        posStart = transform.position;
    }

    private void Update() 
    {
        if (drag)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePos);
        }

        else
        {
            if (trigger == false)
            {
                transform.position = posStart;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (colorObj == "red" && collision.gameObject.tag == "redSquare")
        {
            if (!drag)
            {
                transform.position = collision.transform.position;
            }
        }

        if (colorObj == "green" && collision.gameObject.tag == "greenSquare")
        {
            if (!drag)
            {
                transform.position = collision.transform.position;
            }
        }
        trigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigger = false;
    }


}

