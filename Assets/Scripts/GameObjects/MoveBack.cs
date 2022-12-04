using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    PlayerController playerController;
    Vector3 oldPos;
    bool moveCam;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    public void GetPlayerPosition(Vector3 PlayerPose)
    {
        oldPos = PlayerPose;
    }

    private void OnMouseUp()
    {
        playerController.ChangePlace(oldPos);
        playerController.movable = moveCam;
    }
}
