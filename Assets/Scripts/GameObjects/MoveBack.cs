using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    PlayerController playerController;
    [SerializeField] bool moveCam;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnMouseUpAsButton()
    {
        playerController.Revenir();
        playerController.movable = moveCam;
    }
}
