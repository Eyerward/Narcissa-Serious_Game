using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordReveal : MonoBehaviour
{
    [SerializeField] GameObject hiddenWord;

    private void OnMouseUpAsButton()
    {
        hiddenWord.SetActive(true);
    }
}
