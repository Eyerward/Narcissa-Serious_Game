using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public bool movable = true;
    float prevX = 0;
    Vector3 oldPos;

    [SerializeField] float boundL;
    [SerializeField] float boundR;
    /*private bool stopG = false;
    private bool stopD = false;*/


    void Update()
    {

        /***********MOUVEMENT CAMERA***********/
        if (movable)
        {
            if (Input.touchCount == 0)
            {
                prevX = 0;
            }
            else
            {
                if (prevX != 0)
                {
                    float deltaX = prevX - Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
                    
                    Camera.main.transform.Translate(deltaX, 0, 0);
                }
                prevX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
                
            }
        }
        
        /******LIMITES DE MOUVEMENT******/
        if (transform.position.x <= boundL)
        {
            transform.position = new Vector3 (boundL, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= boundR)
        {
            transform.position = new Vector3(boundR, transform.position.y, transform.position.z);
        }


    }

    public void ChangePlace(Vector3 newPlace)
    {
        oldPos = transform.position;
        transform.position = newPlace;
    }

}
