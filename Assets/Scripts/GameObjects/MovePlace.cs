using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlace : MonoBehaviour
{
    PlayerController playerController;
    [SerializeField] GameObject newPlace;
    [SerializeField] bool moveCam;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnMouseUp()
    {
        playerController.ChangePlace(newPlace.transform.position);
        playerController.movable= moveCam;
        Debug.Log("Pasta");
    }
}
