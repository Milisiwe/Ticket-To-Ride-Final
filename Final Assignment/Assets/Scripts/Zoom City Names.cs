using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCityNames : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject ZoomCityName;

    public void Awake()
    {
        //find canvas where game object is located
        Canvas = GameObject.Find("Main Canvas");
    }

    public void OnHoverEnter()
    {
        //position of the enlarged image of the game object
        ZoomCityName = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y + 50) Quaternion.identity);
        ZoomCityName.transform.SetParent(Canvas.transform, false);

        //create new layer so that the game objects don't collide if there is a collider component
        ZoomCityName.layer = LayerMask.NameToLayer("Zoom");

        //new size of the zoomed game object
        RectTransform rect = ZoomCityName.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(60, 60);
    }

    // Update is called once per frame
    public void OnHoverExit()
    {
        //when not hovering over game object, destroy the new component made so that it disappears
        Destroy(ZoomCityName);
    }
}
