
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;

public class Wheel : MonoBehaviour
{
    PadLock padLock;
    public int numValue;
    public float rotate= 0;
    public bool stillUnlocked = true;

    private void Awake()
    {
        padLock = FindObjectOfType<PadLock>();
    }

    void Start()
    {
        numValue = 0;
    }

    private void OnMouseDown()
    {
        if (stillUnlocked)
        {
            rotate -= 36f;
            if (rotate <= -360) rotate = 0;
            DOTween.Kill(gameObject);
            Quaternion quat = Quaternion.Euler(rotate, 0, 0);
            transform.DOLocalRotateQuaternion(quat, 0.5f).SetEase(Ease.OutBounce);
            ChangeValue();
        }
    }

    void ChangeValue()
    {
        numValue++;
        if (numValue >= 10)
        {
            numValue = 0;
        }
        padLock.TryToUnlock();
    }

    public void PadUnlocked()
    {
        DOTween.Kill(gameObject);
        stillUnlocked = false;
    }
}
