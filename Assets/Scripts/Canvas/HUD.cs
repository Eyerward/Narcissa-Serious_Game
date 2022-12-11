using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    PlayerController playerController;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    public void GoToMap()
    {
        SceneManager.LoadScene("MAP");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("00Gate");
    }

    public void MoveBack()
    {
        playerController.Revenir();
        playerController.movable = true;
    }
}
