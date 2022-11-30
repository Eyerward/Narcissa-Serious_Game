using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour
{
    [SerializeField] LayerMask CameraSliderLayerMask;
    public bool movable = true;
    float prevX = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
                    float deltaX = prevX - Camera.main.ScreenToWorldPoint(Input.mousePosition).x; ;

                    Camera.main.transform.Translate(deltaX, 0, 0);


                }
                prevX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            }
        }
        


    }

    public Vector3 ChangePlace(Vector3 newPlace)
    {
        transform.position = newPlace;

        return transform.position;
    }

}
