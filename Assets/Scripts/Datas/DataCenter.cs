using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCenter : Singleton<DataCenter>
{
    PlayerController playerController;
    float gateBoundL = -5;
    float gateBoundR = 5;

    public override void Awake()
    {
        base.Awake();
        playerController = FindObjectOfType<PlayerController>();
    }

    public void SetBounds(float boundL, float boundR)
    {
        boundL = gateBoundL;
        boundR = gateBoundR;
    }
}
