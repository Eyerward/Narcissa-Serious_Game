using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;
using UnityEngine.UIElements;

public class Scratcher : MonoBehaviour
{
    [SerializeField] GameObject scratchFX;
    int scratchCount = 0;

    private void OnMouseDown()
    {
        if (scratchCount >= 4)
        {
            DOTween.Kill(gameObject);
            GameObject Burst = Instantiate(scratchFX);
            Burst.transform.position = transform.position;
            Destroy(gameObject);
        }
        else
        {
            scratchCount++;
            transform.eulerAngles = new Vector3(0, 0, scratchCount*8);
            DOTween.Kill(gameObject);
            Quaternion quat = Quaternion.Euler(0, 0, 0);
            transform.DOLocalRotateQuaternion(quat, 0.5f).SetEase(Ease.OutElastic);
        }
    }
}
