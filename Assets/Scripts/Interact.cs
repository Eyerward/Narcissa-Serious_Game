using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    GameManager gameManager;

    private void Awake()
    {
        gameManager= FindObjectOfType<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if ()
        //{
        //    Collect();
        //}
    }

    private void OnMouseDown()
    {
        Collect();
    }

    void Collect()
    {
        Destroy(gameObject);
        gameManager.valeur++;
        Debug.Log(gameManager.valeur);
    }
}
