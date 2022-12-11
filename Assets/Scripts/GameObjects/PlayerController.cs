using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;
using DG.Tweening.Core.Easing;

public class PlayerController : MonoBehaviour
{
    DataCenter dataCenter;
    public bool movable = true;
    bool smooth = true;
    float prevX = 0;
    Vector3 oldPos;
    float deltaX;

    [SerializeField] float boundL = 0;
    [SerializeField] float boundR = 0;
    /*private bool stopG = false;
    private bool stopD = false;*/

    private void Awake()
    {
        dataCenter = FindObjectOfType<DataCenter>();
    }

    private void Start()
    {
    }

    void Update()
    {

        /***********MOUVEMENT CAMERA***********/
        if (movable)
        {
            if (Input.touchCount == 0)
            {
                //Debug.Log(deltaX);
                prevX = 0;
                DOTween.Kill(gameObject);
                if (smooth)
                {
                    smooth= false;
                    
                }
            }
            else
            {
                smooth = true;
                if (prevX != 0)
                {
                    deltaX = prevX - Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
                    
                    Camera.main.transform.Translate(deltaX, 0, 0);

                    //Camera.main.transform.DOMoveX(Camera.main.transform.position.x + deltaX, 0.2f);
                }
                prevX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
                
            }
            //Debug.Log(prevX);
            /******LIMITES DE MOUVEMENT******/
            if (transform.position.x <= boundL)
            {
                transform.position = new Vector3(boundL, transform.position.y, transform.position.z);
            }

            if (transform.position.x >= boundR)
            {
                transform.position = new Vector3(boundR, transform.position.y, transform.position.z);
            }
        }




    }

    public void MovableCamera()
    {
        movable = true;
    }

    /*SE CONCENTRE SUR UN OBJET PARTICULIER DANS UNE SCENE*/
    public void ChangePlace(Vector3 newPlace)
    {
        oldPos = transform.position;
        transform.position = newPlace;
        prevX = 0;
        // Debug.Log(oldPos);
    }

    /*REVIENT SUR LA SCENE PRINCIPALE*/
    public void Revenir()
    {
        transform.position = oldPos;
        prevX = 0;
        // Debug.Log(oldPos);
    }

}
