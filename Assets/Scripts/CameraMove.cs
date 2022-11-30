using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour
{
    [SerializeField] LayerMask CameraSliderLayerMask;
    public bool movable = true;
    float prevX = 0;
    private bool stopG = false;
    private bool stopD = false;


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

                    if (stopG == true)
                    {
                        if(deltaX < 0)
                        {
                            deltaX =0;
                        }
                    }else if (stopD == true)
                    {
                        if (deltaX > 0)
                        {
                            deltaX = 0;
                        }
                    }

                    Debug.Log(deltaX);
                    Camera.main.transform.Translate(deltaX, 0, 0);


                }
                prevX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
                
            }
        }
        


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WallG")){
            stopG = true;
        }else if (other.CompareTag("WallD"))
        {
            stopD = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("WallG"))
        {
            stopG = false;
        }
        else if (other.CompareTag("WallD"))
        {
            stopD = false;
        }
    }

    public Vector3 ChangePlace(Vector3 newPlace)
    {
        transform.position = newPlace;

        return transform.position;
    }

}
