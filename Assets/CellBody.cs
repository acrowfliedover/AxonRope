using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBody : MonoBehaviour
{
    //public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        //cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Camera.main == null);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Vector2 touchPosition= touch.position;
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(touch.position);
            //Debug.Log(Camera.main.transform);
           
           curPosition.z = 0f;
            transform.position = curPosition;
        }
    }
}
