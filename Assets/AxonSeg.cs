using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxonSeg : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    float judgingRadius = 2.0f;
    public GameObject Note;
    void Awake()
    {
      //  Note=
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Vector2 touchPosition= touch.position;
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Vector2 thisPosition=new Vector2(curPosition.x, curPosition.y);
            if (touch.phase == TouchPhase.Began && Vector2.Distance(thisPosition, transform.position) < judgingRadius)
            {
                score += 100;
            }
            
        }
    }
    //Instance.score+=100;

}
