using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject place1;
    [SerializeField] GameObject place2;
    [SerializeField] GameObject place3;
    [SerializeField] GameObject place4;
    [SerializeField] GameObject place5;
    void Start()
    {
        if (DataCenter.Instance.wireTree) place1.SetActive(true);
        if (DataCenter.Instance.greenhouse) place2.SetActive(true);
        if (DataCenter.Instance.observatory) place3.SetActive(true);
        if (DataCenter.Instance.ginkgo) place4.SetActive(true);
        if (DataCenter.Instance.grave) place5.SetActive(true);
    }
}
