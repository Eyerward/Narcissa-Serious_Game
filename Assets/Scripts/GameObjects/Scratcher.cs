using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;
using UnityEngine.UIElements;

public class Scratcher : MonoBehaviour
{
    int scratchCount = 0;

    private void OnMouseDown()
    {
        if (scratchCount >= 3)
        {
            transform.eulerAngles = new Vector3(0, 0, -4);
            DOTween.Kill(gameObject);
            Quaternion quat = Quaternion.Euler(0, 0, 0);
            transform.DOLocalRotateQuaternion(quat, 0.5f).SetEase(Ease.OutBounce);
        }
        else
        {
            scratchCount++;
        }
    }
}
