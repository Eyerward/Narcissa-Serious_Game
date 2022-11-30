using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public void GoToMap()
    {
        SceneManager.LoadScene("MAP");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Place01");
    }
}
