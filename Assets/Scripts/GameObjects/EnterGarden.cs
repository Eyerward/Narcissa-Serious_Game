using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGarden : MonoBehaviour
{
    public bool unlocked = false;
    private void OnMouseUpAsButton()
    {
        if (unlocked)
        {
            SceneManager.LoadScene("01Fountain");
        }
        else
        {
            Debug.Log("Not Yet");
        }
    }

    public void CanEnter()
    {
        unlocked = true;
    }
}
