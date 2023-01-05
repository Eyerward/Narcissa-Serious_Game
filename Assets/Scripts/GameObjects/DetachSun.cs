using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;

public class DetachSun : MonoBehaviour
{
    [SerializeField] GameObject doorLock;

    private void OnMouseUpAsButton()
    {
        doorLock.SetActive(true);
        AnimDetach();
    }

    void AnimDetach()
    {
        transform.DORotate(new Vector3(0, 0, 720), 2f, RotateMode.FastBeyond360)
            .SetEase(Ease.InCubic);
        transform.DOMoveY(-10, 1f)
            .SetDelay(1f)
            .SetEase(Ease.InBack)
            .OnComplete(EndAnim);
    }

    void EndAnim()
    {
        DOTween.Kill(gameObject);
        Destroy(gameObject);
    }
}
