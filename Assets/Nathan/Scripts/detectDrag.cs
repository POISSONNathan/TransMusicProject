using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nathan
{

    public class detectDrag : MonoBehaviour
{
    private Touch touch;

    /// //////////////////////////////
    public Drag currentDraggedObject;

    /// //////////////////////////////
    public Essuyer currentEssuieObject;

    /// //////////////////////////////
    public rotateLight currentRotateObject;
    public List<GameObject> lights;
    public int lightUseCount = 0;

    /// //////////////////////////////
    public List<GameObject> objPressed;
    public objActive currentObjPress;
    public int randomChoice = -1;
    public reactionTime rt;

    /// //////////////////////////////
    public activeRotation currentActiveRotate;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >0)
        {
            var tempVector = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, Camera.main.nearClipPlane);
            var tempRay = Camera.main.ScreenPointToRay(tempVector);
            var tempObject = Physics2D.Raycast(tempRay.origin,tempRay.direction);

            if (tempObject.collider != null )
            {
                /// //////////////////////////////
                currentDraggedObject = tempObject.collider.GetComponent<Drag>();
                if (currentDraggedObject != null)
                {
                    currentDraggedObject.drag = true;
                }

                 /// //////////////////////////////
                currentActiveRotate = tempObject.collider.GetComponent<activeRotation>();
                if (currentActiveRotate != null)
                {
                    currentActiveRotate.isActive = true;
                }

                /// //////////////////////////////
                currentEssuieObject = tempObject.collider.GetComponent<Essuyer>();
                if (currentEssuieObject != null)
                {
                    touch = Input.GetTouch(0);
                    if (touch.phase == TouchPhase.Moved)
                    {
                        currentEssuieObject.drag = true;
                    }
                    else 
                    {
                        currentEssuieObject.drag = false;
                    }
                }

                /// //////////////////////////////
                currentRotateObject = tempObject.collider.GetComponent<rotateLight>();
                if (currentRotateObject.gameObject == lights[lightUseCount])
                {
                    currentRotateObject.rotate = true;
                }

                /// //////////////////////////////
                currentObjPress = tempObject.collider.GetComponent<objActive>();
                if (currentObjPress.isActive == true && currentObjPress.gameObject)
                {
                    rt.score ++;
                    rt.activePossible = true;
                    currentObjPress.isActive = false;
                    rt.counterChangeColor = 0;
                }

            
            }

        }
        
        else
        {
            /// //////////////////////////////
            if(currentDraggedObject != null)
            {
                currentDraggedObject.drag = false;
            }

            /// //////////////////////////////
            if (currentRotateObject != null)
            {
                currentRotateObject.rotate = false;
            }
            if (currentActiveRotate != null)
                {
                    currentActiveRotate.isActive = false;
                }
            }
        }
    }
}

