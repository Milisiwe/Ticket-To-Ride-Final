using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDropMovement : MonoBehaviour
{
    /*private bool isDragging = false;
    private Vector2 StartPos;

    private bool isOverDropZone = false;
    private GameObject DropZone;

    public GameObject Canvas;
    private GameObject StartParent;

    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas"); 
    }

    //move the card to where the mouse is if isDragging is true
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Canvas.SetParent(Canvas.transform, true);
        }
        
    }

    //when collision is made, dropzone variable is now equal to game object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        DropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        DropZone = null;
    }

    public void StartDrag()
    {
        StartParent = transform.parent.gameObject;
        StartPos = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;

        //when the object(card) is not dropped into the dropzone, return to start position
        if (isOverDropZone)
        {
            transform.SetParent(DropZone.transform, false);
        }
        else
        {
            transform.position = StartPos;
            transform.SetParent(StartParent.transform, false);
        }
    }*/
}
