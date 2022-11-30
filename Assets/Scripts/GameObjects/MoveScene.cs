using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    [SerializeField] string sceneName;
    private void OnMouseUp()
    {
        SceneManager.LoadScene(sceneName);
    }
}
