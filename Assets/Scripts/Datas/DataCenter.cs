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

    public int level = 0;
    public bool wireTree = false;
    public bool greenhouse = false;
    public bool observatory = false;
    public bool ginkgo = false;
    public bool grave = false;

    public override void Awake()
    {
        base.Awake();
    }

    public void SetBounds(float boundL, float boundR)
    {
        gateBoundL = boundL;
        gateBoundR = boundR;
    }

    public void LevelUp()
    {
        wireTree = false;
        greenhouse = false;
        observatory = false;
        ginkgo = false;
        grave = false;
        level++;

        if (level == 1)
        {
            wireTree = true;
        } else if (level == 2)
        {
            greenhouse = true;
        }else if (level == 3)
        {
            observatory = true;
        }else if (level == 4)
        {
            ginkgo = true;
        }else if (level == 5)
        {
            grave = true;
        }
    }
}
