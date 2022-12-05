using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCenter : Singleton<DataCenter>
{
    PlayerController playerController;

    public override void Awake()
    {
        base.Awake();
        playerController = FindObjectOfType<PlayerController>();
    }
}
