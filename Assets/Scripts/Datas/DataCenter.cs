using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCenter : Singleton<DataCenter>
{

    public string sceneName;
    public Vector3 playerPos;
    public Vector3 oldPos;

    public float gateBoundL = -5;
    public float gateBoundR = 5;

    public override void Awake()
    {
        base.Awake();
    }

    public void SetBounds(float boundL, float boundR)
    {
        gateBoundL = boundL;
        gateBoundR = boundR;
    }
}
