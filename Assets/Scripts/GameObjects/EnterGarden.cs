using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGarden : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("01Fountain");
    }
}
