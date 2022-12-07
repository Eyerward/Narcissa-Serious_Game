using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;

public class Wheel : MonoBehaviour
{
    public float numValue;
    public float rotate= 0;

    private void Start()
    {
        numValue = 0;
        numValue.ToString();
    }
    private void OnMouseDown()
    {
        rotate -= 36f;
        //if (rotate <= -360) rotate = 0;
        DOTween.Kill(gameObject);
        Quaternion quat = Quaternion.Euler(rotate, 0, 0);
        transform.DOLocalRotateQuaternion(quat, 0.5f).SetEase(Ease.OutBounce);
        Debug.Log(rotate);
    }

    void ChangeValue()
    {
        numValue++;
    }

    private void Update()
    {

    }
}
