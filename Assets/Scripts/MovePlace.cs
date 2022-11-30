using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlace : MonoBehaviour
{
    CameraMove cameraMove;
    Vector3 statuePlace = new Vector3(0, 0, 5.5f);

    private void Awake()
    {
        cameraMove = FindObjectOfType<CameraMove>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        cameraMove.ChangePlace(statuePlace);
        cameraMove.movable= false;
    }
}
